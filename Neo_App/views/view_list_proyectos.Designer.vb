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
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colFechaFinaliza = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDuracion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridProyectos = New DevExpress.XtraGrid.GridControl()
        Me.CtrcalProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Proyectos = New Neo_App.DS_Proyectos()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colCodStatus = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.Ctrcal_ProyectosTableAdapter = New Neo_App.DS_ProyectosTableAdapters.ctrcal_ProyectosTableAdapter()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrcalProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 1
        Me.colDireccion.Width = 271
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
        'colDuracion
        '
        Me.colDuracion.FieldName = "Duracion"
        Me.colDuracion.Name = "colDuracion"
        Me.colDuracion.Visible = True
        Me.colDuracion.VisibleIndex = 4
        Me.colDuracion.Width = 86
        '
        'GridProyectos
        '
        Me.GridProyectos.DataSource = Me.CtrcalProyectosBindingSource
        Me.GridProyectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProyectos.Location = New System.Drawing.Point(0, 0)
        Me.GridProyectos.MainView = Me.TileView1
        Me.GridProyectos.Name = "GridProyectos"
        Me.GridProyectos.Size = New System.Drawing.Size(900, 600)
        Me.GridProyectos.TabIndex = 0
        Me.GridProyectos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
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
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion, Me.colDireccion, Me.colFechaInicio, Me.colFechaFinaliza, Me.colDuracion, Me.colCodStatus})
        Me.TileView1.GridControl = Me.GridProyectos
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.HighlightFocusedTileOnGridLoad = True
        Me.TileView1.OptionsTiles.IndentBetweenItems = 3
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(800, 120)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.RowCount = 50
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.colDescripcion
        TileViewItemElement1.Text = "colDescripcion"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement2.Column = Me.colDireccion
        TileViewItemElement2.Text = "colDireccion"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(0, 20)
        TileViewItemElement3.Column = Me.colFechaInicio
        TileViewItemElement3.Text = "colFechaInicio"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement3.TextLocation = New System.Drawing.Point(0, 80)
        TileViewItemElement4.Column = Me.colFechaFinaliza
        TileViewItemElement4.Text = "colFechaFinaliza"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(150, 80)
        TileViewItemElement5.Column = Me.colDuracion
        TileViewItemElement5.Text = "colDuracion"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement5.TextLocation = New System.Drawing.Point(0, 40)
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        Me.TileView1.TileTemplate.Add(TileViewItemElement4)
        Me.TileView1.TileTemplate.Add(TileViewItemElement5)
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
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(282, 33)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Listado de Proyectos"
        '
        'view_list_proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridProyectos)
        Me.Name = "view_list_proyectos"
        Me.Size = New System.Drawing.Size(900, 600)
        CType(Me.GridProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrcalProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridProyectos As DevExpress.XtraGrid.GridControl
    Friend WithEvents CtrcalProyectosBindingSource As BindingSource
    Friend WithEvents DS_Proyectos As DS_Proyectos
    Friend WithEvents Ctrcal_ProyectosTableAdapter As DS_ProyectosTableAdapters.ctrcal_ProyectosTableAdapter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFechaFinaliza As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDuracion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCodStatus As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
