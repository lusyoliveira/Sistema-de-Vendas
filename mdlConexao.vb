Module mdlConexao
Imports System.Data.Common
Imports System.Configuration

    Private cn As DbConnection

    Const DataBase = "dbVendas"
    Const user = "usuario"
    Const password = "senha"
    Const Servidor = "(local)"

    Public Enum tpServidor
        Access = 0
        SqlServer = 1
        MySQL = 2
        PostgreSQL = 3
        Oracle = 4
        SQLite = 5
    End Enum

    Private Function GetConnectionString(ByVal servidor As tpServidor) As String
        Select Case servidor
            Case tpServidor.SqlServer
                Return $"Server={Servidor};Database={DataBase};User Id={user};Password={password};"
            Case tpServidor.MySQL
                Return $"Server={Servidor};Database={DataBase};User={user};Password={password};"
            Case tpServidor.PostgreSQL
                Return $"Host={Servidor};Database={DataBase};Username={user};Password={password};"
            Case tpServidor.Oracle
                Return $"Data Source={Servidor};User Id={user};Password={password};"
            Case tpServidor.SQLite
                Dim dbPath As String = My.Computer.FileSystem.CurrentDirectory & If(Right(My.Computer.FileSystem.CurrentDirectory, 1) = "\", "", "\") & BancoDeDados & ".sqlite"
                Return $"Data Source={dbPath};Version=3;"
            Case Else ' Access
                Dim acess_db2 As String = My.Computer.FileSystem.CurrentDirectory
                acess_db2 &= If(Right(acess_db2, 1) = "\", "", "\")
                acess_db2 &= DataBase & ".mdb"
                Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DataBase};Persist Security Info=False"
        End Select
    End Function

    Private Function GetProviderInvariantName(ByVal servidor As tpServidor) As String
        Select Case servidor
            Case tpServidor.SqlServer
                Return "System.Data.SqlClient"
            Case tpServidor.MySQL
                Return "MySql.Data.MySqlClient"
            Case tpServidor.PostgreSQL
                Return "Npgsql"
            Case tpServidor.Oracle
                Return "Oracle.ManagedDataAccess.Client"
            Case tpServidor.SQLite
                Return "System.Data.SQLite"
            Case Else ' Access
                Return "System.Data.OleDb"
        End Select
    End Function

    Public Function RecebeTabela(ByVal Sql As String, Optional ByVal servidor As tpServidor = tpServidor.Access) As DataTable
        Dim factory As DbProviderFactory = DbProviderFactories.GetFactory(GetProviderInvariantName(servidor))
        cn = factory.CreateConnection()
        cn.ConnectionString = GetConnectionString(servidor)

        Dim dt As New DataTable()
        Try
            cn.Open()
            Dim cmd As DbCommand = aConexao.CreateCommand()
            cmd.CommandText = Sql
            Dim adapter As DbDataAdapter = factory.CreateDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
        Catch ex As Exception
            dt = Nothing
            MsgBox("Banco de Dados não encontrado!")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        Return dt
    End Function

   '    Private aConexao As New ADODB.Connection

'    Const BancoDeDados = "dbVendas"

'    Const acess_db = "bancodedados"
'    Const acess_usr = "usuario"
'    Const acess_pwd = "senha"
'    Const acess_server = "(local)"

'    Public Enum tpServidor
'        Access = 0
'        SqlServer = 1
'    End Enum

'    Public Function RecebeTabela(ByVal Sql As String, Optional ByVal servidor As tpServidor = tpServidor.Access)

'        Dim aResultado As New ADODB.Recordset
'        Dim acess_db2 As String
'        acess_db2 = My.Computer.FileSystem.CurrentDirectory
'        acess_db2 &= IIf(Right(acess_db2, 1) = "\", "", "\")
'        acess_db2 &= BancoDeDados & ".mdb"
'        'MsgBox(acess_db2)
'        If aConexao.State = 1 Then aConexao.Close()

'        If servidor = tpServidor.SqlServer Then

'            aConexao.ConnectionString = "driver={sql server};" &
'                                            "server=" + acess_server + ";" &
'                                            "Database=" + acess_db + ";" &
'                                            "PWD=" + acess_pwd + ";" &
'                                            "UID=" + acess_usr + ";"
'        Else
'            aConexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & acess_db2 & ";Persist Security Info=False"
'        End If
'        Try
'            aConexao.Open()

'        Catch ex As Exception
'            aResultado = Nothing
'            MsgBox("Banco de Dados n�o encontrado!")
'            GoTo fim
'        End Try

'        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'        aResultado.Open(Sql, aConexao, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
'fim:
'        RecebeTabela = aResultado
'        aResultado = Nothing
'    End Function
End Module
