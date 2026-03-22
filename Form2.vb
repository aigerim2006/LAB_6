Public Class Form2

    ' Переменная для хранения индекса последнего активного поля (1 или 2)
    Dim lastFocusedIndex As Integer = 0

    ' При наведении фокуса запоминаем, в какое поле писать
    Private Sub txtOp1_GotFocus(sender As Object, e As EventArgs) Handles txtOp1.GotFocus
        lastFocusedIndex = 1
    End Sub

    Private Sub txtOp2_GotFocus(sender As Object, e As EventArgs) Handles txtOp2.GotFocus
        lastFocusedIndex = 2
    End Sub

    ' Общий обработчик для всех кнопок с цифрами и запятой
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnComma.Click

        Dim btn As Button = DirectCast(sender, Button)
        Dim targetTextBox As TextBox = Nothing

        If lastFocusedIndex = 1 Then
            targetTextBox = txtOp1
        ElseIf lastFocusedIndex = 2 Then
            targetTextBox = txtOp2
        End If

        If targetTextBox IsNot Nothing Then
            ' Проверка, чтобы не ввели две запятых
            If btn.Text = "," And targetTextBox.Text.Contains(",") Then Return
            targetTextBox.Text &= btn.Text
        End If

    End Sub

    ' Общая процедура для расчета двух чисел
    Private Sub CalculateBinary(op As String)
        Try
            txtSign.Text = op
            Dim a As Double = CDbl(txtOp1.Text)
            Dim b As Double = CDbl(txtOp2.Text)
            Dim res As Double

            Select Case op
                Case "+" : res = a + b
                Case "-" : res = a - b
                Case "*" : res = a * b
                Case "/"
                    If b = 0 Then Throw New DivideByZeroException
                    res = a / b
                Case "mod" : res = a Mod b
                Case "^" : res = Math.Pow(a, b)
            End Select

            txtResult.Text = res.ToString()
        Catch ex As Exception
            MessageBox.Show("Ошибка ввода или деление на ноль!", "Внимание")
        End Try
    End Sub


    ' БИНАРНЫЕ ОПЕРАЦИИ (+, -, *, /, mod, a^b)
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        CalculateBinary("+")
    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        CalculateBinary("*")
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        CalculateBinary("/")
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        CalculateBinary("-")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        CalculateBinary("mod")
    End Sub

    Private Sub btnBdegree_Click(sender As Object, e As EventArgs) Handles btnBdegree.Click
        CalculateBinary("^")
    End Sub


    ' --- УНАРНЫЕ ОПЕРАЦИИ (sin, cos, sqrt, a^2, a^3, 1/a) ---
    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Try
            txtSign.Text = "√"
            Dim a As Double = CDbl(txtOp1.Text)
            If a < 0 Then
                MessageBox.Show("Корень из отрицательного числа!", "Ошибка")
                Return
            End If
            txtResult.Text = Math.Sqrt(a).ToString()
        Catch
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        Try
            txtSign.Text = "sin"
            ' Перевод из градусов в радианы: deg * Pi / 180
            Dim deg As Double = CDbl(txtOp1.Text)
            Dim rad As Double = deg * Math.PI / 180
            txtResult.Text = Math.Sin(rad).ToString()
        Catch
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Try
            txtSign.Text = "cos"
            Dim deg As Double = CDbl(txtOp1.Text)
            Dim rad As Double = deg * Math.PI / 180
            txtResult.Text = Math.Cos(rad).ToString()
        Catch
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    Private Sub btn2degree_Click(sender As Object, e As EventArgs) Handles btn2degree.Click
        Try
            txtSign.Text = "^"
            txtOp2.Clear()
            txtOp2.Text &= "2"
            Dim a As Double = CDbl(txtOp1.Text)
            Dim res As Double = Math.Pow(a, 2)
            txtResult.Text = res.ToString()
        Catch ex As Exception
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    Private Sub btn3degree_Click(sender As Object, e As EventArgs) Handles btn3degree.Click
        Try
            txtSign.Text = "^"
            txtOp2.Clear()
            txtOp2.Text &= "3"
            Dim a As Double = CDbl(txtOp1.Text)
            Dim res As Double = Math.Pow(a, 3)
            txtResult.Text = res.ToString()
        Catch ex As Exception
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    Private Sub btn1divA_Click(sender As Object, e As EventArgs) Handles btn1divA.Click
        Try
            Dim a As Double = CDbl(txtOp1.Text)
            txtSign.Text = "1/"
            txtOp2.Clear()
            If a = 0 Then
                MessageBox.Show("Деление на ноль!", "Ошибка")
                Return
            End If
            Dim res As Double = 1 / a
            txtResult.Text = res.ToString()
        Catch ex As Exception
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub

    ' Копирование результата в первый операнд
    Private Sub txtResult_Click(sender As Object, e As EventArgs) Handles txtResult.Click
        If txtResult.Text <> "" Then
            txtOp1.Text = txtResult.Text
            txtOp2.Clear()
            txtSign.Clear()
            txtResult.Clear()
        End If
    End Sub

    ' Очистка по двойному клику
    Private Sub txtOp1_DoubleClick(sender As Object, e As EventArgs) Handles txtOp1.DoubleClick, txtOp2.DoubleClick
        DirectCast(sender, TextBox).Clear()
    End Sub


    ' Кнопка Выход
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnPlusMines_Click(sender As Object, e As EventArgs) Handles btnPlusMines.Click
        Try
            Dim a As Double = CDbl(txtOp1.Text)
            a = -a
            txtResult.Text = a.ToString()
        Catch ex As Exception
            MessageBox.Show("Ошибка данных")
        End Try
    End Sub
End Class