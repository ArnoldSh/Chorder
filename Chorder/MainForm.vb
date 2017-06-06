Public Class MainForm

    Public Shared Event _ScrollEvt As ScrollEventHandler

    Private _utils As New Utils()
    Private _utilsGUI As New UtilsGUI()

    Private BORDER_WIDTH As Integer = 1
    Private FORM_PADDING As Integer = 4

    Private isMouseDown As Boolean
    Private lastPos As Point

    'Protected Overrides ReadOnly Property CreateParams() As CreateParams ' ???
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000 ' Turn on WS_EX_COMPOSITED
    '        Return cp
    '    End Get
    'End Property

    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Const CS_DROPSHADOW As Integer = &H20000
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
    '        Return cp
    '    End Get
    'End Property

    Protected Overrides Sub OnLoad(e As EventArgs)

        Me.SetStyle(ControlStyles.ResizeRedraw, True)

        Me.Padding = New Padding(FORM_PADDING)
        Me.MinimumSize = New Size(Me.ControlButtonsLayout.Width + Me.Padding.All * 2 + ChorderTitle.Width, Me.TopPanel.Height + Me.Padding.All * 2)
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Me.BackColor = GUI.Default.MAIN_BACK_COLOR
        TopPanel.BackColor = GUI.Default.TOP_PANEL_COLOR
        ChorderTitle.ForeColor = GUI.Default.MAIN_TEXT_COLOR

        'LyricsControllerInstance.BackColor = GUI.Default.MAIN_BACK_COLOR
        'LyricsControllerInstance.Text = My.Resources.example_chords

        'LyricsControllerInstance.ForeColor = GUI.Default.MAIN_TEXT_COLOR

        'RichTextBox1.BackColor = GUI.Default.MAIN_BACK_COLOR
        'RichTextBox1.ForeColor = Color.Aquamarine
        'RichTextBox1.Font = New Drawing.Font("Calibri", 10, FontStyle.Regular)


        ' test render html via WebBrowser component

        WebBrowser1.DocumentText = "<html><head><style>p { background: green; transition: background 2s;} p:hover {background: red;}</style></head><body><p>Hello!</p><b>Bold</b></body></html>"
        MyBase.OnLoad(e)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H84) Then
            MyBase.WndProc(m)
            If (m.Result = &H1 And Me.WindowState = FormWindowState.Normal) Then
                Dim screenPoint As Point = New Point(m.LParam.ToInt32())
                Dim clientPoint As Point = Me.PointToClient(screenPoint)
                If (clientPoint.Y <= FORM_PADDING) Then
                    If (clientPoint.X <= FORM_PADDING) Then
                        m.Result = 13 ' top left corner
                    ElseIf (clientPoint.X < (Me.Size.Width - FORM_PADDING)) Then
                        m.Result = 12 ' top
                    Else
                        m.Result = 14 ' top right corner
                    End If
                ElseIf (clientPoint.Y <= (Me.Size.Height - FORM_PADDING)) Then
                    If (clientPoint.X <= FORM_PADDING) Then
                        m.Result = 10 ' left
                    ElseIf (clientPoint.X < (Me.Size.Width - FORM_PADDING)) Then
                        'm.Result = 2 ' move
                    Else
                        m.Result = 11 ' right
                    End If
                Else
                    If (clientPoint.X <= FORM_PADDING) Then
                        m.Result = 16 ' bottom left corner
                    ElseIf (clientPoint.X < (Me.Size.Width - FORM_PADDING)) Then
                        m.Result = 15 ' bottom
                    Else
                        m.Result = 17 ' bottom right corner
                    End If
                End If
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        'Me.BackColor = GUI.Default.MAIN_BORDER_COLOR
        'MainContainer.BackColor = GUI.Default.MAIN_BACK_COLOR

        _utilsGUI.makeBorder(Me, e.Graphics, GUI.Default.MAIN_BORDER_COLOR, BORDER_WIDTH)

        MyBase.OnPaint(e)
    End Sub

    Private Sub paintPackman(e As PaintEventArgs)
        Dim packman As New System.Drawing.Drawing2D.GraphicsPath()
        Dim x As Integer = 250
        Dim y As Integer = 150
        Dim width As Integer = 100
        Dim height As Integer = 100
        packman.AddPie(x, y, width, height, 45, 270)
        packman.AddEllipse(x + 40, y + 10, 10, 10)
        packman.AddEllipse(x + 120, y + 35, 20, 20)
        packman.AddEllipse(x + 170, y + 35, 20, 20)
        packman.AddEllipse(x + 220, y + 35, 20, 20)
        Dim formRegion As New Region(New Rectangle(Point.Empty, Me.Size))
        formRegion.Exclude(packman)
        Me.Region = formRegion
    End Sub

    Private Sub TopPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        isMouseDown = True
        lastPos = e.Location
    End Sub

    Private Sub TopPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove
        If (isMouseDown) Then
            Me.Location = New Point((Me.Location.X - lastPos.X) + e.X, (Me.Location.Y - lastPos.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub TopPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp
        isMouseDown = False
    End Sub

    Private Sub MainForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        'Dim interval As Double = Stopwatch.Frequency / 30.0
        ' Me.Invalidate()
        'Application.DoEvents()
        'System.Threading.Thread.Sleep(1000)
        'MsgBox("Hello_1")
        'System.Threading.Thread.Sleep(1000)
        'MsgBox("Hello_2")
        'System.Threading.Thread.Sleep(1000)
        'MsgBox("Hello_3")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CloseButton_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover
        'setControlButtonColor(CloseButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.Transparent
    End Sub

    Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter
        setControlButtonColor(CloseButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub CloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown
        setControlButtonColor(CloseButton, GUI.Default.CTRL_BTNS_PRESS_COLOR)
    End Sub

    Private Sub CloseButton_MouseMove(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseMove
        'setControlButtonColor(CloseButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub CloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseUp
        setControlButtonColor(CloseButton, Color.Transparent)
    End Sub

    Private Sub setControlButtonColor(button As Object, color As Color)
        button.BackColor = color
    End Sub

    Private Sub MaximizeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MaximizeButton.MouseDown
        setControlButtonColor(MaximizeButton, GUI.Default.CTRL_BTNS_PRESS_COLOR)
    End Sub

    Private Sub MaximizeButton_MouseEnter(sender As Object, e As EventArgs) Handles MaximizeButton.MouseEnter
        setControlButtonColor(MaximizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MaximizeButton_MouseHover(sender As Object, e As EventArgs) Handles MaximizeButton.MouseHover
        'setControlButtonColor(MaximizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MaximizeButton_MouseLeave(sender As Object, e As EventArgs) Handles MaximizeButton.MouseLeave
        setControlButtonColor(MaximizeButton, Color.Transparent)
    End Sub

    Private Sub MaximizeButton_MouseMove(sender As Object, e As MouseEventArgs) Handles MaximizeButton.MouseMove
        'setControlButtonColor(MaximizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MaximizeButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MaximizeButton.MouseUp
        setControlButtonColor(MaximizeButton, Color.Transparent)
    End Sub

    Private Sub MinimizeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseDown
        setControlButtonColor(MinimizeButton, GUI.Default.CTRL_BTNS_PRESS_COLOR)
    End Sub

    Private Sub MinimizeButton_MouseEnter(sender As Object, e As EventArgs) Handles MinimizeButton.MouseEnter
        setControlButtonColor(MinimizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MinimizeButton_MouseHover(sender As Object, e As EventArgs) Handles MinimizeButton.MouseHover
        'setControlButtonColor(MinimizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MinimizeButton_MouseLeave(sender As Object, e As EventArgs) Handles MinimizeButton.MouseLeave
        setControlButtonColor(MinimizeButton, Color.Transparent)
    End Sub

    Private Sub MinimizeButton_MouseMove(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseMove
        'setControlButtonColor(MinimizeButton, GUI.Default.CTRL_BTNS_HOVER_COLOR)
    End Sub

    Private Sub MinimizeButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseUp
        setControlButtonColor(MinimizeButton, Color.Transparent)
    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        formResize()
    End Sub

    Private Sub formResize()
        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Normal
            MaximizeButton.BackgroundImage = My.Resources.maximize_button
        ElseIf (Me.WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
            MaximizeButton.BackgroundImage = My.Resources.restore_windows_button
        End If
    End Sub

    Private Sub TopPanel_DoubleClick(sender As Object, e As EventArgs) Handles TopPanel.DoubleClick
        formResize()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LyricsView_HScroll(sender As Object, e As EventArgs)
        Console.WriteLine("HSCROLL, sender = " & sender.ToString())
    End Sub

    Private Sub LyricsView_VScroll(sender As Object, e As EventArgs)
        Console.WriteLine("VSCROLL, sender = " & sender.ToString())
    End Sub

End Class