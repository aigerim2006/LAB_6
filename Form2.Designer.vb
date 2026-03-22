<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtSign = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btn2degree = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btn3degree = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnBdegree = New System.Windows.Forms.Button()
        Me.btn1divA = New System.Windows.Forms.Button()
        Me.btnComma = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnPlusMines = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOp1
        '
        Me.txtOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtOp1.Location = New System.Drawing.Point(330, 49)
        Me.txtOp1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(140, 28)
        Me.txtOp1.TabIndex = 0
        '
        'txtSign
        '
        Me.txtSign.Location = New System.Drawing.Point(247, 102)
        Me.txtSign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSign.Name = "txtSign"
        Me.txtSign.Size = New System.Drawing.Size(55, 27)
        Me.txtSign.TabIndex = 1
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(331, 161)
        Me.txtOp2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(139, 27)
        Me.txtOp2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Операнд 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Операнд 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Результат"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtResult.Location = New System.Drawing.Point(303, 220)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(192, 27)
        Me.txtResult.TabIndex = 6
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(56, 345)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(76, 33)
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMultiple
        '
        Me.btnMultiple.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMultiple.Location = New System.Drawing.Point(160, 345)
        Me.btnMultiple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(76, 33)
        Me.btnMultiple.TabIndex = 8
        Me.btnMultiple.Text = "*"
        Me.btnMultiple.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSqrt.Location = New System.Drawing.Point(255, 345)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(76, 33)
        Me.btnSqrt.TabIndex = 9
        Me.btnSqrt.Text = "√a"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(56, 396)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(76, 29)
        Me.btnMinus.TabIndex = 10
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(160, 396)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(76, 29)
        Me.btnDiv.TabIndex = 11
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btn2degree
        '
        Me.btn2degree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn2degree.Location = New System.Drawing.Point(255, 396)
        Me.btn2degree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn2degree.Name = "btn2degree"
        Me.btn2degree.Size = New System.Drawing.Size(76, 29)
        Me.btn2degree.TabIndex = 12
        Me.btn2degree.Text = "a^2"
        Me.btn2degree.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSin.Location = New System.Drawing.Point(56, 446)
        Me.btnSin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(76, 29)
        Me.btnSin.TabIndex = 13
        Me.btnSin.Text = "sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCos.Location = New System.Drawing.Point(160, 446)
        Me.btnCos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(76, 29)
        Me.btnCos.TabIndex = 14
        Me.btnCos.Text = "cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btn3degree
        '
        Me.btn3degree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn3degree.Location = New System.Drawing.Point(255, 446)
        Me.btn3degree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn3degree.Name = "btn3degree"
        Me.btn3degree.Size = New System.Drawing.Size(76, 29)
        Me.btn3degree.TabIndex = 15
        Me.btn3degree.Text = "a^3"
        Me.btn3degree.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMod.Location = New System.Drawing.Point(56, 493)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(76, 29)
        Me.btnMod.TabIndex = 16
        Me.btnMod.Text = "mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnBdegree
        '
        Me.btnBdegree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBdegree.Location = New System.Drawing.Point(160, 493)
        Me.btnBdegree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBdegree.Name = "btnBdegree"
        Me.btnBdegree.Size = New System.Drawing.Size(76, 29)
        Me.btnBdegree.TabIndex = 17
        Me.btnBdegree.Text = "a^b"
        Me.btnBdegree.UseVisualStyleBackColor = True
        '
        'btn1divA
        '
        Me.btn1divA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn1divA.Location = New System.Drawing.Point(255, 493)
        Me.btn1divA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn1divA.Name = "btn1divA"
        Me.btn1divA.Size = New System.Drawing.Size(76, 29)
        Me.btn1divA.TabIndex = 18
        Me.btn1divA.Text = "1/a"
        Me.btn1divA.UseVisualStyleBackColor = True
        '
        'btnComma
        '
        Me.btnComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnComma.Location = New System.Drawing.Point(402, 345)
        Me.btnComma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnComma.Name = "btnComma"
        Me.btnComma.Size = New System.Drawing.Size(68, 29)
        Me.btnComma.TabIndex = 19
        Me.btnComma.Text = ","
        Me.btnComma.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn1.Location = New System.Drawing.Point(486, 345)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(68, 29)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn2.Location = New System.Drawing.Point(575, 345)
        Me.btn2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(67, 29)
        Me.btn2.TabIndex = 21
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn3.Location = New System.Drawing.Point(666, 345)
        Me.btn3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(67, 29)
        Me.btn3.TabIndex = 22
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn0.Location = New System.Drawing.Point(402, 396)
        Me.btn0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(68, 29)
        Me.btn0.TabIndex = 23
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn4.Location = New System.Drawing.Point(486, 396)
        Me.btn4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(68, 29)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn5.Location = New System.Drawing.Point(575, 396)
        Me.btn5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(67, 29)
        Me.btn5.TabIndex = 25
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn6.Location = New System.Drawing.Point(666, 396)
        Me.btn6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(67, 29)
        Me.btn6.TabIndex = 26
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnPlusMines
        '
        Me.btnPlusMines.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPlusMines.Location = New System.Drawing.Point(402, 446)
        Me.btnPlusMines.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPlusMines.Name = "btnPlusMines"
        Me.btnPlusMines.Size = New System.Drawing.Size(68, 29)
        Me.btnPlusMines.TabIndex = 27
        Me.btnPlusMines.Text = "+/-"
        Me.btnPlusMines.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn7.Location = New System.Drawing.Point(486, 446)
        Me.btn7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(68, 29)
        Me.btn7.TabIndex = 28
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn8.Location = New System.Drawing.Point(575, 446)
        Me.btn8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(67, 29)
        Me.btn8.TabIndex = 29
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn9.Location = New System.Drawing.Point(666, 446)
        Me.btn9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(67, 29)
        Me.btn9.TabIndex = 30
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnExit.Location = New System.Drawing.Point(499, 493)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 29)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Выход"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 565)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnPlusMines)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnComma)
        Me.Controls.Add(Me.btn1divA)
        Me.Controls.Add(Me.btnBdegree)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btn3degree)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.btn2degree)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtSign)
        Me.Controls.Add(Me.txtOp1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Калькулятор"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtSign As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMultiple As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btn2degree As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btn3degree As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnBdegree As Button
    Friend WithEvents btn1divA As Button
    Friend WithEvents btnComma As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnPlusMines As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnExit As Button
End Class
