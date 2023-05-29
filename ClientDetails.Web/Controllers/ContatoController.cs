using ClientDetails.Dominio.Contratos;
using ClientDetails.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClientDetails.Web.Controllers
{

    [Route("api/[controller]")]
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_contatoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contato contato)
        {
            try
            {
                _contatoRepositorio.Atualizar(contato);
                return Created("api/contato", contato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}