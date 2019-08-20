<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAltaPlan = New System.Windows.Forms.Button()
        Me.cbxVendedorAP = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIrGrilla = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImporteCtaAP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipoPlan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAltaPlan
        '
        Me.btnAltaPlan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAltaPlan.Location = New System.Drawing.Point(570, 338)
        Me.btnAltaPlan.Name = "btnAltaPlan"
        Me.btnAltaPlan.Size = New System.Drawing.Size(151, 39)
        Me.btnAltaPlan.TabIndex = 21
        Me.btnAltaPlan.Text = "Añadir Plan"
        Me.btnAltaPlan.UseVisualStyleBackColor = True
        '
        'cbxVendedorAP
        '
        Me.cbxVendedorAP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxVendedorAP.IntegralHeight = False
        Me.cbxVendedorAP.Location = New System.Drawing.Point(174, 125)
        Me.cbxVendedorAP.Name = "cbxVendedorAP"
        Me.cbxVendedorAP.Size = New System.Drawing.Size(154, 21)
        Me.cbxVendedorAP.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID del Plan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Vendedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha Contrato:"
        '
        'btnIrGrilla
        '
        Me.btnIrGrilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIrGrilla.Location = New System.Drawing.Point(391, 338)
        Me.btnIrGrilla.Name = "btnIrGrilla"
        Me.btnIrGrilla.Size = New System.Drawing.Size(151, 39)
        Me.btnIrGrilla.TabIndex = 22
        Me.btnIrGrilla.Text = "Listar "
        Me.btnIrGrilla.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Importe Cuota:"
        '
        'txtImporteCtaAP
        '
        Me.txtImporteCtaAP.Location = New System.Drawing.Point(593, 76)
        Me.txtImporteCtaAP.Name = "txtImporteCtaAP"
        Me.txtImporteCtaAP.Size = New System.Drawing.Size(128, 20)
        Me.txtImporteCtaAP.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Tipo:"
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(174, 75)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(154, 21)
        Me.cbxTipo.TabIndex = 35
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(174, 184)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(154, 20)
        Me.txtCliente.TabIndex = 36
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(593, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(566, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "$"
        '
        'txtTipoPlan
        '
        Me.txtTipoPlan.Location = New System.Drawing.Point(174, 24)
        Me.txtTipoPlan.Name = "txtTipoPlan"
        Me.txtTipoPlan.Size = New System.Drawing.Size(154, 20)
        Me.txtTipoPlan.TabIndex = 40
        '
        'FormAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EXAMEN2.My.Resources.Resources.Maipu
        Me.ClientSize = New System.Drawing.Size(745, 395)
        Me.Controls.Add(Me.txtTipoPlan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtImporteCtaAP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnIrGrilla)
        Me.Controls.Add(Me.btnAltaPlan)
        Me.Controls.Add(Me.cbxVendedorAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAlta"
        Me.Text = "SISTEMA DE PLANES DE AHORRO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAltaPlan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIrGrilla As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImporteCtaAP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxVendedorAP As ComboBox
    Friend WithEvents txtTipoPlan As TextBox
End Class
