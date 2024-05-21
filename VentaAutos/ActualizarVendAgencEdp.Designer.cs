using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActualizarVendAgencEdp : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Label1 = new Label();
            Label2 = new Label();
            txtNombre = new TextBox();
            txtactualiza = new TextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label3 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 98);
            Label1.Name = "Label1";
            Label1.Size = new Size(128, 41);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 159);
            Label2.Name = "Label2";
            Label2.Size = new Size(223, 41);
            Label2.TabIndex = 1;
            Label2.Text = "Nuevo Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(888, 47);
            txtNombre.TabIndex = 2;
            // 
            // txtactualiza
            // 
            txtactualiza.Location = new Point(241, 153);
            txtactualiza.Name = "txtactualiza";
            txtactualiza.Size = new Size(793, 47);
            txtactualiza.TabIndex = 3;
            // 
            // Button1
            // 
            Button1.Location = new Point(807, 218);
            Button1.Name = "Button1";
            Button1.Size = new Size(227, 56);
            Button1.TabIndex = 4;
            Button1.Text = "Aceptar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Maroon;
            Label3.Location = new Point(12, 9);
            Label3.Name = "Label3";
            Label3.Size = new Size(472, 54);
            Label3.TabIndex = 5;
            Label3.Text = "Actualizacion de nombre";
            // 
            // ActualizarVendAgencEdp
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 293);
            Controls.Add(Label3);
            Controls.Add(Button1);
            Controls.Add(txtactualiza);
            Controls.Add(txtNombre);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "ActualizarVendAgencEdp";
            Text = "ActualizarVendAgencEdp";
            Load += new EventHandler(ActualizarVendAgencEdp_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal TextBox txtNombre;
        internal TextBox txtactualiza;
        internal Button Button1;
        internal Label Label3;
    }
}