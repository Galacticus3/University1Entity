using DBModels;
using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace BLL.Implementations
{
    public class GroupSubjectManager : BaseManager, IGroupSubjectManager
    {
        public GroupSubjectManager(UnitOfWork uof) : base(uof) { }     


        public void InsertGroupSubject(GroupSubject grsubj)
        {
            uof.GroupSubjectRepository.Insert(grsubj);
            uof.Save();
        }

        public void DeleteGroupSubject(int groupId, int subjId)
        {
            uof.GroupSubjectRepository.Delete(groupId, subjId);
            uof.Save();
        }

        public IEnumerable<SubjectDTO> GetSubjectsByGroupID(int groupId)
        {

            return uof.GroupSubjectRepository.SubjectsByGroupID(groupId);
        }

        public IEnumerable<GroupDTO> GetGroupsBySubjectID(int subjId)
        {

            return uof.GroupSubjectRepository.GroupsBySubjectID(subjId);
        }  

       
        
    }
}
