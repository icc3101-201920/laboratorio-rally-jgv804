namespace VistasRally
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.VerPilotosButton = new System.Windows.Forms.Button();
            this.AgregarPilotosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a Rally Manager";
            // 
            // VerPilotosButton
            // 
            this.VerPilotosButton.Location = new System.Drawing.Point(154, 227);
            this.VerPilotosButton.Name = "VerPilotosButton";
            this.VerPilotosButton.Size = new System.Drawing.Size(94, 23);
            this.VerPilotosButton.TabIndex = 1;
            this.VerPilotosButton.Text = "Ver Pilotos";
            this.VerPilotosButton.UseVisualStyleBackColor = true;
            // 
            // AgregarPilotosButton
            // 
            this.AgregarPilotosButton.Location = new System.Drawing.Point(523, 227);
            this.AgregarPilotosButton.Name = "AgregarPilotosButton";
            this.AgregarPilotosButton.Size = new System.Drawing.Size(94, 23);
            this.AgregarPilotosButton.TabIndex = 2;
            this.AgregarPilotosButton.Text = "Agregar Pilotos";
            this.AgregarPilotosButton.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AgregarPilotosButton);
            this.Controls.Add(this.VerPilotosButton);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerPilotosButton;
        private System.Windows.Forms.Button AgregarPilotosButton;
    }
}
