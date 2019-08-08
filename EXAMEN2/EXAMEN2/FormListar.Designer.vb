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
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtv
        '
        Me.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv.Location = New System.Drawing.Point(12, 58)
        Me.dtv.Name = "dtv"
        Me.dtv.Size = New System.Drawing.Size(598, 501)
        Me.dtv.TabIndex = 1
        '
        'btnIrAltaPlan
        '
        Me.btnIrAltaPlan.Location = New System.Drawing.Point(229, 601)
        Me.btnIrAltaPlan.Name = "btnIrAltaPlan"
        Me.btnIrAltaPlan.Size = New System.Drawing.Size(151, 46)
        Me.btnIrAltaPlan.TabIndex = 22
        Me.btnIrAltaPlan.Text = "IR ALTA PLAN"
        Me.btnIrAltaPlan.UseVisualStyleBackColor = True
        '
        'FormListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 698)
        Me.Controls.Add(Me.btnIrAltaPlan)
        Me.Controls.Add(Me.dtv)
        Me.Name = "FormListar"
        Me.Text = "Listar"
        CType(Me.dtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtv As DataGridView
    Friend WithEvents btnIrAltaPlan As Button
End Class
