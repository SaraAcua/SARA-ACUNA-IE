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
        public bool ValidarExisteArchivo()
        {
            if (institucionRepository.ConsultarTodos().Count()==0)
            {
                return true;
            }
            else {

                return false;           
            }
        }

        public bool ValidarDisponibilidad(string tipoIE)
        {
            return institucionRepository.ValidarDisponibilidad(tipoIE);
        }

        public EstudianteResponse ConsultarEs(string tipo)
        {
            try
            {
                List<Estudiante> estudiantes = institucionRepository.FiltroPorTipoIes(tipo);
                if (estudiantes != null)
                {
                    var response = new EstudianteResponse(estudiantes);
                    return response;
                }
                else
                {
                    var response = new EstudianteResponse("No se encontro el registro ");
                    return response;
                }

            }
            catch (Exception e)
            {
                var response = new EstudianteResponse("Error de Aplicacion:" + e.Message);
                return response;
            }

        }
        public EstudianteResponse ConsultarEsTodos()
        {
            try
            {
                List<Estudiante> estudiantes = institucionRepository.ConsultarAtodos();
                if (estudiantes != null)
                {
                    var response = new EstudianteResponse(estudiantes);
                    return response;
                }
                else
                {
                    var response = new EstudianteResponse("No se encontro el registro ");
                    return response;
                }

            }
            catch (Exception e)
            {
                var response = new EstudianteResponse("Error de Aplicacion:" + e.Message);
                return response;
            }

        }
        public IntitucionResponse ConsultarTipo(string tipo)
        {
            try
            {
                List<Institucion> institucion = institucionRepository.FiltroPorTipo(tipo);
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

        public int CupoDisponible(string tipoIE)
        {
            return institucionRepository.CupoDisponible(tipoIE);
        }
        public int Contarcupo(int cupo)
        {
            int conteo = 0;
            conteo = institucionRepository.ContarCupo(cupo);
            return conteo;
        }
        public int ContarEs(string estudiante)
        {
            int conteo = 0;
            conteo = institucionRepository.ContarEstudiante(estudiante);
            return conteo;
        }
        

        public string Guardar(Estudiante estudiante)
        {

            try
            {

                if (institucionRepository.Buscar(estudiante.NumeroId) == null)
                {
                    institucionRepository.Guardar(estudiante);
                   

                    return "Se guardaron los datos de manera exitosa";
                }
                return "No es posible guardar los datos";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        public string Modificar(string institucion)
        {
          
            return institucionRepository.Modificar(institucion);
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
    public class EstudianteResponse
    {
        Estudiante estudiante;

        public List<Estudiante> Estudiantes { get; set; }
        public string MessageEs { get; set; }
        public bool ErrorEs { get; set; }


        public EstudianteResponse(string message)
        {
            ErrorEs = true;
            MessageEs = message;
        }
        public EstudianteResponse(List<Estudiante> estudiante)
        {
            Estudiantes = estudiante;
            ErrorEs = false;
        }

        public EstudianteResponse(Estudiante estudiante)
        {
            this.estudiante = estudiante;
        }




    }
}
