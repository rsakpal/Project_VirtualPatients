' Date: 06/26/2013
' MEInfo_form: This form accepts information about the medical examiner like age, gender and culture
Public Class MEInfo_form

    Dim age As String
    Dim gender As String
    Dim ethnicity As String

    ' Function: To close the form
    Private Sub exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_Button.Click
        End
    End Sub

    ' Function: To load the form
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    ' Function: To store inofrmation in the database and open a new form
    Private Sub submit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_Button.Click

        ' Check if all the fields of the form have been filled
        If Not male_RadioButton.Checked And Not female_RadioButton.Checked Then
            MsgBox("You have to check one of the radio buttons.", MsgBoxStyle.OkOnly)
        ElseIf age_ComboBox.Text = "" Then
            MsgBox("You have to select an age from the drop-down list.", MsgBoxStyle.OkOnly)
        ElseIf ethnicity_ComboBox.Text = "" Then
            MsgBox("You have to slect a race or ethnicity from the drop-down list.", MsgBoxStyle.OkOnly)
        ElseIf otherEthinicty_TextBox.Visible = True And (otherEthinicty_TextBox.Text = "" Or otherEthinicty_TextBox.Text = "Please Specify") Then
            MsgBox("You have to specify a race or ethnicity.", MsgBoxStyle.OkOnly)
        Else
            ' Save values in local variables
            If male_RadioButton.Checked Then
                gender = male_RadioButton.Text
            Else
                gender = female_RadioButton.Text
            End If
            age = age_ComboBox.Text
            If ethnicity_ComboBox.Text = "Other" Then
                ethnicity = otherEthinicty_TextBox.Text
            Else
                ethnicity = ethnicity_ComboBox.Text
            End If

            ' Insert values in the database
            medicalExaminer_Insert(MedicalExaminer_DataTBLTableAdapter2, age, gender, ethnicity)

            ' Send data to the server
            'Process.Start("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/MEdata.php?age=" & age & "&gender=" & gender & "&ethnicity=" & ethnicity)
            Dim htmlcode As String = PHP("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/MEdata.php", "POST", "age=" & age & "&gender=" & gender & "&ethnicity=" & ethnicity)

            ' Close this form and open the new form
            Me.Visible = False
            patientChoice_form.Show()

        End If

    End Sub

    ' Function: To capture the changes made to ethnicity comboBox
    Private Sub ethnicity_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ethnicity_ComboBox.SelectedIndexChanged
        
        ' If user selected 'other' from ethnicity list then ask user to specify the race/ethnicity
        If ethnicity_ComboBox.SelectedIndex = 7 Then
            otherEthinicty_TextBox.Visible = True
        Else
            otherEthinicty_TextBox.Visible = False
        End If

    End Sub

   
End Class
