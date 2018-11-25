using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceForm.ServiceWebFX;

namespace WebServiceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnshowservice_Click(object sender, EventArgs e)
        {

            ServiceWebFX.WebServiceFXSoapClient client = new WebServiceFXSoapClient();
            ///////////////////////
            // enter by user
            //
            //int numberfab = Convert.ToInt32(txtnumberfab.Text);
            //var reponse =Convert.ToString(client.Fibonacci(numberfab));
            //
            //////////////////

            await Task.Run(() =>
            {
                var reponse = Convert.ToString(client.Fibonacci(10));
                MessageBox.Show(reponse);
                Thread.Sleep(2000); // Arrête la tâche pendant 2 secondes
            });

           
            //Result.Text =Convert.ToString(reponse);
            
        }

        private async void btnshowxmltojson_Click(object sender, EventArgs e)
        {
            ServiceWebFX.WebServiceFXSoapClient client = new WebServiceFXSoapClient();

            await Task.Run(() =>
            {
                var resultxmltojson = client.XmlToJson(textxmltojson.Text);
                MessageBox.Show(resultxmltojson);
                //bxresult.Text = resultxmltojson;
                Thread.Sleep(2000); // Arrête la tâche pendant 2 secondes

            });

        }
    }
}
