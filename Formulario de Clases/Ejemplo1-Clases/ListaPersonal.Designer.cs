namespace Ejemplo1_Clases
{
    partial class ListaPersonal
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
            this.dataGridViewListPer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxListCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListCent
            // 
            this.groupBoxListCent.Controls.Add(this.dataGridViewListPer);
            this.groupBoxListCent.Location = new System.Drawing.Point(12, 22);
            this.groupBoxListCent.Name = "groupBoxListCent";
            this.groupBoxListCent.Size = new System.Drawing.Size(776, 335);
            this.groupBoxListCent.TabIndex = 1;
            this.groupBoxListCent.TabStop = false;
            this.groupBoxListCent.Text = "Lista Centro";
            // 
            // dataGridViewListPer
            // 
            this.dataGridViewListPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPer.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewListPer.Name = "dataGridViewListPer";
            this.dataGridViewListPer.RowHeadersWidth = 51;
            this.dataGridViewListPer.RowTemplate.Height = 24;
            this.dataGridViewListPer.Size = new System.Drawing.Size(764, 308);
            this.dataGridViewListPer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxListCent);
            this.Name = "ListaPersonal";
            this.Text = "ListaPersonal";
            this.Load += new System.EventHandler(this.ListaPersonal_Load);
            this.groupBoxListCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListCent;
        private System.Windows.Forms.DataGridView dataGridViewListPer;
        private System.Windows.Forms.Button button1;
    }
}