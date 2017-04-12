Imports System.Data.SqlClient
Imports CapaNegocio

Public Class CanchaDA
    Inherits ConexionDA
    Dim cmd As New SqlCommand

    '************************ FUNCION MOSTRAR Cancha*******************
    Public Function Mostrar_cancha() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select C.id_cancha, C.Habilitado 'Habilitado',C.Precio_cancha 'Precio de Cancha',C.FechaActPrecio() 'Fecha de ultima actualizacion',T.Descripcion  from Cancha as C,TipoCancha as T where C.id_cancha=T.Id_Cancha")
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

    '****************************FUNCION INSERTAR CANCHA **************************************
    Public Function Insertar_Cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@Id_cancha", dts.id_cancha)
            cmd.Parameters.AddWithValue("@Habilitado", dts.habilitado)


        Catch ex As Exception

        End Try
    End Function
End Class
