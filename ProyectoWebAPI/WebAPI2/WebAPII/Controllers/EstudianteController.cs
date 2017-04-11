using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPII.Models;

namespace WebAPII.Controllers
{
    public class EstudianteController : ApiController
    {
        // Para publicar se ocupa bin, Global.asax, Web.config
        // Mover a Ineput --> wwwroot --> Crear carpeta
        List<Estudiante> ListaEstudiantes = new List<Estudiante>()
        {
            new Estudiante {idEstudiante="123", nombreEstudiante="Kevin", apellido1Estudiante="Zheng",apellido2Estudiante="Wu" },
            new Estudiante {idEstudiante="456", nombreEstudiante="Laura", apellido1Estudiante="Vargas", apellido2Estudiante="Castro" },
            new Estudiante {idEstudiante="798", nombreEstudiante="Jose", apellido1Estudiante="Lopez", apellido2Estudiante="Porras" }
        };

        public IEnumerable<Estudiante> GetAllEstudiante()
        {
            return ListaEstudiantes;
        }

        public IHttpActionResult GetEstudiante(string id)
        {
            Estudiante objEstudiante = ListaEstudiantes.FirstOrDefault((x) => x.idEstudiante.Equals(id));

            if (objEstudiante != null)
            {
                return Ok(objEstudiante);
            }
            else
            {
                return NotFound();
            }
           
        }
    }
}
