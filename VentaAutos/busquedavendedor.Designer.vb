<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busquedavendedor
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
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Rdid = New System.Windows.Forms.RadioButton()
        Me.RdNombre = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(15, 62)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(569, 47)
        Me.txtbuscar.TabIndex = 2
        '
        'Rdid
        '
        Me.Rdid.AutoSize = True
        Me.Rdid.Location = New System.Drawing.Point(590, 65)
        Me.Rdid.Name = "Rdid"
        Me.Rdid.Size = New System.Drawing.Size(65, 45)
        Me.Rdid.TabIndex = 3
        Me.Rdid.TabStop = True
        Me.Rdid.Text = "Id"
        Me.Rdid.UseVisualStyleBackColor = True
        '
        'RdNombre
        '
        Me.RdNombre.AutoSize = True
        Me.RdNombre.Location = New System.Drawing.Point(656, 65)
        Me.RdNombre.Name = "RdNombre"
        Me.RdNombre.Size = New System.Drawing.Size(149, 45)
        Me.RdNombre.TabIndex = 4
        Me.RdNombre.TabStop = True
        Me.RdNombre.Text = "Nombre"
        Me.RdNombre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Busqueda Avanzada Vendedores"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(787, 522)
        Me.DataGridView1.TabIndex = 6
        '
        'busquedavendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 685)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdNombre)
        Me.Controls.Add(Me.Rdid)
        Me.Controls.Add(Me.txtbuscar)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "busquedavendedor"
        Me.Text = "busquedavendedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Rdid As RadioButton
    Friend WithEvents RdNombre As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
