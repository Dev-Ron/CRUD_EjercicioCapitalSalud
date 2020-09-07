using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CRUD_EjercicioCapitalSalud.Data;
using CRUD_EjercicioCapitalSalud.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRUD_EjercicioCapitalSalud.Controllers {
    
    [Route("api/[controller]")]
    public class OrdersController : Controller {

        private AppDbContext _dbContext;
        public OrdersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Este metodo obtiene los registros de la tabla usuario
        /// </summary>
        /// <param name="loadOptions"></param>
        /// <returns></returns>
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_dbContext.Usuario.ToList(), loadOptions);
        }

        [HttpPost]
        public object Post(string values)
        {
            Usuario usuario = new Usuario();
            try
            {
                JsonConvert.PopulateObject(values, usuario);
                _dbContext.Usuario.Add(usuario);
                _dbContext.SaveChanges();
            }
            catch(Exception e)
            {
                
            }
            return (usuario);
        }

        [HttpDelete]
        public object Delete(int key)
        {
            _dbContext.Usuario.Remove(_dbContext.Find<Usuario>(key));
            _dbContext.SaveChanges();
            return (true);
        }


        [HttpPut]
        public object Put(int key, string values)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario = _dbContext.Usuario.FirstOrDefault(r => r.Id == key);
                JsonConvert.PopulateObject(values, usuario);
                _dbContext.Usuario.Update(usuario);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }

            return (usuario);
        }
    }
}