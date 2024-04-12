<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.Web_Main = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Tx_Address = New System.Windows.Forms.TextBox()
        Me.But_Go = New System.Windows.Forms.Button()
        CType(Me.Web_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Web_Main
        '
        Me.Web_Main.AllowExternalDrop = True
        Me.Web_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Web_Main.CreationProperties = Nothing
        Me.Web_Main.DefaultBackgroundColor = System.Drawing.Color.White
        Me.Web_Main.Location = New System.Drawing.Point(4, 27)
        Me.Web_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.Web_Main.Name = "Web_Main"
        Me.Web_Main.Size = New System.Drawing.Size(1175, 592)
        Me.Web_Main.Source = New System.Uri("https://google.com", System.UriKind.Absolute)
        Me.Web_Main.TabIndex = 2
        Me.Web_Main.ZoomFactor = 1.0R
        '
        'Tx_Address
        '
        Me.Tx_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Address.BackColor = System.Drawing.Color.White
        Me.Tx_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_Address.ForeColor = System.Drawing.Color.Black
        Me.Tx_Address.Location = New System.Drawing.Point(4, 4)
        Me.Tx_Address.Margin = New System.Windows.Forms.Padding(0)
        Me.Tx_Address.Name = "Tx_Address"
        Me.Tx_Address.Size = New System.Drawing.Size(1130, 23)
        Me.Tx_Address.TabIndex = 0
        '
        'But_Go
        '
        Me.But_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.But_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Go.Location = New System.Drawing.Point(1133, 4)
        Me.But_Go.Margin = New System.Windows.Forms.Padding(0)
        Me.But_Go.Name = "But_Go"
        Me.But_Go.Size = New System.Drawing.Size(46, 23)
        Me.But_Go.TabIndex = 1
        Me.But_Go.Text = "Go"
        Me.But_Go.UseVisualStyleBackColor = True
        '
        'Frm_Main
        '
        Me.AcceptButton = Me.But_Go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1183, 623)
        Me.Controls.Add(Me.But_Go)
        Me.Controls.Add(Me.Tx_Address)
        Me.Controls.Add(Me.Web_Main)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Main"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Main"
        CType(Me.Web_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Web_Main As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Tx_Address As TextBox
    Friend WithEvents But_Go As Button
End Class
