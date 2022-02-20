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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_BMI_Page_Click(object sender, EventArgs e)
        {
            //shows BMI form elements
            BMI_pic.Visible = true;
            btn_BMI_result.Visible = true;
        }

        private void btn_BodyFat_Page_Click(object sender, EventArgs e)
        {
            //Removes BMI form elements
            BMI_pic.Visible = false;
            btn_BMI_result.Visible = false;
        }

        #region BMI API call
        private async void btn_BMI_result_Click(object sender, EventArgs e)
        {
            //Make call to API
            var client = new RestClient($"https://fitness-calculator.p.rapidapi.com/bmi?age={age_Box.Text}&weight={Convert.ToInt32(weight_Box.Text)}&height={Convert.ToInt32(height_Box.Text)}");
            var request = new RestRequest("", Method.Get);
            

            //authenticate
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");

            //retrieve data
            //get response from API
            var BMIresponse = await client.ExecuteAsync(request);
            request.AddParameter("ID", Guid.NewGuid(), ParameterType.QueryString);
            request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            //test response
            MessageBox.Show(BMIresponse.Content);


            //assign user inputs to header values : not used
            var userDeets = new BMIData
            {
                age = Convert.ToInt32(age_Box.Text),
                height = Convert.ToInt32(height_Box.Text),
                weight = Convert.ToInt32(weight_Box.Text)
            };

            if (age_Box.Text == "" && height_Box.Text == "" && weight_Box.Text == "")
            {
                MessageBox.Show("Please input a value!");
            }

            //Deserialize json response 
            //details deserialiser
            var myDataDeserializer = new SystemTextJsonSerializer();
            BMIData DataDetails = myDataDeserializer.Deserialize<BMIData>(BMIresponse);
            //calculation deserialiser
            var DeserialiseHealthCalc = new SystemTextJsonSerializer();
            BMICalculator healthCalc = DeserialiseHealthCalc.Deserialize<BMICalculator>(BMIresponse);


            //test reponse 
            MessageBox.Show($"Bmi = {healthCalc.data.bmi}\nHealth = {healthCalc.data.health}\nBmi Healthy range = {healthCalc.data.healthy_bmi_range}");

        }
        #endregion BMI API call

        #region BodyFat API Call

        private void btn_BodyFat_calc_Click(object sender, EventArgs e)
        {

        }

        #endregion Body Fat API Call

        #region BMI classes
        public class BMIData
        {
            public double bmi { get; set; }
            public string health { get; set; }
            public string healthy_bmi_range { get; set; }

            public int age { get; set; }

            public int height { get; set; }

            public int weight { get; set; }
        }

        public class BMICalculator
        {
            public int status_code { get; set; }
            public string request_result { get; set; }
            public BMIData data { get; set; }
        }

        #endregion BMI Classes

        #region Body Fat Classes
        public class BodyFatData
        {
            [JsonProperty("Body Fat (U.S. Navy Method)")]
            public double BodyFatUSNavyMethod { get; set; }

            [JsonProperty("Body Fat Category")]
            public string BodyFatCategory { get; set; }

            [JsonProperty("Body Fat Mass")]
            public double BodyFatMass { get; set; }

            [JsonProperty("Lean Body Mass")]
            public double LeanBodyMass { get; set; }

            [JsonProperty("Body Fat (BMI method)")]
            public double BodyFatBMIMethod { get; set; }
        }

        public class BodyFatRoot
        {
            public int status_code { get; set; }
            public string request_result { get; set; }
            public BodyFatData data { get; set; }
        }

        #endregion Body Fat Classes
    }
}
