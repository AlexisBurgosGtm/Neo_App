Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Speech.Synthesis
Imports DevExpress.Data
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports Microsoft.Office.Interop

Module General
    'variables globales

    'variables de proyectos
    Public global_CodProyecto As Integer
    Public global_DesProyecto As String

    Public global_usuario As String
    Public global_nivelusuario As Integer


    Public Global_TipoConexion As String = "SQLSVR"
    'SQLSVR
    'MYSQL
    'MONGO
    'ACCESS

    Public Global_Cn 'objeto global para la conexión

    Public GlobalErrorDesc As String

    ' Public cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\access\NeoApp.accdb")


    Public oAccess As New Access.Application

    Public Function fcn_HablarTexto(ByVal texto As String) As Boolean
        Try
            Dim Hablar As New SpeechSynthesizer
            Hablar.SpeakAsync(texto)
            ' Hablar.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function


    Public Function fcn_MostrarVista(ByVal vista As Object, ByVal parent As Form, ByVal Titulo As String) As Form
        Dim frm As New Form
        frm.MdiParent = parent
        frm.Text = Titulo
        frm.Size = parent.Size
        frm.Controls.Add(vista)
        Return frm

    End Function

    Public Function fcn_AbrirConexion() As Boolean

        Try
            If Global_TipoConexion = "ACCESS" Then
                Global_Cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\access\NeoApp.accdb")

                If Global_Cn.state = 0 Then
                    Global_Cn.Open()
                End If
            End If

            If Global_TipoConexion = "SQLSVR" Then
                'Global_Cn = New SqlConnection("Data Source=SERVERALEXIS\SQLEXPRESS;Initial Catalog=NEOAPP;User ID=iEx;Password=iEx;MultipleActiveResultSets=True")
                Global_Cn = New SqlConnection("Data Source=sql5004.site4now.net;Initial Catalog=DB_A3D4D3_neoapp;User ID=DB_A3D4D3_neoapp_admin;Password=razors1805;MultipleActiveResultSets=True")
                If Global_Cn.state = 0 Then
                    Global_Cn.Open()
                End If
            End If

            Return True

        Catch ex As Exception

            GlobalErrorDesc = ex.ToString
            Return False
        End Try


    End Function

    Public Function fcn_ConectarAccess() As Boolean
        Try
            oAccess.OpenCurrentDatabase(filepath:=Application.StartupPath & "\access\NeoApp.accdb", Exclusive:=False)
            Return True
        Catch ex As Exception
            Call EnviarGmail("Error Ing Dedet al cargar Access OBJ", ex.ToString, "ralexmailreu@gmail.com")
            MsgBox(ex.ToString)
            GlobalErrorDesc = ex.ToString
            Return False
        End Try

    End Function


    Public Function fcn_CerrarAccess() As Boolean
        Try
            oAccess.CloseCurrentDatabase()
            Return True
        Catch ex As Exception
            GlobalErrorDesc = ex.ToString
            Return False
        End Try
    End Function


    Public Function fcn_Mensaje(ByVal texto As String, owner As Form) As Boolean
        Try
            Dim action As New FlyoutAction()
            action.Caption = "Importante"
            action.Description = texto
            action.Commands.Add(FlyoutCommand.OK)

            FlyoutDialog.Show(owner, action)
            Return True
        Catch ex As Exception
            GlobalErrorDesc = ex.ToString
            Return False
        End Try

    End Function

    Public Function fcn_Confirmacion(ByVal texto As String, owner As Form) As Boolean
        Try
            Dim action As New FlyoutAction()
            action.Caption = "Confirme"
            action.Description = texto
            action.Commands.Add(FlyoutCommand.OK)
            action.Commands.Add(FlyoutCommand.Cancel)
            If FlyoutDialog.Show(owner, action) = DialogResult.OK Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            GlobalErrorDesc = ex.ToString
            Return False
        End Try

    End Function



    Public Sub EnviarGmail(ByVal Subject As String, ByVal Body As String, ByVal Destino As String)
        GmailEmisor = "sistemaarespos@gmail.com"
        GmailEmisorPass = "razors1805"
        Try

            Dim MMessage As System.Net.Mail.MailMessage = New MailMessage
            MMessage.To.Add(Destino)
            MMessage.From = New MailAddress(GmailEmisor, GmailEmisor, System.Text.Encoding.UTF8)
            MMessage.Subject = Subject
            MMessage.SubjectEncoding = System.Text.Encoding.UTF8
            MMessage.Body = Body
            MMessage.BodyEncoding = System.Text.Encoding.UTF8
            MMessage.IsBodyHtml = False

            Dim sClient As New SmtpClient()
            sClient.Credentials = New System.Net.NetworkCredential(GmailEmisor, GmailEmisorPass)
            sClient.Host = "smtp.gmail.com"
            sClient.Port = 587

            sClient.EnableSsl = True


            sClient.Send(MMessage)
        Catch ex As System.Net.Mail.SmtpException
            '   MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub EnviarGmailAdjunto(ByVal Subject As String, ByVal Body As String, ByVal Destino As String, ByVal RutaAdjunto As String)

        GmailEmisor = "sistemaarespos@gmail.com"
        GmailEmisorPass = "razors1805"

        Try

            Dim MMessage As System.Net.Mail.MailMessage = New MailMessage
            MMessage.To.Add(Destino)
            MMessage.From = New MailAddress(GmailEmisor, GmailEmisor, System.Text.Encoding.UTF8)
            MMessage.Subject = Subject
            MMessage.SubjectEncoding = System.Text.Encoding.UTF8
            MMessage.Body = Body
            MMessage.BodyEncoding = System.Text.Encoding.UTF8
            MMessage.IsBodyHtml = False
            Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(RutaAdjunto)
            MMessage.Attachments.Add(archivo)

            Dim sClient As New SmtpClient()
            sClient.Credentials = New System.Net.NetworkCredential(GmailEmisor, GmailEmisorPass)
            sClient.Host = "smtp.gmail.com"
            sClient.Port = 587

            sClient.EnableSsl = True


            sClient.Send(MMessage)
        Catch ex As System.Net.Mail.SmtpException
            '   MsgBox(ex.ToString)
        End Try

    End Sub
    'variables globales para correo y pass del gmail
    Public GmailEmisor As String
    Public GmailEmisorPass As String

End Module
