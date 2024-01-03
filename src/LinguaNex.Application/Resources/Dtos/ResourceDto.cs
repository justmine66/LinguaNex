﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaNex.Resources.Dtos
{
    public class ResourceDto
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public long CultureId { get; set; }
        public string ProjectId { get; set; }
    }
}
