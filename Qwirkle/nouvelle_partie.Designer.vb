﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nouvelle_partie
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
        Me.bp_2joueurs = New System.Windows.Forms.Button()
        Me.bp_3joueurs = New System.Windows.Forms.Button()
        Me.bp_4joueurs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bp_2joueurs
        '
        Me.bp_2joueurs.Location = New System.Drawing.Point(331, 50)
        Me.bp_2joueurs.Name = "bp_2joueurs"
        Me.bp_2joueurs.Size = New System.Drawing.Size(94, 37)
        Me.bp_2joueurs.TabIndex = 0
        Me.bp_2joueurs.Text = "2 joueurs"
        Me.bp_2joueurs.UseVisualStyleBackColor = True
        '
        'bp_3joueurs
        '
        Me.bp_3joueurs.Location = New System.Drawing.Point(331, 141)
        Me.bp_3joueurs.Name = "bp_3joueurs"
        Me.bp_3joueurs.Size = New System.Drawing.Size(94, 37)
        Me.bp_3joueurs.TabIndex = 1
        Me.bp_3joueurs.Text = "3 joueurs"
        Me.bp_3joueurs.UseVisualStyleBackColor = True
        '
        'bp_4joueurs
        '
        Me.bp_4joueurs.Location = New System.Drawing.Point(331, 229)
        Me.bp_4joueurs.Name = "bp_4joueurs"
        Me.bp_4joueurs.Size = New System.Drawing.Size(94, 37)
        Me.bp_4joueurs.TabIndex = 2
        Me.bp_4joueurs.Text = "4 joueurs"
        Me.bp_4joueurs.UseVisualStyleBackColor = True
        '
        'nouvelle_partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bp_4joueurs)
        Me.Controls.Add(Me.bp_3joueurs)
        Me.Controls.Add(Me.bp_2joueurs)
        Me.Name = "nouvelle_partie"
        Me.Text = "nouvelle_partie"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bp_2joueurs As Button
    Friend WithEvents bp_3joueurs As Button
    Friend WithEvents bp_4joueurs As Button
End Class
