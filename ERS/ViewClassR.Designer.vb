﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewClassR
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sec = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subj = New System.Windows.Forms.ComboBox()
        Me.SearchSubj_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sec)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 74)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Information"
        '
        'sec
        '
        Me.sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sec.FormattingEnabled = True
        Me.sec.Location = New System.Drawing.Point(96, 29)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(160, 21)
        Me.sec.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Section"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.subj)
        Me.GroupBox1.Controls.Add(Me.SearchSubj_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 81)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Subject"
        '
        'subj
        '
        Me.subj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subj.FormattingEnabled = True
        Me.subj.Items.AddRange(New Object() {"Grade 1", "Grade 2 ", "Grade 3"})
        Me.subj.Location = New System.Drawing.Point(104, 30)
        Me.subj.Name = "subj"
        Me.subj.Size = New System.Drawing.Size(160, 21)
        Me.subj.TabIndex = 4
        '
        'SearchSubj_btn
        '
        Me.SearchSubj_btn.Location = New System.Drawing.Point(270, 31)
        Me.SearchSubj_btn.Name = "SearchSubj_btn"
        Me.SearchSubj_btn.Size = New System.Drawing.Size(75, 23)
        Me.SearchSubj_btn.TabIndex = 2
        Me.SearchSubj_btn.Text = "Search"
        Me.SearchSubj_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Grade Level:"
        '
        'ViewClassR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 199)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ViewClassR"
        Me.Text = "ViewSubjectR"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents subj As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSubj_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.ComboBox
End Class