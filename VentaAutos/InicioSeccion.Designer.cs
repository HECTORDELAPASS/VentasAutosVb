using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InicioSeccion : Form
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
            Label3 = new Label();
            txtcontra = new TextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            picno = new PictureBox();
            picno.Click += new EventHandler(picno_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            picsi = new PictureBox();
            picsi.Click += new EventHandler(picsi_Click);
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            txtusuario = new TextBox();
            TabPage2 = new TabPage();
            panelactualizar = new Panel();
            Label8 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            txtcontractualizar2 = new TextBox();
            txtnombreactualizar2 = new TextBox();
            txtnombreactualizar2.TextChanged += new EventHandler(txtnombreactualizar2_TextChanged);
            Label6 = new Label();
            txtusernameactualizar2 = new TextBox();
            Label7 = new Label();
            panelbuscar = new Panel();
            Label4 = new Label();
            picsi2 = new PictureBox();
            picsi2.Click += new EventHandler(picsi2_Click);
            btnbuscar2 = new Button();
            btnbuscar2.Click += new EventHandler(btnbuscar2_Click);
            Label5 = new Label();
            txtcontra2 = new TextBox();
            picno2 = new PictureBox();
            picno2.Click += new EventHandler(picno2_Click);
            txtusuario2 = new TextBox();
            TabPage3 = new TabPage();
            Label9 = new Label();
            picsi3 = new PictureBox();
            picsi3.Click += new EventHandler(picsi3_Click);
            Label10 = new Label();
            picno3 = new PictureBox();
            picno3.Click += new EventHandler(picno3_Click);
            txtusuario3 = new TextBox();
            txtcontra3 = new TextBox();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            ((System.ComponentModel.ISupportInitialize)picno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picsi).BeginInit();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            panelactualizar.SuspendLayout();
            panelbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsi2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picno2).BeginInit();
            TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsi3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picno3).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(339, 41);
            Label1.TabIndex = 0;
            Label1.Text = "Control de credenciales";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(25, 43);
            Label2.Name = "Label2";
            Label2.Size = new Size(275, 41);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre de usuario";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(25, 123);
            Label3.Name = "Label3";
            Label3.Size = new Size(168, 41);
            Label3.TabIndex = 2;
            Label3.Text = "Contraseña";
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(199, 117);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(528, 47);
            txtcontra.TabIndex = 4;
            // 
            // Button1
            // 
            Button1.Location = new Point(542, 179);
            Button1.Name = "Button1";
            Button1.Size = new Size(238, 48);
            Button1.TabIndex = 5;
            Button1.Text = "Continuar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // picno
            // 
            picno.Image = VentaAutos.My.Resources.Resources.ojo__1_;
            picno.Location = new Point(734, 119);
            picno.Name = "picno";
            picno.Size = new Size(34, 41);
            picno.SizeMode = PictureBoxSizeMode.Zoom;
            picno.TabIndex = 7;
            picno.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = VentaAutos.My.Resources.Resources.salida_de_emergencia;
            PictureBox1.Location = new Point(720, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(78, 61);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // picsi
            // 
            picsi.Image = VentaAutos.My.Resources.Resources.ver;
            picsi.Location = new Point(734, 119);
            picsi.Name = "picsi";
            picsi.Size = new Size(34, 41);
            picsi.SizeMode = PictureBoxSizeMode.Zoom;
            picsi.TabIndex = 8;
            picsi.TabStop = false;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Location = new Point(19, 79);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(864, 401);
            TabControl1.TabIndex = 9;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(Label2);
            TabPage1.Controls.Add(picsi);
            TabPage1.Controls.Add(Label3);
            TabPage1.Controls.Add(picno);
            TabPage1.Controls.Add(txtusuario);
            TabPage1.Controls.Add(txtcontra);
            TabPage1.Controls.Add(Button1);
            TabPage1.Location = new Point(4, 50);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(856, 347);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Inicio de Sesión";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(306, 37);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(474, 47);
            txtusuario.TabIndex = 3;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(panelactualizar);
            TabPage2.Controls.Add(panelbuscar);
            TabPage2.Location = new Point(4, 50);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(856, 347);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Actualizar mi Informacion";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // panelactualizar
            // 
            panelactualizar.Controls.Add(Label8);
            panelactualizar.Controls.Add(Button2);
            panelactualizar.Controls.Add(txtcontractualizar2);
            panelactualizar.Controls.Add(txtnombreactualizar2);
            panelactualizar.Controls.Add(Label6);
            panelactualizar.Controls.Add(txtusernameactualizar2);
            panelactualizar.Controls.Add(Label7);
            panelactualizar.Location = new Point(6, 139);
            panelactualizar.Name = "panelactualizar";
            panelactualizar.Size = new Size(843, 205);
            panelactualizar.TabIndex = 23;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(27, 141);
            Label8.Name = "Label8";
            Label8.Size = new Size(129, 31);
            Label8.TabIndex = 21;
            Label8.Text = "Contraseña";
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(682, 147);
            Button2.Name = "Button2";
            Button2.Size = new Size(158, 48);
            Button2.TabIndex = 20;
            Button2.Text = "Actualizar";
            Button2.UseVisualStyleBackColor = true;
            // 
            // txtcontractualizar2
            // 
            txtcontractualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontractualizar2.Location = new Point(162, 134);
            txtcontractualizar2.Name = "txtcontractualizar2";
            txtcontractualizar2.Size = new Size(491, 38);
            txtcontractualizar2.TabIndex = 22;
            // 
            // txtnombreactualizar2
            // 
            txtnombreactualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombreactualizar2.Location = new Point(238, 36);
            txtnombreactualizar2.Name = "txtnombreactualizar2";
            txtnombreactualizar2.Size = new Size(474, 38);
            txtnombreactualizar2.TabIndex = 18;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(21, 43);
            Label6.Name = "Label6";
            Label6.Size = new Size(211, 31);
            Label6.TabIndex = 16;
            Label6.Text = "Nombre de usuario";
            // 
            // txtusernameactualizar2
            // 
            txtusernameactualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusernameactualizar2.Location = new Point(207, 87);
            txtusernameactualizar2.Name = "txtusernameactualizar2";
            txtusernameactualizar2.Size = new Size(505, 38);
            txtusernameactualizar2.TabIndex = 19;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(21, 94);
            Label7.Name = "Label7";
            Label7.Size = new Size(180, 31);
            Label7.TabIndex = 17;
            Label7.Text = "Nombre Publico";
            // 
            // panelbuscar
            // 
            panelbuscar.Controls.Add(Label4);
            panelbuscar.Controls.Add(picsi2);
            panelbuscar.Controls.Add(btnbuscar2);
            panelbuscar.Controls.Add(Label5);
            panelbuscar.Controls.Add(txtcontra2);
            panelbuscar.Controls.Add(picno2);
            panelbuscar.Controls.Add(txtusuario2);
            panelbuscar.Location = new Point(6, 6);
            panelbuscar.Name = "panelbuscar";
            panelbuscar.Size = new Size(839, 127);
            panelbuscar.TabIndex = 24;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(21, 16);
            Label4.Name = "Label4";
            Label4.Size = new Size(211, 31);
            Label4.TabIndex = 9;
            Label4.Text = "Nombre de usuario";
            // 
            // picsi2
            // 
            picsi2.Image = VentaAutos.My.Resources.Resources.ver;
            picsi2.Location = new Point(653, 57);
            picsi2.Name = "picsi2";
            picsi2.Size = new Size(34, 41);
            picsi2.SizeMode = PictureBoxSizeMode.Zoom;
            picsi2.TabIndex = 15;
            picsi2.TabStop = false;
            // 
            // btnbuscar2
            // 
            btnbuscar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbuscar2.Location = new Point(714, 54);
            btnbuscar2.Name = "btnbuscar2";
            btnbuscar2.Size = new Size(112, 48);
            btnbuscar2.TabIndex = 13;
            btnbuscar2.Text = "Buscar";
            btnbuscar2.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(21, 67);
            Label5.Name = "Label5";
            Label5.Size = new Size(129, 31);
            Label5.TabIndex = 10;
            Label5.Text = "Contraseña";
            // 
            // txtcontra2
            // 
            txtcontra2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontra2.Location = new Point(156, 60);
            txtcontra2.Name = "txtcontra2";
            txtcontra2.Size = new Size(491, 38);
            txtcontra2.TabIndex = 12;
            // 
            // picno2
            // 
            picno2.Image = VentaAutos.My.Resources.Resources.ojo__1_;
            picno2.Location = new Point(654, 57);
            picno2.Name = "picno2";
            picno2.Size = new Size(34, 41);
            picno2.SizeMode = PictureBoxSizeMode.Zoom;
            picno2.TabIndex = 14;
            picno2.TabStop = false;
            // 
            // txtusuario2
            // 
            txtusuario2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario2.Location = new Point(238, 9);
            txtusuario2.Name = "txtusuario2";
            txtusuario2.Size = new Size(474, 38);
            txtusuario2.TabIndex = 11;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(Label9);
            TabPage3.Controls.Add(picsi3);
            TabPage3.Controls.Add(Label10);
            TabPage3.Controls.Add(picno3);
            TabPage3.Controls.Add(txtusuario3);
            TabPage3.Controls.Add(txtcontra3);
            TabPage3.Controls.Add(Button3);
            TabPage3.Location = new Point(4, 50);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(856, 347);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Borrar Perfil";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(32, 68);
            Label9.Name = "Label9";
            Label9.Size = new Size(275, 41);
            Label9.TabIndex = 9;
            Label9.Text = "Nombre de usuario";
            // 
            // picsi3
            // 
            picsi3.Image = VentaAutos.My.Resources.Resources.ver;
            picsi3.Location = new Point(741, 144);
            picsi3.Name = "picsi3";
            picsi3.Size = new Size(34, 41);
            picsi3.SizeMode = PictureBoxSizeMode.Zoom;
            picsi3.TabIndex = 15;
            picsi3.TabStop = false;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(32, 148);
            Label10.Name = "Label10";
            Label10.Size = new Size(168, 41);
            Label10.TabIndex = 10;
            Label10.Text = "Contraseña";
            // 
            // picno3
            // 
            picno3.Image = VentaAutos.My.Resources.Resources.ojo__1_;
            picno3.Location = new Point(741, 144);
            picno3.Name = "picno3";
            picno3.Size = new Size(34, 41);
            picno3.SizeMode = PictureBoxSizeMode.Zoom;
            picno3.TabIndex = 14;
            picno3.TabStop = false;
            // 
            // txtusuario3
            // 
            txtusuario3.Location = new Point(313, 62);
            txtusuario3.Name = "txtusuario3";
            txtusuario3.Size = new Size(474, 47);
            txtusuario3.TabIndex = 11;
            // 
            // txtcontra3
            // 
            txtcontra3.Location = new Point(206, 142);
            txtcontra3.Name = "txtcontra3";
            txtcontra3.Size = new Size(528, 47);
            txtcontra3.TabIndex = 12;
            // 
            // Button3
            // 
            Button3.Location = new Point(549, 208);
            Button3.Name = "Button3";
            Button3.Size = new Size(238, 48);
            Button3.TabIndex = 13;
            Button3.Text = "borrar";
            Button3.UseVisualStyleBackColor = true;
            // 
            // InicioSeccion
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 485);
            Controls.Add(TabControl1);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "InicioSeccion";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)picno).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picsi).EndInit();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            panelactualizar.ResumeLayout(false);
            panelactualizar.PerformLayout();
            panelbuscar.ResumeLayout(false);
            panelbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picsi2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picno2).EndInit();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picsi3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picno3).EndInit();
            Load += new EventHandler(InicioSeccion_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal TextBox txtcontra;
        internal Button Button1;
        internal PictureBox PictureBox1;
        internal PictureBox picno;
        internal PictureBox picsi;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TextBox txtusuario;
        internal TabPage TabPage3;
        internal TabPage TabPage2;
        internal Label Label8;
        internal TextBox txtcontractualizar2;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtnombreactualizar2;
        internal TextBox txtusernameactualizar2;
        internal Button Button2;
        internal Label Label4;
        internal PictureBox picsi2;
        internal Label Label5;
        internal PictureBox picno2;
        internal TextBox txtusuario2;
        internal TextBox txtcontra2;
        internal Button btnbuscar2;
        internal Panel panelactualizar;
        internal Panel panelbuscar;
        internal Label Label9;
        internal PictureBox picsi3;
        internal Label Label10;
        internal PictureBox picno3;
        internal TextBox txtusuario3;
        internal TextBox txtcontra3;
        internal Button Button3;
    }
}