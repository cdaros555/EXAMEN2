Imports System.Data.SqlClient
Imports ClassLibrary1
Imports Entidades
Imports Datos
'Namespace ClassLibrary1
'    Friend Class clasealtametodos
'        Public Sub grabarplan()
'        End Sub
'    End Class
'End Namespace
Public Class FormAlta
    Dim conex As New ClaseConexion
    Dim Alta As Entidades.ClasPlanAhorro = New ClasPlanAhorro
    Dim altamet As ClassLibrary1.ClaseAltaMetodos = New ClassLibrary1.ClaseAltaMetodos
    Dim Dt1, Dt2, Dt3, Dt4 As DataTable
    Dim Cmd As New SqlCommand
    Dim Da As New SqlDataAdapter
    Dim Ds As New DataSet
    Private Sub FormAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargo_Combo_Vendedor()
        Cargo_Combo_Tipo_Plan()
    End Sub
    Public Sub Cargo_Combo_Vendedor()
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select legajo nombre,legajo From empleado"
            .Connection = conex.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt1 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt1) 'Relleno dentro de la tabla creada anteriormente
        With cbxVendedorAP
            'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt1
            .DisplayMember = "nombre" 'coincide con el campo/columna
            .ValueMember = "legajo" 'establece el orden
        End With
    End Sub
    Private Sub btnAltaPlan_Click(sender As Object, e As EventArgs) Handles btnAltaPlan.Click
        Cmd.Connection = conex.AbrirConexion
        'If Cmd.Connection.State = ConnectionState.Open Then
        '    MessageBox.Show("conex ABIERTT")
        'End If
        Alta._idPlan = txtTipoPlan.Text
        Alta._fecha_contrato = DateTimePicker1.Text
        Alta._vendedor = cbxVendedorAP.Text
        Alta._cliente = txtCliente.Text
        Alta._id_tipo_plan = cbxTipo.Text
        Alta._importe_cuotas = txtImporteCtaAP.Text
        altamet.grabarPlan(Alta)
    End Sub
    Public Sub Cargo_Combo_Tipo_Plan()
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select id_tipo idplan, id_tipo From tipo_plan"
            .Connection = conex.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt2 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt2) 'Relleno dentro de la tabla creada anteriormente
        With cbxTipo  'Recorro y lleno el cbxPaisP con los nombres de la tabla 
            .DataSource = Dt2
            .DisplayMember = "idplan"
            .ValueMember = "id_tipo"
        End With
    End Sub
    Private Sub btnIrGrilla_Click(sender As Object, e As EventArgs) Handles btnIrGrilla.Click
        FormListar.Show()
        'Me.Close()
    End Sub
    Private Sub cbxtipo_keypress(sender As Object, e As KeyPressEventArgs) Handles cbxTipo.KeyPress
        e.Handled = True
    End Sub
    Private Sub cbxVendedorAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxVendedorAP.KeyPress
        e.Handled = True
    End Sub
End Class
