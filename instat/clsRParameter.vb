﻿' Instat+R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class RParameter
    Public strArgumentName As String
    Public strArgumentValue As String
    Public clsArgumentFunction As RFunction
    Public bIsFunction As Boolean = False

    Public Sub SetArgumentName(strTemp As String)
        strArgumentName = strTemp
    End Sub

    Public Sub SetArgumentValue(strTemp As String)
        strArgumentValue = strTemp
        bIsFunction = False
    End Sub

    Public Sub SetArgumentFunction(clsFunc As RFunction)
        clsArgumentFunction = clsFunc
        bIsFunction = True
    End Sub

    Public Function ToScript(ByRef strScript As String) As String
        If bIsFunction Then
            Return strArgumentName & "=" & clsArgumentFunction.ToScript(strScript)
        Else
            Return strArgumentName & "=" & strArgumentValue
        End If
    End Function
End Class