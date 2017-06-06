<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.ControlButtonsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ChorderTitle = New System.Windows.Forms.Label()
        Me.MainContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.LyricsViewContainer = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ChorderScrollBar = New Chorder.ChorderScrollBar()
        Me.CloseButton = New Chorder.CloseButton()
        Me.MaximizeButton = New Chorder.MaximizeButton()
        Me.MinimizeButton = New Chorder.MinimizeButton()
        Me.TopPanel.SuspendLayout()
        Me.ControlButtonsLayout.SuspendLayout()
        Me.MainContainer.SuspendLayout()
        Me.LyricsViewContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.ControlButtonsLayout)
        Me.TopPanel.Controls.Add(Me.ChorderTitle)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1024, 24)
        Me.TopPanel.TabIndex = 0
        '
        'ControlButtonsLayout
        '
        Me.ControlButtonsLayout.ColumnCount = 3
        Me.ControlButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ControlButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ControlButtonsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ControlButtonsLayout.Controls.Add(Me.CloseButton, 2, 0)
        Me.ControlButtonsLayout.Controls.Add(Me.MaximizeButton, 1, 0)
        Me.ControlButtonsLayout.Controls.Add(Me.MinimizeButton, 0, 0)
        Me.ControlButtonsLayout.Dock = System.Windows.Forms.DockStyle.Right
        Me.ControlButtonsLayout.Location = New System.Drawing.Point(904, 0)
        Me.ControlButtonsLayout.Name = "ControlButtonsLayout"
        Me.ControlButtonsLayout.RowCount = 1
        Me.ControlButtonsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ControlButtonsLayout.Size = New System.Drawing.Size(120, 24)
        Me.ControlButtonsLayout.TabIndex = 0
        '
        'ChorderTitle
        '
        Me.ChorderTitle.BackColor = System.Drawing.Color.Transparent
        Me.ChorderTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChorderTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChorderTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChorderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ChorderTitle.Location = New System.Drawing.Point(0, 0)
        Me.ChorderTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.ChorderTitle.Name = "ChorderTitle"
        Me.ChorderTitle.Size = New System.Drawing.Size(64, 24)
        Me.ChorderTitle.TabIndex = 0
        Me.ChorderTitle.Text = "Chorder"
        Me.ChorderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainContainer
        '
        Me.MainContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.MainContainer.ColumnCount = 1
        Me.MainContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainContainer.Controls.Add(Me.LyricsViewContainer, 0, 0)
        Me.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContainer.ForeColor = System.Drawing.Color.Transparent
        Me.MainContainer.Location = New System.Drawing.Point(0, 24)
        Me.MainContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.MainContainer.RowCount = 1
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainContainer.Size = New System.Drawing.Size(1024, 488)
        Me.MainContainer.TabIndex = 1
        '
        'LyricsViewContainer
        '
        Me.LyricsViewContainer.Controls.Add(Me.ChorderScrollBar)
        Me.LyricsViewContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LyricsViewContainer.Location = New System.Drawing.Point(10, 10)
        Me.LyricsViewContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.LyricsViewContainer.Name = "LyricsViewContainer"
        Me.LyricsViewContainer.Size = New System.Drawing.Size(1004, 468)
        Me.LyricsViewContainer.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(350, 79)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(405, 339)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'ChorderScrollBar
        '
        Me.ChorderScrollBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ChorderScrollBar.BackColor = System.Drawing.Color.Transparent
        Me.ChorderScrollBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChorderScrollBar.Location = New System.Drawing.Point(980, 0)
        Me.ChorderScrollBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ChorderScrollBar.MinimumSize = New System.Drawing.Size(0, 50)
        Me.ChorderScrollBar.Name = "ChorderScrollBar"
        Me.ChorderScrollBar.Padding = New System.Windows.Forms.Padding(2)
        Me.ChorderScrollBar.ParentView = Nothing
        Me.ChorderScrollBar.Size = New System.Drawing.Size(24, 468)
        Me.ChorderScrollBar.TabIndex = 5
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.Chorder.My.Resources.Resources.close_button
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CloseButton.Location = New System.Drawing.Point(80, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(40, 24)
        Me.CloseButton.TabIndex = 0
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.BackgroundImage = CType(resources.GetObject("MaximizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaximizeButton.Location = New System.Drawing.Point(40, 0)
        Me.MaximizeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(40, 24)
        Me.MaximizeButton.TabIndex = 0
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BackgroundImage = CType(resources.GetObject("MinimizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinimizeButton.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(40, 24)
        Me.MinimizeButton.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MainContainer)
        Me.Controls.Add(Me.TopPanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(120, 30)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.ControlButtonsLayout.ResumeLayout(False)
        Me.MainContainer.ResumeLayout(False)
        Me.LyricsViewContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlButtonsLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CloseButton As Chorder.CloseButton
    Friend WithEvents MaximizeButton As Chorder.MaximizeButton
    Friend WithEvents MinimizeButton As Chorder.MinimizeButton
    Friend WithEvents ChorderTitle As System.Windows.Forms.Label
    Friend WithEvents MainContainer As TableLayoutPanel
    Friend WithEvents LyricsViewContainer As Panel
    Friend WithEvents ChorderScrollBar As ChorderScrollBar
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
