using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporteBack.Servicios;

namespace TransporteWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargasController : ControllerBase
    {
        private IService service;

        public CargasController()
        {
            service = new ServiceFactoryImp().CrearService();
        }

        // GET api/<CargasController>/5
        [HttpGet("obtenerCargaID")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(service.ObtenerCargaPorID(id));
        }

        // GET api/<CargasController>/5
        [HttpPost("Login")]
        public IActionResult Login(string usuario, string contraseña)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                return BadRequest("Falta usuario o contraseña!");
            return Ok(service.ControlUsuarios(usuario,contraseña));
        }

        // POST api/<CargasController>
        [HttpPost("consultar")]
        public IActionResult GetCamiones(List<Parametro> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(service.ConsultarCamiones(lst));
        }

        // DELETE api/<CargasController>/5
        [HttpDelete("Eliminar Carga")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(service.RegistrarBajaCarga(id));
        }
    }
}