Public Class Clientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientesDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_Insetar.Click
        Me.ClientesTableAdapter.INSERTAR(IdclienteTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, CorreoTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text)
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bt_modificar.Click
        Me.ClientesTableAdapter.EDITAR(IdclienteTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, CorreoTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text, IdclienteTextBox.Text)
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Bt_Nuevo.Click
        Me.Validate()
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Bt_Guardar.Click
        Try
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ClientesDataSet)
            Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)
        Catch ex As Exception
            MsgBox("Todos los campos deben ser llenados", vbInformation, "Campos nulos")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bt_borrar.Click
        Me.ClientesTableAdapter.BORRAR(IdclienteTextBox.Text)
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Bt_buscar.Click
        Me.ClientesTableAdapter.FillBy(Me.ClientesDataSet.clientes, IdclienteTextBox.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Bt_Actualizar.Click
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.clientes)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub
End Class