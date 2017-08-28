using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Knockout.DataTables.Web.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCore.Knockout.DataTables.Web.Controllers
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(new List<CustomFieldModel>
                {
                    new CustomFieldModel
                    {
                        Id = 1,
                        Name = "FirstName",
                        Value = "Joshua",
                    },
                    new CustomFieldModel
                    {
                        Id = 2,
                        Name = "LastName",
                        Value = "Thompson",
                    }
            });
        }
    }
}
