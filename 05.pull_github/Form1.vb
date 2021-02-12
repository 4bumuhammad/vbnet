'Imports System.Collections.ObjectModel
'Imports System.Management.Automation
'Imports System.Management.Automation.Runspaces
'Imports System.Text

Public Class Form1

    Private Function RunScript(ByVal scriptText As String) As String
        'Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        'MyRunSpace.Open()

        'Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()
        'MyPipeline.Commands.AddScript(scriptText)
        'MyPipeline.Commands.Add("Out-String")


        'Dim results As Collection(Of PSObject) = MyPipeline.Invoke()

        '' close the runspace
        'MyRunSpace.Close()

        'Dim MyStringBuilder As New StringBuilder()

        'For Each obj As PSObject In results
        '    MyStringBuilder.AppendLine(obj.ToString())
        'Next

        'Return MyStringBuilder.ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'RunScript("curl -L https://github.com/4bumuhammad/coba-git/script.js?private_token=711a70816442792c648c63e47274705fa18ae9aa -outfile D:\Microsoft Visual Studio 2019\VB.Net(Win-Desk)\AplikasidariGit\")
    End Sub

End Class
