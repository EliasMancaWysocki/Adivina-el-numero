namespace Adivina_el_número
{
    partial class FrmLoader
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoader));
            progressBar = new ProgressBar();
            Animation = new System.Windows.Forms.Timer(components);
            HideAnimation = new System.Windows.Forms.Timer(components);
            lblPorcentaje = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.FromArgb(0, 192, 0);
            progressBar.Location = new Point(12, 80);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(310, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // Animation
            // 
            Animation.Interval = 50;
            Animation.Tick += Animation_Tick;
            // 
            // HideAnimation
            // 
            HideAnimation.Interval = 10;
            HideAnimation.Tick += Hide_Tick;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Algerian", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPorcentaje.Location = new Point(132, 125);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(52, 14);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "label2";
            // 
            // FrmLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(334, 161);
            ControlBox = false;
            Controls.Add(lblPorcentaje);
            Controls.Add(progressBar);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MaximumSize = new Size(350, 200);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(350, 200);
            Name = "FrmLoader";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thinking...";
            Load += FrmLoader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label label1;
        private System.Windows.Forms.Timer Animation;
        private System.Windows.Forms.Timer HideAnimation;
        private Label lblPorcenaje;
        private Label lblPorcentaje;
    }
}