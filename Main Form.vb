' Jesse Hauck
' 6/23/19
' Takes an input from the user of an amount of money
' and calculates the number and type of bills and / or
' coins that makes up that amount.
' 6/24/19
' added a teaching mode with random numbers for amount 
' or bills / coins
' 4/7/20
' added a beginner mode that shows the amount so far
' 4/8/20
' changed the layout of the form, lowered the largest
' number limits, and changed the way the user's results
' were read to prevent problems from entering a zero

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    '********************************************************************************
    ' Class-level array for the amounts of the bills and coins, and the AmountTxt
    Private ReadOnly AMOUNTS() As Decimal = {50D, 20D, 10D, 5D, 1D, 0.25D, 0.1D, 0.05D, 0.01D}
    Dim theAmount As Decimal
    '________________________________________________________________________________

    ' the exit button
    Private Sub BtnExit_Click(sender As Object,
                              e As EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub

    ' function to generate a random number for the quiz mode
    Private Function RandomAmount(ByVal upperLimit As Integer) As Decimal
        Randomize()
        Dim rndAmount As Decimal = CDec(upperLimit * Rnd())
        Return rndAmount
    End Function

    ' method to read the amount and calculate the bills and coins that make up that amount
    Private Sub ChangeCalculator()
        ' variable for the amount entered by the user
        Dim theMoney As Decimal
        ' getting the amount that was entered
        Decimal.TryParse(AmountTxt.Text, theMoney)
        ' storing theMoney in the class variable theAmount
        theAmount = theMoney

        ' variables to hold the bill/coin number, max AMOUNTS array length, 
        ' the remainder, and the bill/coin count
        Dim howMany As Integer
        Dim max As Integer = AMOUNTS.GetUpperBound(0)
        Dim remainder As Decimal
        Dim billCoinCount As String
        'Dim billCoin(8) As Integer

        ' calculating the bills and/or coins that make up the amount
        For counter As Integer = 0 To max
            remainder = theMoney Mod AMOUNTS(counter)
            howMany = CInt((theMoney - remainder) / AMOUNTS(counter))
            'billCoin(counter) = howMany

            If howMany = 0 Then
                billCoinCount = String.Empty
            Else
                billCoinCount = howMany.ToString
            End If

            ' displaying the count of each bill and/or coin
            Select Case counter
                Case 0
                    Fifties.Text = billCoinCount
                Case 1
                    Twenties.Text = billCoinCount
                Case 2
                    Tens.Text = billCoinCount
                Case 3
                    Fives.Text = billCoinCount
                Case 4
                    Ones.Text = billCoinCount
                Case 5
                    Quarters.Text = billCoinCount
                Case 6
                    Dimes.Text = billCoinCount
                Case 7
                    Nickels.Text = billCoinCount
                Case 8
                    Pennies.Text = billCoinCount
            End Select

            theMoney = remainder
        Next
    End Sub

    ' checking if quizzing mode has been selected, and enabling or disabling functions 
    Private Sub quizRad_CheckedChanged(sender As Object, e As EventArgs) Handles quizRad.CheckedChanged
        If quizRad.Checked = True Then
            LimitGrp.Enabled = True
            StartQuizBtn.Enabled = True
            CheckBtn.Enabled = True
            ClearBtn.Enabled = True
            MakeChange.Enabled = False
            BeginnerGrp.Enabled = True
            Label1.Text = "Amount: $"
            ClearSystemText()
            ClearUserText()
            AmountTxt.Text = String.Empty
        Else
            LimitGrp.Enabled = False
            StartQuizBtn.Enabled = False
            CheckBtn.Enabled = False
            ClearBtn.Enabled = False
            MakeChange.Enabled = True
            BeginnerGrp.Enabled = False
            Label1.Text = "Enter amount: $"
        End If
    End Sub

    ' calls the change calculator when the Make Change button is clicked
    Private Sub MakeChange_Click(sender As Object, e As EventArgs) Handles MakeChange.Click, MakeChange.Enter
        ChangeCalculator()
    End Sub

    ' quiz mode starts by finding the selected largest number,
    ' calling the random number, and displaying the amount
    Private Sub StartQuizBtn_Click(sender As Object, e As EventArgs) Handles StartQuizBtn.Click
        ' variables for the upper amount limit and the selectable limits
        Dim limit As Integer
        Dim limitAmounts() As Integer = {5, 10, 20, 50, 75, 100}

        ' finding out which limit has been selected
        Select Case True
            Case fiveRad.Checked
                limit = limitAmounts(0)
            Case tenRad.Checked
                limit = limitAmounts(1)
            Case twentyRad.Checked
                limit = limitAmounts(2)
            Case fiftyRad.Checked
                limit = limitAmounts(3)
            Case hundredRad.Checked
                limit = limitAmounts(4)
            Case fiveHundRad.Checked
                limit = limitAmounts(5)
        End Select

        ' calling the random number generator for the amount to display
        AmountTxt.Text = RandomAmount(limit).ToString("F2")

    End Sub

    ' selecting all of the text when clicked or entered for easy entry of new amount
    Private Sub AmountTxt_Click(sender As Object, e As EventArgs) Handles AmountTxt.Click, AddUpBox.Click
        AmountTxt.SelectAll()

    End Sub

    Private Sub AmountTxt_Enter(sender As Object, e As EventArgs) Handles AmountTxt.Enter, AddUpBox.Enter
        AmountTxt.SelectAll()

    End Sub

    ' ensuring that only numbers, the period, and the backspace key are used for entering the amount
    Private Sub AmountTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountTxt.KeyPress, AddUpBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    ' clearing all of system the text boxes when a new amount is entered
    Private Sub AmountTxt_TextChanged(sender As Object, e As EventArgs) Handles AmountTxt.TextChanged, AddUpBox.TextChanged
        ClearSystemText()
    End Sub

    ' clearing all of the text boxes when the Clear Form button is pressed
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearSystemText()
        ClearUserText()
        AmountTxt.Text = String.Empty
        AddUpBox.Text = String.Empty
    End Sub

    Private Sub ClearSystemText() ' clears all of the text boxes for the bill and coins
        Fifties.Text = String.Empty
        Twenties.Text = String.Empty
        Tens.Text = String.Empty
        Fives.Text = String.Empty
        Ones.Text = String.Empty
        Quarters.Text = String.Empty
        Dimes.Text = String.Empty
        Nickels.Text = String.Empty
        Pennies.Text = String.Empty
    End Sub

    Private Sub ClearUserText() ' clears the user's text boxes
        userFifty.Text = String.Empty
        userTwenty.Text = String.Empty
        userTen.Text = String.Empty
        userFive.Text = String.Empty
        userOne.Text = String.Empty
        userQuart.Text = String.Empty
        userDime.Text = String.Empty
        userNick.Text = String.Empty
        userPenn.Text = String.Empty
    End Sub

    ' if beginner mode is enabled, the "Amount so far" text box
    ' will show an amount based on the values that have been entered
    ' into the user's text box for each bill and/or coin
    Private Sub BeModeRad_CheckedChanged(sender As Object, e As EventArgs) Handles BeModeRad.CheckedChanged
        If BeModeRad.Checked = True Then
            BeModeLbl.Enabled = True
            BeModeLbl.Visible = True
            AddUpBox.Enabled = True
            AddUpBox.Visible = True
        Else
            BeModeLbl.Enabled = False
            BeModeLbl.Visible = False
            AddUpBox.Enabled = False
            AddUpBox.Visible = False
        End If
    End Sub

    ' method for caculating and displaying the amount that
    ' the user has entered
    Private Sub AddUp(ByVal position As Integer, ByVal someMoney As Decimal, ByRef addUpTotal As Decimal)

        addUpTotal += someMoney * AMOUNTS(position)
        AddUpBox.Text = addUpTotal.ToString("F2")

    End Sub

    ' calling the AddUp method when text is changed in
    ' any of the user boxes
    Private Sub userFifty_TextChanged(sender As Object, e As EventArgs) Handles userFifty.TextChanged, userTwenty.TextChanged,
            userTen.TextChanged, userFive.TextChanged, userOne.TextChanged, userQuart.TextChanged, userDime.TextChanged,
            userNick.TextChanged, userPenn.TextChanged
        Dim someMoney As Decimal = 0.00D
        Dim addUpTotal As Decimal = 0.00D

        If Decimal.TryParse(userFifty.Text, someMoney) Then
            AddUp(0, someMoney, addUpTotal)
        Else
            AddUp(0, 0, addUpTotal)
        End If

        If Decimal.TryParse(userTwenty.Text, someMoney) Then
            AddUp(1, someMoney, addUpTotal)
        Else
            AddUp(1, 0, addUpTotal)
        End If

        If Decimal.TryParse(userTen.Text, someMoney) Then
            AddUp(2, someMoney, addUpTotal)
        Else
            AddUp(2, 0, addUpTotal)
        End If

        If Decimal.TryParse(userFive.Text, someMoney) Then
            AddUp(3, someMoney, addUpTotal)
        Else
            AddUp(3, 0, addUpTotal)
        End If

        If Decimal.TryParse(userOne.Text, someMoney) Then
            AddUp(4, someMoney, addUpTotal)
        Else
            AddUp(4, 0, addUpTotal)
        End If

        If Decimal.TryParse(userQuart.Text, someMoney) Then
            AddUp(5, someMoney, addUpTotal)
        Else
            AddUp(5, 0, addUpTotal)
        End If

        If Decimal.TryParse(userDime.Text, someMoney) Then
            AddUp(6, someMoney, addUpTotal)
        Else
            AddUp(6, 0, addUpTotal)
        End If

        If Decimal.TryParse(userNick.Text, someMoney) Then
            AddUp(7, someMoney, addUpTotal)
        Else
            AddUp(7, 0, addUpTotal)
        End If

        If Decimal.TryParse(userPenn.Text, someMoney) Then
            AddUp(8, someMoney, addUpTotal)
        Else
            AddUp(8, 0, addUpTotal)
        End If

    End Sub

    ' checking the answers
    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Dim isCorrect As Boolean = False ' for checking the answers
        ' getting the values from the beginner add up box, and the amount
        Dim userTotal As Decimal = 0.00D
        Decimal.TryParse(AddUpBox.Text, userTotal)

        ' calling the Change Calculator to display the correct count of bills/coins
        ChangeCalculator()

        '' checking to see if the user's answers are correct
        'If Fifties.Text <> userFifty.Text Then
        '    isCorrect = False
        'ElseIf Twenties.Text <> userTwenty.Text Then
        '    isCorrect = False
        'ElseIf Tens.Text <> userTen.Text Then
        '    isCorrect = False
        'ElseIf Fives.Text <> userFive.Text Then
        '    isCorrect = False
        'ElseIf Ones.Text <> userOne.Text Then
        '    isCorrect = False
        'ElseIf Quarters.Text <> userQuart.Text Then
        '    isCorrect = False
        'ElseIf Dimes.Text <> userDime.Text Then
        '    isCorrect = False
        'ElseIf Nickels.Text <> userNick.Text Then
        '    isCorrect = False
        'ElseIf Pennies.Text <> userPenn.Text Then
        '    isCorrect = False
        'Else
        '    isCorrect = True
        'End If

        ' displaying messages for correct or incorect ansers
        If userTotal <> theAmount Then
            MessageBox.Show("Sorry, that was incorrect", "Results", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ClearSystemText()
        Else
            MessageBox.Show("Great Job! You got them all right!", "Results", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
        'If Not isCorrect Then
        '    MessageBox.Show("Sorry, that was incorrect", "Results", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    ClearSystemText()
        'Else
        '    MessageBox.Show("Great Job! You got them all right!", "Results", MessageBoxButtons.OK, MessageBoxIcon.None)
        'End If
    End Sub

End Class
