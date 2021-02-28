<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampusMusicCafe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampusMusicCafe))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picCafe = New System.Windows.Forms.PictureBox()
        Me.lvlAllWelcome = New System.Windows.Forms.Label()
        Me.btnClickDetails = New System.Windows.Forms.Button()
        Me.lblMoreDetails = New System.Windows.Forms.Label()
        CType(Me.picCafe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(198, 73)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(299, 72)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Campus Music Café" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Open Mic Night"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCafe
        '
        Me.picCafe.Image = CType(resources.GetObject("picCafe.Image"), System.Drawing.Image)
        Me.picCafe.Location = New System.Drawing.Point(198, 148)
        Me.picCafe.Name = "picCafe"
        Me.picCafe.Size = New System.Drawing.Size(300, 250)
        Me.picCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCafe.TabIndex = 1
        Me.picCafe.TabStop = False
        '
        'lvlAllWelcome
        '
        Me.lvlAllWelcome.AutoSize = True
        Me.lvlAllWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lvlAllWelcome.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvlAllWelcome.Location = New System.Drawing.Point(124, 401)
        Me.lvlAllWelcome.Name = "lvlAllWelcome"
        Me.lvlAllWelcome.Size = New System.Drawing.Size(451, 30)
        Me.lvlAllWelcome.TabIndex = 2
        Me.lvlAllWelcome.Text = "All College Students Are Welcome"
        Me.lvlAllWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClickDetails
        '
        Me.btnClickDetails.BackColor = System.Drawing.Color.Wheat
        Me.btnClickDetails.FlatAppearance.BorderSize = 0
        Me.btnClickDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClickDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClickDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClickDetails.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.btnClickDetails.Location = New System.Drawing.Point(243, 480)
        Me.btnClickDetails.Name = "btnClickDetails"
        Me.btnClickDetails.Size = New System.Drawing.Size(213, 62)
        Me.btnClickDetails.TabIndex = 3
        Me.btnClickDetails.Text = "For More Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click Here"
        Me.btnClickDetails.UseVisualStyleBackColor = False
        '
        'lblMoreDetails
        '
        Me.lblMoreDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoreDetails.AutoSize = True
        Me.lblMoreDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMoreDetails.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMoreDetails.Location = New System.Drawing.Point(94, 477)
        Me.lblMoreDetails.Name = "lblMoreDetails"
        Me.lblMoreDetails.Size = New System.Drawing.Size(511, 135)
        Me.lblMoreDetails.TabIndex = 4
        Me.lblMoreDetails.Text = "October 30, 2018" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Open ""Mic""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Time: 8:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "view t" &
    "he Campus Music Café's Facebook page."
        Me.lblMoreDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMoreDetails.Visible = False
        '
        'frmCampusMusicCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(714, 685)
        Me.Controls.Add(Me.lblMoreDetails)
        Me.Controls.Add(Me.btnClickDetails)
        Me.Controls.Add(Me.lvlAllWelcome)
        Me.Controls.Add(Me.picCafe)
        Me.Controls.Add(Me.lblHeading)
        Me.DoubleBuffered = True
        Me.Name = "frmCampusMusicCafe"
        Me.Text = "Henderson Ch2Asgmnt3 CampusMusicCafe"
        CType(Me.picCafe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picCafe As PictureBox
    Friend WithEvents lvlAllWelcome As Label
    Friend WithEvents btnClickDetails As Button
    Friend WithEvents lblMoreDetails As Label
End Class
