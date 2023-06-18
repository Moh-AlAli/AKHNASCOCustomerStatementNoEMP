
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows.Forms
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports acc = ACCPAC.Advantage

Friend Class crviewer
    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Dim server As String = ""
    Dim uid As String = ""
    Dim pass As String = ""

    Private ccompid As String
    Private crbfun As Boolean
    Private crbsrc As Boolean
    Private cfdate As String
    Private ctdate As String
    Private cfrmsales As String
    Private ctosales As String
    Private cfrmcust As String
    Private ctocust As String
    Private ccw As Boolean
    Private ccwow As Boolean
    Friend Property ObjectHandle As String
    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\akhcon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()


        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)

        Dim cons As String = ""

        Return cons
    End Function
    Public Sub New(ByVal _objectHandle As String, ByVal _sess As acc.Session, ByVal rbfun As Boolean, ByVal rbsrc As Boolean, ByVal fdate As String, ByVal tdate As String, ByVal frmcust As String, ByVal tocust As String, ByVal rbcw As Boolean, rbwocw As Boolean)
        InitializeComponent()
        ObjectHandle = _objectHandle
        ccompid = _sess.CompanyID
        crbfun = rbfun
        crbsrc = rbsrc

        cfdate = fdate
        ctdate = tdate
        cfrmcust = frmcust
        ctocust = tocust
        ccw = rbcw
        ccwow = rbwocw
    End Sub

    Public Sub New(ByVal _objectHandle As String)
        InitializeComponent()
        ObjectHandle = _objectHandle
    End Sub


    Private Sub crviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim cwvr As New CrystalReportViewer
            cwvr.Dock = DockStyle.Fill
            cwvr.BorderStyle = BorderStyle.None
            cwvr.ExportReport()
            Me.Controls.Add(cwvr)


            If crbfun = True And ccwow = True Then
                rdoc.Load("reports\ARCUSTHOMERPT.rpt")
            ElseIf crbsrc = True And ccwow = True Then
                rdoc.Load("reports\ARCUSTSURCRPT.rpt")
            ElseIf crbfun = True And ccw = True Then
                rdoc.Load("reports\ARCUSTHOMERPTCW.rpt")
            ElseIf crbsrc = True And ccw = True Then
                rdoc.Load("reports\ARCUSTSURCRPTCw.rpt")
            End If


            Dim tabs As Tables = rdoc.Database.Tables
            Dim parv As New ParameterValues
            Dim dis As New ParameterDiscreteValue

            Dim fmonthnew As String = 0
            If custstatement.DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & custstatement.DateTimePicker1.Value.Month
            Else
                fmonthnew = custstatement.DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If custstatement.DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & custstatement.DateTimePicker2.Value.Month
            Else
                tmonthnew = custstatement.DateTimePicker2.Value.Month
            End If



            Dim fdate As String = cfdate

            Dim tdate As String = ctdate


            Readconnectionstring()



            For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs
                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = server
                conrpt.DatabaseName = ccompid
                conrpt.UserID = uid
                conrpt.Password = pass
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)
            Next

            Dim sec As Section
            Dim secs As Sections
            Dim rob As ReportObject
            Dim robs As ReportObjects
            Dim subrpobj As SubreportObject
            Dim subrp As ReportDocument
            Dim crSubTables As Tables
            Dim crsubtable As Table
            secs = rdoc.ReportDefinition.Sections
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
            Dim subConInfo As New ConnectionInfo
            For Each sec In secs
                robs = sec.ReportObjects
                For Each rob In robs
                    If rob.Kind = ReportObjectKind.SubreportObject Then
                        subrpobj = CType(rob, SubreportObject)
                        subrp = subrpobj.OpenSubreport(subrpobj.SubreportName)
                        If subrp.Name = "GLBatch" Then
                            crSubTables = subrp.Database.Tables
                            For Each crsubtable In crSubTables
                                crtableLogoninfo = crsubtable.LogOnInfo
                                subConInfo.ServerName = server
                                subConInfo.DatabaseName = ccompid
                                subConInfo.UserID = uid
                                subConInfo.Password = pass
                                crtableLogoninfo.ConnectionInfo = subConInfo 'ConInfo.ConnectionInfo
                                crsubtable.ApplyLogOnInfo(crtableLogoninfo)
                            Next
                        End If
                        If subrp.Name = "gbbatch" Then
                            crSubTables = subrp.Database.Tables
                            For Each crsubtable In crSubTables
                                crtableLogoninfo = crsubtable.LogOnInfo
                                subConInfo.ServerName = server
                                subConInfo.DatabaseName = ccompid
                                subConInfo.UserID = uid
                                subConInfo.Password = pass
                                crtableLogoninfo.ConnectionInfo = subConInfo 'ConInfo.ConnectionInfo
                                crsubtable.ApplyLogOnInfo(crtableLogoninfo)

                            Next
                        End If
                    End If

                Next
            Next




            rdoc.SetParameterValue("frmyearper", fdate)
            rdoc.SetParameterValue("toyearper", tdate)
            rdoc.SetParameterValue("Frmcus", cfrmcust)
            rdoc.SetParameterValue("TOcus", ctocust)

            cwvr.ReportSource = rdoc


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try
    End Sub
End Class
