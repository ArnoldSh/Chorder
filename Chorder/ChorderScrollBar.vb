Public Class ChorderScrollBar

    Public Property ParentView() As Control
        Get
            Return Me._parentView
        End Get
        Set(value As Control)
            Me._parentView = value
        End Set
    End Property

    Private _parentView As Control

    Private minBarHeight As Integer = 16

    Private _utilsGUI As UtilsGUI = New UtilsGUI()

    Private isMouseDownOnScrollBar As Boolean = False

    Private isMouseDownOnArrowUp As Boolean = False
    Private isMouseDownOnArrowDown As Boolean = False
    Private lastPos As Point

    Private lastContainerHeight As Integer

    'Friend WithEvents continuousScrollController As Timer = New Timer()

    ' value thats represents how many percents of original VIEW is VISIBLE - it's neccessary for correct scrolling
    ' for example, if scaleFactor == 0.5 => it means that VIEW shows only 50% of original content
    ' and therefore in dependency of scale factor it have to resize scroll bar HEIGHT
    ' in MS VS even if content fully displayed in window scroll bar has some 'reserved' movable space
    Private scaleFactor As Double = 0.5

    Private minDistance As Integer = 10 ' minimal distance between scroll bar and up/down buttons
    Private minStep As Integer = 5

    Public Event _ScrollDownEvent As ScrollEventHandler
    Public Event _ScrollUpEvent As ScrollEventHandler

    Public Event _ScrollOnTop As EventHandler
    Public Event _ScrollOnBottom As EventHandler

    ' timing vars (ms)
    Private INIT_DELAY As Integer = 500
    Private SCROLLING_DELAY As Integer = 25

    Private WithEvents timer As Timer = New Timer()

    Private arrowButtonsBorderWidth = 1

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Me.SetStyle(ControlStyles.ResizeRedraw, True)

        Me.ScrollBar.BackColor = GUI.Default.SCROLL_BAR_COLOR
        Me.ArrowUp.BackColor = GUI.Default.SCROLL_ARROW_COLOR
        Me.ArrowDown.BackColor = GUI.Default.SCROLL_ARROW_COLOR
        timer.Interval = INIT_DELAY

        ' init scroll bar
        'ScrollBar.Location = New Point(ScrollBar.Location.X, ScrollBar.Location.Y + minDistance)

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        _utilsGUI.makeBorder(Me, e.Graphics, GUI.Default.MAIN_BORDER_COLOR, 1)
        MyBase.OnPaint(e)




        '_utilsGUI.makeBorder(Me.ArrowDown, e.Graphics, GUI.Default.MAIN_BORDER_COLOR, 1)
        '_utilsGUI.makeBorder(Me.ArrowUp, e.Graphics, GUI.Default.MAIN_BORDER_COLOR, 1)
        '_utilsGUI.makeBorder(Me.ScrollBar, e.Graphics, GUI.Default.MAIN_BORDER_COLOR, 1)

        ' autosize width of bar
        ScrollBar.Width = ScrollBarContainer.Width
        'If (isScrollBarLower() = True) Then
        '    scrollBarUp()
        'ElseIf (isScrollBarAbove() = True) Then
        '    scrollBarDown()
        'End If

        'Console.WriteLine("")
        'Console.WriteLine("Parent = " & ScrollBar.Parent.Name)
        'Console.WriteLine("Top = " & ScrollBar.Top.ToString())
        'Console.WriteLine("Bottom = " & ScrollBar.Bottom.ToString())

        'Console.WriteLine("Bottom - Top = " & (ScrollBar.Bottom - ScrollBar.Top).ToString())
        'Console.WriteLine("ParentHeight = " & ScrollBarContainer.Height.ToString())

        'Console.WriteLine("bottom distance = " & getBottomDistance().ToString())

        'Console.WriteLine("Parent, height = " & ScrollBarContainer.Height.ToString())

    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        ' autosize width of bar
        'ScrollBar.Width = ScrollBarContainer.Width

        'Console.WriteLine("OnSizeChanged, Me.Height = " & Me.Height)

        Dim delta As Double = ScrollBarContainer.Height / lastContainerHeight

        Console.WriteLine("DELTA = " & delta)

        If (isScrollBarLower() = True) Then
            While (isScrollBarLower() = True)
                ScrollBar.Location = New Point(ScrollBar.Location.X, ScrollBar.Location.Y - 1)
            End While
        ElseIf (isScrollBarAbove() = True) Then
            While (isScrollBarAbove() = True)
                ScrollBar.Location = New Point(ScrollBar.Location.X, ScrollBar.Location.Y + 1)
            End While
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        lastContainerHeight = ScrollBarContainer.Height
        MyBase.OnResize(e)
        'Console.WriteLine("OnResize, Me.Height = " & Me.Height)

    End Sub

    Public Sub scaleScrollBar()

    End Sub

    Private Function getTopDistance() As Integer
        getTopDistance = ScrollBar.Top
    End Function
    Private Function getBottomDistance() As Integer
        getBottomDistance = ScrollBarContainer.Height - ScrollBar.Bottom
    End Function


    Private Sub ScrollBar_MouseEnter(sender As Object, e As EventArgs) Handles ScrollBar.MouseEnter
        Me.ScrollBar.BackColor = GUI.Default.SCROLL_BAR_HOVER_COLOR
    End Sub

    Private Sub ScrollBar_MouseLeave(sender As Object, e As EventArgs) Handles ScrollBar.MouseLeave
        Me.ScrollBar.BackColor = GUI.Default.SCROLL_BAR_COLOR
    End Sub

    Private Sub ScrollBar_MouseDown(sender As Object, e As MouseEventArgs) Handles ScrollBar.MouseDown
        Me.ScrollBar.BackColor = GUI.Default.SCROLL_BAR_MOUSE_DOWN_COLOR
        isMouseDownOnScrollBar = True
        lastPos = New Point(e.Location)
    End Sub

    Private Sub ScrollBar_MouseMove(sender As Object, e As MouseEventArgs) Handles ScrollBar.MouseMove
        If (isMouseDownOnScrollBar) Then
            If (e.Y > lastPos.Y) Then
                If (e.Y - lastPos.Y >= minStep) Then
                    scrollBarDown()
                End If
            Else
                If (lastPos.Y - e.Y >= minStep) Then
                    scrollBarUp()
                End If
            End If
        End If
    End Sub

    Private Sub ScrollBar_MouseUp(sender As Object, e As MouseEventArgs) Handles ScrollBar.MouseUp
        Me.ScrollBar.BackColor = GUI.Default.SCROLL_BAR_HOVER_COLOR
        isMouseDownOnScrollBar = False
    End Sub

    Private Sub ArrowUp_MouseEnter(sender As Object, e As EventArgs) Handles ArrowUp.MouseEnter
        Me.ArrowUp.BackColor = GUI.Default.SCROLL_ARROW_HOVER_COLOR
    End Sub

    Private Sub ArrowUp_MouseLeave(sender As Object, e As EventArgs) Handles ArrowUp.MouseLeave
        Me.ArrowUp.BackColor = GUI.Default.SCROLL_ARROW_COLOR
    End Sub

    Private Sub ArrowUp_MouseUp(sender As Object, e As MouseEventArgs) Handles ArrowUp.MouseUp
        isMouseDownOnArrowUp = False
        Me.ArrowUp.BackColor = GUI.Default.SCROLL_ARROW_HOVER_COLOR
        timer.Stop()
        timer.Interval = INIT_DELAY
    End Sub

    Private Sub ArrowUp_MouseDown(sender As Object, e As MouseEventArgs) Handles ArrowUp.MouseDown
        isMouseDownOnArrowUp = True
        Me.ArrowUp.BackColor = GUI.Default.SCROLL_ARROW_MOUSE_DOWN_COLOR
        scrollBarUp()
        timer.Start()
    End Sub

    Private Sub ArrowDown_MouseUp(sender As Object, e As MouseEventArgs) Handles ArrowDown.MouseUp
        isMouseDownOnArrowDown = False
        Me.ArrowDown.BackColor = GUI.Default.SCROLL_ARROW_HOVER_COLOR
        timer.Stop()
        timer.Interval = INIT_DELAY
    End Sub

    Private Sub ArrowDown_MouseDown(sender As Object, e As MouseEventArgs) Handles ArrowDown.MouseDown
        isMouseDownOnArrowDown = True
        Me.ArrowDown.BackColor = GUI.Default.SCROLL_ARROW_MOUSE_DOWN_COLOR
        scrollBarDown()
        timer.Start()
    End Sub

    Private Sub tickHandle(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        timer.Interval = SCROLLING_DELAY
        If (isMouseDownOnArrowDown) Then
            scrollBarDown()
        ElseIf (isMouseDownOnArrowUp) Then
            scrollBarUp()
        End If
    End Sub

    Private Sub ArrowDown_MouseEnter(sender As Object, e As EventArgs) Handles ArrowDown.MouseEnter
        Me.ArrowDown.BackColor = GUI.Default.SCROLL_ARROW_HOVER_COLOR
    End Sub

    Private Sub ArrowDown_MouseLeave(sender As Object, e As EventArgs) Handles ArrowDown.MouseLeave
        Me.ArrowDown.BackColor = GUI.Default.SCROLL_ARROW_COLOR
    End Sub

    Private Sub scrollBarUp()
        Dim _step As Integer = getStepUp()
        If (_step <> 0) Then
            Dim newY As Integer = Math.Min(Math.Max(ScrollBar.Top - _step, 0 + minDistance), ScrollBar.Parent.Height - ScrollBar.Height - minDistance)
            ScrollBar.Location = New Point(ScrollBar.Location.X, newY)
            RaiseEvent _ScrollUpEvent(ParentView, New ScrollEventArgs(ScrollEventType.SmallDecrement, -1))
        End If
    End Sub

    Private Sub scrollBarDown()
        Dim _step As Integer = getStepDown()
        If (_step <> 0) Then
            Dim newY As Integer = Math.Min(Math.Max(ScrollBar.Top + _step, 0 + minDistance), ScrollBar.Parent.Height - ScrollBar.Height - minDistance)
            ScrollBar.Location = New Point(ScrollBar.Location.X, newY)
            RaiseEvent _ScrollDownEvent(ParentView, New ScrollEventArgs(ScrollEventType.SmallIncrement, 1))
        End If
    End Sub

    Private Function isScrollBarOnTop() As Boolean
        isScrollBarOnTop = getTopDistance() = minDistance
    End Function

    Private Function isScrollBarOnBottom() As Boolean
        isScrollBarOnBottom = getBottomDistance() = minDistance
    End Function

    Private Function isScrollBarAbove() As Boolean
        isScrollBarAbove = getTopDistance() < minDistance
    End Function

    Private Function isScrollBarLower() As Boolean
        isScrollBarLower = getBottomDistance() < minDistance
    End Function

    Private Function getStepDown() As Integer
        Dim bottom As Integer = getBottomDistance()
        If (bottom >= minDistance) Then
            getStepDown = minStep
        Else
            getStepDown = minDistance - bottom
        End If

    End Function

    Private Function getStepUp() As Integer
        Dim top As Integer = getTopDistance()
        If (top >= minDistance) Then
            getStepUp = minStep
        Else
            getStepUp = minDistance - top
        End If

    End Function

    Private Sub _hUp(sender As Control, e As ScrollEventArgs) Handles Me._ScrollUpEvent
        'Console.WriteLine("_ScrollUpEvent fired")
        If (isScrollBarOnTop() = True) Then
            RaiseEvent _ScrollOnTop(Me, New EventArgs())
        End If
    End Sub
    Private Sub _hDown(sender As Control, e As ScrollEventArgs) Handles Me._ScrollDownEvent
        'Console.WriteLine("_ScrollDownEvent fired")
        If (isScrollBarOnBottom() = True) Then
            RaiseEvent _ScrollOnBottom(Me, New EventArgs())
        End If
    End Sub

    Private Sub _hTop(sender As Control, e As EventArgs) Handles Me._ScrollOnTop
        'Console.WriteLine("_ScrollOnTop fired")
    End Sub

    Private Sub _hBottom(sender As Control, e As EventArgs) Handles Me._ScrollOnBottom
        'Console.WriteLine("_ScrollOnBottom fired")
    End Sub

End Class
