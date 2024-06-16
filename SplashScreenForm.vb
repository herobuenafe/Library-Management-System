Imports System.Threading

Public Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadingThread As New Thread(AddressOf StartLoading)
        loadingThread.Start()
    End Sub

    Private Sub StartLoading()
        For i As Integer = 0 To 100 Step 40
            Me.Invoke(Sub()
                          ProgressBar1.Value = i
                      End Sub)
            Thread.Sleep(1000)
        Next

        Me.Invoke(Sub()

                      Me.Hide()

                      Form1.Show()


                  End Sub)

        


    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class