using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.DAL.Entities
{
    public class Foglalas : EntityBase
    {
        public int HanyFore { get; set; }
        public DateTime Idopont { get; set; }
        public int AsztalId { get; set; }
    }
}
