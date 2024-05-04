namespace _6_KalitimTekrar
{
    partial class ProductCrud
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
            Kategoricmb = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)northwindDs).BeginInit();
            SuspendLayout();
            // 
            // Kategoricmb
            // 
            Kategoricmb.FormattingEnabled = true;
            Kategoricmb.Location = new Point(174, 40);
            Kategoricmb.Name = "Kategoricmb";
            Kategoricmb.Size = new Size(151, 28);
            Kategoricmb.TabIndex = 0;
            Kategoricmb.SelectedIndexChanged += Kategoricmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            label1.Click += label1_Click;
            // 
            // ProductCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Kategoricmb);
            Name = "ProductCrud";
            Text = "ProductCrud";
            Load += ProductCrud_Load;
            ((System.ComponentModel.ISupportInitialize)northwindDs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Kategoricmb;
        private Label label1;
    }
}