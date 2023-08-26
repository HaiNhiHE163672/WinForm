using ClassManagementWebApp.DataAccess;
namespace ClassManagementWebApp.Models
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetGroupList();
        Group GetGroupID(int groupID);
        void AddNew(Group group);
        void Update(Group group);
        void Remove(int groupID);
        IEnumerable<Group> GetStudentGroupList(int groupID);
    }
}
