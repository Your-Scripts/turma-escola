Public Class Form1
    Dim notas() As Integer
    Dim alunos As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Pergunta Quantos alunos tem a turma'
        alunos = InputBox("Quantos alunos tem a turma?")
        ReDim notas(alunos - 1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Pergunta a nota de cada aluno'
        For i = 0 To alunos - 1
            notas(i) = InputBox("A Nota do aluno(" & i + 1 & ")")
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Lista nas Notas de cada Aluno da Turma'
        ListBox1.Items.Clear()
        For i = 0 To alunos - 1
            ListBox1.Items.Add("Aluno " & i + 1 & " = " & notas(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Faz a media e apresenta na ListBox'
        ListBox1.Items.Clear()
        Dim soma As Double = 0
        Dim media As Double = 0

        For i = 0 To alunos - 1
            soma = soma + notas(i)
        Next
        media = soma / alunos
        ListBox1.Items.Add("Media= " & media)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Faz o minimo e apresenta na ListBox'
        ListBox1.Items.Clear()
        Dim minimo As Single = 9999
        For i = 0 To alunos - 1
            If notas(i) < minimo Then
                minimo = notas(i)
            End If
        Next
        ListBox1.Items.Add("Nota minima= " & minimo)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Faz o maximo e apresenta na ListBox'
        ListBox1.Items.Clear()
        Dim maximo As Single = -9999
        For i = 0 To alunos - 1
            If notas(i) > maximo Then
                maximo = notas(i)
            End If
        Next
        ListBox1.Items.Add("Nota maxima= " & maximo)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Quantos Alunos tiveram notas inferiores a 5valores'
        ListBox1.Items.Clear()
        Dim c As Integer = 0
        For i = 0 To alunos - 1
            If notas(i) < 5 Then
                c = c + 1
            End If
        Next
        ListBox1.Items.Add("Ha " & c & " notas inferiores a 5")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Quantos Alunos tiveram notas entre 5 e 9valores'
        ListBox1.Items.Clear()
        Dim c As Integer = 0
        For i = 0 To alunos - 1
            If notas(i) >= 5 And notas(i) <= 9 Then
                c = c + 1
            End If
        Next
        ListBox1.Items.Add("Ha " & c & " notas entre 5 e 9")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Quantos Alunos tiveram notas entre 10 e 14valores'
        ListBox1.Items.Clear()
        Dim c As Integer = 0
        For i = 0 To alunos - 1
            If notas(i) >= 10 And notas(i) <= 14 Then
                c = c + 1
            End If
        Next
        ListBox1.Items.Add("Ha " & c & " notas entre 10 e 14")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Quantos Alunos tiveram notas entre 15 e 18valores'
        ListBox1.Items.Clear()
        Dim c As Integer = 0
        For i = 0 To alunos - 1
            If notas(i) >= 15 And notas(i) <= 18 Then
                c = c + 1
            End If
        Next
        ListBox1.Items.Add("Ha " & c & " notas entre 15 e 18")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Quantos alunos tiveram notas superiores a 19valores'
        ListBox1.Items.Clear()
        Dim c As Integer = 0
        For i = 0 To alunos - 1
            If notas(i) >= 19 Then
                c = c + 1
            End If
        Next
        ListBox1.Items.Add("Ha " & c & " notas superiores a 19")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Regra de Tres Simples para apresentar o % de Positivas na Turma'
        ListBox1.Items.Clear()
        Dim positivas As Integer = 0
        Dim percentagem As Double
        For i = 0 To alunos - 1
            If notas(i) >= 10 Then
                positivas = positivas + 1
            End If
        Next
        percentagem = positivas * 100 / alunos
        ListBox1.Items.Add("Ha " & percentagem & " % de positivas")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Regra de Tres Simples para apresentar o % de Negativas na Turma'
        ListBox1.Items.Clear()
        Dim negativas As Integer = 0
        Dim percentagem As Double
        For i = 0 To alunos - 1
            If notas(i) <= 10 Then
                negativas = negativas + 1
            End If
        Next
        percentagem = negativas * 100 / alunos
        ListBox1.Items.Add("Ha " & percentagem & " % de negativas")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub
End Class

'Trabalho Feito pelo João  Gabriel nº14 10TPI'