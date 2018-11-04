Imports Entidades
Imports Dominio
Public Class frmOfertaWeb
    Dim listaProd As New List(Of clsEProducto)
    Dim unacon As New clsControladora

    Private Function GetPrecioProd(nom As String, desc As String) As Integer
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.nombre = nom And p.descripcion = desc)
        Return selectedValue.precio
    End Function 'donde tenes la lista de errores forro se fue
    Private Sub frmOfertaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaProd = unacon.ListarProducto("", 1)
        For Each Prod In listaProd
            ComboProd1.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
            ComboProd2.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
            ComboProd3.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
            ComboProd4.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
            ComboProd5.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")

        Next
    End Sub
    Private Sub ComboProd1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd1.SelectedIndexChanged

        Dim conjunto As String = ComboProd1.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        TextBox2.Text = precio

    End Sub

    Private Sub ComboProd2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd2.SelectedIndexChanged

        Dim conjunto As String = ComboProd2.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        TextBox5.Text = precio

    End Sub

    Private Sub ComboProd3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd3.SelectedIndexChanged

        Dim conjunto As String = ComboProd3.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        TextBox8.Text = precio

    End Sub

    Private Sub ComboProd4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd4.SelectedIndexChanged

        Dim conjunto As String = ComboProd4.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        TextBox11.Text = precio

    End Sub

    Private Sub ComboProd5_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboProd5.SelectedValueChanged

        Dim conjunto As String = ComboProd5.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        TextBox14.Text = precio

    End Sub

    ' Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
    'Select Case MsgBox("Desea actualizar el producto " & txtNombre.Text & " " & txtDescripcion.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
    'Case MsgBoxResult.Yes
    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
    'Dim unprod As New clsEProducto 'Crea el empleado
    '           unprod.codigo = txtCodigo.Text 'Carga los datos del empleado
    '          unprod.nombre = txtNombre.Text
    '         unprod.descripcion = txtDescripcion.Text
    '        unprod.precio = txtPrecio.Text
    '      unprod.minstock = txtMinStock.Text


    'Dim unaC As New clsControladora
    'If unaC.ModificarProducto(unprod) Then
    '               MsgBox("Producto actualizado correctamente")
    '              Listar()
    'Else
    '               MsgBox("Ocurrio un error al actualizar el producto")
    'End If
    'Case MsgBoxResult.No
    '    MessageBox.Show("NO button")
    'End Select

    'End Sub
    'End Sub
End Class