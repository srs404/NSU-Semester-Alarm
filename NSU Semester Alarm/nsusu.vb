Imports System.IO
Public Class nsusu
    Dim tody As String = DateTime.Now.ToString("dddd")
    Dim nowtime As String = DateTime.Now.ToString("hh:mm:ss tt")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        checktimedate.Start()
    End Sub

    Private Sub checktimedate_Tick(sender As Object, e As EventArgs) Handles checktimedate.Tick
        Dim nowtime As String = DateTime.Now.ToString("hh:mm:ss tt")
        If tody = "Tuesday" And nowtime >= "02:30:00 PM" And nowtime <= "04:00:00 PM" Then
            Me.Visible = True
            Me.TopMost = True
            Label2.Text = nowtime
            section.Text = "Room: SAC513"
        ElseIf tody = "Sunday" And nowtime >= "02:30:00 PM" And nowtime <= "04:00:00 PM" Then
            Me.Visible = True
            Me.TopMost = True
            Label2.Text = nowtime
            section.Text = "Room: SAC513"
        ElseIf tody = "Monday" And nowtime >= "04:10:00 PM" And nowtime <= "05:50:00 PM" Then
            Me.Visible = True
            Me.TopMost = True
            Label2.Text = nowtime
            section.Text = "Room: SAC211"
        ElseIf tody = "Wednesday" And nowtime >= "04:10:00 PM" And nowtime <= "05:50:00 PM" Then
            Me.Visible = True
            Me.TopMost = True
            Label2.Text = nowtime
            section.Text = "Room: SAC211"
        Else
            Me.Visible = True
            'My.Computer.Audio.Play(My.Resources.alarm, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
