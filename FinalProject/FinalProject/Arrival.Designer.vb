<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arrival
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
        Me.lstRoutes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRouteName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRouteTime = New System.Windows.Forms.TextBox()
        Me.txtTimeInDock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstRoutes
        '
        Me.lstRoutes.FormattingEnabled = True
        Me.lstRoutes.ItemHeight = 25
        Me.lstRoutes.Location = New System.Drawing.Point(12, 78)
        Me.lstRoutes.Name = "lstRoutes"
        Me.lstRoutes.Size = New System.Drawing.Size(824, 479)
        Me.lstRoutes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Normal Routes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Routes"
        '
        'txtRouteName
        '
        Me.txtRouteName.Location = New System.Drawing.Point(193, 666)
        Me.txtRouteName.Name = "txtRouteName"
        Me.txtRouteName.Size = New System.Drawing.Size(202, 31)
        Me.txtRouteName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 669)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Route Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 713)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Route Time"
        '
        'txtRouteTime
        '
        Me.txtRouteTime.Location = New System.Drawing.Point(193, 710)
        Me.txtRouteTime.Name = "txtRouteTime"
        Me.txtRouteTime.Size = New System.Drawing.Size(202, 31)
        Me.txtRouteTime.TabIndex = 6
        '
        'txtTimeInDock
        '
        Me.txtTimeInDock.Location = New System.Drawing.Point(269, 757)
        Me.txtTimeInDock.Name = "txtTimeInDock"
        Me.txtTimeInDock.Size = New System.Drawing.Size(126, 31)
        Me.txtTimeInDock.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 760)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time allowed in dock"
        '
        'Arrival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 821)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTimeInDock)
        Me.Controls.Add(Me.txtRouteTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRouteName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRoutes)
        Me.Name = "Arrival"
        Me.Text = "Arrival"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRoutes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRouteName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRouteTime As TextBox
    Friend WithEvents txtTimeInDock As TextBox
    Friend WithEvents Label5 As Label
End Class
