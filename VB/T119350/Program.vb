﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace T119350
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New fmDesigner())
		End Sub
	End Class
End Namespace
