<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListar
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
        Me.dgvPlan = New System.Windows.Forms.DataGridView()
        Me.btnIrAltaPlan = New System.Windows.Forms.Button()
        CType(Me.dgvPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPlan
        '
        Me.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlan.Location = New System.Drawing.Point(12, 58)
        Me.dgvPlan.Name = "dgvPlan"
        Me.dgvPlan.Size = New System.Drawing.Size(1163, 501)
        Me.dgvPlan.TabIndex = 1
        '
        'btnIrAltaPlan
        '
        Me.btnIrAltaPlan.Location = New System.Drawing.Point(532, 590)
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
        Me.ClientSize = New System.Drawing.Size(1187, 666)
        Me.Controls.Add(Me.btnIrAltaPlan)
        Me.Controls.Add(Me.dgvPlan)
        Me.Name = "FormListar"
        Me.Text = "Listar"
        CType(Me.dgvPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPlan As DataGridView
    Friend WithEvents btnIrAltaPlan As Button
End Class
