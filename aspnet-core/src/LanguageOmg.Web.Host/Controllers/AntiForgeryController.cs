using Microsoft.AspNetCore.Antiforgery;
using LanguageOmg.Controllers;

namespace LanguageOmg.Web.Host.Controllers
{
    public class AntiForgeryController : LanguageOmgControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
