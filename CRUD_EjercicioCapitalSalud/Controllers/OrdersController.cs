using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CRUD_EjercicioCapitalSalud.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_EjercicioCapitalSalud.Controllers {

    [Route("api/[controller]")]
    public class OrdersController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}