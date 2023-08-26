using ClassManagementWebApp.DataAccess;
using ClassManagementWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassManagementWebApp.Controllers
{
    public class GroupController : Controller
    {
        IGroupRepository groupRepository = null;
        public GroupController() => groupRepository= new GroupRepository();
        public ActionResult List()
        {
            
            var StudentList = groupRepository.GetGroupList();
            return View(StudentList);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupRepository.GetGroupID(id.Value);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        
        public ActionResult Create() => View();

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Group group)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    groupRepository.AddNew(group);
                }
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(group);
            }
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupRepository.GetGroupID(id.Value);
            if ( group == null)
            {
                return NotFound();
            }
            return View(group);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Group group)
        {
            try
            {
                if (id != group.GroupId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    groupRepository.AddNew(group);
                }
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupRepository.GetGroupID(id.Value);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                groupRepository.Remove(id);
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }


    }
}
