<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_list_proyectos
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
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_list_proyectos))
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFechaFinaliza = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridProyectos = New DevExpress.XtraGrid.GridControl()
        Me.CtrcalProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Proyectos = New Neo_App.DS_Proyectos()
        Me.TileViewProyectos = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDuracion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCodStatus = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.Ctrcal_ProyectosTableAdapter = New Neo_App.DS_ProyectosTableAdapters.ctrcal_ProyectosTableAdapter()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lbDesProyecto = New DevExpress.XtraEditors.LabelControl()
        Me.WindowsUIButtonPanelOpciones = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ProgressBarControl3 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.bar_cronReal = New DevExpress.XtraEditors.ProgressBarControl()
        Me.bar_presReal = New DevExpress.XtraEditors.ProgressBarControl()
        Me.ProgressBarControl2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.WindowsUIButtonPanelEdicion = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        CType(Me.GridProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrcalProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileViewProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ProgressBarControl3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar_cronReal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar_presReal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 0
        Me.colDescripcion.Width = 233
        '
        'colFechaInicio
        '
        Me.colFechaInicio.FieldName = "FechaInicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 2
        Me.colFechaInicio.Width = 107
        '
        'colFechaFinaliza
        '
        Me.colFechaFinaliza.FieldName = "FechaFinaliza"
        Me.colFechaFinaliza.Name = "colFechaFinaliza"
        Me.colFechaFinaliza.Visible = True
        Me.colFechaFinaliza.VisibleIndex = 3
        Me.colFechaFinaliza.Width = 92
        '
        'GridProyectos
        '
        Me.GridProyectos.DataSource = Me.CtrcalProyectosBindingSource
        Me.GridProyectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProyectos.Location = New System.Drawing.Point(0, 0)
        Me.GridProyectos.MainView = Me.TileViewProyectos
        Me.GridProyectos.Name = "GridProyectos"
        Me.GridProyectos.Size = New System.Drawing.Size(659, 611)
        Me.GridProyectos.TabIndex = 0
        Me.GridProyectos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileViewProyectos})
        '
        'CtrcalProyectosBindingSource
        '
        Me.CtrcalProyectosBindingSource.DataMember = "ctrcal_Proyectos"
        Me.CtrcalProyectosBindingSource.DataSource = Me.DS_Proyectos
        '
        'DS_Proyectos
        '
        Me.DS_Proyectos.DataSetName = "DS_Proyectos"
        Me.DS_Proyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TileViewProyectos
        '
        Me.TileViewProyectos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TileViewProyectos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion, Me.colDireccion, Me.colFechaInicio, Me.colFechaFinaliza, Me.colDuracion, Me.colCodStatus})
        Me.TileViewProyectos.GridControl = Me.GridProyectos
        Me.TileViewProyectos.Name = "TileViewProyectos"
        Me.TileViewProyectos.OptionsTiles.ColumnCount = 2
        Me.TileViewProyectos.OptionsTiles.HighlightFocusedTileOnGridLoad = True
        Me.TileViewProyectos.OptionsTiles.IndentBetweenItems = 10
        Me.TileViewProyectos.OptionsTiles.ItemSize = New System.Drawing.Size(260, 120)
        Me.TileViewProyectos.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileViewProyectos.OptionsTiles.RowCount = 500
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.colDescripcion
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.StretchVertical = True
        TileViewItemElement1.Text = "colDescripcion"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(0, 25)
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement2.Column = Me.colFechaInicio
        TileViewItemElement2.Text = "colFechaInicio"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(0, 87)
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement3.Column = Me.colFechaFinaliza
        TileViewItemElement3.Text = "colFechaFinaliza"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(145, 87)
        TileViewItemElement4.Text = "Proyecto:"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.Text = "Inicio:"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(0, 70)
        TileViewItemElement6.Text = "Fin:"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement6.TextLocation = New System.Drawing.Point(145, 70)
        TileViewItemElement7.Image = CType(resources.GetObject("TileViewItemElement7.Image"), System.Drawing.Image)
        TileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileViewItemElement7.Text = ""
        TileViewItemElement8.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 20.0!)
        TileViewItemElement8.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement8.Appearance.Normal.Options.UseFont = True
        TileViewItemElement8.StretchHorizontal = True
        TileViewItemElement8.Text = " "
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement8.TextLocation = New System.Drawing.Point(0, 85)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement1)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement2)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement3)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement4)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement5)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement6)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement7)
        Me.TileViewProyectos.TileTemplate.Add(TileViewItemElement8)
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 1
        Me.colDireccion.Width = 271
        '
        'colDuracion
        '
        Me.colDuracion.FieldName = "Duracion"
        Me.colDuracion.Name = "colDuracion"
        Me.colDuracion.Visible = True
        Me.colDuracion.VisibleIndex = 4
        Me.colDuracion.Width = 86
        '
        'colCodStatus
        '
        Me.colCodStatus.FieldName = "CodStatus"
        Me.colCodStatus.Name = "colCodStatus"
        Me.colCodStatus.Visible = True
        Me.colCodStatus.VisibleIndex = 5
        Me.colCodStatus.Width = 77
        '
        'Ctrcal_ProyectosTableAdapter
        '
        Me.Ctrcal_ProyectosTableAdapter.ClearBeforeFill = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(218, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Listado de Proyectos"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.IsSplitterFixed = True
        Me.SplitContainerControl1.Location = New System.Drawing.Point(9, 36)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridProyectos)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(998, 619)
        Me.SplitContainerControl1.SplitterPosition = 663
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.WindowsUIButtonPanelEdicion)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(322, 611)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Opciones del Proyecto"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.AllowGlyphSkinning = False
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.WindowsUIButtonPanel1.AppearanceButton.Normal.Options.UseBorderColor = True
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Nuevo", CType(resources.GetObject("WindowsUIButtonPanel1.Buttons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "NUEVO", -1, False, False)})
        Me.WindowsUIButtonPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(239, 23)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(68, 66)
        Me.WindowsUIButtonPanel1.TabIndex = 3
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbDesProyecto)
        Me.GroupControl2.Controls.Add(Me.WindowsUIButtonPanelOpciones)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.ProgressBarControl3)
        Me.GroupControl2.Controls.Add(Me.bar_cronReal)
        Me.GroupControl2.Controls.Add(Me.bar_presReal)
        Me.GroupControl2.Controls.Add(Me.ProgressBarControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 116)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(313, 479)
        Me.GroupControl2.TabIndex = 15
        Me.GroupControl2.Text = "Status del Proyecto Seleccionado"
        '
        'lbDesProyecto
        '
        Me.lbDesProyecto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesProyecto.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDesProyecto.Location = New System.Drawing.Point(8, 154)
        Me.lbDesProyecto.Name = "lbDesProyecto"
        Me.lbDesProyecto.Size = New System.Drawing.Size(12, 16)
        Me.lbDesProyecto.TabIndex = 1
        Me.lbDesProyecto.Text = "..."
        '
        'WindowsUIButtonPanelOpciones
        '
        Me.WindowsUIButtonPanelOpciones.AllowGlyphSkinning = False
        Me.WindowsUIButtonPanelOpciones.AllowHtmlDraw = True
        Me.WindowsUIButtonPanelOpciones.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Chequeo Calidad", CType(resources.GetObject("WindowsUIButtonPanelOpciones.Buttons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "CHEQUEO", -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Cronograma", CType(resources.GetObject("WindowsUIButtonPanelOpciones.Buttons1"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "CRONOGRAMA", -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Presupuesto", CType(resources.GetObject("WindowsUIButtonPanelOpciones.Buttons2"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "PRESUPUESTO", -1, False, False)})
        Me.WindowsUIButtonPanelOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WindowsUIButtonPanelOpciones.Location = New System.Drawing.Point(7, 31)
        Me.WindowsUIButtonPanelOpciones.Name = "WindowsUIButtonPanelOpciones"
        Me.WindowsUIButtonPanelOpciones.Size = New System.Drawing.Size(295, 66)
        Me.WindowsUIButtonPanelOpciones.TabIndex = 3
        Me.WindowsUIButtonPanelOpciones.Text = "WindowsUIButtonPanel2"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(37, 408)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Teórico:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(18, 212)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Status Cronológico"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(37, 367)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 13
        Me.LabelControl9.Text = "Real:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(18, 340)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Status Presupuestario"
        '
        'ProgressBarControl3
        '
        Me.ProgressBarControl3.Location = New System.Drawing.Point(85, 398)
        Me.ProgressBarControl3.Name = "ProgressBarControl3"
        Me.ProgressBarControl3.Properties.ShowTitle = True
        Me.ProgressBarControl3.Size = New System.Drawing.Size(189, 33)
        Me.ProgressBarControl3.TabIndex = 12
        '
        'bar_cronReal
        '
        Me.bar_cronReal.Location = New System.Drawing.Point(85, 238)
        Me.bar_cronReal.Name = "bar_cronReal"
        Me.bar_cronReal.Properties.ShowTitle = True
        Me.bar_cronReal.Size = New System.Drawing.Size(189, 33)
        Me.bar_cronReal.TabIndex = 6
        '
        'bar_presReal
        '
        Me.bar_presReal.Location = New System.Drawing.Point(85, 359)
        Me.bar_presReal.Name = "bar_presReal"
        Me.bar_presReal.Properties.ShowTitle = True
        Me.bar_presReal.Size = New System.Drawing.Size(189, 33)
        Me.bar_presReal.TabIndex = 11
        '
        'ProgressBarControl2
        '
        Me.ProgressBarControl2.Location = New System.Drawing.Point(85, 280)
        Me.ProgressBarControl2.Name = "ProgressBarControl2"
        Me.ProgressBarControl2.Properties.ShowTitle = True
        Me.ProgressBarControl2.Size = New System.Drawing.Size(189, 33)
        Me.ProgressBarControl2.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(37, 290)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Teórico:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(37, 246)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Real:"
        '
        'WindowsUIButtonPanelEdicion
        '
        Me.WindowsUIButtonPanelEdicion.AllowGlyphSkinning = False
        Me.WindowsUIButtonPanelEdicion.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Resumen", CType(resources.GetObject("WindowsUIButtonPanelEdicion.Buttons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "RESUMEN", -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Editar", CType(resources.GetObject("WindowsUIButtonPanelEdicion.Buttons1"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "EDITAR", -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Eliminar", CType(resources.GetObject("WindowsUIButtonPanelEdicion.Buttons2"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "ELIMINAR", -1, False, False)})
        Me.WindowsUIButtonPanelEdicion.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.WindowsUIButtonPanelEdicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WindowsUIButtonPanelEdicion.Location = New System.Drawing.Point(12, 23)
        Me.WindowsUIButtonPanelEdicion.Name = "WindowsUIButtonPanelEdicion"
        Me.WindowsUIButtonPanelEdicion.Size = New System.Drawing.Size(170, 66)
        Me.WindowsUIButtonPanelEdicion.TabIndex = 2
        Me.WindowsUIButtonPanelEdicion.Text = "WindowsUIButtonPanel1"
        '
        'view_list_proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "view_list_proyectos"
        Me.Size = New System.Drawing.Size(1012, 659)
        CType(Me.GridProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrcalProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileViewProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.ProgressBarControl3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar_cronReal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar_presReal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridProyectos As DevExpress.XtraGrid.GridControl
    Friend WithEvents CtrcalProyectosBindingSource As BindingSource
    Friend WithEvents DS_Proyectos As DS_Proyectos
    Friend WithEvents Ctrcal_ProyectosTableAdapter As DS_ProyectosTableAdapters.ctrcal_ProyectosTableAdapter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbDesProyecto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBarControl3 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents bar_presReal As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressBarControl2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents bar_cronReal As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WindowsUIButtonPanelEdicion As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents WindowsUIButtonPanelOpciones As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TileViewProyectos As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFechaFinaliza As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDuracion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCodStatus As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
