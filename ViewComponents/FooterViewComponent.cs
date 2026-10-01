using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
