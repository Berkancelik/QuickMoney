using Microsoft.AspNetCore.Mvc;

namespace QuickMoney.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}