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
using unirest_net;

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
            var client = new RestClient("https://mega-fitness-calculator1.p.rapidapi.com/bmi?weight=65&height=167");
            var request = new RestRequest();
            request.AddHeader("x-rapidapi-host", "mega-fitness-calculator1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "ec6dc6e4bcmsh87299e3b4d9f6b4p1e413fjsn10f7f37e01ba");
            var response = await client.ExecuteAsync(request);

            var myDesializer = new SystemTextJsonSerializer();
            
            Application temp = myDesializer.Deserialize<Application>(response);
            


            //results_Box.Text = weight.;
        }


        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Weight
        {
            public string weight { get; set; }
            
        }

        public class Height
        {
            public string value { get; set; }
            public string unit { get; set; }
        }

        public class Gender
        {
            public string gender { get; set; }
        }

        public class Application
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
