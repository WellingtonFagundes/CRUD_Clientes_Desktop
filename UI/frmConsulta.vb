Imports BLL

Public Class frmConsulta

    'Recebe o indice da listview
    Public index As Integer

    Private Sub lsvDados_Click(sender As Object, e As EventArgs) Handles lsvDados.Click
        If (lsvDados.SelectedItems.Count > 0) Then
            'Coleta o item selecionado
            index = lsvDados.SelectedItems(0).Index
        End If
    End Sub

    Private Sub CarregarListView()
        Dim objDados As New ClientesBLL
        Dim dt As New DataTable

        dt = objDados.ConsultarCliente()

        For Each linha As DataRow In dt.Rows
            Dim lista As New ListViewItem

            lista.Text = linha("IdCliente").ToString()
            lista.SubItems.Add(linha("Nome").ToString())
            lista.SubItems.Add(linha("Endereco").ToString())
            lista.SubItems.Add(linha("Cidade").ToString())
            lista.SubItems.Add(linha("Telefone").ToString())
            lista.SubItems.Add(linha("Email").ToString())

            If linha("Ativo").ToString().Equals("True") Then
                lista.SubItems.Add("Sim")
            Else
                lista.SubItems.Add("Não")
            End If

            lsvDados.Items.Add(lista)
        Next
    End Sub

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarListView()
    End Sub

    Private Function ExcluirCliente(ByVal idcliente As Integer) As Integer
        Dim objDados As New ClientesBLL

        Return objDados.ExcluirCliente(idcliente)
    End Function

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If lsvDados.SelectedItems.Count > 0 Then
            If (MessageBox.Show("Deseja excluir este cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then

                If (ExcluirCliente(Integer.Parse(lsvDados.Items(index).Text)) > 0) Then
                    MessageBox.Show("Cliente excluído com sucesso!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lsvDados.Items.Clear()
                    CarregarListView()
                End If

            End If
        Else
            MessageBox.Show("Favor para excluir selecione um cliente específico", "Advertindo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If lsvDados.SelectedItems.Count > 0 Then
            'Dim instancia As New FrmCadastro()

            FrmCadastro.idCliente = Integer.Parse(lsvDados.Items(index).Text)
            FrmCadastro.txtNome.Text = lsvDados.Items(index).SubItems(1).Text
            FrmCadastro.txtEndereco.Text = lsvDados.Items(index).SubItems(2).Text
            FrmCadastro.txtCidade.Text = lsvDados.Items(index).SubItems(3).Text
            FrmCadastro.mskTelefone.Text = lsvDados.Items(index).SubItems(4).Text
            FrmCadastro.txtEmail.Text = lsvDados.Items(index).SubItems(5).Text

            If (lsvDados.Items(index).SubItems(6).Text.Equals("Sim")) Then
                FrmCadastro.rbtAtivo.Checked = True
            Else
                FrmCadastro.rbtInativo.Checked = True
            End If

            Me.Close()
        Else
            MessageBox.Show("Para alterar selecione um cliente específico", "Advertindo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim clienteBLL As New ClientesBLL
        Dim dt As New DataTable

        If (cmbTipoPesquisa.SelectedIndex = -1) Then
            MessageBox.Show("Selecione um critério específico para a pesquisa", "Advertindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf (txtPesquisa.Text = String.Empty) Then
            MessageBox.Show("Digite uma pesquisa específica", "Advertindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf (cmbTipoPesquisa.SelectedItem.Equals("ID")) Then
            dt = clienteBLL.ConsultarPorCriterio("ID", txtPesquisa.Text)
        ElseIf (cmbTipoPesquisa.SelectedItem.Equals("Nome")) Then
            dt = clienteBLL.ConsultarPorCriterio("Nome", txtPesquisa.Text)

        End If

        lsvDados.Items.Clear()

        For Each linha As DataRow In dt.Rows
            Dim lista As New ListViewItem

            lista.Text = Convert.ToInt32(linha("IdCliente"))
            lista.SubItems.Add(linha("Nome").ToString())
            lista.SubItems.Add(linha("Endereco").ToString())
            lista.SubItems.Add(linha("Cidade").ToString())
            lista.SubItems.Add(linha("Telefone").ToString())
            lista.SubItems.Add(linha("Email").ToString())

            If linha("Ativo").ToString().Equals("True") Then
                lista.SubItems.Add("Sim")
            Else
                lista.SubItems.Add("Não")
            End If

            lsvDados.Items.Add(lista)
        Next
    End Sub
End Class