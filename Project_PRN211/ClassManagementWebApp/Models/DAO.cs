using ClassManagementWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.ComponentModel.DataAnnotations;

namespace ClassManagementWebApp.Models
{
    public class DAO
    {
        private static DAO instance = null;
        private static readonly object instanceLock = new object();
        public static DAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Group> GetGroupList()
        {
            var groups = new List<Group>();
            try
            {
                using var context = new PrnProjectContext();
                groups = context.Groups.Include(g => g.Lecturer).Include(g => g.Subject).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return groups;
        }
        public Group GetGroupID(int groupID)
        {
            Group group = null; ;
            try
            {
                using var context = new PrnProjectContext();
                group = context.Groups.Include(g => g.Lecturer).Include(g => g.Subject).SingleOrDefault(g => g.GroupId== groupID);

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return group;
        }
        public void AddNew(Group group)
        {
            try
            {
                Group _group = GetGroupID(group.GroupId);
                if (_group == null)
                {
                    using var context = new PrnProjectContext();
                    context.Groups.Add(group);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Class is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Group group)
        {
            try
            {
                Group _group = GetGroupID(group.GroupId);
                if (_group != null)
                {
                    using var context = new PrnProjectContext();
                    context.Groups.Update(group);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Class does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Remove(int groupID)
        {
            try
            {
                Group group = GetGroupID(groupID);
                if (group != null)
                {
                    using var context = new PrnProjectContext();
                    context.Groups.Remove(group);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Class does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Group> GetStudentGroupList(int groupID)
        {
            var groups = new List<Group>();
            try
            {
                using var context = new PrnProjectContext();
                groups = context.Groups.Include(g => g.Students).Where(g => g.GroupId == groupID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return groups;
        }



    }
}
