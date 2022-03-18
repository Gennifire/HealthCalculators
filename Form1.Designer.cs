
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
            this.gender_label = new System.Windows.Forms.Label();
            this.results_Box = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_male = new System.Windows.Forms.Button();
            this.btn_female = new System.Windows.Forms.Button();
            this.Gender_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BMI_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyFat_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BMI_Page
            // 
            this.btn_BMI_Page.Location = new System.Drawing.Point(-2, 1);
            this.btn_BMI_Page.Name = "btn_BMI_Page";
            this.btn_BMI_Page.Size = new System.Drawing.Size(108, 57);
            this.btn_BMI_Page.TabIndex = 0;
            this.btn_BMI_Page.Text = "BMI";
            this.btn_BMI_Page.UseVisualStyleBackColor = true;
            this.btn_BMI_Page.Click += new System.EventHandler(this.btn_BMI_Page_Click);
            // 
            // btn_IdealWeight_Page
            // 
            this.btn_IdealWeight_Page.Location = new System.Drawing.Point(139, 1);
            this.btn_IdealWeight_Page.Name = "btn_IdealWeight_Page";
            this.btn_IdealWeight_Page.Size = new System.Drawing.Size(108, 57);
            this.btn_IdealWeight_Page.TabIndex = 1;
            this.btn_IdealWeight_Page.Text = "Ideal Weight";
            this.btn_IdealWeight_Page.UseVisualStyleBackColor = true;
            this.btn_IdealWeight_Page.Click += new System.EventHandler(this.btn_BodyFat_Page_Click);
            // 
            // btn_BMI_result
            // 
            this.btn_BMI_result.Location = new System.Drawing.Point(302, 264);
            this.btn_BMI_result.Name = "btn_BMI_result";
            this.btn_BMI_result.Size = new System.Drawing.Size(119, 47);
            this.btn_BMI_result.TabIndex = 4;
            this.btn_BMI_result.Text = "Get BMI";
            this.btn_BMI_result.UseVisualStyleBackColor = true;
            this.btn_BMI_result.Click += new System.EventHandler(this.btn_BMI_result_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(19, 99);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(32, 16);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Location = new System.Drawing.Point(19, 169);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(73, 16);
            this.height_Label.TabIndex = 6;
            this.height_Label.Text = "Height (cm)";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Location = new System.Drawing.Point(18, 239);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(72, 16);
            this.weight_Label.TabIndex = 7;
            this.weight_Label.Text = "Weight (kg)";
            // 
            // age_Box
            // 
            this.age_Box.Location = new System.Drawing.Point(32, 122);
            this.age_Box.Name = "age_Box";
            this.age_Box.Size = new System.Drawing.Size(106, 27);
            this.age_Box.TabIndex = 11;
            // 
            // height_Box
            // 
            this.height_Box.Location = new System.Drawing.Point(32, 192);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(106, 27);
            this.height_Box.TabIndex = 12;
            // 
            // weight_Box
            // 
            this.weight_Box.Location = new System.Drawing.Point(32, 264);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(106, 27);
            this.weight_Box.TabIndex = 13;
            // 
            // btn_IdealWeight_calc
            // 
            this.btn_IdealWeight_calc.Location = new System.Drawing.Point(302, 264);
            this.btn_IdealWeight_calc.Name = "btn_IdealWeight_calc";
            this.btn_IdealWeight_calc.Size = new System.Drawing.Size(119, 47);
            this.btn_IdealWeight_calc.TabIndex = 15;
            this.btn_IdealWeight_calc.Text = "Get ideal Weight";
            this.btn_IdealWeight_calc.UseVisualStyleBackColor = true;
            this.btn_IdealWeight_calc.Click += new System.EventHandler(this.btn_IdealWeight_calc_Click);
            // 
            // BMI_pic
            // 
            this.BMI_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMI_pic.BackgroundImage")));
            this.BMI_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_pic.Location = new System.Drawing.Point(621, 1);
            this.BMI_pic.Name = "BMI_pic";
            this.BMI_pic.Size = new System.Drawing.Size(475, 322);
            this.BMI_pic.TabIndex = 16;
            this.BMI_pic.TabStop = false;
            // 
            // BodyFat_pic
            // 
            this.BodyFat_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyFat_pic.BackgroundImage")));
            this.BodyFat_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BodyFat_pic.ErrorImage = null;
            this.BodyFat_pic.Location = new System.Drawing.Point(621, 1);
            this.BodyFat_pic.Name = "BodyFat_pic";
            this.BodyFat_pic.Size = new System.Drawing.Size(476, 322);
            this.BodyFat_pic.TabIndex = 17;
            this.BodyFat_pic.TabStop = false;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(18, 239);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(48, 16);
            this.gender_label.TabIndex = 25;
            this.gender_label.Text = "Gender";
            // 
            // results_Box
            // 
            this.results_Box.Location = new System.Drawing.Point(274, 12);
            this.results_Box.Multiline = true;
            this.results_Box.Name = "results_Box";
            this.results_Box.Size = new System.Drawing.Size(319, 234);
            this.results_Box.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(164, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 29);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(440, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 47);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_male
            // 
            this.btn_male.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_male.Location = new System.Drawing.Point(32, 264);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(75, 23);
            this.btn_male.TabIndex = 29;
            this.btn_male.Text = "Male";
            this.btn_male.UseVisualStyleBackColor = false;
            this.btn_male.Visible = false;
            this.btn_male.Click += new System.EventHandler(this.btn_male_Click);
            // 
            // btn_female
            // 
            this.btn_female.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_female.Location = new System.Drawing.Point(109, 264);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(75, 23);
            this.btn_female.TabIndex = 30;
            this.btn_female.Text = "Female";
            this.btn_female.UseVisualStyleBackColor = false;
            this.btn_female.Visible = false;
            this.btn_female.Click += new System.EventHandler(this.btn_female_Click);
            // 
            // Gender_box
            // 
            this.Gender_box.Location = new System.Drawing.Point(32, 264);
            this.Gender_box.Name = "Gender_box";
            this.Gender_box.Size = new System.Drawing.Size(106, 27);
            this.Gender_box.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1108, 321);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.results_Box);
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
            this.Controls.Add(this.Gender_box);
            this.Controls.Add(this.gender_label);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox results_Box;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_male;
        private System.Windows.Forms.Button btn_female;
        private System.Windows.Forms.TextBox Gender_box;
    }
}

