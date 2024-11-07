namespace FInalProglang
{
    partial class FoodMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bmiResult = new Label();
            label2 = new Label();
            categoryResult = new Label();
            label3 = new Label();
            MaintainWeightBtn = new Button();
            GainWeightBtn = new Button();
            LossWeightBtn = new Button();
            Backbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 12);
            label1.Name = "label1";
            label1.Size = new Size(194, 35);
            label1.TabIndex = 2;
            label1.Text = "Your BMI is: \r\n";
            // 
            // bmiResult
            // 
            bmiResult.AutoSize = true;
            bmiResult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bmiResult.Location = new Point(503, 16);
            bmiResult.Name = "bmiResult";
            bmiResult.Size = new Size(72, 31);
            bmiResult.TabIndex = 4;
            bmiResult.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 77);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 5;
            label2.Text = "Result:";
            // 
            // categoryResult
            // 
            categoryResult.AutoSize = true;
            categoryResult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            categoryResult.Location = new Point(427, 83);
            categoryResult.Name = "categoryResult";
            categoryResult.Size = new Size(72, 31);
            categoryResult.TabIndex = 6;
            categoryResult.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 193);
            label3.Name = "label3";
            label3.Size = new Size(568, 35);
            label3.TabIndex = 7;
            label3.Text = "Select a Category to achieve your Goal\r\n";
            // 
            // MaintainWeightBtn
            // 
            MaintainWeightBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MaintainWeightBtn.Location = new Point(368, 309);
            MaintainWeightBtn.Margin = new Padding(3, 4, 3, 4);
            MaintainWeightBtn.Name = "MaintainWeightBtn";
            MaintainWeightBtn.Size = new Size(144, 79);
            MaintainWeightBtn.TabIndex = 11;
            MaintainWeightBtn.Text = "Maintain Weight";
            MaintainWeightBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MaintainWeightBtn.UseVisualStyleBackColor = true;
            MaintainWeightBtn.Click += MaintainWeightBtn_Click;
            // 
            // GainWeightBtn
            // 
            GainWeightBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GainWeightBtn.Location = new Point(553, 309);
            GainWeightBtn.Margin = new Padding(3, 4, 3, 4);
            GainWeightBtn.Name = "GainWeightBtn";
            GainWeightBtn.Size = new Size(144, 79);
            GainWeightBtn.TabIndex = 10;
            GainWeightBtn.Text = "Gain weight";
            GainWeightBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            GainWeightBtn.UseVisualStyleBackColor = true;
            GainWeightBtn.Click += GainWeightBtn_Click;
            // 
            // LossWeightBtn
            // 
            LossWeightBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LossWeightBtn.Location = new Point(175, 309);
            LossWeightBtn.Margin = new Padding(3, 4, 3, 4);
            LossWeightBtn.Name = "LossWeightBtn";
            LossWeightBtn.Size = new Size(144, 79);
            LossWeightBtn.TabIndex = 9;
            LossWeightBtn.Text = "Loss Weight";
            LossWeightBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LossWeightBtn.UseVisualStyleBackColor = true;
            LossWeightBtn.Click += LossWeightBtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.Location = new Point(38, 16);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(144, 79);
            Backbtn.TabIndex = 100;
            Backbtn.Text = "BACK";
            Backbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Backbtn);
            Controls.Add(MaintainWeightBtn);
            Controls.Add(GainWeightBtn);
            Controls.Add(LossWeightBtn);
            Controls.Add(label3);
            Controls.Add(categoryResult);
            Controls.Add(label2);
            Controls.Add(bmiResult);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FoodMenu";
            Text = "FoodMenu";
            Load += FoodMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label bmiResult;
        private Label label2;
        private Label categoryResult;
        private Label label3;
        private Button MaintainWeightBtn;
        private Button GainWeightBtn;
        private Button LossWeightBtn;
        private Button Backbtn;
    }
}