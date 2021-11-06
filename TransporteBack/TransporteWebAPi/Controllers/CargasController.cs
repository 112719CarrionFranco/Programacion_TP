using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporteBack.Servicios;
using TrasnporteDeCargas.Dominio;

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

        [HttpPost("registro")]
        public IActionResult PostCliente(Carga oCarga)
        {
            if (oCarga != null)
            {
                bool result = service.Crear(oCarga);
                return Ok(result);
            }

            return BadRequest("Se requiere la patente del camion");
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
        [HttpPost("consultaparam")]
        public IActionResult PostConsulta(List<Parametro> filtros)
        {
            if (filtros == null || filtros.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(service.ConsultarCamiones(filtros));
        }

        [HttpDelete("{patente}")]
        public IActionResult Delete(string patente)
        {
            if (!String.IsNullOrEmpty(patente))
                return BadRequest("se necesita la patente!");
            return Ok(service.RegistrarBajaCamion(patente));
        }
    }
}