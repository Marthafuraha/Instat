﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDuplicateColumns
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
        Me.grpCopyFrom = New System.Windows.Forms.GroupBox()
        Me.rdoAnotherWorkSheet = New System.Windows.Forms.RadioButton()
        Me.rdoCurrentWorksheet = New System.Windows.Forms.RadioButton()
        Me.grpDataType = New System.Windows.Forms.GroupBox()
        Me.rdoLabelL = New System.Windows.Forms.RadioButton()
        Me.rdoColumnsX = New System.Windows.Forms.RadioButton()
        Me.lblPasteto = New System.Windows.Forms.Label()
        Me.lstPasteInto = New System.Windows.Forms.ListBox()
        Me.chkTranspose = New System.Windows.Forms.CheckBox()
        Me.txtWorksheetName = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpWorksheetName = New System.Windows.Forms.GroupBox()
        Me.ucrAddremove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpCopyFrom.SuspendLayout()
        Me.grpDataType.SuspendLayout()
        Me.grpWorksheetName.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCopyFrom
        '
        Me.grpCopyFrom.Controls.Add(Me.rdoAnotherWorkSheet)
        Me.grpCopyFrom.Controls.Add(Me.rdoCurrentWorksheet)
        Me.grpCopyFrom.Location = New System.Drawing.Point(0, 5)
        Me.grpCopyFrom.Name = "grpCopyFrom"
        Me.grpCopyFrom.Size = New System.Drawing.Size(405, 46)
        Me.grpCopyFrom.TabIndex = 12
        Me.grpCopyFrom.TabStop = False
        Me.grpCopyFrom.Tag = "Copy_Columns_from"
        Me.grpCopyFrom.Text = "Copy Columns from"
        '
        'rdoAnotherWorkSheet
        '
        Me.rdoAnotherWorkSheet.AutoSize = True
        Me.rdoAnotherWorkSheet.Location = New System.Drawing.Point(262, 19)
        Me.rdoAnotherWorkSheet.Name = "rdoAnotherWorkSheet"
        Me.rdoAnotherWorkSheet.Size = New System.Drawing.Size(114, 17)
        Me.rdoAnotherWorkSheet.TabIndex = 2
        Me.rdoAnotherWorkSheet.TabStop = True
        Me.rdoAnotherWorkSheet.Tag = "Another_worksheet"
        Me.rdoAnotherWorkSheet.Text = "Another worksheet"
        Me.rdoAnotherWorkSheet.UseVisualStyleBackColor = True
        '
        'rdoCurrentWorksheet
        '
        Me.rdoCurrentWorksheet.AutoSize = True
        Me.rdoCurrentWorksheet.Location = New System.Drawing.Point(21, 21)
        Me.rdoCurrentWorksheet.Name = "rdoCurrentWorksheet"
        Me.rdoCurrentWorksheet.Size = New System.Drawing.Size(111, 17)
        Me.rdoCurrentWorksheet.TabIndex = 0
        Me.rdoCurrentWorksheet.TabStop = True
        Me.rdoCurrentWorksheet.Tag = "Current_Worksheet"
        Me.rdoCurrentWorksheet.Text = "Current worksheet"
        Me.rdoCurrentWorksheet.UseVisualStyleBackColor = True
        '
        'grpDataType
        '
        Me.grpDataType.Controls.Add(Me.rdoLabelL)
        Me.grpDataType.Controls.Add(Me.rdoColumnsX)
        Me.grpDataType.Enabled = False
        Me.grpDataType.Location = New System.Drawing.Point(6, 57)
        Me.grpDataType.Name = "grpDataType"
        Me.grpDataType.Size = New System.Drawing.Size(399, 46)
        Me.grpDataType.TabIndex = 13
        Me.grpDataType.TabStop = False
        Me.grpDataType.Tag = "Type_of_data"
        Me.grpDataType.Text = "Type of data"
        '
        'rdoLabelL
        '
        Me.rdoLabelL.AutoSize = True
        Me.rdoLabelL.Location = New System.Drawing.Point(262, 19)
        Me.rdoLabelL.Name = "rdoLabelL"
        Me.rdoLabelL.Size = New System.Drawing.Size(64, 17)
        Me.rdoLabelL.TabIndex = 2
        Me.rdoLabelL.TabStop = True
        Me.rdoLabelL.Tag = "Label_L_"
        Me.rdoLabelL.Text = "Type (L)"
        Me.rdoLabelL.UseVisualStyleBackColor = True
        '
        'rdoColumnsX
        '
        Me.rdoColumnsX.AutoSize = True
        Me.rdoColumnsX.Checked = True
        Me.rdoColumnsX.Location = New System.Drawing.Point(21, 21)
        Me.rdoColumnsX.Name = "rdoColumnsX"
        Me.rdoColumnsX.Size = New System.Drawing.Size(81, 17)
        Me.rdoColumnsX.TabIndex = 0
        Me.rdoColumnsX.TabStop = True
        Me.rdoColumnsX.Tag = "Columns_X"
        Me.rdoColumnsX.Text = "Columns (X)"
        Me.rdoColumnsX.UseVisualStyleBackColor = True
        '
        'lblPasteto
        '
        Me.lblPasteto.AutoSize = True
        Me.lblPasteto.Location = New System.Drawing.Point(237, 110)
        Me.lblPasteto.Name = "lblPasteto"
        Me.lblPasteto.Size = New System.Drawing.Size(54, 13)
        Me.lblPasteto.TabIndex = 17
        Me.lblPasteto.Tag = "Paste_Into"
        Me.lblPasteto.Text = "Paste into"
        '
        'lstPasteInto
        '
        Me.lstPasteInto.FormattingEnabled = True
        Me.lstPasteInto.Location = New System.Drawing.Point(240, 126)
        Me.lstPasteInto.Name = "lstPasteInto"
        Me.lstPasteInto.Size = New System.Drawing.Size(136, 108)
        Me.lstPasteInto.Sorted = True
        Me.lstPasteInto.TabIndex = 16
        '
        'chkTranspose
        '
        Me.chkTranspose.AutoSize = True
        Me.chkTranspose.Location = New System.Drawing.Point(6, 244)
        Me.chkTranspose.Name = "chkTranspose"
        Me.chkTranspose.Size = New System.Drawing.Size(76, 17)
        Me.chkTranspose.TabIndex = 15
        Me.chkTranspose.Tag = "Transpose"
        Me.chkTranspose.Text = "Transpose"
        Me.chkTranspose.UseVisualStyleBackColor = True
        '
        'txtWorksheetName
        '
        Me.txtWorksheetName.Location = New System.Drawing.Point(6, 19)
        Me.txtWorksheetName.Name = "txtWorksheetName"
        Me.txtWorksheetName.Size = New System.Drawing.Size(207, 20)
        Me.txtWorksheetName.TabIndex = 8
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(318, 16)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 9
        Me.cmdBrowse.Tag = "Browse"
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpWorksheetName
        '
        Me.grpWorksheetName.Controls.Add(Me.txtWorksheetName)
        Me.grpWorksheetName.Controls.Add(Me.cmdBrowse)
        Me.grpWorksheetName.Enabled = False
        Me.grpWorksheetName.Location = New System.Drawing.Point(6, 267)
        Me.grpWorksheetName.Name = "grpWorksheetName"
        Me.grpWorksheetName.Size = New System.Drawing.Size(399, 46)
        Me.grpWorksheetName.TabIndex = 18
        Me.grpWorksheetName.TabStop = False
        Me.grpWorksheetName.Tag = "Worksheet_name"
        Me.grpWorksheetName.Text = "Worksheet name"
        '
        'ucrAddremove
        '
        Me.ucrAddremove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrAddremove.Location = New System.Drawing.Point(6, 110)
        Me.ucrAddremove.Name = "ucrAddremove"
        Me.ucrAddremove.Size = New System.Drawing.Size(207, 127)
        Me.ucrAddremove.TabIndex = 14
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 319)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(413, 51)
        Me.ucrBase.TabIndex = 11
        '
        'dlgDuplicateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 370)
        Me.Controls.Add(Me.grpCopyFrom)
        Me.Controls.Add(Me.grpDataType)
        Me.Controls.Add(Me.lblPasteto)
        Me.Controls.Add(Me.lstPasteInto)
        Me.Controls.Add(Me.chkTranspose)
        Me.Controls.Add(Me.grpWorksheetName)
        Me.Controls.Add(Me.ucrAddremove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDuplicateColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Duplicate_copy_paste_columns"
        Me.Text = "Duplicate (copy/paste) columns"
        Me.grpCopyFrom.ResumeLayout(False)
        Me.grpCopyFrom.PerformLayout()
        Me.grpDataType.ResumeLayout(False)
        Me.grpDataType.PerformLayout()
        Me.grpWorksheetName.ResumeLayout(False)
        Me.grpWorksheetName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCopyFrom As GroupBox
    Friend WithEvents rdoAnotherWorkSheet As RadioButton
    Friend WithEvents rdoCurrentWorksheet As RadioButton
    Friend WithEvents grpDataType As GroupBox
    Friend WithEvents rdoLabelL As RadioButton
    Friend WithEvents rdoColumnsX As RadioButton
    Friend WithEvents lblPasteto As Label
    Friend WithEvents lstPasteInto As ListBox
    Friend WithEvents chkTranspose As CheckBox
    Friend WithEvents txtWorksheetName As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents grpWorksheetName As GroupBox
    Friend WithEvents ucrAddremove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
End Class
