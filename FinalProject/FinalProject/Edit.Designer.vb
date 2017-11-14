<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEditTimeInDock = New System.Windows.Forms.TextBox()
        Me.txtEditRouteTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEditRouteName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEditRoutes = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 700)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Time allowed in dock"
        '
        'txtEditTimeInDock
        '
        Me.txtEditTimeInDock.Location = New System.Drawing.Point(225, 697)
        Me.txtEditTimeInDock.Name = "txtEditTimeInDock"
        Me.txtEditTimeInDock.Size = New System.Drawing.Size(126, 31)
        Me.txtEditTimeInDock.TabIndex = 16
        '
        'txtEditRouteTime
        '
        Me.txtEditRouteTime.Location = New System.Drawing.Point(149, 650)
        Me.txtEditRouteTime.Name = "txtEditRouteTime"
        Me.txtEditRouteTime.Size = New System.Drawing.Size(202, 31)
        Me.txtEditRouteTime.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 653)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Route Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 609)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Route Name"
        '
        'txtEditRouteName
        '
        Me.txtEditRouteName.Location = New System.Drawing.Point(149, 606)
        Me.txtEditRouteName.Name = "txtEditRouteName"
        Me.txtEditRouteName.Size = New System.Drawing.Size(202, 31)
        Me.txtEditRouteName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select route to be edited"
        '
        'lstEditRoutes
        '
        Me.lstEditRoutes.FormattingEnabled = True
        Me.lstEditRoutes.ItemHeight = 25
        Me.lstEditRoutes.Location = New System.Drawing.Point(12, 54)
        Me.lstEditRoutes.Name = "lstEditRoutes"
        Me.lstEditRoutes.Size = New System.Drawing.Size(824, 479)
        Me.lstEditRoutes.TabIndex = 9
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 548)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(139, 37)
        Me.btnSelect.TabIndex = 18
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 827)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEditTimeInDock)
        Me.Controls.Add(Me.txtEditRouteTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEditRouteName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEditRoutes)
        Me.Name = "Edit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtEditTimeInDock As TextBox
    Friend WithEvents txtEditRouteTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEditRouteName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstEditRoutes As ListBox
    Friend WithEvents btnSelect As Button
End Class
