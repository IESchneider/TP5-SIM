﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5SIM.Entidades
{
    public class Abierta : Estado
    {
        public string nombre { get; set; }
        public Abierta() : base("Abierta", false, false, false, false, false, 
                                false, false, false, false, false, true, false) { }
    }
    
}
