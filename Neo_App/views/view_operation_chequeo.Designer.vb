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
        Me.lbProyectoSeleccionado = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DS_Proyectos = New Neo_App.DS_Proyectos()
        Me.TblTempChequeoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDESPROCESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESETAPA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCAMPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCALIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTempChequeoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbProyectoSeleccionado
        '
        Me.lbProyectoSeleccionado.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProyectoSeleccionado.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbProyectoSeleccionado.Location = New System.Drawing.Point(12, 32)
        Me.lbProyectoSeleccionado.Name = "lbProyectoSeleccionado"
        Me.lbProyectoSeleccionado.Size = New System.Drawing.Size(181, 19)
        Me.lbProyectoSeleccionado.TabIndex = 0
        Me.lbProyectoSeleccionado.Text = "Proyecto seleccionado"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.ComboBox4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.ComboBox3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.ComboBox2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.ComboBox1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.lbProyectoSeleccionado)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1006, 141)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos del Chequeo de Calidad"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl10.Location = New System.Drawing.Point(846, 34)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "000000000000"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(807, 34)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "No.:"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(379, 99)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox4.TabIndex = 12
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(304, 102)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Contratista:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(379, 63)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(304, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Supervisor:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(87, 99)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Apartamento:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Sub-Proyecto:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(807, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Fecha:"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(846, 64)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(101, 20)
        Me.DateEdit1.TabIndex = 1
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(65, 43)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox5.TabIndex = 14
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Nivel:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ComboBox7)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.ComboBox6)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.ComboBox5)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 152)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(200, 274)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Sección"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(65, 121)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox7.TabIndex = 18
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 124)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Sub-Área:"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(65, 81)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox6.TabIndex = 16
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 84)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Área:"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TblTempChequeoBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(212, 152)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(631, 494)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDESPROCESO, Me.colDESETAPA, Me.colDESCAMPO, Me.colDESCALIFICACION})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDESPROCESO, DevExpress.Data.ColumnSortOrder.Descending)})
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
        'DS_Proyectos
        '
        Me.DS_Proyectos.DataSetName = "DS_Proyectos"
        Me.DS_Proyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTempChequeoBindingSource
        '
        Me.TblTempChequeoBindingSource.DataMember = "tblTempChequeo"
        Me.TblTempChequeoBindingSource.DataSource = Me.DS_Proyectos
        '
        'colDESPROCESO
        '
        Me.colDESPROCESO.FieldName = "DESPROCESO"
        Me.colDESPROCESO.Name = "colDESPROCESO"
        Me.colDESPROCESO.Visible = True
        Me.colDESPROCESO.VisibleIndex = 0
        '
        'colDESETAPA
        '
        Me.colDESETAPA.FieldName = "DESETAPA"
        Me.colDESETAPA.Name = "colDESETAPA"
        Me.colDESETAPA.Visible = True
        Me.colDESETAPA.VisibleIndex = 0
        Me.colDESETAPA.Width = 185
        '
        'colDESCAMPO
        '
        Me.colDESCAMPO.FieldName = "DESCAMPO"
        Me.colDESCAMPO.Name = "colDESCAMPO"
        Me.colDESCAMPO.Visible = True
        Me.colDESCAMPO.VisibleIndex = 1
        Me.colDESCAMPO.Width = 321
        '
        'colDESCALIFICACION
        '
        Me.colDESCALIFICACION.FieldName = "DESCALIFICACION"
        Me.colDESCALIFICACION.Name = "colDESCALIFICACION"
        Me.colDESCALIFICACION.Visible = True
        Me.colDESCALIFICACION.VisibleIndex = 2
        Me.colDESCALIFICACION.Width = 106
        '
        'view_operation_chequeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "view_operation_chequeo"
        Me.Size = New System.Drawing.Size(1012, 659)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTempChequeoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbProyectoSeleccionado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TblTempChequeoBindingSource As BindingSource
    Friend WithEvents DS_Proyectos As DS_Proyectos
    Friend WithEvents colDESPROCESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESETAPA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCAMPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCALIFICACION As DevExpress.XtraGrid.Columns.GridColumn
End Class
