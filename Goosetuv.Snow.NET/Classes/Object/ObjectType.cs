﻿using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Object
{
    public class ObjectType
    {
        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public Data Body { get; set; }

        public class Metum
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public List<Context> Value { get; set; }
        }

        public class Context
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Link
        {
            public string Type { get; set; }
            public string Href { get; set; }
            public string Method { get; set; }
            public string Rel { get; set; }
            public string Title { get; set; }
        }

        public class Data
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
