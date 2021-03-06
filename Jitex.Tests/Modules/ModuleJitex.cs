﻿using System.Collections.Generic;
using System.Reflection;
using Jitex.JIT.Context;

namespace Jitex.Tests.Modules
{
    public class ModuleJitex : JitexModule
    {
        public static IList<MethodBase> MethodsCompiled { get; set; }
        public static IList<int> TokensCompiled { get; set; }

        static ModuleJitex()
        {
            TokensCompiled = new List<int>();
            MethodsCompiled = new List<MethodBase>();
        }

        protected override void MethodResolver(MethodContext context)
        {
            if (context.Method.Module == GetType().Module)
                MethodsCompiled.Add(context.Method);
        }

        protected override void TokenResolver(TokenContext context)
        {
            if (context.Module == GetType().Module)
                TokensCompiled.Add(context.MetadataToken);
        }
    }
}
