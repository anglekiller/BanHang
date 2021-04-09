using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Billdetail
    {
        private int? id;
        private float? amount;
        private float? price;

        public float? Amount { get => amount; set => amount = value; }
        public float? Price { get => price; set => price = value; }
        public List<Product> Products { get; set; }
        public List<Bill> Bills { get; set; }
        [Key]
        public int? Id { get => id; set => id = value; }
    }
}
