Option Strict Off
Option Explicit On
Module basDeclarations
	Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
End Module