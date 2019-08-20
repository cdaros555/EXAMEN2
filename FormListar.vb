Imports System.Data.SqlClient
Public Class FormListar
    Dim conex As New SqlConnection
    Dim con As Datos.ClaseConexion = New Datos.ClaseConexion
    Private Sub FormListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conex = con.AbrirConexion
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("select 
P.id_plan,
T.marca,
E.Nombre_E +' '+ E.Apellido_E VENDEDOR,
K.Nombre_C +' '+ K.Apellido_C CLIENTE,
P.Fch_Contrato,
P.Importe_Cuota,
V.Precio
from Cliente K,
PlanesAhorro P,
tipo_plan T, 
empleado E,
vehiculos V
WHERE T.marca = V.Marca and 
P.Vendedor = E.Legajo and
P.Cliente = K.Id_Client and
P.Id_TipoPlan = T.Id_Tipo
", conex)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dtv.DataSource = dt
    End Sub
    Private Sub btnIrAltaPlan_Click(sender As Object, e As EventArgs) Handles btnIrAltaPlan.Click
        FormAlta.Show()
        Me.Close()
    End Sub
End Class