#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ICSharpCode.Decompiler.CSharp.OutputVisitor;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.TypeSystem;

namespace Noha.Arkdays.CLITools
{
    public class CSharpOutputVisitor : ICSharpCode.Decompiler.CSharp.OutputVisitor.CSharpOutputVisitor
    {
        public CSharpOutputVisitor(TextWriter textWriter, CSharpFormattingOptions formattingPolicy)
            : base(textWriter, formattingPolicy)
        {
        }

        protected override void WriteAttributes(IEnumerable<AttributeSection> attributes)
        {
        }

        public override void VisitUsingDeclaration(UsingDeclaration usingDeclaration)
        {
            if (usingDeclaration.Namespace == "Il2CppDummyDll")
            {
                return;
            }
            base.VisitUsingDeclaration(usingDeclaration);
        }

        // protected override void WriteMethodBody(BlockStatement body, BraceStyle style) { }
        // public override void VisitMethodDeclaration(MethodDeclaration methodDeclaration) { }
        // public override void VisitConstructorDeclaration(ConstructorDeclaration constructorDeclaration) { }
        // public override void VisitConstructorInitializer(ConstructorInitializer constructorInitializer) { }
        // public override void VisitDestructorDeclaration(DestructorDeclaration destructorDeclaration) { }
    }
}