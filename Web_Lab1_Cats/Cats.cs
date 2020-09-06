using System;
using System.Collections.Generic;

namespace Web_Lab1_Cats
{
    public partial class Cats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public int SpeciesId { get; set; }
        public int Age { get; set; }
        public string Info { get; set; }
    }
}
