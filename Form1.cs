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

        #region buttons
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            age_Box.Text = "";
            weight_Box.Text = "";
            height_Box.Text = "";
            Gender_box.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            results_Box.Text = "";
        }

        #endregion buttons

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

                
                //details deserialised response
                var BMIDataDeserializer = new SystemTextJsonSerializer();
                BMIdata BMIDataDetails = BMIDataDeserializer.Deserialize<BMIdata>(BMIresponse);
                //calculation deserialiser
                var DeserialiseBMICalc = new SystemTextJsonSerializer();
                BMICalculator BMICalc = DeserialiseBMICalc.Deserialize<BMICalculator>(BMIresponse);

                //Cleaned up reponse : tostring method
                results_Box.Text = $"Bmi = {BMICalc.data}\r\n";

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
                results_Box.Text = ($"Ideal weight results below: \r\n\r\n" + deserialisedIdealWeightCalc.data);
                    
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        #endregion Body Fat API Call

       
    }
}
