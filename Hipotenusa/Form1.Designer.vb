<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTNcalcular = New System.Windows.Forms.Button()
        Me.TXTx1 = New System.Windows.Forms.TextBox()
        Me.TXTy1 = New System.Windows.Forms.TextBox()
        Me.TXTy2 = New System.Windows.Forms.TextBox()
        Me.TXTx2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTresultado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNcalcular
        '
        Me.BTNcalcular.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcalcular.Location = New System.Drawing.Point(328, 316)
        Me.BTNcalcular.Name = "BTNcalcular"
        Me.BTNcalcular.Size = New System.Drawing.Size(92, 31)
        Me.BTNcalcular.TabIndex = 0
        Me.BTNcalcular.Text = "Calcular"
        Me.BTNcalcular.UseVisualStyleBackColor = True
        '
        'TXTx1
        '
        Me.TXTx1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXTx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTx1.Location = New System.Drawing.Point(161, 92)
        Me.TXTx1.Name = "TXTx1"
        Me.TXTx1.Size = New System.Drawing.Size(100, 24)
        Me.TXTx1.TabIndex = 1
        '
        'TXTy1
        '
        Me.TXTy1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXTy1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTy1.Location = New System.Drawing.Point(320, 92)
        Me.TXTy1.Name = "TXTy1"
        Me.TXTy1.Size = New System.Drawing.Size(100, 24)
        Me.TXTy1.TabIndex = 2
        '
        'TXTy2
        '
        Me.TXTy2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXTy2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTy2.Location = New System.Drawing.Point(320, 186)
        Me.TXTy2.Name = "TXTy2"
        Me.TXTy2.Size = New System.Drawing.Size(100, 24)
        Me.TXTy2.TabIndex = 4
        '
        'TXTx2
        '
        Me.TXTx2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXTx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTx2.Location = New System.Drawing.Point(161, 186)
        Me.TXTx2.Name = "TXTx2"
        Me.TXTx2.Size = New System.Drawing.Size(100, 24)
        Me.TXTx2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Punto 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Punto 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "X2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(317, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Y2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Y1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X1"
        '
        'TXTresultado
        '
        Me.TXTresultado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXTresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTresultado.Location = New System.Drawing.Point(161, 265)
        Me.TXTresultado.Name = "TXTresultado"
        Me.TXTresultado.Size = New System.Drawing.Size(259, 24)
        Me.TXTresultado.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Resultado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(397, 27)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "DISTANCIA ENTRE 2 PUNTOS"
        '
        'BTNlimpiar
        '
        Me.BTNlimpiar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNlimpiar.Location = New System.Drawing.Point(34, 316)
        Me.BTNlimpiar.Name = "BTNlimpiar"
        Me.BTNlimpiar.Size = New System.Drawing.Size(92, 31)
        Me.BTNlimpiar.TabIndex = 14
        Me.BTNlimpiar.Text = "Limpiar"
        Me.BTNlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(449, 359)
        Me.Controls.Add(Me.BTNlimpiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTresultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTy2)
        Me.Controls.Add(Me.TXTx2)
        Me.Controls.Add(Me.TXTy1)
        Me.Controls.Add(Me.TXTx1)
        Me.Controls.Add(Me.BTNcalcular)
        Me.Name = "Form1"
        Me.Text = "DISTANCIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNcalcular As Button
    Friend WithEvents TXTx1 As TextBox
    Friend WithEvents TXTy1 As TextBox
    Friend WithEvents TXTy2 As TextBox
    Friend WithEvents TXTx2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTresultado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNlimpiar As Button
End Class
