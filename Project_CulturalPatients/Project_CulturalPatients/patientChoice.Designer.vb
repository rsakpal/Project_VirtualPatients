<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patientChoice_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(patientChoice_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mexicanMale_Button = New System.Windows.Forms.Button()
        Me.indianMale_Button = New System.Windows.Forms.Button()
        Me.mexicanFem_Button = New System.Windows.Forms.Button()
        Me.indianFem_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.MedicalExaminerDataTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulturalPatients_DBDataSet = New Global.Project_CulturalPatients.CulturalPatients_DBDataSet()
        Me.MedicalExaminer_DataTBLTableAdapter = New Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter()
        Me.AgentSelection_TBLTableAdapter1 = New Global.Project_CulturalPatients.CulturalPatients_DBDataSet1TableAdapters.agentSelection_TBLTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.MedicalExaminerDataTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulturalPatients_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Virtual Human Behavior Toolkit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.mexicanMale_Button)
        Me.Panel1.Controls.Add(Me.indianMale_Button)
        Me.Panel1.Controls.Add(Me.mexicanFem_Button)
        Me.Panel1.Controls.Add(Me.indianFem_Button)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(38, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 465)
        Me.Panel1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mexican Male"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Indian Male"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mexican Female"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Indian Female"
        '
        'mexicanMale_Button
        '
        Me.mexicanMale_Button.Image = CType(resources.GetObject("mexicanMale_Button.Image"), System.Drawing.Image)
        Me.mexicanMale_Button.Location = New System.Drawing.Point(285, 258)
        Me.mexicanMale_Button.Name = "mexicanMale_Button"
        Me.mexicanMale_Button.Size = New System.Drawing.Size(181, 170)
        Me.mexicanMale_Button.TabIndex = 9
        Me.mexicanMale_Button.UseVisualStyleBackColor = True
        '
        'indianMale_Button
        '
        Me.indianMale_Button.Image = CType(resources.GetObject("indianMale_Button.Image"), System.Drawing.Image)
        Me.indianMale_Button.Location = New System.Drawing.Point(53, 258)
        Me.indianMale_Button.Name = "indianMale_Button"
        Me.indianMale_Button.Size = New System.Drawing.Size(181, 170)
        Me.indianMale_Button.TabIndex = 8
        Me.indianMale_Button.UseVisualStyleBackColor = True
        '
        'mexicanFem_Button
        '
        Me.mexicanFem_Button.Image = CType(resources.GetObject("mexicanFem_Button.Image"), System.Drawing.Image)
        Me.mexicanFem_Button.Location = New System.Drawing.Point(285, 50)
        Me.mexicanFem_Button.Name = "mexicanFem_Button"
        Me.mexicanFem_Button.Size = New System.Drawing.Size(181, 170)
        Me.mexicanFem_Button.TabIndex = 7
        Me.mexicanFem_Button.UseVisualStyleBackColor = True
        '
        'indianFem_Button
        '
        Me.indianFem_Button.Image = CType(resources.GetObject("indianFem_Button.Image"), System.Drawing.Image)
        Me.indianFem_Button.Location = New System.Drawing.Point(53, 50)
        Me.indianFem_Button.Name = "indianFem_Button"
        Me.indianFem_Button.Size = New System.Drawing.Size(181, 170)
        Me.indianFem_Button.TabIndex = 6
        Me.indianFem_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(424, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please choose an agent by clicking one of the image buttons."
        '
        'exit_Button
        '
        Me.exit_Button.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_Button.Location = New System.Drawing.Point(452, 554)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(100, 32)
        Me.exit_Button.TabIndex = 4
        Me.exit_Button.Text = "Exit"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'MedicalExaminerDataTBLBindingSource
        '
        Me.MedicalExaminerDataTBLBindingSource.DataMember = "MedicalExaminer_DataTBL"
        Me.MedicalExaminerDataTBLBindingSource.DataSource = Me.CulturalPatients_DBDataSet
        '
        'CulturalPatients_DBDataSet
        '
        Me.CulturalPatients_DBDataSet.DataSetName = "CulturalPatients_DBDataSet"
        Me.CulturalPatients_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '
        '
        Me.AgentSelection_TBLTableAdapter1.ClearBeforeFill = True
        '
        'patientChoice_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 598)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "patientChoice_form"
        Me.Text = "Virtual Human Behavior Toolkit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicalExaminerDataTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulturalPatients_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mexicanMale_Button As System.Windows.Forms.Button
    Friend WithEvents indianMale_Button As System.Windows.Forms.Button
    Friend WithEvents mexicanFem_Button As System.Windows.Forms.Button
    Friend WithEvents indianFem_Button As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CulturalPatients_DBDataSet As Global.Project_CulturalPatients.CulturalPatients_DBDataSet
    Friend WithEvents MedicalExaminerDataTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicalExaminer_DataTBLTableAdapter As Project_CulturalPatients.CulturalPatients_DBDataSetTableAdapters.MedicalExaminer_DataTBLTableAdapter
    Friend WithEvents AgentSelection_TBLTableAdapter1 As Global.Project_CulturalPatients.CulturalPatients_DBDataSet1TableAdapters.agentSelection_TBLTableAdapter
End Class
