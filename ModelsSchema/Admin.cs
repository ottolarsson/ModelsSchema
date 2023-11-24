using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsSchema
{
    internal class Admin : Person
    {
        public int Telefonnummer { get; set; }
        public string Signatur {  get; set; }
        public string Akronym { get; set; }
    }
}
