<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class busquedaedoventa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdNombre = New System.Windows.Forms.RadioButton()
        Me.Rdid = New System.Windows.Forms.RadioButton()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.ListId = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ListEdo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Busqueda Avanzada Estados de venta"
        '
        'RdNombre
        '
        Me.RdNombre.AutoSize = True
        Me.RdNombre.Location = New System.Drawing.Point(665, 78)
        Me.RdNombre.Name = "RdNombre"
        Me.RdNombre.Size = New System.Drawing.Size(149, 45)
        Me.RdNombre.TabIndex = 9
        Me.RdNombre.TabStop = True
        Me.RdNombre.Text = "Nombre"
        Me.RdNombre.UseVisualStyleBackColor = True
        '
        'Rdid
        '
        Me.Rdid.AutoSize = True
        Me.Rdid.Location = New System.Drawing.Point(599, 78)
        Me.Rdid.Name = "Rdid"
        Me.Rdid.Size = New System.Drawing.Size(65, 45)
        Me.Rdid.TabIndex = 8
        Me.Rdid.TabStop = True
        Me.Rdid.Text = "Id"
        Me.Rdid.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(24, 75)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(569, 47)
        Me.txtbuscar.TabIndex = 7
        '
        'ListId
        '
        Me.ListId.FormattingEnabled = True
        Me.ListId.ItemHeight = 41
        Me.ListId.Location = New System.Drawing.Point(24, 139)
        Me.ListId.Name = "ListId"
        Me.ListId.Size = New System.Drawing.Size(144, 537)
        Me.ListId.TabIndex = 11
        '
        'ListEdo
        '
        Me.ListEdo.FormattingEnabled = True
        Me.ListEdo.ItemHeight = 41
        Me.ListEdo.Location = New System.Drawing.Point(174, 139)
        Me.ListEdo.Name = "ListEdo"
        Me.ListEdo.Size = New System.Drawing.Size(640, 537)
        Me.ListEdo.TabIndex = 12
        '
        'busquedaedoventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 697)
        Me.Controls.Add(Me.ListEdo)
        Me.Controls.Add(Me.ListId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdNombre)
        Me.Controls.Add(Me.Rdid)
        Me.Controls.Add(Me.txtbuscar)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "busquedaedoventa"
        Me.Text = "busquedaedoventa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RdNombre As RadioButton
    Friend WithEvents Rdid As RadioButton
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents ListId As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListEdo As ListBox
End Class
