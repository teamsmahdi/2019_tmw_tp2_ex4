<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S2EX4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.b0 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.bPoint = New System.Windows.Forms.Button()
        Me.bDiv = New System.Windows.Forms.Button()
        Me.bFois = New System.Windows.Forms.Button()
        Me.bMoins = New System.Windows.Forms.Button()
        Me.bPlus = New System.Windows.Forms.Button()
        Me.bCE = New System.Windows.Forms.Button()
        Me.bC = New System.Windows.Forms.Button()
        Me.bEgale = New System.Windows.Forms.Button()
        Me.afficheur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'b0
        '
        Me.b0.Location = New System.Drawing.Point(111, 180)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(26, 23)
        Me.b0.TabIndex = 0
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(143, 180)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(26, 23)
        Me.b1.TabIndex = 1
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(175, 180)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(26, 23)
        Me.b2.TabIndex = 2
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'bPoint
        '
        Me.bPoint.Location = New System.Drawing.Point(207, 180)
        Me.bPoint.Name = "bPoint"
        Me.bPoint.Size = New System.Drawing.Size(26, 23)
        Me.bPoint.TabIndex = 3
        Me.bPoint.Text = "."
        Me.bPoint.UseVisualStyleBackColor = True
        '
        'bDiv
        '
        Me.bDiv.Location = New System.Drawing.Point(335, 180)
        Me.bDiv.Name = "bDiv"
        Me.bDiv.Size = New System.Drawing.Size(26, 23)
        Me.bDiv.TabIndex = 7
        Me.bDiv.Text = "/"
        Me.bDiv.UseVisualStyleBackColor = True
        '
        'bFois
        '
        Me.bFois.Location = New System.Drawing.Point(303, 180)
        Me.bFois.Name = "bFois"
        Me.bFois.Size = New System.Drawing.Size(26, 23)
        Me.bFois.TabIndex = 6
        Me.bFois.Text = "*"
        Me.bFois.UseVisualStyleBackColor = True
        '
        'bMoins
        '
        Me.bMoins.Location = New System.Drawing.Point(271, 180)
        Me.bMoins.Name = "bMoins"
        Me.bMoins.Size = New System.Drawing.Size(26, 23)
        Me.bMoins.TabIndex = 5
        Me.bMoins.Text = "-"
        Me.bMoins.UseVisualStyleBackColor = True
        '
        'bPlus
        '
        Me.bPlus.Location = New System.Drawing.Point(239, 180)
        Me.bPlus.Name = "bPlus"
        Me.bPlus.Size = New System.Drawing.Size(26, 23)
        Me.bPlus.TabIndex = 4
        Me.bPlus.Text = "+"
        Me.bPlus.UseVisualStyleBackColor = True
        '
        'bCE
        '
        Me.bCE.Location = New System.Drawing.Point(433, 180)
        Me.bCE.Name = "bCE"
        Me.bCE.Size = New System.Drawing.Size(41, 23)
        Me.bCE.TabIndex = 10
        Me.bCE.Text = "CE"
        Me.bCE.UseVisualStyleBackColor = True
        '
        'bC
        '
        Me.bC.Location = New System.Drawing.Point(401, 180)
        Me.bC.Name = "bC"
        Me.bC.Size = New System.Drawing.Size(26, 23)
        Me.bC.TabIndex = 9
        Me.bC.Text = "C"
        Me.bC.UseVisualStyleBackColor = True
        '
        'bEgale
        '
        Me.bEgale.Location = New System.Drawing.Point(369, 180)
        Me.bEgale.Name = "bEgale"
        Me.bEgale.Size = New System.Drawing.Size(26, 23)
        Me.bEgale.TabIndex = 8
        Me.bEgale.Text = "="
        Me.bEgale.UseVisualStyleBackColor = True
        '
        'afficheur
        '
        Me.afficheur.Location = New System.Drawing.Point(111, 142)
        Me.afficheur.Name = "afficheur"
        Me.afficheur.Size = New System.Drawing.Size(363, 22)
        Me.afficheur.TabIndex = 11
        Me.afficheur.Text = "0"
        '
        'S2EX4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 549)
        Me.Controls.Add(Me.afficheur)
        Me.Controls.Add(Me.bCE)
        Me.Controls.Add(Me.bC)
        Me.Controls.Add(Me.bEgale)
        Me.Controls.Add(Me.bDiv)
        Me.Controls.Add(Me.bFois)
        Me.Controls.Add(Me.bMoins)
        Me.Controls.Add(Me.bPlus)
        Me.Controls.Add(Me.bPoint)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b0)
        Me.Name = "S2EX4"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b0 As System.Windows.Forms.Button
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents bPoint As System.Windows.Forms.Button
    Friend WithEvents bDiv As System.Windows.Forms.Button
    Friend WithEvents bFois As System.Windows.Forms.Button
    Friend WithEvents bMoins As System.Windows.Forms.Button
    Friend WithEvents bPlus As System.Windows.Forms.Button
    Friend WithEvents bCE As System.Windows.Forms.Button
    Friend WithEvents bC As System.Windows.Forms.Button
    Friend WithEvents bEgale As System.Windows.Forms.Button
    Friend WithEvents afficheur As System.Windows.Forms.TextBox

End Class
