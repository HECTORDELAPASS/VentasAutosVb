<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busquedavehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busquedavehiculo))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.CboAgencia = New System.Windows.Forms.ComboBox()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.txtvin = New System.Windows.Forms.TextBox()
        Me.rdmodelo = New System.Windows.Forms.RadioButton()
        Me.rdvin = New System.Windows.Forms.RadioButton()
        Me.Agencia = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1236, 597)
        Me.DataGridView1.TabIndex = 16
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Font = New System.Drawing.Font("Segoe UI Semibold", 28.2!, System.Drawing.FontStyle.Bold)
        Me.txt1.ForeColor = System.Drawing.Color.Maroon
        Me.txt1.Location = New System.Drawing.Point(13, 14)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(889, 62)
        Me.txt1.TabIndex = 15
        Me.txt1.Text = "Busqueda Avanzada Codigo de vehiculo "
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(662, 127)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(293, 47)
        Me.txtbuscar.TabIndex = 12
        '
        'CboAgencia
        '
        Me.CboAgencia.FormattingEnabled = True
        Me.CboAgencia.Location = New System.Drawing.Point(20, 125)
        Me.CboAgencia.Name = "CboAgencia"
        Me.CboAgencia.Size = New System.Drawing.Size(372, 49)
        Me.CboAgencia.TabIndex = 20
        '
        'cboyear
        '
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Location = New System.Drawing.Point(409, 125)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(231, 49)
        Me.cboyear.TabIndex = 22
        '
        'txtvin
        '
        Me.txtvin.Location = New System.Drawing.Point(1110, 125)
        Me.txtvin.Name = "txtvin"
        Me.txtvin.Size = New System.Drawing.Size(293, 47)
        Me.txtvin.TabIndex = 23
        '
        'rdmodelo
        '
        Me.rdmodelo.AutoSize = True
        Me.rdmodelo.Location = New System.Drawing.Point(961, 127)
        Me.rdmodelo.Name = "rdmodelo"
        Me.rdmodelo.Size = New System.Drawing.Size(143, 45)
        Me.rdmodelo.TabIndex = 24
        Me.rdmodelo.TabStop = True
        Me.rdmodelo.Text = "Modelo"
        Me.rdmodelo.UseVisualStyleBackColor = True
        '
        'rdvin
        '
        Me.rdvin.AutoSize = True
        Me.rdvin.Location = New System.Drawing.Point(1409, 126)
        Me.rdvin.Name = "rdvin"
        Me.rdvin.Size = New System.Drawing.Size(82, 45)
        Me.rdvin.TabIndex = 25
        Me.rdvin.TabStop = True
        Me.rdvin.Text = "Vin"
        Me.rdvin.UseVisualStyleBackColor = True
        '
        'Agencia
        '
        Me.Agencia.AutoSize = True
        Me.Agencia.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Agencia.Location = New System.Drawing.Point(13, 89)
        Me.Agencia.Name = "Agencia"
        Me.Agencia.Size = New System.Drawing.Size(99, 32)
        Me.Agencia.TabIndex = 26
        Me.Agencia.Text = "Agencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(402, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(655, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(1103, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 32)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Codigo Vehiculo"
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lb3.Location = New System.Drawing.Point(1312, 812)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(174, 30)
        Me.lb3.TabIndex = 35
        Me.lb3.Text = "Eliminar Registro"
        '
        'pic3
        '
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(1298, 643)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(193, 166)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 34
        Me.pic3.TabStop = False
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lb2.Location = New System.Drawing.Point(1312, 575)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(191, 30)
        Me.lb2.TabIndex = 33
        Me.lb2.Text = "Actualizar Registro"
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(1298, 406)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(193, 166)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 32
        Me.pic2.TabStop = False
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lb1.Location = New System.Drawing.Point(1312, 344)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(177, 30)
        Me.lb1.TabIndex = 31
        Me.lb1.Text = "Agregar Registro"
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(1298, 175)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(193, 166)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 30
        Me.pic1.TabStop = False
        '
        'busquedavehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Agencia)
        Me.Controls.Add(Me.rdvin)
        Me.Controls.Add(Me.rdmodelo)
        Me.Controls.Add(Me.txtvin)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.CboAgencia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "busquedavehiculo"
        Me.Text = "busquedavehiculo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt1 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents CboAgencia As ComboBox
    Friend WithEvents cboyear As ComboBox
    Friend WithEvents txtvin As TextBox
    Friend WithEvents rdmodelo As RadioButton
    Friend WithEvents rdvin As RadioButton
    Friend WithEvents Agencia As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents lb2 As Label
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents lb1 As Label
    Friend WithEvents pic1 As PictureBox
End Class
