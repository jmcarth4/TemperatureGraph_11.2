<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinLabel = New System.Windows.Forms.Label()
        Me.MaxLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TempGButton = New System.Windows.Forms.Button()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HcenterLabel = New System.Windows.Forms.Label()
        Me.HtopLabel = New System.Windows.Forms.Label()
        Me.h2Label = New System.Windows.Forms.Label()
        Me.h1Label = New System.Windows.Forms.Label()
        Me.HBottomLabel = New System.Windows.Forms.Label()
        Me.ScaleLabel = New System.Windows.Forms.Label()
        Me.InvtertLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OffsetLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RangeLabel = New System.Windows.Forms.Label()
        Me.DataButton = New System.Windows.Forms.Button()
        Me.MaxMinButton = New System.Windows.Forms.Button()
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GraphInButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(1096, 433)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(89, 36)
        Me.QuitButton.TabIndex = 0
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(87, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(823, 274)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MinLabel
        '
        Me.MinLabel.AutoSize = True
        Me.MinLabel.Location = New System.Drawing.Point(660, 359)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(34, 20)
        Me.MinLabel.TabIndex = 2
        Me.MinLabel.Text = "Min"
        '
        'MaxLabel
        '
        Me.MaxLabel.AutoSize = True
        Me.MaxLabel.Location = New System.Drawing.Point(731, 359)
        Me.MaxLabel.Name = "MaxLabel"
        Me.MaxLabel.Size = New System.Drawing.Size(38, 20)
        Me.MaxLabel.TabIndex = 3
        Me.MaxLabel.Text = "Max"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "value"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'TempGButton
        '
        Me.TempGButton.Location = New System.Drawing.Point(1, 433)
        Me.TempGButton.Name = "TempGButton"
        Me.TempGButton.Size = New System.Drawing.Size(81, 36)
        Me.TempGButton.TabIndex = 5
        Me.TempGButton.Text = "Graph Temperature"
        Me.TempGButton.UseVisualStyleBackColor = True
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(531, 326)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(113, 70)
        Me.TestButton.TabIndex = 6
        Me.TestButton.Text = "Test Graph Stuff"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 431)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "graphed value"
        '
        'HcenterLabel
        '
        Me.HcenterLabel.AutoSize = True
        Me.HcenterLabel.Location = New System.Drawing.Point(-3, 149)
        Me.HcenterLabel.Name = "HcenterLabel"
        Me.HcenterLabel.Size = New System.Drawing.Size(54, 20)
        Me.HcenterLabel.TabIndex = 8
        Me.HcenterLabel.Text = "center"
        '
        'HtopLabel
        '
        Me.HtopLabel.AutoSize = True
        Me.HtopLabel.Location = New System.Drawing.Point(-3, 29)
        Me.HtopLabel.Name = "HtopLabel"
        Me.HtopLabel.Size = New System.Drawing.Size(32, 20)
        Me.HtopLabel.TabIndex = 9
        Me.HtopLabel.Text = "top"
        '
        'h2Label
        '
        Me.h2Label.AutoSize = True
        Me.h2Label.Location = New System.Drawing.Point(-3, 85)
        Me.h2Label.Name = "h2Label"
        Me.h2Label.Size = New System.Drawing.Size(45, 20)
        Me.h2Label.TabIndex = 10
        Me.h2Label.Text = ".25%"
        '
        'h1Label
        '
        Me.h1Label.AutoSize = True
        Me.h1Label.Location = New System.Drawing.Point(-3, 208)
        Me.h1Label.Name = "h1Label"
        Me.h1Label.Size = New System.Drawing.Size(45, 20)
        Me.h1Label.TabIndex = 11
        Me.h1Label.Text = ".75%"
        '
        'HBottomLabel
        '
        Me.HBottomLabel.AutoSize = True
        Me.HBottomLabel.Location = New System.Drawing.Point(-3, 267)
        Me.HBottomLabel.Name = "HBottomLabel"
        Me.HBottomLabel.Size = New System.Drawing.Size(59, 20)
        Me.HBottomLabel.TabIndex = 12
        Me.HBottomLabel.Text = "bottom"
        '
        'ScaleLabel
        '
        Me.ScaleLabel.AutoSize = True
        Me.ScaleLabel.Location = New System.Drawing.Point(223, 375)
        Me.ScaleLabel.Name = "ScaleLabel"
        Me.ScaleLabel.Size = New System.Drawing.Size(49, 20)
        Me.ScaleLabel.TabIndex = 13
        Me.ScaleLabel.Text = "Scale"
        '
        'InvtertLabel
        '
        Me.InvtertLabel.AutoSize = True
        Me.InvtertLabel.Location = New System.Drawing.Point(223, 326)
        Me.InvtertLabel.Name = "InvtertLabel"
        Me.InvtertLabel.Size = New System.Drawing.Size(49, 20)
        Me.InvtertLabel.TabIndex = 14
        Me.InvtertLabel.Text = "Invert"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Invert"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Scale"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "graphed value"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Offset"
        '
        'OffsetLabel
        '
        Me.OffsetLabel.AutoSize = True
        Me.OffsetLabel.Location = New System.Drawing.Point(219, 395)
        Me.OffsetLabel.Name = "OffsetLabel"
        Me.OffsetLabel.Size = New System.Drawing.Size(53, 20)
        Me.OffsetLabel.TabIndex = 20
        Me.OffsetLabel.Text = "Offset"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Range"
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Location = New System.Drawing.Point(215, 351)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(57, 20)
        Me.RangeLabel.TabIndex = 22
        Me.RangeLabel.Text = "Range"
        '
        'DataButton
        '
        Me.DataButton.Location = New System.Drawing.Point(5, 314)
        Me.DataButton.Name = "DataButton"
        Me.DataButton.Size = New System.Drawing.Size(106, 45)
        Me.DataButton.TabIndex = 23
        Me.DataButton.Text = "Collect Data"
        Me.DataButton.UseVisualStyleBackColor = True
        '
        'MaxMinButton
        '
        Me.MaxMinButton.Location = New System.Drawing.Point(1, 366)
        Me.MaxMinButton.Name = "MaxMinButton"
        Me.MaxMinButton.Size = New System.Drawing.Size(113, 62)
        Me.MaxMinButton.TabIndex = 24
        Me.MaxMinButton.Text = "Find max and min"
        Me.MaxMinButton.UseVisualStyleBackColor = True
        '
        'DataListBox
        '
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.ItemHeight = 20
        Me.DataListBox.Location = New System.Drawing.Point(916, 23)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(201, 404)
        Me.DataListBox.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(660, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Min Temp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(744, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Max Temp"
        '
        'GraphInButton
        '
        Me.GraphInButton.Location = New System.Drawing.Point(302, 314)
        Me.GraphInButton.Name = "GraphInButton"
        Me.GraphInButton.Size = New System.Drawing.Size(114, 45)
        Me.GraphInButton.TabIndex = 28
        Me.GraphInButton.Text = "Graph Input"
        Me.GraphInButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 479)
        Me.Controls.Add(Me.GraphInButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataListBox)
        Me.Controls.Add(Me.MaxMinButton)
        Me.Controls.Add(Me.DataButton)
        Me.Controls.Add(Me.RangeLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.OffsetLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InvtertLabel)
        Me.Controls.Add(Me.ScaleLabel)
        Me.Controls.Add(Me.HBottomLabel)
        Me.Controls.Add(Me.h1Label)
        Me.Controls.Add(Me.h2Label)
        Me.Controls.Add(Me.HtopLabel)
        Me.Controls.Add(Me.HcenterLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.TempGButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaxLabel)
        Me.Controls.Add(Me.MinLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MinLabel As Label
    Friend WithEvents MaxLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TempGButton As Button
    Friend WithEvents TestButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents HcenterLabel As Label
    Friend WithEvents HtopLabel As Label
    Friend WithEvents h2Label As Label
    Friend WithEvents h1Label As Label
    Friend WithEvents HBottomLabel As Label
    Friend WithEvents ScaleLabel As Label
    Friend WithEvents InvtertLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OffsetLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RangeLabel As Label
    Friend WithEvents DataButton As Button
    Friend WithEvents MaxMinButton As Button
    Friend WithEvents DataListBox As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GraphInButton As Button
End Class
