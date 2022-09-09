using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Repository.Interfaces;

namespace AlumnosAPI.Controllers
{
    [Route("api-alumnos")]
    [ApiController]
    public class AlumnosController : Controller
    {
        private readonly IAlumnoRepository _alumnosRepository;
        public AlumnosController(IAlumnoRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }

        [HttpGet]
        public ActionResult<List<Alumno>> findAll()
        {
            try
            {
                List<Alumno> listaAlunos = _alumnosRepository.findAll();
                return StatusCode(200, listaAlunos);
            }
            catch (Exception err)
            {
                return StatusCode(500, err.Message);
            }

        }

    }
}
