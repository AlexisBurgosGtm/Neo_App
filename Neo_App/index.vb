Public Class index
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.UserSkins.BonusSkins.Register()

        Me.Skins.Initialize()
    End Sub
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_Proyectos_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles btn_Proyectos.ElementClick

        fcn_MostrarVista(New view_list_proyectos, Me, "Proyectos").Show()

    End Sub

End Class