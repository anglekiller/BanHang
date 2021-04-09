using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Typeofproduct
    {
        private int? id;
        private string nameoftype;
        private string image;
        private string description;
        [Key]
        public int? Id { get => id; set => id = value; }
        public string Nameoftype { get => nameoftype; set => nameoftype = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public List<Product> Products { get; set; }
    }
}
