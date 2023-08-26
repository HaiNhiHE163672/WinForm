using ClassManagementWebApp.DataAccess;
namespace ClassManagementWebApp.Models
{
    public class GroupRepository : IGroupRepository
    {
        public IEnumerable<Group> GetGroupList() => DAO.Instance.GetGroupList();
        public Group GetGroupID(int groupID) => DAO.Instance.GetGroupID(groupID);
        public void AddNew(Group group) => DAO.Instance.AddNew(group);
        public void Update(Group group) => DAO.Instance.Update(group);
        public void Remove(int groupID) => DAO.Instance.Remove(groupID);
        public IEnumerable<Group> GetStudentGroupList(int groupID) => DAO.Instance.GetStudentGroupList(groupID);
    }
}
