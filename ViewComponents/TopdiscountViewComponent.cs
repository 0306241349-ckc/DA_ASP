using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class TopDiscountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
