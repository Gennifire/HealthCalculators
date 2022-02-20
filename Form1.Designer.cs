
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
            ((System.ComponentModel.ISupportInitialize)(this.BMI_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyFat_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BMI_Page
            // 
            this.btn_BMI_Page.Location = new System.Drawing.Point(97, -1);
            this.btn_BMI_Page.Name = "btn_BMI_Page";
            this.btn_BMI_Page.Size = new System.Drawing.Size(87, 72);
            this.btn_BMI_Page.TabIndex = 0;
            this.btn_BMI_Page.Text = "BMI";
            this.btn_BMI_Page.UseVisualStyleBackColor = true;
            this.btn_BMI_Page.Click += new System.EventHandler(this.btn_BMI_Page_Click);
            // 
            // btn_BodyFat_Page
            // 
            this.btn_BodyFat_Page.Location = new System.Drawing.Point(4, -10);
            this.btn_BodyFat_Page.Name = "btn_BodyFat_Page";
            this.btn_BodyFat_Page.Size = new System.Drawing.Size(87, 81);
            this.btn_BodyFat_Page.TabIndex = 1;
            this.btn_BodyFat_Page.Text = "Body Fat %";
            this.btn_BodyFat_Page.UseVisualStyleBackColor = true;
            this.btn_BodyFat_Page.Click += new System.EventHandler(this.btn_BodyFat_Page_Click);
            // 
            // btn_BMI_result
            // 
            this.btn_BMI_result.Location = new System.Drawing.Point(161, 339);
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
            this.age_label.Location = new System.Drawing.Point(12, 92);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(39, 20);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Location = new System.Drawing.Point(12, 176);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(88, 20);
            this.height_Label.TabIndex = 6;
            this.height_Label.Text = "Height (cm)";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Location = new System.Drawing.Point(12, 255);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(86, 20);
            this.weight_Label.TabIndex = 7;
            this.weight_Label.Text = "Weight (kg)";
            // 
            // age_Box
            // 
            this.age_Box.Location = new System.Drawing.Point(12, 126);
            this.age_Box.Name = "age_Box";
            this.age_Box.Size = new System.Drawing.Size(166, 27);
            this.age_Box.TabIndex = 11;
            // 
            // height_Box
            // 
            this.height_Box.Location = new System.Drawing.Point(12, 208);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(166, 27);
            this.height_Box.TabIndex = 12;
            // 
            // weight_Box
            // 
            this.weight_Box.Location = new System.Drawing.Point(12, 292);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(166, 27);
            this.weight_Box.TabIndex = 13;
            // 
            // btn_BodyFat_calc
            // 
            this.btn_BodyFat_calc.Location = new System.Drawing.Point(161, 339);
            this.btn_BodyFat_calc.Name = "btn_BodyFat_calc";
            this.btn_BodyFat_calc.Size = new System.Drawing.Size(123, 48);
            this.btn_BodyFat_calc.TabIndex = 15;
            this.btn_BodyFat_calc.Text = "Get Body Fat %";
            this.btn_BodyFat_calc.UseVisualStyleBackColor = true;
            this.btn_BodyFat_calc.Click += new System.EventHandler(this.btn_BodyFat_calc_Click);
            // 
            // BMI_pic
            // 
            this.BMI_pic.Location = new System.Drawing.Point(661, 12);
            this.BMI_pic.Name = "BMI_pic";
            this.BMI_pic.Size = new System.Drawing.Size(262, 319);
            this.BMI_pic.TabIndex = 16;
            this.BMI_pic.TabStop = false;
            // 
            // BodyFat_pic
            // 
            this.BodyFat_pic.Location = new System.Drawing.Point(614, 27);
            this.BodyFat_pic.Name = "BodyFat_pic";
            this.BodyFat_pic.Size = new System.Drawing.Size(262, 319);
            this.BodyFat_pic.TabIndex = 17;
            this.BodyFat_pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 343);
            this.Controls.Add(this.BodyFat_pic);
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
    }
}

