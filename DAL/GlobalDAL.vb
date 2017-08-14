Imports System.Data.SqlClient

'Variáveis globais para todo o projeto
Module GlobalDAL

    Public Const strConexao As String = "Data Source=NOTE;Initial Catalog=CRUD;Integrated Security=true"

    Public strInstrucao As String = String.Empty

    Public objConexao As New SqlConnection(strConexao)

    Public objCommand As New SqlCommand(strInstrucao, objConexao)

End Module
