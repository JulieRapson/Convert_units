<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlanPicture = New System.Windows.Forms.PictureBox()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtValueToConvert = New System.Windows.Forms.TextBox()
        Me.rdoInchtoMeter = New System.Windows.Forms.RadioButton()
        Me.rdoMeterToInch = New System.Windows.Forms.RadioButton()
        Me.grpBoxConvert = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        CType(Me.picPlanPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxConvert.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlanPicture
        '
        Me.picPlanPicture.Image = Global.MidtermProject.My.Resources.Resources.building
        Me.picPlanPicture.Location = New System.Drawing.Point(2, 1)
        Me.picPlanPicture.Name = "picPlanPicture"
        Me.picPlanPicture.Size = New System.Drawing.Size(324, 224)
        Me.picPlanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlanPicture.TabIndex = 0
        Me.picPlanPicture.TabStop = False
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTitle.Location = New System.Drawing.Point(384, 60)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(210, 33)
        Me.lblAppTitle.TabIndex = 1
        Me.lblAppTitle.Text = "Converter App"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(396, 134)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(187, 46)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'txtValueToConvert
        '
        Me.txtValueToConvert.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueToConvert.Location = New System.Drawing.Point(647, 150)
        Me.txtValueToConvert.MaximumSize = New System.Drawing.Size(100, 30)
        Me.txtValueToConvert.MinimumSize = New System.Drawing.Size(100, 30)
        Me.txtValueToConvert.Name = "txtValueToConvert"
        Me.txtValueToConvert.Size = New System.Drawing.Size(100, 30)
        Me.txtValueToConvert.TabIndex = 3
        '
        'rdoInchtoMeter
        '
        Me.rdoInchtoMeter.AutoSize = True
        Me.rdoInchtoMeter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInchtoMeter.Location = New System.Drawing.Point(50, 32)
        Me.rdoInchtoMeter.Name = "rdoInchtoMeter"
        Me.rdoInchtoMeter.Size = New System.Drawing.Size(163, 23)
        Me.rdoInchtoMeter.TabIndex = 4
        Me.rdoInchtoMeter.TabStop = True
        Me.rdoInchtoMeter.Text = "Inches to Meters"
        Me.rdoInchtoMeter.UseVisualStyleBackColor = True
        '
        'rdoMeterToInch
        '
        Me.rdoMeterToInch.AutoSize = True
        Me.rdoMeterToInch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMeterToInch.Location = New System.Drawing.Point(50, 61)
        Me.rdoMeterToInch.Name = "rdoMeterToInch"
        Me.rdoMeterToInch.Size = New System.Drawing.Size(163, 23)
        Me.rdoMeterToInch.TabIndex = 5
        Me.rdoMeterToInch.TabStop = True
        Me.rdoMeterToInch.Text = "Meters to Inches"
        Me.rdoMeterToInch.UseVisualStyleBackColor = True
        '
        'grpBoxConvert
        '
        Me.grpBoxConvert.BackColor = System.Drawing.Color.DimGray
        Me.grpBoxConvert.Controls.Add(Me.rdoInchtoMeter)
        Me.grpBoxConvert.Controls.Add(Me.rdoMeterToInch)
        Me.grpBoxConvert.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxConvert.ForeColor = System.Drawing.Color.White
        Me.grpBoxConvert.Location = New System.Drawing.Point(452, 218)
        Me.grpBoxConvert.Name = "grpBoxConvert"
        Me.grpBoxConvert.Size = New System.Drawing.Size(265, 106)
        Me.grpBoxConvert.TabIndex = 6
        Me.grpBoxConvert.TabStop = False
        Me.grpBoxConvert.Text = "Convert Measurement"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumPurple
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(57, 418)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(148, 35)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(333, 418)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(609, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(410, 360)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(73, 23)
        Me.lblResults.TabIndex = 10
        Me.lblResults.Text = "Label1"
        Me.lblResults.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(810, 494)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpBoxConvert)
        Me.Controls.Add(Me.txtValueToConvert)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblAppTitle)
        Me.Controls.Add(Me.picPlanPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.picPlanPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxConvert.ResumeLayout(False)
        Me.grpBoxConvert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlanPicture As PictureBox
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtValueToConvert As TextBox
    Friend WithEvents rdoInchtoMeter As RadioButton
    Friend WithEvents rdoMeterToInch As RadioButton
    Friend WithEvents grpBoxConvert As GroupBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResults As Label
End Class
