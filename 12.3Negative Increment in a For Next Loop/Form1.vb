Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim counter, sum As Integer
		sum = 1000
		For counter = 100 To 5 Step -5
			sum -= counter
			ListBox1.Items.Add(sum)
		Next
	End Sub
End Class
