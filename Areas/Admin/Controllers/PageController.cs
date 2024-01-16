using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Project.BLL.Abstract;
using Project.ENTITIES.Models;
using synto.Areas.Admin.Models;
using System.Xml;

namespace synto.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class PageController : Controller
    {
        private readonly  IPageManager _pMan;
        private readonly  ICategoryManager _catMan;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PageController(IPageManager pMan, IWebHostEnvironment hostingEnvironment, ICategoryManager catMan)
        {
            _pMan = pMan;
            _hostingEnvironment = hostingEnvironment;
            _catMan = catMan;
        }
        [HttpGet]
        public IActionResult ChoosePageIndex(int id)
        {
            List<AdminPageVM> pages = _pMan.GetActives().Where(x => x.CategoryID == id).Select(x => new AdminPageVM
            {
                ID = x.ID,
                CategoryID = x.CategoryID,
                PageType = x.PageType,
                Order = x.Order
            }).ToList();

            ViewBag.Pages = pages;
            TempData["CategoryID"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult ChoosePageIndex(AdminChoseVM model)
        {

            Guid uniqueCode = Guid.NewGuid();
            string uniqueCodeString = uniqueCode.ToString();
            
            var category = _catMan.Find((int)TempData["CategoryID"]);

            var pages = _pMan.GetActives().Where(x => x.CategoryID == category.ID);
            foreach (var item in model.Items)
            {
                
                if (pages.Any(p => p.ID == item.Id))
                {
                   var page = _pMan.Find(Convert.ToInt32(item.Id));
                    page.Order = Convert.ToInt32(item.Order);
                    _pMan.Update    (page);
                    
                }
                else
                {
                    Page page = new Page();
                    page.CategoryID = (int)TempData["CategoryID"];
                    page.PageType = item.Id;
                    page.Order = item.Order;

                    page.PageUniqueCode = uniqueCodeString;
                    _pMan.Add(page);
                }
            }

           


            return View();
        }

    }
}
//public IActionResult CreatePage(int id)
//{




//    return View();

//}

//public async Task<IActionResult> CreatePage(AdminCreatePageListVM p)
//{
//    if (p.CreatePageVM != null)
//    {
//        Page page = new Page();

//        foreach (var item in p.CreatePageVM.TextAreas)
//        {
//            Content content = new Content
//            {
//                PageID = page.ID,
//                Text = item
//            };
//            page.Contents.Add(content);
//        }

//        foreach (var item in p.CreatePageVM.Images)
//        {
//            if (item.Length > 0 && item != null)
//            {
//                var imagePath = Path.Combine("wwwroot/assets/img/gallery/", item.FileName);
//                using (var stream = new FileStream(imagePath, FileMode.Create))
//                {
//                    await item.CopyToAsync(stream);
//                }


//                Image image = new Image

//                {
//                    ImagePath = imagePath,
//                    PageID = page.ID

//                };
//                page.Images.Add(image);
//            }

//        }

//        page.CategoryID = (int)TempData["CategoryID"];
//        _pMan.Add(page);

//    }








