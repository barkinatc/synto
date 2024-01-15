using Microsoft.AspNetCore.Mvc;
using Project.BLL.Abstract;
using Project.ENTITIES.Models;
using synto.Areas.Admin.Models;

namespace synto.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProjectAController : Controller
    {
        private readonly IProjectAManager _proMan;
        private readonly ICategoryManager _categoryMan;
        private readonly ISubCategoryManager _subCategoryMan;

        public ProjectAController(IProjectAManager proMan, ICategoryManager categoryMan, ISubCategoryManager subCategoryMan)
        {
            _proMan = proMan;
            _categoryMan = categoryMan;
            _subCategoryMan = subCategoryMan;

        }

        public IActionResult ListProjects()
        {
            List<AdminProjectVM> projects = _proMan.GetActives().Select(x => new AdminProjectVM 
            { 
                ID = x.ID,
                Name = x.Name
            }).ToList();

            AdminProjectPageVM page = new AdminProjectPageVM();
            page.ProjectVMs = projects;

            return View(page);
        }
        [HttpPost]
        public IActionResult AddProject(AdminProjectPageVM p)
        {
            ProjectA pr = new ProjectA();
            pr.Name = p.ProjectVM.Name;
            _proMan.Add(pr);

            return Redirect("/Admin/ProjectA/ListProjects");

        }
        public IActionResult AddCategory(int id, AdminProjectPageVM p)
        {
            Category c = new Category();
            c.Name = p.AdminCategoryVM.Name;
            c.ProjectAID = id;
            _categoryMan.Add(c);
            return Redirect($"/Admin/ProjectA/ProjectTreeView/{id}");

        }

        public ActionResult ProjectTreeView(int id )
        {

            var project = _proMan.Find(id);
          
            
            List<AdminCategoryVM> listCategories = _categoryMan.GetActives().Where(x=> x.ProjectAID == project.ID).Select(x=> new AdminCategoryVM 
            {
            ID = x.ID,
            Name = x.Name,
            ParentID = x.ParentID.ToString()
            
            }).ToList();
           
            List<AdminTreeViewVM> nodes = new List<AdminTreeViewVM>();
            foreach (var item in listCategories)
            {
                if (item.ParentID == null || item.ParentID == "")
                {
                    nodes.Add(new AdminTreeViewVM
                    {
                        ID = item.ID.ToString(),
                        Parent = "#",
                        Text = item.Name
                    });
                }

                else
                {
                    nodes.Add(new AdminTreeViewVM
                    {
                        ID = item.ID.ToString(),
                        Parent = item.ParentID.ToString(),
                        Text = item.Name
                    });
                }
            }
           
            AdminProjectPageVM page = new AdminProjectPageVM();
            AdminProjectVM adminProjectVM = new AdminProjectVM();
            adminProjectVM.ID = id;
            
            page.AdminTreeViewVMs = nodes;
            page.ProjectVM = adminProjectVM;
            return View(page);
        }
    }
}
