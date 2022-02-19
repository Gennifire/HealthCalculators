using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serializers.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HealthCalculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //when form loads
            //Connect to from calculation API
            var client = new RestClient("https://fitness-calculator.p.rapidapi.com/bmi?age=23&weight=65&height=180");

            var request = new RestRequest("", Method.Get);
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");
            request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");

            
            //test get response from BMI API
            var BMIresponse = await client.ExecuteAsync(request);
            MessageBox.Show(BMIresponse.Content);
        }

        private async void btn_BMI_Page_Click(object sender, EventArgs e)
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

            var client = new RestClient($"https://fitness-calculator.p.rapidapi.com/bmi?age={age_Box.Text}&weight={Convert.ToInt32(weight_Box.Text)}&height={Convert.ToInt32(height_Box.Text)}");
            //var request = new RestRequest("/bmi", Method.Get) { RequestFormat = DataFormat.Json }
               // .AddBody("/bmi?age={age_Box.Text}&weight=weightValue&height=heightValue");

            var request = new RestRequest("", Method.Get);
            request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
            //header alters the 
            //request.AddHeader("https://fitness-calculator.p.rapidapi.com", $"/bmi?age={age_Box.Text}&weight={weight_Box.Text}&height={height_Box.Text}");

            //authenticate
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");


            //var client = new RestClient("https://fitness-calculator.p.rapidapi.com/bmi?age=23&weight=65&height=180");
            //var request = new RestRequest("bmi", Method.Post);
            //request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");
            //request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
            request.AddHeader($"bmi?age={age_Box.Text}&weight={Convert.ToInt32(weight_Box.Text)}&height={Convert.ToInt32(height_Box.Text)}", "https://fitness-calculator.p.rapidapi.com/bmi?age={age_Box.Text}&weight={Convert.ToInt32(weight_Box.Text)}&height={Convert.ToInt32(height_Box.Text)}");

            ////get response from API
            var BMIresponse = await client.ExecuteAsync(request);

            //Deserialize json response
            var myDataDeserializer = new SystemTextJsonSerializer();
            Data DataDetails = myDataDeserializer.Deserialize<Data>(BMIresponse);

           

            //retrieve data
            request.AddParameter("ID", Guid.NewGuid(), ParameterType.QueryString);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            //to test reponse
            MessageBox.Show(DataDetails.health);

        }

        public class Data
        {
            public double bmi { get; set; }
            public string health { get; set; }
            public string healthy_bmi_range { get; set; }

            public int age { get; set; }

            public int height { get; set; }

            public int weight { get; set; }
        }

        public class HealthCalculator
        {
            public int status_code { get; set; }
            public string request_result { get; set; }
            public Data data { get; set; }
        }

    }
}
