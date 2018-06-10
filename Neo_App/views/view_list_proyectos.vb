Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Customization

Public Class view_list_proyectos
    Dim objProyectos As New modelProyectos()
    Private Sub view_list_proyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CargarGrid()
    End Sub

    'RECARGA EL GRID
    Private Sub CargarGrid()
        Me.GridProyectos.DataSource = Nothing
        Me.GridProyectos.DataSource = objProyectos.fcn_SelectProyectos()

    End Sub

    'cargar tres o dos columnas en el tile view cuando den clic al spliter
    Private Sub SplitContainerControl1_SplitGroupPanelCollapsed(sender As Object, e As DevExpress.XtraEditors.SplitGroupPanelCollapsedEventArgs) Handles SplitContainerControl1.SplitGroupPanelCollapsed
        If Me.TileViewProyectos.OptionsTiles.ColumnCount = 3 Then
            Me.TileViewProyectos.OptionsTiles.ColumnCount = 2
        Else
            Me.TileViewProyectos.OptionsTiles.ColumnCount = 3
        End If
    End Sub

    'BOTÓN NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If FlyoutDialog.Show(Me.ParentForm, New view_new_proyecto("NUEVO")) = DialogResult.OK Then
            MsgBox("Proyecto Creado Exitosamente")
            Call CargarGrid()
        End If
    End Sub

    'OPCIONES DEL PANEL DE EDICIÓN
    Private Sub WindowsUIButtonPanelEdicion_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanelEdicion.ButtonClick
        Try

            Dim tag As String = CType(e.Button, WindowsUIButton).Tag.ToString()
            Select Case tag
                Case "EDITAR"

                Case "RESUMEN"

                Case "ELIMINAR"
                    If fcn_Confirmacion("¿Está seguro que desea eliminar este Proyecto?", Me.ParentForm) = True Then
                        If objProyectos.fcn_EliminarProyecto(CType(drw.Item(0), Integer)) = True Then
                            Call fcn_Mensaje("Proyecto eliminado exitosamente", Me.ParentForm)
                            Call CargarGrid()
                        End If
                    End If
            End Select

        Catch ex As Exception

        End Try
    End Sub


    Dim drw As DataRow
    Private Sub TileViewProyectos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles TileViewProyectos.FocusedRowChanged
        drw = Nothing
        drw = Me.TileViewProyectos.GetFocusedDataRow


        Try
            global_CodProyecto = CType(drw.Item(0), Integer)
            global_DesProyecto = drw.Item(2).ToString

            'agrega los títulos
            Me.lbChequeProyecto.Text = global_DesProyecto
            Me.lbCronogramaProyecto.Text = global_DesProyecto
            Me.lbPresupuestoProyecto.Text = global_DesProyecto


            Me.lbDesProyecto.Text = drw.Item(2).ToString

            Me.bar_cronReal.Position = Double.Parse(drw.Item(14))
            Me.bar_cronReal.Text = Double.Parse(drw.Item(14)).ToString

            Me.bar_presReal.Position = Double.Parse(drw.Item(15))
            Me.bar_presReal.Text = Double.Parse(drw.Item(15)).ToString
        Catch ex As Exception

        End Try
    End Sub

    'PANEL DE LAS OPCIONES DEL PROYECTO
    Private Sub WindowsUIButtonPanelOpciones_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanelOpciones.ButtonClick
        Try


            Dim tag As String = CType(e.Button, WindowsUIButton).Tag.ToString()
            Select Case tag

                Case "CHEQUEO"

                    Me.NavFrameProyectos.SelectedPage = NP_Chequeo

                Case "PRESUPUESTO"
                    Me.NavFrameProyectos.SelectedPage = NP_Presupuesto
                Case "CRONOGRAMA"
                    Me.NavFrameProyectos.SelectedPage = Np_Cronograma
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.NavFrameProyectos.SelectedPage = NP_Listado
    End Sub

    Private Sub btnCronogramaAtras_Click(sender As Object, e As EventArgs) Handles btnCronogramaAtras.Click
        Me.NavFrameProyectos.SelectedPage = NP_Listado
    End Sub

    Private Sub btnPresupuestAtras_Click(sender As Object, e As EventArgs) Handles btnPresupuestAtras.Click
        Me.NavFrameProyectos.SelectedPage = NP_Listado
    End Sub
End Class
