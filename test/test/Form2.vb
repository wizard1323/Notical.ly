
Imports System.Speech

Public Class Form2

    Dim WithEvents MyVoice As New Recognition.SpeechRecognitionEngine
    Dim score As Integer
    Dim spawnx As Integer
    Dim spawny As Integer
    Dim rand As New Random


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'activate the default audio device "Mic"
        MyVoice.SetInputToDefaultAudioDevice()

        'Create a var MyGrammar
        Dim MyGrammar As New Recognition.SrgsGrammar.SrgsDocument

        'Create a var MyWordsRule
        Dim MyWordsRule As New Recognition.SrgsGrammar.SrgsRule("words")

        'Create a var MyWordsRule
        Dim MyWords As New Recognition.SrgsGrammar.SrgsOneOf("dough", "red", "mi", "fa", "stop")

        'Add the words I speak onto the system
        MyWordsRule.Add(MyWords)

        'Add the MyWordRule onto the system
        MyGrammar.Rules.Add(MyWordsRule)

        'The location to MyWordRule
        MyGrammar.Root = MyWordsRule

        'LoadGrammar
        MyVoice.LoadGrammar(New Recognition.Grammar(MyGrammar))

        'recognise my voice on form load
        MyVoice.RecognizeAsync()

    End Sub


    'recognise my voice every time I speak
    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles MyVoice.RecognizeCompleted

        MyVoice.RecognizeAsync()

    End Sub
    Dim SAPI


    'recognise my voice and if the case exists, execute the procedure



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top += 2
        PictureBox4.Top += 2
        PictureBox3.Top += 2
        PictureBox2.Top += 2
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y >= 420 Or PictureBox4.Location.Y >= 420 Or PictureBox3.Location.Y >= 420 Or PictureBox2.Location.Y >= 420 Then
            Me.Dispose()
            MsgBox("Game Over!")
            Form1.Show()

        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score = score + 5
        Label1.Text = "Score: " & score

        'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

        'spawnx = Int((204 - 1 + 1) * Rnd() + 1)
        spawnx = rand.Next(1, 104)
        spawny = rand.Next(1, 194)

        PictureBox1.Location = New Point(spawnx, spawny)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        score = score + 5
        Label1.Text = "Score: " & score

        'spawnx = Int((408 * Rnd()) + 205)
        spawnx = rand.Next(205, 308)
        spawny = rand.Next(1, 194)

        PictureBox2.Location = New Point(spawnx, spawny)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        score = score + 5
        Label1.Text = "Score: " & score

        'spawnx = Int((612 * Rnd()) + 409)
        spawnx = rand.Next(409, 512)
        spawny = rand.Next(1, 194)

        PictureBox3.Location = New Point(spawnx, spawny)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        score = score + 5
        Label1.Text = "Score: " & score

        ' spawnx = Int((816 * Rnd()) + 613)
        'spawnx = Int((816 - 613 + 1) * Rnd() + 613)
        spawnx = rand.Next(613, 716)
        spawny = rand.Next(1, 194)


        PictureBox4.Location = New Point(spawnx, spawny)
    End Sub


End Class