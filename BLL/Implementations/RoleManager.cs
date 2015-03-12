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
    class RoleManager : BaseManager, IRoleManager
    {
       public RoleManager(UnitOfWork uof) : base(uof) { }     
        
       public IEnumerable<RoleDTO> GetRoles()
        {
           var list = uof.RoleRepository.All.Select(s => new RoleDTO()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description
            });

            return list.ToList();
        }

        public Role GetRoleByID(int roleId)
        {
            return uof.RoleRepository.GetByID(roleId);
        }

        public void InsertRole(Role role)
        {
            uof.RoleRepository.Insert(role);
            uof.Save();
          
        }

        public void DeleteRole(int roleId)
        {
            uof.RoleRepository.Delete(roleId);
            uof.Save();
        }

        public void UpdateRole(Role role)
        {
            uof.RoleRepository.Update(role);
            uof.Save();
        }
    }
}
