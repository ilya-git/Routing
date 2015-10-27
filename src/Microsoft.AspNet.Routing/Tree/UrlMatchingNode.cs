﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.Routing.Tree
{
    public class UrlMatchingNode
    {
        public UrlMatchingNode(int length)
        {
            Length = length;

            ExactMatches = new List<UrlMatchingEntry>();
            Literals = new Dictionary<string, UrlMatchingNode>(StringComparer.OrdinalIgnoreCase);
        }

        public int Length { get; }

        // These entries need to be sorted by precedence then template
        public List<UrlMatchingEntry> ExactMatches { get; }

        public List<UrlMatchingEntry> InexactMatches { get; }

        public Dictionary<string, UrlMatchingNode> Literals { get; }

        public UrlMatchingNode ConstrainedParameters { get; set; }

        public UrlMatchingNode Parameters { get; set; }

        public UrlMatchingNode ConstrainedCatchAlls { get; set; }

        public UrlMatchingNode CatchAlls { get; set; }
    }
}