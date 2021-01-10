Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You have Registered Successfully !")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox2.Text = "1st Sem" Then
            CheckBox1.Text = "Chemistry"
            CheckBox2.Text = "Engineering Graphics"
            CheckBox3.Text = "Life System"
            CheckBox4.Text = "Mathematics I"
            CheckBox5.Text = "C programming"

        Else
            If ComboBox2.Text = "2nd Sem" Then
                CheckBox1.Text = "Physics"
                CheckBox2.Text = "Engineering Mechanics"
                CheckBox3.Text = "Electronics"
                CheckBox4.Text = "Mathematics II"
                CheckBox5.Text = "Environmental Study"

            Else
                If ComboBox2.Text = "3rd Sem" Then
                    CheckBox1.Text = "Communication Engineering"
                    CheckBox2.Text = "EDC"
                    CheckBox3.Text = "DMGT"
                    CheckBox4.Text = "Mathematics III"
                    CheckBox5.Text = "Programming Methodology"

                Else
                    If ComboBox2.Text = "4th Sem" Then
                        CheckBox1.Text = "Data Structure"
                        CheckBox2.Text = "DC"
                        CheckBox3.Text = "DIC"
                        CheckBox4.Text = "OOT"
                        CheckBox5.Text = "NMCP"

                    Else
                        If ComboBox2.Text = "5th Sem" Then
                            CheckBox1.Text = "System Analysis and Design"
                            CheckBox2.Text = "Principle of Management"
                            CheckBox3.Text = "Theory of Computation"
                            CheckBox4.Text = "System Programming"
                            CheckBox5.Text = "Database Management System"


                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        CheckBox5.Text = ""
        CheckBox4.Text = ""
        CheckBox3.Text = ""
        CheckBox2.Text = ""
        CheckBox1.Text = ""
    End Sub
End Class
