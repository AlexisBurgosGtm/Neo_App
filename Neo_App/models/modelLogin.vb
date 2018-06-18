
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class modelLogin
    Sub New()

    End Sub


    Public Function fcn_Login(ByVal usuario As String, ByVal pass As String) As Boolean
        If Global_TipoConexion = "ACCESS" Then
            Call fcn_AbrirConexion()
            Try
                Dim cmd As New OleDbCommand("SELECT USUARIO, NIVEL FROM GEN_USUARIOS WHERE USUARIO=@usuario AND PASS=@pass", Global_Cn)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@pass", pass)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    global_usuario = dr(0).ToString
                    global_nivelusuario = Integer.Parse(dr(1))

                    Return True
                Else
                    Return False
                End If
                dr.Close()
                cmd.Dispose()

            Catch ex As Exception
                Return False
            End Try


        End If



        If Global_TipoConexion = "SQLSVR" Then
            Call fcn_AbrirConexion()
            Try
                Dim cmd As New SqlCommand("SELECT USUARIO, NIVEL FROM GEN_USUARIOS WHERE USUARIO=@usuario AND PASS=@pass", Global_Cn)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@pass", pass)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    global_usuario = dr(0).ToString
                    global_nivelusuario = Integer.Parse(dr(1))

                    Return True
                Else
                    Return False
                End If
                dr.Close()
                cmd.Dispose()

            Catch ex As Exception
                Return False
            End Try


        End If

    End Function


End Class
