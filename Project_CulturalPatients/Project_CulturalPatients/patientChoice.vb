' Date: 06/27/2013
' patientChoice_form: This form allows the user to choose an agent

Public Class patientChoice_form

    ' Variable for storing the user ID
    Dim userID As Integer

    ' Variable to save patient choice
    Dim patient As String

    ' Function: To close the application
    Private Sub exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_Button.Click
        End
    End Sub

    ' Function: On form load
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Retireve User ID from the database
        userID = getUserID(MedicalExaminer_DataTBLTableAdapter)

    End Sub

    ' Function: On button click open new form and store data in the database
    Private Sub indianFem_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indianFem_Button.Click
        patient = "Indian Female"
        agentSelection_Insert(AgentSelection_TBLTableAdapter1, userID, patient)

        ' Send data to the server
        'Process.Start("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php?userID=" & userID & "&agentSelect=" & "Indian Female")
        Dim htmlcode As String = PHP("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php", "POST", "userID=" & userID & "&agentSelect=" & patient)

        ' Close current form & open the webService form
        Me.Visible = False

        ' Object for new mainInterface form
        Dim mainInterfaceForm As New mainInterface(patient, userID)
        mainInterfaceForm.Show()
    End Sub

    ' Function: On button click open new form and store data in the database
    Private Sub mexicanFem_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mexicanFem_Button.Click
        patient = "Mexican Female"
        agentSelection_Insert(AgentSelection_TBLTableAdapter1, userID, patient)

        ' Send data to the server
        'Process.Start("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php?userID=" & userID & "&agentSelect=" & "Mexican Female")
        Dim htmlcode As String = PHP("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php", "POST", "userID=" & userID & "&agentSelect=" & patient)

        ' Close current form & open the webService form
        Me.Visible = False

        ' Object for new mainInterface form
        Dim mainInterfaceForm As New mainInterface(patient, userID)
        mainInterfaceForm.Show()

    End Sub

    ' Function: On button click open new form and store data in the database
    Private Sub indianMale_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indianMale_Button.Click
        patient = "Indian Male"
        agentSelection_Insert(AgentSelection_TBLTableAdapter1, userID, patient)

        ' Send data to the server
        'Process.Start("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php?userID=" & userID & "&agentSelect=" & "Indian Male")
        Dim htmlcode As String = PHP("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php", "POST", "userID=" & userID & "&agentSelect=" & patient)

        ' Close current form & open the webService form
        Me.Visible = False

        ' Object for new mainInterface form
        Dim mainInterfaceForm As New mainInterface(patient, userID)
        mainInterfaceForm.Show()
    End Sub

    ' Function: On button click open new form and store data in the database
    Private Sub mexicanMale_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mexicanMale_Button.Click
        patient = "Mexican Male"
        agentSelection_Insert(AgentSelection_TBLTableAdapter1, userID, patient)

        ' Send data to the server
        'Process.Start("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php?userID=" & userID & "&agentSelect=" & "Mexican Male")
        Dim htmlcode As String = PHP("http://ccis004.uncc.edu/~rsakpal/Project_CulturalPatients/patientChoice.php", "POST", "userID=" & userID & "&agentSelect=" & patient)

        ' Close current form & open the webService form
        Me.Visible = False

        ' Object for new mainInterface form
        Dim mainInterfaceForm As New mainInterface(patient, userID)
        mainInterfaceForm.Show()
    End Sub
End Class