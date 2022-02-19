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
            var client = new RestClient("https://fitness-calculator.p.rapidapi.com/dailycalorie?age=25&gender=male&height=180&weight=70&activitylevel=level_1");
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

            var client = new RestClient("https://fitness-calculator.p.rapidapi.com/dailycalorie?age=25&gender=male&height=180&weight=70&activitylevel=level_1");

            var request = new RestRequest("/bmi", Method.Post) { RequestFormat = DataFormat.Json }
                .AddBody("/bmi?age=ageValue&weight=weightValue&height=heightValue");

            //auth
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");


            // Handle response errors
            //HandleResponseErrors(response);

            //if (Errors.Length == 0)
            //{ }
            //else
            //{ }

            //var client = new RestClient("https://fitness-calculator.p.rapidapi.com/bmi?age=23&weight=65&height=180");
            //var request = new RestRequest("bmi", Method.Post);
            //request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");
            //request.AddHeader("x-rapidapi-host", "fitness-calculator.p.rapidapi.com");
            ////request.AddParameter("", "bmi?age=ageValue&weight=weightValue&height=heightValue");
            ////request.AddParameter("ageValue&heightValueweightValue");

            ////get response from API
            var BMIresponse = await client.ExecuteAsync(request);

            //Deserialize json response
            var myDes = new SystemTextJsonSerializer();
          
            Getdata DesDetails = myDes.Deserialize<Getdata>(BMIresponse);

            

           


            //retrieve data
            request.AddParameter("ID", Guid.NewGuid(), ParameterType.QueryString);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddBody(new { ageValue = age_Box.Text, heightValue = height_Box.Text, weightValue = weight_Box.Text });

            //to test reponse
            MessageBox.Show(BMIresponse.Content);

            //get and set user inputs
            JObject jObject = new JObject();

            jObject.Add(DesDetails);
            DesDetails.ageValue = Convert.ToInt32(age_Box.Text);
            if (DesDetails.ageValue <=0 || DesDetails.ageValue > 80)
            {
                MessageBox.Show("Please enter an appropriate age");
            }

            jObject.Add("age", age_Box.Text);
            jObject.Add("Height", height_Box.Text);
            results_Box.Text += DesDetails.bmi;
            
        }

       public class Getdata
       {
            public int bmi { get; set; }
            public int ageValue { get; set; }

            public string genderValue { get; set; }

            public int weightValue { get; set; }

            public int heightValue { get; set; }

            public int neckValue { get; set; }

            public int waistValue { get; set; }

            public string activityLevel { get; set; }

       }

       

        
    }
}
