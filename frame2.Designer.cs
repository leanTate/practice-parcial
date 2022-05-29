namespace arbol_genealogico
{
    partial class frame2
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
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.TxtMadre = new System.Windows.Forms.TextBox();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPadre
            // 
            this.txtPadre.Location = new System.Drawing.Point(384, 29);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(206, 23);
            this.txtPadre.TabIndex = 0;
            // 
            // TxtMadre
            // 
            this.TxtMadre.Location = new System.Drawing.Point(384, 73);
            this.TxtMadre.Name = "TxtMadre";
            this.TxtMadre.Size = new System.Drawing.Size(206, 23);
            this.TxtMadre.TabIndex = 1;
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.ItemHeight = 15;
            this.lista1.Location = new System.Drawing.Point(25, 12);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(322, 274);
            this.lista1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Padre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Madre";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 458);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.TxtMadre);
            this.Controls.Add(this.txtPadre);
            this.Name = "frame2";
            this.Text = "frame2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPadre;
        private TextBox TxtMadre;
        private ListBox lista1;
        private Label label1;
        private Label label2;
        private Button btnUpdate;
    }
}