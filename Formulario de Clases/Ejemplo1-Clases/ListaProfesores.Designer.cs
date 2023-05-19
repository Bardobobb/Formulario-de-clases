namespace Ejemplo1_Clases
{
    partial class ListaProfesores
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
            this.groupBoxListCent = new System.Windows.Forms.GroupBox();
            this.dataGridViewListProf = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxListCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProf)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListCent
            // 
            this.groupBoxListCent.Controls.Add(this.dataGridViewListProf);
            this.groupBoxListCent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListCent.Name = "groupBoxListCent";
            this.groupBoxListCent.Size = new System.Drawing.Size(776, 335);
            this.groupBoxListCent.TabIndex = 1;
            this.groupBoxListCent.TabStop = false;
            this.groupBoxListCent.Text = "Lista Profesores";
            // 
            // dataGridViewListProf
            // 
            this.dataGridViewListProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProf.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewListProf.Name = "dataGridViewListProf";
            this.dataGridViewListProf.RowHeadersWidth = 51;
            this.dataGridViewListProf.RowTemplate.Height = 24;
            this.dataGridViewListProf.Size = new System.Drawing.Size(764, 308);
            this.dataGridViewListProf.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(606, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 41);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ListaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxListCent);
            this.Name = "ListaProfesores";
            this.Text = "ListaProfesores";
            this.Load += new System.EventHandler(this.ListaProfesores_Load);
            this.groupBoxListCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListCent;
        private System.Windows.Forms.DataGridView dataGridViewListProf;
        private System.Windows.Forms.Button btnCancel;
    }
}