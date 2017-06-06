Public Class UtilsGUI

    Public Sub makeBorder(_element As Control, _graphics As Graphics, _color As Color, _borderWidth As Integer)
        Dim x As Integer = _borderWidth / 2
        Dim y As Integer = _borderWidth / 2
        Dim width As Integer = _element.Size.Width - _borderWidth
        Dim height As Integer = _element.Size.Height - _borderWidth

        Dim g As Graphics = If(_element.Name = MainForm.Name, _graphics, _element.CreateGraphics())

        g.DrawRectangle(New Pen(_color, _borderWidth), New Rectangle(x, y, width, height))
    End Sub

    Public Sub translateInParent(_control As Control, _lastPos As Point, _newPos As Point)
        Dim nx As Integer = Math.Min(Math.Max(_control.Left + (_newPos.X - _lastPos.X), 0), _control.Parent.Width - _control.Width)
        Dim ny As Integer = Math.Min(Math.Max(_control.Top + (_newPos.Y - _lastPos.Y), 0), _control.Parent.Height - _control.Height)
        _control.Location = New Point(nx, ny)
    End Sub

End Class
