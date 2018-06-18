Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraSplashScreen

Public Class index
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.UserSkins.BonusSkins.Register()
        Me.Skins.Initialize()
    End Sub

    Dim objGeneral
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenManager.ShowForm(Me, IntroSplash.GetType, True, True, ParentFormState.Locked)

        objGeneral = New view_login
        Me.Controls.Add(objGeneral)

        'carga la interfaz
        Call CargarInterfaz(False)

        SplashScreenManager.CloseForm()
    End Sub

    'carga la interfaz inicial
    Public Sub CargarInterfaz(ByVal Activar As Boolean)

        If Activar = True Then

            Me.Controls.Remove(objGeneral)
            objGeneral = Nothing

            'carga el listado de proyectos
            Call fcn_MostrarVista(New view_list_proyectos, Me, "Proyectos").Show()
            'muestra el acordeon
            Me.Menu_Acordion.Visible = True

        Else
            'muestra el acordeon
            Me.Menu_Acordion.Visible = False
        End If

    End Sub



    'carga una vista como operación mdi para gestionar más de una
    'tarea a la vez
    Public Sub LoadLocalOperation(ByVal view As Object, ByVal Titulo As String)
        Dim frm As New Form
        frm.MdiParent = Me
        frm.Text = Titulo
        frm.Size = Parent.Size
        frm.Controls.Add(view)
        frm.Show()
    End Sub



#Region " ** MENU PRINCIPAL ** "

    Private Sub btnInicioProyectosCurso_Click(sender As Object, e As EventArgs) Handles btnInicioProyectosCurso.Click
        Call fcn_MostrarVista(New view_list_proyectos, Me, "Proyectos").Show()
    End Sub

    Private Sub btnInicioCronActividades_Click(sender As Object, e As EventArgs) Handles btnInicioCronActividades.Click
        Call fcn_MostrarVista(New view_cron_actividades, Me, "Actividades Predeterminadas").Show()
    End Sub
    Private Sub btnInicioDashboard_Click(sender As Object, e As EventArgs) Handles btnInicioDashboard.Click


    End Sub


#End Region

#Region " ** SKINS ** "
    Private Sub btnSkin_Caramel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkin_Caramel.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Caramel"
    End Sub
    Private Sub btnSkin_Foggy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkin_Foggy.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Foggy"
    End Sub
    Private Sub btnSkin_Black_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkin_Black.ItemClick
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Black"
    End Sub


#End Region


End Class