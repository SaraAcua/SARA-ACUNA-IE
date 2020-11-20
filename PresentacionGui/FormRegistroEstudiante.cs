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
            cmboInstitucion.Items.Add("PRUDENCIA DAZA");
            cmboInstitucion.Items.Add("SAN JOAQUIN");
            cmboInstitucion.Items.Add("FRANCISCO MOLINA SANCHEZ");
            cmboInstitucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboGrado.Items.Add("JARDIN");
            cmboGrado.Items.Add("PRE-JARDIN");
            cmboGrado.Items.Add("TRANSICION");
            cmboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboTipoId.Items.Add("RC");
            cmboTipoId.Items.Add("TI");
            cmboTipoId.Items.Add("CC");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)

        {
            InstitucionService service = new InstitucionService();
            try
            {
                if (cmboTipoId.Text.Equals("") || txtId.Text.Equals("") || txtNombre.Text.Equals("") ||
                    cmboGrado.Text.Equals("") || cmboInstitucion.Text.Equals(""))
                {
                    MessageBox.Show("Datos imcompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if(! service.ValidarDisponibilidad(cmboInstitucion.Text)) 
                {
                    MessageBox.Show("No hay cupos disponibles en " + cmboInstitucion.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.TipoId = cmboTipoId.Text;
                    estudiante.NumeroId = txtId.Text;
                    estudiante.Nombre = txtNombre.Text;
                    estudiante.Grado = cmboGrado.Text;
                    estudiante.Institucion = cmboInstitucion.Text; 
                    service.Guardar(estudiante);
                    ActualizarCuposDisponibles();
                    MessageBox.Show(" Se registro el estudiante correctamente, cupos disponibles: "+service.CupoDisponible(cmboInstitucion.Text)," Informacion", MessageBoxButtons.OK);
                    LimpiarTxt();
                    
                    
                }

            }

            catch
            { }

        }
        void LimpiarTxt()
        {
            cmboTipoId.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            cmboGrado.Text = "";
            cmboInstitucion.Text = "";

        }
        public void ActualizarCuposDisponibles()
        {
            InstitucionService service = new InstitucionService();
            string message = service.Modificar(cmboInstitucion.Text);
        }
    }
}
    

