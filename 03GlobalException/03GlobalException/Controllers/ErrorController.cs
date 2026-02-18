
using Microsoft.AspNetCore.Mvc;

namespace _03GlobalException.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Handle(int statusCode)
        {
            var model = new ViewModels.ErrorViewModel
            {
                StatusCode = statusCode,
                Message = GetMessage(statusCode)
            };

            return View("Error", model);
        }

        private string GetMessage(int statusCode)
        {
            return statusCode switch
            {
                401 => "Yetkilendirme gerekli.",
                403 => "Bu sayfaya erişim izniniz yok.",
                404 => "Sayfa bulunamadı.",
                500 => "Sunucu hatası oluştu.",
                _ => "Beklenmeyen bir hata oluştu."
            };
        }
    }

}
