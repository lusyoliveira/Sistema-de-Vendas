Public Class frmProdutos

    Private Sub LimparProduto()
        grpProdutos.Tag = 0
        txtNome.Text = ""
        txtValor.Text = ""
        btnExcluir.Visible = False
    End Sub
    Private Sub CarregarProdutos()
        Dim dtProdutos As DataTable, x As Integer, sql As String
        LimparProduto()
        lstProdutos.Items.Clear()
        sql = "select * from tbprodutos where nome like '%" & txtProduto.Text & "%'"
        If IsNumeric(txtProduto.Text) Then
            sql = "select * from tbprodutos where codP = " & txtProduto.Text
        End If
        dtProdutos = RecebeTabela(sql, tpServidor.SqlServer)
        If dtProdutos IsNot Nothing AndAlso dtProdutos.Rows.Count > 0 Then
            For Each row As DataRow In dtProdutos.Rows
                Dim item As New ListViewItem(row("codP").ToString())
                item.SubItems.Add(row("nome").ToString())
                item.SubItems.Add(Format(row("valor"), "0.00"))
                lstProdutos.Items.Add(item)
                x += 1
            Next
        End If
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        ' Procura o produto pelo código armazenado na propriedade Tag
        Dim tbprodutos As ADODB.Recordset
        tbprodutos = RecebeTabela("select * from tbprodutos where codP = " & grpProdutos.Tag)
        If grpProdutos.Tag = 0 Then tbprodutos.AddNew() ' Se for um novo adciona um registro
        tbprodutos("nome").Value = txtNome.Text
        tbprodutos("valor").Value = CDec(txtValor.Text) '.Replace(",", ".")
        tbprodutos.Update() ' Confirma a mudança dos dados
        CarregarProdutos() ' Atualiza a exibição dos dados
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbprodutos As ADODB.Recordset
        tbprodutos = RecebeTabela("select * from tbprodutos where codP = " & grpProdutos.Tag)
        If tbprodutos.RecordCount = 0 Then Exit Sub ' Verifica se realmente exite
        tbprodutos.Delete()
        CarregarProdutos()
    End Sub

    Private Sub btnProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurar.Click
        CarregarProdutos()
    End Sub

    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CarregarProdutos()
    End Sub

    Private Sub lstProdutos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProdutos.SelectedIndexChanged
        ' Verifica se existe produto selecionado na lista para evitar erro
        If lstProdutos.SelectedItems.Count = 0 Then
            LimparProduto()
            Exit Sub
        End If
        ' Carrega as informações
        grpProdutos.Tag = Val(lstProdutos.SelectedItems(0).SubItems(0).Text)
        txtNome.Text = lstProdutos.SelectedItems(0).SubItems(1).Text
        txtValor.Text = lstProdutos.SelectedItems(0).SubItems(2).Text
        btnExcluir.Visible = True
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        LimparProduto()
        txtNome.Focus()
    End Sub
End Class
