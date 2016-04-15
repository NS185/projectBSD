<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Utama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuControl = New System.Windows.Forms.TabControl()
        Me.TabMaster = New System.Windows.Forms.TabPage()
        Me.Master_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.M_BtnBarang = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_BtnPelanggan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_BtnSuplier = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_BtnUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_BtnMekanik = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_BtnKendaraan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Pembelian_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Penjualan_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MidPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tanggal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.Hari = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.Jam = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.MenuControl.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.Master_ToolStrip.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pembelian_ToolStrip.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Penjualan_ToolStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuControl)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'MenuControl
        '
        resources.ApplyResources(Me.MenuControl, "MenuControl")
        Me.MenuControl.Controls.Add(Me.TabMaster)
        Me.MenuControl.Controls.Add(Me.TabPage1)
        Me.MenuControl.Controls.Add(Me.TabPage2)
        Me.MenuControl.Controls.Add(Me.TabPage3)
        Me.MenuControl.Multiline = True
        Me.MenuControl.Name = "MenuControl"
        Me.MenuControl.SelectedIndex = 0
        Me.MenuControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'TabMaster
        '
        Me.TabMaster.BackColor = System.Drawing.SystemColors.Control
        Me.TabMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabMaster.Controls.Add(Me.Master_ToolStrip)
        resources.ApplyResources(Me.TabMaster, "TabMaster")
        Me.TabMaster.Name = "TabMaster"
        '
        'Master_ToolStrip
        '
        resources.ApplyResources(Me.Master_ToolStrip, "Master_ToolStrip")
        Me.Master_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Master_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_BtnBarang, Me.ToolStripSeparator9, Me.M_BtnPelanggan, Me.ToolStripSeparator6, Me.M_BtnSuplier, Me.ToolStripSeparator7, Me.M_BtnUser, Me.ToolStripSeparator5, Me.M_BtnMekanik, Me.ToolStripSeparator10, Me.M_BtnKendaraan, Me.ToolStripSeparator11})
        Me.Master_ToolStrip.Name = "Master_ToolStrip"
        Me.Master_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'M_BtnBarang
        '
        resources.ApplyResources(Me.M_BtnBarang, "M_BtnBarang")
        Me.M_BtnBarang.Name = "M_BtnBarang"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'M_BtnPelanggan
        '
        resources.ApplyResources(Me.M_BtnPelanggan, "M_BtnPelanggan")
        Me.M_BtnPelanggan.Name = "M_BtnPelanggan"
        Me.M_BtnPelanggan.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'M_BtnSuplier
        '
        resources.ApplyResources(Me.M_BtnSuplier, "M_BtnSuplier")
        Me.M_BtnSuplier.Name = "M_BtnSuplier"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'M_BtnUser
        '
        resources.ApplyResources(Me.M_BtnUser, "M_BtnUser")
        Me.M_BtnUser.Name = "M_BtnUser"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'M_BtnMekanik
        '
        resources.ApplyResources(Me.M_BtnMekanik, "M_BtnMekanik")
        Me.M_BtnMekanik.Name = "M_BtnMekanik"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'M_BtnKendaraan
        '
        resources.ApplyResources(Me.M_BtnKendaraan, "M_BtnKendaraan")
        Me.M_BtnKendaraan.Name = "M_BtnKendaraan"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Pembelian_ToolStrip)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Pembelian_ToolStrip
        '
        resources.ApplyResources(Me.Pembelian_ToolStrip, "Pembelian_ToolStrip")
        Me.Pembelian_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Pembelian_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4})
        Me.Pembelian_ToolStrip.Name = "Pembelian_ToolStrip"
        Me.Pembelian_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'ToolStripButton2
        '
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.Name = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ToolStripButton3
        '
        resources.ApplyResources(Me.ToolStripButton3, "ToolStripButton3")
        Me.ToolStripButton3.Name = "ToolStripButton3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ToolStripButton4
        '
        resources.ApplyResources(Me.ToolStripButton4, "ToolStripButton4")
        Me.ToolStripButton4.Name = "ToolStripButton4"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Penjualan_ToolStrip)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Penjualan_ToolStrip
        '
        resources.ApplyResources(Me.Penjualan_ToolStrip, "Penjualan_ToolStrip")
        Me.Penjualan_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Penjualan_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton12, Me.ToolStripSeparator14, Me.ToolStripButton13, Me.ToolStripSeparator15, Me.ToolStripButton14, Me.ToolStripSeparator16, Me.ToolStripButton15, Me.ToolStripSeparator17})
        Me.Penjualan_ToolStrip.Name = "Penjualan_ToolStrip"
        Me.Penjualan_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'ToolStripButton12
        '
        resources.ApplyResources(Me.ToolStripButton12, "ToolStripButton12")
        Me.ToolStripButton12.Name = "ToolStripButton12"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        resources.ApplyResources(Me.ToolStripSeparator14, "ToolStripSeparator14")
        '
        'ToolStripButton13
        '
        resources.ApplyResources(Me.ToolStripButton13, "ToolStripButton13")
        Me.ToolStripButton13.Name = "ToolStripButton13"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        resources.ApplyResources(Me.ToolStripSeparator15, "ToolStripSeparator15")
        '
        'ToolStripButton14
        '
        resources.ApplyResources(Me.ToolStripButton14, "ToolStripButton14")
        Me.ToolStripButton14.Name = "ToolStripButton14"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        resources.ApplyResources(Me.ToolStripSeparator16, "ToolStripSeparator16")
        '
        'ToolStripButton15
        '
        resources.ApplyResources(Me.ToolStripButton15, "ToolStripButton15")
        Me.ToolStripButton15.Name = "ToolStripButton15"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        resources.ApplyResources(Me.ToolStripSeparator17, "ToolStripSeparator17")
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MidPanel
        '
        resources.ApplyResources(Me.MidPanel, "MidPanel")
        Me.MidPanel.Name = "MidPanel"
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tanggal, Me.ToolStripSeparator20, Me.Hari, Me.ToolStripSeparator19, Me.Jam, Me.ToolStripLabel1})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'Tanggal
        '
        Me.Tanggal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tanggal.Name = "Tanggal"
        resources.ApplyResources(Me.Tanggal, "Tanggal")
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        resources.ApplyResources(Me.ToolStripSeparator20, "ToolStripSeparator20")
        '
        'Hari
        '
        Me.Hari.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Hari.Name = "Hari"
        resources.ApplyResources(Me.Hari, "Hari")
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        resources.ApplyResources(Me.ToolStripSeparator19, "ToolStripSeparator19")
        '
        'Jam
        '
        Me.Jam.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Jam.Name = "Jam"
        resources.ApplyResources(Me.Jam, "Jam")
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
        '
        'Frm_Utama
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MidPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.MenuControl.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabMaster.PerformLayout()
        Me.Master_ToolStrip.ResumeLayout(False)
        Me.Master_ToolStrip.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Pembelian_ToolStrip.ResumeLayout(False)
        Me.Pembelian_ToolStrip.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Penjualan_ToolStrip.ResumeLayout(False)
        Me.Penjualan_ToolStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuControl As System.Windows.Forms.TabControl
    Friend WithEvents TabMaster As System.Windows.Forms.TabPage
    Friend WithEvents Master_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents M_BtnBarang As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_BtnPelanggan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_BtnSuplier As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_BtnUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_BtnMekanik As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents M_BtnKendaraan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Penjualan_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MidPanel As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Jam As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Hari As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tanggal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Pembelian_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
