﻿'Instat-R
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

Imports instat.Translations
Public Class dlgNon_ParametricANOVA
    Private Sub dlgNon_ParametricANOVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverYVariate.Selector = ucrAddRemove
        ucrReceiverYVariate.SetMeAsReceiver()
        ucrReceiverFactor.Selector = ucrAddRemove
        autoTranslate(Me)

        ucrBase.OKEnabled(False)

    End Sub

    Private Sub ucrReceiverYVariate_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverYVariate.ValueChanged
        FillFormula()

    End Sub

    Private Sub ucrReceiverFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactor.ValueChanged
        FillFormula()
    End Sub
    Private Sub FillFormula()
        Dim strYVariate As String
        Dim strFactor As String
        strYVariate = ucrReceiverYVariate.GetVariables()
        strFactor = ucrReceiverFactor.GetVariables()
        If ((Not (strYVariate = "")) And (Not (strFactor = ""))) Then
            ucrBase.clsRsyntax.AddParameter("formula", strYVariate & "~" & strFactor)
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
End Class