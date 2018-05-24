<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
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
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.btn_Proyectos = New DevExpress.XtraBars.Navigation.NavButton()
        Me.NavButton4 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.Skins = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.XtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeader
        Me.XtraTabbedMdiManager1.ShowFloatingDropHint = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.TabPageWidth = 110
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 747)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 747)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1158, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 747)
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.Skins)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 719)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1158, 28)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.Skins})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1158, 49)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'TileNavPane1
        '
        Me.TileNavPane1.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.TileNavPane1.Appearance.Options.UseBackColor = True
        Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane1.Buttons.Add(Me.NavButton2)
        Me.TileNavPane1.Buttons.Add(Me.btn_Proyectos)
        Me.TileNavPane1.Buttons.Add(Me.NavButton4)
        '
        'TileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
        Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.TileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileNavPane1.Location = New System.Drawing.Point(0, 49)
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Size = New System.Drawing.Size(1158, 40)
        Me.TileNavPane1.TabIndex = 8
        Me.TileNavPane1.Text = "TileNavPane1"
        '
        'NavButton2
        '
        Me.NavButton2.Caption = "Inicio"
        Me.NavButton2.IsMain = True
        Me.NavButton2.Name = "NavButton2"
        '
        'btn_Proyectos
        '
        Me.btn_Proyectos.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.btn_Proyectos.Caption = "Proyectos"
        Me.btn_Proyectos.Name = "btn_Proyectos"
        '
        'NavButton4
        '
        Me.NavButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.NavButton4.Caption = "NavButton4"
        Me.NavButton4.Name = "NavButton4"
        '
        'Skins
        '
        Me.Skins.Caption = "Skins"
        Me.Skins.Id = 1
        Me.Skins.Name = "Skins"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark"
        '
        'index
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AllowMdiBar = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 747)
        Me.Controls.Add(Me.TileNavPane1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "index"
        Me.Ribbon = Me.RibbonControl1
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "index"
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents btn_Proyectos As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents NavButton4 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents Skins As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
