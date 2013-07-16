Imports System.Text
Imports System.IO
Imports System.Net

' Date: 06/28/2013
' webService Module: This module is responsible to send data from forms to php file on remote server

Module webService

    Public Function PHP(ByVal url As String, ByVal method As String, ByVal data As String)
        Try
            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
            request.Method = method
            Dim postData = data

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length

            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()

            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()

            Return (responseFromServer)
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            If error1 = "Invalid URL: The format of the URL could not be determined." Then
                MsgBox("ERROR! Must have HTTP:// before the URL")
            Else
                MsgBox(error1)
            End If

            Return ("Error")
        End Try
    End Function

End Module
