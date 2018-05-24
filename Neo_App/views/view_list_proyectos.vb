Public Class view_list_proyectos
    Dim objProyectos As New modelProyectos(0)
    Private Sub view_list_proyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.GridProyectos.DataSource = objProyectos.fcn_SelectProyectos()

    End Sub


End Class
