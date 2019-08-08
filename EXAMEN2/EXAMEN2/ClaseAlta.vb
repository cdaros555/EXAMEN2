Public Class ClaseAlta
    Private fecha_contrato As Date
    Public Property _fecha_contrato As Date
        Get
            Return fecha_contrato 'como es un get retorno algo
        End Get
        Set(value As Date)
            fecha_contrato = value
        End Set
    End Property

    Private importe_cuotas As Integer
    Public Property _importe_cuotas As Integer
        Get
            Return importe_cuotas 'como es un get retorno algo
        End Get
        Set(value As Integer)
            importe_cuotas = value
        End Set
    End Property

    Private vendedor As String
    Public Property _vendedor As String
        Get
            Return vendedor 'como es un get retorno algo
        End Get
        Set(value As String)
            vendedor = value
        End Set
    End Property

    Private cliente As Integer
    Public Property _cliente As Integer
        Get
            Return cliente 'como es un get retorno algo
        End Get
        Set(value As Integer)
            cliente = value
        End Set
    End Property

    Private id_tipo_plan As Integer
    Public Property _id_tipo_plan As Integer
        Get
            Return id_tipo_plan 'como es un get retorno algo
        End Get
        Set(value As Integer)
            id_tipo_plan = value
        End Set
    End Property
End Class
