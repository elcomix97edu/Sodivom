Imports Entidades

Public Class frmStock
    Dim munempl As New clsEEmpleado

    Public Property unempl As clsEEmpleado
        Get
            Return munempl
        End Get
        Set(value As clsEEmpleado)
            munempl = value
        End Set
    End Property

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        If unempl.tipoEmpleado = 4 Then 'Es Vendedor
            btnEliminar.Enabled = False
            btnIngresar.Enabled = False
            btnModificar.Enabled = False

        End If
    End Sub
End Class