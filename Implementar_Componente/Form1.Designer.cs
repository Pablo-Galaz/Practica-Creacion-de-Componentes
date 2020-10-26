namespace Implementar_Componente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlDelUsuario1 = new Creacion_Componente.ControlDelUsuario();
            this.SuspendLayout();
            // 
            // controlDelUsuario1
            // 
            this.controlDelUsuario1.BackColor = System.Drawing.Color.Tan;
            this.controlDelUsuario1.Location = new System.Drawing.Point(0, 0);
            this.controlDelUsuario1.Name = "controlDelUsuario1";
            this.controlDelUsuario1.Size = new System.Drawing.Size(567, 410);
            this.controlDelUsuario1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 409);
            this.Controls.Add(this.controlDelUsuario1);
            this.Name = "Form1";
            this.Text = "Practica_Componentes";
            this.ResumeLayout(false);

        }

        #endregion

        private Creacion_Componente.ControlDelUsuario controlDelUsuario1;
    }
}

