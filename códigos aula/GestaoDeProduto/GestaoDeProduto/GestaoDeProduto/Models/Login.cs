﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Models
{
    public class Login
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string role { get; set; }
    }
}
