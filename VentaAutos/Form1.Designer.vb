<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CboEdo = New System.Windows.Forms.ComboBox()
        Me.CboAgen = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.CboYear = New System.Windows.Forms.ComboBox()
        Me.d = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 173)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1493, 624)
        Me.DataGridView1.TabIndex = 0
        '
        'CboEdo
        '
        Me.CboEdo.FormattingEnabled = True
        Me.CboEdo.Location = New System.Drawing.Point(22, 104)
        Me.CboEdo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.CboEdo.Name = "CboEdo"
        Me.CboEdo.Size = New System.Drawing.Size(294, 45)
        Me.CboEdo.TabIndex = 1
        '
        'CboAgen
        '
        Me.CboAgen.FormattingEnabled = True
        Me.CboAgen.Location = New System.Drawing.Point(349, 104)
        Me.CboAgen.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.CboAgen.Name = "CboAgen"
        Me.CboAgen.Size = New System.Drawing.Size(294, 45)
        Me.CboAgen.TabIndex = 2
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI Semilight", 16.2!)
        Me.txtbuscar.Location = New System.Drawing.Point(18, 35)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(332, 43)
        Me.txtbuscar.TabIndex = 3
        '
        'CboYear
        '
        Me.CboYear.FormattingEnabled = True
        Me.CboYear.Location = New System.Drawing.Point(677, 104)
        Me.CboYear.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.CboYear.Name = "CboYear"
        Me.CboYear.Size = New System.Drawing.Size(187, 45)
        Me.CboYear.TabIndex = 4
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.d.Location = New System.Drawing.Point(672, 79)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(164, 28)
        Me.d.TabIndex = 6
        Me.d.Text = "Fecha Por Estados"
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.R1.Location = New System.Drawing.Point(365, 44)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(47, 32)
        Me.R1.TabIndex = 8
        Me.R1.TabStop = True
        Me.R1.Text = "Si"
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.R2.Location = New System.Drawing.Point(420, 44)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(59, 32)
        Me.R2.TabIndex = 9
        Me.R2.TabStop = True
        Me.R2.Text = "No"
        Me.R2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(351, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Filtrar Fecha?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(864, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 92)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda Por Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(17, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Estados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(344, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Agencias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1004, 41)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ventas de Vehiculos, segmentadas por el Estado de venta y sus Agencias"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VentaAutos.My.Resources.Resources.agregar_carrito
        Me.PictureBox2.Location = New System.Drawing.Point(1412, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(1381, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 28)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Agregar Venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.CboYear)
        Me.Controls.Add(Me.CboAgen)
        Me.Controls.Add(Me.CboEdo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CboEdo As ComboBox
    Friend WithEvents CboAgen As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents CboYear As ComboBox
    Friend WithEvents d As Label
    Friend WithEvents R1 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
End Class
