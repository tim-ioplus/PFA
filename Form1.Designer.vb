<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
		tbSearchTransaction = New TextBox()
		cmbSearchRepository = New ComboBox()
		dgvTransactions = New DataGridView()
		dgcIdColumn = New DataGridViewTextBoxColumn()
		dgcReceiverName = New DataGridViewTextBoxColumn()
		dgcReceiverIban = New DataGridViewTextBoxColumn()
		dgcTransactionDate = New DataGridViewTextBoxColumn()
		dgcTransactionTopic = New DataGridViewTextBoxColumn()
		dgcTransactionAmount = New DataGridViewTextBoxColumn()

		CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' tbSearchTransaction
		' 
		tbSearchTransaction.Location = New Point(12, 12)
		tbSearchTransaction.Name = "tbSearchTransaction"
		tbSearchTransaction.Size = New Size(450, 23)
		tbSearchTransaction.TabIndex = 0
		'
		' cmbSearchRepository
		'
		cmbSearchRepository.Location = New Point(525, 12)
		cmbSearchRepository.Name = "cmbSearchRepository"
		cmbSearchRepository.Size = New Size(100, 23)
		cmbSearchRepository.TabIndex = 0
		cmbSearchRepository.DropDownWidth = 100
		cmbSearchRepository.Items.AddRange(New Object() {RepositoryType.Csv, RepositoryType.LocalTestData, RepositoryType.Sql})
		' 
		' dgvTransactions
		' 
		dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		'dgvTransactions.Columns.AddRange(New DataGridViewColumn() {dgcIdColumn, dgcReceiverName, dgcReceiverIban, dgcTransactionDate, dgcTransactionTopic, dgcTransactionAmount})
		dgvTransactions.Location = New Point(12, 53)
		dgvTransactions.Name = "dgvTransactions"
		dgvTransactions.Size = New Size(643, 385)
		dgvTransactions.TabIndex = 1
		' 
		' dgcIdColumn
		' 
		DataGridViewCellStyle1.NullValue = Nothing
		dgcIdColumn.DefaultCellStyle = DataGridViewCellStyle1
		dgcIdColumn.HeaderText = "Id"
		dgcIdColumn.Name = "dgcIdColumn"
		' 
		' dgcReceiverName
		' 
		dgcReceiverName.HeaderText = "Empfänger Name"
		dgcReceiverName.Name = "dgcReceiverName"
		dgcReceiverName.ToolTipText = "defined in designer"
		' 
		' dgcReceiverIban
		' 
		dgcReceiverIban.HeaderText = "Iban"
		dgcReceiverIban.Name = "dgcReceiverIban"
		' 
		' dgcTransactionDate
		' 
		DataGridViewCellStyle2.Format = "d"
		DataGridViewCellStyle2.NullValue = Nothing
		dgcTransactionDate.DefaultCellStyle = DataGridViewCellStyle2
		dgcTransactionDate.HeaderText = "Wertstellung"
		dgcTransactionDate.Name = "dgcTransactionDate"
		' 
		' dgcTransactionTopic
		' 
		dgcTransactionTopic.HeaderText = "Betreff"
		dgcTransactionTopic.Name = "dgcTransactionTopic"
		' 
		' dgcTransactionAmount
		' 
		DataGridViewCellStyle3.Format = "C2"
		DataGridViewCellStyle3.NullValue = Nothing
		dgcTransactionAmount.DefaultCellStyle = DataGridViewCellStyle3
		dgcTransactionAmount.HeaderText = "Betrag"
		dgcTransactionAmount.Name = "dgcTransactionAmount"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(667, 450)
		Controls.Add(dgvTransactions)
		Controls.Add(cmbSearchRepository)
		Controls.Add(tbSearchTransaction)
		Name = "Form1"
		Text = "Form1"
		AddHandler tbSearchTransaction.TextChanged, New EventHandler(AddressOf TbSearchTransaction_TextChanged)
		AddHandler cmbSearchRepository.SelectedIndexChanged, New EventHandler(AddressOf cbSearchTestRepository_SelectedIndexChanged)

		CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub


	Public WithEvents tbSearchTransaction As TextBox
	Public WithEvents cmbSearchRepository As ComboBox
	Public WithEvents dgvTransactions As DataGridView
	Public WithEvents dgcIdColumn As DataGridViewTextBoxColumn
	Public WithEvents dgcReceiverName As DataGridViewTextBoxColumn
	Public WithEvents dgcReceiverIban As DataGridViewTextBoxColumn
	Public WithEvents dgcTransactionDate As DataGridViewTextBoxColumn
	Public WithEvents dgcTransactionTopic As DataGridViewTextBoxColumn
	Public WithEvents dgcTransactionAmount As DataGridViewTextBoxColumn

End Class



