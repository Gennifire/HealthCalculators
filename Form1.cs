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
            var client = new RestClient("https://fitness-api.p.rapidapi.com/fitness");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("x-rapidapi-host", "fitness-api.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "ec6dc6e4bcmsh87299e3b4d9f6b4p1e413fjsn10f7f37e01ba");
            request.AddParameter("application/x-www-form-urlencoded", "height=190&weight=80&age=30&gender=male&exercise=little&neck=41&hip=100&waist=88&goal=maintenance&deficit=500&goalWeight=85", ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);





            results_Box.Text = response.value;
        }


       

        public class Rootobject
        {
            public int height { get; set; }
            public int weight { get; set; }
            public Idealbodyweight idealBodyWeight { get; set; }
            public Bodymassindex bodyMassIndex { get; set; }
        }

        public class Idealbodyweight
        {
            public Peterson peterson { get; set; }
        }

        public class Peterson
        {
            public string formulaName { get; set; }
            public Metric metric { get; set; }
            public Imperial imperial { get; set; }
        }

        public class Metric
        {
            public float value { get; set; }
            public string[] unit { get; set; }
        }

        public class Imperial
        {
            public float value { get; set; }
            public string[] unit { get; set; }
        }

        public class Bodymassindex
        {
            public float value { get; set; }
            public string conclusion { get; set; }
            public string unit { get; set; }
        }


    }
}
