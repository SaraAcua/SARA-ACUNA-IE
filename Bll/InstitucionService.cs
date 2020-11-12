using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dall;
using Entity;

namespace Bll
{
    public class InstitucionService
    {
        InstitucionRepository institucionRepository;
        public InstitucionService()
        {
            institucionRepository = new InstitucionRepository();
        }


        public IntitucionResponse Consultar()
        {
            try
            {
                List<Institucion> institucion = institucionRepository.ConsultarTodos();
                if (institucion != null)
                {
                    var response = new IntitucionResponse(institucion);
                    return response;
                }
                else
                {
                    var response = new IntitucionResponse("No se encontro ");
                    return response;
                }

            }
            catch (Exception e)
            {
                var response = new IntitucionResponse("Error de Aplicacion:" + e.Message);
                return response;
            }

        }
    }
    public class IntitucionResponse
    {
        Institucion institucion;

        public List<Institucion> Institucions { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }


        public IntitucionResponse(string message)
        {
            Error = true;
            Message = message;
        }
        public IntitucionResponse(List<Institucion> institucion)
        {
            Institucions = institucion;
            Error = false;
        }

        public IntitucionResponse(Institucion institucion)
        {
            this.institucion = institucion;
        }
    }

}
