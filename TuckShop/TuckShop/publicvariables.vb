Imports MySql.Data.MySqlClient
Module publicvariables
    Public con As MySqlConnection = myconn()
    Public result As Integer
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dReader As MySqlDataReader
    Public sql As String = ""
    Public reportselect, reportname As String
    Public switch, switchcurr As String
    Public issucess As Boolean
    Public bdaystring As String
    Public ay, sem, cur_yr As String

    Public ACCOUNT_NAME As String = ""
    Public ACCOUNT_USERNAME As String = ""
    Public ACCOUNT_TYPE As String = ""
    Public username As String = ""
    Public usertype As String = ""
    Public fullname As String = ""
    Public LNAME As String = ""
    Public FNAME As String = ""



    Public vardepartment As Integer = 0
    Public varcollege As Integer = 0
    Public leavestatus As String = ""
    Public department As String
    Public college As String
    Public Nameofchair As String = ""
    Public ChairID As Integer = 0
    Public NameofDean As String = ""
    Public DeanID As Integer = 0
    Public varDate As Integer
    Public globalID As Integer = 0

    Public typeofleave As String


    Public MSGID As Integer = 0
    Public FlagStudent As String = ""
End Module
