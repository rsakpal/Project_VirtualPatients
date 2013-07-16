<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEInfo_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.submit_Button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.otherEthinicty_TextBox = New System.Windows.Forms.TextBox()
        Me.ethnicity_ComboBox = New System.Windows.Forms.ComboBox()
        Me.age_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.female_RadioButton = New System.Windows.Forms.RadioButton()
        Me.male_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.MedicalExaminer_DataTBLTableAdapter2 = New Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Virtual Human Behavior Toolkit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.submit_Button)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(40, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 465)
        Me.Panel1.TabIndex = 1
        '
        'submit_Button
        '
        Me.submit_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_Button.Location = New System.Drawing.Point(209, 409)
        Me.submit_Button.Name = "submit_Button"
        Me.submit_Button.Size = New System.Drawing.Size(100, 32)
        Me.submit_Button.TabIndex = 2
        Me.submit_Button.Text = "Submit"
        Me.submit_Button.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.otherEthinicty_TextBox)
        Me.Panel2.Controls.Add(Me.ethnicity_ComboBox)
        Me.Panel2.Controls.Add(Me.age_ComboBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.female_RadioButton)
        Me.Panel2.Controls.Add(Me.male_RadioButton)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(49, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 303)
        Me.Panel2.TabIndex = 1
        '
        'otherEthinicty_TextBox
        '
        Me.otherEthinicty_TextBox.Location = New System.Drawing.Point(162, 250)
        Me.otherEthinicty_TextBox.Name = "otherEthinicty_TextBox"
        Me.otherEthinicty_TextBox.Size = New System.Drawing.Size(204, 26)
        Me.otherEthinicty_TextBox.TabIndex = 7
        Me.otherEthinicty_TextBox.Text = "Please Specify"
        Me.otherEthinicty_TextBox.Visible = False
        '
        'ethnicity_ComboBox
        '
        Me.ethnicity_ComboBox.FormattingEnabled = True
        Me.ethnicity_ComboBox.Items.AddRange(New Object() {"American Indian or Alaska Native", "Hawaiian or Other Pacific Islander", "Asian or Asian American", "Black or African Anerican", "Hispanic or Latino", "Non-Hispanic White", "Indian or Hindu", "Other"})
        Me.ethnicity_ComboBox.Location = New System.Drawing.Point(162, 206)
        Me.ethnicity_ComboBox.Name = "ethnicity_ComboBox"
        Me.ethnicity_ComboBox.Size = New System.Drawing.Size(204, 27)
        Me.ethnicity_ComboBox.TabIndex = 6
        '
        'age_ComboBox
        '
        Me.age_ComboBox.FormattingEnabled = True
        Me.age_ComboBox.Items.AddRange(New Object() {"Under 12 years old", "12 - 17 years old", "18 - 24 years old", "25 - 34 years old", "35 - 44 years old", "45 - 54 years old", "55 - 64 years old", "65 - 74 years old", "75 years or older"})
        Me.age_ComboBox.Location = New System.Drawing.Point(162, 45)
        Me.age_ComboBox.Name = "age_ComboBox"
        Me.age_ComboBox.Size = New System.Drawing.Size(204, 27)
        Me.age_ComboBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Race/Ethnicity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender :"
        '
        'female_RadioButton
        '
        Me.female_RadioButton.AutoSize = True
        Me.female_RadioButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.female_RadioButton.Location = New System.Drawing.Point(272, 128)
        Me.female_RadioButton.Name = "female_RadioButton"
        Me.female_RadioButton.Size = New System.Drawing.Size(77, 23)
        Me.female_RadioButton.TabIndex = 2
        Me.female_RadioButton.TabStop = True
        Me.female_RadioButton.Text = "Female"
        Me.female_RadioButton.UseVisualStyleBackColor = True
        '
        'male_RadioButton
        '
        Me.male_RadioButton.AutoSize = True
        Me.male_RadioButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.male_RadioButton.Location = New System.Drawing.Point(182, 128)
        Me.male_RadioButton.Name = "male_RadioButton"
        Me.male_RadioButton.Size = New System.Drawing.Size(60, 23)
        Me.male_RadioButton.TabIndex = 1
        Me.male_RadioButton.TabStop = True
        Me.male_RadioButton.Text = "Male"
        Me.male_RadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Age :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please enter your details below and click on the Submit button."
        '
        'exit_Button
        '
        Me.exit_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_Button.Location = New System.Drawing.Point(454, 549)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(100, 32)
        Me.exit_Button.TabIndex = 2
        Me.exit_Button.Text = "Exit"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'MedicalExaminer_DataTBLTableAdapter2
        '
        Me.MedicalExaminer_DataTBLTableAdapter2.ClearBeforeFill = True
        '
        'MEInfo_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 598)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MEInfo_form"
        Me.Text = "Virtual Human Behavior Toolkit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents submit_Button As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents female_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents male_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents age_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ethnicity_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents otherEthinicty_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicalExaminer_DataTBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter
    Friend WithEvents MedicalExaminer_DataTBLTableAdapter2 As Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter

End Class
