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
        Me.ArrayButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HcenterLabel = New System.Windows.Forms.Label()
        Me.HtopLabel = New System.Windows.Forms.Label()
        Me.h2Label = New System.Windows.Forms.Label()
        Me.h1Label = New System.Windows.Forms.Label()
        Me.HBottomLabel = New System.Windows.Forms.Label()
        Me.ScaleLabel = New System.Windows.Forms.Label()
        Me.InvtertLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(727, 343)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(96, 52)
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
        Me.MinLabel.Location = New System.Drawing.Point(454, 359)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(34, 20)
        Me.MinLabel.TabIndex = 2
        Me.MinLabel.Text = "Min"
        '
        'MaxLabel
        '
        Me.MaxLabel.AutoSize = True
        Me.MaxLabel.Location = New System.Drawing.Point(566, 359)
        Me.MaxLabel.Name = "MaxLabel"
        Me.MaxLabel.Size = New System.Drawing.Size(38, 20)
        Me.MaxLabel.TabIndex = 3
        Me.MaxLabel.Text = "Max"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 323)
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
        Me.TempGButton.Location = New System.Drawing.Point(30, 343)
        Me.TempGButton.Name = "TempGButton"
        Me.TempGButton.Size = New System.Drawing.Size(81, 36)
        Me.TempGButton.TabIndex = 5
        Me.TempGButton.Text = "Graph Temperature"
        Me.TempGButton.UseVisualStyleBackColor = True
        '
        'ArrayButton
        '
        Me.ArrayButton.Location = New System.Drawing.Point(244, 309)
        Me.ArrayButton.Name = "ArrayButton"
        Me.ArrayButton.Size = New System.Drawing.Size(113, 70)
        Me.ArrayButton.TabIndex = 6
        Me.ArrayButton.Text = "Graph and store"
        Me.ArrayButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 403)
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
        Me.ScaleLabel.Location = New System.Drawing.Point(156, 375)
        Me.ScaleLabel.Name = "ScaleLabel"
        Me.ScaleLabel.Size = New System.Drawing.Size(49, 20)
        Me.ScaleLabel.TabIndex = 13
        Me.ScaleLabel.Text = "Scale"
        '
        'InvtertLabel
        '
        Me.InvtertLabel.AutoSize = True
        Me.InvtertLabel.Location = New System.Drawing.Point(156, 351)
        Me.InvtertLabel.Name = "InvtertLabel"
        Me.InvtertLabel.Size = New System.Drawing.Size(49, 20)
        Me.InvtertLabel.TabIndex = 14
        Me.InvtertLabel.Text = "Invert"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 432)
        Me.Controls.Add(Me.InvtertLabel)
        Me.Controls.Add(Me.ScaleLabel)
        Me.Controls.Add(Me.HBottomLabel)
        Me.Controls.Add(Me.h1Label)
        Me.Controls.Add(Me.h2Label)
        Me.Controls.Add(Me.HtopLabel)
        Me.Controls.Add(Me.HcenterLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ArrayButton)
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
    Friend WithEvents ArrayButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents HcenterLabel As Label
    Friend WithEvents HtopLabel As Label
    Friend WithEvents h2Label As Label
    Friend WithEvents h1Label As Label
    Friend WithEvents HBottomLabel As Label
    Friend WithEvents ScaleLabel As Label
    Friend WithEvents InvtertLabel As Label
End Class
