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
        public Taruf Taruf { get; set; }
        public uint Price { get; set; }
        public string UserCartId { get; set; }
    }
}
