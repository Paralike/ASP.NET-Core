﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.DAL.Entities
{
    public class Felhasznalo : EntityBase{
        public string Felhasznalonev { get; set; }
        public string Email { get; set; }
        public string Jelszo { get; set; }
    } 
}
