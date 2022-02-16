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

        }

        private void btn_Macro_Page_Click(object sender, EventArgs e)
        {
            BMI_pic.Visible = false;
            btn_BMI_result.Visible = false;
        }

        private void btn_BMI_result_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://bmi.p.rapidapi.com/");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddHeader("x-rapidapi-key", "8c12547588msh5afaecc61abe785p1b6facjsn74f4a83ef1d6");
            request.AddHeader("x-rapidapi-host", "bmi.p.rapidapi.com");
            request.AddParameter("application/json", "{\r\n    \"weight\": {\r\n        \"value\": \"85.00\",\r\n        \"unit\": \"kg\"\r\n    },\r\n    \"height\": {\r\n        \"value\": \"170.00\",\r\n        \"unit\": \"cm\"\r\n    },\r\n    \"sex\": \"m\",\r\n    \"age\": \"24\",\r\n    \"waist\": \"34.00\",\r\n    \"hip\": \"40.00\"\r\n}", ParameterType.RequestBody);
            var response = client.ExecuteAsync(request);
        }


        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Weight
        {
            public string value { get; set; }
            public string unit { get; set; }
        }

        public class Height
        {
            public string value { get; set; }
            public string unit { get; set; }
        }

        public class Root
        {
            public Weight weight { get; set; }
            public Height height { get; set; }
            public string sex { get; set; }
            public string age { get; set; }
            public string waist { get; set; }
            public string hip { get; set; }
        }



    }
}
