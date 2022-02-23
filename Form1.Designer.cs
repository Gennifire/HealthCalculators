
namespace HealthCalculators
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_BMI_Page = new System.Windows.Forms.Button();
            this.btn_IdealWeight_Page = new System.Windows.Forms.Button();
            this.btn_BMI_result = new System.Windows.Forms.Button();
            this.age_label = new System.Windows.Forms.Label();
            this.height_Label = new System.Windows.Forms.Label();
            this.weight_Label = new System.Windows.Forms.Label();
            this.age_Box = new System.Windows.Forms.TextBox();
            this.height_Box = new System.Windows.Forms.TextBox();
            this.weight_Box = new System.Windows.Forms.TextBox();
            this.btn_IdealWeight_calc = new System.Windows.Forms.Button();
            this.BMI_pic = new System.Windows.Forms.PictureBox();
            this.BodyFat_pic = new System.Windows.Forms.PictureBox();
            this.Waist_measurement = new System.Windows.Forms.TextBox();
            this.Neck_measurement = new System.Windows.Forms.TextBox();
            this.Gender_box = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.neck_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hip_measurement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BMI_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyFat_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BMI_Page
            // 
            this.btn_BMI_Page.Location = new System.Drawing.Point(12, 88);
            this.btn_BMI_Page.Name = "btn_BMI_Page";
            this.btn_BMI_Page.Size = new System.Drawing.Size(87, 72);
            this.btn_BMI_Page.TabIndex = 0;
            this.btn_BMI_Page.Text = "BMI";
            this.btn_BMI_Page.UseVisualStyleBackColor = true;
            this.btn_BMI_Page.Click += new System.EventHandler(this.btn_BMI_Page_Click);
            // 
            // btn_IdealWeight_Page
            // 
            this.btn_IdealWeight_Page.Location = new System.Drawing.Point(12, 266);
            this.btn_IdealWeight_Page.Name = "btn_IdealWeight_Page";
            this.btn_IdealWeight_Page.Size = new System.Drawing.Size(87, 81);
            this.btn_IdealWeight_Page.TabIndex = 1;
            this.btn_IdealWeight_Page.Text = "Get Ideal Weight";
            this.btn_IdealWeight_Page.UseVisualStyleBackColor = true;
            this.btn_IdealWeight_Page.Click += new System.EventHandler(this.btn_BodyFat_Page_Click);
            // 
            // btn_BMI_result
            // 
            this.btn_BMI_result.Location = new System.Drawing.Point(141, 270);
            this.btn_BMI_result.Name = "btn_BMI_result";
            this.btn_BMI_result.Size = new System.Drawing.Size(123, 48);
            this.btn_BMI_result.TabIndex = 4;
            this.btn_BMI_result.Text = "Get BMI";
            this.btn_BMI_result.UseVisualStyleBackColor = true;
            this.btn_BMI_result.Click += new System.EventHandler(this.btn_BMI_result_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(126, 22);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(39, 20);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Location = new System.Drawing.Point(126, 90);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(88, 20);
            this.height_Label.TabIndex = 6;
            this.height_Label.Text = "Height (cm)";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Location = new System.Drawing.Point(126, 168);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(86, 20);
            this.weight_Label.TabIndex = 7;
            this.weight_Label.Text = "Weight (kg)";
            // 
            // age_Box
            // 
            this.age_Box.Location = new System.Drawing.Point(126, 45);
            this.age_Box.Name = "age_Box";
            this.age_Box.Size = new System.Drawing.Size(158, 27);
            this.age_Box.TabIndex = 11;
            // 
            // height_Box
            // 
            this.height_Box.Location = new System.Drawing.Point(126, 125);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(158, 27);
            this.height_Box.TabIndex = 12;
            // 
            // weight_Box
            // 
            this.weight_Box.Location = new System.Drawing.Point(126, 204);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(158, 27);
            this.weight_Box.TabIndex = 13;
            // 
            // btn_IdealWeight_calc
            // 
            this.btn_IdealWeight_calc.Location = new System.Drawing.Point(141, 340);
            this.btn_IdealWeight_calc.Name = "btn_IdealWeight_calc";
            this.btn_IdealWeight_calc.Size = new System.Drawing.Size(123, 48);
            this.btn_IdealWeight_calc.TabIndex = 15;
            this.btn_IdealWeight_calc.Text = "Get ideal Weight";
            this.btn_IdealWeight_calc.UseVisualStyleBackColor = true;
            this.btn_IdealWeight_calc.Click += new System.EventHandler(this.btn_IdealWeight_calc_Click);
            // 
            // BMI_pic
            // 
            this.BMI_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMI_pic.BackgroundImage")));
            this.BMI_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_pic.Location = new System.Drawing.Point(483, 45);
            this.BMI_pic.Name = "BMI_pic";
            this.BMI_pic.Size = new System.Drawing.Size(440, 346);
            this.BMI_pic.TabIndex = 16;
            this.BMI_pic.TabStop = false;
            // 
            // BodyFat_pic
            // 
            this.BodyFat_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyFat_pic.BackgroundImage")));
            this.BodyFat_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BodyFat_pic.ErrorImage = null;
            this.BodyFat_pic.Location = new System.Drawing.Point(496, 45);
            this.BodyFat_pic.Name = "BodyFat_pic";
            this.BodyFat_pic.Size = new System.Drawing.Size(427, 346);
            this.BodyFat_pic.TabIndex = 17;
            this.BodyFat_pic.TabStop = false;
            // 
            // Waist_measurement
            // 
            this.Waist_measurement.Location = new System.Drawing.Point(315, 281);
            this.Waist_measurement.Name = "Waist_measurement";
            this.Waist_measurement.Size = new System.Drawing.Size(158, 27);
            this.Waist_measurement.TabIndex = 22;
            // 
            // Neck_measurement
            // 
            this.Neck_measurement.Location = new System.Drawing.Point(315, 202);
            this.Neck_measurement.Name = "Neck_measurement";
            this.Neck_measurement.Size = new System.Drawing.Size(158, 27);
            this.Neck_measurement.TabIndex = 23;
            // 
            // Gender_box
            // 
            this.Gender_box.Location = new System.Drawing.Point(126, 281);
            this.Gender_box.Name = "Gender_box";
            this.Gender_box.Size = new System.Drawing.Size(158, 27);
            this.Gender_box.TabIndex = 24;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(126, 245);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(57, 20);
            this.gender_label.TabIndex = 25;
            this.gender_label.Text = "Gender";
            // 
            // neck_label
            // 
            this.neck_label.AutoSize = true;
            this.neck_label.Location = new System.Drawing.Point(315, 163);
            this.neck_label.Name = "neck_label";
            this.neck_label.Size = new System.Drawing.Size(162, 20);
            this.neck_label.TabIndex = 26;
            this.neck_label.Text = "Neck measurment (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Waist measurement (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hip measurment (cm)";
            // 
            // Hip_measurement
            // 
            this.Hip_measurement.Location = new System.Drawing.Point(315, 359);
            this.Hip_measurement.Name = "Hip_measurement";
            this.Hip_measurement.Size = new System.Drawing.Size(158, 27);
            this.Hip_measurement.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 411);
            this.Controls.Add(this.BMI_pic);
            this.Controls.Add(this.weight_Box);
            this.Controls.Add(this.height_Box);
            this.Controls.Add(this.age_Box);
            this.Controls.Add(this.weight_Label);
            this.Controls.Add(this.height_Label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.btn_BMI_result);
            this.Controls.Add(this.btn_IdealWeight_Page);
            this.Controls.Add(this.btn_BMI_Page);
            this.Controls.Add(this.btn_IdealWeight_calc);
            this.Controls.Add(this.BodyFat_pic);
            this.Controls.Add(this.Waist_measurement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Neck_measurement);
            this.Controls.Add(this.neck_label);
            this.Controls.Add(this.Gender_box);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.Hip_measurement);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HealthCalulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BMI_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyFat_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BMI_Page;
        private System.Windows.Forms.Button btn_IdealWeight_Page;
        private System.Windows.Forms.Button btn_BMI_result;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label height_Label;
        private System.Windows.Forms.Label weight_Label;
        private System.Windows.Forms.TextBox age_Box;
        private System.Windows.Forms.TextBox height_Box;
        private System.Windows.Forms.TextBox weight_Box;
        private System.Windows.Forms.Button btn_IdealWeight_calc;
        private System.Windows.Forms.PictureBox BMI_pic;
        private System.Windows.Forms.PictureBox BodyFat_pic;
        private System.Windows.Forms.TextBox Waist_measurement;
        private System.Windows.Forms.TextBox Neck_measurement;
        private System.Windows.Forms.TextBox Gender_box;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label neck_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Hip_measurement;
    }
}

