﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Erronkak
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tableroa1 = New ChessGame.Tableroa()
        Me.SuspendLayout()
        '
        'Tableroa1
        '
        Me.Tableroa1.Location = New System.Drawing.Point(12, 12)
        Me.Tableroa1.Name = "Tableroa1"
        Me.Tableroa1.Size = New System.Drawing.Size(717, 680)
        Me.Tableroa1.TabIndex = 0
        '
        'Erronkak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 681)
        Me.Controls.Add(Me.Tableroa1)
        Me.Name = "Erronkak"
        Me.Text = "Erronkak"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tableroa1 As Tableroa
End Class
