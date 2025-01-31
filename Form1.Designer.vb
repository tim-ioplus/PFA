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
		btnSearch = New Button()
		btnCancel = New Button()

		CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()

		' 
		' tbSearchTransaction
		' 
		tbSearchTransaction.Location = New Point(12, 12)
		tbSearchTransaction.Name = "tbSearchTransaction"
		tbSearchTransaction.Size = New Size(400, 23)
		tbSearchTransaction.TabIndex = 0
		'
		' cmbSearchRepository
		'
		cmbSearchRepository.Location = New Point(425, 12)
		cmbSearchRepository.Name = "cmbSearchRepository"
		cmbSearchRepository.Size = New Size(100, 23)
		cmbSearchRepository.TabIndex = 0
		cmbSearchRepository.DropDownWidth = 100
		cmbSearchRepository.Items.AddRange(New Object() {RepositoryType.Csv, RepositoryType.LocalTestData, RepositoryType.Sql})
		'
		' btnSearch
		'
		btnSearch.Location = New Point(530, 12)
		btnSearch.Name = "cmbSearchRepository"
		btnSearch.Size = New Size(100, 23)
		btnSearch.Text = "Suchen"
		btnSearch.TabIndex = 0
		'
		' btnCancel
		'
		btnCancel.Location = New Point(635, 12)
		btnCancel.Name = "cmbSearchRepository"
		btnCancel.Size = New Size(23, 23)
		btnCancel.Text = "X"
		btnCancel.TabIndex = 0
		' 
		' dgvTransactions
		' 
		dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvTransactions.Location = New Point(12, 53)
		dgvTransactions.Name = "dgvTransactions"
		dgvTransactions.Size = New Size(643, 385)
		dgvTransactions.TabIndex = 1
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(667, 450)
		Controls.Add(dgvTransactions)
		Controls.Add(cmbSearchRepository)
		Controls.Add(tbSearchTransaction)
		Controls.Add(btnSearch)
		Controls.Add(btnCancel)
		Name = "Form1"
		Text = "Form1"
		AddHandler tbSearchTransaction.TextChanged, New EventHandler(AddressOf TbSearchTransaction_TextChanged)
		AddHandler cmbSearchRepository.SelectedIndexChanged, New EventHandler(AddressOf cbSearchTestRepository_SelectedIndexChanged)
		AddHandler btnSearch.Click, New EventHandler(AddressOf BtnSearch_Click)
		AddHandler btnCancel.Click, New EventHandler(AddressOf BtnCancel_Click)

		CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub


	Public WithEvents tbSearchTransaction As TextBox
	Public WithEvents cmbSearchRepository As ComboBox
	Public WithEvents dgvTransactions As DataGridView
	Public WithEvents btnSearch As Button
	Public WithEvents btnCancel As Button

End Class



