using System;
using System.Collections.Generic;
using System.Text;

namespace pubertekelo.DAL.Entities
{
    class Felhasznalo : EntityBase{
        string felhasznalonev { get; set; }
        string email { get; set; }
        string jelszo { get; set; }
    }
}
