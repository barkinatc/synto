using Microsoft.AspNetCore.Mvc;
using Project.BLL.Abstract;
using Project.BLL.Concretes;
using Project.ENTITIES.Models;
using synto.Areas.Admin.Models;

namespace synto.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {

        private readonly ICategoryManager _catMan;
        private readonly ISubCategoryManager _subCategoryMan;
        public CategoryController(ICategoryManager catMan, ISubCategoryManager subCategoryMan)
        {
            _catMan = catMan;
            _subCategoryMan = subCategoryMan;
         
        }
        public IActionResult ListCategories()
        {
            List<AdminCategoryVM> listCategories = _catMan.GetActives().Select(x => new AdminCategoryVM
            {
                ID = x.ID,
                Name = x.Name
                
            }).ToList();
            List<AdminSubCategoryVM> subList = _subCategoryMan.GetActives().Select(x => new AdminSubCategoryVM
            {
                ID = x.ID,
                SubCategoryName = x.SubCategoryName,
                CategoryID = x.CategoryID
            }).ToList();
        

            AdminCategoryPageVM page = new AdminCategoryPageVM();
            
            page.AdminCategoryVMs = listCategories;
           
           

            return View(page);
        }
      
        public IActionResult TreeView()
        {
            List<AdminCategoryVM> listCategories = _catMan.GetActives().Select(x => new AdminCategoryVM
            {
                ID = x.ID,
                Name = x.Name

                
            }).ToList();
            List<AdminSubCategoryVM> subList = _subCategoryMan.GetActives().Select(x => new AdminSubCategoryVM
            {
                ID= x.ID,
                SubCategoryName = x.SubCategoryName,
                CategoryID = x.CategoryID
            }).ToList();
            List<AdminTreeViewVM> nodes = new List<AdminTreeViewVM>();
            foreach (var item in listCategories)
            {

                nodes.Add(new AdminTreeViewVM
                {
                    ID = item.ID.ToString(),
                    Parent = "#",
                    Text = item.Name
                });
            }
            foreach (var item in subList)
            {
                nodes.Add(new AdminTreeViewVM
                {
                    ID =  item.ID.ToString(),
                    Parent = item.CategoryID.ToString(),
                    Text = item.SubCategoryName
                });
            }

            AdminCategoryPageVM page = new AdminCategoryPageVM
            {
                AdminCategoryVMs = listCategories,
                AdminTreeViewVMs = nodes
            };

            return View(page);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(AdminCategoryPageVM p)
        {
            Category c = new Category();
            c.Name = p.AdminCategoryVM.Name;
           

            _catMan.Add(c);

            return Redirect("/Admin/Category/ListCategories");

        }


        [HttpPost]
        public IActionResult MoveCategory(int id, int? newParentId, int? oldParentId)
        {
            //var subCatToMove = _subCategoryMan.Find(Convert.ToInt32(id));
            //if (newParentId !=null)
            //{
            //    subCatToMove.CategoryID = newParentId;

            //}
            //_subCategoryMan.Update(subCatToMove);
            
            var categoryToMove = _catMan.Find(id);
            categoryToMove.ParentID = newParentId;
            _catMan.Update(categoryToMove);

           
         
            return Json(new { success = true });
        }

        public IActionResult DeleteCategory(int id)
        {
            _catMan.Delete(_catMan.Find(id));

            return Redirect("/Admin/Category/ListCategories");

        }

        [HttpGet]
        public IActionResult UpdateInstitution(int id)
        {
            AdminCategoryVM? adminCategory = _catMan.Where(x => x.ID == id).Select(x => new AdminCategoryVM
            {
                ID = x.ID,
                Name = x.Name
            }).FirstOrDefault();
            return View(adminCategory);
        }
        [HttpPost]
        public IActionResult UpdateInstitution(AdminCategoryVM p)
        {
            Category toBeUpdated = _catMan.Find(p.ID);
            toBeUpdated.Name = p.Name;
            
            _catMan.Update(toBeUpdated);

            return Redirect("/Admin/Category/ListCategories");
        }
    }

    }
