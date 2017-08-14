Imports DAL
Imports DTO

'Camada de Negócios (BLL)
Public Class ClientesBLL

    Public Function GravarCliente(ByVal cliente As ClientesDTO) As Integer
        Try
            Dim db As New ClientesDAL
            Dim cod As Integer

            cod = db.GravarCliente(cliente)

            Return cod
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function AtualizarCliente(ByVal cliente As ClientesDTO) As Integer
        Try
            Dim db As New ClientesDAL
            Dim cod As Integer

            cod = db.AtualizarCliente(cliente)

            Return cod
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ExcluirCliente(ByVal idcliente As Integer) As Integer
        Try
            Dim db As New ClientesDAL
            Dim cod As Integer

            cod = db.ExcluirCliente(idcliente)

            Return cod
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ConsultarCliente() As DataTable
        Try
            Dim db As New ClientesDAL
            Dim dt As DataTable

            dt = db.ConsultarClientes()

            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ConsultarPorCriterio(ByVal criterio As String, ByVal pesquisa As String) As DataTable
        Try
            Dim db As New ClientesDAL
            Dim dt As DataTable

            dt = db.ConsultarPorCriterio(criterio, pesquisa)

            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ValidarCampos(ByVal cliente As ClientesDTO) As Boolean
        Dim blnResult = False

        If (cliente.Nome.Equals(String.Empty)) Then
            blnResult = False
        ElseIf (cliente.Endereco.Equals(String.Empty)) Then
            blnResult = False
        ElseIf (cliente.Cidade.Equals(String.Empty)) Then
            blnResult = False
        ElseIf (cliente.Email.Equals(String.Empty)) Then
            blnResult = False
        ElseIf (cliente.Ativo.Equals(String.Empty)) Then
            blnResult = False
        ElseIf (cliente.Telefone.Equals("(  )     -")) Then
            blnResult = False
        Else
            blnResult = True
        End If

        Return blnResult
    End Function
End Class
