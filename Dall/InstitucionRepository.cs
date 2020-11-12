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
        private Institucion Map(string linea)
        {
            Institucion institucion;
            char delimeter = ';';
            string[] vector = linea.Split(delimeter);
            institucion = new Institucion();
            institucion.Codigo = vector[0];
            institucion.NombreInstitucion = vector[1];
            institucion.CuposAprobados = int.Parse( vector[2]);
            institucion.CupoDisponible= int.Parse(vector[3]);

            return institucion;
        }
    
    private Estudiante Mapeo(string linea)
        {
           
            char delimeter = ';';
            string[] vectorContratacion = linea.Split(delimeter);
            if (vectorContratacion[0] == "IE NACIONAL LOPERENA")
            {
                estudiante = new Estudiante();
            }
            if (vectorContratacion[0] == "PUDENCIA DAZA")
            {
                estudiante = new Estudiante();
            }
            if (vectorContratacion[0]=="SAN JOAQUIN")
            {
                estudiante = new Estudiante();
            }
            if ((vectorContratacion[0] == "FRANCISCO MOLINA SANCHEZ"))
            {
                estudiante = new Estudiante();
            }
            else
            {
            }

            estudiante.TipoId= vectorContratacion[0];
            estudiante.NumeroId= vectorContratacion[1];
                estudiante.Nombre= vectorContratacion[2];
               estudiante.Grado = vectorContratacion[3];
                estudiante.Institucion = vectorContratacion[4];
            return estudiante;
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
        public int ContarCupo(int cupo)
        {
            return ConsultarTodos().Count(p => p.CupoDisponible.Equals(cupo));
        }
    }

}
