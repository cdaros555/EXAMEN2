Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseAltaMetodos
    Public con As New SqlConnection
    Public com As New SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public conn As New ClaseConexion

    Public Sub grabarPlan(ByVal alta As ClaseAlta)

        Dim sel As String
        ' Dim sqlUltimoPacInsertado As Integer
        Try
            conn.AbrirConexion()
            'INSERTO EN PACIENTE
            sel = "set dateformat dmy INSERT INTO PLANES_AHORRO" &
                    "(fecha_contrato,vendedor,cliene,id_tipo_plan,importe_cuota) " &
                    "VALUES ('" & alta._fecha_contrato & "','" &
                      alta._vendedor & "','" &
                      alta._cliente & "','" &
                      alta._id_tipo_plan & "','" &
                      alta._importe_cuotas & "'" & ")" 'en este "1" debo dejar registro de la persona que lo dio de alta.
            com.CommandText = sel
            com.ExecuteNonQuery()
            sel = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hubo un Error")
        Finally
            conn.CerrarConexion()
        End Try
    End Sub

End Class
