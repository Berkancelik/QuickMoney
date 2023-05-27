using Microsoft.AspNetCore.Mvc;

namespace QuickMoney.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}