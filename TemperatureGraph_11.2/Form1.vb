﻿



Public Class Form1

    Public newX As Single
    Public newY As Single

    Public vPens As Pen
    Public centerX, centerY, currentX, currentY, lastX, lastY As Integer


    Public penColor As Pen

    Public data(95) As Double

    Public tempF As Double
    Public i As Integer                         'Sets index of array
    Dim minTemp As Integer
    Dim maxTemp As Integer
    Dim range As Integer

    Dim portState As Boolean                    'Enables serial communication
    Dim drivePath As String                     'Path to file
    Dim drivePath2 As String
    Dim fileName As String                      'Names file
    Dim fileName2 As String
    Dim dateTemp As String
    Dim timeTemp As String
    Dim both As String
    Dim port As String                          'Set port name
    Dim baud As String                          'Set baud rate


    Dim receiveByte(18) As Byte                 'Receive Data Bytes
    Public TXdata(3) As Byte                    'Byte array to transmit data to Qy@ board
    Dim vOut As String                          'Calculated voltage in for input
    Dim vInv As String                          'Inverted voltage of input
    Dim receiveCount, TransmitCount As Double
    Dim newData As Integer                       'Received data
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer  'Processes data in

    Sub CollectData()
        For i = 0 To 95
            data(i) = CInt((Rnd() * 100) + 32)
        Next

        DisplayArray()

    End Sub

    Sub DisplayArray()
        Dim loopCount As Integer        'Sets loop count of display loop.

        DataListBox.Items.Clear()                          'Clears listbox

        Do Until loopCount = 96 'recordLength 
            DataListBox.Items.Add(data(loopCount).ToString("n"))   'Displays array in listbox 
            loopCount = loopCount + 1
        Loop

        SaveFile()
    End Sub


    Sub SaveFile()
        Try
            FileOpen(1, Me.fileName2, OpenMode.Append) 'Open file for Append
        Catch ex As Exception

        End Try

        For i = 0 To 95
            WriteLine(1, data(i) & " " & dateTemp & " " & timeTemp)

            ' WriteLine(1, " ")
        Next


        FileClose(1)

    End Sub
    Sub ShiftArray(newRead As Double)
        If portState = True Then

            For i = LBound(data) To UBound(data) - 1
                data(i) = data(i + 1)
            Next
            data(95) = newRead
        Else portState = False
            For i = 0 To 95
                data(i) = 0
            Next

        End If



    End Sub



    'Establishs communication and displays received data from Qy@ board, analog input1
    Sub AnalogIn()
        TXdata(0) = 81                          'Send command for analog input 1
        TXdata(1) = 0
        TXdata(2) = 0
        SendData()                              'Calls function to send serial data
        AnVoltage()                             'Calls function to calcuate input voltage 
        VA1Label.Text = vOut & "V"                    'Display input voltage
    End Sub

    'Converts received byte 1 and 2 to binary value (0 to 1024) and voltage (0 to 3.3)
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double
        Dim vTemp As Double
        n1 = dataIn1 * 4
        n2 = dataIn2 / 64
        n3 = Fix(n1 + n2)               'Calcuated number of bits recieved
        n4 = 3.3 / 1023
        vPort = n4 * n3
        vTemp = vPort * 100
        vOut = Format(vPort, "n")       'Calculated voltage at input

        ShiftArray(vTemp)
    End Sub

    'Sends byte array to serial port
    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXdata, 0, 3)                    'Write byte array to serial port
        Else
            MsgBox("Please configure and open serial port to procede")      'Send user message box if no port connected
        End If
        Timer1.Enabled = True                                   'Enable timer when done

    End Function

    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        receiveCount += 1                                           'Increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                         'Read serial buffer value

        Select Case newData                                         'Test case to determine where to place info
            Case = 0

                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)

            Case Else
                newData = 0                                             'Possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                                    'Increment newData once loop is complete
    End Sub


    Sub MaxMin()
        Dim i As Integer
        Dim currentMin As Integer = 150
        Dim currentMax As Integer = -150



        For i = 0 To 95

            If data(i) < currentMin Then
                MinLabel.Text = data(i).ToString("n")

                minTemp = data(i)
                currentMin = data(i)
            End If
            If data(i) > currentMax Then
                MaxLabel.Text = data(i).ToString("n")

                maxTemp = data(i)
                currentMax = data(i)
            End If

        Next
        minTemp = MinLabel.Text
        maxTemp = MaxLabel.Text
    End Sub
    Sub Graph()
        Dim loopX As Integer
        Dim tempF As Double
        Dim graphF As Integer
        Dim inv As Integer
        Dim scale As Double
        Dim offset As Integer
        Dim i As Integer

        lastX = 0
        lastY = 0
        Me.Refresh()
        Hdivisions()

        Do Until loopX > PictureBox1.Size.Width    'Need?

            For i = 0 To 95
                tempF = data(i)
                Label1.Text = CInt(tempF)

                inv = CInt(tempF) - (minTemp - 5)    'Invert temp
                InvtertLabel.Text = inv
                range = (maxTemp + 5) - (minTemp - 5)           'Set range
                RangeLabel.Text = range

                If range = 0 Then
                    'scale = PictureBox1.Height / (range + 1)
                ElseIf range <> 0 Then
                    scale = PictureBox1.Height / range            'Set scale
                End If                                            'Do not round or fix !!!!! 
                ScaleLabel.Text = scale.ToString("n")                            'Need exact value to several decimals to scale correctly!!

                'offset = 30                                    'Not need?
                OffsetLabel.Text = "n/a"

                graphF = PictureBox1.Height - (scale * inv)
                Label2.Text = graphF


                PictureBox1.CreateGraphics.DrawLine(Pens.DarkSeaGreen, loopX, graphF, lastX, lastY)
                lastX = loopX

                loopX += (PictureBox1.Width / 96)
                lastY = graphF
            Next
        Loop
        GraphLabels()
    End Sub

    Sub Hdivisions()
        Dim hC As Integer
        Dim hMax As Integer
        Dim hMin As Integer
        Dim h1 As Integer
        Dim h2 As Integer

        hC = PictureBox1.Height * 0.5
        penColor = Pens.LightGray
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hC, PictureBox1.Width, hC)

        h1 = PictureBox1.Height * 0.75
        penColor = Pens.LightBlue
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, h1, PictureBox1.Width, h1)

        h2 = PictureBox1.Height * 0.25
        penColor = Pens.Orange
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, h2, PictureBox1.Width, h2)

        hMax = PictureBox1.Height - 5
        penColor = Pens.CornflowerBlue
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hMax, PictureBox1.Width, hMax)

        hMin = 5
        penColor = Pens.Red
        PictureBox1.CreateGraphics.DrawLine(penColor, 0, hMin, PictureBox1.Width, hMin)

    End Sub

    'Sub to label side of graph across range of the data
    Sub GraphLabels()
        HcenterLabel.Text = (range * 0.5) + minTemp - 5
        h1Label.Text = (range * 0.25) + minTemp - 5
        h2Label.Text = (range * 0.75) + minTemp - 5
        HBottomLabel.Text = minTemp - 5
        HtopLabel.Text = maxTemp + 5
    End Sub

    Sub DateDisplay()

        dateTemp = DateString
        timeTemp = TimeString

    End Sub


    'Sets com port and baud rate 
    Sub ReadComPorts()
        portState = False
        Try
            SerialPort1.BaudRate = ComPortComboBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortComboBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub

    'Loads and reads settings file
    Public Sub Load_setting()
        drivePath = CurDir()
        fileName = drivePath & "\ScopeSettings.txt"               'File found in debug folder of project
        Try
            FileOpen(1, fileName, OpenMode.Input)                 'Open file for read
        Catch ex As Exception
            MsgBox("Settings file not found, please go to settings menu") 'Alerts user if no file found
            Exit Sub
        End Try

        Input(1, port)      'Load port name
        Input(1, baud)      'Load baud rate

        FileClose(1)

        ComPortLabel.Text = port
        BaudRateLabel.Text = baud
    End Sub

    Sub BaudRate()
        BaudRateComboBox.Items.Clear()                          'Clear list box and load baud rate values
        BaudRateComboBox.Items.Add(1200)
        BaudRateComboBox.Items.Add(2400)
        BaudRateComboBox.Items.Add(4800)
        BaudRateComboBox.Items.Add(9600)
        BaudRateComboBox.Items.Add(19200)
        BaudRateComboBox.Items.Add(38400)
        BaudRateComboBox.Items.Add(57600)
        BaudRateComboBox.Items.Add(115200)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(460800)
        BaudRateComboBox.Items.Add(921600)
    End Sub

    'Set sample rate of timer
    Sub SampleRate()
        SampleRateComboBox.Items.Clear()
        SampleRateComboBox.Items.Add(10)
        SampleRateComboBox.Items.Add(100)
        SampleRateComboBox.Items.Add(500)
        SampleRateComboBox.Items.Add(1000)
        SampleRateComboBox.Items.Add(5000)
        SampleRateComboBox.Items.Add(10000)
        SampleRateComboBox.Items.Add(60000)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        DateDisplay()
        DateLabel.Text = dateTemp
        TimeLabel.Text = timeTemp

    End Sub

    Private Sub DataButton_Click(sender As Object, e As EventArgs) Handles DataButton.Click
        If AnIn1CheckBox.Checked = True Then
            DisplayArray()

        ElseIf AnIn1CheckBox.Checked = False Then
            CollectData()
        End If


    End Sub

    Private Sub MaxMinButton_Click(sender As Object, e As EventArgs) Handles MaxMinButton.Click
        MaxMin()
    End Sub
    Private Sub TempGButton_Click(sender As Object, e As EventArgs) Handles TempGButton.Click
        Graph()
    End Sub

    Private Sub GraphInButton_Click(sender As Object, e As EventArgs) Handles GraphInButton.Click
        If AnIn1CheckBox.Checked = True Then
            DisplayArray()
        ElseIf AnIn1CheckBox.Checked = False Then
            CollectData()
        End If
        MaxMin()
        Graph()
    End Sub

    Private Sub AnIn1CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AnIn1CheckBox.CheckedChanged
        Timer1.Enabled = True
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        DataListBox.Items.Clear()
    End Sub


    'Draws input in picture box, communicates with the Qy@ board and processes recieved data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer



        'Enable input from Qy@ board when check box is checked
        If AnIn1CheckBox.Checked = True Then
            'Calls functions to communicate with Qy@ board, analog input 1 when serial communication is present
            If portState = True Then
                'Transmit and receive data from Qy@ analog input 1 
                AnalogIn()
                If AutoGraphCheckBox.Checked = True Then
                    DisplayArray()
                    MaxMin()
                    Graph()
                End If

            End If
        End If



        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select

        End If
    End Sub


    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
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


    'Selects com port when selected in combo box
    Private Sub ComPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub

    'Selects baud rate when selected in combo box
    Private Sub BaudRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaudRateComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub

    Private Sub SampleRateComboBox_Click(sender As Object, e As EventArgs) Handles SampleRateComboBox.Click
        If SampleRateComboBox.SelectedItem = 0 Then

        ElseIf SampleRateComboBox.SelectedItem > 0 Then
            Timer1.Interval = SampleRateComboBox.SelectedItem
            SampleRateLabel.Text = SampleRateComboBox.SelectedItem & " " & "ms"
        End If

    End Sub

    'Saves set values to file
    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        Try
            FileOpen(1, fileName, OpenMode.Output)                 'Open file for write
        Catch ex As Exception

        End Try

        WriteLine(1, ComPortComboBox.SelectedItem, BaudRateComboBox.SelectedItem) 'Write file
        FileClose(1)
    End Sub

    'Button -Loads saved setting of com port and baud rate when presssed
    Private Sub LoadSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadSettingsToolStripMenuItem.Click
        Load_setting()                                      'Reads file
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

        ConnectToolStripMenuItem.Text = "Connect"
        portState = False

        SerialPort1.BaudRate = baud 'See if baud rate data is in the list box
        SerialPort1.PortName = port 'Bot baud rate, save port name
    End Sub

    'Activates selected comport
    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        If ConnectToolStripMenuItem.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                ConnectToolStripMenuItem.Text = "Disconnect"                  'Displays that com port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                ConnectToolStripMenuItem.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            ConnectToolStripMenuItem.Text = "Connect"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = False                          'timer disabled
        AnIn1CheckBox.Checked = False                   'Input disabled
        AutoGraphCheckBox.Checked = False
        drivePath = CurDir()
        fileName = drivePath & "\ScopeSettings.txt"             'File found in debug folder of project

        BaudRate()


        ComPortComboBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortComboBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

        SampleRate()

        DateDisplay()
        drivePath2 = CurDir()
        Me.fileName2 = CurDir() & "\TemperatureData" & dateTemp & ".txt"
    End Sub


    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
