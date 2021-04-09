using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Permission
    {
        private int? permissionId;
        private string permissionName;
        private string detail;
        [Key]
        public int? PermissionId { get => permissionId; set => permissionId = value; }
        public string PermissionName { get => permissionName; set => permissionName = value; }
        public string Detail { get => detail; set => detail = value; }
        public User User { get; set; }
    }
}
