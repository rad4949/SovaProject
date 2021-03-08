using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class Taruf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Img { get; set; }
        public uint Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
