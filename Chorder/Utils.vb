Public Class Utils

    Private Class Key
        Private key As String

        Public Shared ReadOnly C As Key = New Key("C")
        Public Shared ReadOnly CSharp As Key = New Key("C#")
        Public Shared ReadOnly D As Key = New Key("D")
        Public Shared ReadOnly DSharp As Key = New Key("D#")
        Public Shared ReadOnly E As Key = New Key("E")
        Public Shared ReadOnly F As Key = New Key("F")
        Public Shared ReadOnly FSharp As Key = New Key("F#")
        Public Shared ReadOnly G As Key = New Key("G")
        Public Shared ReadOnly GSharp As Key = New Key("G#")
        Public Shared ReadOnly A As Key = New Key("A")
        Public Shared ReadOnly ASharp As Key = New Key("A#")
        Public Shared ReadOnly H As Key = New Key("H")

        Private Sub New(_key As String)
            Me.key = _key
        End Sub

        Public Overrides Function ToString() As String
            Return Me.key
        End Function

        Public Shared Operator <>(ByVal key1 As Key, ByVal key2 As Key)
            Return key1.ToString() <> key2.ToString()
        End Operator

        Public Shared Operator =(ByVal key1 As Key, ByVal key2 As Key)
            Return key1.ToString() = key2.ToString()
        End Operator

    End Class

    Private keys As Key() = {Key.C, Key.CSharp, Key.D, Key.DSharp, Key.E, Key.F, Key.FSharp, Key.G, Key.GSharp, Key.A, Key.ASharp, Key.H}

    Private Function getKey(keyName As String) As Key
        Select Case keyName
            Case Key.C.ToString()
                Return Key.C
            Case Key.CSharp.ToString()
                Return Key.CSharp
            Case Key.D.ToString()
                Return Key.D
            Case Key.DSharp.ToString()
                Return Key.DSharp
            Case Key.E.ToString()
                Return Key.E
            Case Key.F.ToString()
                Return Key.F
            Case Key.FSharp.ToString()
                Return Key.FSharp
            Case Key.G.ToString()
                Return Key.G
            Case Key.GSharp.ToString()
                Return Key.GSharp
            Case Key.A.ToString()
                Return Key.A
            Case Key.ASharp.ToString()
                Return Key.ASharp
            Case Key.H.ToString()
                Return Key.H
            Case Else
                Return Key.C
        End Select
    End Function

    Function transpose(root As String, transposeValue As Integer) As String
        Dim rootIndex As Integer = 0
        Dim key As Key = getKey(root)
        Select Case key
            Case Key.C
                rootIndex = 0
            Case Key.CSharp
                rootIndex = 1
            Case Key.D
                rootIndex = 2
            Case Key.DSharp
                rootIndex = 3
            Case Key.E
                rootIndex = 4
            Case Key.F
                rootIndex = 5
            Case Key.FSharp
                rootIndex = 6
            Case Key.G
                rootIndex = 7
            Case Key.GSharp
                rootIndex = 8
            Case Key.A
                rootIndex = 9
            Case Key.ASharp
                rootIndex = 10
            Case Key.H
                rootIndex = 11
        End Select

        Dim transposeIndex As Integer

        If (rootIndex + transposeValue < 0) Then
            transposeIndex = (rootIndex + transposeValue) Mod 12 + 12
        Else
            transposeIndex = (rootIndex + transposeValue) Mod 12
        End If

        Return keys(transposeIndex).ToString()

    End Function

    Private Class Chord
        Private startPos As Integer
        Private endPos As Integer
        Private root As String
        Private add As String

        Public Sub New(_startPos As Integer, _endPos As Integer, _root As String, Optional _add As String = "")
            startPos = _startPos
            endPos = _endPos
            root = _root
            add = _add
        End Sub

    End Class

    Private Class ChordsTable

        Private chords As List(Of Chord)

    End Class

    Public Function parseChords(source As String) As String

        Dim result As String = source

        Dim isChordMatch As Boolean = False
        Dim currentChord As String = ""
        Dim chords As New List(Of String)

        For index As Integer = 0 To result.Length - 1
            Dim _char As Char = result.ElementAt(index)
            If isChordMatch = True Then
                If (System.Text.RegularExpressions.Regex.IsMatch(_char, "^[a-zA-Z0-9_#]+$")) Then
                    currentChord += _char
                Else
                    chords.Add(currentChord)
                    currentChord = ""
                    isChordMatch = False
                End If
            ElseIf _char = "*" Then
                isChordMatch = True
            End If
        Next

        result = result.Replace("*", "")

        Return result

    End Function

End Class

