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
        private readonly IImageManager _imgMan;
        private readonly IContentManager _contentMan;
        private readonly IDataManager _dataMan;
        private readonly IAppUserManager _userMan;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public MissionController(IMissionManager missionManager, IInstitutionManager institutionManager, ICategoryManager categoryManager, IPageManager pageManager, IProjectAManager proMan, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IImageManager imgMan, IContentManager contentMan, IDataManager dataMan, IAppUserManager userMan)
        {
            _missionManager = missionManager;
            _institutionManager = institutionManager;
            _categoryManager = categoryManager;
            _pageManager = pageManager;
            _proMan = proMan;
            _userManager = userManager;
            _signInManager = signInManager;
            _imgMan = imgMan;
            _contentMan = contentMan;
            _dataMan = dataMan;
            _userMan = userMan;

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
                int number = 1;
                char letter = 'A';
                string currentParentID = null;

                foreach (var item in listCategories)
                {
                    string label;
                    if (item.ParentID == null || item.ParentID == "")
                    {
                        label = number.ToString();
                        number++;
                        currentParentID = item.ID.ToString();
                        letter = 'A'; // Ana kategori değiştiğinde harf sıralamasını sıfırla
                    }
                    else
                    {
                        if (currentParentID != item.ParentID)
                        {
                            letter = 'A'; // Ana kategori değiştiğinde harf sıralamasını sıfırla
                        }

                        label = letter.ToString();
                        letter++;
                        if (letter > 'Z') letter = 'Z';
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

            List<MissionVM> missions = _missionManager.GetActives().Select(x => new MissionVM
            {
                ID = x.ID,
                PageID = x.PageID,
                CategoryID = x.CategoryID

            }).ToList();

            List<AppUserVM> users = _userMan.GetActives().Select(x => new AppUserVM
            {
                ID = x.id,
                Name = x.Name,
                Surname = x.Surname,
                InstitutionID = x.InstitutionID,
                Mail = x.Email
            }).ToList();
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
                    InstitutionID = x.InstitutionID,
                    InstitutionName =x.Institution.Name

                }).ToList();

                AdminAssignMissionVM assign = new AdminAssignMissionVM();
                assign.CreateMission.CategoryID = category.ID;
                assign.InstitutionVMs = institutions;
                assign.PageVMs = pages;
                assign.Missions = missions;
                assign.Users = users;
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
                    if (item.PageID != p.selectedDivID)
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

                        return Redirect("/Admin/Mission/AssignTask");

                    }
                    break;
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
                    var institutions = _institutionManager.GetActives();

                    foreach (var item in institutions)
                    {
                        if (item.ID ==user.InstitutionID)
                        {
                            ViewBag.InstitutionName = item.Name;
                        }
                    }
                    
                    List<MissionVM> missions = _missionManager.Where(x => x.InstitutionID == user.InstitutionID).Select(x => new MissionVM
                    {
                        ID = x.ID,
                        PageID = x.PageID,
                        InstitutionID = x.InstitutionID,
                        CategoryID = x.CategoryID,
                        CategoryName = x.Category.Name,
                        PageType = x.Page.PageType,
                        PageOrder = x.Page.Order,
                        MissionName =x.MissionName,
                        Status =x.Status,
                        CreatedDate =x.CreatedDate.ToString()
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
            ViewBag.EmptyUser = "Kullanıcı bulunamadı.. ";
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
                        List<AdminPageVM> pages = _pageManager.Where(x => x.CategoryID == category.ID).Select(x => new AdminPageVM
                        {
                            ID = x.ID,

                            CategoryID = x.CategoryID,
                            PageType = x.PageType,
                            Order = x.Order,
                            InstitutionID = x.InstitutionID
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
            if (p.Image != null)
            {
                var imagePath = Path.Combine("wwwroot/assets/img/gallery/", p.Image.FileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await p.Image.CopyToAsync(stream);
                }

                Image image = new Image();

                image.ImagePath = imagePath;
                image.PageID = Convert.ToInt32(p.itemId);
                _imgMan.Add(image);



            }
            if (p.TextArea != null)
            {
                Content content = new Content();

                content.PageID = Convert.ToInt32(p.itemId);
                content.Text = p.TextArea;
                _contentMan.Add(content);


            }
            if (p.DataInput != null)
            {
                Data data = new Data();
                data.Content = p.DataInput;
                _dataMan.Add(data);
            }
           

            return View();

        }
    }
}