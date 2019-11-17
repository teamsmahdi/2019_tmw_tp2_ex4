Public Class S2EX4
    Private operateur As Button
    Private operande As Double
    Private resultat As Double
    Private Sub chiffre_Click(sender As Object, e As EventArgs) Handles b0.Click, _
                                                                        b1.Click, _
                                                                        b2.Click
        Dim b As Button = CType(sender, Button)
        If (afficheur.Text = "0") Then
            afficheur.Text = ""
        End If
        afficheur.Text &= b.Text
    End Sub
    Private Sub C_Ce_Click(sender As Object, e As EventArgs) Handles bC.Click, _
                                                                     bCE.Click, _
                                                                     bPoint.Click

        Dim b As Button = CType(sender, Button)

        Select Case b.Text
            Case "CE"
                afficheur.Text = "0"
            Case "C"
                If Len(afficheur.Text) >= 2 Or afficheur.Text.IndexOf(".") = Len(afficheur.Text) - 1 Then
                    'supprimer le dernier chiffre de l'afficheur
                    afficheur.Text = afficheur.Text.Substring(0, Len(afficheur.Text) - 1)
                    ' en cas ou  "." est en dernier position il faut supprimer
                    If afficheur.Text.IndexOf(".") = Len(afficheur.Text) - 1 Then
                        afficheur.Text = afficheur.Text.Substring(0, Len(afficheur.Text) - 1)
                    End If
                Else
                    afficheur.Text = "0"
                End If
            Case "."

                If Not afficheur.Text.Contains(".") Then
                    afficheur.Text &= b.Text
                End If

        End Select


    End Sub
    Private Sub Operateur_Click(sender As Object, e As EventArgs) Handles bPlus.Click, _
                                                                       bMoins.Click, _
                                                                       bFois.Click, _
                                                                       bDiv.Click, _
                                                                       bEgale.Click
        Dim b As Button = CType(sender, Button)

        'si pas d'operateur déja cliqué, il faut avoir un operande à zero et l'operateur le bouton que vous avez cliqué. l'afficheur toujours à zero
        If IsNothing(operateur) Then
            operateur = b
            operande = CDbl(afficheur.Text)
            afficheur.Text = "0"
        Else
            '1 le click sur  egale calcule sur il y'a une ancien operation
            If b.Text = "=" Then
                Select Case operateur.Text
                    Case "+", "-", "*", "/"
                        If operateur.Text = "+" Then
                            operande += CDbl(afficheur.Text)
                        ElseIf operateur.Text = "-" Then
                            operande -= CDbl(afficheur.Text)
                        ElseIf operateur.Text = "*" Then
                            operande *= CDbl(afficheur.Text)
                        Else
                            operande /= CDbl(afficheur.Text)
                        End If
                        operateur = bPlus
                        afficheur.Text = operande
                        operande = 0
                End Select
            Else
                Select Case operateur.Text
                    Case "+", "-", "*", "/"
                        If operateur.Text = "+" Then
                            operande += CDbl(afficheur.Text)
                        ElseIf operateur.Text = "-" Then
                            operande -= CDbl(afficheur.Text)
                        ElseIf operateur.Text = "*" Then
                            operande *= CDbl(afficheur.Text)
                        Else
                            operande /= CDbl(afficheur.Text)
                        End If
                End Select
                operateur = b
                afficheur.Text = "0"
            End If


        End If


        'si ce n'est pas le premier clic
        ' selon ce que vous avez cliqué :
        ' 1-a evaluer l'ancien operation, enregistrer le resultat comme ancien operande et actualiser l'afficheur  
        ' 2-a enregistrer le bouton en cours comme dans operteur 

    End Sub



 
End Class
