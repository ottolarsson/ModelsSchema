using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsSchema
{
    abstract class Person
    {
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }

    }
}
