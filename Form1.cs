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
using System.Text.Json;
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
            
            //shows BMI form elements
            BMI_pic.Visible = true;
            btn_BMI_result.Visible = true;
            weight_Box.Visible = true;
            weight_Label.Visible = true;
            //remove ideal weight form elements
            btn_IdealWeight_calc.Visible = false;
            BodyFat_pic.Visible = false;
            Gender_box.Visible = false;
            gender_label.Visible = false;
            
        }

        private void btn_BMI_Page_Click(object sender, EventArgs e)
        {
            //shows BMI form elements
            BMI_pic.Visible = true;
            btn_BMI_result.Visible = true;
            weight_Box.Visible = true;
            weight_Label.Visible = true;
            //remove ideal weight form elements
            btn_IdealWeight_calc.Visible = false;
            BodyFat_pic.Visible = false;
            Gender_box.Visible = false;
            gender_label.Visible = false;
            
        }

        private void btn_BodyFat_Page_Click(object sender, EventArgs e)
        {
            //Removes BMI form elements
            BMI_pic.Visible = false;
            btn_BMI_result.Visible = false;
            weight_Box.Visible = false;
            weight_Label.Visible = false;
            //show ideal weight form elements
            btn_IdealWeight_calc.Visible = true;
            BodyFat_pic.Visible = true;
            Gender_box.Visible = true;
            gender_label.Visible = true;
            
        }

        #region BMI API call
        private async void btn_BMI_result_Click(object sender, EventArgs e)
        {
            try
            {
                //Make call to API
                var client = new RestClient($"https://fitness-calculator.p.rapidapi.com/bmi?age={Convert.ToInt32(age_Box.Text)}&weight={Convert.ToInt32(weight_Box.Text)}&height={Convert.ToInt32(height_Box.Text)}");
                var request = new RestRequest("", Method.Get);


                //authenticate
                request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");

                //retrieve data
                //get response from API with parameters/headers
                var BMIresponse = await client.ExecuteAsync(request);
                request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");

                //test response
                //MessageBox.Show(BMIresponse.Content);


                //Deserialize json response 
                //details deserialiser
                var myDataDeserializer = new SystemTextJsonSerializer();
                BMIData DataDetails = myDataDeserializer.Deserialize<BMIData>(BMIresponse);
                //calculation deserialiser
                var DeserialiseBMICalc = new SystemTextJsonSerializer();
                BMICalculator BMICalc = DeserialiseBMICalc.Deserialize<BMICalculator>(BMIresponse);

                //Cleaned up reponse : maybe add to a text box for permanence on page
                MessageBox.Show($"Bmi = {BMICalc.data.bmi}\n" +
                                $"Health = {BMICalc.data.health}\n" +
                                $"Bmi Healthy range = {BMICalc.data.healthy_bmi_range}");

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
        #endregion BMI API call


        #region BodyFat API Call
        private async void btn_IdealWeight_calc_Click(object sender, EventArgs e)
        {
            try {
                //talk to api
                var client = new RestClient($"https://fitness-calculator.p.rapidapi.com/idealweight?gender={Gender_box.Text}&height={Convert.ToInt32(height_Box.Text)}");
                var request = new RestRequest("", Method.Get);

                //add headers / parameters
                request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
                request.AddHeader("x-rapidapi-key", "ec6dc6e4bcmsh87299e3b4d9f6b4p1e413fjsn10f7f37e01ba");
                var idealWeightResponse = await client.ExecuteAsync(request);

                //test json response
                MessageBox.Show(idealWeightResponse.Content);

                //deserialize response
                //Ideal weight Data
                var idealWeightDataDeserialiser = new SystemTextJsonSerializer();
                IdealWeightData deserialisedIdealWeightData = idealWeightDataDeserialiser.Deserialize<IdealWeightData>(idealWeightResponse);

                //calculation
                var idealWeightCalcDeserialiser = new SystemTextJsonSerializer();
                IdealWeightCalculation deserialisedIdealWeightCalc = idealWeightDataDeserialiser.Deserialize<IdealWeightCalculation>(idealWeightResponse);



                //display response
                results_Box.Text = ($"Ideal weight results below: \n\n" +
                                    $"Using Hamwi formula: {deserialisedIdealWeightCalc.data.Hamwi} Kg\n" +
                                    $"Using Devine formula: {deserialisedIdealWeightCalc.data.Devine} Kg\n" +
                                    $"Using Miller formula: {deserialisedIdealWeightCalc.data.Miller} Kg\n" +
                                    $"Using Robinson formula: {deserialisedIdealWeightCalc.data.Robinson} Kg");
                    
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        #endregion Body Fat API Call

        #region


        #endregion

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

        #region Ideal Weight Classes

        public class IdealWeightData
        {
            public double Hamwi { get; set; }
            public double Devine { get; set; }
            public double Miller { get; set; }
            public double Robinson { get; set; }
        }

        public class IdealWeightCalculation
        {
            public int status_code { get; set; }
            public string request_result { get; set; }
            public IdealWeightData data { get; set; }
        }

        #endregion Ideal Weight Classes
    }
}
