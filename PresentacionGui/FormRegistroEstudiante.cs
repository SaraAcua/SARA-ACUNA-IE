using Bll;
using Entity;
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
           
            cmboInstitucion.Items.Add("IE NACIONAL LOPERENA");
            cmboInstitucion.Items.Add("PUDENCIA DAZA");
            cmboInstitucion.Items.Add("SAN JOAQUIN");
            cmboInstitucion.Items.Add("FRANCISCO MOLINA SANCHEZ");
            cmboInstitucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboGrado.Items.Add("JARDIN");
            cmboGrado.Items.Add("PRE-JARDIN");
            cmboGrado.Items.Add("TRANSICION");
            cmboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboTipoId.Items.Add("RC");
            cmboTipoId.Items.Add("TI");
            cmboTipoId.Items.Add("CC");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)

        {
            try
            {


                Estudiante estudiante = new Estudiante();
                estudiante.TipoId = cmboTipoId.Text;
                estudiante.NumeroId = txtId.Text;
                estudiante.Nombre = txtNombre.Text;
                estudiante.Grado = cmboGrado.Text;
                estudiante.Institucion = cmboInstitucion.Text;
                InstitucionService service = new InstitucionService();
                string mensaje = service.Guardar(estudiante);
                MessageBox.Show(mensaje);
            }
            catch
            {
                MessageBox.Show("Datos imcompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
    

