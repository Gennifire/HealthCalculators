
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
            this.btn_BodyFat_Page = new System.Windows.Forms.Button();
            this.btn_BMI_result = new System.Windows.Forms.Button();
            this.age_label = new System.Windows.Forms.Label();
            this.height_Label = new System.Windows.Forms.Label();
            this.weight_Label = new System.Windows.Forms.Label();
            this.age_Box = new System.Windows.Forms.TextBox();
            this.height_Box = new System.Windows.Forms.TextBox();
            this.weight_Box = new System.Windows.Forms.TextBox();
            this.btn_BodyFat_calc = new System.Windows.Forms.Button();
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
            this.btn_BMI_Page.Location = new System.Drawing.Point(2, 70);
            this.btn_BMI_Page.Name = "btn_BMI_Page";
            this.btn_BMI_Page.Size = new System.Drawing.Size(87, 72);
            this.btn_BMI_Page.TabIndex = 0;
            this.btn_BMI_Page.Text = "BMI";
            this.btn_BMI_Page.UseVisualStyleBackColor = true;
            this.btn_BMI_Page.Click += new System.EventHandler(this.btn_BMI_Page_Click);
            // 
            // btn_BodyFat_Page
            // 
            this.btn_BodyFat_Page.Location = new System.Drawing.Point(2, 204);
            this.btn_BodyFat_Page.Name = "btn_BodyFat_Page";
            this.btn_BodyFat_Page.Size = new System.Drawing.Size(87, 81);
            this.btn_BodyFat_Page.TabIndex = 1;
            this.btn_BodyFat_Page.Text = "Body Fat %";
            this.btn_BodyFat_Page.UseVisualStyleBackColor = true;
            this.btn_BodyFat_Page.Click += new System.EventHandler(this.btn_BodyFat_Page_Click);
            // 
            // btn_BMI_result
            // 
            this.btn_BMI_result.Location = new System.Drawing.Point(163, 307);
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
            this.age_label.Location = new System.Drawing.Point(128, 58);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(39, 20);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Location = new System.Drawing.Point(128, 126);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(88, 20);
            this.height_Label.TabIndex = 6;
            this.height_Label.Text = "Height (cm)";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Location = new System.Drawing.Point(128, 204);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(86, 20);
            this.weight_Label.TabIndex = 7;
            this.weight_Label.Text = "Weight (kg)";
            // 
            // age_Box
            // 
            this.age_Box.Location = new System.Drawing.Point(128, 81);
            this.age_Box.Name = "age_Box";
            this.age_Box.Size = new System.Drawing.Size(158, 27);
            this.age_Box.TabIndex = 11;
            // 
            // height_Box
            // 
            this.height_Box.Location = new System.Drawing.Point(128, 161);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(158, 27);
            this.height_Box.TabIndex = 12;
            // 
            // weight_Box
            // 
            this.weight_Box.Location = new System.Drawing.Point(128, 240);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(158, 27);
            this.weight_Box.TabIndex = 13;
            // 
            // btn_BodyFat_calc
            // 
            this.btn_BodyFat_calc.Location = new System.Drawing.Point(163, 307);
            this.btn_BodyFat_calc.Name = "btn_BodyFat_calc";
            this.btn_BodyFat_calc.Size = new System.Drawing.Size(123, 48);
            this.btn_BodyFat_calc.TabIndex = 15;
            this.btn_BodyFat_calc.Text = "Get Body Fat %";
            this.btn_BodyFat_calc.UseVisualStyleBackColor = true;
            this.btn_BodyFat_calc.Click += new System.EventHandler(this.btn_BodyFat_calc_Click);
            // 
            // BMI_pic
            // 
            this.BMI_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMI_pic.BackgroundImage")));
            this.BMI_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_pic.Location = new System.Drawing.Point(328, 25);
            this.BMI_pic.Name = "BMI_pic";
            this.BMI_pic.Size = new System.Drawing.Size(595, 354);
            this.BMI_pic.TabIndex = 16;
            this.BMI_pic.TabStop = false;
            // 
            // BodyFat_pic
            // 
            this.BodyFat_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyFat_pic.BackgroundImage")));
            this.BodyFat_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BodyFat_pic.ErrorImage = null;
            this.BodyFat_pic.Location = new System.Drawing.Point(496, 25);
            this.BodyFat_pic.Name = "BodyFat_pic";
            this.BodyFat_pic.Size = new System.Drawing.Size(427, 346);
            this.BodyFat_pic.TabIndex = 17;
            this.BodyFat_pic.TabStop = false;
            // 
            // Waist_measurement
            // 
            this.Waist_measurement.Location = new System.Drawing.Point(328, 240);
            this.Waist_measurement.Name = "Waist_measurement";
            this.Waist_measurement.Size = new System.Drawing.Size(158, 27);
            this.Waist_measurement.TabIndex = 22;
            // 
            // Neck_measurement
            // 
            this.Neck_measurement.Location = new System.Drawing.Point(328, 161);
            this.Neck_measurement.Name = "Neck_measurement";
            this.Neck_measurement.Size = new System.Drawing.Size(158, 27);
            this.Neck_measurement.TabIndex = 23;
            // 
            // Gender_box
            // 
            this.Gender_box.Location = new System.Drawing.Point(328, 81);
            this.Gender_box.Name = "Gender_box";
            this.Gender_box.Size = new System.Drawing.Size(158, 27);
            this.Gender_box.TabIndex = 24;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(328, 58);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(57, 20);
            this.gender_label.TabIndex = 25;
            this.gender_label.Text = "Gender";
            // 
            // neck_label
            // 
            this.neck_label.AutoSize = true;
            this.neck_label.Location = new System.Drawing.Point(328, 122);
            this.neck_label.Name = "neck_label";
            this.neck_label.Size = new System.Drawing.Size(162, 20);
            this.neck_label.TabIndex = 26;
            this.neck_label.Text = "Neck measurment (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Waist measurement (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hip measurment (cm)";
            // 
            // Hip_measurement
            // 
            this.Hip_measurement.Location = new System.Drawing.Point(328, 318);
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
            this.Controls.Add(this.btn_BodyFat_Page);
            this.Controls.Add(this.btn_BMI_Page);
            this.Controls.Add(this.btn_BodyFat_calc);
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
        private System.Windows.Forms.Button btn_BodyFat_Page;
        private System.Windows.Forms.Button btn_BMI_result;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label height_Label;
        private System.Windows.Forms.Label weight_Label;
        private System.Windows.Forms.TextBox age_Box;
        private System.Windows.Forms.TextBox height_Box;
        private System.Windows.Forms.TextBox weight_Box;
        private System.Windows.Forms.Button btn_BodyFat_calc;
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

