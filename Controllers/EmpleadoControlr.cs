using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestApi.Models;

namespace TestApi.Controllers
{

    [ApiController]
    public class EmpleadoControlr : ControllerBase
    {
        [Route("api/obtenerEmpleado")]
        [HttpGet]

        public ActionResult obternerEmpleado(int idEmpleado)
        {
            var objetoEmpleado = new RootObject();
            objetoEmpleado.empleados = new List<EmpleadoDto>
            {
            new EmpleadoDto {id = 1, nombre = "Diana", edad=20, salario=180},
            new EmpleadoDto {id = 2, nombre = "Ana", edad=20, salario=180},
            new EmpleadoDto {id = 3, nombre = "Camilo", edad=20, salario=180},
            new EmpleadoDto {id = 4, nombre = "PEdro", edad=20, salario=180},
            new EmpleadoDto {id = 5, nombre = "Jorge", edad=20, salario=180},

            };

            EmpleadoDto empleado = new EmpleadoDto();
            foreach (var item in objetoEmpleado.empleados)
            {
                if(item.id == idEmpleado)
                {
                    empleado.id = item.id;
                    empleado.nombre = item.nombre;
                    empleado.edad = item.edad;
                    empleado.salario = item.salario;
                }

            }

            var respuesta = JsonConvert.SerializeObject(empleado);
                return Ok(respuesta);


        }

    }
}
