Imports System.Linq.Expressions

Public Class Form1
    Private Sub SetAllButtonsToWhite()
        For Each button As Button In Me.Controls.OfType(Of Button)()
            If button.BackColor = Color.White OrElse button.BackColor = Color.Red OrElse button.BackColor = Color.Gray Then
                button.BackColor = Color.White
            End If
        Next
    End Sub

    Dim checkBlock As Integer = 0
    Dim userStatus As Integer = 0
    Dim lineCount As Integer = 0
    Dim clickCount As Integer = 1
    '--------------------------------------------------------------
    Dim blockLine1 As Integer = 0
    Dim blockLine2 As Integer = 0
    Dim blockLine3 As Integer = 0
    Dim blockLine4 As Integer = 0
    Dim blockLine5 As Integer = 0
    Dim blockLine6 As Integer = 0
    Dim blockLine7 As Integer = 0
    Dim blockLine8 As Integer = 0
    Dim blockLine9 As Integer = 0
    '--------------------------------------------------------------
    Private Sub First_Block(sender As Object, e As EventArgs) _
    Handles Button1.Click, Button2.Click, Button3.Click, Button10.Click, Button11.Click, Button12.Click, Button19.Click, Button20.Click, Button21.Click
        SetAllButtonsToWhite()
        '------------------------------------------------
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 1 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1

        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button1.Text = Button2.Text AndAlso Button2.Text = Button3.Text AndAlso Button3.Text <> "") Then
            If blockLine1 = 0 Then
                If Button1.Text = "O" Then
                    Button1.BackColor = Color.Blue
                    Button2.BackColor = Color.Blue
                    Button3.BackColor = Color.Blue
                Else
                    Button1.BackColor = Color.Yellow
                    Button2.BackColor = Color.Yellow
                    Button3.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button10.Text = Button11.Text AndAlso Button11.Text = Button12.Text AndAlso Button12.Text <> "") Then
            If blockLine1 = 0 Then
                If Button10.Text = "O" Then
                    Button10.BackColor = Color.Blue
                    Button11.BackColor = Color.Blue
                    Button12.BackColor = Color.Blue
                Else
                    Button10.BackColor = Color.Yellow
                    Button11.BackColor = Color.Yellow
                    Button12.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button19.Text = Button20.Text AndAlso Button20.Text = Button21.Text AndAlso Button21.Text <> "") Then
            If blockLine1 = 0 Then
                If Button19.Text = "O" Then
                    Button19.BackColor = Color.Blue
                    Button20.BackColor = Color.Blue
                    Button21.BackColor = Color.Blue
                Else
                    Button19.BackColor = Color.Yellow
                    Button20.BackColor = Color.Yellow
                    Button21.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button1.Text = Button10.Text AndAlso Button10.Text = Button19.Text AndAlso Button19.Text <> "") Then
            If blockLine1 = 0 Then
                If Button1.Text = "O" Then
                    Button1.BackColor = Color.Blue
                    Button10.BackColor = Color.Blue
                    Button19.BackColor = Color.Blue
                Else
                    Button1.BackColor = Color.Yellow
                    Button10.BackColor = Color.Yellow
                    Button19.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button2.Text = Button11.Text AndAlso Button11.Text = Button20.Text AndAlso Button20.Text <> "") Then
            If blockLine1 = 0 Then
                If Button2.Text = "O" Then
                    Button2.BackColor = Color.Blue
                    Button11.BackColor = Color.Blue
                    Button20.BackColor = Color.Blue
                Else
                    Button2.BackColor = Color.Yellow
                    Button11.BackColor = Color.Yellow
                    Button20.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button3.Text = Button12.Text AndAlso Button12.Text = Button21.Text AndAlso Button21.Text <> "") Then
            If blockLine1 = 0 Then
                If Button3.Text = "O" Then
                    Button3.BackColor = Color.Blue
                    Button12.BackColor = Color.Blue
                    Button21.BackColor = Color.Blue
                Else
                    Button3.BackColor = Color.Yellow
                    Button12.BackColor = Color.Yellow
                    Button21.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button1.Text = Button11.Text AndAlso Button11.Text = Button21.Text AndAlso Button21.Text <> "") Then
            If blockLine1 = 0 Then
                If Button1.Text = "O" Then
                    Button1.BackColor = Color.Blue
                    Button11.BackColor = Color.Blue
                    Button21.BackColor = Color.Blue
                Else
                    Button1.BackColor = Color.Yellow
                    Button11.BackColor = Color.Yellow
                    Button21.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        If (Button3.Text = Button11.Text AndAlso Button11.Text = Button19.Text AndAlso Button19.Text <> "") Then
            If blockLine1 = 0 Then
                If Button3.Text = "O" Then
                    Button3.BackColor = Color.Blue
                    Button11.BackColor = Color.Blue
                    Button19.BackColor = Color.Blue
                Else
                    Button3.BackColor = Color.Yellow
                    Button11.BackColor = Color.Yellow
                    Button19.BackColor = Color.Yellow
                End If
                blockLine1 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 1
                userStatus = 1
            Case 2
                userStatus = 2
            Case 3
                userStatus = 3
            Case 10
                userStatus = 4
            Case 11
                userStatus = 5
            Case 12
                userStatus = 6
            Case 19
                userStatus = 7
            Case 20
                userStatus = 8
            Case 21
                userStatus = 9
        End Select
        '-----------------------------------------------------
        If Button1.Enabled = False AndAlso Button2.Enabled = False AndAlso Button3.Enabled = False AndAlso
        Button10.Enabled = False AndAlso Button11.Enabled = False AndAlso Button12.Enabled = False AndAlso
        Button19.Enabled = False AndAlso Button20.Enabled = False AndAlso Button21.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub Second_Block(sender As Object, e As EventArgs) _
    Handles Button4.Click, Button5.Click, Button6.Click, Button13.Click, Button14.Click, Button15.Click, Button22.Click, Button23.Click, Button24.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 2 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button4.Text = Button5.Text AndAlso Button5.Text = Button6.Text AndAlso Button6.Text <> "") Then
            If blockLine2 = 0 Then
                If Button4.Text = "O" Then
                    Button4.BackColor = Color.Blue
                    Button5.BackColor = Color.Blue
                    Button6.BackColor = Color.Blue
                Else
                    Button4.BackColor = Color.Yellow
                    Button5.BackColor = Color.Yellow
                    Button6.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button13.Text = Button14.Text AndAlso Button14.Text = Button15.Text AndAlso Button15.Text <> "") Then
            If blockLine2 = 0 Then
                If Button13.Text = "O" Then
                    Button13.BackColor = Color.Blue
                    Button14.BackColor = Color.Blue
                    Button15.BackColor = Color.Blue
                Else
                    Button13.BackColor = Color.Yellow
                    Button14.BackColor = Color.Yellow
                    Button15.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button22.Text = Button23.Text AndAlso Button23.Text = Button24.Text AndAlso Button24.Text <> "") Then
            If blockLine2 = 0 Then
                If Button22.Text = "O" Then
                    Button22.BackColor = Color.Blue
                    Button23.BackColor = Color.Blue
                    Button24.BackColor = Color.Blue
                Else
                    Button22.BackColor = Color.Yellow
                    Button23.BackColor = Color.Yellow
                    Button24.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button4.Text = Button13.Text AndAlso Button13.Text = Button22.Text AndAlso Button22.Text <> "") Then
            If blockLine2 = 0 Then
                If Button4.Text = "O" Then
                    Button4.BackColor = Color.Blue
                    Button13.BackColor = Color.Blue
                    Button22.BackColor = Color.Blue
                Else
                    Button4.BackColor = Color.Yellow
                    Button13.BackColor = Color.Yellow
                    Button22.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button5.Text = Button14.Text AndAlso Button14.Text = Button23.Text AndAlso Button23.Text <> "") Then
            If blockLine2 = 0 Then
                If Button5.Text = "O" Then
                    Button5.BackColor = Color.Blue
                    Button14.BackColor = Color.Blue
                    Button23.BackColor = Color.Blue
                Else
                    Button5.BackColor = Color.Yellow
                    Button14.BackColor = Color.Yellow
                    Button23.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button6.Text = Button15.Text AndAlso Button15.Text = Button24.Text AndAlso Button24.Text <> "") Then
            If blockLine2 = 0 Then
                If Button6.Text = "O" Then
                    Button6.BackColor = Color.Blue
                    Button15.BackColor = Color.Blue
                    Button24.BackColor = Color.Blue
                Else
                    Button6.BackColor = Color.Yellow
                    Button15.BackColor = Color.Yellow
                    Button24.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button4.Text = Button14.Text AndAlso Button14.Text = Button24.Text AndAlso Button24.Text <> "") Then
            If blockLine2 = 0 Then
                If Button4.Text = "O" Then
                    Button4.BackColor = Color.Blue
                    Button14.BackColor = Color.Blue
                    Button24.BackColor = Color.Blue
                Else
                    Button4.BackColor = Color.Yellow
                    Button14.BackColor = Color.Yellow
                    Button24.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        If (Button6.Text = Button14.Text AndAlso Button14.Text = Button22.Text AndAlso Button22.Text <> "") Then
            If blockLine2 = 0 Then
                If Button6.Text = "O" Then
                    Button6.BackColor = Color.Blue
                    Button14.BackColor = Color.Blue
                    Button22.BackColor = Color.Blue
                Else
                    Button6.BackColor = Color.Yellow
                    Button14.BackColor = Color.Yellow
                    Button22.BackColor = Color.Yellow
                End If
                blockLine2 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 4
                userStatus = 1
            Case 5
                userStatus = 2
            Case 6
                userStatus = 3
            Case 13
                userStatus = 4
            Case 14
                userStatus = 5
            Case 15
                userStatus = 6
            Case 22
                userStatus = 7
            Case 23
                userStatus = 8
            Case 24
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button4.Enabled = False AndAlso Button5.Enabled = False AndAlso Button6.Enabled = False AndAlso
        Button13.Enabled = False AndAlso Button14.Enabled = False AndAlso Button15.Enabled = False AndAlso
        Button22.Enabled = False AndAlso Button23.Enabled = False AndAlso Button24.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub third_Block(sender As Object, e As EventArgs) _
    Handles Button7.Click, Button8.Click, Button9.Click, Button16.Click, Button17.Click, Button18.Click, Button25.Click, Button26.Click, Button27.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 3 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button7.Text = Button8.Text AndAlso Button8.Text = Button9.Text AndAlso Button9.Text <> "") Then
            If blockLine3 = 0 Then
                If Button7.Text = "O" Then
                    Button7.BackColor = Color.Blue
                    Button8.BackColor = Color.Blue
                    Button9.BackColor = Color.Blue
                Else
                    Button7.BackColor = Color.Yellow
                    Button8.BackColor = Color.Yellow
                    Button9.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button16.Text = Button17.Text AndAlso Button17.Text = Button18.Text AndAlso Button18.Text <> "") Then
            If blockLine3 = 0 Then
                If Button16.Text = "O" Then
                    Button16.BackColor = Color.Blue
                    Button17.BackColor = Color.Blue
                    Button18.BackColor = Color.Blue
                Else
                    Button16.BackColor = Color.Yellow
                    Button17.BackColor = Color.Yellow
                    Button18.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button25.Text = Button26.Text AndAlso Button26.Text = Button27.Text AndAlso Button27.Text <> "") Then
            If blockLine3 = 0 Then
                If Button25.Text = "O" Then
                    Button25.BackColor = Color.Blue
                    Button26.BackColor = Color.Blue
                    Button27.BackColor = Color.Blue
                Else
                    Button25.BackColor = Color.Yellow
                    Button26.BackColor = Color.Yellow
                    Button27.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button7.Text = Button16.Text AndAlso Button16.Text = Button25.Text AndAlso Button25.Text <> "") Then
            If blockLine3 = 0 Then
                If Button7.Text = "O" Then
                    Button7.BackColor = Color.Blue
                    Button16.BackColor = Color.Blue
                    Button25.BackColor = Color.Blue
                Else
                    Button7.BackColor = Color.Yellow
                    Button16.BackColor = Color.Yellow
                    Button25.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button8.Text = Button17.Text AndAlso Button17.Text = Button26.Text AndAlso Button26.Text <> "") Then
            If blockLine3 = 0 Then
                If Button8.Text = "O" Then
                    Button8.BackColor = Color.Blue
                    Button17.BackColor = Color.Blue
                    Button26.BackColor = Color.Blue
                Else
                    Button8.BackColor = Color.Yellow
                    Button17.BackColor = Color.Yellow
                    Button26.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button9.Text = Button18.Text AndAlso Button18.Text = Button27.Text AndAlso Button27.Text <> "") Then
            If blockLine3 = 0 Then
                If Button9.Text = "O" Then
                    Button9.BackColor = Color.Blue
                    Button18.BackColor = Color.Blue
                    Button27.BackColor = Color.Blue
                Else
                    Button9.BackColor = Color.Yellow
                    Button18.BackColor = Color.Yellow
                    Button27.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button7.Text = Button17.Text AndAlso Button17.Text = Button27.Text AndAlso Button27.Text <> "") Then
            If blockLine3 = 0 Then
                If Button7.Text = "O" Then
                    Button7.BackColor = Color.Blue
                    Button17.BackColor = Color.Blue
                    Button27.BackColor = Color.Blue
                Else
                    Button7.BackColor = Color.Yellow
                    Button17.BackColor = Color.Yellow
                    Button27.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        If (Button9.Text = Button17.Text AndAlso Button17.Text = Button25.Text AndAlso Button25.Text <> "") Then
            If blockLine3 = 0 Then
                If Button9.Text = "O" Then
                    Button9.BackColor = Color.Blue
                    Button17.BackColor = Color.Blue
                    Button25.BackColor = Color.Blue
                Else
                    Button9.BackColor = Color.Yellow
                    Button17.BackColor = Color.Yellow
                    Button25.BackColor = Color.Yellow
                End If
                blockLine3 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 7
                userStatus = 1
            Case 8
                userStatus = 2
            Case 9
                userStatus = 3
            Case 16
                userStatus = 4
            Case 17
                userStatus = 5
            Case 18
                userStatus = 6
            Case 25
                userStatus = 7
            Case 26
                userStatus = 8
            Case 27
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button7.Enabled = False AndAlso Button8.Enabled = False AndAlso Button9.Enabled = False AndAlso
        Button16.Enabled = False AndAlso Button17.Enabled = False AndAlso Button18.Enabled = False AndAlso
        Button25.Enabled = False AndAlso Button26.Enabled = False AndAlso Button27.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub fourth_Block(sender As Object, e As EventArgs) _
    Handles Button28.Click, Button29.Click, Button30.Click, Button37.Click, Button38.Click, Button39.Click, Button46.Click, Button47.Click, Button48.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 4 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button28.Text = Button29.Text AndAlso Button29.Text = Button30.Text AndAlso Button30.Text <> "") Then
            If blockLine4 = 0 Then
                If Button28.Text = "O" Then
                    Button28.BackColor = Color.Blue
                    Button29.BackColor = Color.Blue
                    Button30.BackColor = Color.Blue
                Else
                    Button28.BackColor = Color.Yellow
                    Button29.BackColor = Color.Yellow
                    Button30.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button37.Text = Button38.Text AndAlso Button38.Text = Button39.Text AndAlso Button39.Text <> "") Then
            If blockLine4 = 0 Then
                If Button37.Text = "O" Then
                    Button37.BackColor = Color.Blue
                    Button38.BackColor = Color.Blue
                    Button39.BackColor = Color.Blue
                Else
                    Button37.BackColor = Color.Yellow
                    Button38.BackColor = Color.Yellow
                    Button39.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button46.Text = Button47.Text AndAlso Button47.Text = Button48.Text AndAlso Button48.Text <> "") Then
            If blockLine4 = 0 Then
                If Button46.Text = "O" Then
                    Button46.BackColor = Color.Blue
                    Button47.BackColor = Color.Blue
                    Button48.BackColor = Color.Blue
                Else
                    Button46.BackColor = Color.Yellow
                    Button47.BackColor = Color.Yellow
                    Button48.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button28.Text = Button37.Text AndAlso Button37.Text = Button46.Text AndAlso Button46.Text <> "") Then
            If blockLine4 = 0 Then
                If Button28.Text = "O" Then
                    Button28.BackColor = Color.Blue
                    Button37.BackColor = Color.Blue
                    Button46.BackColor = Color.Blue
                Else
                    Button28.BackColor = Color.Yellow
                    Button37.BackColor = Color.Yellow
                    Button46.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button29.Text = Button38.Text AndAlso Button38.Text = Button47.Text AndAlso Button47.Text <> "") Then
            If blockLine4 = 0 Then
                If Button29.Text = "O" Then
                    Button29.BackColor = Color.Blue
                    Button38.BackColor = Color.Blue
                    Button47.BackColor = Color.Blue
                Else
                    Button29.BackColor = Color.Yellow
                    Button38.BackColor = Color.Yellow
                    Button47.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button30.Text = Button39.Text AndAlso Button39.Text = Button48.Text AndAlso Button48.Text <> "") Then
            If blockLine4 = 0 Then
                If Button30.Text = "O" Then
                    Button30.BackColor = Color.Blue
                    Button39.BackColor = Color.Blue
                    Button48.BackColor = Color.Blue
                Else
                    Button30.BackColor = Color.Yellow
                    Button39.BackColor = Color.Yellow
                    Button48.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button28.Text = Button38.Text AndAlso Button38.Text = Button48.Text AndAlso Button48.Text <> "") Then
            If blockLine4 = 0 Then
                If Button28.Text = "O" Then
                    Button28.BackColor = Color.Blue
                    Button38.BackColor = Color.Blue
                    Button48.BackColor = Color.Blue
                Else
                    Button28.BackColor = Color.Yellow
                    Button38.BackColor = Color.Yellow
                    Button48.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        If (Button30.Text = Button38.Text AndAlso Button38.Text = Button46.Text AndAlso Button46.Text <> "") Then
            If blockLine4 = 0 Then
                If Button30.Text = "O" Then
                    Button30.BackColor = Color.Blue
                    Button38.BackColor = Color.Blue
                    Button46.BackColor = Color.Blue
                Else
                    Button30.BackColor = Color.Yellow
                    Button38.BackColor = Color.Yellow
                    Button46.BackColor = Color.Yellow
                End If
                blockLine4 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 28
                userStatus = 1
            Case 29
                userStatus = 2
            Case 30
                userStatus = 3
            Case 37
                userStatus = 4
            Case 38
                userStatus = 5
            Case 39
                userStatus = 6
            Case 46
                userStatus = 7
            Case 47
                userStatus = 8
            Case 48
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button28.Enabled = False AndAlso Button29.Enabled = False AndAlso Button30.Enabled = False AndAlso
        Button37.Enabled = False AndAlso Button38.Enabled = False AndAlso Button39.Enabled = False AndAlso
        Button46.Enabled = False AndAlso Button47.Enabled = False AndAlso Button48.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub fifth_Block(sender As Object, e As EventArgs) _
    Handles Button31.Click, Button32.Click, Button33.Click, Button40.Click, Button41.Click, Button42.Click, Button49.Click, Button50.Click, Button51.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 5 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button31.Text = Button32.Text AndAlso Button32.Text = Button33.Text AndAlso Button33.Text <> "") Then
            If blockLine5 = 0 Then
                If Button31.Text = "O" Then
                    Button31.BackColor = Color.Blue
                    Button32.BackColor = Color.Blue
                    Button33.BackColor = Color.Blue
                Else
                    Button31.BackColor = Color.Yellow
                    Button32.BackColor = Color.Yellow
                    Button33.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button40.Text = Button41.Text AndAlso Button41.Text = Button42.Text AndAlso Button42.Text <> "") Then
            If blockLine5 = 0 Then
                If Button40.Text = "O" Then
                    Button40.BackColor = Color.Blue
                    Button41.BackColor = Color.Blue
                    Button42.BackColor = Color.Blue
                Else
                    Button40.BackColor = Color.Yellow
                    Button41.BackColor = Color.Yellow
                    Button42.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button49.Text = Button50.Text AndAlso Button50.Text = Button51.Text AndAlso Button51.Text <> "") Then
            If blockLine5 = 0 Then
                If Button49.Text = "O" Then
                    Button49.BackColor = Color.Blue
                    Button50.BackColor = Color.Blue
                    Button51.BackColor = Color.Blue
                Else
                    Button49.BackColor = Color.Yellow
                    Button50.BackColor = Color.Yellow
                    Button51.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button31.Text = Button40.Text AndAlso Button40.Text = Button49.Text AndAlso Button49.Text <> "") Then
            If blockLine5 = 0 Then
                If Button31.Text = "O" Then
                    Button31.BackColor = Color.Blue
                    Button40.BackColor = Color.Blue
                    Button49.BackColor = Color.Blue
                Else
                    Button31.BackColor = Color.Yellow
                    Button40.BackColor = Color.Yellow
                    Button49.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button32.Text = Button41.Text AndAlso Button41.Text = Button50.Text AndAlso Button50.Text <> "") Then
            If blockLine5 = 0 Then
                If Button32.Text = "O" Then
                    Button32.BackColor = Color.Blue
                    Button41.BackColor = Color.Blue
                    Button50.BackColor = Color.Blue
                Else
                    Button32.BackColor = Color.Yellow
                    Button41.BackColor = Color.Yellow
                    Button50.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button33.Text = Button42.Text AndAlso Button42.Text = Button51.Text AndAlso Button51.Text <> "") Then
            If blockLine5 = 0 Then
                If Button33.Text = "O" Then
                    Button33.BackColor = Color.Blue
                    Button42.BackColor = Color.Blue
                    Button51.BackColor = Color.Blue
                Else
                    Button33.BackColor = Color.Yellow
                    Button42.BackColor = Color.Yellow
                    Button51.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button31.Text = Button41.Text AndAlso Button41.Text = Button51.Text AndAlso Button51.Text <> "") Then
            If blockLine5 = 0 Then
                If Button31.Text = "O" Then
                    Button31.BackColor = Color.Blue
                    Button41.BackColor = Color.Blue
                    Button51.BackColor = Color.Blue
                Else
                    Button31.BackColor = Color.Yellow
                    Button41.BackColor = Color.Yellow
                    Button51.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        If (Button33.Text = Button41.Text AndAlso Button41.Text = Button49.Text AndAlso Button49.Text <> "") Then
            If blockLine5 = 0 Then
                If Button33.Text = "O" Then
                    Button33.BackColor = Color.Blue
                    Button41.BackColor = Color.Blue
                    Button49.BackColor = Color.Blue
                Else
                    Button33.BackColor = Color.Yellow
                    Button41.BackColor = Color.Yellow
                    Button49.BackColor = Color.Yellow
                End If
                blockLine5 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 31
                userStatus = 1
            Case 32
                userStatus = 2
            Case 33
                userStatus = 3
            Case 40
                userStatus = 4
            Case 41
                userStatus = 5
            Case 42
                userStatus = 6
            Case 49
                userStatus = 7
            Case 50
                userStatus = 8
            Case 51
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button31.Enabled = False AndAlso Button32.Enabled = False AndAlso Button33.Enabled = False AndAlso
        Button40.Enabled = False AndAlso Button41.Enabled = False AndAlso Button42.Enabled = False AndAlso
        Button49.Enabled = False AndAlso Button50.Enabled = False AndAlso Button51.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub sixth_Block(sender As Object, e As EventArgs) _
    Handles Button34.Click, Button35.Click, Button36.Click, Button43.Click, Button44.Click, Button45.Click, Button52.Click, Button53.Click, Button54.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 6 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button34.Text = Button35.Text AndAlso Button35.Text = Button36.Text AndAlso Button36.Text <> "") Then
            If blockLine6 = 0 Then
                If Button34.Text = "O" Then
                    Button34.BackColor = Color.Blue
                    Button35.BackColor = Color.Blue
                    Button36.BackColor = Color.Blue
                Else
                    Button34.BackColor = Color.Yellow
                    Button35.BackColor = Color.Yellow
                    Button36.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button43.Text = Button44.Text AndAlso Button44.Text = Button45.Text AndAlso Button45.Text <> "") Then
            If blockLine6 = 0 Then
                If Button43.Text = "O" Then
                    Button43.BackColor = Color.Blue
                    Button44.BackColor = Color.Blue
                    Button45.BackColor = Color.Blue
                Else
                    Button43.BackColor = Color.Yellow
                    Button44.BackColor = Color.Yellow
                    Button45.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button52.Text = Button53.Text AndAlso Button53.Text = Button54.Text AndAlso Button54.Text <> "") Then
            If blockLine6 = 0 Then
                If Button52.Text = "O" Then
                    Button52.BackColor = Color.Blue
                    Button53.BackColor = Color.Blue
                    Button54.BackColor = Color.Blue
                Else
                    Button52.BackColor = Color.Yellow
                    Button53.BackColor = Color.Yellow
                    Button54.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button34.Text = Button43.Text AndAlso Button43.Text = Button52.Text AndAlso Button52.Text <> "") Then
            If blockLine6 = 0 Then
                If Button34.Text = "O" Then
                    Button34.BackColor = Color.Blue
                    Button43.BackColor = Color.Blue
                    Button52.BackColor = Color.Blue
                Else
                    Button34.BackColor = Color.Yellow
                    Button43.BackColor = Color.Yellow
                    Button52.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button35.Text = Button44.Text AndAlso Button44.Text = Button53.Text AndAlso Button53.Text <> "") Then
            If blockLine6 = 0 Then
                If Button35.Text = "O" Then
                    Button35.BackColor = Color.Blue
                    Button44.BackColor = Color.Blue
                    Button53.BackColor = Color.Blue
                Else
                    Button35.BackColor = Color.Yellow
                    Button44.BackColor = Color.Yellow
                    Button53.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button36.Text = Button45.Text AndAlso Button45.Text = Button54.Text AndAlso Button54.Text <> "") Then
            If blockLine6 = 0 Then
                If Button36.Text = "O" Then
                    Button36.BackColor = Color.Blue
                    Button45.BackColor = Color.Blue
                    Button54.BackColor = Color.Blue
                Else
                    Button36.BackColor = Color.Yellow
                    Button45.BackColor = Color.Yellow
                    Button54.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button34.Text = Button44.Text AndAlso Button44.Text = Button54.Text AndAlso Button54.Text <> "") Then
            If blockLine6 = 0 Then
                If Button34.Text = "O" Then
                    Button34.BackColor = Color.Blue
                    Button44.BackColor = Color.Blue
                    Button54.BackColor = Color.Blue
                Else
                    Button34.BackColor = Color.Yellow
                    Button44.BackColor = Color.Yellow
                    Button54.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        If (Button36.Text = Button44.Text AndAlso Button44.Text = Button52.Text AndAlso Button52.Text <> "") Then
            If blockLine6 = 0 Then
                If Button36.Text = "O" Then
                    Button36.BackColor = Color.Blue
                    Button44.BackColor = Color.Blue
                    Button52.BackColor = Color.Blue
                Else
                    Button36.BackColor = Color.Yellow
                    Button44.BackColor = Color.Yellow
                    Button52.BackColor = Color.Yellow
                End If
                blockLine6 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 34
                userStatus = 1
            Case 35
                userStatus = 2
            Case 36
                userStatus = 3
            Case 43
                userStatus = 4
            Case 44
                userStatus = 5
            Case 45
                userStatus = 6
            Case 52
                userStatus = 7
            Case 53
                userStatus = 8
            Case 54
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button34.Enabled = False AndAlso Button35.Enabled = False AndAlso Button36.Enabled = False AndAlso
        Button43.Enabled = False AndAlso Button44.Enabled = False AndAlso Button45.Enabled = False AndAlso
        Button52.Enabled = False AndAlso Button53.Enabled = False AndAlso Button54.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub seventh_Block(sender As Object, e As EventArgs) _
    Handles Button55.Click, Button56.Click, Button57.Click, Button64.Click, Button65.Click, Button66.Click, Button73.Click, Button74.Click, Button75.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 7 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button55.Text = Button56.Text AndAlso Button56.Text = Button57.Text AndAlso Button57.Text <> "") Then
            If blockLine7 = 0 Then
                If Button55.Text = "O" Then
                    Button55.BackColor = Color.Blue
                    Button56.BackColor = Color.Blue
                    Button57.BackColor = Color.Blue
                Else
                    Button55.BackColor = Color.Yellow
                    Button56.BackColor = Color.Yellow
                    Button57.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button64.Text = Button65.Text AndAlso Button65.Text = Button66.Text AndAlso Button66.Text <> "") Then
            If blockLine7 = 0 Then
                If Button64.Text = "O" Then
                    Button64.BackColor = Color.Blue
                    Button65.BackColor = Color.Blue
                    Button66.BackColor = Color.Blue
                Else
                    Button64.BackColor = Color.Yellow
                    Button65.BackColor = Color.Yellow
                    Button66.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button73.Text = Button74.Text AndAlso Button74.Text = Button75.Text AndAlso Button75.Text <> "") Then
            If blockLine7 = 0 Then
                If Button73.Text = "O" Then
                    Button73.BackColor = Color.Blue
                    Button74.BackColor = Color.Blue
                    Button75.BackColor = Color.Blue
                Else
                    Button73.BackColor = Color.Yellow
                    Button74.BackColor = Color.Yellow
                    Button75.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button55.Text = Button64.Text AndAlso Button64.Text = Button73.Text AndAlso Button73.Text <> "") Then
            If blockLine7 = 0 Then
                If Button55.Text = "O" Then
                    Button55.BackColor = Color.Blue
                    Button64.BackColor = Color.Blue
                    Button73.BackColor = Color.Blue
                Else
                    Button55.BackColor = Color.Yellow
                    Button64.BackColor = Color.Yellow
                    Button73.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button56.Text = Button65.Text AndAlso Button65.Text = Button74.Text AndAlso Button74.Text <> "") Then
            If blockLine7 = 0 Then
                If Button56.Text = "O" Then
                    Button56.BackColor = Color.Blue
                    Button65.BackColor = Color.Blue
                    Button74.BackColor = Color.Blue
                Else
                    Button56.BackColor = Color.Yellow
                    Button65.BackColor = Color.Yellow
                    Button74.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button57.Text = Button66.Text AndAlso Button66.Text = Button75.Text AndAlso Button75.Text <> "") Then
            If blockLine7 = 0 Then
                If Button57.Text = "O" Then
                    Button57.BackColor = Color.Blue
                    Button66.BackColor = Color.Blue
                    Button75.BackColor = Color.Blue
                Else
                    Button57.BackColor = Color.Yellow
                    Button66.BackColor = Color.Yellow
                    Button75.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button55.Text = Button65.Text AndAlso Button65.Text = Button75.Text AndAlso Button75.Text <> "") Then
            If blockLine7 = 0 Then
                If Button55.Text = "O" Then
                    Button55.BackColor = Color.Blue
                    Button65.BackColor = Color.Blue
                    Button75.BackColor = Color.Blue
                Else
                    Button55.BackColor = Color.Yellow
                    Button65.BackColor = Color.Yellow
                    Button75.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        If (Button57.Text = Button65.Text AndAlso Button65.Text = Button73.Text AndAlso Button73.Text <> "") Then
            If blockLine7 = 0 Then
                If Button57.Text = "O" Then
                    Button57.BackColor = Color.Blue
                    Button65.BackColor = Color.Blue
                    Button73.BackColor = Color.Blue
                Else
                    Button57.BackColor = Color.Yellow
                    Button65.BackColor = Color.Yellow
                    Button73.BackColor = Color.Yellow
                End If
                blockLine7 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 55
                userStatus = 1
            Case 56
                userStatus = 2
            Case 57
                userStatus = 3
            Case 64
                userStatus = 4
            Case 65
                userStatus = 5
            Case 66
                userStatus = 6
            Case 73
                userStatus = 7
            Case 74
                userStatus = 8
            Case 75
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button55.Enabled = False AndAlso Button56.Enabled = False AndAlso Button57.Enabled = False AndAlso
        Button64.Enabled = False AndAlso Button65.Enabled = False AndAlso Button66.Enabled = False AndAlso
        Button73.Enabled = False AndAlso Button74.Enabled = False AndAlso Button75.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub eighth_Block(sender As Object, e As EventArgs) _
    Handles Button58.Click, Button59.Click, Button60.Click, Button67.Click, Button68.Click, Button69.Click, Button76.Click, Button77.Click, Button78.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 8 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button58.Text = Button59.Text AndAlso Button59.Text = Button60.Text AndAlso Button60.Text <> "") Then
            If blockLine8 = 0 Then
                If Button58.Text = "O" Then
                    Button58.BackColor = Color.Blue
                    Button59.BackColor = Color.Blue
                    Button60.BackColor = Color.Blue
                Else
                    Button58.BackColor = Color.Yellow
                    Button59.BackColor = Color.Yellow
                    Button60.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button67.Text = Button68.Text AndAlso Button68.Text = Button69.Text AndAlso Button69.Text <> "") Then
            If blockLine8 = 0 Then
                If Button67.Text = "O" Then
                    Button67.BackColor = Color.Blue
                    Button68.BackColor = Color.Blue
                    Button69.BackColor = Color.Blue
                Else
                    Button67.BackColor = Color.Yellow
                    Button68.BackColor = Color.Yellow
                    Button69.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button76.Text = Button77.Text AndAlso Button77.Text = Button78.Text AndAlso Button78.Text <> "") Then
            If blockLine8 = 0 Then
                If Button76.Text = "O" Then
                    Button76.BackColor = Color.Blue
                    Button77.BackColor = Color.Blue
                    Button78.BackColor = Color.Blue
                Else
                    Button76.BackColor = Color.Yellow
                    Button77.BackColor = Color.Yellow
                    Button78.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button58.Text = Button67.Text AndAlso Button67.Text = Button76.Text AndAlso Button76.Text <> "") Then
            If blockLine8 = 0 Then
                If Button58.Text = "O" Then
                    Button58.BackColor = Color.Blue
                    Button67.BackColor = Color.Blue
                    Button76.BackColor = Color.Blue
                Else
                    Button58.BackColor = Color.Yellow
                    Button67.BackColor = Color.Yellow
                    Button76.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button59.Text = Button68.Text AndAlso Button68.Text = Button77.Text AndAlso Button77.Text <> "") Then
            If blockLine8 = 0 Then
                If Button59.Text = "O" Then
                    Button59.BackColor = Color.Blue
                    Button68.BackColor = Color.Blue
                    Button77.BackColor = Color.Blue
                Else
                    Button59.BackColor = Color.Yellow
                    Button68.BackColor = Color.Yellow
                    Button77.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button60.Text = Button69.Text AndAlso Button69.Text = Button78.Text AndAlso Button78.Text <> "") Then
            If blockLine8 = 0 Then
                If Button60.Text = "O" Then
                    Button60.BackColor = Color.Blue
                    Button69.BackColor = Color.Blue
                    Button78.BackColor = Color.Blue
                Else
                    Button60.BackColor = Color.Yellow
                    Button69.BackColor = Color.Yellow
                    Button78.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button58.Text = Button68.Text AndAlso Button68.Text = Button78.Text AndAlso Button78.Text <> "") Then
            If blockLine8 = 0 Then
                If Button58.Text = "O" Then
                    Button58.BackColor = Color.Blue
                    Button68.BackColor = Color.Blue
                    Button78.BackColor = Color.Blue
                Else
                    Button58.BackColor = Color.Yellow
                    Button68.BackColor = Color.Yellow
                    Button78.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        If (Button60.Text = Button68.Text AndAlso Button68.Text = Button76.Text AndAlso Button76.Text <> "") Then
            If blockLine8 = 0 Then
                If Button60.Text = "O" Then
                    Button60.BackColor = Color.Blue
                    Button68.BackColor = Color.Blue
                    Button76.BackColor = Color.Blue
                Else
                    Button60.BackColor = Color.Yellow
                    Button68.BackColor = Color.Yellow
                    Button76.BackColor = Color.Yellow
                End If
                blockLine8 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 58
                userStatus = 1
            Case 59
                userStatus = 2
            Case 60
                userStatus = 3
            Case 67
                userStatus = 4
            Case 68
                userStatus = 5
            Case 69
                userStatus = 6
            Case 76
                userStatus = 7
            Case 77
                userStatus = 8
            Case 78
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button58.Enabled = False AndAlso Button59.Enabled = False AndAlso Button60.Enabled = False AndAlso
        Button67.Enabled = False AndAlso Button68.Enabled = False AndAlso Button69.Enabled = False AndAlso
        Button76.Enabled = False AndAlso Button77.Enabled = False AndAlso Button78.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

    Private Sub nineth_Block(sender As Object, e As EventArgs) _
    Handles Button61.Click, Button62.Click, Button63.Click, Button70.Click, Button71.Click, Button72.Click, Button79.Click, Button80.Click, Button81.Click
        SetAllButtonsToWhite()
        Dim ClickedButton = DirectCast(sender, Button)
        If userStatus <> 9 AndAlso userStatus <> 0 Then
            If checkBlock <> 1 Then
                ClickedButton.BackColor = Color.Red
                Exit Sub
            End If
        End If
        clickCount += 1
        If clickCount Mod 2 = 0 Then
            ClickedButton.Text = "O"

        Else
            ClickedButton.Text = "X"
        End If
        ClickedButton.BackColor = Color.Gray
        ClickedButton.Enabled = False
        '--------------------------------------------------------------------
        If (Button61.Text = Button62.Text AndAlso Button62.Text = Button63.Text AndAlso Button63.Text <> "") Then
            If blockLine9 = 0 Then
                If Button61.Text = "O" Then
                    Button61.BackColor = Color.Blue
                    Button62.BackColor = Color.Blue
                    Button63.BackColor = Color.Blue
                Else
                    Button61.BackColor = Color.Yellow
                    Button62.BackColor = Color.Yellow
                    Button63.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button70.Text = Button71.Text AndAlso Button71.Text = Button72.Text AndAlso Button72.Text <> "") Then
            If blockLine9 = 0 Then
                If Button70.Text = "O" Then
                    Button70.BackColor = Color.Blue
                    Button71.BackColor = Color.Blue
                    Button72.BackColor = Color.Blue
                Else
                    Button70.BackColor = Color.Yellow
                    Button71.BackColor = Color.Yellow
                    Button72.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button79.Text = Button80.Text AndAlso Button80.Text = Button81.Text AndAlso Button81.Text <> "") Then
            If blockLine9 = 0 Then
                If Button79.Text = "O" Then
                    Button79.BackColor = Color.Blue
                    Button80.BackColor = Color.Blue
                    Button81.BackColor = Color.Blue
                Else
                    Button79.BackColor = Color.Yellow
                    Button80.BackColor = Color.Yellow
                    Button81.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button61.Text = Button70.Text AndAlso Button70.Text = Button79.Text AndAlso Button79.Text <> "") Then
            If blockLine9 = 0 Then
                If Button61.Text = "O" Then
                    Button61.BackColor = Color.Blue
                    Button70.BackColor = Color.Blue
                    Button79.BackColor = Color.Blue
                Else
                    Button61.BackColor = Color.Yellow
                    Button70.BackColor = Color.Yellow
                    Button79.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button62.Text = Button71.Text AndAlso Button71.Text = Button80.Text AndAlso Button80.Text <> "") Then
            If blockLine9 = 0 Then
                If Button62.Text = "O" Then
                    Button62.BackColor = Color.Blue
                    Button71.BackColor = Color.Blue
                    Button80.BackColor = Color.Blue
                Else
                    Button62.BackColor = Color.Yellow
                    Button71.BackColor = Color.Yellow
                    Button80.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button63.Text = Button72.Text AndAlso Button72.Text = Button81.Text AndAlso Button81.Text <> "") Then
            If blockLine9 = 0 Then
                If Button63.Text = "O" Then
                    Button63.BackColor = Color.Blue
                    Button72.BackColor = Color.Blue
                    Button81.BackColor = Color.Blue
                Else
                    Button63.BackColor = Color.Yellow
                    Button72.BackColor = Color.Yellow
                    Button81.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button61.Text = Button71.Text AndAlso Button71.Text = Button81.Text AndAlso Button81.Text <> "") Then
            If blockLine9 = 0 Then
                If Button61.Text = "O" Then
                    Button61.BackColor = Color.Blue
                    Button71.BackColor = Color.Blue
                    Button81.BackColor = Color.Blue
                Else
                    Button61.BackColor = Color.Yellow
                    Button71.BackColor = Color.Yellow
                    Button81.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        If (Button63.Text = Button71.Text AndAlso Button71.Text = Button79.Text AndAlso Button79.Text <> "") Then
            If blockLine9 = 0 Then
                If Button63.Text = "O" Then
                    Button63.BackColor = Color.Blue
                    Button71.BackColor = Color.Blue
                    Button79.BackColor = Color.Blue
                Else
                    Button63.BackColor = Color.Yellow
                    Button71.BackColor = Color.Yellow
                    Button79.BackColor = Color.Yellow
                End If
                blockLine9 += 1
            End If
        End If
        '--------------------------------------------------------------------
        Select Case ClickedButton.TabIndex
            Case 61
                userStatus = 1
            Case 62
                userStatus = 2
            Case 63
                userStatus = 3
            Case 70
                userStatus = 4
            Case 71
                userStatus = 5
            Case 72
                userStatus = 6
            Case 79
                userStatus = 7
            Case 80
                userStatus = 8
            Case 81
                userStatus = 9
        End Select
        '------------------------------------------------------------
        If Button61.Enabled = False AndAlso Button62.Enabled = False AndAlso Button63.Enabled = False AndAlso
        Button70.Enabled = False AndAlso Button71.Enabled = False AndAlso Button72.Enabled = False AndAlso
        Button79.Enabled = False AndAlso Button80.Enabled = False AndAlso Button81.Enabled = False Then
            checkBlock = 1
        Else
            checkBlock = 0
        End If
    End Sub

End Class
