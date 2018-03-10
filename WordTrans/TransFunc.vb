Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Friend Module TransFunc

    Public Class TransHelper
        Private saltnum As String
        Private s_appid As String
        Private s_q As String
        Private s_key As String
        Private s_From As String
        Private s_To As String
        Public Function HttpGet(ByVal url As String, ByVal data As String) As String
            Dim request As HttpWebRequest = WebRequest.Create(url + "?" + data)
            request.Method = "GET"
            Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
            Return sr.ReadToEnd
        End Function
        Public Function HttpPost(ByVal url As String, ByVal data As String) As String
            ServicePointManager.Expect100Continue = False
            Dim request As HttpWebRequest = WebRequest.Create(url)
            '//Post请求方式
            request.Method = "POST"
            '内容类型
            request.ContentType = "application/x-www-form-urlencoded"
            '将URL编码后的字符串转化为字节
            Dim encoding As New UTF8Encoding()
            Dim bys As Byte() = encoding.GetBytes(data)
            '设置请求的 ContentLength 
            request.ContentLength = bys.Length
            '获得请求流
            Dim newStream As Stream = request.GetRequestStream()
            newStream.Write(bys, 0, bys.Length)
            newStream.Close()
            '获得响应流
            Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
            Return sr.ReadToEnd
        End Function
        Public Function GetUTF8MD5(ByVal stringbytes() As Byte) As String
            Dim str As String = ""
            '字节串取MD5
            Dim md5Hasher As New MD5CryptoServiceProvider()
            Dim data As Byte() = md5Hasher.ComputeHash(stringbytes)
            '转换为字符串
            Dim sBuilder As New StringBuilder()
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i
            str = sBuilder.ToString().Substring(0, 32)
            Return str
        End Function

        Public Sub InitSalt()
            Randomize()
            saltnum = Format(Math.Round(Rnd() * 9000), "0000")
            'saltnum = "1023"
        End Sub
        Public Sub SetAppid(ByVal AppID As String)
            s_appid = AppID
        End Sub
        Public Sub SetKey(ByVal Key As String)
            s_key = Key
        End Sub

        'Public Function getSignString(ByVal Qg As String) As Byte()
        '    s_q = Qg
        '    Dim tmp_q As String = s_appid & s_q & saltnum & s_key
        '    Dim transquery_default_byte() As Byte = Encoding.Default.GetBytes(tmp_q)
        '    Dim transquery_transd_byte() As Byte = Encoding.Convert(Encoding.Default, Encoding.UTF8, transquery_default_byte)
        '    Return transquery_transd_byte
        'End Function
        'Public Function signQuery(ByVal Qs As String)
        '    Dim md5 As New MD5Helper
        '    Return md5.getUTF8MD5(getSignString(Qs))
        'End Function

        Public Function GetParams(ByVal QueryToTranslation As String)
            Dim signQuery As String
            'Dim md5 As New MD5Helper
            s_q = QueryToTranslation
            '以下拼接key字符串
            Dim tmp_q As String = s_appid & s_q & saltnum & s_key
            '以下转换编码
            Dim transquery_default_byte() As Byte = Encoding.Default.GetBytes(tmp_q)
            Dim signStringByte() As Byte = Encoding.Convert(Encoding.Default, Encoding.UTF8, transquery_default_byte)
            'getSignString(QueryToTranslation)
            '取的key串的MD5值
            signQuery = GetUTF8MD5(signStringByte)
            Return "q=" & QueryToTranslation & "&from=" & s_From & "&to=" & s_To & "&appid=" & s_appid & "&salt=" & saltnum & "&sign=" & signQuery 'signQuery(QueryToTranslation)
        End Function
        Public Sub New()
            Me.InitSalt()
            s_From = "auto"
            s_To = "zh"
        End Sub
        Public Function Translate(ByVal transquery As String, Optional ByVal transfrom As String = "auto", Optional ByVal transto As String = "zh")

            s_From = transfrom
            s_To = transto
            '以下对属性有效性进行判断，错误即退出
            If s_appid = "" Then
                Return "Initialize Error : APP ID requested"
                Exit Function
            End If
            If s_key = "" Then
                Return "Initialize Error : APP key requested"
                Exit Function
            End If
            If s_appid.Length <> 17 Then
                Return "Initialize Error : Wrong APP ID"
                Exit Function
            End If
            If s_key.Length <> 20 Then
                Return "Initialize Error : Wrong APP key"
                Exit Function
            End If
            '以下进行网络通讯
            Dim empData As String = HttpPost(My.Resources.PubRes.StringTransURL, GetParams(transquery))
            Dim resulttempset As JObject = CType(JsonConvert.DeserializeObject(empData), JObject)
            If resulttempset.ContainsKey("trans_result") Then
                Dim resulttempstring As String = resulttempset("trans_result").ToString
                Dim resultstring As String = Mid(resulttempstring, 2, resulttempstring.Length - 2)
                Dim resultset As JObject = CType(JsonConvert.DeserializeObject(resultstring), JObject)
                Return resultset("dst").ToString
            ElseIf resulttempset.ContainsKey("error_msg") Then
                Return "API Error: " & resulttempset("error_msg").ToString
            Else
                Return "Unknown Error"
            End If
        End Function

    End Class
End Module
