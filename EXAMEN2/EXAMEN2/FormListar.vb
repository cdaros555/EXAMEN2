Public Class FormListar
    Private altamet As New ClaseAltaMetodos
    Private Sub FormListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        altamet.llenarGrilla(dgvPlan)
        dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPlan.AutoResizeColumns()
    End Sub

    Private Sub btnIrAltaPlan_Click(sender As Object, e As EventArgs) Handles btnIrAltaPlan.Click
        Me.Hide()
        FormAlta.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '  altamet.llenarGrilla(dgvPlan)
    End Sub

    Private Sub dgvPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlan.CellContentClick

    End Sub
End Class