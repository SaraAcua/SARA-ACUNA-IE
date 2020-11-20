using Bll;
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
    public partial class FormConsultaEstudiantesInscritos : Form
    {

        InstitucionService service = new InstitucionService();
        public FormConsultaEstudiantesInscritos()
        {
            InitializeComponent();
             cmboIes.Items.Add("Todos");
            cmboIes.Items.Add("IE NACIONAL LOPERENA");
            cmboIes.Items.Add("PRUDENCIA DAZA");
            cmboIes.Items.Add("SAN JOAQUIN");
            cmboIes.Items.Add("FRANCISCO MOLINA SANCHEZ");
            cmboIes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultarEs_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboIes.Text.Equals(""))
                {
                    MessageBox.Show("No ha seleccionado una IES", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (cmboIes.Text.Equals("Todos"))
                {
                    ConsultarTodos();
                    lblConteo.Visible = false;
                    lblConteocuposdisponibles.Visible = false;
                    
                  
                }
                else
                {
                    FiltroTipo();
                    ContarEstudiante();
                    lblConteo.Visible = true;
                    lblConteocuposdisponibles.Visible = true;

                }
            }
            catch
            {

            }
        }


       
        private void ConsultarTodos()
        {
            var response = service.ConsultarEsTodos();
            if (response.ErrorEs == false)
            {
                dataGVEs.DataSource = response.Estudiantes;
            }
            else
            {
                MessageBox.Show( "Informacion de Consulta","No existen registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void FiltroTipo()
        {
            var response = service.ConsultarEs(cmboIes.Text);
            if (response.ErrorEs== false)
            {
                dataGVEs.DataSource = response.Estudiantes;
            }
            else
            {
                MessageBox.Show("informacion");
            }
        }
        private void ContarEstudiante()
        {
            int cantidad = 0;
            cantidad = service.ContarEs(cmboIes.Text);
            if (cantidad != 0)
            {
                lblConteocuposdisponibles.Text = " " + cantidad;
            }
            else
            {
                lblConteocuposdisponibles.Text = "0";
              //  MessageBox.Show("No existen registros : " + cmboIes.Text, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        }
    }

