<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hasiera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hasiera))
        Me.btnJokatu = New System.Windows.Forms.Button()
        Me.btnErronkak = New System.Windows.Forms.Button()
        Me.btnIrekierak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJokatu
        '
        Me.btnJokatu.Location = New System.Drawing.Point(203, 121)
        Me.btnJokatu.Name = "btnJokatu"
        Me.btnJokatu.Size = New System.Drawing.Size(165, 40)
        Me.btnJokatu.TabIndex = 0
        Me.btnJokatu.Text = "JOKATU"
        Me.btnJokatu.UseVisualStyleBackColor = True
        '
        'btnErronkak
        '
        Me.btnErronkak.Location = New System.Drawing.Point(203, 185)
        Me.btnErronkak.Name = "btnErronkak"
        Me.btnErronkak.Size = New System.Drawing.Size(165, 45)
        Me.btnErronkak.TabIndex = 1
        Me.btnErronkak.Text = "ERRONKAK"
        Me.btnErronkak.UseVisualStyleBackColor = True
        '
        'btnIrekierak
        '
        Me.btnIrekierak.Location = New System.Drawing.Point(203, 250)
        Me.btnIrekierak.Name = "btnIrekierak"
        Me.btnIrekierak.Size = New System.Drawing.Size(165, 45)
        Me.btnIrekierak.TabIndex = 2
        Me.btnIrekierak.Text = "HASIERAK"
        Me.btnIrekierak.UseVisualStyleBackColor = True
        '
        'Hasiera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 382)
        Me.Controls.Add(Me.btnIrekierak)
        Me.Controls.Add(Me.btnErronkak)
        Me.Controls.Add(Me.btnJokatu)
        Me.Name = "Hasiera"
        Me.Text = "Hasiera"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJokatu As Button
    Friend WithEvents btnErronkak As Button
    Friend WithEvents btnIrekierak As Button
End Class
