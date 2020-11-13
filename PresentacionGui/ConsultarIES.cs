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
    public partial class ConsultarIES : Form
    {
    
        public ConsultarIES()
        {
            InitializeComponent();
            cmboIes.Items.Add("Todos");
            cmboIes.Items.Add("IE NACIONAL LOPERENA");
            cmboIes.Items.Add("PUDENCIA DAZA");
            cmboIes.Items.Add("SAN JOAQUIN");
            cmboIes.Items.Add("FRANCISCO MOLINA SANCHEZ");
            cmboIes.DropDownStyle = ComboBoxStyle.DropDownList;
        }




        private void btnConsultarIes_Click(object sender, EventArgs e)
        {
            try
            {


                if (cmboIes.Text.Equals("Todos"))
                {
                    ConsultarTodos();
                    ContarCupoSDisponible();
                }
                else
                {
                    FiltroTipo();
                    ContarCupoSDisponible();
                }
            }
            catch
            {

            }

        }

        InstitucionService service = new InstitucionService();
        private void ConsultarTodos()
        {
            var respuesta = service.Consultar();
            if (respuesta.Error==false)
            {
                dataGVIes.DataSource = respuesta.Institucions;
            }
            else
            {
                MessageBox.Show(respuesta.Message, "Informacion de Consulta");
            }

        }
        private void FiltroTipo()
        {
            var response = service.ConsultarTipo(cmboIes.Text);
            if (response.Error == false)
            {
                dataGVIes .DataSource = response.Institucions;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void ContarCupoSDisponible()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGVIes.Rows)
            {
                total += Convert.ToInt32(row.Cells["CupoDisponible"].Value);
                service.Contarcupo(total);
                if (total !=0)
                {
                    lblConteocuposdisponibles.Text = Convert.ToString(total);
                }
                else{
                    lblConteocuposdisponibles.Text = "0";
                }
            }
        }

        private void lblConteocuposdisponibles_Click(object sender, EventArgs e)
        {

        }

        private void dataGVIes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmboIes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

