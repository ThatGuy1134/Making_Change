<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.AmountTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fifties = New System.Windows.Forms.TextBox()
        Me.Twenties = New System.Windows.Forms.TextBox()
        Me.Tens = New System.Windows.Forms.TextBox()
        Me.Fives = New System.Windows.Forms.TextBox()
        Me.Ones = New System.Windows.Forms.TextBox()
        Me.Quarters = New System.Windows.Forms.TextBox()
        Me.Dimes = New System.Windows.Forms.TextBox()
        Me.Nickels = New System.Windows.Forms.TextBox()
        Me.Pennies = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MakeChange = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.userFifty = New System.Windows.Forms.TextBox()
        Me.userTwenty = New System.Windows.Forms.TextBox()
        Me.userTen = New System.Windows.Forms.TextBox()
        Me.userFive = New System.Windows.Forms.TextBox()
        Me.userOne = New System.Windows.Forms.TextBox()
        Me.userQuart = New System.Windows.Forms.TextBox()
        Me.userDime = New System.Windows.Forms.TextBox()
        Me.userNick = New System.Windows.Forms.TextBox()
        Me.userPenn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LimitGrp = New System.Windows.Forms.GroupBox()
        Me.fiveHundRad = New System.Windows.Forms.RadioButton()
        Me.twentyRad = New System.Windows.Forms.RadioButton()
        Me.hundredRad = New System.Windows.Forms.RadioButton()
        Me.fiftyRad = New System.Windows.Forms.RadioButton()
        Me.tenRad = New System.Windows.Forms.RadioButton()
        Me.fiveRad = New System.Windows.Forms.RadioButton()
        Me.quizzingGrp = New System.Windows.Forms.GroupBox()
        Me.noQuizRad = New System.Windows.Forms.RadioButton()
        Me.quizRad = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.StartQuizBtn = New System.Windows.Forms.Button()
        Me.LimitGrp.SuspendLayout()
        Me.quizzingGrp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AmountTxt
        '
        Me.AmountTxt.Location = New System.Drawing.Point(366, 41)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.Size = New System.Drawing.Size(87, 23)
        Me.AmountTxt.TabIndex = 1
        Me.AmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter amount:  $"
        '
        'Fifties
        '
        Me.Fifties.BackColor = System.Drawing.SystemColors.Info
        Me.Fifties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fifties.Cursor = System.Windows.Forms.Cursors.No
        Me.Fifties.Location = New System.Drawing.Point(13, 180)
        Me.Fifties.Name = "Fifties"
        Me.Fifties.Size = New System.Drawing.Size(37, 23)
        Me.Fifties.TabIndex = 4
        Me.Fifties.TabStop = False
        Me.Fifties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Twenties
        '
        Me.Twenties.BackColor = System.Drawing.SystemColors.Info
        Me.Twenties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Twenties.Cursor = System.Windows.Forms.Cursors.No
        Me.Twenties.Location = New System.Drawing.Point(72, 180)
        Me.Twenties.Name = "Twenties"
        Me.Twenties.Size = New System.Drawing.Size(37, 23)
        Me.Twenties.TabIndex = 4
        Me.Twenties.TabStop = False
        Me.Twenties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tens
        '
        Me.Tens.BackColor = System.Drawing.SystemColors.Info
        Me.Tens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tens.Cursor = System.Windows.Forms.Cursors.No
        Me.Tens.Location = New System.Drawing.Point(131, 180)
        Me.Tens.Name = "Tens"
        Me.Tens.Size = New System.Drawing.Size(37, 23)
        Me.Tens.TabIndex = 4
        Me.Tens.TabStop = False
        Me.Tens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fives
        '
        Me.Fives.BackColor = System.Drawing.SystemColors.Info
        Me.Fives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fives.Cursor = System.Windows.Forms.Cursors.No
        Me.Fives.Location = New System.Drawing.Point(190, 180)
        Me.Fives.Name = "Fives"
        Me.Fives.Size = New System.Drawing.Size(37, 23)
        Me.Fives.TabIndex = 4
        Me.Fives.TabStop = False
        Me.Fives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ones
        '
        Me.Ones.BackColor = System.Drawing.SystemColors.Info
        Me.Ones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ones.Cursor = System.Windows.Forms.Cursors.No
        Me.Ones.Location = New System.Drawing.Point(249, 180)
        Me.Ones.Name = "Ones"
        Me.Ones.Size = New System.Drawing.Size(37, 23)
        Me.Ones.TabIndex = 4
        Me.Ones.TabStop = False
        Me.Ones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quarters
        '
        Me.Quarters.BackColor = System.Drawing.SystemColors.Info
        Me.Quarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Quarters.Cursor = System.Windows.Forms.Cursors.No
        Me.Quarters.Location = New System.Drawing.Point(308, 180)
        Me.Quarters.Name = "Quarters"
        Me.Quarters.Size = New System.Drawing.Size(37, 23)
        Me.Quarters.TabIndex = 4
        Me.Quarters.TabStop = False
        Me.Quarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dimes
        '
        Me.Dimes.BackColor = System.Drawing.SystemColors.Info
        Me.Dimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dimes.Cursor = System.Windows.Forms.Cursors.No
        Me.Dimes.Location = New System.Drawing.Point(367, 180)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(37, 23)
        Me.Dimes.TabIndex = 4
        Me.Dimes.TabStop = False
        Me.Dimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nickels
        '
        Me.Nickels.BackColor = System.Drawing.SystemColors.Info
        Me.Nickels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nickels.Cursor = System.Windows.Forms.Cursors.No
        Me.Nickels.Location = New System.Drawing.Point(426, 180)
        Me.Nickels.Name = "Nickels"
        Me.Nickels.Size = New System.Drawing.Size(37, 23)
        Me.Nickels.TabIndex = 4
        Me.Nickels.TabStop = False
        Me.Nickels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pennies
        '
        Me.Pennies.BackColor = System.Drawing.SystemColors.Info
        Me.Pennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pennies.Cursor = System.Windows.Forms.Cursors.No
        Me.Pennies.Location = New System.Drawing.Point(485, 180)
        Me.Pennies.Name = "Pennies"
        Me.Pennies.Size = New System.Drawing.Size(37, 23)
        Me.Pennies.TabIndex = 4
        Me.Pennies.TabStop = False
        Me.Pennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fifties"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Twenties"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tens"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fives"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(298, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Quarters"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Dimes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(420, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nickels"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(478, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Pennies"
        '
        'MakeChange
        '
        Me.MakeChange.Location = New System.Drawing.Point(366, 84)
        Me.MakeChange.Name = "MakeChange"
        Me.MakeChange.Size = New System.Drawing.Size(87, 42)
        Me.MakeChange.TabIndex = 2
        Me.MakeChange.Text = "&Make Change"
        Me.MakeChange.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(448, 294)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(74, 27)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'userFifty
        '
        Me.userFifty.BackColor = System.Drawing.SystemColors.Window
        Me.userFifty.Location = New System.Drawing.Point(13, 229)
        Me.userFifty.Name = "userFifty"
        Me.userFifty.Size = New System.Drawing.Size(37, 23)
        Me.userFifty.TabIndex = 5
        Me.userFifty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userTwenty
        '
        Me.userTwenty.BackColor = System.Drawing.SystemColors.Window
        Me.userTwenty.Location = New System.Drawing.Point(72, 229)
        Me.userTwenty.Name = "userTwenty"
        Me.userTwenty.Size = New System.Drawing.Size(37, 23)
        Me.userTwenty.TabIndex = 5
        Me.userTwenty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userTen
        '
        Me.userTen.BackColor = System.Drawing.SystemColors.Window
        Me.userTen.Location = New System.Drawing.Point(131, 229)
        Me.userTen.Name = "userTen"
        Me.userTen.Size = New System.Drawing.Size(37, 23)
        Me.userTen.TabIndex = 5
        Me.userTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userFive
        '
        Me.userFive.BackColor = System.Drawing.SystemColors.Window
        Me.userFive.Location = New System.Drawing.Point(190, 229)
        Me.userFive.Name = "userFive"
        Me.userFive.Size = New System.Drawing.Size(37, 23)
        Me.userFive.TabIndex = 5
        Me.userFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userOne
        '
        Me.userOne.BackColor = System.Drawing.SystemColors.Window
        Me.userOne.Location = New System.Drawing.Point(249, 229)
        Me.userOne.Name = "userOne"
        Me.userOne.Size = New System.Drawing.Size(37, 23)
        Me.userOne.TabIndex = 5
        Me.userOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userQuart
        '
        Me.userQuart.BackColor = System.Drawing.SystemColors.Window
        Me.userQuart.Location = New System.Drawing.Point(308, 229)
        Me.userQuart.Name = "userQuart"
        Me.userQuart.Size = New System.Drawing.Size(37, 23)
        Me.userQuart.TabIndex = 5
        Me.userQuart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userDime
        '
        Me.userDime.BackColor = System.Drawing.SystemColors.Window
        Me.userDime.Location = New System.Drawing.Point(367, 229)
        Me.userDime.Name = "userDime"
        Me.userDime.Size = New System.Drawing.Size(37, 23)
        Me.userDime.TabIndex = 5
        Me.userDime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userNick
        '
        Me.userNick.BackColor = System.Drawing.SystemColors.Window
        Me.userNick.Location = New System.Drawing.Point(426, 229)
        Me.userNick.Name = "userNick"
        Me.userNick.Size = New System.Drawing.Size(37, 23)
        Me.userNick.TabIndex = 5
        Me.userNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userPenn
        '
        Me.userPenn.BackColor = System.Drawing.SystemColors.Window
        Me.userPenn.Location = New System.Drawing.Point(485, 229)
        Me.userPenn.Name = "userPenn"
        Me.userPenn.Size = New System.Drawing.Size(37, 23)
        Me.userPenn.TabIndex = 5
        Me.userPenn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Enter your answer:"
        '
        'LimitGrp
        '
        Me.LimitGrp.Controls.Add(Me.fiveHundRad)
        Me.LimitGrp.Controls.Add(Me.twentyRad)
        Me.LimitGrp.Controls.Add(Me.hundredRad)
        Me.LimitGrp.Controls.Add(Me.fiftyRad)
        Me.LimitGrp.Controls.Add(Me.tenRad)
        Me.LimitGrp.Controls.Add(Me.fiveRad)
        Me.LimitGrp.Enabled = False
        Me.LimitGrp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimitGrp.Location = New System.Drawing.Point(12, 51)
        Me.LimitGrp.Name = "LimitGrp"
        Me.LimitGrp.Size = New System.Drawing.Size(166, 104)
        Me.LimitGrp.TabIndex = 7
        Me.LimitGrp.TabStop = False
        Me.LimitGrp.Text = "Largest number?"
        '
        'fiveHundRad
        '
        Me.fiveHundRad.AutoSize = True
        Me.fiveHundRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveHundRad.Location = New System.Drawing.Point(92, 70)
        Me.fiveHundRad.Name = "fiveHundRad"
        Me.fiveHundRad.Size = New System.Drawing.Size(64, 19)
        Me.fiveHundRad.TabIndex = 0
        Me.fiveHundRad.TabStop = True
        Me.fiveHundRad.Text = "$500.00"
        Me.fiveHundRad.UseVisualStyleBackColor = True
        '
        'twentyRad
        '
        Me.twentyRad.AutoSize = True
        Me.twentyRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twentyRad.Location = New System.Drawing.Point(8, 70)
        Me.twentyRad.Name = "twentyRad"
        Me.twentyRad.Size = New System.Drawing.Size(58, 19)
        Me.twentyRad.TabIndex = 0
        Me.twentyRad.TabStop = True
        Me.twentyRad.Text = "$20.00"
        Me.twentyRad.UseVisualStyleBackColor = True
        '
        'hundredRad
        '
        Me.hundredRad.AutoSize = True
        Me.hundredRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hundredRad.Location = New System.Drawing.Point(92, 47)
        Me.hundredRad.Name = "hundredRad"
        Me.hundredRad.Size = New System.Drawing.Size(64, 19)
        Me.hundredRad.TabIndex = 0
        Me.hundredRad.TabStop = True
        Me.hundredRad.Text = "$100.00"
        Me.hundredRad.UseVisualStyleBackColor = True
        '
        'fiftyRad
        '
        Me.fiftyRad.AutoSize = True
        Me.fiftyRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiftyRad.Location = New System.Drawing.Point(92, 24)
        Me.fiftyRad.Name = "fiftyRad"
        Me.fiftyRad.Size = New System.Drawing.Size(58, 19)
        Me.fiftyRad.TabIndex = 0
        Me.fiftyRad.TabStop = True
        Me.fiftyRad.Text = "$50.00"
        Me.fiftyRad.UseVisualStyleBackColor = True
        '
        'tenRad
        '
        Me.tenRad.AutoSize = True
        Me.tenRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenRad.Location = New System.Drawing.Point(8, 47)
        Me.tenRad.Name = "tenRad"
        Me.tenRad.Size = New System.Drawing.Size(58, 19)
        Me.tenRad.TabIndex = 0
        Me.tenRad.TabStop = True
        Me.tenRad.Text = "$10.00"
        Me.tenRad.UseVisualStyleBackColor = True
        '
        'fiveRad
        '
        Me.fiveRad.AutoSize = True
        Me.fiveRad.Checked = True
        Me.fiveRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveRad.Location = New System.Drawing.Point(8, 24)
        Me.fiveRad.Name = "fiveRad"
        Me.fiveRad.Size = New System.Drawing.Size(52, 19)
        Me.fiveRad.TabIndex = 0
        Me.fiveRad.TabStop = True
        Me.fiveRad.Text = "$5.00"
        Me.fiveRad.UseVisualStyleBackColor = True
        '
        'quizzingGrp
        '
        Me.quizzingGrp.Controls.Add(Me.noQuizRad)
        Me.quizzingGrp.Controls.Add(Me.quizRad)
        Me.quizzingGrp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quizzingGrp.Location = New System.Drawing.Point(13, 10)
        Me.quizzingGrp.Name = "quizzingGrp"
        Me.quizzingGrp.Size = New System.Drawing.Size(165, 37)
        Me.quizzingGrp.TabIndex = 7
        Me.quizzingGrp.TabStop = False
        Me.quizzingGrp.Text = "Quizzing  mode?"
        '
        'noQuizRad
        '
        Me.noQuizRad.AutoSize = True
        Me.noQuizRad.Checked = True
        Me.noQuizRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noQuizRad.Location = New System.Drawing.Point(91, 14)
        Me.noQuizRad.Name = "noQuizRad"
        Me.noQuizRad.Size = New System.Drawing.Size(41, 19)
        Me.noQuizRad.TabIndex = 0
        Me.noQuizRad.TabStop = True
        Me.noQuizRad.Text = "No"
        Me.noQuizRad.UseVisualStyleBackColor = True
        '
        'quizRad
        '
        Me.quizRad.AutoSize = True
        Me.quizRad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quizRad.Location = New System.Drawing.Point(7, 14)
        Me.quizRad.Name = "quizRad"
        Me.quizRad.Size = New System.Drawing.Size(42, 19)
        Me.quizRad.TabIndex = 0
        Me.quizRad.TabStop = True
        Me.quizRad.Text = "Yes"
        Me.quizRad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-421, -16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 37)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Training mode?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(91, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(7, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Yes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(-331, -16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 37)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Training mode?"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(91, 14)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(41, 19)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(7, 14)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Yes"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'CheckBtn
        '
        Me.CheckBtn.Enabled = False
        Me.CheckBtn.Location = New System.Drawing.Point(13, 275)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(75, 23)
        Me.CheckBtn.TabIndex = 8
        Me.CheckBtn.Text = "&Check"
        Me.CheckBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Enabled = False
        Me.ClearBtn.Location = New System.Drawing.Point(103, 275)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "Clear &Form"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'StartQuizBtn
        '
        Me.StartQuizBtn.Enabled = False
        Me.StartQuizBtn.Location = New System.Drawing.Point(211, 84)
        Me.StartQuizBtn.Name = "StartQuizBtn"
        Me.StartQuizBtn.Size = New System.Drawing.Size(87, 42)
        Me.StartQuizBtn.TabIndex = 9
        Me.StartQuizBtn.Text = "Start the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Quiz"
        Me.StartQuizBtn.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 357)
        Me.Controls.Add(Me.StartQuizBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CheckBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.quizzingGrp)
        Me.Controls.Add(Me.LimitGrp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.MakeChange)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userPenn)
        Me.Controls.Add(Me.Pennies)
        Me.Controls.Add(Me.userNick)
        Me.Controls.Add(Me.Nickels)
        Me.Controls.Add(Me.userDime)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.userQuart)
        Me.Controls.Add(Me.Quarters)
        Me.Controls.Add(Me.userOne)
        Me.Controls.Add(Me.Ones)
        Me.Controls.Add(Me.userFive)
        Me.Controls.Add(Me.Fives)
        Me.Controls.Add(Me.userTen)
        Me.Controls.Add(Me.Tens)
        Me.Controls.Add(Me.userTwenty)
        Me.Controls.Add(Me.Twenties)
        Me.Controls.Add(Me.userFifty)
        Me.Controls.Add(Me.Fifties)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountTxt)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Maker"
        Me.LimitGrp.ResumeLayout(False)
        Me.LimitGrp.PerformLayout()
        Me.quizzingGrp.ResumeLayout(False)
        Me.quizzingGrp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AmountTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Fifties As TextBox
    Friend WithEvents Twenties As TextBox
    Friend WithEvents Tens As TextBox
    Friend WithEvents Fives As TextBox
    Friend WithEvents Ones As TextBox
    Friend WithEvents Quarters As TextBox
    Friend WithEvents Dimes As TextBox
    Friend WithEvents Nickels As TextBox
    Friend WithEvents Pennies As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MakeChange As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents userFifty As TextBox
    Friend WithEvents userTwenty As TextBox
    Friend WithEvents userTen As TextBox
    Friend WithEvents userFive As TextBox
    Friend WithEvents userOne As TextBox
    Friend WithEvents userQuart As TextBox
    Friend WithEvents userDime As TextBox
    Friend WithEvents userNick As TextBox
    Friend WithEvents userPenn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LimitGrp As GroupBox
    Friend WithEvents fiveHundRad As RadioButton
    Friend WithEvents twentyRad As RadioButton
    Friend WithEvents hundredRad As RadioButton
    Friend WithEvents fiftyRad As RadioButton
    Friend WithEvents tenRad As RadioButton
    Friend WithEvents fiveRad As RadioButton
    Friend WithEvents quizzingGrp As GroupBox
    Friend WithEvents noQuizRad As RadioButton
    Friend WithEvents quizRad As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents CheckBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents StartQuizBtn As Button
End Class
