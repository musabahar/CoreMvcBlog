using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcBlog.ViewComponents.Reference
{
    public class ReferenceList : ViewComponent
    {
        ReferenceManager referenceManager = new ReferenceManager(new EFReferenceDal());
        public IViewComponentResult Invoke()
        {
            var values = referenceManager.TGetList();
            return View(values);
        }
    }
}
