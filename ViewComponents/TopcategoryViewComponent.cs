using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class TopCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
