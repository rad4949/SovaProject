using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class UserCartItem
    {
        public int Id { get; set; }
        public Taruf taruf { get; set; }
        public uint price { get; set; }
        public string UserCartId { get; set; }
        //[ForeignKey("taruf")]
        //public int tarufId { get; set; }

    }
}
