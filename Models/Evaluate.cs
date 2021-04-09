using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Evaluate
    {
        private int? id;
        private int? idProduct;
        private int? idUser;
        private int? star;
        private DateTime createDate;
        private string comment;

        public int? IdProduct { get => idProduct; set => idProduct = value; }
        public int? IdUser { get => idUser; set => idUser = value; }
        public int? Star { get => star; set => star = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public string Comment { get => comment; set => comment = value; }
        [Key]
        public int? Id { get => id; set => id = value; }

        public Product Product;
    }
}
