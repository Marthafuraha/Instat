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

Public Class Distribution
    Public strNameTag As String
    Public bIncluded As Boolean = True
    Public strRFunctionName As String = ""
    Public strPFunctionName As String = ""
    Public strQFunctionName As String = ""
    Public strDFunctionName As String = ""
    Public strGLMFunctionName As String = ""
    Public clsParameters As New List(Of DistributionParameter)

    Public Sub SetNameTag(strTemp As String)
        strNameTag = strTemp
    End Sub

    Public Sub AddParameter(strArgumentName As String, strNameTag As String, Optional DefaultValue As Decimal = 9999)
        Dim NewParameter As New DistributionParameter
        NewParameter.strArgumentName = strArgumentName
        NewParameter.strNameTag = strNameTag
        If Not DefaultValue = 9999 Then
            NewParameter.SetDefaultValue(DefaultValue)
        End If
        clsParameters.Add(NewParameter)
    End Sub
End Class

Public Class DistributionParameter
    Public strArgumentName As String
    Public strNameTag As String
    Public dcmDefaultValue As Decimal
    Public bHasDefault As Boolean = False

    Public Sub SetDefaultValue(Val As Decimal)
        dcmDefaultValue = Val
        bHasDefault = True
    End Sub
End Class