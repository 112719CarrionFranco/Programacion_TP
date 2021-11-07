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
        public IActionResult Postcarga(Carga oCarga)
        {
            if (oCarga != null)
            {
                bool result = service.Crear(oCarga);
                return Ok(result);
            }

            return BadRequest("Se requiere la patente del camion");
        }

        [HttpPost("actualizar")]
        public IActionResult PostActualizar(Carga oCarga)
        {
            if (oCarga != null)
            {
                bool result = service.ActualizarCarga(oCarga);
                return Ok(result);
            }

            return BadRequest("Se requiere la patente del camion");
        }

        [HttpGet("{nro}")]
        public IActionResult Get(int nro)
        {
            if (nro == 0)
                return BadRequest("Se requiere Nro de Carga");
            return Ok(service.ObtenerCargaPorID(nro));
        }

        [HttpGet("{patente}")]
        public IActionResult CargaMaxima(string patente)
        {
            if (string.IsNullOrEmpty(patente))
                return BadRequest("Se requiere patente");
            return Ok(service.ConsultaPesoMax(patente));
        }

        // GET api/<CargasController>/5
        [HttpPost("Login")]
        public IActionResult Login(string usuario, string contraseña)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                return BadRequest("Falta usuario o contraseña!");
            return Ok(service.ControlUsuarios(usuario,contraseña));
        }

        // GET api/<CargasController>/5
        [HttpGet("consultaSinParametro")]
        public IActionResult Login(string sp)
        {
            if (string.IsNullOrEmpty(sp))
                return BadRequest("Falta sp!");
            return Ok(service.ConsultarSP(sp));
        }

        // POST api/<CargasController>
        [HttpPost("consultaparam")]
        public IActionResult PostConsulta(List<Parametro> filtros)
        {
            if (filtros == null || filtros.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(service.ConsultarCamiones(filtros));
        }

        // POST api/<CargasController>
        [HttpPost("consultapCarga")]
        public IActionResult PostConsultaCarga(List<Parametro> filtros)
        {
            if (filtros == null || filtros.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(service.ConsultarCarga(filtros));
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