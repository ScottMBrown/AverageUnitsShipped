'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Name:          Scott Brown
'Program:       AverageUnitsShipped
'Date:          2018-02-06
'Course:        NETD-2202-01
'Description:   This is a windows form application.  The user can enter
'               the amount of units shipped per day and the program will
'               calculate the average of that weeks shipped units.  The 
'               form is very user friendly and includes tips to assist the 
'               user as well as buttons to make the program easy to use.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


Option Strict On
Public Class frmAverageUnitsShipped


    'Variable for holding the users input as an integer
    Dim userInputInteger As Integer = 0

    'Array holding the value for the units shipped each day of the week
    Dim daysOfTheWeekArray(6) As Integer

    'Variable used as a counter for each day
    Dim dayCounter As Integer = 0

    'Another counter used to display in the label that displays the day
    Dim dayCounterDisplay As Integer = 1

    'Varaible used to count the sum of the units in a week 
    Dim unitSum As Double = 0.00

    'Constant Variable holding the value for the number of days in a week
    Private Const daysInAWeek As Double = 7.0

    'Constants for the ranges for user input validation
    Private Const maximumRange As Integer = 1000
    Private Const minimumRange As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtInputBox_TextChanged(sender As Object, e As EventArgs) Handles txtInputBox.TextChanged


    End Sub

    Private Sub lblDayLabel_Click(sender As Object, e As EventArgs) Handles lblDayLabel.Click

    End Sub



    Private Sub lblResultDisplay_Click(sender As Object, e As EventArgs) Handles lblResultDisplay.Click

    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Sets the input text box to have focus on it when it starts
        txtInputBox.Focus()

        'Error checking if statement making sure the value is an integer
        If (Integer.TryParse(txtInputBox.Text, userInputInteger) = False) Then
            MessageBox.Show("Error, value must be an integer")

            'Selecting the text box 
            txtInputBox.SelectAll()

            'Used to jump out if given a non integer value so the array doesn't include it
            Return

            'If the value by the user is good it will convert the input into an int and store it in userInputInteger
        Else
            userInputInteger = Convert.ToInt32(txtInputBox.Text)

            'Putting Focus on the textbox
            txtInputBox.Focus()
        End If

        ' If the user input is out of the range then give an error message
        If (userInputInteger > maximumRange Or userInputInteger < minimumRange) Then
            MessageBox.Show("Error, value must be between 0 and 1000 inclusive")
            txtInputBox.SelectAll()

            'Used to jump out if given a value not in range so the array doesn't include it
            Return
        Else
            'Bringing focus to the textbox and selecting the text for easy input for the user
            txtInputBox.Focus()
            txtInputBox.SelectAll()

            'Using the appendtext method to use the initial value with the newly entered value on a new line
            txtResultBox.AppendText(userInputInteger & vbCrLf)

            'Everytime the user hits enter it go up the array index and set the value and store it.
            'The counter will increase by 1 (days of the week)
            daysOfTheWeekArray(dayCounter) = userInputInteger
            dayCounter = dayCounter + 1

            'This day counter display is used to change the daylabel everytime the user hits enter
            dayCounterDisplay = dayCounterDisplay + 1
            lblDayLabel.Text = "Day " + dayCounterDisplay.ToString()


        End If

        'Once it hits the end of the week it will go into this if
        If dayCounter = daysInAWeek Then

            'Setting the display to day 7 because it goes to 8 on the last enter click
            dayCounterDisplay = dayCounterDisplay - 1
            lblDayLabel.Text = "Day " + dayCounterDisplay.ToString()

            'A For loop calculating the average of the units shipped this week
            For index As Integer = 0 To daysOfTheWeekArray.Length - 1
                'Adding the values of each day together
                unitSum = unitSum + daysOfTheWeekArray(index)
            Next
            'Rounding the final average to two decimal places
            unitSum = Math.Round(unitSum / daysInAWeek, 2)

            'Concatenated string showing the avearge units shipped in the week
            lblResultDisplay.Text = "Average per day: " + unitSum.ToString()

            'Making it so you cant hit enter again or type values in the text box
            btnEnter.Enabled = False
            txtInputBox.ReadOnly = True
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Setting all the variables and properties to their starting state so that when the user hits reset they get a clean slate
        userInputInteger = 0
        dayCounter = 0
        unitSum = 0
        txtInputBox.Text = ""
        txtResultBox.Text = ""
        lblResultDisplay.Text = ""
        lblDayLabel.Text = "Day 1"
        btnEnter.Enabled = True
        txtInputBox.ReadOnly = False
        dayCounterDisplay = 1


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Method to close the form
        Me.Close()

    End Sub

    Private Sub txtResultBox_TextChanged(sender As Object, e As EventArgs) Handles txtResultBox.TextChanged

    End Sub
End Class
