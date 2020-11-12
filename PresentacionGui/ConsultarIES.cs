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

            if (cmboIes.Text.Equals("Todos"))
            {
                ConsultarTodos();
                //lblConteo.Text = "----";
            }
            else
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
    }
}
