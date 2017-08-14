Imports System.Data.SqlClient
Imports DTO

'Camada de Dados (DAL)
Public Class ClientesDAL

    Public Function GravarCliente(ByVal clientes As ClientesDTO) As Integer

        Try
            strInstrucao = "INSERT INTO Clientes(Nome,Endereco,Cidade,Telefone,Email,Ativo) " &
                       " VALUES (@Nome,@Endereco,@Cidade,@Telefone,@Email,@Ativo)"

            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao

            If objCommand.Parameters.Contains("@Nome") = False Then
                objCommand.Parameters.AddWithValue("@Nome", clientes.IdCliente)
            Else
                objCommand.Parameters.Item(1).Value = clientes.Nome
            End If

            If objCommand.Parameters.Contains("@Endereco") = False Then
                objCommand.Parameters.AddWithValue("@Endereco", clientes.Endereco)
            Else
                objCommand.Parameters.Item(2).Value = clientes.Endereco
            End If

            If objCommand.Parameters.Contains("@Cidade") = False Then
                objCommand.Parameters.AddWithValue("@Cidade", clientes.Cidade)
            Else
                objCommand.Parameters.Item(3).Value = clientes.Cidade
            End If

            If objCommand.Parameters.Contains("@Telefone") = False Then
                objCommand.Parameters.AddWithValue("@Telefone", clientes.Telefone)
            Else
                objCommand.Parameters.Item(4).Value = clientes.Telefone
            End If

            If objCommand.Parameters.Contains("@Email") = False Then
                objCommand.Parameters.AddWithValue("@Email", clientes.Email)
            Else
                objCommand.Parameters.Item(5).Value = clientes.Email
            End If

            If objCommand.Parameters.Contains("@Ativo") = False Then
                objCommand.Parameters.AddWithValue("@Ativo", clientes.Ativo)
            Else
                objCommand.Parameters.Item(6).Value = clientes.Ativo
            End If

            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Return objCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Function

    Public Function AtualizarCliente(ByVal clientes As ClientesDTO) As Integer

        Try
            strInstrucao = "UPDATE Clientes SET Nome = @Nome," &
                                            "Endereco = @Endereco," &
                                            "Cidade = @Cidade," &
                                            "Telefone = @Telefone," &
                                            "Email = @Email," &
                                            "Ativo = @Ativo " &
                                            "WHERE IdCliente = @IdCliente"

            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao


            If objCommand.Parameters.Contains("@IdCliente") = False Then
                objCommand.Parameters.AddWithValue("@IdCliente", clientes.IdCliente)
            Else
                objCommand.Parameters.Item(0).Value = clientes.IdCliente
            End If

            If objCommand.Parameters.Contains("@Nome") = False Then
                objCommand.Parameters.AddWithValue("@Nome", clientes.Nome)
            Else
                objCommand.Parameters.Item(1).Value = clientes.Nome
            End If

            If objCommand.Parameters.Contains("@Endereco") = False Then
                objCommand.Parameters.AddWithValue("@Endereco", clientes.Endereco)
            Else
                objCommand.Parameters.Item(2).Value = clientes.Endereco
            End If

            If objCommand.Parameters.Contains("@Cidade") = False Then
                objCommand.Parameters.AddWithValue("@Cidade", clientes.Cidade)
            Else
                objCommand.Parameters.Item(3).Value = clientes.Cidade
            End If

            If objCommand.Parameters.Contains("@Telefone") = False Then
                objCommand.Parameters.AddWithValue("@Telefone", clientes.Telefone)
            Else
                objCommand.Parameters.Item(4).Value = clientes.Telefone
            End If

            If objCommand.Parameters.Contains("@Email") = False Then
                objCommand.Parameters.AddWithValue("@Email", clientes.Email)
            Else
                objCommand.Parameters.Item(5).Value = clientes.Email
            End If

            If objCommand.Parameters.Contains("@Ativo") = False Then
                objCommand.Parameters.AddWithValue("@Ativo", clientes.Ativo)
            Else
                objCommand.Parameters.Item(6).Value = clientes.Ativo
            End If


            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Return objCommand.ExecuteNonQuery()



        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConexao.Close()
        End Try


    End Function

    Public Function ExcluirCliente(ByVal idCliente As Integer) As Integer

        Try
            strInstrucao = "DELETE FROM Clientes WHERE IdCliente = @IdCliente"
            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao

            If objCommand.Parameters.Contains("@IdCliente") = False Then
                objCommand.Parameters.AddWithValue("@IdCliente", idCliente)
            Else
                objCommand.Parameters.Item(0).Value = idCliente
            End If


            If (objConexao.State = ConnectionState.Closed) Then
                objConexao.Open()
            End If

            Return objCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Function

    Public Function ConsultarClientes() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet

        Try

            strInstrucao = "SELECT IdCliente,Nome,Endereco,Cidade,Telefone,Email,Ativo FROM Clientes"

            objCommand.CommandText = strInstrucao
            objCommand.Connection = objConexao

            If (objConexao.State = ConnectionState.Closed) Then
                objConexao.Open()
            End If

            Dim da As New SqlDataAdapter(objCommand)

            da.Fill(ds)

            dt = ds.Tables(0)

            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objConexao.Close()
        End Try

    End Function

    Public Function ConsultarPorCriterio(ByVal criterio As String, ByVal pesquisa As String) As DataTable
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet

            objCommand.Connection = objConexao
            objCommand.CommandType = CommandType.Text

            If (criterio = "ID") Then
                strInstrucao = "SELECT * FROM Clientes WHERE IdCliente = @IdCliente"
                If (objCommand.Parameters.Contains("@IdCliente") = False) Then
                    objCommand.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(pesquisa))
                Else
                    objCommand.Parameters.Item(0).Value = pesquisa
                End If

            ElseIf (criterio = "Nome") Then
                strInstrucao = "SELECT * FROM Clientes WHERE Nome LIKE '%" + pesquisa + "%'"
            End If
            objCommand.CommandText = strInstrucao

            If (objConexao.State = ConnectionState.Closed) Then
                objConexao.Open()
            End If

            Dim da As New SqlDataAdapter(objCommand)
            da.Fill(ds)

            dt = ds.Tables(0)

            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
