using BLL.Interfaces;
using DAL;
using DBModels;
using DBModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    class UserManager : BaseManager, IUserManager
    {
        public UserManager(UnitOfWork uof) : base(uof) { }     
        
       public IEnumerable<UserDTO> GetUsers()
        {
            var list = uof.UserRepository.All.Select(s => new UserDTO()
            {
                Id = s.Id,
                UserName = s.UserName,
                Password = s.Password,
                Email = s.Email,
                RoleName = s.Roles.Name
            });

            return list.ToList();
        }

        public User GetUserByID(int userId)
        {
            return uof.UserRepository.GetByID(userId);
        }

        public void InsertUser(User user)
        {
            uof.UserRepository.Insert(user);
            uof.Save();
          
        }

        public void DeleteUser(int userId)
        {
            uof.UserRepository.Delete(userId);
            uof.Save();
        }

        public void UpdateUser(User user)
        {
            uof.UserRepository.Update(user);
            uof.Save();
        }
    }
}
