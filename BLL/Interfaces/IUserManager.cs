using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserManager
    {
        DBModels.User GetUserByUserName(string userName, string password);
        DBModels.User GetUserByID(int userId);
        System.Collections.Generic.IEnumerable<DBModels.DTO.UserDTO> GetUsers();
        //System.Collections.Generic.IEnumerable<DBModels.Student> GetStudentsGroupId();
        void InsertUser(DBModels.User user);
        void UpdateUser(DBModels.User user);
        void DeleteUser(int userId);
    }
}
