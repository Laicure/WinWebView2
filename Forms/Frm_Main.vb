Public Class Frm_Main

#Region "Form"

	Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Sub_FormIconText(Me, "WinWebView2 Playground v" & My.Application.Info.Version.ToString)
	End Sub

#End Region

#Region "Controls"

	Private Sub But_Go_Click(sender As Object, e As EventArgs) Handles But_Go.Click
		Dim NavURL As String = Tx_Address.Text.Trim
		If String.IsNullOrWhiteSpace(NavURL) Then Exit Sub

		Web_Main.CoreWebView2.Navigate(NavURL)
	End Sub

#End Region

#Region "Web"

	Private Sub Web_Main_SourceChanged(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs) Handles Web_Main.SourceChanged
		Tx_Address.Text = Web_Main.Source.AbsoluteUri
	End Sub

	Private Sub Web_Main_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles Web_Main.NavigationCompleted
		Web_Main.ExecuteScriptAsync("document.getElementsByName('q')[0].value='test'")
		Web_Main.ExecuteScriptAsync("document.getElementsByName('btnK')[0].click()")
	End Sub

#End Region

End Class
