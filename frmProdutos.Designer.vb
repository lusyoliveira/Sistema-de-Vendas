<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpProdutos = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnProcurar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProduto = New System.Windows.Forms.TextBox
        Me.lstProdutos = New System.Windows.Forms.ListView
        Me.clmCod = New System.Windows.Forms.ColumnHeader
        Me.clmNome = New System.Windows.Forms.ColumnHeader
        Me.clmValor = New System.Windows.Forms.ColumnHeader
        Me.grpProdutos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProdutos
        '
        Me.grpProdutos.Controls.Add(Me.Label3)
        Me.grpProdutos.Controls.Add(Me.Label2)
        Me.grpProdutos.Controls.Add(Me.txtValor)
        Me.grpProdutos.Controls.Add(Me.txtNome)
        Me.grpProdutos.Controls.Add(Me.btnExcluir)
        Me.grpProdutos.Controls.Add(Me.btnSalvar)
        Me.grpProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProdutos.Location = New System.Drawing.Point(29, 380)
        Me.grpProdutos.Name = "grpProdutos"
        Me.grpProdutos.Size = New System.Drawing.Size(513, 131)
        Me.grpProdutos.TabIndex = 0
        Me.grpProdutos.TabStop = False
        Me.grpProdutos.Tag = "0"
        Me.grpProdutos.Text = "Dados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nome"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(378, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(119, 24)
        Me.txtValor.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(68, 35)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(248, 24)
        Me.txtNome.TabIndex = 3
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(269, 75)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(130, 31)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        Me.btnExcluir.Visible = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(111, 75)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(130, 32)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnProcurar
        '
        Me.btnProcurar.AccessibleName = "Procurar"
        Me.btnProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.Location = New System.Drawing.Point(276, 19)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(130, 27)
        Me.btnProcurar.TabIndex = 1
        Me.btnProcurar.Tag = ""
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(412, 19)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(130, 27)
        Me.btnNovo.TabIndex = 2
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Produto"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(29, 24)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(241, 20)
        Me.txtProduto.TabIndex = 5
        '
        'lstProdutos
        '
        Me.lstProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmCod, Me.clmNome, Me.clmValor})
        Me.lstProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProdutos.FullRowSelect = True
        Me.lstProdutos.Location = New System.Drawing.Point(29, 62)
        Me.lstProdutos.MultiSelect = False
        Me.lstProdutos.Name = "lstProdutos"
        Me.lstProdutos.Size = New System.Drawing.Size(513, 305)
        Me.lstProdutos.TabIndex = 6
        Me.lstProdutos.UseCompatibleStateImageBehavior = False
        Me.lstProdutos.View = System.Windows.Forms.View.Details
        '
        'clmCod
        '
        Me.clmCod.Text = "Código"
        '
        'clmNome
        '
        Me.clmNome.Text = "Nome"
        Me.clmNome.Width = 330
        '
        'clmValor
        '
        Me.clmValor.Text = "Valor"
        Me.clmValor.Width = 90
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 523)
        Me.Controls.Add(Me.lstProdutos)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.grpProdutos)
        Me.Name = "frmProdutos"
        Me.Text = "Produto"
        Me.grpProdutos.ResumeLayout(False)
        Me.grpProdutos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstProdutos As System.Windows.Forms.ListView
    Friend WithEvents clmCod As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmNome As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmValor As System.Windows.Forms.ColumnHeader

End Class
