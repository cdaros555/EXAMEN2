<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAltaPlan = New System.Windows.Forms.Button()
        Me.cbxVendedorAP = New System.Windows.Forms.ComboBox()
        Me.cbxClienteAP = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImporteCuotaAP = New System.Windows.Forms.TextBox()
        Me.txtFechaContratoAP = New System.Windows.Forms.TextBox()
        Me.btnIrGrilla = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAltaPlan
        '
        Me.btnAltaPlan.Location = New System.Drawing.Point(190, 315)
        Me.btnAltaPlan.Name = "btnAltaPlan"
        Me.btnAltaPlan.Size = New System.Drawing.Size(151, 46)
        Me.btnAltaPlan.TabIndex = 21
        Me.btnAltaPlan.Text = "GRABAR"
        Me.btnAltaPlan.UseVisualStyleBackColor = True
        '
        'cbxVendedorAP
        '
        Me.cbxVendedorAP.FormattingEnabled = True
        Me.cbxVendedorAP.Location = New System.Drawing.Point(241, 169)
        Me.cbxVendedorAP.Name = "cbxVendedorAP"
        Me.cbxVendedorAP.Size = New System.Drawing.Size(121, 21)
        Me.cbxVendedorAP.TabIndex = 20
        '
        'cbxClienteAP
        '
        Me.cbxClienteAP.FormattingEnabled = True
        Me.cbxClienteAP.Location = New System.Drawing.Point(241, 207)
        Me.cbxClienteAP.Name = "cbxClienteAP"
        Me.cbxClienteAP.Size = New System.Drawing.Size(121, 21)
        Me.cbxClienteAP.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "IMPORTE CUOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "VENDEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "FECHA CONTRATO"
        '
        'txtImporteCuotaAP
        '
        Me.txtImporteCuotaAP.Location = New System.Drawing.Point(241, 245)
        Me.txtImporteCuotaAP.Name = "txtImporteCuotaAP"
        Me.txtImporteCuotaAP.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteCuotaAP.TabIndex = 14
        '
        'txtFechaContratoAP
        '
        Me.txtFechaContratoAP.Location = New System.Drawing.Point(241, 134)
        Me.txtFechaContratoAP.Name = "txtFechaContratoAP"
        Me.txtFechaContratoAP.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaContratoAP.TabIndex = 13
        '
        'btnIrGrilla
        '
        Me.btnIrGrilla.Location = New System.Drawing.Point(190, 389)
        Me.btnIrGrilla.Name = "btnIrGrilla"
        Me.btnIrGrilla.Size = New System.Drawing.Size(151, 46)
        Me.btnIrGrilla.TabIndex = 22
        Me.btnIrGrilla.Text = "VER GRILLA"
        Me.btnIrGrilla.UseVisualStyleBackColor = True
        '
        'FormAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 487)
        Me.Controls.Add(Me.btnIrGrilla)
        Me.Controls.Add(Me.btnAltaPlan)
        Me.Controls.Add(Me.cbxVendedorAP)
        Me.Controls.Add(Me.cbxClienteAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporteCuotaAP)
        Me.Controls.Add(Me.txtFechaContratoAP)
        Me.Name = "FormAlta"
        Me.Text = "Alta Plan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAltaPlan As Button
    Friend WithEvents cbxVendedorAP As ComboBox
    Friend WithEvents cbxClienteAP As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImporteCuotaAP As TextBox
    Friend WithEvents txtFechaContratoAP As TextBox
    Friend WithEvents btnIrGrilla As Button
End Class
