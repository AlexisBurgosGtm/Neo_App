<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_operation_chequeo
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_operation_chequeo))
        Me.TblTempChequeoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Proyectos = New Neo_App.DS_Proyectos()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbSubArea = New System.Windows.Forms.ComboBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbSubProyecto = New System.Windows.Forms.ComboBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.cmbContratista = New System.Windows.Forms.ComboBox()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.cmbApartamento = New System.Windows.Forms.ComboBox()
        Me.gridChequeo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDESPROCESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESETAPA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCAMPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCALIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lbCorrelativo = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.lbTitulo = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TblTempChequeoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.gridChequeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblTempChequeoBindingSource
        '
        Me.TblTempChequeoBindingSource.DataMember = "tblTempChequeo"
        Me.TblTempChequeoBindingSource.DataSource = Me.DS_Proyectos
        '
        'DS_Proyectos
        '
        Me.DS_Proyectos.DataSetName = "DS_Proyectos"
        Me.DS_Proyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(862, 180)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(136, 57)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Guardar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(862, 276)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(136, 57)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Cancelar"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl2.Location = New System.Drawing.Point(4, 101)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.gridChequeo)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1003, 546)
        Me.SplitContainerControl2.SplitterPosition = 703
        Me.SplitContainerControl2.TabIndex = 10
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cmbSubArea)
        Me.GroupControl4.Controls.Add(Me.SimpleButton3)
        Me.GroupControl4.Controls.Add(Me.LabelControl15)
        Me.GroupControl4.Controls.Add(Me.SimpleButton4)
        Me.GroupControl4.Controls.Add(Me.LabelControl13)
        Me.GroupControl4.Controls.Add(Me.cmbSubProyecto)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Controls.Add(Me.cmbSupervisor)
        Me.GroupControl4.Controls.Add(Me.LabelControl16)
        Me.GroupControl4.Controls.Add(Me.LabelControl5)
        Me.GroupControl4.Controls.Add(Me.cmbArea)
        Me.GroupControl4.Controls.Add(Me.cmbContratista)
        Me.GroupControl4.Controls.Add(Me.LabelControl17)
        Me.GroupControl4.Controls.Add(Me.LabelControl12)
        Me.GroupControl4.Controls.Add(Me.cmbNivel)
        Me.GroupControl4.Controls.Add(Me.cmbApartamento)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(290, 542)
        Me.GroupControl4.TabIndex = 19
        Me.GroupControl4.Text = "Datos del Chequeo de Calidad"
        '
        'cmbSubArea
        '
        Me.cmbSubArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSubArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSubArea.FormattingEnabled = True
        Me.cmbSubArea.Location = New System.Drawing.Point(89, 330)
        Me.cmbSubArea.Name = "cmbSubArea"
        Me.cmbSubArea.Size = New System.Drawing.Size(187, 21)
        Me.cmbSubArea.TabIndex = 18
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 470)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(114, 54)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "Cancelar"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(16, 335)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl15.TabIndex = 17
        Me.LabelControl15.Text = "Sub-Área:"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = Global.Neo_App.My.Resources.Resources.bt19
        Me.SimpleButton4.Location = New System.Drawing.Point(161, 470)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(114, 54)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "Guardar"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(14, 49)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl13.TabIndex = 5
        Me.LabelControl13.Text = "Sub-Proyecto:"
        '
        'cmbSubProyecto
        '
        Me.cmbSubProyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSubProyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSubProyecto.FormattingEnabled = True
        Me.cmbSubProyecto.Location = New System.Drawing.Point(14, 68)
        Me.cmbSubProyecto.Name = "cmbSubProyecto"
        Me.cmbSubProyecto.Size = New System.Drawing.Size(262, 21)
        Me.cmbSubProyecto.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(14, 95)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl11.TabIndex = 9
        Me.LabelControl11.Text = "Supervisor:"
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSupervisor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(14, 113)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(262, 21)
        Me.cmbSupervisor.TabIndex = 10
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(16, 301)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl16.TabIndex = 15
        Me.LabelControl16.Text = "Área:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(14, 152)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Contratista:"
        '
        'cmbArea
        '
        Me.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(91, 296)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(185, 21)
        Me.cmbArea.TabIndex = 16
        '
        'cmbContratista
        '
        Me.cmbContratista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbContratista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbContratista.FormattingEnabled = True
        Me.cmbContratista.Location = New System.Drawing.Point(14, 167)
        Me.cmbContratista.Name = "cmbContratista"
        Me.cmbContratista.Size = New System.Drawing.Size(262, 21)
        Me.cmbContratista.TabIndex = 12
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 267)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl17.TabIndex = 13
        Me.LabelControl17.Text = "Nivel:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(16, 232)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl12.TabIndex = 7
        Me.LabelControl12.Text = "Apartamento:"
        '
        'cmbNivel
        '
        Me.cmbNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Location = New System.Drawing.Point(91, 262)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(185, 21)
        Me.cmbNivel.TabIndex = 14
        '
        'cmbApartamento
        '
        Me.cmbApartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbApartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbApartamento.FormattingEnabled = True
        Me.cmbApartamento.Location = New System.Drawing.Point(91, 227)
        Me.cmbApartamento.Name = "cmbApartamento"
        Me.cmbApartamento.Size = New System.Drawing.Size(185, 21)
        Me.cmbApartamento.TabIndex = 8
        '
        'gridChequeo
        '
        Me.gridChequeo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridChequeo.Location = New System.Drawing.Point(0, 0)
        Me.gridChequeo.MainView = Me.GridView1
        Me.gridChequeo.Name = "gridChequeo"
        Me.gridChequeo.Size = New System.Drawing.Size(699, 542)
        Me.gridChequeo.TabIndex = 5
        Me.gridChequeo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDESPROCESO, Me.colDESETAPA, Me.colDESCAMPO, Me.colDESCALIFICACION})
        Me.GridView1.GridControl = Me.gridChequeo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
        '
        'colDESPROCESO
        '
        Me.colDESPROCESO.Caption = "Proceso"
        Me.colDESPROCESO.FieldName = "DESPROCESO"
        Me.colDESPROCESO.Name = "colDESPROCESO"
        Me.colDESPROCESO.Visible = True
        Me.colDESPROCESO.VisibleIndex = 0
        Me.colDESPROCESO.Width = 134
        '
        'colDESETAPA
        '
        Me.colDESETAPA.Caption = "Etapa"
        Me.colDESETAPA.FieldName = "DESETAPA"
        Me.colDESETAPA.Name = "colDESETAPA"
        Me.colDESETAPA.Visible = True
        Me.colDESETAPA.VisibleIndex = 1
        Me.colDESETAPA.Width = 190
        '
        'colDESCAMPO
        '
        Me.colDESCAMPO.Caption = "Campo"
        Me.colDESCAMPO.FieldName = "DESCAMPO"
        Me.colDESCAMPO.Name = "colDESCAMPO"
        Me.colDESCAMPO.Visible = True
        Me.colDESCAMPO.VisibleIndex = 2
        Me.colDESCAMPO.Width = 351
        '
        'colDESCALIFICACION
        '
        Me.colDESCALIFICACION.Caption = "Calificación"
        Me.colDESCALIFICACION.FieldName = "DESCALIFICACION"
        Me.colDESCALIFICACION.Name = "colDESCALIFICACION"
        Me.colDESCALIFICACION.Visible = True
        Me.colDESCALIFICACION.VisibleIndex = 3
        Me.colDESCALIFICACION.Width = 128
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lbCorrelativo)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl14)
        Me.GroupControl3.Controls.Add(Me.txtFecha)
        Me.GroupControl3.Controls.Add(Me.lbTitulo)
        Me.GroupControl3.Location = New System.Drawing.Point(9, 9)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(998, 86)
        Me.GroupControl3.TabIndex = 9
        Me.GroupControl3.Text = "Datos del Chequeo de Calidad"
        '
        'lbCorrelativo
        '
        Me.lbCorrelativo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorrelativo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCorrelativo.Location = New System.Drawing.Point(850, 33)
        Me.lbCorrelativo.Name = "lbCorrelativo"
        Me.lbCorrelativo.Size = New System.Drawing.Size(96, 16)
        Me.lbCorrelativo.TabIndex = 15
        Me.lbCorrelativo.Text = "000000000000"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(811, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "No.:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(63, 56)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl14.TabIndex = 2
        Me.LabelControl14.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Location = New System.Drawing.Point(102, 54)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Size = New System.Drawing.Size(101, 20)
        Me.txtFecha.TabIndex = 1
        '
        'lbTitulo
        '
        Me.lbTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTitulo.Location = New System.Drawing.Point(63, 28)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(181, 19)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Proyecto seleccionado"
        '
        'view_operation_chequeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "view_operation_chequeo"
        Me.Size = New System.Drawing.Size(1012, 659)
        CType(Me.TblTempChequeoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.gridChequeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TblTempChequeoBindingSource As BindingSource
    Friend WithEvents DS_Proyectos As DS_Proyectos
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbSubArea As ComboBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSubProyecto As ComboBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSupervisor As ComboBox
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbContratista As ComboBox
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNivel As ComboBox
    Friend WithEvents cmbApartamento As ComboBox
    Friend WithEvents gridChequeo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDESPROCESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESETAPA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCAMPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCALIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbCorrelativo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbTitulo As DevExpress.XtraEditors.LabelControl
End Class
