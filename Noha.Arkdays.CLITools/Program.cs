using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CommandLine;

namespace Noha.Arkdays.CLITools
{
    class Program
    {
        // TODO: support dynamic discovering
        // private static Type[] LoadVerbs()
        // {
        //     return Assembly.GetExecutingAssembly().GetTypes()
        //         .Where(t => t.GetCustomAttribute<VerbAttribute>() != null).ToArray();
        // }

        public static async Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<
                HotUpdate.Options,
                DownloadTable.Options,
                GenerateTypes.Options
            >(args)
                .MapResult(
                    (HotUpdate.Options opt) => HotUpdate.Handle(opt),
                    (DownloadTable.Options opt) => DownloadTable.Handle(opt),
                    (GenerateTypes.Options opt) => GenerateTypes.Handle(opt),
                    err =>
                    {
                        err.Output();
                        return Task.CompletedTask;
                    });
        }
    }
}
