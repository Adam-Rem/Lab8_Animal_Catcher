namespace Lab8_Animal_Catcher
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
            this.start = new System.Windows.Forms.Button();
            this.typ = new System.Windows.Forms.ComboBox();
            this.rozmiar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.start.FlatAppearance.BorderSize = 2;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.start.Location = new System.Drawing.Point(60, 29);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(240, 121);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Items.AddRange(new object[] {
            "PIES",
            "KOT",
            "KROKODYL",
            "KAPIBAR"});
            this.typ.Location = new System.Drawing.Point(12, 172);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(121, 23);
            this.typ.TabIndex = 1;
            this.typ.Text = "PIES";
            // 
            // rozmiar
            // 
            this.rozmiar.FormattingEnabled = true;
            this.rozmiar.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5"});
            this.rozmiar.Location = new System.Drawing.Point(211, 172);
            this.rozmiar.Name = "rozmiar";
            this.rozmiar.Size = new System.Drawing.Size(121, 23);
            this.rozmiar.TabIndex = 2;
            this.rozmiar.Text = "3 x 3";
            this.rozmiar.SelectedIndexChanged += new System.EventHandler(this.rozmiar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 442);
            this.Controls.Add(this.rozmiar);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Animon GO Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button start;
        private ComboBox typ;
        private ComboBox rozmiar;
    }
}