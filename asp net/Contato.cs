﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net
{
    public class Contato

    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;

        }
    } 
    
}