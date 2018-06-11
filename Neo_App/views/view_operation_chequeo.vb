Public Class view_operation_chequeo
    Sub New(ByVal _CodProyecto As Integer, ByVal _DesProyecto As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CodProyecto = _CodProyecto
        DesProyecto = _DesProyecto
    End Sub

    Dim CodProyecto As Integer
    Dim DesProyecto As String

    Dim objProyectos As New modelProyectos
    Private Sub view_operation_chequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lbTitulo.Text = DesProyecto

        Me.txtFecha.DateTime = Today.Date

        Me.lbCorrelativo.Text = objProyectos.double_Correlativo_ControlCalidad()


    End Sub



End Class
