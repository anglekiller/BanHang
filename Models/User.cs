using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace BanHang.Models
{
    public class User
    {
        private int? idUser;
        private string lastName;
        private string firstName;
        private string middleName;
        private string phoneNumber;
        private string email;
        private string address;
        private string account;
        private string password;
        private int? permissionId;
        private int? status;

        [Key]
        public int? IdUser { get => idUser; set => idUser = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public int? PermissionId { get => permissionId; set => permissionId = value; }
        public int? Status { get => status; set => status = value; }
        public Permission Permission { get; set; }
    }
}
