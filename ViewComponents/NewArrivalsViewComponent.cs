using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class NewArrivalsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
