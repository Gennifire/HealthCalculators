using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serializers.Json;


namespace HealthCalculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BMI_Page_Click(object sender, EventArgs e)
        {
            //shows BMI form elements
            BMI_pic.Visible = true;
            btn_BMI_result.Visible = true;
        }

        private void btn_Macro_Page_Click(object sender, EventArgs e)
        {
            //Removes BMI form elements
            BMI_pic.Visible = false;
            btn_BMI_result.Visible = false;
        }

        private async void btn_BMI_result_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://fitness-calculator.p.rapidapi.com/bmi?age=23&weight=65&height=180");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");
            request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
           // request.AddParameter(/bmi?age=ageValue&weight=weightValue&height=heightValue);


            //get response from API
            var response = await client.ExecuteAsync(request);
           

            //Deserialize json response
            var myDes = new SystemTextJsonSerializer();
            data temp = myDes.Deserialize<data>(response);
            MessageBox.Show(response.Content);

            //get and set user inputs
            //get age
            temp.age = age_Box.Text;
            //get height
            temp.height = (height_Box.Text);
            //get weight
            temp.weight = (weight_Box.Text);

            
            
           
                results_Box.Text += temp.age;
            
            
              
            

        }

       public class data
        {
            public string age { get; set; }

            public string weight { get; set; }

            public string height { get; set; }
        }

    }
}
