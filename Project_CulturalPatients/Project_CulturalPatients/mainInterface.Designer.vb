<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainInterface
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainInterface))
        Me.AxActiveHaptekX1 = New AxACTIVEHAPTEKXLib.AxActiveHaptekX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.retrieveQuestion_Button = New System.Windows.Forms.Button()
        Me.query_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.query_TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.response_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.QuestionnaireFemaleTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulturalPatients_DBDataSetQuestion1 = New Project_CulturalPatients.CulturalPatients_DBDataSetQuestion()
        Me.QuestionnaireMaleTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionnaireFemale_TBLTableAdapter1 = New Project_CulturalPatients.CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireFemale_TBLTableAdapter()
        Me.QuestionnaireMale_TBLTableAdapter1 = New Project_CulturalPatients.CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireMale_TBLTableAdapter()
        Me.MedicalExaminer_DataTBLTableAdapter1 = New Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter()
        Me.male_DataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponseMaleTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulturalPatientsDBDataSetResponse1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulturalPatients_DBDataSetResponse1 = New Project_CulturalPatients.CulturalPatients_DBDataSetResponse()
        Me.female_DataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QNumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponseDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEGenderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponseFemaleTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResponseMale_TBLTableAdapter1 = New Project_CulturalPatients.CulturalPatients_DBDataSetResponseTableAdapters.responseMale_TBLTableAdapter()
        Me.ResponseFemale_TBLTableAdapter1 = New Project_CulturalPatients.CulturalPatients_DBDataSetResponseTableAdapters.responseFemale_TBLTableAdapter()
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QuestionnaireFemaleTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulturalPatients_DBDataSetQuestion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionnaireMaleTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.male_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponseMaleTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulturalPatientsDBDataSetResponse1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulturalPatients_DBDataSetResponse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.female_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponseFemaleTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxActiveHaptekX1
        '
        Me.AxActiveHaptekX1.Enabled = True
        Me.AxActiveHaptekX1.Location = New System.Drawing.Point(25, 55)
        Me.AxActiveHaptekX1.Name = "AxActiveHaptekX1"
        Me.AxActiveHaptekX1.OcxState = CType(resources.GetObject("AxActiveHaptekX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActiveHaptekX1.Size = New System.Drawing.Size(390, 560)
        Me.AxActiveHaptekX1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Virtual Human Behavior Toolkit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'back_Button
        '
        Me.back_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_Button.Location = New System.Drawing.Point(25, 639)
        Me.back_Button.Name = "back_Button"
        Me.back_Button.Size = New System.Drawing.Size(100, 32)
        Me.back_Button.TabIndex = 3
        Me.back_Button.Text = "Back"
        Me.back_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.retrieveQuestion_Button)
        Me.Panel1.Controls.Add(Me.query_Button)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.query_TextBox)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(442, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 559)
        Me.Panel1.TabIndex = 4
        '
        'retrieveQuestion_Button
        '
        Me.retrieveQuestion_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retrieveQuestion_Button.Location = New System.Drawing.Point(211, 507)
        Me.retrieveQuestion_Button.Name = "retrieveQuestion_Button"
        Me.retrieveQuestion_Button.Size = New System.Drawing.Size(120, 32)
        Me.retrieveQuestion_Button.TabIndex = 5
        Me.retrieveQuestion_Button.Text = "Question"
        Me.retrieveQuestion_Button.UseVisualStyleBackColor = True
        '
        'query_Button
        '
        Me.query_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.query_Button.Location = New System.Drawing.Point(391, 507)
        Me.query_Button.Name = "query_Button"
        Me.query_Button.Size = New System.Drawing.Size(120, 32)
        Me.query_Button.TabIndex = 4
        Me.query_Button.Text = "Send Query"
        Me.query_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(31, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Click to Talk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'query_TextBox
        '
        Me.query_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.query_TextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.query_TextBox.Location = New System.Drawing.Point(31, 357)
        Me.query_TextBox.Multiline = True
        Me.query_TextBox.Name = "query_TextBox"
        Me.query_TextBox.Size = New System.Drawing.Size(480, 128)
        Me.query_TextBox.TabIndex = 2
        Me.query_TextBox.Text = "Enter your question here."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.response_TextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Response"
        '
        'response_TextBox
        '
        Me.response_TextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.response_TextBox.Location = New System.Drawing.Point(13, 25)
        Me.response_TextBox.Multiline = True
        Me.response_TextBox.Name = "response_TextBox"
        Me.response_TextBox.Size = New System.Drawing.Size(453, 133)
        Me.response_TextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(481, 133)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exit_Button
        '
        Me.exit_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_Button.Location = New System.Drawing.Point(883, 639)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(100, 32)
        Me.exit_Button.TabIndex = 5
        Me.exit_Button.Text = "Exit"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'QuestionnaireFemaleTBLBindingSource
        '
        Me.QuestionnaireFemaleTBLBindingSource.DataMember = "questionnaireFemale_TBL"
        Me.QuestionnaireFemaleTBLBindingSource.DataSource = Me.CulturalPatients_DBDataSetQuestion1
        '
        'CulturalPatients_DBDataSetQuestion1
        '
        Me.CulturalPatients_DBDataSetQuestion1.DataSetName = "CulturalPatients_DBDataSetQuestion"
        Me.CulturalPatients_DBDataSetQuestion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionnaireMaleTBLBindingSource
        '
        Me.QuestionnaireMaleTBLBindingSource.DataMember = "questionnaireMale_TBL"
        Me.QuestionnaireMaleTBLBindingSource.DataSource = Me.CulturalPatients_DBDataSetQuestion1
        '
        'QuestionnaireFemale_TBLTableAdapter1
        '
        Me.QuestionnaireFemale_TBLTableAdapter1.ClearBeforeFill = True
        '
        'QuestionnaireMale_TBLTableAdapter1
        '
        Me.QuestionnaireMale_TBLTableAdapter1.ClearBeforeFill = True
        '
        'MedicalExaminer_DataTBLTableAdapter1
        '
        Me.MedicalExaminer_DataTBLTableAdapter1.ClearBeforeFill = True
        '
        'male_DataGridView
        '
        Me.male_DataGridView.AutoGenerateColumns = False
        Me.male_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.male_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.QNumDataGridViewTextBoxColumn, Me.ResponseDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.MEGenderDataGridViewTextBoxColumn})
        Me.male_DataGridView.DataSource = Me.ResponseMaleTBLBindingSource
        Me.male_DataGridView.Location = New System.Drawing.Point(1006, 93)
        Me.male_DataGridView.Name = "male_DataGridView"
        Me.male_DataGridView.Size = New System.Drawing.Size(418, 191)
        Me.male_DataGridView.TabIndex = 6
        Me.male_DataGridView.Visible = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'QNumDataGridViewTextBoxColumn
        '
        Me.QNumDataGridViewTextBoxColumn.DataPropertyName = "Q_Num"
        Me.QNumDataGridViewTextBoxColumn.HeaderText = "Q_Num"
        Me.QNumDataGridViewTextBoxColumn.Name = "QNumDataGridViewTextBoxColumn"
        '
        'ResponseDataGridViewTextBoxColumn
        '
        Me.ResponseDataGridViewTextBoxColumn.DataPropertyName = "Response"
        Me.ResponseDataGridViewTextBoxColumn.HeaderText = "Response"
        Me.ResponseDataGridViewTextBoxColumn.Name = "ResponseDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'MEGenderDataGridViewTextBoxColumn
        '
        Me.MEGenderDataGridViewTextBoxColumn.DataPropertyName = "ME_Gender"
        Me.MEGenderDataGridViewTextBoxColumn.HeaderText = "ME_Gender"
        Me.MEGenderDataGridViewTextBoxColumn.Name = "MEGenderDataGridViewTextBoxColumn"
        '
        'ResponseMaleTBLBindingSource
        '
        Me.ResponseMaleTBLBindingSource.DataMember = "responseMale_TBL"
        Me.ResponseMaleTBLBindingSource.DataSource = Me.CulturalPatientsDBDataSetResponse1BindingSource
        '
        'CulturalPatientsDBDataSetResponse1BindingSource
        '
        Me.CulturalPatientsDBDataSetResponse1BindingSource.DataSource = Me.CulturalPatients_DBDataSetResponse1
        Me.CulturalPatientsDBDataSetResponse1BindingSource.Position = 0
        '
        'CulturalPatients_DBDataSetResponse1
        '
        Me.CulturalPatients_DBDataSetResponse1.DataSetName = "CulturalPatients_DBDataSetResponse"
        Me.CulturalPatients_DBDataSetResponse1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'female_DataGridView
        '
        Me.female_DataGridView.AutoGenerateColumns = False
        Me.female_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.female_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.QNumDataGridViewTextBoxColumn1, Me.ResponseDataGridViewTextBoxColumn1, Me.GenderDataGridViewTextBoxColumn1, Me.MEGenderDataGridViewTextBoxColumn1})
        Me.female_DataGridView.DataSource = Me.ResponseFemaleTBLBindingSource
        Me.female_DataGridView.Location = New System.Drawing.Point(1005, 362)
        Me.female_DataGridView.Name = "female_DataGridView"
        Me.female_DataGridView.Size = New System.Drawing.Size(418, 209)
        Me.female_DataGridView.TabIndex = 7
        Me.female_DataGridView.Visible = False
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'QNumDataGridViewTextBoxColumn1
        '
        Me.QNumDataGridViewTextBoxColumn1.DataPropertyName = "Q_Num"
        Me.QNumDataGridViewTextBoxColumn1.HeaderText = "Q_Num"
        Me.QNumDataGridViewTextBoxColumn1.Name = "QNumDataGridViewTextBoxColumn1"
        '
        'ResponseDataGridViewTextBoxColumn1
        '
        Me.ResponseDataGridViewTextBoxColumn1.DataPropertyName = "Response"
        Me.ResponseDataGridViewTextBoxColumn1.HeaderText = "Response"
        Me.ResponseDataGridViewTextBoxColumn1.Name = "ResponseDataGridViewTextBoxColumn1"
        '
        'GenderDataGridViewTextBoxColumn1
        '
        Me.GenderDataGridViewTextBoxColumn1.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.Name = "GenderDataGridViewTextBoxColumn1"
        '
        'MEGenderDataGridViewTextBoxColumn1
        '
        Me.MEGenderDataGridViewTextBoxColumn1.DataPropertyName = "ME_Gender"
        Me.MEGenderDataGridViewTextBoxColumn1.HeaderText = "ME_Gender"
        Me.MEGenderDataGridViewTextBoxColumn1.Name = "MEGenderDataGridViewTextBoxColumn1"
        '
        'ResponseFemaleTBLBindingSource
        '
        Me.ResponseFemaleTBLBindingSource.DataMember = "responseFemale_TBL"
        Me.ResponseFemaleTBLBindingSource.DataSource = Me.CulturalPatientsDBDataSetResponse1BindingSource
        '
        'ResponseMale_TBLTableAdapter1
        '
        Me.ResponseMale_TBLTableAdapter1.ClearBeforeFill = True
        '
        'ResponseFemale_TBLTableAdapter1
        '
        Me.ResponseFemale_TBLTableAdapter1.ClearBeforeFill = True
        '
        'mainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 688)
        Me.Controls.Add(Me.female_DataGridView)
        Me.Controls.Add(Me.male_DataGridView)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxActiveHaptekX1)
        Me.Name = "mainInterface"
        Me.Text = "Virtual Human Behavior Toolkit"
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QuestionnaireFemaleTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulturalPatients_DBDataSetQuestion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionnaireMaleTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.male_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponseMaleTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulturalPatientsDBDataSetResponse1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulturalPatients_DBDataSetResponse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.female_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponseFemaleTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxActiveHaptekX1 As AxACTIVEHAPTEKXLib.AxActiveHaptekX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents back_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents query_Button As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents query_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents retrieveQuestion_Button As System.Windows.Forms.Button
    Friend WithEvents QuestionnaireFemale_TBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireFemale_TBLTableAdapter
    Friend WithEvents QuestionnaireMale_TBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetQuestionTableAdapters.questionnaireMale_TBLTableAdapter
    Friend WithEvents CulturalPatients_DBDataSetQuestion1 As Project_CulturalPatients.CulturalPatients_DBDataSetQuestion
    Friend WithEvents QuestionnaireMaleTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuestionnaireFemaleTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicalExaminer_DataTBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter
    Friend WithEvents ResponseMale_TBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetResponseTableAdapters.responseMale_TBLTableAdapter
    Friend WithEvents ResponseFemale_TBLTableAdapter1 As Project_CulturalPatients.CulturalPatients_DBDataSetResponseTableAdapters.responseFemale_TBLTableAdapter
    Friend WithEvents CulturalPatients_DBDataSetResponse1 As Project_CulturalPatients.CulturalPatients_DBDataSetResponse
    Friend WithEvents CulturalPatientsDBDataSetResponse1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents male_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEGenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponseMaleTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents female_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QNumDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponseDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEGenderDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponseFemaleTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents response_TextBox As System.Windows.Forms.TextBox
End Class
