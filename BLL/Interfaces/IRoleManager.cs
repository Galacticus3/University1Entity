using DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRoleManager
    {
        IEnumerable<DBModels.DTO.RoleDTO> GetRoles();
        Role GetRoleByID(int roleId);
        void InsertRole(Role role);
        void DeleteRole(int roleId);
        void UpdateRole(Role role); 
    }
}
