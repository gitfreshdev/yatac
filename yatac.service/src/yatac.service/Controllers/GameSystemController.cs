using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace yatac.service.Controllers
{
    public class GameSystemController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return View();
            return null;
        }

        public IActionResult GetSystemById(System.Guid id)
        {
            if (id.Equals(Guid.Empty))
            {
                throw new ArgumentOutOfRangeException(nameof(id), id.ToString(), "id cannot be an empty guid.");
            }

            throw new NotImplementedException();
        }
    }
}
