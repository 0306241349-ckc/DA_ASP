using Microsoft.AspNetCore.Mvc;


namespace MyProject.ViewComponents
{
    public class OfferViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
