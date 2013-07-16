' Date: 07/01/2013
' sqlQuery_Module: This module contains all sql query

Module sqlQuery

    ' Function: To insert data about the medical examiner in the MedicalExaminer_DataTBL
    Public Sub medicalExaminer_Insert(ByVal ME_tableAdapter As CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter, ByVal age As String, ByVal gender As String, ByVal ethnicity As String)
        ME_tableAdapter.Insert(age, gender, ethnicity)
    End Sub

    ' Function: To retreiev gender of the Medical Examiner from MedicalExaminer_DataTBL
    Function medicalExaminerGender(ByVal ME_tableAdapter As CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter, ByVal ID As Integer)
        Dim genderME As String
        genderME = ME_tableAdapter.SelectMEGender(ID)
        Return genderME
    End Function

    ' Function: Select last user ID from the MedicalExaminer_DataTBL
    Function getUserID(ByVal ME_tableAdapter As CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter)
        Return ME_tableAdapter.SelectLastID()
    End Function

    ' Function: Insert agent selection data in the agentSelection_TBL
    Public Sub agentSelection_Insert(ByVal agentSelect_tableAdapter As CulturalPatients_DBDataSet1TableAdapters.agentSelection_TBLTableAdapter, ByVal userID As Integer, ByVal patient As String)
        agentSelect_tableAdapter.Insert(userID, patient)
    End Sub

    ' Function: To retrieve the number of questions from the questionnaireFemale_TBL
    Function retrieveQuestionFemale(ByVal question_tableAdapter As CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireFemale_TBLTableAdapter, ByVal question_DataSet As CulturalPatients_DBDataSetQuestion)
        Return question_tableAdapter.FillByLast(question_DataSet.questionnaireFemale_TBL)
    End Function

    ' Function: To retrieve the number of questions from the questionnaireMale_TBL
    Function retrieveQuestionMale(ByVal question_tableAdapter As CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireMale_TBLTableAdapter, ByVal question_DataSet As CulturalPatients_DBDataSetQuestion)
        Return question_tableAdapter.FillByLast(question_DataSet.questionnaireMale_TBL)
    End Function

    ' Function: To retrieve the question from questionnaireFemale_TBL
    Function questionFemale(ByVal question_tableAdapter As CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireFemale_TBLTableAdapter, ByVal quesNum As Integer)
        Return question_tableAdapter.SelectQuestionFemale(quesNum)
    End Function

    ' Function: To retrieve the question from questionnaireMale_TBL
    Function questionMale(ByVal question_tableAdapter As CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireMale_TBLTableAdapter, ByVal quesNum As Integer)
        Return question_tableAdapter.SelectQuestionMale(quesNum)
    End Function

    ' Function: To retrieve response from the database responseFemale_TBL 
    Function responseFemale(ByVal response_tableAdapter As CulturalPatients_DBDataSetResponseTableAdapters.responseFemale_TBLTableAdapter, ByVal response_DataSet As CulturalPatients_DBDataSetResponse, ByVal quesNum As Integer, ByVal ME_gender As String)
        Return response_tableAdapter.FillBySample(response_DataSet.responseFemale_TBL, quesNum, ME_gender)
    End Function

    ' Function: To retrieve from the database responseMale_TBL
    Function responseMale(ByVal response_tableAdapter As CulturalPatients_DBDataSetResponseTableAdapters.responseMale_TBLTableAdapter, ByVal response_DataSet As CulturalPatients_DBDataSetResponse, ByVal quesNum As Integer, ByVal ME_gender As String)
        Return response_tableAdapter.FillBySampleMale(response_DataSet.responseMale_TBL, quesNum, ME_gender)
    End Function

End Module
