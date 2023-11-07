Public Class Form1

    Public newX As Single
    Public newY As Single

    Public vPens As Pen
    Public centerX, centerY, currentX, currentY, lastX, lastY As Integer


    Public penColor As Pen



    Private Sub TempGButton_Click(sender As Object, e As EventArgs) Handles TempGButton.Click

        Dim loopX As Integer
        Dim tempF As Double
        Dim graphF As Integer
        Dim inv As Integer
        Dim minTemp As Integer
        Dim maxTemp As Integer
        Dim range As Integer
        Dim scale As Integer
        Dim offset As Integer
        Dim sc As Integer


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


        Hdivisions()



        Do Until loopX > PictureBox1.Size.Width
            tempF = (Rnd() * 100) + 32

            Label1.Text = CInt(tempF)

            If loopX = 0 Then
                MaxLabel.Text = CInt(tempF)
                MinLabel.Text = Fix(tempF)
            Else
                If tempF < lastX Then
                    MinLabel.Text = CInt(tempF)
                    ' minTemp = PictureBox1.Height - CInt(tempF)
                    minTemp = CInt(tempF)
                End If
                If tempF > lastX Then
                    MaxLabel.Text = Fix(tempF)
                    ' maxTemp = PictureBox1.Height - CInt(tempF)
                    maxTemp = CInt(tempF)
                End If
            End If

            inv = PictureBox1.Height - CInt(tempF)
            InvtertLabel.Text = inv
            range = (maxTemp + 5) - (minTemp - 5)
            'range = (minTemp + 5) - (maxTemp - 5) '137 - 27
            RangeLabel.Text = range
            If range = 0 Then
                scale = PictureBox1.Height / (range + 1)
            ElseIf range <> 0 Then
                scale = PictureBox1.Height / range
            End If

            ScaleLabel.Text = scale

            'If maxTemp = 0 Then
            '    sc = PictureBox1.Height
            'ElseIf maxTemp <> 0 Then
            '    sc = PictureBox1.Height / maxTemp
            'End If


            offset = PictureBox1.Height / 4
            OffsetLabel.Text = offset

            graphF = ((inv / scale)) + offset
            Label2.Text = graphF

            PictureBox1.CreateGraphics.DrawLine(Pens.DarkSeaGreen, lastX, lastY, loopX, graphF)
            lastX = loopX

            loopX += (PictureBox1.Width / 96)
            lastY = graphF
        Loop




    End Sub
    Private Sub ArrayButton_Click(sender As Object, e As EventArgs) Handles ArrayButton.Click
        Dim record(95) As Integer
        Dim loopX As Integer
        Dim tempF As Double
        Dim graphF As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()
        Hdivisions()
        For i = 0 To 95
            Do Until loopX > PictureBox1.Width

                tempF = CInt((Rnd() * 100) + 32)

                record(i) = tempF
                Label1.Text = tempF
                graphF = PictureBox1.Height - tempF
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

                lastY = graphF

            Loop
        Next
    End Sub
    Sub Hdivisions()
        Dim hC As Integer
        Dim hMax As Integer
        Dim hMin As Integer
        Dim h1 As Integer
        Dim h2 As Integer



        hC = PictureBox1.Height * 0.5
        HcenterLabel.Text = hC
        penColor = Pens.Gray
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hC, PictureBox1.Width, hC)

        h1 = PictureBox1.Height * 0.75
        h1Label.Text = h1
        penColor = Pens.LightBlue
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, h1, PictureBox1.Width, h1)

        h2 = PictureBox1.Height * 0.25
        h2Label.Text = h2
        penColor = Pens.Orange
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, h2, PictureBox1.Width, h2)

        hMax = PictureBox1.Height - 5
        HBottomLabel.Text = hMax
        penColor = Pens.Blue
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hMax, PictureBox1.Width, hMax)

        hMin = 5
        HtopLabel.Text = hMin
        penColor = Pens.Red
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hMin, PictureBox1.Width, hMin)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
