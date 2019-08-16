Public Class telaPrincipal

    Dim pontosX As New List(Of Integer)()
    Dim pontosY As New List(Of Integer)()
    Dim tela As Bitmap
    Dim contaPontos As Integer
    Dim permiteClick, escolheLinear, escolheQuadratica, escolheCubica As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tela = New Bitmap(quadro.Width, quadro.Height)
        quadro.Image = tela

    End Sub

    Private Sub tracaBezierQuadratica_Click(sender As Object, e As EventArgs) Handles curvaBezierQuadratica.Click

        MessageBox.Show("Escolha 3 pontos de controle na tela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        permiteClick = True
        escolheQuadratica = True

        'Carrega o bitmap para a tela
        quadro.Image = tela

        'Reseta as listas de pontos
        pontosX = New List(Of Integer)
        pontosY = New List(Of Integer)

    End Sub

    'Botão para traçar a curva de Bezier
    Private Sub tracaBezierCubico_Click(sender As Object, e As EventArgs) Handles curvaBezierCubica.Click

        MessageBox.Show("Escolha 4 pontos de controle na tela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        permiteClick = True
        escolheCubica = True

        'Carrega o bitmap para a tela
        quadro.Image = tela

        'Reseta as listas de pontos
        pontosX = New List(Of Integer)
        pontosY = New List(Of Integer)

    End Sub

    'Limpa as curvas traçadas na tela

    Private Sub resetaTela_Click(sender As Object, e As EventArgs) Handles resetaTela.Click
        'Reseta as listas de pontos
        pontosX = New List(Of Integer)
        pontosY = New List(Of Integer)

        'Reseta o bitmap
        tela = New Bitmap(quadro.Width, quadro.Height)

        'Carrega o bitmap para a tela
        quadro.Image = tela
    End Sub

    'Captura o pixel selecionado com o clique do cursor
    Private Sub quadro_Click(sender As Object, e As EventArgs) Handles quadro.Click
        If (permiteClick) Then
            'valores subtraídos para posicionar o pixel no bitmap e salvos na lista de pontos X e Y
            pontosX.Add(MousePosition.X - Me.Location.X - quadro.Location.X - 8)
            pontosY.Add(MousePosition.Y - Me.Location.Y - quadro.Location.Y - 30)

            contaPontos += 1

            tela.SetPixel(pontosX(contaPontos - 1), pontosY(contaPontos - 1), Color.Black)

            quadro.Image = tela


            'Verifica se um par de pontos foi selecionado na tela
            If (contaPontos > 2 And contaPontos < 4 And escolheQuadratica) Then
                Dim cor As Color
                Dim codigoCor As String

                'Pede a cor para colorir as retas de limite
                MessageBox.Show("Escolha a cor para das retas limitantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                    codigoCor = ColorTranslator.ToHtml(ColorDialog1.Color)
                    cor = ColorTranslator.FromHtml(codigoCor)

                    Try
                        'Gera as retas delimitadoras
                        bresenhamReta(pontosX(contaPontos - 3), pontosY(contaPontos - 3), pontosX(contaPontos - 2), pontosY(contaPontos - 2), ColorTranslator.FromHtml(codigoCor))
                        bresenhamReta(pontosX(contaPontos - 2), pontosY(contaPontos - 2), pontosX(contaPontos - 1), pontosY(contaPontos - 1), ColorTranslator.FromHtml(codigoCor))

                        'Carrega o bitmap para a tela
                        quadro.Image = tela

                        'Pede a cor para colorir a curva de Bezier
                        MessageBox.Show("Escolha a cor da curva de Bezier", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                            codigoCor = ColorTranslator.ToHtml(ColorDialog1.Color)
                            cor = ColorTranslator.FromHtml(codigoCor)

                            'Gera a curva de Bezier
                            BezierQuadratica(pontosX(contaPontos - 3), pontosY(contaPontos - 3), pontosX(contaPontos - 2), pontosY(contaPontos - 2), pontosX(contaPontos - 1), pontosY(contaPontos - 1), ColorTranslator.FromHtml(codigoCor))
                        End If

                    Catch ex As OverflowException

                    End Try

                End If
                'Carrega o bitmap para a tela
                quadro.Image = tela

                'Reseta as listas de pontos
                pontosX = New List(Of Integer)
                pontosY = New List(Of Integer)

                contaPontos = 0

                escolheQuadratica = False

                permiteClick = False

            Else
                'Verifica se um par de pontos foi selecionado na tela
                If (contaPontos > 3 And contaPontos < 5 And escolheCubica) Then
                    Dim cor As Color
                    Dim codigoCor As String

                    'Pede a cor para colorir as retas de limite
                    MessageBox.Show("Escolha a cor para das retas limitantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                        codigoCor = ColorTranslator.ToHtml(ColorDialog1.Color)
                        cor = ColorTranslator.FromHtml(codigoCor)

                        Try
                            'Gera as retas delimitadoras
                            bresenhamReta(pontosX(contaPontos - 4), pontosY(contaPontos - 4), pontosX(contaPontos - 3), pontosY(contaPontos - 3), ColorTranslator.FromHtml(codigoCor))
                            bresenhamReta(pontosX(contaPontos - 3), pontosY(contaPontos - 3), pontosX(contaPontos - 2), pontosY(contaPontos - 2), ColorTranslator.FromHtml(codigoCor))
                            bresenhamReta(pontosX(contaPontos - 2), pontosY(contaPontos - 2), pontosX(contaPontos - 1), pontosY(contaPontos - 1), ColorTranslator.FromHtml(codigoCor))

                            'Carrega o bitmap para a tela
                            quadro.Image = tela

                            'Pede a cor para colorir a curva de Bezier
                            MessageBox.Show("Escolha a cor da curva de Bezier", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                                codigoCor = ColorTranslator.ToHtml(ColorDialog1.Color)
                                cor = ColorTranslator.FromHtml(codigoCor)

                                'Gera a curva de Bezier
                                BezierCubica(pontosX(contaPontos - 4), pontosY(contaPontos - 4), pontosX(contaPontos - 3), pontosY(contaPontos - 3), pontosX(contaPontos - 2), pontosY(contaPontos - 2), pontosX(contaPontos - 1), pontosY(contaPontos - 1), ColorTranslator.FromHtml(codigoCor))
                            End If

                        Catch ex As OverflowException

                        End Try

                    End If
                    'Carrega o bitmap para a tela
                    quadro.Image = tela

                    'Reseta as listas de pontos
                    pontosX = New List(Of Integer)
                    pontosY = New List(Of Integer)

                    contaPontos = 0

                    escolheCubica = False

                    permiteClick = False

                End If

            End If

        End If

    End Sub

    'Algoritmo de Bresenham para traçar retas utilizando apenas calculos com números inteiros
    Function bresenhamReta(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cor As Color)
        Dim x As Double = x1
        Dim y As Double = y1
        Dim dx As Integer = x2 - x1
        Dim dy As Integer = y2 - y1
        Dim p, xIncr, yIncr, const1, const2 As Integer

        tela.SetPixel(x, y, cor)

        If (dx < 0) Then
            dx = -dx
            xIncr = -1
        Else
            xIncr += 1
        End If

        If (dy < 0) Then
            dy = -dy
            yIncr = -1
        Else
            yIncr += 1
        End If

        If (dx > dy) Then
            p = 2 * dy - dx
            const1 = 2 * dy
            const2 = 2 * (dy - dx)
            For i = 0 To dx - 1
                x += xIncr
                If (p < 0) Then
                    p += const1
                Else
                    y += yIncr
                    p += const2
                End If

                tela.SetPixel(x, y, cor)

            Next
        Else
            p = 2 * dx - dy
            const1 = 2 * dx
            const2 = 2 * (dx - dy)

            For i = 0 To dy - 1
                y += yIncr
                If (p < 0) Then
                    p += const1
                Else
                    p += const2
                    x += xIncr
                End If

                tela.SetPixel(x, y, cor)

            Next
        End If

    End Function

    Function BezierQuadratica(xC1 As Integer, yC1 As Integer, xC2 As Integer, yC2 As Integer, xC3 As Integer, yC3 As Integer, cor As Color) As Bitmap

        Dim xOld As Integer = xC1
        Dim yOld As Integer = yC1
        Dim xNew, yNew

        For t = 0 To 1 Step 0.001

            xNew = Math.Pow((1 - t), 2) * xC1 + 2 * t * (1 - t) * xC2 + Math.Pow(t, 2) * xC3
            yNew = Math.Pow((1 - t), 2) * yC1 + 2 * t * (1 - t) * yC2 + Math.Pow(t, 2) * yC3

            bresenhamReta(Math.Abs(xOld), Math.Abs(yOld), Math.Abs(xNew), Math.Abs(yNew), cor)

            Me.Refresh()

            xOld = xNew
            yOld = yNew
        Next

        Return tela
    End Function


    Function BezierCubica(xC1 As Integer, yC1 As Integer, xC2 As Integer, yC2 As Integer, xC3 As Integer, yC3 As Integer, xC4 As Integer, yC4 As Integer, cor As Color) As Bitmap

        Dim xOld As Integer = xC1
        Dim yOld As Integer = yC1
        Dim xNew, yNew

        For t = 0 To 1 Step 0.001

            xNew = Math.Pow((1 - t), 3) * xC1 + 3 * t * Math.Pow((1 - t), 2) * xC2 + 3 * (1 - t) * Math.Pow(t, 2) * xC3 + Math.Pow(t, 3) * xC4
            yNew = Math.Pow((1 - t), 3) * yC1 + 3 * t * Math.Pow((1 - t), 2) * yC2 + 3 * (1 - t) * Math.Pow(t, 2) * yC3 + Math.Pow(t, 3) * yC4

            bresenhamReta(Math.Abs(xOld), Math.Abs(yOld), Math.Abs(xNew), Math.Abs(yNew), cor)

            Me.Refresh()

            xOld = xNew
            yOld = yNew
        Next

        Return tela
    End Function

End Class
