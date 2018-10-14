Imports Entidades
Imports Persistencia
Public Class clsDVenta
    Dim unPV As New clsPVenta

    Public Function AltaVenta(fecha As Date, importe As Integer, empl As clsEEmpleado) As Boolean
        Return unPV.AltaVenta(fecha, importe, empl)
    End Function

    Public Function AltaVentaProducto(idventa As Integer, idprod As Integer, cantidad As Integer) As Boolean
        Return unPV.AltaVentaProducto(idventa, idprod, cantidad)
    End Function

    Public Function AltaVentaDeProducto(idventa As Integer, cicli As Integer) As Boolean
        Return unPV.AltaVentaDeProducto(idventa, cicli)
    End Function

    Public Function GetIdVenta(fecha As Date, ciEmpl As Integer) As Integer
        Return unPV.GetIdVenta(fecha, ciEmpl)
    End Function
End Class
