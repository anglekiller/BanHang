using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Promotion
    {
        private int? promotionId;
        private string promotionName;
        private string tyoeOfpromotion;
        private float? promotionValue;
        private DateTime? start;
        private DateTime? end;
        [Key]
        public int? PromotionId { get => promotionId; set => promotionId = value; }
        public string PromotionName { get => promotionName; set => promotionName = value; }
        public string TyoeOfpromotion { get => tyoeOfpromotion; set => tyoeOfpromotion = value; }
        public float? PromotionValue { get => promotionValue; set => promotionValue = value; }
        public DateTime? Start { get => start; set => start = value; }
        public DateTime? End { get => end; set => end = value; }

    }
}
