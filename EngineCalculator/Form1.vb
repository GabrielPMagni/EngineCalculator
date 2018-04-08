Public Class frmTelaInicio


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double
        Dim sMgs1 As String
        Dim sMgs2 As String
        sMgs1 = "Caractére inválido. Digite valores numéricos."
        sMgs2 = "Selecione uma opção de cálculo."
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox(sMgs1,, "Erro 001")
            TextBox1.Select()
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then


            MsgBox(sMgs1,, "Erro 001")
            TextBox2.Select()
            Exit Sub
        End If


        If RadioButton1.Checked Then

            num2 = TextBox1.Text
            num1 = TextBox2.Text
            resultado = num2 * num1 / 120

        End If

        If RadioButton2.Checked Then
            num2 = TextBox1.Text
            num1 = TextBox2.Text
            resultado = 120 * num2 / num1
        End If

        If RadioButton3.Checked Then
            num2 = TextBox1.Text
            num1 = TextBox2.Text
            resultado = 120 * num1 / num2
        End If


        TextBox3.Text = resultado
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Digite o número de Pólos"
        Label2.Text = "Digite o número de RPM"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Digite a Frequência"
        Label2.Text = "Digite o número de RPM"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Digite o número de Pólos"
        Label2.Text = "Digite a Frequência"
    End Sub



End Class