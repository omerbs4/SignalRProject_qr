﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.FeatureDto
{
    public class UpdateFeatureDto
    {
        public int FeatureID { get; set; }
        public string Title1 { get; set; }
        public string Desc1 { get; set; }

        public string Title2 { get; set; }
        public string Desc2 { get; set; }

        public string Title3 { get; set; }
        public string Desc3 { get; set; }
    }
}
