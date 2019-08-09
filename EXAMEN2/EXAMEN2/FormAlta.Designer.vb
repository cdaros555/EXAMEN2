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
        Me.txtFechaContratoAP = New System.Windows.Forms.TextBox()
        Me.btnIrGrilla = New System.Windows.Forms.Button()
        Me.cbxCantCuotasPlanAP = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImporteCtaAP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescripcionAP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecioAP = New System.Windows.Forms.TextBox()
        Me.cbxMarcaAP = New System.Windows.Forms.ComboBox()
        Me.cbxModeloAP = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAltaPlan
        '
        Me.btnAltaPlan.Location = New System.Drawing.Point(182, 371)
        Me.btnAltaPlan.Name = "btnAltaPlan"
        Me.btnAltaPlan.Size = New System.Drawing.Size(151, 46)
        Me.btnAltaPlan.TabIndex = 21
        Me.btnAltaPlan.Text = "GRABAR"
        Me.btnAltaPlan.UseVisualStyleBackColor = True
        '
        'cbxVendedorAP
        '
        Me.cbxVendedorAP.FormattingEnabled = True
        Me.cbxVendedorAP.Location = New System.Drawing.Point(231, 60)
        Me.cbxVendedorAP.Name = "cbxVendedorAP"
        Me.cbxVendedorAP.Size = New System.Drawing.Size(154, 21)
        Me.cbxVendedorAP.TabIndex = 20
        '
        'cbxClienteAP
        '
        Me.cbxClienteAP.FormattingEnabled = True
        Me.cbxClienteAP.Location = New System.Drawing.Point(231, 98)
        Me.cbxClienteAP.Name = "cbxClienteAP"
        Me.cbxClienteAP.Size = New System.Drawing.Size(154, 21)
        Me.cbxClienteAP.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "MODELO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "VENDEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "FECHA CONTRATO"
        '
        'txtFechaContratoAP
        '
        Me.txtFechaContratoAP.Location = New System.Drawing.Point(231, 25)
        Me.txtFechaContratoAP.Name = "txtFechaContratoAP"
        Me.txtFechaContratoAP.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaContratoAP.TabIndex = 13
        '
        'btnIrGrilla
        '
        Me.btnIrGrilla.Location = New System.Drawing.Point(182, 445)
        Me.btnIrGrilla.Name = "btnIrGrilla"
        Me.btnIrGrilla.Size = New System.Drawing.Size(151, 46)
        Me.btnIrGrilla.TabIndex = 22
        Me.btnIrGrilla.Text = "VER GRILLA"
        Me.btnIrGrilla.UseVisualStyleBackColor = True
        '
        'cbxCantCuotasPlanAP
        '
        Me.cbxCantCuotasPlanAP.FormattingEnabled = True
        Me.cbxCantCuotasPlanAP.Location = New System.Drawing.Point(233, 231)
        Me.cbxCantCuotasPlanAP.Name = "cbxCantCuotasPlanAP"
        Me.cbxCantCuotasPlanAP.Size = New System.Drawing.Size(35, 21)
        Me.cbxCantCuotasPlanAP.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "CANT. CUOTAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "IMPORTE"
        '
        'txtImporteCtaAP
        '
        Me.txtImporteCtaAP.Location = New System.Drawing.Point(233, 264)
        Me.txtImporteCtaAP.Name = "txtImporteCtaAP"
        Me.txtImporteCtaAP.ReadOnly = True
        Me.txtImporteCtaAP.Size = New System.Drawing.Size(74, 20)
        Me.txtImporteCtaAP.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "DESCRIPCION"
        '
        'txtDescripcionAP
        '
        Me.txtDescripcionAP.Location = New System.Drawing.Point(233, 301)
        Me.txtDescripcionAP.Name = "txtDescripcionAP"
        Me.txtDescripcionAP.ReadOnly = True
        Me.txtDescripcionAP.Size = New System.Drawing.Size(154, 20)
        Me.txtDescripcionAP.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(113, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "MARCA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(116, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "PRECIO"
        '
        'txtPrecioAP
        '
        Me.txtPrecioAP.Location = New System.Drawing.Point(233, 200)
        Me.txtPrecioAP.Name = "txtPrecioAP"
        Me.txtPrecioAP.ReadOnly = True
        Me.txtPrecioAP.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioAP.TabIndex = 32
        '
        'cbxMarcaAP
        '
        Me.cbxMarcaAP.FormattingEnabled = True
        Me.cbxMarcaAP.Location = New System.Drawing.Point(233, 135)
        Me.cbxMarcaAP.Name = "cbxMarcaAP"
        Me.cbxMarcaAP.Size = New System.Drawing.Size(154, 21)
        Me.cbxMarcaAP.TabIndex = 35
        '
        'cbxModeloAP
        '
        Me.cbxModeloAP.FormattingEnabled = True
        Me.cbxModeloAP.Location = New System.Drawing.Point(233, 173)
        Me.cbxModeloAP.Name = "cbxModeloAP"
        Me.cbxModeloAP.Size = New System.Drawing.Size(154, 21)
        Me.cbxModeloAP.TabIndex = 34
        '
        'FormAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 539)
        Me.Controls.Add(Me.cbxMarcaAP)
        Me.Controls.Add(Me.cbxModeloAP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecioAP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescripcionAP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtImporteCtaAP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxCantCuotasPlanAP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnIrGrilla)
        Me.Controls.Add(Me.btnAltaPlan)
        Me.Controls.Add(Me.cbxVendedorAP)
        Me.Controls.Add(Me.cbxClienteAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents txtFechaContratoAP As TextBox
    Friend WithEvents btnIrGrilla As Button
    Friend WithEvents cbxCantCuotasPlanAP As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImporteCtaAP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescripcionAP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecioAP As TextBox
    Friend WithEvents cbxMarcaAP As ComboBox
    Friend WithEvents cbxModeloAP As ComboBox
End Class
