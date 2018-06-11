Public Class view_new_proyecto


    Sub New(ByVal _Tipo As String, Optional _Descripcion As String = "", Optional _Direccion As String = "", Optional _FInicial As Date = Nothing, Optional _FFinal As Date = Nothing)


        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Tipo = _Tipo
        Descripcion = _Descripcion
        Direccion = _Direccion
        FInicial = FInicial
        FFinal = _FFinal
    End Sub

    Dim Tipo, Descripcion, Direccion As String
    Dim objProyectos As New modelProyectos

    Private Sub btnAceptarFake_Click(sender As Object, e As EventArgs) Handles btnAceptarFake.Click
        If Me.txtDescripcion.Text <> "" Then
            If Me.txtDireccion.Text <> "" Then
                If Tipo = "NUEVO" Then
                    If objProyectos.fcn_InsertNuevoProyecto(Me.txtDescripcion.Text, Me.txtDireccion.Text, Me.txtFInicio.DateTime, Me.txtFFin.DateTime) = True Then
                        Me.btnAceptar.PerformClick()
                    Else
                        MsgBox("No se logró guardar el Proyecto, este es el error: " & GlobalErrorDesc)
                    End If
                End If



            Else
                MsgBox("Escriba la dirección del Proyecto")
            End If

        Else
            MsgBox("Llene el Campo Proyecto")
        End If
    End Sub

    Dim FInicial, FFinal As Date


    Private Sub view_new_proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtDescripcion.Text = Descripcion
        Me.txtDireccion.Text = Direccion

        If Tipo = "NUEVO" Then
            Me.txtFInicio.DateTime = Today.Date
            Me.txtFFin.DateTime = Today.Date
        End If

        If Tipo = "EDITAR" Then
            Me.txtFInicio.DateTime = FInicial
            Me.txtFFin.DateTime = FFinal
        End If



    End Sub






End Class
