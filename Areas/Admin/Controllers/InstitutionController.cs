using Microsoft.AspNetCore.Mvc;
using Project.BLL.Abstract;
using Project.ENTITIES.Models;
using synto.Areas.Admin.Models;

namespace synto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstitutionController : Controller
    {
        private readonly IInstitutionManager _institutionManager;
        private readonly IAppUserManager _userMan;
        public InstitutionController(IInstitutionManager institutionManager, IAppUserManager userMan)
        {
            _institutionManager = institutionManager;
            _userMan = userMan;
        }


        public IActionResult ListInstitutions()
        {
            List<AppUserVM> users = _userMan.GetActives().Select(x => new AppUserVM
            {
                ID = x.Id,
                Name = x.Name,
                Mail = x.Email,
                Surname = x.Surname,
                InstitutionID = x.InstitutionID
            }).ToList();
            List<AdminInstitutionVM> list = _institutionManager.GetActives().Select(x => new AdminInstitutionVM
            {
                ID = x.ID,
                Name = x.Name
            }).ToList();
            List<InstitutionTreeViewVM> nodes = new List<InstitutionTreeViewVM>();

            foreach (var institution in list)
            {
                var institutionNode = new InstitutionTreeViewVM
                {
                    ID = institution.ID,
                    Name = institution.Name,
                    Children = new List<InstitutionTreeViewVM>()
                };

                // Bu kurumun kullanıcılarını bul
                var usersInInstitution = groupedUsers.FirstOrDefault(g => g.Key == institution.ID);

                if (usersInInstitution != null)
                {
                    foreach (var user in usersInInstitution)
                    {
                        institutionNode.Children.Add(new InstitutionTreeViewVM
                        {
                            ID = user.ID,
                            Name = $"{user.Name} {user.Surname}" // İsim ve soyismi birleştirme
                        });
                    }
                }

                nodes.Add(institutionNode);
            }



            AdminListAddInstitutionVM pageVM = new AdminListAddInstitutionVM
            {
                AdminInstitutionVMs = list
            };




            return View(pageVM);
        }
        [HttpGet]
        public IActionResult AddInstitutions()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstitutions(AdminListAddInstitutionVM p)
        {
            Institution institution = new Institution();
            institution.Name = p.AdminInstitutionVM.Name;
            _institutionManager.Add(institution);

            return Redirect("/Admin/Institution/ListInstitutions");

        }
        [HttpGet]
        public IActionResult UpdateInstitution(int id)
        {
            AdminInstitutionVM ?adminInstitution = _institutionManager.Where(x => x.ID == id).Select(x => new AdminInstitutionVM
            {
                ID = x.ID,
                Name = x.Name
            }).FirstOrDefault();
            return View(adminInstitution);
        }
        [HttpPost]
        public IActionResult UpdateInstitution(AdminInstitutionVM p)
        {
            Institution toBeUpdated = _institutionManager.Find(p.ID);
            toBeUpdated.Name = p.Name;
            _institutionManager.Update(toBeUpdated);

            return Redirect("/Admin/Institution/ListInstitutions");
        }
        public IActionResult DeleteInstitution(int id)
        {
            _institutionManager.Delete(_institutionManager.Find(id));

            return Redirect("/Admin/Institution/ListInstitutions");
        }

    }
}
