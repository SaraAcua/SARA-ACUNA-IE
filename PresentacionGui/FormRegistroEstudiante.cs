using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    public partial class FormRegistroEstudiante : Form
    {
        public FormRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.TipoId =cmboTipoId.Text;
            estudiante.NumeroId = txtId;
            estudiante.Nombre = TxtNombre.Text;
            estudiante.Grado = cmboGrado.Text;
            estudiante.Institucion = cmboInstitucion;
            InstitucionService service = new InstitucionService();
            string mensaje = service.Guardar(estudiante);
            MessageBox.Show(mensaje);
        }
            catch (Exception)
            {
                MessageBox.Show("Datos imcompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}
    }
}
