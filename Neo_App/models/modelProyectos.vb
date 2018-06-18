Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class modelProyectos

    Sub New()

    End Sub


    'tabla = ctrcal_Proyectos

    Dim CodProyecto As Integer

    Public Function cmb_SubProyectos(ByVal CodigoProyecto As Integer) As DataTable

        Dim tbl As New DataTable
        With tbl.Columns
            .Add("Codigo", GetType(Integer))
            .Add("Descripcion", GetType(String))
        End With


        If Global_TipoConexion = "ACCESS" Then
            Call fcn_AbrirConexion()

            Try
                Dim cmd As New OleDbCommand("SELECT CodSubProyectos, DESCRIPCION FROM ctrcal_SubProyectos WHERE CODPROYECTO=@CODIGO", Global_Cn)
                cmd.Parameters.AddWithValue("@CODIGO", CodigoProyecto)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)
                da.Dispose()
                cmd.Dispose()

                Return tbl

            Catch ex As Exception
                Return Nothing
            End Try

        End If


        If Global_TipoConexion = "SQLSVR" Then
            Call fcn_AbrirConexion()

            Try
                Dim cmd As New SqlCommand("SELECT CodSubProyectos, DESCRIPCION FROM ctrcal_SubProyectos WHERE CODPROYECTO=@CODIGO", Global_Cn)
                cmd.Parameters.AddWithValue("@CODIGO", CodigoProyecto)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)
                da.Dispose()
                cmd.Dispose()

                Return tbl

            Catch ex As Exception
                Return Nothing
            End Try

        End If


        Global_Cn.Close()

    End Function


    Public Function double_Correlativo_ControlCalidad() As Double

        If Global_TipoConexion = "ACCESS" Then
            Call fcn_AbrirConexion()
            Try
                Dim cmd As New OleDbCommand("SELECT CORRELATIVO FROM gen_TipoDocumentos WHERE ID=1", Global_Cn)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Return Double.Parse(dr(0))
                End If
                dr.Close()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return 0
            End Try

        End If


        If Global_TipoConexion = "SQLSVR" Then
            Call fcn_AbrirConexion()
            Try
                Dim cmd As New SqlCommand("SELECT CORRELATIVO FROM gen_TipoDocumentos WHERE ID=1", Global_Cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Return Double.Parse(dr(0))
                End If
                dr.Close()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return 0
            End Try

        End If


        Global_Cn.Close()

    End Function


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

        End If


        If Global_TipoConexion = "SQLSVR" Then
            Call fcn_AbrirConexion()

            Try
                Dim tbl As New DS_Proyectos.ctrcal_ProyectosDataTable

                Dim cmd As New SqlCommand("SELECT * FROM ctrcal_Proyectos", Global_Cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(tbl)
                da.Dispose()

                Return tbl
            Catch ex As Exception
                MsgBox(ex.ToString)
                GlobalErrorDesc = ex.ToString
                Return Nothing

            End Try

        End If


        Global_Cn.Close()

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



        End If


        If Global_TipoConexion = "SQLSVR" Then

            Call fcn_AbrirConexion()

            Try

                Dim cmd As New SqlCommand("insert into ctrcal_Proyectos (DESCRIPCION,DIRECCION,FECHAINICIO,FECHAFINALIZA) values (@DESCRIPCION,@DIRECCION,@FINICIO,@FFIN)", Global_Cn)
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



        End If



        Global_Cn.Close()

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


        End If


        If Global_TipoConexion = "SQLSVR" Then

            Call fcn_AbrirConexion()

            Try

                Dim cmd As New SqlCommand("delete from ctrcal_Proyectos WHERE CodProyecto=@codigo", Global_Cn)
                cmd.Parameters.AddWithValue("@codigo", CodProyecto)
                cmd.ExecuteNonQuery()

                Return True

            Catch ex As Exception

                'MsgBox(ex.ToString)
                GlobalErrorDesc = ex.ToString
                Return False

            End Try


        End If



        Global_Cn.Close()


    End Function


End Class
