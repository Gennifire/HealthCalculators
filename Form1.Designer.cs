
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
            this.Gender_box = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.results_Box = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BMI_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyFat_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BMI_Page
            // 
            this.btn_BMI_Page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BMI_Page.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_BMI_Page.FlatAppearance.BorderSize = 2;
            this.btn_BMI_Page.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btn_BMI_Page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_BMI_Page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BMI_Page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMI_Page.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BMI_Page.Location = new System.Drawing.Point(12, 348);
            this.btn_BMI_Page.Name = "btn_BMI_Page";
            this.btn_BMI_Page.Size = new System.Drawing.Size(114, 39);
            this.btn_BMI_Page.TabIndex = 0;
            this.btn_BMI_Page.Text = "BMI";
            this.btn_BMI_Page.UseVisualStyleBackColor = false;
            this.btn_BMI_Page.Click += new System.EventHandler(this.btn_BMI_Page_Click);
            // 
            // btn_IdealWeight_Page
            // 
            this.btn_IdealWeight_Page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_IdealWeight_Page.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_IdealWeight_Page.FlatAppearance.BorderSize = 2;
            this.btn_IdealWeight_Page.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btn_IdealWeight_Page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_IdealWeight_Page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_IdealWeight_Page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IdealWeight_Page.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IdealWeight_Page.Location = new System.Drawing.Point(132, 348);
            this.btn_IdealWeight_Page.Name = "btn_IdealWeight_Page";
            this.btn_IdealWeight_Page.Size = new System.Drawing.Size(108, 39);
            this.btn_IdealWeight_Page.TabIndex = 1;
            this.btn_IdealWeight_Page.Text = "Ideal Weight";
            this.btn_IdealWeight_Page.UseVisualStyleBackColor = false;
            this.btn_IdealWeight_Page.Click += new System.EventHandler(this.btn_BodyFat_Page_Click);
            // 
            // btn_BMI_result
            // 
            this.btn_BMI_result.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BMI_result.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_BMI_result.FlatAppearance.BorderSize = 2;
            this.btn_BMI_result.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btn_BMI_result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_BMI_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BMI_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMI_result.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BMI_result.Location = new System.Drawing.Point(253, 597);
            this.btn_BMI_result.Name = "btn_BMI_result";
            this.btn_BMI_result.Size = new System.Drawing.Size(72, 37);
            this.btn_BMI_result.TabIndex = 4;
            this.btn_BMI_result.Text = "Get BMI";
            this.btn_BMI_result.UseVisualStyleBackColor = false;
            this.btn_BMI_result.Click += new System.EventHandler(this.btn_BMI_result_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age_label.Location = new System.Drawing.Point(12, 404);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(34, 17);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height_Label.Location = new System.Drawing.Point(12, 474);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(75, 17);
            this.height_Label.TabIndex = 6;
            this.height_Label.Text = "Height (cm)";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight_Label.Location = new System.Drawing.Point(12, 546);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(74, 17);
            this.weight_Label.TabIndex = 7;
            this.weight_Label.Text = "Weight (kg)";
            // 
            // age_Box
            // 
            this.age_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age_Box.Location = new System.Drawing.Point(12, 423);
            this.age_Box.Name = "age_Box";
            this.age_Box.Size = new System.Drawing.Size(106, 25);
            this.age_Box.TabIndex = 11;
            // 
            // height_Box
            // 
            this.height_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height_Box.Location = new System.Drawing.Point(12, 493);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(106, 25);
            this.height_Box.TabIndex = 12;
            // 
            // weight_Box
            // 
            this.weight_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight_Box.Location = new System.Drawing.Point(12, 565);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(106, 25);
            this.weight_Box.TabIndex = 13;
            // 
            // btn_IdealWeight_calc
            // 
            this.btn_IdealWeight_calc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_IdealWeight_calc.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_IdealWeight_calc.FlatAppearance.BorderSize = 2;
            this.btn_IdealWeight_calc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btn_IdealWeight_calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_IdealWeight_calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_IdealWeight_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IdealWeight_calc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IdealWeight_calc.Location = new System.Drawing.Point(328, 597);
            this.btn_IdealWeight_calc.Name = "btn_IdealWeight_calc";
            this.btn_IdealWeight_calc.Size = new System.Drawing.Size(119, 37);
            this.btn_IdealWeight_calc.TabIndex = 15;
            this.btn_IdealWeight_calc.Text = "Get ideal Weight";
            this.btn_IdealWeight_calc.UseVisualStyleBackColor = false;
            this.btn_IdealWeight_calc.Click += new System.EventHandler(this.btn_IdealWeight_calc_Click);
            // 
            // BMI_pic
            // 
            this.BMI_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMI_pic.BackgroundImage")));
            this.BMI_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_pic.Location = new System.Drawing.Point(12, 12);
            this.BMI_pic.Name = "BMI_pic";
            this.BMI_pic.Size = new System.Drawing.Size(524, 322);
            this.BMI_pic.TabIndex = 16;
            this.BMI_pic.TabStop = false;
            // 
            // BodyFat_pic
            // 
            this.BodyFat_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyFat_pic.BackgroundImage")));
            this.BodyFat_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BodyFat_pic.ErrorImage = null;
            this.BodyFat_pic.Location = new System.Drawing.Point(12, 12);
            this.BodyFat_pic.Name = "BodyFat_pic";
            this.BodyFat_pic.Size = new System.Drawing.Size(524, 322);
            this.BodyFat_pic.TabIndex = 17;
            this.BodyFat_pic.TabStop = false;
            // 
            // Gender_box
            // 
            this.Gender_box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender_box.Location = new System.Drawing.Point(132, 423);
            this.Gender_box.Name = "Gender_box";
            this.Gender_box.Size = new System.Drawing.Size(106, 25);
            this.Gender_box.TabIndex = 24;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender_label.Location = new System.Drawing.Point(132, 404);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(86, 17);
            this.gender_label.TabIndex = 25;
            this.gender_label.Text = "Gender (M/F)";
            // 
            // results_Box
            // 
            this.results_Box.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.results_Box.Location = new System.Drawing.Point(253, 348);
            this.results_Box.Multiline = true;
            this.results_Box.Name = "results_Box";
            this.results_Box.Size = new System.Drawing.Size(283, 234);
            this.results_Box.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(157, 558);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 32);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(453, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 37);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(549, 645);
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
        private System.Windows.Forms.TextBox Gender_box;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox results_Box;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
    }
}

