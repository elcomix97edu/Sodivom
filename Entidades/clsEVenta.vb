Imports Entidades

Public Class clsEVenta
    Dim eCajero As String
    Dim efecha As String
    Dim ecliente As String
    Dim etotal As String
    Dim elistpord As List(Of clsEStock)
    Dim edir As String


    Public Property Cajero As String
        Get
            Return eCajero
        End Get
        Set(value As String)
            eCajero = value
        End Set
    End Property

    Public Property fecha As String
        Get
            Return efecha
        End Get
        Set(value As String)
            efecha = value
        End Set
    End Property

    Public Property cliente As String
        Get
            Return ecliente
        End Get
        Set(value As String)
            ecliente = value
        End Set
    End Property

    Public Property total As String
        Get
            Return etotal
        End Get
        Set(value As String)
            etotal = value
        End Set
    End Property

    Public Property listprod As List(Of clsEStock)
        Get
            Return elistpord
        End Get
        Set(value As List(Of clsEStock))
            elistpord = value
        End Set
    End Property

    Public Property dir As String
        Get
            Return edir
        End Get
        Set(value As String)
            edir = value
        End Set
    End Property
End Class

