Module Mod_Generic
	Friend cul_invar As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
	Friend str_newLine As String = Environment.NewLine
	Friend strs_errX As String() = {""}
	Friend dtm_ExecStart As Date = Date.Now

	Friend str_DesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
	Friend str_Username As String = Environment.UserName

#Region "Form"

	Friend Sub Sub_FormIconText(targetForm As Form, formCaption As String)
		With targetForm
			.Icon = My.Resources.Iconizer
			.Text = formCaption
		End With
	End Sub

	Friend Sub Sub_LogToTextBox(txtbox As TextBox, descr As String)
		txtbox.Text = "[" & DateTime.Now.ToString("hh:mm:ss tt", cul_invar) & "]" & str_newLine & descr & str_newLine & str_newLine & txtbox.Text.Trim
	End Sub

#End Region

#Region "Extras"

	Friend Sub Sub_CreateDTColumns(columnHeaders As List(Of String), ByRef datatb As DataTable)
		Dim uniqueColCount As Integer = 0
		For Each str As String In columnHeaders
			If datatb.Columns.Contains(str.Trim) Then
				uniqueColCount += 1
				str &= uniqueColCount.ToString("0")
			End If
			datatb.Columns.Add(str.Trim)
		Next
	End Sub

	Friend Function Func_IsSameString(strA As String, strB As String) As Boolean
		Return strA.Trim.Equals(strB.Trim, StringComparison.OrdinalIgnoreCase)
	End Function

	Friend Sub Sub_ApplyDataGridViewProperties(ByVal datagrid As DataGridView)
		Sub_DoubleBuff(datagrid)
		With datagrid
			.SuspendLayout()
			.AutoGenerateColumns = False
			.BackgroundColor = Color.White
			.BackColor = Color.White
			.ForeColor = Color.Black
			.DefaultCellStyle.BackColor = Color.White
			.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
			.GridColor = Color.Brown
			.ReadOnly = True
			.TabStop = False
			.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			.RowHeadersVisible = False
			.MultiSelect = False
			.AllowUserToAddRows = False
			.AllowUserToDeleteRows = False
			.AllowUserToOrderColumns = False
			.AllowUserToResizeColumns = True
			.AllowUserToResizeRows = False
			.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
			.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
			.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			.VirtualMode = False
			.TabIndex = 0
			.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
			.DefaultCellStyle.SelectionBackColor = Color.White
			.DefaultCellStyle.SelectionForeColor = Color.Black
			.ResumeLayout()
		End With
	End Sub

	Friend Sub Sub_DoubleBuff(ByVal Contt As Control)
		Dim ConttType As Type = Contt.GetType()
		Dim propInfo As Reflection.PropertyInfo = ConttType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
		propInfo.SetValue(Contt, True, Nothing)
	End Sub

	Friend Sub Sub_StartTimer()
		dtm_ExecStart = DateTime.UtcNow
	End Sub

	Friend Function Func_EndTimer() As String
		Return DateTime.UtcNow.Subtract(dtm_ExecStart).ToString.Substring(0, 8)
	End Function

	Friend Function Func_StringNum(numb As Long) As String
		Return numb.ToString("0", cul_invar)
	End Function

	Friend Sub STAClipboard(tx As String)
		Dim STAThread As New Threading.Thread(
				Sub()
					Clipboard.SetText(tx.Trim)
				End Sub
				)
		With STAThread
			.SetApartmentState(Threading.ApartmentState.STA)
			.Start()
			.Join()
		End With
	End Sub

#End Region

#Region "Report"

	Friend Function Func_ReportSaveTo(descr As String) As String
		Using SaveToBrowse As New FolderBrowserDialog
			With SaveToBrowse
				.Description = descr
				.RootFolder = Environment.SpecialFolder.Desktop
				.ShowNewFolderButton = True
				If .ShowDialog = DialogResult.OK Then
					Return .SelectedPath
				Else
					Return String.Empty
				End If
			End With
		End Using
	End Function

	Friend Function Func_ReportOpenFile(filter As String, title As String) As String
		Using OpenFileBrowse As New OpenFileDialog
			With OpenFileBrowse
				.Title = title
				.Filter = filter
				.FileName = ""
				If .ShowDialog = DialogResult.OK Then
					Return .FileName
				Else
					Return String.Empty
				End If
			End With
		End Using
	End Function

#End Region

End Module
