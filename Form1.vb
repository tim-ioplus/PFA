Public Class Form1

	Private _transactionDataTableAdapter As IDataTableAdapter
	Private _adapters As Dictionary(Of RepositoryType, IDataTableAdapter)

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		_adapters = New Dictionary(Of RepositoryType, IDataTableAdapter)
		_adapters.Add(RepositoryType.LocalTestData, New TransactionDataTableAdapter(RepositoryType.LocalTestData))
		_adapters.Add(RepositoryType.Csv, New TransactionDataTableAdapter(RepositoryType.Csv))
		_adapters.Add(RepositoryType.Sql, New TransactionDataTableAdapter(RepositoryType.Sql))

		Me.cmbSearchRepository.SelectedIndex = 0

		cbSearchTestRepository_SelectedIndexChanged(Me.cmbSearchRepository, Nothing)

		List()

	End Sub
	Private Sub Find(ByVal searchText As String)

		Dim results As DataTable = _transactionDataTableAdapter.Find(searchText)
		dgvTransactions.DataSource = results

	End Sub

	Private Sub List()

		Dim results As DataTable = _transactionDataTableAdapter.List
		dgvTransactions.DataSource = results

	End Sub

	Private Sub TbSearchTransaction_TextChanged(sender As Object, e As EventArgs)

		If tbSearchTransaction.Text.Length >= 2 Then
			Find(tbSearchTransaction.Text)
		End If

	End Sub


	Private Sub cbSearchTestRepository_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim cmbSearchRepo As ComboBox = sender
		_transactionDataTableAdapter = _adapters(cmbSearchRepo.SelectedItem)

		List()

	End Sub

End Class
