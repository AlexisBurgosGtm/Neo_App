<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_new_proyecto
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
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtFInicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtFFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptarFake = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(103, 70)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(103, 113)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(327, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'txtFInicio
        '
        Me.txtFInicio.EditValue = Nothing
        Me.txtFInicio.EnterMoveNextControl = True
        Me.txtFInicio.Location = New System.Drawing.Point(103, 166)
        Me.txtFInicio.Name = "txtFInicio"
        Me.txtFInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtFInicio.TabIndex = 2
        '
        'txtFFin
        '
        Me.txtFFin.EditValue = Nothing
        Me.txtFFin.EnterMoveNextControl = True
        Me.txtFFin.Location = New System.Drawing.Point(297, 166)
        Me.txtFFin.Name = "txtFFin"
        Me.txtFFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFFin.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Proyecto:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Dirección:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(43, 169)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Inicia el: "
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(241, 169)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Finaliza el:"
        '
        'lbTitulo
        '
        Me.lbTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(18, 17)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(151, 23)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = "Nuevo Proyecto"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Image = Global.Neo_App.My.Resources.Resources.bt20
        Me.SimpleButton1.Location = New System.Drawing.Point(184, 238)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(142, 53)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btnAceptarFake
        '
        Me.btnAceptarFake.Image = Global.Neo_App.My.Resources.Resources.btExito
        Me.btnAceptarFake.Location = New System.Drawing.Point(359, 238)
        Me.btnAceptarFake.Name = "btnAceptarFake"
        Me.btnAceptarFake.Size = New System.Drawing.Size(142, 53)
        Me.btnAceptarFake.TabIndex = 9
        Me.btnAceptarFake.Text = "Aceptar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Image = Global.Neo_App.My.Resources.Resources.btExito
        Me.btnAceptar.Location = New System.Drawing.Point(18, 330)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(142, 53)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.TabStop = False
        Me.btnAceptar.Text = "Aceptar"
        '
        'view_new_proyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAceptarFake)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtFFin)
        Me.Controls.Add(Me.txtFInicio)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "view_new_proyecto"
        Me.Size = New System.Drawing.Size(515, 318)
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptarFake As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
End Class
