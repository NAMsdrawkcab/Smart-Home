<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        picSmartHome = New PictureBox()
        lblHeading = New Label()
        cboMonth = New ComboBox()
        btnDisplay = New Button()
        lblMonth = New Label()
        lblMost = New Label()
        lblAverage = New Label()
        CType(picSmartHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picSmartHome
        ' 
        picSmartHome.Image = CType(resources.GetObject("picSmartHome.Image"), Image)
        picSmartHome.Location = New Point(0, 0)
        picSmartHome.Name = "picSmartHome"
        picSmartHome.Size = New Size(374, 262)
        picSmartHome.SizeMode = PictureBoxSizeMode.AutoSize
        picSmartHome.TabIndex = 0
        picSmartHome.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeading.Location = New Point(415, 45)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(298, 87)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Smart Home Electric Savings"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboMonth
        ' 
        cboMonth.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cboMonth.FormattingEnabled = True
        cboMonth.Location = New Point(454, 173)
        cboMonth.Name = "cboMonth"
        cboMonth.Size = New Size(224, 32)
        cboMonth.TabIndex = 2
        cboMonth.Text = "Select a Month"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.SteelBlue
        btnDisplay.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDisplay.ForeColor = SystemColors.Control
        btnDisplay.Location = New Point(251, 348)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(246, 45)
        btnDisplay.TabIndex = 3
        btnDisplay.Text = "Display Statistics"
        btnDisplay.UseVisualStyleBackColor = False
        ' 
        ' lblMonth
        ' 
        lblMonth.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblMonth.Location = New Point(12, 295)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(725, 39)
        lblMonth.TabIndex = 4
        lblMonth.Text = "The electric savings for XX is $X.XX"
        lblMonth.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMost
        ' 
        lblMost.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblMost.Location = New Point(12, 447)
        lblMost.Name = "lblMost"
        lblMost.Size = New Size(725, 38)
        lblMost.TabIndex = 5
        lblMost.Text = "XX had the most significant monthly savings"
        lblMost.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAverage
        ' 
        lblAverage.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblAverage.Location = New Point(12, 396)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(725, 42)
        lblAverage.TabIndex = 6
        lblAverage.Text = "The average monthly savings is $X.XX"
        lblAverage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(749, 501)
        Controls.Add(lblAverage)
        Controls.Add(lblMost)
        Controls.Add(lblMonth)
        Controls.Add(btnDisplay)
        Controls.Add(cboMonth)
        Controls.Add(lblHeading)
        Controls.Add(picSmartHome)
        Name = "Form1"
        Text = "Smart Home Application"
        CType(picSmartHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblMost As Label
    Friend WithEvents lblAverage As Label
End Class
