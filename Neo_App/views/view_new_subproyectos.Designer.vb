<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_new_subproyectos
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_new_subproyectos))
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridSubProyectos = New DevExpress.XtraGrid.GridControl()
        Me.TblSubProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Proyectos = New Neo_App.DS_Proyectos()
        Me.TileViewSubProyectos = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colCodSubProyecto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridSubProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileViewSubProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbTitulo)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(982, 92)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Gestión de SubProyectos"
        '
        'lbTitulo
        '
        Me.lbTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTitulo.Location = New System.Drawing.Point(19, 37)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(235, 25)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Proyecto Seleccionado"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnCancelar)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Controls.Add(Me.txtDireccion)
        Me.GroupControl2.Controls.Add(Me.txtCodigo)
        Me.GroupControl2.Controls.Add(Me.txtDescripcion)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(15, 109)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(319, 528)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Datos del Sub Proyecto"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(48, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 54)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Neo_App.My.Resources.Resources.bt19
        Me.btnGuardar.Location = New System.Drawing.Point(193, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 54)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'txtDireccion
        '
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(12, 170)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(295, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(193, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 98)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(295, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 151)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Dirección:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descripción:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridSubProyectos)
        Me.GroupControl3.Location = New System.Drawing.Point(340, 109)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(657, 528)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Sub Proyectos Asociados"
        '
        'GridSubProyectos
        '
        Me.GridSubProyectos.DataSource = Me.TblSubProyectosBindingSource
        Me.GridSubProyectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSubProyectos.Location = New System.Drawing.Point(2, 22)
        Me.GridSubProyectos.MainView = Me.TileViewSubProyectos
        Me.GridSubProyectos.Name = "GridSubProyectos"
        Me.GridSubProyectos.Size = New System.Drawing.Size(653, 504)
        Me.GridSubProyectos.TabIndex = 0
        Me.GridSubProyectos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileViewSubProyectos})
        '
        'TblSubProyectosBindingSource
        '
        Me.TblSubProyectosBindingSource.DataMember = "tblSubProyectos"
        Me.TblSubProyectosBindingSource.DataSource = Me.DS_Proyectos
        '
        'DS_Proyectos
        '
        Me.DS_Proyectos.DataSetName = "DS_Proyectos"
        Me.DS_Proyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TileViewSubProyectos
        '
        Me.TileViewSubProyectos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodSubProyecto, Me.colDescripcion, Me.colDireccion})
        Me.TileViewSubProyectos.GridControl = Me.GridSubProyectos
        Me.TileViewSubProyectos.Name = "TileViewSubProyectos"
        Me.TileViewSubProyectos.OptionsTiles.ColumnCount = 2
        Me.TileViewSubProyectos.OptionsTiles.IndentBetweenItems = 9
        Me.TileViewSubProyectos.OptionsTiles.ItemSize = New System.Drawing.Size(260, 150)
        Me.TileViewSubProyectos.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileViewSubProyectos.OptionsTiles.RowCount = 100
        TileViewItemElement1.Column = Me.colDescripcion
        TileViewItemElement1.Text = "colDescripcion"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement1.TextLocation = New System.Drawing.Point(0, 25)
        TileViewItemElement2.Column = Me.colDireccion
        TileViewItemElement2.Text = "colDireccion"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement2.TextLocation = New System.Drawing.Point(0, 90)
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Text = "Descripción:"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement4.Appearance.Normal.Options.UseFont = True
        TileViewItemElement4.Text = "Dirección:"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement4.TextLocation = New System.Drawing.Point(0, 70)
        Me.TileViewSubProyectos.TileTemplate.Add(TileViewItemElement1)
        Me.TileViewSubProyectos.TileTemplate.Add(TileViewItemElement2)
        Me.TileViewSubProyectos.TileTemplate.Add(TileViewItemElement3)
        Me.TileViewSubProyectos.TileTemplate.Add(TileViewItemElement4)
        '
        'colCodSubProyecto
        '
        Me.colCodSubProyecto.FieldName = "CodSubProyecto"
        Me.colCodSubProyecto.Name = "colCodSubProyecto"
        Me.colCodSubProyecto.Visible = True
        Me.colCodSubProyecto.VisibleIndex = 0
        '
        'view_new_subproyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "view_new_subproyectos"
        Me.Size = New System.Drawing.Size(1012, 659)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridSubProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileViewSubProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridSubProyectos As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileViewSubProyectos As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TblSubProyectosBindingSource As BindingSource
    Friend WithEvents DS_Proyectos As DS_Proyectos
    Friend WithEvents colCodSubProyecto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
