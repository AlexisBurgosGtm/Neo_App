Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class modelProyectos

    Sub New(ByVal _codProyecto As Integer, Optional drw As DataRow = Nothing)
        CodProyecto = _codProyecto


    End Sub


    'tabla = ctrcal_Proyectos

    Dim CodProyecto As Integer
    Dim drw As DataRow

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




End Class
