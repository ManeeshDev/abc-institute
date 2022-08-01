Imports System.Data.SqlClient

Public Class Form1
    Dim OL, AL, NVQ4, Gender As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StD()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim cmd As SqlCommand
        Dim Ans As String

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        If txtStID.Text <> "" Then
            cmd = New SqlCommand("INSERT INTO Student(sid,name,address,gender,OL,AL,NVQ4,course,dob) VALUES('" & txtStID.Text & "','" & txtName.Text & "','" & txtAdress.Text & "','" & Gender & "','" & OL & "','" & AL & "','" & NVQ4 & "','" & cmbCourse.Text & "','" & CDate(txtDob.Text) & "' )", cn)

            Ans = MsgBox("Do you Want to save Changes..?", vbYesNo + vbQuestion, "Save")

            If Ans = vbYes Then
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
                    clear()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            Else
                MsgBox("Save Canceled..", MsgBoxStyle.Information, "Save")
            End If

            cn.Close()
        Else
            MsgBox("Please Fill Student ID..!!", MsgBoxStyle.Exclamation, "Sorry!!")
            txtStID.Focus()
        End If

    End Sub

    Private Sub clear()
        txtStID.Text = ""
        cmbCourse.SelectedIndex = -1
        txtName.Text = ""
        txtAdress.Text = ""
        rdioMale.Checked = False
        rdioFemale.Checked = False
        chkOL.Checked = False
        chkAL.Checked = False
        chkNVQ.Checked = False
        txtSearch.Text = ""
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Dim Ans2 As String

        Ans2 = MsgBox("Do you Want to Reset..?", vbYesNo + vbQuestion, "Reset")

        If Ans2 = vbYes Then
            clear()
        End If

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        Dim cmd2 As New SqlCommand
        Dim StNo As String = Trim(txtSearch.Text)

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        If e.KeyCode.Equals(Keys.Enter) Then

            cmd2 = New SqlCommand("SELECT * FROM Student WHERE sid='" & StNo & "'", cn)

            Dim adapter As New SqlDataAdapter(cmd2)
            Dim table As New DataTable
            adapter.Fill(table)

            clear()

            If StNo <> "" Then
                If table.Rows.Count > 0 Then

                    txtSearch.Text = table.Rows(0)(0).ToString()
                    txtStID.Text = table.Rows(0)(0).ToString()
                    txtName.Text = table.Rows(0)(1).ToString()
                    txtAdress.Text = table.Rows(0)(2).ToString()
                    Gender = table.Rows(0)(3).ToString()
                    If Gender = "Male" Then
                        rdioMale.Checked = True
                    ElseIf Gender = "Female" Then
                        rdioFemale.Checked = True
                    End If

                    OL = table.Rows(0)(4).ToString()
                    If OL = "Yes" Then
                        chkOL.Checked = True
                    End If
                    AL = table.Rows(0)(5).ToString()
                    If AL = "Yes" Then
                        chkAL.Checked = True
                    End If
                    NVQ4 = table.Rows(0)(6).ToString()
                    If NVQ4 = "Yes" Then
                        chkNVQ.Checked = True
                    End If
                    cmbCourse.Text = table.Rows(0)(7).ToString()
                    txtDob.Text = table.Rows(0)(8).ToString()

                Else
                    MsgBox("Details Not Found..!!" & vbLf & "Enter Valid Student Number.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Sorry...!")

                End If
            Else
                MsgBox("Please Fill the Student Number in Search Box..!!", MsgBoxStyle.Exclamation, "Sorry...!")
                txtSearch.Focus()
            End If
            cn.Close()
        End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim cmd As SqlCommand
        Dim Ans As String
        Dim StNo As String = Trim(txtSearch.Text)

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        If StNo <> "" Then
            If txtStID.Text <> StNo Then
                MsgBox("You can't update your student id.!", MsgBoxStyle.Critical, "Error")
            End If

            cmd = New SqlCommand("UPDATE Student SET name='" & txtName.Text & "', address='" & txtAdress.Text & "', gender='" & Gender & "', OL='" & OL & "', AL='" & AL & "', NVQ4='" & NVQ4 & "', course='" & cmbCourse.Text & "', dob='" & CDate(txtDob.Text) & "' WHERE sid='" & StNo & "'", cn)

            Ans = MsgBox("Do you Want to save Changes..?", vbYesNo + vbQuestion, "Save")

            If Ans = vbYes Then
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Updated Successfully..!!", MsgBoxStyle.Information, "Update")
                    clear()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            Else
                MsgBox("Update Canceled..", MsgBoxStyle.Information, "Update")
            End If

            cn.Close()
        Else
            MsgBox("Please Fill Student ID..!!", MsgBoxStyle.Exclamation, "Sorry!!")
            txtStID.Focus()
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim cmd As SqlCommand
        Dim Ans As String
        Dim StNo As String = Trim(txtSearch.Text)

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        If StNo <> "" Then

            cmd = New SqlCommand("DELETE FROM Student WHERE sid='" & StNo & "'", cn)

            Ans = MsgBox("Do you Want to delete student..?", vbYesNo + vbQuestion, "Delete")

            If Ans = vbYes Then
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted Successfully..!!", MsgBoxStyle.Information, "Delete")
                    clear()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            Else
                MsgBox("Delete Canceled..", MsgBoxStyle.Information, "Delete")
            End If

            cn.Close()
        Else
            MsgBox("Please Fill Student ID..!!", MsgBoxStyle.Exclamation, "Sorry!!")
            txtStID.Focus()
        End If
    End Sub

    Private Sub qualification_CheckedChanged(sender As Object, e As EventArgs) Handles chkOL.CheckedChanged, chkNVQ.CheckedChanged, chkAL.CheckedChanged

        If chkOL.Checked = True Then
            OL = "Yes"
        End If
        If chkAL.Checked = True Then
            AL = "Yes"
        End If
        If chkNVQ.Checked = True Then
            NVQ4 = "Yes"
        End If

    End Sub

    Private Sub rdioMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub rdioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFemale.CheckedChanged
        Gender = "Female"
    End Sub

End Class
