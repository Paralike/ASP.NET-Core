using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.DAL.Entities
{
    public class VendeglatoipariEgyseg : EntityBase
    {
        public float Ertekeles { get; set; }
        public string Cim { get; set; }
        public string Telefonszam { get; set; }
        public bool Akadalymentesitett { get; set; }
        public bool AllatBarat { get; set; }
        public bool CsakNagykoruak { get; set; }
        public int Arkategoria { get; set; }
    }
}
