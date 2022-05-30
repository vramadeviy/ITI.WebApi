using ITI.WebApi.Services;
using ITI_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : Controller
    {        

        [HttpGet]
        public IActionResult getCountries()
        {
            RegisterService regService = new RegisterService();
            var response = regService.lstCountries();
            return Json(response);
        }
    }
}