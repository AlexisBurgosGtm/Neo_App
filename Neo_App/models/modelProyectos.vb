Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class modelProyectos

    Sub New()

    End Sub


    'tabla = ctrcal_Proyectos

    Dim CodProyecto As Integer


    Public Function fcn_SelectProyectos() As DataTable

        If Global_TipoConexion = "ACCESS" Then
            Call fcn_AbrirConexion()

            Try
                Dim tbl As New DS_Proyectos.ctrcal_ProyectosDataTable

                Dim cmd As New OleDbCommand("SELECT * FROM ctrcal_Proyectos", Global_Cn)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)
                da.Dispose()

                Return tbl
            Catch ex As Exception
                MsgBox(ex.ToString)
                GlobalErrorDesc = ex.ToString
                Return Nothing

            End Try

            Global_Cn.Close()

        End If


    End Function


    Public Function fcn_InsertNuevoProyecto(ByVal DesProyecto As String, ByVal Direccion As String, ByVal FInicio As Date, ByVal FFinal As Date) As Boolean
        If Global_TipoConexion = "ACCESS" Then

            Call fcn_AbrirConexion()

            Try

                Dim cmd As New OleDbCommand("insert into ctrcal_Proyectos (DESCRIPCION,DIRECCION,FECHAINICIO,FECHAFINALIZA) values (@DESCRIPCION,@DIRECCION,@FINICIO,@FFIN)", Global_Cn)
                cmd.Parameters.AddWithValue("@DESCRIPCION", DesProyecto)
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion)
                cmd.Parameters.AddWithValue("@FINICIO", FInicio)
                cmd.Parameters.AddWithValue("@FFIN", FFinal)
                cmd.ExecuteNonQuery()

                Return True

            Catch ex As Exception

                'MsgBox(ex.ToString)
                GlobalErrorDesc = ex.ToString
                Return False

            End Try

            Global_Cn.Close()

        End If


    End Function

    Public Function fcn_EliminarProyecto(ByVal CodProyecto As Integer) As Boolean
        If Global_TipoConexion = "ACCESS" Then

            Call fcn_AbrirConexion()

            Try

                Dim cmd As New OleDbCommand("delete from ctrcal_Proyectos WHERE CodProyecto=@codigo", Global_Cn)
                cmd.Parameters.AddWithValue("@codigo", CodProyecto)
                cmd.ExecuteNonQuery()

                Return True

            Catch ex As Exception

                'MsgBox(ex.ToString)
                GlobalErrorDesc = ex.ToString
                Return False

            End Try

            Global_Cn.Close()

        End If


    End Function


End Class
