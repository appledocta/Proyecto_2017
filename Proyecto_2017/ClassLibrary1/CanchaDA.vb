Imports System.Data.SqlClient
Imports CapaNE

Public Class CanchaDA
    Inherits Conexion
    Dim cmd As New SqlCommand

    '************************ FUNCION MOSTRAR Cancha*******************
    Public Function Mostrar_cancha() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select id_cancha, Habilitado 'Habilitado',Precio_cancha 'Precio de Cancha',FechaActPrecio 'Fecha de ultima actualizacion'  from Cancha order by Id_cancha desc")
            cmd.CommandType = CommandType.Text

            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) ''adaptador con bd
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function
End Class
