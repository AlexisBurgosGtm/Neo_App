Public Class view_operation_chequeo
    Sub New(ByVal _CodProyecto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CodProyecto = _CodProyecto
    End Sub

    Dim CodProyecto As Integer
    Private Sub view_operation_chequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub



End Class
