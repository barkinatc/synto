using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Project.BLL.Abstract;
using Project.ENTITIES.Models;
using synto.Areas.Admin.Models;
using System;

namespace synto.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class MissionController : Controller
    {
       private readonly IMissionManager _missionManager;
        private readonly IInstitutionManager _institutionManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IPageManager _pageManager;
        private readonly IProjectAManager _proMan;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public MissionController(IMissionManager missionManager, IInstitutionManager institutionManager, ICategoryManager categoryManager, IPageManager pageManager, IProjectAManager proMan, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _missionManager = missionManager;
            _institutionManager = institutionManager;
            _categoryManager = categoryManager;
            _pageManager = pageManager;
            _proMan = proMan;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult ChooseProject()
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
        public IActionResult ChooseCategory(int id)
        {
            var project = _proMan.Find(id);
            if (project != null)
            {
                List<AdminCategoryVM> listCategories = _categoryManager.GetActives().Where(x => x.ProjectAID == project.ID).Select(x => new AdminCategoryVM
                {
                    ID = x.ID,
                    Name = x.Name,
                    ParentID = x.ParentID.ToString()

                }).ToList();

                List<AdminTreeViewVM> nodes = new List<AdminTreeViewVM>();
                char letter = 'A';
                int number = 1;

                foreach (var item in listCategories)
                {
                    string label;
                    if (item.ParentID == null || item.ParentID == "")
                    {
                        label = letter.ToString();
                        letter++;
                        if (letter > 'Z') letter = 'A';
                    }
                    else
                    {
                        label = number.ToString();
                        number++;
                    }

                    nodes.Add(new AdminTreeViewVM
                    {
                        ID = item.ID.ToString(),
                        Parent = item.ParentID == null || item.ParentID == "" ? "#" : item.ParentID.ToString(),
                        Text = label + " - " + item.Name
                    });
                }

                AdminProjectPageVM page = new AdminProjectPageVM();
                AdminProjectVM adminProjectVM = new AdminProjectVM();

                adminProjectVM.ID = id;

                page.AdminTreeViewVMs = nodes;
                page.ProjectVM = adminProjectVM;
                return View(page);
            }

            return View();
        }
        [HttpGet]
        public IActionResult AssignMission(int id)
        {



            var category = _categoryManager.Find(id);

            if (category != null)
            {
                List<AdminInstitutionVM> institutions = _institutionManager.GetActives().Select(x => new AdminInstitutionVM
                {
                    ID = x.ID,
                    Name = x.Name
                }).ToList();

                List<AdminPageVM> pages = _pageManager.GetActives().Where(x => x.CategoryID == category.ID).Select(x => new AdminPageVM
                {
                    ID = x.ID,
                    CategoryID = x.CategoryID,
                    PageType = x.PageType,
                    Order = x.Order,
                    InstitutionID = x.InstitutionID

                }).ToList();

                AdminAssignMissionVM assign = new AdminAssignMissionVM();
                assign.CreateMission.CategoryID = category.ID;
                assign.InstitutionVMs = institutions;
                assign.PageVMs = pages;

                return View(assign);


            }

            return View();


        }
        [HttpPost]
        public IActionResult AssignMission(AdminAssignMissionVM p)
        {
            //var missions = _missionManager.GetActives().Where(x=> x.InstitutionID != p.CreateMission.InstitutionID).Select(x=> new MissionVM
            //{
            //    ID
            //})
            var missions = _missionManager.GetActives();
            if (missions != null)
            {
                foreach (var item in missions)
                {
                    if (item.PageID != p.selectedDivID || item.CategoryID != p.CreateMission.CategoryID || item.InstitutionID != p.CreateMission.InstitutionID)
                    {
                        Mission mi = new Mission();
                        mi.PageID = p.selectedDivID;
                        mi.InstitutionID = p.CreateMission.InstitutionID;
                        mi.CategoryID = p.CreateMission.CategoryID;
                        mi.MissionName = p.CreateMission.Mission;
                        Page pa = _pageManager.Find(Convert.ToInt32(p.selectedDivID));
                        pa.InstitutionID = Convert.ToInt32(mi.InstitutionID);
                        _pageManager.Update(pa);
                        _missionManager.Add(mi);

                        return Redirect("/Admin/");

                    }
                }
            }
            else
            {
                Mission m = new Mission();
                m.PageID = p.selectedDivID;
                m.InstitutionID = p.CreateMission.InstitutionID;
                m.CategoryID = p.CreateMission.CategoryID;
                m.MissionName = p.CreateMission.Mission;
                Page page = _pageManager.Find(Convert.ToInt32(p.selectedDivID));
                page.InstitutionID = Convert.ToInt32(m.InstitutionID);
                _pageManager.Update(page);
                _missionManager.Add(m);
            }


            return View();







        }
        public async Task<IActionResult> AssignTask()
        {


            var userName = HttpContext.User.Identity.Name;
            if (userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                if (user != null)
                {
                    List<MissionVM> missions = _missionManager.Where(x => x.InstitutionID == user.InstitutionID).Select(x => new MissionVM
                    {
                        ID = x.ID,
                        PageID = x.PageID,
                        InstitutionID = x.InstitutionID,
                        CategoryID = x.CategoryID,
                        CategoryName = x.Category.Name,
                        PageType = x.Page.PageType,
                        PageOrder = x.Page.Order
                    }).ToList();
                    List<AdminPageVM> pages = _pageManager.GetActives().Select(x => new AdminPageVM
                    {
                        ID = x.ID,
                        PageType = x.PageType
                        ,
                        Order = x.Order
                    }).ToList();
                    //List<AdminCategoryVM> categories = _categoryManager.GetActives().Select(x => new AdminCategoryVM {
                    //    ID = x.ID,
                    //    Name = x.Name 
                    //}).ToList();
                    MissionPageVM pageVM = new MissionPageVM { Missions = missions, Pages = pages };
                    return View(pageVM);

                }
                return View();
            }

            return View();



        }

        [HttpGet]

        public async Task<IActionResult> CreatePage(int id)
        {
            var userName = HttpContext.User.Identity.Name;
            if (userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                if (user != null)
                {
                    var category = _categoryManager.Find(id);
                    if (category != null)
                    {
                        List<AdminPageVM> pages = _pageManager.Where(x => x.CategoryID == category.ID ).Select(x => new AdminPageVM
                        {
                            ID= x.ID,

                            CategoryID = x.CategoryID,
                            PageType = x.PageType,
                            Order = x.Order,
                            InstitutionID =x.InstitutionID
                        }).ToList();
                        AppUserVM appUser = new AppUserVM();
                        appUser.ID = user.Id;
                        appUser.InstitutionID = user.InstitutionID;

                        MissionCreatePage createPage = new MissionCreatePage();

                        createPage.Appuser = appUser;
                        createPage.PageVMs = pages;
                        return View(createPage);
                    }

                    return View();
                }
                return View();
            }
            return View();

        }
        [HttpPost]

        public async Task<IActionResult> CreatePage(MissionCreatePage p)
        {

            //if (p.CreatePageVM != null)
            //{
            //    Page page = new Page();

            //    foreach (var item in p.CreatePageVM.TextAreas)
            //    {
            //        Content content = new Content
            //        {
            //            PageID = page.ID,
            //            Text = item
            //        };
            //        page.Contents.Add(content);
            //    }

            //    foreach (var item in p.CreatePageVM.Images)
            //    {
            //        if (item.Length > 0 && item != null)
            //        {
            //            var imagePath = Path.Combine("wwwroot/assets/img/gallery/", item.FileName);
            //            using (var stream = new FileStream(imagePath, FileMode.Create))
            //            {
            //                await item.CopyToAsync(stream);
            //            }


            //            Image image = new Image

            //            {
            //                ImagePath = imagePath,
            //                PageID = page.ID

            //            };
            //            page.Images.Add(image);
            //        }

            //    }

            //    page.CategoryID = (int)TempData["CategoryID"];
            //    _pMan.Add(page);

            //}

            return View();

        }
    }
}