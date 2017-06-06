<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CloseButton
    Inherits System.Windows.Forms.Panel

    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Chorder.My.Resources.Resources.close_button
        Me.Size = New System.Drawing.Size(20, 20)
        Me.ResumeLayout(False)

    End Sub
End Class

