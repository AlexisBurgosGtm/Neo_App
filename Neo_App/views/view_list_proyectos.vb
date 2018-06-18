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
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
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


            Me.lbDesProyecto.Text = drw.Item(2).ToString

            Me.bar_cronReal.Position = Double.Parse(drw.Item(14))
            Me.bar_cronReal.Text = Double.Parse(drw.Item(14)).ToString

            Me.bar_presReal.Position = Double.Parse(drw.Item(15))
            Me.bar_presReal.Text = Double.Parse(drw.Item(15)).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Function fcn_MostrarVistaLocal(ByVal view As Object, ByVal parent As Form, ByVal Titulo As String) As Boolean
        Dim frm As New Form
        frm.Size = view.size
        frm.Controls.Add(view)
        frm.Text = Titulo
        frm.MdiParent = parent
        frm.Show()
    End Function


    'PANEL DE LAS OPCIONES DEL PROYECTO
    Private Sub WindowsUIButtonPanelOpciones_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanelOpciones.ButtonClick
        Try

            Dim tag As String = CType(e.Button, WindowsUIButton).Tag.ToString()
            Select Case tag
                Case "SUBPROYECTOS"
                    Call fcn_MostrarVistaLocal(New view_new_subproyectos(global_CodProyecto), index, "SubProyectos")
                Case "CHEQUEO"
                    Call fcn_MostrarVistaLocal(New view_operation_chequeo(global_CodProyecto, global_DesProyecto), index, "Control de Calidad")
                'Me.NavFrameProyectos.SelectedPage = NP_Chequeo

                Case "PRESUPUESTO"


                Case "CRONOGRAMA"


            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Try

            Dim tag As String = CType(e.Button, WindowsUIButton).Tag.ToString()
            Select Case tag

                Case "NUEVO"
                    If FlyoutDialog.Show(Me.ParentForm, New view_new_proyecto("NUEVO")) = DialogResult.OK Then
                        MsgBox("Proyecto Creado Exitosamente")
                        Call CargarGrid()
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



End Class
