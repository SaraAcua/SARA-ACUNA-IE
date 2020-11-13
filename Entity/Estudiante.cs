using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Estudiante
    {
        public Estudiante() { }
        public Estudiante(string tipoId, string numeroId, string nombre,  string grado, string Intitucion)
        {
            TipoId = tipoId;
            NumeroId = numeroId;
            Nombre = nombre;
            Grado = grado;
            Institucion = Institucion;
        }
        public string TipoId { get; set; }
        public string NumeroId { get; set; }
        public string Nombre { get; set; }
        public string Grado { get; set; }
        public string Institucion { get; set; }

        public override string ToString()
        {
            return $"tipoid: {TipoId}-identificacion: {NumeroId} - nombre:{Nombre}-grado:{Grado}-institucion{Institucion}";
        }

        public static implicit operator List<object>(Estudiante v)
        {
            throw new NotImplementedException();
        }
    }
}

