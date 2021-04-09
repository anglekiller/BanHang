using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Product
    {
        private int? id;
        private string name;
        private float? price;
        private int? amount;
        private string image;
        private string screen;
        private string os;
        private string frontCamera;
        private string camera;
        private string cpu;
        private string ram;
        private string rom;
        private string sdCard;
        private string battery;
        private string status;
        private string comment;

        [Key]
        public int? Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float? Price { get => price; set => price = value; }
        public int? Amount { get => amount; set => amount = value; }
        [DisplayName("Upload file")]
        public string Image { get => image; set => image = value; }
        public string Screen { get => screen; set => screen = value; }
        public string Os { get => os; set => os = value; }
        public string FrontCamera { get => frontCamera; set => frontCamera = value; }
        public string Camera { get => camera; set => camera = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Rom { get => rom; set => rom = value; }
        public string SdCard { get => sdCard; set => sdCard = value; }
        public string Battery { get => battery; set => battery = value; }
        public string Status { get => status; set => status = value; }
        public string Comment { get => comment; set => comment = value; }
        public Typeofproduct Typeofproduct { get; set; }
    }
}
