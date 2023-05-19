namespace Ejemplo1_Clases
{
    partial class ListaAlumnos
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
            this.groupBoxListAlum = new System.Windows.Forms.GroupBox();
            this.dataGridViewListAlum = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxListAlum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAlum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListAlum
            // 
            this.groupBoxListAlum.Controls.Add(this.dataGridViewListAlum);
            this.groupBoxListAlum.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListAlum.Name = "groupBoxListAlum";
            this.groupBoxListAlum.Size = new System.Drawing.Size(776, 335);
            this.groupBoxListAlum.TabIndex = 2;
            this.groupBoxListAlum.TabStop = false;
            this.groupBoxListAlum.Text = "Lista Alumnos";
            // 
            // dataGridViewListAlum
            // 
            this.dataGridViewListAlum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAlum.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewListAlum.Name = "dataGridViewListAlum";
            this.dataGridViewListAlum.RowHeadersWidth = 51;
            this.dataGridViewListAlum.RowTemplate.Height = 24;
            this.dataGridViewListAlum.Size = new System.Drawing.Size(764, 308);
            this.dataGridViewListAlum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxListAlum);
            this.Name = "ListaAlumnos";
            this.Text = "ListaAlumnos";
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            this.groupBoxListAlum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAlum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListAlum;
        private System.Windows.Forms.DataGridView dataGridViewListAlum;
        private System.Windows.Forms.Button button1;
    }
}