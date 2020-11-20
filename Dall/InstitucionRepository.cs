using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dall
{
    public class InstitucionRepository
    {
        private readonly string FileName = "IE.txt";
        private readonly string FileNameEs = "Estudiantes.txt";


        Estudiante estudiante;

        public List<Institucion> ConsultarTodos()
        {

            List<Institucion> lista = new List<Institucion>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Institucion institucion = Map(linea);
                lista.Add(institucion);
            }
            reader.Close();
            file.Close();
            return lista;
        }
         public bool ValidarDisponibilidad(string tipoIE)
        {
            List<Institucion> institucions = ConsultarTodos();
            foreach (Institucion institucion in institucions )
            {
                if ((institucion.CupoDisponible ==0) &&(institucion.NombreInstitucion== tipoIE))
                {
                    return false;
                }
            }
            return true;

        }

        public int CupoDisponible(string tipoIE)
        {
            List<Institucion> institucions = ConsultarTodos();
            int total = 0;
            foreach (Institucion institucion in institucions)
            {
                if (( (institucion.NombreInstitucion == tipoIE)))
                {
                    total = institucion.CupoDisponible;
                    break;
                }
            }
            return total;

        }

        public List<Estudiante> ConsultarTodosEstudiantes()
        {
            List<Estudiante> lista = new List<Estudiante>();
            FileStream file = new FileStream(FileNameEs, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Estudiante estudiante = Mapeo(linea);
                lista.Add(estudiante);
            }
            reader.Close();
            file.Close();
            return lista;
        }


        public void Guardar(Estudiante estudiante)
        {
            FileStream file = new FileStream(FileNameEs, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{estudiante.TipoId};{estudiante.NumeroId};" +
              $"{estudiante.Nombre};{estudiante.Grado};" +
              $"{estudiante.Institucion};");

            writer.Close();
            file.Close();
        }
        private bool Encontrado(string idEstudiante, string idEstudianteBuscado)
        {
            return idEstudiante == idEstudianteBuscado;

        }
        public List<Estudiante> ConsultarAtodos()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            FileStream file = new FileStream(FileNameEs, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                Estudiante estudiante = Mapeo(linea);
                estudiantes.Add(estudiante);
            }
            reader.Close();
            file.Close();
            return estudiantes;

        }
        public Estudiante Buscar(string numeroId)
        {
            List<Estudiante> liquidacionCuotaModeradoras = ConsultarAtodos();
            foreach (var item in liquidacionCuotaModeradoras)
            {
                if (Encontrado(item.NumeroId, numeroId))
                {
                    return item;
                }
            }
            return null;
        }
        private Institucion Map(string linea)
        {
            Institucion institucion;
            char delimeter = ';';
            string[] vector = linea.Split(delimeter);
            institucion = new Institucion();
            institucion.Codigo = vector[0];
            institucion.NombreInstitucion = vector[1];
            institucion.CuposAprobados = int.Parse(vector[2]);
            institucion.CupoDisponible = int.Parse(vector[3]);

            return institucion;
        }

        private Estudiante Mapeo(string linea)
        {

            char delimeter = ';';
            string[] vector = linea.Split(delimeter);
            estudiante = new Estudiante();

            estudiante.TipoId = vector[0];
            estudiante.NumeroId = vector[1];
            estudiante.Nombre = vector[2];
            estudiante.Grado = vector[3];
            estudiante.Institucion = vector[4];
            return estudiante;
        }
    

    public string Modificar(string institucion)
    {
        FileStream file = new FileStream("Temporal.txt", FileMode.Create);
        StreamWriter escribir = new StreamWriter(file);
        FileStream fileReader = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader leer = new StreamReader(fileReader);

        string linea = string.Empty;
        bool encontrado = false;
        while ((linea = leer.ReadLine()) != null)
        {
            Institucion institucion1 = Map(linea);
                if (institucion1.NombreInstitucion == institucion)
            {
                encontrado = true;

              institucion1.CupoDisponible = (institucion1.CupoDisponible) - 1;

                escribir.WriteLine(institucion1.FormatoArchivo());

            }
            else
            {
                escribir.WriteLine(institucion1.FormatoArchivo());
            }

        }
        leer.Close();
        escribir.Close();
        File.Delete("IE.txt");
        File.Move("Temporal.txt", "IE.txt");
        if (encontrado == false)
        {
            return "no se encontró ese registro";
        }
        else
        {
            return "se encontró el registro y se modificó";
        }
    }




        public List<Institucion> FiltroPorTipo(string tipo)
        {
            List<Institucion> institucions = ConsultarTodos();
            List<Institucion> institucionesFiltradas =
                (from c in institucions
                 where c.NombreInstitucion == tipo
                 select c).ToList();
            return institucionesFiltradas;
        }
        public List<Estudiante> FiltroPorTipoIes(string tipo)
        {
            List<Estudiante> estudiantes= ConsultarTodosEstudiantes();
            List<Estudiante> estudiantesFiltradas =
                (from c in estudiantes
                 where c.Institucion == tipo
                 select c).ToList();
            return estudiantesFiltradas;
        }
        public int ContarCupo(int cupo)
        {
            return ConsultarTodos().Count(p => p.CupoDisponible.Equals(cupo));
        }
        public int ContarEstudiante(string estudiante)
        {
            return ConsultarTodosEstudiantes().Count(p => p.Institucion.Equals(estudiante));
        }




    }
}



