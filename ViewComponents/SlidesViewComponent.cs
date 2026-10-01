using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class SlidesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
