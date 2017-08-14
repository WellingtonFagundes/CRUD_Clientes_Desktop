<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastro))
        Me.grClientes = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbtInativo = New System.Windows.Forms.RadioButton()
        Me.rbtAtivo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grClientes
        '
        Me.grClientes.Controls.Add(Me.btnSair)
        Me.grClientes.Controls.Add(Me.btnLimpar)
        Me.grClientes.Controls.Add(Me.btnVer)
        Me.grClientes.Controls.Add(Me.btnGravar)
        Me.grClientes.Controls.Add(Me.PictureBox1)
        Me.grClientes.Controls.Add(Me.rbtInativo)
        Me.grClientes.Controls.Add(Me.rbtAtivo)
        Me.grClientes.Controls.Add(Me.Label6)
        Me.grClientes.Controls.Add(Me.mskTelefone)
        Me.grClientes.Controls.Add(Me.txtEmail)
        Me.grClientes.Controls.Add(Me.Label5)
        Me.grClientes.Controls.Add(Me.Label4)
        Me.grClientes.Controls.Add(Me.txtCidade)
        Me.grClientes.Controls.Add(Me.Label3)
        Me.grClientes.Controls.Add(Me.txtEndereco)
        Me.grClientes.Controls.Add(Me.Label2)
        Me.grClientes.Controls.Add(Me.txtNome)
        Me.grClientes.Controls.Add(Me.Label1)
        Me.grClientes.Location = New System.Drawing.Point(13, 13)
        Me.grClientes.Name = "grClientes"
        Me.grClientes.Size = New System.Drawing.Size(499, 315)
        Me.grClientes.TabIndex = 0
        Me.grClientes.TabStop = False
        Me.grClientes.Text = "Clientes"
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSair.Location = New System.Drawing.Point(366, 258)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(114, 44)
        Me.btnSair.TabIndex = 17
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLimpar.Location = New System.Drawing.Point(246, 258)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(114, 44)
        Me.btnLimpar.TabIndex = 16
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Image = CType(resources.GetObject("btnVer.Image"), System.Drawing.Image)
        Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVer.Location = New System.Drawing.Point(126, 258)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(114, 44)
        Me.btnVer.TabIndex = 15
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGravar.Location = New System.Drawing.Point(6, 258)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(114, 44)
        Me.btnGravar.TabIndex = 14
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 139)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'rbtInativo
        '
        Me.rbtInativo.AutoSize = True
        Me.rbtInativo.Location = New System.Drawing.Point(274, 208)
        Me.rbtInativo.Name = "rbtInativo"
        Me.rbtInativo.Size = New System.Drawing.Size(57, 17)
        Me.rbtInativo.TabIndex = 12
        Me.rbtInativo.TabStop = True
        Me.rbtInativo.Text = "Inativo"
        Me.rbtInativo.UseVisualStyleBackColor = True
        '
        'rbtAtivo
        '
        Me.rbtAtivo.AutoSize = True
        Me.rbtAtivo.Checked = True
        Me.rbtAtivo.Location = New System.Drawing.Point(219, 208)
        Me.rbtAtivo.Name = "rbtAtivo"
        Me.rbtAtivo.Size = New System.Drawing.Size(49, 17)
        Me.rbtAtivo.TabIndex = 11
        Me.rbtAtivo.TabStop = True
        Me.rbtAtivo.Text = "Ativo"
        Me.rbtAtivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Status:"
        '
        'mskTelefone
        '
        Me.mskTelefone.Location = New System.Drawing.Point(219, 136)
        Me.mskTelefone.Mask = "(99) 9999-9999"
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(94, 20)
        Me.mskTelefone.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(219, 172)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(253, 20)
        Me.txtEmail.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefone:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(220, 103)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(203, 20)
        Me.txtCidade.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cidade:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(220, 67)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(267, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Endereço:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(219, 30)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(268, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'FrmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 337)
        Me.Controls.Add(Me.grClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.grClientes.ResumeLayout(False)
        Me.grClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grClientes As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLimpar As Button
    Public WithEvents mskTelefone As MaskedTextBox
    Public WithEvents txtEmail As TextBox
    Public WithEvents txtCidade As TextBox
    Public WithEvents txtEndereco As TextBox
    Public WithEvents txtNome As TextBox
    Public WithEvents rbtInativo As RadioButton
    Public WithEvents rbtAtivo As RadioButton
End Class
