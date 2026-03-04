Public Class Form1

    ' Переменные уровня класса
    Private a, b, c, d As Double
    Private paper As Graphics
    Private myPen As New Pen(Color.Black)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            paper = PictureBox1.CreateGraphics()
            DrawGraph()
        Catch ex As Exception
            MessageBox.Show("Ошибка ввода коэффициентов!")
        End Try
    End Sub

    Private Sub DrawGraph()

        ' Считывание коэффициентов
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        c = CDbl(TextBox3.Text)
        d = CDbl(TextBox4.Text)

        paper.Clear(Color.White)

        Draw()

    End Sub

    Private Sub Draw()

        Dim x, y, nextX, nextY As Double
        Dim xPixel, yPixel, nextXPixel, nextYPixel As Integer

        For xPixel = 0 To PictureBox1.Width - 2

            ' 1. Перевод пикселя в координату X
            x = ScaleX(xPixel)

            ' 2. Вычисление значения функции
            y = TheFunction(x)

            ' 3. Перевод Y в пиксели
            yPixel = ScaleY(y)

            ' Следующая точка
            nextXPixel = xPixel + 1
            nextX = ScaleX(nextXPixel)
            nextY = TheFunction(nextX)
            nextYPixel = ScaleY(nextY)

            ' Рисуем маленький отрезок
            paper.DrawLine(myPen, xPixel, yPixel, nextXPixel, nextYPixel)

        Next

    End Sub

    Private Function TheFunction(x As Double) As Double
        Return a * x ^ 3 + b * x ^ 2 + c * x + d
    End Function

    Private Function ScaleX(xPixel As Integer) As Double

        Dim xStart As Double = -5
        Dim xEnd As Double = 5
        Dim xScale As Double = PictureBox1.Width / (xEnd - xStart)

        Return (xPixel - PictureBox1.Width / 2) / xScale

    End Function

    Private Function ScaleY(y As Double) As Integer

        Dim yStart As Double = -5
        Dim yEnd As Double = 5
        Dim yScale As Double = PictureBox1.Height / (yEnd - yStart)

        Return CInt(-y * yScale + PictureBox1.Height / 2)

    End Function

End Class