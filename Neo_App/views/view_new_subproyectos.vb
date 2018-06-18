Public Class view_new_subproyectos

    Sub New(ByVal _CodProyecto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CodProyecto = _CodProyecto
    End Sub

    Dim CodProyecto As Integer

    Dim objSubProyectos As New modelSubProyectos

    Private Sub view_new_subproyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbTitulo.Text = global_DesProyecto

        Call CargarGrid()

    End Sub

    Private Sub CargarGrid()
        Me.GridSubProyectos.DataSource = Nothing

        Me.GridSubProyectos.DataSource = objSubProyectos.select_SubProyectos(CodProyecto)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.txtCodigo.Text <> "" Then
            'si está editando



        Else
            'si está guardando
            If Me.txtDescripcion.Text <> "" Then
                If Me.txtDireccion.Text <> "" Then
                Else
                    Me.txtDireccion.Text = "Ciudad"
                End If

                If objSubProyectos.insert_SubProyecto(Me.txtDescripcion.Text, Me.txtDireccion.Text, CodProyecto) = True Then

                    Call BorrarDatos()

                    MsgBox("Se ha creado un Nuevo SubProyecto Asociado")

                    Call CargarGrid()

                Else
                    MsgBox("No pude guardar los datos, solicite ayuda a Soporte Técnico")
                End If

            Else
                Call fcn_Mensaje("Escriba una Descripción para el Nuevo Sub Proyecto", Me.ParentForm)
            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call BorrarDatos()
    End Sub

    Private Sub BorrarDatos()
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtDireccion.Text = ""
    End Sub

    Private Sub TileViewSubProyectos_DoubleClick(sender As Object, e As EventArgs) Handles TileViewSubProyectos.DoubleClick

    End Sub
End Class
