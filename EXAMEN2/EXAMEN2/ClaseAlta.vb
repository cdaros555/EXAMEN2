Public Class ClaseAlta
    Private Cantidad_cuotas As Integer
    Public Property _Cantidad_cuotas As Integer
        Get
            Return Cantidad_cuotas 'como es un get retorno algo
        End Get
        Set(value As Integer)
            Cantidad_cuotas = value
        End Set
    End Property

    Private Importe_cuotas As Integer
    Public Property _Importe_cuotas As Integer
        Get
            Return Importe_cuotas 'como es un get retorno algo
        End Get
        Set(value As Integer)
            Importe_cuotas = value
        End Set
    End Property

    Private Descripcion_Plan As String
    Public Property _Descripcion_Plan As String
        Get
            Return Descripcion_Plan 'como es un get retorno algo
        End Get
        Set(value As String)
            Descripcion_Plan = value
        End Set
    End Property

    Private Marca As String
    Public Property _Marca As String
        Get
            Return Marca 'como es un get retorno algo
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property
End Class
