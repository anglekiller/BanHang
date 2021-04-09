using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHang.Models;

namespace BanHang.CrudData
{
 public interface IUsers
    {
        List<User> GetUsers();
        User GetUsers(Guid id);
        User AddUsers(User user);
        void DeleteUsers(User user);
        User EditUsers(User user);


    }
}
