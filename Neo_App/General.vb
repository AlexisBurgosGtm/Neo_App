Imports System.Net.Mail
Imports System.Speech.Synthesis
Imports DevExpress.Data
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports Microsoft.Office.Interop

Module General
    'variables globales

    Public GlobalErrorDesc As String

    Public cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\NeoApp\NeoApp.accdb")


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

    Public Function fcn_conectar() As Boolean
        Try
            If cn.State = 0 Then
                cn.Open()
            End If
            Return True
        Catch ex As Exception
            GlobalErrorDesc = ex.ToString
            Return False
        End Try
    End Function

    Public Function fcn_ConectarAccess() As Boolean
        Try
            oAccess.OpenCurrentDatabase(filepath:="C:\NeoApp\NeoApp.accdb", Exclusive:=False)
            Return True
        Catch ex As Exception
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
