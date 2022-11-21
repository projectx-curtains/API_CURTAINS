using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Api.Controllers
{
    public class FiltersCurtainsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<IEnumerable<CurtainsModel>> Get()
        {
            return Ok();
        }
    }
}
