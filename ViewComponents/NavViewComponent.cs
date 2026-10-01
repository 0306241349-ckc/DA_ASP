using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class NavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
