Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseAltaMetodos
    Public con As New SqlConnection
    Public com As New SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public conn As New ClaseConexion

    Public Sub AbrirConexion()
        Dim objcon As New ClaseConexion
        con = objcon.AbrirConexion
        com.Connection = con
    End Sub
    Public Sub grabarPlan(ByVal alta As ClaseAlta)

        Dim sel As String
        ' Dim sqlUltimoPacInsertado As Integer
        Try
            AbrirConexion()
            'INSERTO EN PACIENTE
            sel = "set dateformat dmy INSERT INTO PLANES_AHORRO" &
                    "(fecha_contrato,vendedor,cliente,id_tipo_plan,importe_cuota) " &
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

    Sub llenarGrilla(ByVal dgv As DataGridView)
        Dim sqlStr As String
        ds = New DataSet
        dt = New DataTable

        Try
            AbrirConexion()
            sqlStr = "select RTRIM(pa.id_plan)  ID_PLAN,RTRIM(tp.marca) MARCA,RTRIM(e.nombre) NOMBRE_VENDEDOR,RTRIM(c.nombre) NOMBRE_CLIENTE,
	                           RTRIM(pa.fecha_contrato) FECHA_CONTRATO,concat('$',RTRIM(tp.importe_cuotas)) IMPORTE_CUOTA, 
	                           concat(RTRIM(c.nombre),' ',RTRIM(c.apellido)) NOMBRE_APELLIDO_C,concat(RTRIM(e.nombre),' ',RTRIM(e.apellido)) NOMBRE_APELLIDO_V,concat('$',RTRIM(v.precio)) PRECIO_VEHICULO
	 
                        from
                           planes_ahorro pa,
                           vehiculos v,
                           tipo_plan tp,
                           cliente c,
                           empleados e
                        where 
                           e.legajo=pa.vendedor
                           and pa.cliente=c.id
                           and pa.id_tipo_plan=tp.id
                           and tp.ID_VEHICULOS=v.id
                        order by fecha_contrato asc
                           ;"
            da = New SqlDataAdapter(sqlStr, con)
            '  da.Fill(ds, "Consulta")
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al llenar la grilla")
        Finally
            conn.CerrarConexion()
        End Try
        ' Return ds

    End Sub

End Class
