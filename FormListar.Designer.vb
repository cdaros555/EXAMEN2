<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListar
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
        Me.dtv = New System.Windows.Forms.DataGridView()
        Me.btnIrAltaPlan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtv
        '
        Me.dtv.AllowUserToAddRows = False
        Me.dtv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv.Location = New System.Drawing.Point(12, 54)
        Me.dtv.Name = "dtv"
        Me.dtv.ReadOnly = True
        Me.dtv.Size = New System.Drawing.Size(788, 256)
        Me.dtv.TabIndex = 1
        '
        'btnIrAltaPlan
        '
        Me.btnIrAltaPlan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIrAltaPlan.Location = New System.Drawing.Point(649, 316)
        Me.btnIrAltaPlan.Name = "btnIrAltaPlan"
        Me.btnIrAltaPlan.Size = New System.Drawing.Size(151, 46)
        Me.btnIrAltaPlan.TabIndex = 22
        Me.btnIrAltaPlan.Text = "IR ALTA PLAN"
        Me.btnIrAltaPlan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Planes de Ahorro"
        '
        'FormListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 374)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIrAltaPlan)
        Me.Controls.Add(Me.dtv)
        Me.Name = "FormListar"
        Me.Text = "Listar"
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtv As DataGridView
    Friend WithEvents btnIrAltaPlan As Button
    Friend WithEvents Label1 As Label
End Class
