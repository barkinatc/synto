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
        public InstitutionController(IInstitutionManager institutionManager)
        {
            _institutionManager = institutionManager;
        }

        
        public IActionResult ListInstitutions()
        {


            List<AdminInstitutionVM> list = _institutionManager.GetActives().Select(x => new AdminInstitutionVM
            {
                ID = x.ID,
                Name = x.Name
            }).ToList();
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
