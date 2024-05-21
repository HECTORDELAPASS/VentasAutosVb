<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSeccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picsi = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picno = New System.Windows.Forms.PictureBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNotengo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtcreanombre = New System.Windows.Forms.TextBox()
        Me.txtcrear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcreausername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcreacontra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de credenciales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VentaAutos.My.Resources.Resources.salida_de_emergencia
        Me.PictureBox1.Location = New System.Drawing.Point(720, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre de usuario"
        '
        'picsi
        '
        Me.picsi.Image = Global.VentaAutos.My.Resources.Resources.ver
        Me.picsi.Location = New System.Drawing.Point(732, 98)
        Me.picsi.Name = "picsi"
        Me.picsi.Size = New System.Drawing.Size(34, 41)
        Me.picsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picsi.TabIndex = 15
        Me.picsi.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 41)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Contraseña"
        '
        'picno
        '
        Me.picno.Image = Global.VentaAutos.My.Resources.Resources.ojo__1_
        Me.picno.Location = New System.Drawing.Point(732, 98)
        Me.picno.Name = "picno"
        Me.picno.Size = New System.Drawing.Size(34, 41)
        Me.picno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picno.TabIndex = 14
        Me.picno.TabStop = False
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(292, 18)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(474, 47)
        Me.txtusuario.TabIndex = 11
        '
        'txtcontra
        '
        Me.txtcontra.Location = New System.Drawing.Point(185, 98)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(528, 47)
        Me.txtcontra.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNotengo
        '
        Me.txtNotengo.AutoSize = True
        Me.txtNotengo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotengo.ForeColor = System.Drawing.Color.Red
        Me.txtNotengo.Location = New System.Drawing.Point(634, 309)
        Me.txtNotengo.Name = "txtNotengo"
        Me.txtNotengo.Size = New System.Drawing.Size(162, 28)
        Me.txtNotengo.TabIndex = 17
        Me.txtNotengo.Text = "No tengo Cuenta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtusuario)
        Me.Panel1.Controls.Add(Me.picno)
        Me.Panel1.Controls.Add(Me.picsi)
        Me.Panel1.Controls.Add(Me.txtcontra)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 220)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtcreacontra)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtcreausername)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtcreanombre)
        Me.Panel2.Controls.Add(Me.txtcrear)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(10, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 220)
        Me.Panel2.TabIndex = 20
        '
        'txtcreanombre
        '
        Me.txtcreanombre.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreanombre.Location = New System.Drawing.Point(228, 52)
        Me.txtcreanombre.Name = "txtcreanombre"
        Me.txtcreanombre.Size = New System.Drawing.Size(474, 38)
        Me.txtcreanombre.TabIndex = 11
        '
        'txtcrear
        '
        Me.txtcrear.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrear.Location = New System.Drawing.Point(600, 165)
        Me.txtcrear.Name = "txtcrear"
        Me.txtcrear.Size = New System.Drawing.Size(183, 38)
        Me.txtcrear.TabIndex = 13
        Me.txtcrear.Text = "Crear Usuario"
        Me.txtcrear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre de usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre Publico "
        '
        'txtcreausername
        '
        Me.txtcreausername.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreausername.Location = New System.Drawing.Point(203, 111)
        Me.txtcreausername.Name = "txtcreausername"
        Me.txtcreausername.Size = New System.Drawing.Size(499, 38)
        Me.txtcreausername.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 31)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Contraseña"
        '
        'txtcreacontra
        '
        Me.txtcreacontra.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreacontra.Location = New System.Drawing.Point(146, 166)
        Me.txtcreacontra.Name = "txtcreacontra"
        Me.txtcreacontra.Size = New System.Drawing.Size(448, 38)
        Me.txtcreacontra.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 31)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Crear Usuario"
        '
        'InicioSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 355)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNotengo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "InicioSeccion"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picsi As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picno As PictureBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNotengo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtcreanombre As TextBox
    Friend WithEvents txtcrear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcreacontra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcreausername As TextBox
    Friend WithEvents Label4 As Label
End Class
