namespace Ejemplo1_Clases
{
    partial class FrmCentro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBoxEmaiCen = new System.Windows.Forms.TextBox();
            this.textBoxTelCen = new System.Windows.Forms.TextBox();
            this.textBoxDirCen = new System.Windows.Forms.TextBox();
            this.textBoxNameCen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.textBoxEmaiCen);
            this.groupBox1.Controls.Add(this.textBoxTelCen);
            this.groupBox1.Controls.Add(this.textBoxDirCen);
            this.groupBox1.Controls.Add(this.textBoxNameCen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Centro";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(128, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBoxEmaiCen
            // 
            this.textBoxEmaiCen.Location = new System.Drawing.Point(148, 206);
            this.textBoxEmaiCen.Name = "textBoxEmaiCen";
            this.textBoxEmaiCen.Size = new System.Drawing.Size(377, 22);
            this.textBoxEmaiCen.TabIndex = 7;
            // 
            // textBoxTelCen
            // 
            this.textBoxTelCen.Location = new System.Drawing.Point(148, 155);
            this.textBoxTelCen.Name = "textBoxTelCen";
            this.textBoxTelCen.Size = new System.Drawing.Size(377, 22);
            this.textBoxTelCen.TabIndex = 6;
            // 
            // textBoxDirCen
            // 
            this.textBoxDirCen.Location = new System.Drawing.Point(148, 105);
            this.textBoxDirCen.Name = "textBoxDirCen";
            this.textBoxDirCen.Size = new System.Drawing.Size(377, 22);
            this.textBoxDirCen.TabIndex = 5;
            // 
            // textBoxNameCen
            // 
            this.textBoxNameCen.Location = new System.Drawing.Point(148, 52);
            this.textBoxNameCen.Name = "textBoxNameCen";
            this.textBoxNameCen.Size = new System.Drawing.Size(377, 22);
            this.textBoxNameCen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // FrmCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCentro";
            this.Text = "FrmCentro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBoxEmaiCen;
        private System.Windows.Forms.TextBox textBoxTelCen;
        private System.Windows.Forms.TextBox textBoxDirCen;
        private System.Windows.Forms.TextBox textBoxNameCen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}