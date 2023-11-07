Public Class Form1

    Public newX As Single
    Public newY As Single

    Public vPens As Pen
    Public centerX, centerY, currentX, currentY, lastX, lastY As Integer


    Private Sub TempGButton_Click(sender As Object, e As EventArgs) Handles TempGButton.Click

        Dim loopX As Integer
        Dim tempF As Double
        Dim graphF As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()
        'centerX = PictureBox1.Size.Width / 2
        ' centerY = PictureBox1.Size.Height / 2
        'Period = centerX
        'lastX = 0
        ' lastY = centerY
        'pi2 = (2 * Math.PI)
        'Vp = centerY / 2
        'stepX = centerX / 360

        Do Until loopX > PictureBox1.Size.Width
            tempF = (Rnd() * 100) + 32

            Label1.Text = CInt(tempF)

            graphF = -CInt(tempF)

            Label2.Text = CInt(graphF)

            PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, loopX, CInt(tempF))
            'PictureBox1.CreateGraphics.DrawLine(Pens.DarkSeaGreen, lastX, lastY, loopX, graphF)
            lastX = loopX

            loopX += (PictureBox1.Width / 96)

            lastY = tempF
        Loop




    End Sub
    Private Sub ArrayButton_Click(sender As Object, e As EventArgs) Handles ArrayButton.Click
        Dim record(95) As Integer
        Dim x As Double
        Dim loopX As Integer
        Dim tempF As Double
        Dim graphF As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()
        For i = 0 To 95
            Do Until loopX > PictureBox1.Width

                tempF = CInt((Rnd() * 100) + 32)

                record(i) = tempF
                Label1.Text = tempF
                graphF = PictureBox1.Height - tempF ' 132 - tempF
                Label2.Text = graphF

                If loopX = 0 Then
                    MaxLabel.Text = tempF
                    MinLabel.Text = tempF
                Else
                    If tempF < lastX Then
                        MinLabel.Text = tempF

                    End If
                    If tempF > lastX Then
                        MaxLabel.Text = tempF

                    End If
                End If

                PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, loopX, graphF)

                lastX = loopX

                loopX += (PictureBox1.Width / 96)

                lastY = tempF

            Loop
        Next
    End Sub

    Public penColor As Pen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
