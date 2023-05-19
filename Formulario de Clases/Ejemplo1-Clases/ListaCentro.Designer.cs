namespace Ejemplo1_Clases
{
    partial class ListaCentro
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
            this.dataGridViewListCent = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxListCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListCent
            // 
            this.groupBoxListCent.Controls.Add(this.dataGridViewListCent);
            this.groupBoxListCent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListCent.Name = "groupBoxListCent";
            this.groupBoxListCent.Size = new System.Drawing.Size(776, 335);
            this.groupBoxListCent.TabIndex = 0;
            this.groupBoxListCent.TabStop = false;
            this.groupBoxListCent.Text = "Lista Centro";
            // 
            // dataGridViewListCent
            // 
            this.dataGridViewListCent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCent.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewListCent.Name = "dataGridViewListCent";
            this.dataGridViewListCent.RowHeadersWidth = 51;
            this.dataGridViewListCent.RowTemplate.Height = 24;
            this.dataGridViewListCent.Size = new System.Drawing.Size(764, 308);
            this.dataGridViewListCent.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(610, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ListaCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxListCent);
            this.Name = "ListaCentro";
            this.Text = "ListaCentro";
            this.Load += new System.EventHandler(this.ListaCentro_Load);
            this.groupBoxListCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListCent;
        private System.Windows.Forms.DataGridView dataGridViewListCent;
        private System.Windows.Forms.Button btnCancel;
    }
}