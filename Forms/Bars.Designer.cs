namespace TestRobotApp.Forms
{
    partial class Bars
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
            GetBarDataBtn = new Button();
            SuspendLayout();
            // 
            // GetBarDataBtn
            // 
            GetBarDataBtn.BackColor = SystemColors.ActiveCaption;
            GetBarDataBtn.Font = new Font("JetBrains Mono ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetBarDataBtn.Location = new Point(318, 157);
            GetBarDataBtn.Name = "GetBarDataBtn";
            GetBarDataBtn.Size = new Size(163, 69);
            GetBarDataBtn.TabIndex = 0;
            GetBarDataBtn.Text = "Get Data";
            GetBarDataBtn.UseVisualStyleBackColor = false;
            GetBarDataBtn.Click += GetBarDataBtn_Click;
            // 
            // Bars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GetBarDataBtn);
            Name = "Bars";
            Text = "Bars";
            ResumeLayout(false);
        }

        #endregion

        private Button GetBarDataBtn;
    }
}