using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.DAL.Entities
{
    public class Felhasznalo : EntityBase{
        string felhasznalonev { get; set; }
        string email { get; set; }
        string jelszo { get; set; }
    }
}
