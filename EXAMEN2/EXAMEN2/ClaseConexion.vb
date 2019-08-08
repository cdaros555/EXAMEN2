Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class ClaseConexion

    Public Function AbrirConexion() As SqlConnection
        Dim con As String
        Dim scon As New SqlConnection
        'con = Settings.miCon
        'con = "Data Source=nestor\sqlexpress;Integrated Security=SSPI;Initial Catalog=Alumnos"
        'con = "Integrated Security= true; Data Source=nestor-pc\sqlexpress; Initial Catalog=Cervantes1"
        con = "Data Source=NBCORAR209;Initial Catalog=EXAMEN;Integrated Security=True"
        scon = New SqlConnection(con)
        '       scon.ConnectionString = Settings.miCon
        scon.Open()
        Return scon
    End Function

    Public Function CerrarConexion() As SqlConnection
        Dim con As String
        Dim scon As New SqlConnection
        con = "Data Source=NBCORAR209;Initial Catalog=EXAMEN;Integrated Security=True"
        scon = New SqlConnection(con)
        scon.Close()
        Return scon
    End Function

End Class


