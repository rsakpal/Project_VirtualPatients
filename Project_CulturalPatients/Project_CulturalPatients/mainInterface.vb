' Date: 06/28/2013
' MEInfo_form: This form is where users gets to interact with the patient

Public Class mainInterface

    ' Store the gender of the patient
    Dim patientGender As String
    Dim patient As String
    Dim ME_gender As String
    Dim randomQues As Integer

    ' To store the question number from the question database
    Dim quesNo As Double

    ' Function: On form load
    Public Sub New(ByVal patientChoice As String, ByVal userID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        patient = patientChoice

        ' Store the gender of the patient and number of questions from questionnaireFemale_TBL or questionnaireMale_TBL
        If patientChoice = "Indian Male" Or patientChoice = "Mexican Male" Then
            patientGender = "male"
            quesNo = retrieveQuestionMale(Me.QuestionnaireMale_TBLTableAdapter1, CulturalPatients_DBDataSetQuestion1)
        Else
            patientGender = "female"
            quesNo = retrieveQuestionFemale(Me.QuestionnaireFemale_TBLTableAdapter1, CulturalPatients_DBDataSetQuestion1)
        End If

        ' Retrieve gender of Medical Examiner from MedicalExaminer_DataTBL
        ME_gender = medicalExaminerGender(Me.MedicalExaminer_DataTBLTableAdapter1, userID)

        ' Load the background of haptek player
        loadBkgrnd(AxActiveHaptekX1)

        ' Load the patients in the haptek player
        agentLoad(AxActiveHaptekX1, patientChoice)

        ' Patients Introduce themseleves
        agentIntroTalk(AxActiveHaptekX1, patientChoice)

    End Sub

    ' Function: On click go back to form where you can choose new patient
    Private Sub back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_Button.Click
        Me.Close()
        patientChoice_form.Visible = True
    End Sub

    ' Function: On click close the application
    Private Sub exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_Button.Click
        End
    End Sub

    ' Function: To retrieve a random question from the database
    Private Sub retrieveQuestion_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retrieveQuestion_Button.Click

        ' Choose a random question number to retrieve
        randomQues = CInt(Int(quesNo * Rnd())) + 1
        MsgBox(randomQues)

        If patientGender = "male" Then
            maleQuestion(randomQues)
        Else
            femaleQuestion(randomQues)
        End If

    End Sub

    ' Function: To retrieve question and follow-up question from questionnMale_TBL database
    Private Sub maleQuestion(ByVal quesNo As Integer)
        ' Retrieve the question based on the question number from questionnaireMale_TBL
        query_TextBox.Text = questionMale(Me.QuestionnaireMale_TBLTableAdapter1, quesNo)
    End Sub

    ' Function: To retrieve question and follow-up question from questionnFemale_TBL database
    Private Sub femaleQuestion(ByVal quesNo As Integer)
        ' Retrieve the question based on the question number from questionnaireFemale_TBL 
        query_TextBox.Text = questionFemale(Me.QuestionnaireFemale_TBLTableAdapter1, quesNo)
    End Sub

    ' Make patient talk on click of button
    Private Sub query_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles query_Button.Click
        Dim rowCount As Integer

        ' Retrieve response data based on the question number and the gender of medical examiner
        If patientGender = "female" Then
            'rowCount = Me.ResponseFemale_TBLTableAdapter1.FillBySample(CulturalPatients_DBDataSetResponse1.responseFemale_TBL, randomQues, ME_gender)
            rowCount = responseFemale(Me.ResponseFemale_TBLTableAdapter1, Me.CulturalPatients_DBDataSetResponse1, randomQues, ME_gender)
        Else
            'rowCount = Me.ResponseMale_TBLTableAdapter1.FillBySampleMale(CulturalPatients_DBDataSetResponse1.responseMale_TBL, randomQues, ME_gender)
            rowCount = responseMale(Me.ResponseMale_TBLTableAdapter1, Me.CulturalPatients_DBDataSetResponse1, randomQues, ME_gender)
        End If

        ' Retrieve a random response for the patient from the dataGridView 
        response_TextBox.Text = retrieveResposne(rowCount)
        agentTalk(AxActiveHaptekX1, patient, response_TextBox.Text)
    End Sub


    ' Function: To retrieve response from the dataGridView
    Function retrieveResposne(ByVal rowCount As Integer) As String
        Dim randomRow As Integer = CInt(Int(rowCount * Rnd()))
        If patientGender = "female" Then
            Return female_DataGridView.Item(2, randomRow).Value.ToString()
        Else
            Return male_DataGridView.Item(2, randomRow).Value.ToString()
        End If
    End Function
End Class