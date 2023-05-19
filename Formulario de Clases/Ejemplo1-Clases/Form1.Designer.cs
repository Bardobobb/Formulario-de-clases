namespace Ejemplo1_Clases
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgrega = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListCent = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProfe = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProfesorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgrega,
            this.menuListCent});
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.centroToolStripMenuItem.Text = "Centro";
            // 
            // menuAgrega
            // 
            this.menuAgrega.Name = "menuAgrega";
            this.menuAgrega.Size = new System.Drawing.Size(224, 26);
            this.menuAgrega.Text = "Agregar";
            this.menuAgrega.Click += new System.EventHandler(this.menuAgrega_Click);
            // 
            // menuListCent
            // 
            this.menuListCent.Name = "menuListCent";
            this.menuListCent.Size = new System.Drawing.Size(224, 26);
            this.menuListCent.Text = "Lista de Centro";
            this.menuListCent.Click += new System.EventHandler(this.menuListCent_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProfe,
            this.listaDeProfesorTool});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // agregarProfe
            // 
            this.agregarProfe.Name = "agregarProfe";
            this.agregarProfe.Size = new System.Drawing.Size(224, 26);
            this.agregarProfe.Text = "Agregar";
            this.agregarProfe.Click += new System.EventHandler(this.agregarProfe_Click);
            // 
            // listaDeProfesorTool
            // 
            this.listaDeProfesorTool.Name = "listaDeProfesorTool";
            this.listaDeProfesorTool.Size = new System.Drawing.Size(224, 26);
            this.listaDeProfesorTool.Text = "Lista de Profesores";
            this.listaDeProfesorTool.Click += new System.EventHandler(this.listaDeProfesorTool_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.toolStripMenuItem1});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Lista de Estudiantes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.listaDePersonalesToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(233, 26);
            this.agregarToolStripMenuItem3.Text = "Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // listaDePersonalesToolStripMenuItem
            // 
            this.listaDePersonalesToolStripMenuItem.Name = "listaDePersonalesToolStripMenuItem";
            this.listaDePersonalesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listaDePersonalesToolStripMenuItem.Text = "Lista de Trabajadores";
            this.listaDePersonalesToolStripMenuItem.Click += new System.EventHandler(this.listaDePersonalesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 414);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAgrega;
        private System.Windows.Forms.ToolStripMenuItem menuListCent;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProfe;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfesorTool;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listaDePersonalesToolStripMenuItem;
    }
}

