Imports System.Net
Imports System.IO
Imports System.Text

Public Class cinjectgui
    Dim cinject As New Process
    Dim aName As String = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
    Dim aPath As String = System.IO.Path.GetDirectoryName(aName)

    Private Sub cinjectgui_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cinject.StartInfo.FileName = "cmd.exe"
        cinject.StartInfo.RedirectStandardInput = True
        cinject.StartInfo.UseShellExecute = False
        cinject.StartInfo.CreateNoWindow = True
        cinject.StartInfo.RedirectStandardOutput = True
    End Sub

    Private Sub jailbreak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jailbreak.Click
        jailbreak.Enabled = False
        info.Text = "Starting.."

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "Installing profile.."
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "i.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
        info.Text = "At your iOS device: hit Install and leave the password field empty." & vbNewLine & "click next to continue"
        nextb.Visible = True
    End Sub

    Private Sub nextb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextb.Click
        nextb.Visible = False

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "Jailbreaking.."
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "jb.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text += cinject.StandardOutput.ReadToEnd
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "w.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text += cinject.StandardOutput.ReadToEnd
        info.Text = "At your iOS device: enter settings and toggle VPN." & vbNewLine & "When your iDevice will finish rebooting click finish."
        finish.Visible = True
        Refresh()

    End Sub

    Private Sub finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finish.Click
        info.Text = "Connect your iDevice and hit the jailbreak button"
        finish.Visible = False
        jailbreak.Enabled = True
    End Sub
End Class
