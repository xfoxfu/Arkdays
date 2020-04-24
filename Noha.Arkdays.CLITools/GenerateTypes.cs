using CommandLine;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;
using System.Collections.Generic;
using ICSharpCode.Decompiler.CSharp.Transforms;
using ICSharpCode.Decompiler.CSharp.Syntax;
using System.Text.RegularExpressions;
using ICSharpCode.Decompiler.CSharp.OutputVisitor;

namespace Noha.Arkdays.CLITools
{
    public static class GenerateTypes
    {

        [Verb("generate-types", HelpText = "Generate type declarations from DummyDLL.")]
        public class Options
        {
            [Option('i', "source", Required = true, HelpText = "DummyDLL")]
            public string SourceDir { get; set; } = "";
            [Option('o', "output", Required = true, HelpText = "Output directory")]
            public string OutDir { get; set; } = "";
            [Option('c', "class", Required = true, HelpText = "Class to be generated", Separator = ' ')]
            public IEnumerable<string> Class { get; set; } = new List<string>() { };
        }

        private static List<FullTypeName> TypesToExport { get; set; } = new List<FullTypeName>();
        private static List<string> ExportTypeNames { get; set; } = new List<string>();

        public static Task Handle(Options options)
        {
            var origDir = Environment.CurrentDirectory; // protect workdir
            Environment.CurrentDirectory = origDir + "/" + options.SourceDir;

            var decompiler = new CSharpDecompiler("Assembly-CSharp.dll", new DecompilerSettings());
            var tyList = FlatNamespaces(decompiler.TypeSystem.RootNamespace.GetChildNamespace("Torappu"))
                .Concat(FlatNamespaces(decompiler.TypeSystem.RootNamespace.GetChildNamespace("HGSDK")))
                .SelectMany(ns => ns.Types);
            CreateDefaultExportNames();

            foreach (var type in tyList)
            {
                if (options.Class.Contains(type.Name))
                // ExportTypeNames.Contains(type.Name)) ||
                // type.Name.EndsWith("Request") ||
                // type.Name.EndsWith("Response") ||
                // type.Name.EndsWith("Data"))
                {
                    if (type.IsCompilerGeneratedOrIsInCompilerGeneratedClass())
                    {
                        continue;
                    }
                    AddToExportList(type.FullTypeName);
                    //         foreach (var field in type.Properties)
                    //         {
                    //             if (field.ReturnType.Namespace.StartsWith("Torappu"))
                    //             {
                    //                 var m = tyList.FirstOrDefault(t => t.FullName == field.ReturnType.FullName)?.FullTypeName;
                    //                 if (m == null)
                    //                 {
                    //                     Console.WriteLine("Not Found = {0}", field.ReturnType.FullName);
                    //                 }
                    //                 else
                    //                 {
                    //                     AddToExportList(m.Value);
                    //                 }
                    //             }
                    //         }
                    //         foreach (var field in type.Fields)
                    //         {
                    //             if (field.ReturnType.Namespace.StartsWith("Torappu"))
                    //             {
                    //                 var m = tyList.FirstOrDefault(t => t.FullName == field.ReturnType.FullName)?.FullTypeName;
                    //                 if (m == null)
                    //                 {
                    //                     Console.WriteLine("Not Found = {0}", field.ReturnType.FullName);
                    //                 }
                    //                 else
                    //                 {
                    //                     AddToExportList(m.Value);
                    //                 }
                    //             }
                    //         }
                }
            }

            Environment.CurrentDirectory = origDir + "/" + options.OutDir;
            foreach (var type in TypesToExport)
            {
                WriteToFile(type, decompiler.DecompileType(type));
            }

            return Task.CompletedTask;
        }

        private static IEnumerable<INamespace> FlatNamespaces(INamespace ns)
        {
            var list = new List<INamespace>() { ns };
            list.AddRange(ns.ChildNamespaces.SelectMany(cns => FlatNamespaces(cns)));
            return list;
        }

        private static void CreateDefaultExportNames()
        {
            // ExportTypeNames.Add("NetworkRouterConfig");
            // ExportTypeNames.Add("HotUpdateInfo");
            // ExportTypeNames.Add("CharacterData");
            // ExportTypeNames.Add("ResponseError");
            // ExportTypeNames.Add("ItemBundle");
            // ExportTypeNames.Add("PlayerDeltaResponse");
        }

        private static void AddToExportList(FullTypeName type)
        {
            if (!TypesToExport.Contains(type))
            {
                TypesToExport.Add(type);
            }
        }

        private static void WriteToFile(FullTypeName type, SyntaxTree content)
        {
            var filename = Path.Join(type.ReflectionName.Replace('.', '/') + ".cs");
            Utils.EnsureDirectory(filename);
            try
            {
                using (var file = new FileStream(filename, FileMode.CreateNew))
                {
                    using (var writer = new StreamWriter(file))
                    {
                        content.AcceptVisitor(new CSharpOutputVisitor(writer, FormattingOptionsFactory.CreateAllman()));
                    }
                }
            }
            catch { }
        }
    }
}
