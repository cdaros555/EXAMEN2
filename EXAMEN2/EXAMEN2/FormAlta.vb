Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FormAlta
    Private alta As ClaseAlta
    Private altamet As New ClaseAltaMetodos
    Dim Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8 As DataTable
    Dim conn As New ClaseConexion
    Dim Cmd As New SqlCommand
    Dim Da As New SqlDataAdapter
    Dim Ds As New DataSet
    Dim drd As SqlDataReader
    Dim IDVEHICULO, IDPLAN As Integer
    Private Sub cbxClienteAP_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim cod As String = cbxClienteAP.SelectedValue.ToString 'aca voy a guardar los valores del valueMember del combo Pais (VAL para convertirlo a numero previo al string)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select RTRIM(CANTIDAD_CUOTAS)+' Ctas - '+RTRIM(DESCRIPCION_CUOTAS) AS PLANES,ID From TIPO_PLAN  where id like '" & cod & "'"
            .Connection = conn.AbrirConexion
        End With
        Da.SelectCommand = Cmd
        Dt3 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt3) 'Relleno dentro de la tabla creada anteriormente
        With cbxCantCuotasPlanAP 'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt3
            .DisplayMember = "PLANES" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "ID"
        End With
        '  Cn.Close()

    End Sub


    Private Sub btnAltaPlan_Click(sender As Object, e As EventArgs) Handles btnAltaPlan.Click
        '   Dim fecha_actual As Date
    End Sub

    Private Sub cbxMarcaAP_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxMarcaAP.SelectedValueChanged
        Try
            If String.IsNullOrEmpty(cbxMarcaAP.SelectedValue) Then  'Porque al inicializarse no tiene valores
                ' cerrarConexion()
            Else
                Dim cod As String = cbxMarcaAP.SelectedValue.ToString 'aca voy a guardar los valores del valueMember del combo Pais (VAL para convertirlo a numero previo al string)
                With Cmd
                    .CommandType = CommandType.Text
                    .CommandText = "Select MODELO,PRECIO,ID From VEHICULOS  where MARCA = '" & cod & "'"
                    .Connection = conn.AbrirConexion
                End With
                Da.SelectCommand = Cmd
                Dt5 = New DataTable 'aca recogere todos los valores
                Da.Fill(Dt5) 'Relleno dentro de la tabla creada anteriormente
                With cbxModeloAP 'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
                    .DataSource = Dt5
                    .DisplayMember = "MODELO" 'establece la propiedad que se va a mostrar en el control
                    .ValueMember = "MODELO" 'id
                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxModeloAP_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxModeloAP.SelectedValueChanged
        Try
            If String.IsNullOrEmpty(cbxModeloAP.SelectedValue) Then  'Porque al inicializarse no tiene valores
                ' cerrarConexion()
            Else
                Dim cod As String = cbxModeloAP.SelectedValue.ToString 'aca voy a guardar los valores del valueMember del combo Pais (VAL para convertirlo a numero previo al string)

                With Cmd
                    .CommandType = CommandType.Text
                    .CommandText = "Select PRECIO,ID From VEHICULOS  where MODELO = '" & cod & "'"
                    .Connection = conn.AbrirConexion
                End With
                Da.SelectCommand = Cmd
                Dt6 = New DataTable 'aca recogere todos los valores
                Da.Fill(Dt6) 'Relleno dentro de la tabla creada anteriormente
                drd = Cmd.ExecuteReader
                If drd.Read() Then
                    txtPrecioAP.Text = drd.Item("PRECIO")
                    IDVEHICULO = drd.Item("ID")
                End If
                With Cmd
                    .CommandType = CommandType.Text
                    .CommandText = "Select CANTIDAD_CUOTAS,IMPORTE_CUOTAS,ID From TIPO_PLAN  where ID_VEHICULOS= '" & IDVEHICULO & "'"
                    .Connection = conn.AbrirConexion
                End With
                Da.SelectCommand = Cmd
                Dt7 = New DataTable
                Da.Fill(Dt7) 'Relleno dentro de la tabla creada anteriormente
                drd = Cmd.ExecuteReader
                With cbxCantCuotasPlanAP 'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
                    .DataSource = Dt7
                    .DisplayMember = "CANTIDAD_CUOTAS" 'establece la propiedad que se va a mostrar en el control
                    .ValueMember = "ID" 'id
                End With
                drd = Cmd.ExecuteReader
                If drd.Read() Then
                    txtImporteCtaAP.Text = drd.Item("IMPORTE_CUOTAS")
                    IDPLAN = drd.Item("ID")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxVendedorAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxVendedorAP.KeyPress
        e.Handled = True  'Bloqueo para que no acepte que se escriba nada.
    End Sub

    Private Sub cbxClienteAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxClienteAP.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxMarcaAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMarcaAP.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxModeloAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxModeloAP.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCantCuotasPlanAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCantCuotasPlanAP.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCantCuotasPlanAP_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxCantCuotasPlanAP.SelectedValueChanged
        Try
            If String.IsNullOrEmpty(cbxCantCuotasPlanAP.SelectedValue) Then  'Porque al inicializarse no tiene valores
                ' cerrarConexion()
            Else
                Dim cod As String = cbxCantCuotasPlanAP.SelectedValue.ToString 'aca voy a guardar los valores del valueMember del combo Pais (VAL para convertirlo a numero previo al string)

                With Cmd
                    .CommandType = CommandType.Text
                    .CommandText = "Select IMPORTE_CUOTAS,DESCRIPCION_PLAN,ID From TIPO_PLAN  where ID= '" & cod & "'"
                    .Connection = conn.AbrirConexion
                End With
                Da.SelectCommand = Cmd
                Dt8 = New DataTable 'aca recogere todos los valores
                Da.Fill(Dt8) 'Relleno dentro de la tabla creada anteriormente
                drd = Cmd.ExecuteReader
                If drd.Read() Then
                    txtImporteCtaAP.Text = drd.Item("IMPORTE_CUOTAS")
                    txtDescripcionAP.Text = drd.Item("DESCRIPCION_PLAN")
                    IDPLAN = drd.Item("ID")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargo_Combo_Vendedor()
        Cargo_Combo_Cliente()
        Cargo_Combo_Vehiculos_Marca()
        Cargo_Combo_TipoPlan()
        '     Cargo_Combo_Cuotas()
    End Sub

    Private Sub cbxModeloAP_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Public Sub Cargo_Combo_Vendedor()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select RTRIM(APELLIDO)+' '+RTRIM(NOMBRE) AS APE_NOM,LEGAJO From EMPLEADOS order by APELLIDO asc"
            .Connection = conn.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt1 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt1) 'Relleno dentro de la tabla creada anteriormente
        With cbxVendedorAP  'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt1
            .DisplayMember = "APE_NOM" '& " NOMBRE" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "LEGAJO" 'establece el valor real de los elementos (seria el id de la tabla para relacionarlo con otra), los valores internos

        End With

    End Sub

    Public Sub Cargo_Combo_Cliente()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select RTRIM(APELLIDO)+' '+RTRIM(NOMBRE) AS APE_NOM,ID From CLIENTE order by APELLIDO asc"
            .Connection = conn.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt2 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt2) 'Relleno dentro de la tabla creada anteriormente
        With cbxClienteAP  'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt2
            .DisplayMember = "APE_NOM" '& " NOMBRE" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "ID" 'establece el valor real de los elementos (seria el id de la tabla para relacionarlo con otra), los valores internos

        End With
        'Cargo Paises en Tutores
        '  Cn.Close()
        '     cerrarConexion()
    End Sub

    ''hacer
    Public Sub Cargo_Combo_TipoPlan()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select RTRIM(APELLIDO)+' '+RTRIM(NOMBRE) AS APE_NOM,ID From CLIENTE order by APELLIDO asc"
            .Connection = conn.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt2 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt2) 'Relleno dentro de la tabla creada anteriormente
        With cbxClienteAP  'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt2
            .DisplayMember = "APE_NOM" '& " NOMBRE" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "ID" 'establece el valor real de los elementos (seria el id de la tabla para relacionarlo con otra), los valores internos

        End With
        'Cargo Paises en Tutores
        '  Cn.Close()
        '     cerrarConexion()
    End Sub

    ''hacer2

    Public Sub Cargo_Combo_Vehiculos_Marca()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select distinct MARCA From VEHICULOS order by MARCA asc"
            .Connection = conn.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt4 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt4) 'Relleno dentro de la tabla creada anteriormente
        With cbxMarcaAP  'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt4
            .DisplayMember = "MARCA" '& " NOMBRE" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "MARCA" 'establece el valor real de los elementos (seria el id de la tabla para relacionarlo con otra), los valores internos
        End With

        ' 

    End Sub

    Public Sub Cargo_Combo_Cuotas()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select RTRIM(APELLIDO)+' '+RTRIM(NOMBRE) AS APE_NOM,LEGAJO From TIPO_PLAN order by APELLIDO asc"
            .Connection = conn.AbrirConexion 'Abro la conexion
        End With
        Da.SelectCommand = Cmd
        Dt1 = New DataTable 'aca recogere todos los valores
        Da.Fill(Dt1) 'Relleno dentro de la tabla creada anteriormente
        With cbxVendedorAP  'Recorro y lleno el cbxPaisP con los nombres de la tabla paises
            .DataSource = Dt1
            .DisplayMember = "APE_NOM" '& " NOMBRE" 'establece la propiedad que se va a mostrar en el control
            .ValueMember = "LEGAJO" 'establece el valor real de los elementos (seria el id de la tabla para relacionarlo con otra), los valores internos

        End With
    End Sub
End Class
