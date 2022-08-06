﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ExportDto
{
    [XmlType("Footballer")]
    public class ExportXmlCoachFootballerDto
    {
        public string Name { get; set; }

        public string Position { get; set; }
    }
}
