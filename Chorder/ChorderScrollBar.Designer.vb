<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChorderScrollBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ScrollBar = New System.Windows.Forms.Panel()
        Me.ScrollBarContainer = New System.Windows.Forms.Panel()
        Me.ArrowDown = New System.Windows.Forms.PictureBox()
        Me.ArrowUp = New System.Windows.Forms.PictureBox()
        Me.ScrollBarContainer.SuspendLayout()
        CType(Me.ArrowDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScrollBar
        '
        Me.ScrollBar.AutoScroll = True
        Me.ScrollBar.BackColor = System.Drawing.Color.Silver
        Me.ScrollBar.Location = New System.Drawing.Point(0, 0)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ScrollBar.Size = New System.Drawing.Size(36, 50)
        Me.ScrollBar.TabIndex = 2
        '
        'ScrollBarContainer
        '
        Me.ScrollBarContainer.Controls.Add(Me.ScrollBar)
        Me.ScrollBarContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScrollBarContainer.Location = New System.Drawing.Point(0, 20)
        Me.ScrollBarContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.ScrollBarContainer.Name = "ScrollBarContainer"
        Me.ScrollBarContainer.Size = New System.Drawing.Size(100, 360)
        Me.ScrollBarContainer.TabIndex = 5
        '
        'ArrowDown
        '
        Me.ArrowDown.BackColor = System.Drawing.Color.Transparent
        Me.ArrowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.ArrowDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ArrowDown.Image = Global.Chorder.My.Resources.Resources.scroll_arrow_down_transparent
        Me.ArrowDown.InitialImage = Global.Chorder.My.Resources.Resources.scroll_arrow_down_transparent
        Me.ArrowDown.Location = New System.Drawing.Point(0, 380)
        Me.ArrowDown.Margin = New System.Windows.Forms.Padding(0)
        Me.ArrowDown.Name = "ArrowDown"
        Me.ArrowDown.Size = New System.Drawing.Size(100, 20)
        Me.ArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ArrowDown.TabIndex = 4
        Me.ArrowDown.TabStop = False
        '
        'ArrowUp
        '
        Me.ArrowUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArrowUp.Image = Global.Chorder.My.Resources.Resources.scroll_arrow_up_transparent
        Me.ArrowUp.InitialImage = Global.Chorder.My.Resources.Resources.scroll_arrow_up_transparent
        Me.ArrowUp.Location = New System.Drawing.Point(0, 0)
        Me.ArrowUp.Margin = New System.Windows.Forms.Padding(0)
        Me.ArrowUp.Name = "ArrowUp"
        Me.ArrowUp.Size = New System.Drawing.Size(100, 20)
        Me.ArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ArrowUp.TabIndex = 3
        Me.ArrowUp.TabStop = False
        '
        '_ChorderScrollBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ScrollBarContainer)
        Me.Controls.Add(Me.ArrowDown)
        Me.Controls.Add(Me.ArrowUp)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "_ChorderScrollBar"
        Me.Size = New System.Drawing.Size(100, 400)
        Me.ScrollBarContainer.ResumeLayout(False)
        CType(Me.ArrowDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ArrowDown As System.Windows.Forms.PictureBox
    Friend WithEvents ScrollBar As System.Windows.Forms.Panel
    Friend WithEvents ArrowUp As System.Windows.Forms.PictureBox
    Friend WithEvents ScrollBarContainer As System.Windows.Forms.Panel

End Class
