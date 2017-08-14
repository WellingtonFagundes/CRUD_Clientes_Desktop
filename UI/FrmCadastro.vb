Imports BLL
Imports DTO

Public Class FrmCadastro

    Public idCliente As Integer = 0

    Private Sub FrmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Gravar()
        Dim classe As New ClientesBLL
        Dim objeto As New ClientesDTO

        objeto.Nome = txtNome.Text.Trim()
        objeto.Endereco = txtEndereco.Text.Trim()
        objeto.Cidade = txtCidade.Text.Trim()
        objeto.Email = txtEmail.Text.Trim()
        objeto.Telefone = mskTelefone.Text.Trim()

        If rbtAtivo.Checked Then
            objeto.Ativo = True
        Else
            objeto.Ativo = False
        End If

        If (classe.ValidarCampos(objeto) = False) Then
            MessageBox.Show("Verifique se existe algum dado não informado", "Advertindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If (idCliente > 0) Then
            objeto.IdCliente = idCliente
            If (classe.AtualizarCliente(objeto) > 0) Then
                MessageBox.Show("Cliente alterado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If (classe.GravarCliente(objeto) > 0) Then
                MessageBox.Show("Cliente inserido com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNome.Text = ""
                txtEndereco.Text = ""
                txtEmail.Text = ""
                txtCidade.Text = ""
                mskTelefone.Text = ""
                rbtAtivo.Checked = True
                rbtInativo.Checked = False
                idCliente = 0
            End If
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Gravar()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        frmConsulta.Show()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtEmail.Text = ""
        mskTelefone.Text = ""
        rbtAtivo.Checked = True
        rbtInativo.Checked = False
        idCliente = 0
        txtNome.Focus()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        If (MessageBox.Show("Deseja continuar no programa?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

End Class
