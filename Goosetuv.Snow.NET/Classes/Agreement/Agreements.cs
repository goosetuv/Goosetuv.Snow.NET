﻿using System;
using System.Collections.Generic;

namespace Goosetuv.Snow.NET.Classes.Agreement
{
    public class Agreements
    {
        public string Type { get; set; }
        public List<Metum> Meta { get; set; }
        public List<Link> Links { get; set; }
        public List<Data> Body { get; set; }

        public class Metum
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public object Value { get; set; }
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
            public int? MasterId { get; set; }
            public string Name { get; set; }
            public string AgreementType { get; set; }
            public string AgreementNumber { get; set; }
            public string Contractor { get; set; }
            public DateTime? ActivePeriodFrom { get; set; }
            public DateTime? ActivePeriodTo { get; set; }
            public string Organization { get; set; }
            public bool IsSubscription { get; set; }
            public bool AutomaticLicenseUpgrades { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public List<Link> Links { get; set; }
            public Data Body { get; set; }
        }

    }
}
