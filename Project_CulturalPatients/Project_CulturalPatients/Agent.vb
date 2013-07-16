' Date: 06/28/2013
' Agent Module: This module has all haptek commands for the virtual agent

Module Agent

    ' Function: To load background image in haptek player
    Public Sub loadBkgrnd(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX)
        haptek.HyperText = "\LoadBackGrnd [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_VirtualPatients\Images\Doctors_Office_1.jpg]]"
    End Sub

    ' Function: To load agent in the haptek player
    Public Sub agentLoad(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal agentChoice As String)
        If agentChoice = "Indian Female" Then
            haptek.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_VirtualPatients\Haptars\IndianFemale.haptar]]"
        ElseIf agentChoice = "Mexican Female" Then
            haptek.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_VirtualPatients\Haptars\MexicanFemale.haptar]]"
        ElseIf agentChoice = "Indian Male" Then
            haptek.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_VirtualPatients\Haptars\IndianMale.haptar]]"
        Else
            haptek.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_VirtualPatients\Haptars\MexicanMale.htr]]"
        End If
    End Sub

    ' Function: To introduce the agents
    Public Sub agentIntroTalk(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal agentChoice As String)
        If agentChoice = "Indian Female" Then
            haptek.HyperText = "\sapittsload[i0= 7]"
            haptek.HyperText = "\q2[s0=[Hi, My name is Sita and I am your patient today.]]"
        ElseIf agentChoice = "Mexican Female" Then
            haptek.HyperText = "\sapittsload[i0= 2]"
            haptek.HyperText = "\q2[s0=[Hi, My name is Rohit and I am your patient today.]]"
        ElseIf agentChoice = "Indian Male" Then
            haptek.HyperText = "\sapittsload[i0= 3]"
            haptek.HyperText = "\q2[s0=[Hi, My name is Maria and I am your patient today.]]"
        Else
            haptek.HyperText = "\sapittsload[i0= 4]"
            haptek.HyperText = "\q2[s0=[Hi, My name is Carlos and I am your patient today.]]"
        End If
    End Sub

    ' Function: To make agent talk and load their voices
    Public Sub agentTalk(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal agentChoice As String, ByVal msgString As String)
        If agentChoice = "Indian Female" Then
            haptek.HyperText = "\sapittsload[i0= 7]"
            haptek.HyperText = "\q2[s0=[" & msgString & "]]"
        ElseIf agentChoice = "Mexican Female" Then
            haptek.HyperText = "\sapittsload[i0= 2]"
            haptek.HyperText = "\q2[s0=[" & msgString & "]]"
        ElseIf agentChoice = "Indian Male" Then
            haptek.HyperText = "\sapittsload[i0= 3]"
            haptek.HyperText = "\q2[s0=[" & msgString & "]]"
        Else
            haptek.HyperText = "\sapittsload[i0= 4]"
            haptek.HyperText = "\q2[s0=[" & msgString & "]]"
        End If

    End Sub
End Module
