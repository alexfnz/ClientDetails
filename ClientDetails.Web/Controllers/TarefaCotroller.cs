using ClientDetails.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClientDetails.Web.Controllers
{
    [Route("api/[controller]")]
    public class TarefaCotroller : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaCotroller(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tarefaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}