﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Data.Entity.Query.ExpressionTranslators;

namespace EntityFramework7.Npgsql.Query.Methods
{
    public class MathCeilingTranslator : MultipleOverloadStaticMethodCallTranslator
    {
        public MathCeilingTranslator()
            : base(typeof(Math), "Ceiling", "CEILING")
        {
        }
    }
}
