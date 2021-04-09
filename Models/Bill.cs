using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Bill
    {
        private int? billId;
        private int? userId;
        private DateTime? createDate;
        private string receiver;
        private string phoneNumber;
        private string paymentMethod;
        private float? totalMoney;
        private string status;
        [Key]
        public int? BillId { get => billId; set => billId = value; }
        public int? UserId { get => userId; set => userId = value; }
        public DateTime? CreateDate { get => createDate; set => createDate = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public float? TotalMoney { get => totalMoney; set => totalMoney = value; }
        public string Status { get => status; set => status = value; }
        public User User { get; set; }
    }
}
