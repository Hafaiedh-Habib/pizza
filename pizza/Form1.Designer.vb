<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lsttaille = New ComboBox()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        rb3 = New RadioButton()
        cb1 = New CheckBox()
        cb2 = New CheckBox()
        cb3 = New CheckBox()
        cb4 = New CheckBox()
        btn1 = New Button()
        SuspendLayout()
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"Grande", "Petite", "Moyenne"})
        lsttaille.Location = New Point(248, 26)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(167, 28)
        lsttaille.TabIndex = 0
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Location = New Point(106, 94)
        rb1.Name = "rb1"
        rb1.Size = New Size(101, 24)
        rb1.TabIndex = 1
        rb1.TabStop = True
        rb1.Text = "croute fine"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Location = New Point(106, 153)
        rb2.Name = "rb2"
        rb2.Size = New Size(136, 24)
        rb2.TabIndex = 2
        rb2.TabStop = True
        rb2.Text = "croute classique"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' rb3
        ' 
        rb3.AutoSize = True
        rb3.Location = New Point(106, 218)
        rb3.Name = "rb3"
        rb3.Size = New Size(125, 24)
        rb3.TabIndex = 3
        rb3.TabStop = True
        rb3.Text = "croute epaisse"
        rb3.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(440, 94)
        cb1.Name = "cb1"
        cb1.Size = New Size(120, 24)
        cb1.TabIndex = 4
        cb1.Text = "champignons"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(440, 153)
        cb2.Name = "cb2"
        cb2.Size = New Size(63, 24)
        cb2.TabIndex = 5
        cb2.Text = "olive"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(440, 218)
        cb3.Name = "cb3"
        cb3.Size = New Size(88, 24)
        cb3.TabIndex = 6
        cb3.Text = "poivrons"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(440, 289)
        cb4.Name = "cb4"
        cb4.Size = New Size(201, 24)
        cb4.TabIndex = 7
        cb4.Text = "fromage supplementaires"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(166, 380)
        btn1.Name = "btn1"
        btn1.Size = New Size(313, 29)
        btn1.TabIndex = 8
        btn1.Text = "afficher la récapitulatif"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn1)
        Controls.Add(cb4)
        Controls.Add(cb3)
        Controls.Add(cb2)
        Controls.Add(cb1)
        Controls.Add(rb3)
        Controls.Add(rb2)
        Controls.Add(rb1)
        Controls.Add(lsttaille)
        Name = "pizza"
        Text = "pizza"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsttaille As ComboBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents btn1 As Button

End Class
