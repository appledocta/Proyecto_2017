Public Class frmCliente

    Private dt As New DataTable

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrar()


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New clientes
            dt = func.mostrar
            dataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                lkNoexiste.Visible = False

            Else

                dataListado.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListado.ColumnHeadersVisible = False
                lkNoexiste.Visible = True


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btnNuevo.Visible = True
        btnEditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbTipo.Text & "like'% " & txtBuscar.Text & "%"



            If dv.Count <> 0 Then
                lkNoexiste.Visible = False
                dataListado.DataSource = dv
                ocultar_columnas()

            End If

            lkNoexiste.Visible = True
            dataListado.DataSource = Nothing
            
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dataListado.Columns(1).Visible = False

    End Sub
End Class