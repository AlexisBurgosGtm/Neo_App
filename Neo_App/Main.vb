Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports DevExpress.XtraSplashScreen
Imports System.ComponentModel
Imports DevExpress.XtraScheduler

Public Class Main




    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenManager.ShowForm(Me, IntroSplash.GetType, True, True, ParentFormState.Locked)


        Me.txtUsuario.Text = "carlos"
        Me.txtPass.Text = "123"
        'Me.NAVFRAM_INICIO.SelectedPage = np_inicio
        Call fcn_ConectarAccess()

        Me.NAVFRAM_INICIO.SelectedPage = np_inicio

        SplashScreenManager.CloseForm()
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call fcn_CerrarAccess()
    End Sub


#Region " ** LOGIN ** "
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If Me.txtUsuario.Text <> "" Then
            If Me.txtPass.Text <> "" Then

                If fcn_Login(Me.txtUsuario.Text, Me.txtPass.Text) = True Then
                    Call fcn_HablarTexto("Bienvenido " & Me.txtUsuario.Text)

                    Call fcn_ConectarAccess()

                    Me.NAVFRAM_INICIO.SelectedPage = np_inicio

                Else
                    Call fcn_Mensaje("Usuario o Contraseña incorrectos", Me)
                End If

            Else

                Call fcn_Mensaje("Escriba la contraseña", Me)
            End If
        Else
            Call fcn_Mensaje("Escriba un nombre de usuario", Me)

        End If

    End Sub

    Private Function fcn_Login(ByVal Usuario As String, ByVal Pass As String) As Boolean

        Call fcn_conectar()

        Try
            Dim cmd As New OleDbCommand("Select Usuario, Pass, Nivel from gen_usuarios where usuario=@usuario and pass=@pass", cn)
            cmd.Parameters.AddWithValue("@usuario", Usuario)
            cmd.Parameters.AddWithValue("@pass", Pass)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Return True
            End If
            dr.Close()
            cmd.Dispose()
            cn.Close()

        Catch ex As Exception
            Call EnviarGmail("Error Ing Dedet en Login", ex.ToString, "ralexmailreu@gmail.com")
            MsgBox(ex.ToString)
            GlobalErrorDesc = ex.ToString
            Return False
        End Try

    End Function

#End Region


#Region " ** INICIO ** "
    Private Sub btn_inicio_proyectos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_proyectos.ItemClick
        oAccess.DoCmd.OpenForm("Inicio_ControlCalidad")
    End Sub

    Private Sub btn_inicio_contactos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_contactos.ItemClick
        oAccess.DoCmd.OpenForm("gen_frmContactos")
    End Sub

    Private Sub btn_inicio_niveles_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_niveles.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmNiveles")
    End Sub

    Private Sub btn_inicio_areas_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_areas.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmAreas")
    End Sub

    Private Sub btn_inicio_subareas_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_subareas.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmSubAreas")
    End Sub

    Private Sub btn_inicio_procesos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_procesos.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmProcesos")
    End Sub

    Private Sub btn_inicio_etapas_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_etapas.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmEtapas")
    End Sub

    Private Sub btn_inicio_campos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_campos.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmCampos")
    End Sub

    Private Sub btn_inicio_grupostrabajo_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_grupostrabajo.ItemClick
        oAccess.DoCmd.OpenForm("ctrlcal_frmGruposTrabajo")
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.NAVFRAM_INICIO.SelectedPage = np_inicio
    End Sub
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        oAccess.DoCmd.OpenForm("gen_config")
    End Sub

    Private Sub btnConfig_Atras_Click(sender As Object, e As EventArgs)
        Me.NAVFRAM_INICIO.SelectedPage = np_inicio
    End Sub

    'CRONOGRAMA
    '***********************
    Private Sub btn_inicio_actividades_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_actividades.ItemClick
        oAccess.DoCmd.OpenForm("cron_gen_actividades")
    End Sub

    Private Sub btn_inicio_fases_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btn_inicio_fases.ItemClick
        oAccess.DoCmd.OpenForm("cron_gen_fases")
    End Sub


#End Region



#Region " ** FUNCIONES ** "

    Private Sub Hablar(ByVal texto As String)
        Dim sp As New Speech.Synthesis.SpeechSynthesizer
        sp.SpeakAsync(texto)

    End Sub




#End Region
End Class