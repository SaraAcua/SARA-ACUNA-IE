using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Institucion
    {

        public Institucion()
        {
        }
        public Institucion(string codigo, string nombreInstitucion, int cupoAprobado, int cupoDisponible)
        {

            Codigo = codigo;
            NombreInstitucion = nombreInstitucion;
            CuposAprobados = cupoAprobado;
            CupoDisponible = cupoDisponible;
        }



        public string Codigo { get; set; }
        public string NombreInstitucion { get; set; }
        public int CuposAprobados { get; set; }
        public int CupoDisponible { get; set; }

        public override string ToString()
        {
            return $"Codigon: {Codigo}-Nombre Institucion: {NombreInstitucion} - cupo aprobado:{CuposAprobados}-cupo disponible:{CuposAprobados}";
        }
    }
}


