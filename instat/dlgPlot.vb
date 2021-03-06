﻿' Instat-R
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

Public Class dlgPlot
    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("plot")
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)
        ucrReceiverY.Selector = ucrAddRemove
        ucrReceiverY.SetMeAsReceiver()
        ucrReceiverX.Selector = ucrAddRemove


    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub ucrReceiverY_Leave(sender As Object, e As EventArgs) Handles ucrReceiverY.Leave
        ucrBase.clsRsyntax.AddParameter("y", ucrReceiverY.GetVariables())
    End Sub

    Private Sub ucrReceiverX_Leave(sender As Object, e As EventArgs) Handles ucrReceiverX.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverX.GetVariables())
    End Sub

End Class