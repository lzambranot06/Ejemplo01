using JWT_API.Clases_API;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Api_loginController : ControllerBase
    {

        private readonly ILogger<Api_loginController> _logger;

        public Api_loginController(ILogger<Api_loginController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ClaseApi_Login")]
        public IEnumerable<ClaseApi_Login> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ClaseApi_Login
            {
                login="usuario_login",
                password="contraseña_login",
                tiempo = DateOnly.FromDateTime(DateTime.Now.AddDays(index))
            })
            .ToArray();
        }
    }
}

/*

    public class Api_LoginController : ControllerBase
    {
        private readonly ILogger<Api_LoginController> _logger;

        public Api_LoginController(ILogger<Api_LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetClaseApi_Login")]
        public IEnumerable<ClaseApi_Login> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ClaseApi_Login
            {
                tiempo = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                login = "soy login",
                password = "soy password"
            })
            .ToArray();
        }
*/

        /*
        // POST: Api_LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } */


        /*
        // GET: Api_LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Api_LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Api_LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Api_LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } */

