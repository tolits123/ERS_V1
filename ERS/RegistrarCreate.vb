﻿Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing.Imaging
Public Class RegistrarCreate
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AdminPanel.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim encodingtypestring As String = String.Empty
        Try
            If PictureBox1.ImageLocation.ToLower.EndsWith(".jpg") Then
                encodeType = ImageFormat.Jpeg
                encodingtypestring = "data:image/jpeg:base64,"
            ElseIf PictureBox1.ImageLocation.ToLower.EndsWith(".png") Then
                encodeType = ImageFormat.Png
                encodingtypestring = "data:image/png:base64,"
            End If
        Catch
        End Try
        Try
            decoding = encodingtypestring
            pic = encodingtypestring & imagetobase64(PictureBox1.Image, encodeType)
            Try
                registrarCreate1()
            Catch
            End Try
        Catch ex As Exception
            MsgBox("Must upload or take picture.")
        End Try

    End Sub
    Public Function imagetobase64(ByVal image As Image, ByVal format As ImageFormat) As String
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageByte As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageByte)
            Return base64String
        End Using
    End Function
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            AdminPanel.Show()
            Me.Close()
        End If
    End Sub
    Private Sub RegistrarCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                pic = OpenFileDialog1.FileName
            End If
            PictureBox1.Image = Image.FromFile(pic)
        Catch
            MsgBox("Please select picture.")

            PictureBox1.Image = PictureBox1.ErrorImage
        End Try
    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Webcam.Show()
    End Sub

    Private Sub cno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class