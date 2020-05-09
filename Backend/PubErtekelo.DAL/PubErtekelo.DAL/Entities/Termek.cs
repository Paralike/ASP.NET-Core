using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PubErtekelo.DAL.Entities
{
    public class Termek : EntityBase
    {
        public int ar { get; set; }
        public bool is_akcios { get; set; }
        public List<string> allergenek { get; set; }
    }
}
