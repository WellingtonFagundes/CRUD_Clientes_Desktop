<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.colCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEndereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAtivo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoPesquisa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvDados
        '
        Me.lsvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCodigo, Me.colNome, Me.colEndereco, Me.colCidade, Me.colTelefone, Me.colEmail, Me.colAtivo})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(12, 77)
        Me.lsvDados.MultiSelect = False
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(731, 283)
        Me.lsvDados.TabIndex = 0
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'colCodigo
        '
        Me.colCodigo.Text = "Código"
        '
        'colNome
        '
        Me.colNome.Text = "Nome"
        Me.colNome.Width = 120
        '
        'colEndereco
        '
        Me.colEndereco.Text = "Endereço"
        Me.colEndereco.Width = 200
        '
        'colCidade
        '
        Me.colCidade.Text = "Cidade"
        Me.colCidade.Width = 110
        '
        'colTelefone
        '
        Me.colTelefone.Text = "Telefone"
        Me.colTelefone.Width = 90
        '
        'colEmail
        '
        Me.colEmail.Text = "Email"
        Me.colEmail.Width = 100
        '
        'colAtivo
        '
        Me.colAtivo.Text = "Ativo?"
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(161, 378)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(114, 44)
        Me.btnAlterar.TabIndex = 16
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(332, 378)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(114, 44)
        Me.btnExcluir.TabIndex = 17
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVoltar.Location = New System.Drawing.Point(492, 378)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(114, 44)
        Me.btnVoltar.TabIndex = 18
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Selecione o tipo de Pesquisa:"
        '
        'cmbTipoPesquisa
        '
        Me.cmbTipoPesquisa.FormattingEnabled = True
        Me.cmbTipoPesquisa.Items.AddRange(New Object() {"ID", "Nome"})
        Me.cmbTipoPesquisa.Location = New System.Drawing.Point(161, 31)
        Me.cmbTipoPesquisa.Name = "cmbTipoPesquisa"
        Me.cmbTipoPesquisa.Size = New System.Drawing.Size(125, 21)
        Me.cmbTipoPesquisa.TabIndex = 20
        Me.cmbTipoPesquisa.Text = "Selecione uma opção "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Informe o texto de pesquisa:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(452, 31)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(167, 20)
        Me.txtPesquisa.TabIndex = 22
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(629, 18)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(114, 44)
        Me.btnPesquisar.TabIndex = 23
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 434)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipoPesquisa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.lsvDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvDados As ListView
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents colCodigo As ColumnHeader
    Friend WithEvents colNome As ColumnHeader
    Friend WithEvents colEndereco As ColumnHeader
    Friend WithEvents colTelefone As ColumnHeader
    Friend WithEvents colAtivo As ColumnHeader
    Friend WithEvents colCidade As ColumnHeader
    Friend WithEvents colEmail As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoPesquisa As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents btnPesquisar As Button
End Class
