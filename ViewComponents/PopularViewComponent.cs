using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class PopularViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
