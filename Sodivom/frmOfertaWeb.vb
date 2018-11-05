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

        txtPreIni1.Text = precio

    End Sub

    Private Sub ComboProd2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd2.SelectedIndexChanged

        Dim conjunto As String = ComboProd2.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        txtPreIni2.Text = precio

    End Sub

    Private Sub ComboProd3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd3.SelectedIndexChanged

        Dim conjunto As String = ComboProd3.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        txtPreIni3.Text = precio

    End Sub

    Private Sub ComboProd4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProd4.SelectedIndexChanged

        Dim conjunto As String = ComboProd4.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        txtPreIni4.Text = precio

    End Sub

    Private Sub ComboProd5_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboProd5.SelectedValueChanged

        Dim conjunto As String = ComboProd5.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim precio As Integer = GetPrecioProd(nombre, desc)

        txtPreIni5.Text = precio

    End Sub

    Private Function GetCodProd(nombre As String, desc As String) As Integer
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.nombre = nombre And p.descripcion = desc)
        Return selectedValue.codigo
    End Function

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

        Select Case MsgBox("Desea actualizar las ofertas web ?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
            Case MsgBoxResult.Yes
                Dim listofe As New List(Of clsEOfertaWeb)
                Dim oferta As New clsEOfertaWeb
                '///////////Prod1
                Dim conjunto As String = ComboProd1.Text
                Dim palabras As String() = conjunto.Split(New Char() {" "c})
                Dim nombre As String = palabras.GetValue(0).ToString
                Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
                desc = desc.Replace(")", "")
                oferta = crearOfe(GetCodProd(nombre, desc), txtPreOfe1.Text)
                listofe.Add(oferta)
                '///////////Prod2
                conjunto = ComboProd2.Text
                palabras = conjunto.Split(New Char() {" "c})
                nombre = palabras.GetValue(0).ToString
                desc = palabras.GetValue(1).ToString.Replace("(", "")
                desc = desc.Replace(")", "")
                oferta = crearOfe(GetCodProd(nombre, desc), txtPreOfe2.Text)
                listofe.Add(oferta)
                '///////////Prod3
                conjunto = ComboProd3.Text
                palabras = conjunto.Split(New Char() {" "c})
                nombre = palabras.GetValue(0).ToString
                desc = palabras.GetValue(1).ToString.Replace("(", "")
                desc = desc.Replace(")", "")
                oferta = crearOfe(GetCodProd(nombre, desc), txtPreOfe3.Text)
                listofe.Add(oferta)
                '///////////Prod4
                conjunto = ComboProd4.Text
                palabras = conjunto.Split(New Char() {" "c})
                nombre = palabras.GetValue(0).ToString
                desc = palabras.GetValue(1).ToString.Replace("(", "")
                desc = desc.Replace(")", "")
                oferta = crearOfe(GetCodProd(nombre, desc), txtPreOfe4.Text)
                listofe.Add(oferta)
                '///////////Prod5
                conjunto = ComboProd5.Text
                palabras = conjunto.Split(New Char() {" "c})
                nombre = palabras.GetValue(0).ToString
                desc = palabras.GetValue(1).ToString.Replace("(", "")
                desc = desc.Replace(")", "")
                oferta = crearOfe(GetCodProd(nombre, desc), txtPreOfe5.Text)
                listofe.Add(oferta)





                Dim unaC As New clsControladora
                If unaC.ModificarOfertaWeb(listofe) Then
                    MsgBox("Oferta Web actualizada correctamente")
                Else
                    MsgBox("Ocurrio un error al actualizar la oferta web")
                End If
                'Case MsgBoxResult.No
                '    MessageBox.Show("NO button")
        End Select


    End Sub

    Private Function crearOfe(prod As Integer, preofe As Integer) As clsEOfertaWeb
        Dim ofe As New clsEOfertaWeb
        ofe.Proucto = prod
        ofe.PrecioOferta = preofe

        Return ofe

    End Function

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