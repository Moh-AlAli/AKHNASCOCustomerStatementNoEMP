Imports AccpacCOMAPI

Friend Class custstatement

    Public compid As String = ""
    Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    Public mSession As New AccpacCOMAPI.AccpacSession
    Public frmcust As String
    Public Tocust As String
    Public fdate As String
    Public tdate As String
    Private rdoc As New AccpacReport
    Public xdbcom As AccpacDBLink

    Private Sub custstatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            mSession.Init("", "XX", "XX0001", "65A")
            acsignon.Signon(mSession)
            compid = mSession.CompanyID
            xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

            If compid = "" Then
                Close()
            End If

            Txttocus.Text = "zzzzzzzzzzzzzzzzzzzzzz"
            'Txtfd.Text = Date.Now.ToString("yyyy-MM-dd")
            'Txttd.Text = Date.Now.ToString("yyyy-MM-dd")
            'MonthCalendar1.Visible = False
            'MonthCalendar2.Visible = False
            Rbwcw.Checked = True
            Rbfunc.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub
    Private Sub CMD_OK_Click(sender As Object, e As EventArgs) Handles CMD_OK.Click
        Try
            'Dim fdate As String = Val(Mid(Trim(Txtfd.Text), 1, 4)) * 10000 + Val(Mid(Trim(Txtfd.Text), 6, 2)) * 100 + Val(Mid(Trim(Txtfd.Text), 9, 2))
            'Dim tdate As String = Val(Mid(Trim(Txttd.Text), 1, 4)) * 10000 + Val(Mid(Trim(Txttd.Text), 6, 2)) * 100 + Val(Mid(Trim(Txttd.Text), 9, 2))
            Dim fmonthnew As String = 0
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DateTimePicker1.Value.Month
            Else
                fmonthnew = DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DateTimePicker2.Value.Month
            Else
                tmonthnew = DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DateTimePicker1.Value.Day
            Else
                fdaynew = DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DateTimePicker2.Value.Day
            Else
                tdaynew = DateTimePicker2.Value.Day
            End If

            fdate = DateTimePicker1.Value.Year & fmonthnew & fdaynew

            tdate = DateTimePicker2.Value.Year & tmonthnew & tdaynew
            If Trim(txtfrmcus.Text) <= Trim(Txttocus.Text) Then
                If fdate <= tdate Then
                    crviewer.Show()
                Else
                    MessageBox.Show("From Date  greater than To Date")
                End If
            Else
                MessageBox.Show("From Customer No greater than To Customer No")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bffind_Click(sender As Object, e As EventArgs) Handles bffind.Click
        Fromcust.Show()
        bffind.Visible = False
    End Sub

    Private Sub btfind_Click(sender As Object, e As EventArgs) Handles btfind.Click
        Dim f As Form = New tocust
        f.Show()
        btfind.Visible = False
    End Sub
    Private Sub CMD_Exit_Click(sender As Object, e As EventArgs) Handles CMD_Exit.Click
        Close()
    End Sub
End Class
