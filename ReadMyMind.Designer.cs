namespace Adivina_el_número
{
    partial class ReadMyMind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadMyMind));
            btnSubmit = new Button();
            lblTitle = new Label();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Algerian", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(185, 124);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 45);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Read My Mind";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Algerian", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Enter a number between 1 and 100";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(154, 80);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 23);
            txtNum.TabIndex = 2;
            txtNum.TextChanged += txtNum_TextChanged;
            // 
            // ReadMyMind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(444, 181);
            Controls.Add(txtNum);
            Controls.Add(lblTitle);
            Controls.Add(btnSubmit);
            MaximizeBox = false;
            MaximumSize = new Size(460, 220);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(460, 220);
            Name = "ReadMyMind";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Read My Mind";
            Load += ReadMyMind_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblTitle;
        private TextBox txtNum;
    }
}