<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain2))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Title Translation")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item Translation")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Damage Parser")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("PSO2Proxy Plugin")
        Me.tmrWaitingforPSO2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LibDirChecker = New System.Windows.Forms.Timer(Me.components)
        Me.Main = New System.Windows.Forms.Panel()
        Me.versionLBL = New System.Windows.Forms.Label()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.website_btn = New System.Windows.Forms.Button()
        Me.Play_btn = New System.Windows.Forms.Button()
        Me.settings_btn = New System.Windows.Forms.Button()
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.defaults_btn = New System.Windows.Forms.Button()
        Me.saveSettings_btn = New System.Windows.Forms.Button()
        Me.txtHTML = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TextBoxX1 = New System.Windows.Forms.TextBox()
        Me.txtPSO2DefaultINI = New System.Windows.Forms.TextBox()
        Me.network_btn = New System.Windows.Forms.Button()
        Me.sound_btn = New System.Windows.Forms.Button()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.textures_btn = New System.Windows.Forms.Button()
        Me.screenSettings_btn = New System.Windows.Forms.Button()
        Me.language_btn = New System.Windows.Forms.Button()
        Me.Simple_btn = New System.Windows.Forms.Button()
        Me.return_btn = New System.Windows.Forms.Button()
        Me.simpleSettings_pnl = New System.Windows.Forms.Panel()
        Me.advanceMode_btn = New System.Windows.Forms.Button()
        Me.donationLiveOriginal = New System.Windows.Forms.Button()
        Me.arksDonation = New System.Windows.Forms.Button()
        Me.btnNewShit = New System.Windows.Forms.Button()
        Me.outputEnvironment_btn = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.readSettings_btn = New System.Windows.Forms.Button()
        Me.exportSettings_btn = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.simpleSettigns_tb = New System.Windows.Forms.TrackBar()
        Me.screen_pnl = New System.Windows.Forms.Panel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.fpsRate_cb = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.screenResolution_cb = New System.Windows.Forms.ComboBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.charSize_cb = New System.Windows.Forms.ComboBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.virtualFullscreen_rb = New System.Windows.Forms.RadioButton()
        Me.fullScreen_rb = New System.Windows.Forms.RadioButton()
        Me.windowed_rb = New System.Windows.Forms.RadioButton()
        Me.textures_pnl = New System.Windows.Forms.Panel()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.panel11 = New System.Windows.Forms.Panel()
        Me.HighShaders_rdb = New System.Windows.Forms.RadioButton()
        Me.sharderSimple_rb = New System.Windows.Forms.RadioButton()
        Me.shaderStandard_rb = New System.Windows.Forms.RadioButton()
        Me.label19 = New System.Windows.Forms.Label()
        Me.panel12 = New System.Windows.Forms.Panel()
        Me.compactRes_rb = New System.Windows.Forms.RadioButton()
        Me.standardRes_rb = New System.Windows.Forms.RadioButton()
        Me.highResTextures_rb = New System.Windows.Forms.RadioButton()
        Me.sound_pnl = New System.Windows.Forms.Panel()
        Me.panel15 = New System.Windows.Forms.Panel()
        Me.label28 = New System.Windows.Forms.Label()
        Me.panel14 = New System.Windows.Forms.Panel()
        Me.surroundOFF_rb = New System.Windows.Forms.RadioButton()
        Me.surroundON_rb = New System.Windows.Forms.RadioButton()
        Me.label24 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.vidVol_lbl = New System.Windows.Forms.Label()
        Me.vidVol_tb = New System.Windows.Forms.TrackBar()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.seVol_lbl = New System.Windows.Forms.Label()
        Me.seVol_tb = New System.Windows.Forms.TrackBar()
        Me.panel13 = New System.Windows.Forms.Panel()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.voiceVol_lbl = New System.Windows.Forms.Label()
        Me.voiceVol_tb = New System.Windows.Forms.TrackBar()
        Me.panel10 = New System.Windows.Forms.Panel()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.bgmVol_lbl = New System.Windows.Forms.Label()
        Me.bgmVol_trkb = New System.Windows.Forms.TrackBar()
        Me.network_pnl = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnENPatch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnInstallPSO2 = New System.Windows.Forms.Button()
        Me.btnTerminate = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.enableSteam_cbx = New System.Windows.Forms.CheckBox()
        Me.btnResetTweaker = New System.Windows.Forms.Button()
        Me.rtbDebug = New System.Windows.Forms.TextBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.panel22 = New System.Windows.Forms.Panel()
        Me.chkConnection_btn = New System.Windows.Forms.Button()
        Me.ieSettings_btn = New System.Windows.Forms.Button()
        Me.language_pnl = New System.Windows.Forms.Panel()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.savePlugins = New System.Windows.Forms.Button()
        Me.btnConfigure = New System.Windows.Forms.Button()
        Me.lblPluginInfo = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ListViewEx1 = New System.Windows.Forms.ListView()
        Me.btnLargeFilesTRANSAM = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.language_cb = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.disableVideos_rb = New System.Windows.Forms.RadioButton()
        Me.enableVideos_rb = New System.Windows.Forms.RadioButton()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.Main.SuspendLayout()
        Me.settingsPanel.SuspendLayout()
        Me.simpleSettings_pnl.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.simpleSettigns_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.screen_pnl.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.textures_pnl.SuspendLayout()
        Me.panel11.SuspendLayout()
        Me.panel12.SuspendLayout()
        Me.sound_pnl.SuspendLayout()
        Me.panel14.SuspendLayout()
        Me.panel9.SuspendLayout()
        CType(Me.vidVol_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        CType(Me.seVol_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel13.SuspendLayout()
        CType(Me.voiceVol_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel10.SuspendLayout()
        CType(Me.bgmVol_trkb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.network_pnl.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.panel22.SuspendLayout()
        Me.language_pnl.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrWaitingforPSO2
        '
        Me.tmrWaitingforPSO2.Interval = 10000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LibDirChecker
        '
        Me.LibDirChecker.Enabled = True
        Me.LibDirChecker.Interval = 500
        '
        'Main
        '
        Me.Main.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._131__Japanese__Japan__
        Me.Main.Controls.Add(Me.versionLBL)
        Me.Main.Controls.Add(Me.lblDirectory)
        Me.Main.Controls.Add(Me.webBrowser1)
        Me.Main.Controls.Add(Me.website_btn)
        Me.Main.Controls.Add(Me.Play_btn)
        Me.Main.Controls.Add(Me.settings_btn)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(745, 720)
        Me.Main.TabIndex = 9
        '
        'versionLBL
        '
        Me.versionLBL.AutoSize = True
        Me.versionLBL.BackColor = System.Drawing.Color.Black
        Me.versionLBL.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.versionLBL.Location = New System.Drawing.Point(12, 699)
        Me.versionLBL.Name = "versionLBL"
        Me.versionLBL.Size = New System.Drawing.Size(82, 13)
        Me.versionLBL.TabIndex = 8
        Me.versionLBL.Text = "Version Number"
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.BackColor = System.Drawing.Color.Black
        Me.lblDirectory.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblDirectory.Location = New System.Drawing.Point(12, 185)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(29, 13)
        Me.lblDirectory.TabIndex = 6
        Me.lblDirectory.Text = "Path"
        Me.lblDirectory.Visible = False
        '
        'webBrowser1
        '
        Me.webBrowser1.AllowNavigation = False
        Me.webBrowser1.AllowWebBrowserDrop = False
        Me.webBrowser1.Location = New System.Drawing.Point(10, 244)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.ScrollBarsEnabled = False
        Me.webBrowser1.Size = New System.Drawing.Size(725, 445)
        Me.webBrowser1.TabIndex = 5
        Me.webBrowser1.Url = New System.Uri("http://162.206.115.127:64080/launcher.pso2.htm", System.UriKind.Absolute)
        Me.webBrowser1.WebBrowserShortcutsEnabled = False
        '
        'website_btn
        '
        Me.website_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._169EN
        Me.website_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.website_btn.FlatAppearance.BorderSize = 0
        Me.website_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.website_btn.Location = New System.Drawing.Point(461, 185)
        Me.website_btn.Name = "website_btn"
        Me.website_btn.Size = New System.Drawing.Size(280, 43)
        Me.website_btn.TabIndex = 3
        Me.website_btn.UseVisualStyleBackColor = True
        '
        'Play_btn
        '
        Me.Play_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._172EN
        Me.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Play_btn.FlatAppearance.BorderSize = 0
        Me.Play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play_btn.Location = New System.Drawing.Point(461, 29)
        Me.Play_btn.Name = "Play_btn"
        Me.Play_btn.Size = New System.Drawing.Size(280, 113)
        Me.Play_btn.TabIndex = 1
        Me.Play_btn.UseVisualStyleBackColor = True
        '
        'settings_btn
        '
        Me.settings_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._166EN
        Me.settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.settings_btn.FlatAppearance.BorderSize = 0
        Me.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_btn.Location = New System.Drawing.Point(461, 142)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Size = New System.Drawing.Size(280, 43)
        Me.settings_btn.TabIndex = 2
        Me.settings_btn.UseVisualStyleBackColor = True
        '
        'settingsPanel
        '
        Me.settingsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.settingsPanel.BackgroundImage = CType(resources.GetObject("settingsPanel.BackgroundImage"), System.Drawing.Image)
        Me.settingsPanel.Controls.Add(Me.defaults_btn)
        Me.settingsPanel.Controls.Add(Me.saveSettings_btn)
        Me.settingsPanel.Controls.Add(Me.txtHTML)
        Me.settingsPanel.Controls.Add(Me.lblStatus)
        Me.settingsPanel.Controls.Add(Me.TextBoxX1)
        Me.settingsPanel.Controls.Add(Me.txtPSO2DefaultINI)
        Me.settingsPanel.Controls.Add(Me.network_btn)
        Me.settingsPanel.Controls.Add(Me.sound_btn)
        Me.settingsPanel.Controls.Add(Me.CheckBoxX1)
        Me.settingsPanel.Controls.Add(Me.textures_btn)
        Me.settingsPanel.Controls.Add(Me.screenSettings_btn)
        Me.settingsPanel.Controls.Add(Me.language_btn)
        Me.settingsPanel.Controls.Add(Me.Simple_btn)
        Me.settingsPanel.Controls.Add(Me.return_btn)
        Me.settingsPanel.Controls.Add(Me.simpleSettings_pnl)
        Me.settingsPanel.Controls.Add(Me.screen_pnl)
        Me.settingsPanel.Controls.Add(Me.textures_pnl)
        Me.settingsPanel.Controls.Add(Me.sound_pnl)
        Me.settingsPanel.Controls.Add(Me.network_pnl)
        Me.settingsPanel.Controls.Add(Me.language_pnl)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(745, 720)
        Me.settingsPanel.TabIndex = 10
        Me.settingsPanel.Visible = False
        '
        'defaults_btn
        '
        Me.defaults_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._139EN
        Me.defaults_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.defaults_btn.FlatAppearance.BorderSize = 0
        Me.defaults_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.defaults_btn.Location = New System.Drawing.Point(260, 646)
        Me.defaults_btn.MinimumSize = New System.Drawing.Size(150, 26)
        Me.defaults_btn.Name = "defaults_btn"
        Me.defaults_btn.Size = New System.Drawing.Size(222, 34)
        Me.defaults_btn.TabIndex = 2
        Me.defaults_btn.UseVisualStyleBackColor = True
        '
        'saveSettings_btn
        '
        Me.saveSettings_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._142EN
        Me.saveSettings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.saveSettings_btn.FlatAppearance.BorderSize = 0
        Me.saveSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveSettings_btn.Location = New System.Drawing.Point(29, 646)
        Me.saveSettings_btn.MinimumSize = New System.Drawing.Size(150, 26)
        Me.saveSettings_btn.Name = "saveSettings_btn"
        Me.saveSettings_btn.Size = New System.Drawing.Size(223, 34)
        Me.saveSettings_btn.TabIndex = 1
        Me.saveSettings_btn.UseVisualStyleBackColor = True
        '
        'txtHTML
        '
        Me.txtHTML.Location = New System.Drawing.Point(222, 10)
        Me.txtHTML.Name = "txtHTML"
        Me.txtHTML.Size = New System.Drawing.Size(100, 20)
        Me.txtHTML.TabIndex = 10
        Me.txtHTML.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Black
        Me.lblStatus.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblStatus.Location = New System.Drawing.Point(11, 699)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 13)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "Information"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.Location = New System.Drawing.Point(119, 10)
        Me.TextBoxX1.Multiline = True
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX1.TabIndex = 8
        Me.TextBoxX1.Visible = False
        '
        'txtPSO2DefaultINI
        '
        Me.txtPSO2DefaultINI.Location = New System.Drawing.Point(10, 9)
        Me.txtPSO2DefaultINI.Multiline = True
        Me.txtPSO2DefaultINI.Name = "txtPSO2DefaultINI"
        Me.txtPSO2DefaultINI.Size = New System.Drawing.Size(100, 20)
        Me.txtPSO2DefaultINI.TabIndex = 9
        Me.txtPSO2DefaultINI.Visible = False
        '
        'network_btn
        '
        Me.network_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.network_btn.Enabled = False
        Me.network_btn.FlatAppearance.BorderSize = 0
        Me.network_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.network_btn.Location = New System.Drawing.Point(562, 99)
        Me.network_btn.Name = "network_btn"
        Me.network_btn.Size = New System.Drawing.Size(132, 43)
        Me.network_btn.TabIndex = 10
        Me.network_btn.UseVisualStyleBackColor = True
        Me.network_btn.Visible = False
        '
        'sound_btn
        '
        Me.sound_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._163EN
        Me.sound_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sound_btn.FlatAppearance.BorderSize = 0
        Me.sound_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sound_btn.Location = New System.Drawing.Point(582, 254)
        Me.sound_btn.Name = "sound_btn"
        Me.sound_btn.Size = New System.Drawing.Size(132, 43)
        Me.sound_btn.TabIndex = 9
        Me.sound_btn.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(513, 12)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxX1.TabIndex = 7
        Me.CheckBoxX1.Text = "CheckBox1"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        Me.CheckBoxX1.Visible = False
        '
        'textures_btn
        '
        Me.textures_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._151EN
        Me.textures_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.textures_btn.FlatAppearance.BorderSize = 0
        Me.textures_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.textures_btn.Location = New System.Drawing.Point(444, 254)
        Me.textures_btn.Name = "textures_btn"
        Me.textures_btn.Size = New System.Drawing.Size(132, 43)
        Me.textures_btn.TabIndex = 8
        Me.textures_btn.UseVisualStyleBackColor = True
        '
        'screenSettings_btn
        '
        Me.screenSettings_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._157EN
        Me.screenSettings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.screenSettings_btn.FlatAppearance.BorderSize = 0
        Me.screenSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.screenSettings_btn.Location = New System.Drawing.Point(305, 254)
        Me.screenSettings_btn.Name = "screenSettings_btn"
        Me.screenSettings_btn.Size = New System.Drawing.Size(132, 43)
        Me.screenSettings_btn.TabIndex = 7
        Me.screenSettings_btn.UseVisualStyleBackColor = True
        '
        'language_btn
        '
        Me.language_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._148EN
        Me.language_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.language_btn.FlatAppearance.BorderSize = 0
        Me.language_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.language_btn.Location = New System.Drawing.Point(166, 254)
        Me.language_btn.Name = "language_btn"
        Me.language_btn.Size = New System.Drawing.Size(132, 43)
        Me.language_btn.TabIndex = 6
        Me.language_btn.UseVisualStyleBackColor = True
        '
        'Simple_btn
        '
        Me.Simple_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._158EN
        Me.Simple_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Simple_btn.Enabled = False
        Me.Simple_btn.FlatAppearance.BorderSize = 0
        Me.Simple_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Simple_btn.Location = New System.Drawing.Point(27, 254)
        Me.Simple_btn.Name = "Simple_btn"
        Me.Simple_btn.Size = New System.Drawing.Size(132, 43)
        Me.Simple_btn.TabIndex = 5
        Me.Simple_btn.UseVisualStyleBackColor = True
        '
        'return_btn
        '
        Me.return_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._136EN
        Me.return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.return_btn.FlatAppearance.BorderSize = 0
        Me.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.return_btn.Location = New System.Drawing.Point(489, 646)
        Me.return_btn.MinimumSize = New System.Drawing.Size(150, 26)
        Me.return_btn.Name = "return_btn"
        Me.return_btn.Size = New System.Drawing.Size(223, 34)
        Me.return_btn.TabIndex = 4
        Me.return_btn.UseVisualStyleBackColor = True
        '
        'simpleSettings_pnl
        '
        Me.simpleSettings_pnl.AutoScroll = True
        Me.simpleSettings_pnl.BackColor = System.Drawing.SystemColors.Control
        Me.simpleSettings_pnl.Controls.Add(Me.advanceMode_btn)
        Me.simpleSettings_pnl.Controls.Add(Me.donationLiveOriginal)
        Me.simpleSettings_pnl.Controls.Add(Me.arksDonation)
        Me.simpleSettings_pnl.Controls.Add(Me.btnNewShit)
        Me.simpleSettings_pnl.Controls.Add(Me.outputEnvironment_btn)
        Me.simpleSettings_pnl.Controls.Add(Me.label5)
        Me.simpleSettings_pnl.Controls.Add(Me.label3)
        Me.simpleSettings_pnl.Controls.Add(Me.panel3)
        Me.simpleSettings_pnl.Controls.Add(Me.panel2)
        Me.simpleSettings_pnl.Location = New System.Drawing.Point(42, 310)
        Me.simpleSettings_pnl.Name = "simpleSettings_pnl"
        Me.simpleSettings_pnl.Size = New System.Drawing.Size(652, 314)
        Me.simpleSettings_pnl.TabIndex = 0
        '
        'advanceMode_btn
        '
        Me.advanceMode_btn.Location = New System.Drawing.Point(18, 286)
        Me.advanceMode_btn.Name = "advanceMode_btn"
        Me.advanceMode_btn.Size = New System.Drawing.Size(146, 23)
        Me.advanceMode_btn.TabIndex = 18
        Me.advanceMode_btn.Text = "Advance Settings"
        Me.advanceMode_btn.UseVisualStyleBackColor = True
        '
        'donationLiveOriginal
        '
        Me.donationLiveOriginal.Location = New System.Drawing.Point(502, 286)
        Me.donationLiveOriginal.Name = "donationLiveOriginal"
        Me.donationLiveOriginal.Size = New System.Drawing.Size(147, 23)
        Me.donationLiveOriginal.TabIndex = 17
        Me.donationLiveOriginal.Text = "Help support Live Original"
        Me.donationLiveOriginal.UseVisualStyleBackColor = True
        '
        'arksDonation
        '
        Me.arksDonation.Location = New System.Drawing.Point(514, 257)
        Me.arksDonation.Name = "arksDonation"
        Me.arksDonation.Size = New System.Drawing.Size(135, 23)
        Me.arksDonation.TabIndex = 16
        Me.arksDonation.Text = "Help support Arks Layer"
        Me.arksDonation.UseVisualStyleBackColor = True
        '
        'btnNewShit
        '
        Me.btnNewShit.Enabled = False
        Me.btnNewShit.Location = New System.Drawing.Point(198, 224)
        Me.btnNewShit.Name = "btnNewShit"
        Me.btnNewShit.Size = New System.Drawing.Size(186, 23)
        Me.btnNewShit.TabIndex = 11
        Me.btnNewShit.Text = "Update PSO2"
        Me.btnNewShit.UseVisualStyleBackColor = True
        Me.btnNewShit.Visible = False
        '
        'outputEnvironment_btn
        '
        Me.outputEnvironment_btn.Enabled = False
        Me.outputEnvironment_btn.Location = New System.Drawing.Point(28, 224)
        Me.outputEnvironment_btn.Name = "outputEnvironment_btn"
        Me.outputEnvironment_btn.Size = New System.Drawing.Size(156, 23)
        Me.outputEnvironment_btn.TabIndex = 4
        Me.outputEnvironment_btn.Text = "Output file environmental information"
        Me.outputEnvironment_btn.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(25, 130)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(105, 13)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Read / write settings"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 12)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(121, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Simple Drawing Settings"
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.label7)
        Me.panel3.Controls.Add(Me.label6)
        Me.panel3.Controls.Add(Me.readSettings_btn)
        Me.panel3.Controls.Add(Me.exportSettings_btn)
        Me.panel3.Location = New System.Drawing.Point(18, 136)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(456, 80)
        Me.panel3.TabIndex = 5
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(181, 52)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(139, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Load the saved settings file."
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(181, 23)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(206, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Save the text file the contents of a setting."
        '
        'readSettings_btn
        '
        Me.readSettings_btn.Enabled = False
        Me.readSettings_btn.Location = New System.Drawing.Point(9, 47)
        Me.readSettings_btn.Name = "readSettings_btn"
        Me.readSettings_btn.Size = New System.Drawing.Size(156, 23)
        Me.readSettings_btn.TabIndex = 1
        Me.readSettings_btn.Text = "Read Settings"
        Me.readSettings_btn.UseVisualStyleBackColor = True
        '
        'exportSettings_btn
        '
        Me.exportSettings_btn.Enabled = False
        Me.exportSettings_btn.Location = New System.Drawing.Point(9, 18)
        Me.exportSettings_btn.Name = "exportSettings_btn"
        Me.exportSettings_btn.Size = New System.Drawing.Size(156, 23)
        Me.exportSettings_btn.TabIndex = 0
        Me.exportSettings_btn.Text = "Export Settings"
        Me.exportSettings_btn.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Controls.Add(Me.simpleSettigns_tb)
        Me.panel2.Location = New System.Drawing.Point(18, 18)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(456, 110)
        Me.panel2.TabIndex = 1
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 63)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(443, 39)
        Me.label4.TabIndex = 4
        Me.label4.Text = resources.GetString("label4.Text")
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(392, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(13, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "6"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(13, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "1"
        '
        'simpleSettigns_tb
        '
        Me.simpleSettigns_tb.LargeChange = 1
        Me.simpleSettigns_tb.Location = New System.Drawing.Point(32, 13)
        Me.simpleSettigns_tb.Maximum = 6
        Me.simpleSettigns_tb.Minimum = 1
        Me.simpleSettigns_tb.Name = "simpleSettigns_tb"
        Me.simpleSettigns_tb.Size = New System.Drawing.Size(354, 45)
        Me.simpleSettigns_tb.TabIndex = 0
        Me.simpleSettigns_tb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.simpleSettigns_tb.Value = 3
        '
        'screen_pnl
        '
        Me.screen_pnl.AutoScroll = True
        Me.screen_pnl.Controls.Add(Me.label14)
        Me.screen_pnl.Controls.Add(Me.panel7)
        Me.screen_pnl.Controls.Add(Me.label13)
        Me.screen_pnl.Controls.Add(Me.panel6)
        Me.screen_pnl.Controls.Add(Me.label12)
        Me.screen_pnl.Controls.Add(Me.panel1)
        Me.screen_pnl.Controls.Add(Me.label11)
        Me.screen_pnl.Controls.Add(Me.panel5)
        Me.screen_pnl.Location = New System.Drawing.Point(42, 310)
        Me.screen_pnl.Name = "screen_pnl"
        Me.screen_pnl.Size = New System.Drawing.Size(652, 314)
        Me.screen_pnl.TabIndex = 9
        Me.screen_pnl.Visible = False
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(17, 204)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(101, 13)
        Me.label14.TabIndex = 14
        Me.label14.Text = "Maximum frame rate"
        '
        'panel7
        '
        Me.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel7.Controls.Add(Me.fpsRate_cb)
        Me.panel7.Location = New System.Drawing.Point(11, 210)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(203, 52)
        Me.panel7.TabIndex = 13
        '
        'fpsRate_cb
        '
        Me.fpsRate_cb.FormattingEnabled = True
        Me.fpsRate_cb.Items.AddRange(New Object() {"30fps", "60fps", "90fps", "120fps", "Unlimited"})
        Me.fpsRate_cb.Location = New System.Drawing.Point(8, 16)
        Me.fpsRate_cb.Name = "fpsRate_cb"
        Me.fpsRate_cb.Size = New System.Drawing.Size(179, 21)
        Me.fpsRate_cb.TabIndex = 9
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(17, 136)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(62, 13)
        Me.label13.TabIndex = 12
        Me.label13.Text = "Screen size"
        '
        'panel6
        '
        Me.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel6.Controls.Add(Me.screenResolution_cb)
        Me.panel6.Location = New System.Drawing.Point(11, 142)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(203, 52)
        Me.panel6.TabIndex = 11
        '
        'screenResolution_cb
        '
        Me.screenResolution_cb.FormattingEnabled = True
        Me.screenResolution_cb.Location = New System.Drawing.Point(8, 16)
        Me.screenResolution_cb.Name = "screenResolution_cb"
        Me.screenResolution_cb.Size = New System.Drawing.Size(179, 21)
        Me.screenResolution_cb.TabIndex = 9
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(227, 12)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(125, 13)
        Me.label12.TabIndex = 10
        Me.label12.Text = "The size of the character"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.charSize_cb)
        Me.panel1.Controls.Add(Me.label10)
        Me.panel1.Location = New System.Drawing.Point(221, 18)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(240, 126)
        Me.panel1.TabIndex = 9
        '
        'charSize_cb
        '
        Me.charSize_cb.FormattingEnabled = True
        Me.charSize_cb.Items.AddRange(New Object() {"Standard (equivilant to 1,280 horizontal and 720 vertical)", "1.25 times (equivalent to 1,600 horizontal and 900 vertical)", "1.5 times (equivalent to 1,920 horizontal and 1,080 vertical)"})
        Me.charSize_cb.Location = New System.Drawing.Point(11, 13)
        Me.charSize_cb.Name = "charSize_cb"
        Me.charSize_cb.Size = New System.Drawing.Size(173, 21)
        Me.charSize_cb.TabIndex = 7
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(8, 47)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(215, 65)
        Me.label10.TabIndex = 8
        Me.label10.Text = resources.GetString("label10.Text")
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(17, 12)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(75, 13)
        Me.label11.TabIndex = 6
        Me.label11.Text = "Window mode"
        '
        'panel5
        '
        Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel5.Controls.Add(Me.virtualFullscreen_rb)
        Me.panel5.Controls.Add(Me.fullScreen_rb)
        Me.panel5.Controls.Add(Me.windowed_rb)
        Me.panel5.Location = New System.Drawing.Point(11, 18)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(203, 110)
        Me.panel5.TabIndex = 5
        '
        'virtualFullscreen_rb
        '
        Me.virtualFullscreen_rb.AutoSize = True
        Me.virtualFullscreen_rb.Location = New System.Drawing.Point(12, 77)
        Me.virtualFullscreen_rb.Name = "virtualFullscreen_rb"
        Me.virtualFullscreen_rb.Size = New System.Drawing.Size(140, 17)
        Me.virtualFullscreen_rb.TabIndex = 6
        Me.virtualFullscreen_rb.Text = "Virtual full-screen display"
        Me.virtualFullscreen_rb.UseVisualStyleBackColor = True
        '
        'fullScreen_rb
        '
        Me.fullScreen_rb.AutoSize = True
        Me.fullScreen_rb.Location = New System.Drawing.Point(12, 46)
        Me.fullScreen_rb.Name = "fullScreen_rb"
        Me.fullScreen_rb.Size = New System.Drawing.Size(111, 17)
        Me.fullScreen_rb.TabIndex = 5
        Me.fullScreen_rb.Text = "Full-screen display"
        Me.fullScreen_rb.UseVisualStyleBackColor = True
        '
        'windowed_rb
        '
        Me.windowed_rb.AutoSize = True
        Me.windowed_rb.Checked = True
        Me.windowed_rb.Location = New System.Drawing.Point(12, 15)
        Me.windowed_rb.Name = "windowed_rb"
        Me.windowed_rb.Size = New System.Drawing.Size(128, 17)
        Me.windowed_rb.TabIndex = 4
        Me.windowed_rb.TabStop = True
        Me.windowed_rb.Text = "Window display mode"
        Me.windowed_rb.UseVisualStyleBackColor = True
        '
        'textures_pnl
        '
        Me.textures_pnl.AutoScroll = True
        Me.textures_pnl.Controls.Add(Me.label17)
        Me.textures_pnl.Controls.Add(Me.label18)
        Me.textures_pnl.Controls.Add(Me.panel11)
        Me.textures_pnl.Controls.Add(Me.label19)
        Me.textures_pnl.Controls.Add(Me.panel12)
        Me.textures_pnl.Location = New System.Drawing.Point(42, 310)
        Me.textures_pnl.Name = "textures_pnl"
        Me.textures_pnl.Size = New System.Drawing.Size(652, 314)
        Me.textures_pnl.TabIndex = 15
        Me.textures_pnl.Visible = False
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(179, 12)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(74, 13)
        Me.label17.TabIndex = 10
        Me.label17.Text = "Shader quality"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(327, 19)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(245, 65)
        Me.label18.TabIndex = 8
        Me.label18.Text = resources.GetString("label18.Text")
        '
        'panel11
        '
        Me.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel11.Controls.Add(Me.HighShaders_rdb)
        Me.panel11.Controls.Add(Me.sharderSimple_rb)
        Me.panel11.Controls.Add(Me.shaderStandard_rb)
        Me.panel11.Location = New System.Drawing.Point(173, 18)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(148, 110)
        Me.panel11.TabIndex = 9
        '
        'HighShaders_rdb
        '
        Me.HighShaders_rdb.AutoSize = True
        Me.HighShaders_rdb.Location = New System.Drawing.Point(14, 15)
        Me.HighShaders_rdb.Name = "HighShaders_rdb"
        Me.HighShaders_rdb.Size = New System.Drawing.Size(47, 17)
        Me.HighShaders_rdb.TabIndex = 8
        Me.HighShaders_rdb.Text = "High"
        Me.HighShaders_rdb.UseVisualStyleBackColor = True
        '
        'sharderSimple_rb
        '
        Me.sharderSimple_rb.AutoSize = True
        Me.sharderSimple_rb.Checked = True
        Me.sharderSimple_rb.Location = New System.Drawing.Point(14, 77)
        Me.sharderSimple_rb.Name = "sharderSimple_rb"
        Me.sharderSimple_rb.Size = New System.Drawing.Size(45, 17)
        Me.sharderSimple_rb.TabIndex = 7
        Me.sharderSimple_rb.TabStop = True
        Me.sharderSimple_rb.Text = "Low"
        Me.sharderSimple_rb.UseVisualStyleBackColor = True
        '
        'shaderStandard_rb
        '
        Me.shaderStandard_rb.AutoSize = True
        Me.shaderStandard_rb.Location = New System.Drawing.Point(14, 46)
        Me.shaderStandard_rb.Name = "shaderStandard_rb"
        Me.shaderStandard_rb.Size = New System.Drawing.Size(62, 17)
        Me.shaderStandard_rb.TabIndex = 6
        Me.shaderStandard_rb.Text = "Medium"
        Me.shaderStandard_rb.UseVisualStyleBackColor = True
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(17, 12)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(91, 13)
        Me.label19.TabIndex = 6
        Me.label19.Text = "Texture resolution"
        '
        'panel12
        '
        Me.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel12.Controls.Add(Me.compactRes_rb)
        Me.panel12.Controls.Add(Me.standardRes_rb)
        Me.panel12.Controls.Add(Me.highResTextures_rb)
        Me.panel12.Location = New System.Drawing.Point(11, 18)
        Me.panel12.Name = "panel12"
        Me.panel12.Size = New System.Drawing.Size(153, 110)
        Me.panel12.TabIndex = 5
        '
        'compactRes_rb
        '
        Me.compactRes_rb.AutoSize = True
        Me.compactRes_rb.Checked = True
        Me.compactRes_rb.Location = New System.Drawing.Point(12, 77)
        Me.compactRes_rb.Name = "compactRes_rb"
        Me.compactRes_rb.Size = New System.Drawing.Size(115, 17)
        Me.compactRes_rb.TabIndex = 6
        Me.compactRes_rb.TabStop = True
        Me.compactRes_rb.Text = "Compact resolution"
        Me.compactRes_rb.UseVisualStyleBackColor = True
        '
        'standardRes_rb
        '
        Me.standardRes_rb.AutoSize = True
        Me.standardRes_rb.Location = New System.Drawing.Point(12, 46)
        Me.standardRes_rb.Name = "standardRes_rb"
        Me.standardRes_rb.Size = New System.Drawing.Size(116, 17)
        Me.standardRes_rb.TabIndex = 5
        Me.standardRes_rb.Text = "Standard resolution"
        Me.standardRes_rb.UseVisualStyleBackColor = True
        '
        'highResTextures_rb
        '
        Me.highResTextures_rb.AutoSize = True
        Me.highResTextures_rb.Location = New System.Drawing.Point(12, 15)
        Me.highResTextures_rb.Name = "highResTextures_rb"
        Me.highResTextures_rb.Size = New System.Drawing.Size(95, 17)
        Me.highResTextures_rb.TabIndex = 4
        Me.highResTextures_rb.Text = "High resolution"
        Me.highResTextures_rb.UseVisualStyleBackColor = True
        '
        'sound_pnl
        '
        Me.sound_pnl.AutoScroll = True
        Me.sound_pnl.Controls.Add(Me.panel15)
        Me.sound_pnl.Controls.Add(Me.label28)
        Me.sound_pnl.Controls.Add(Me.panel14)
        Me.sound_pnl.Controls.Add(Me.label24)
        Me.sound_pnl.Controls.Add(Me.label21)
        Me.sound_pnl.Controls.Add(Me.label25)
        Me.sound_pnl.Controls.Add(Me.label20)
        Me.sound_pnl.Controls.Add(Me.panel9)
        Me.sound_pnl.Controls.Add(Me.panel8)
        Me.sound_pnl.Controls.Add(Me.panel13)
        Me.sound_pnl.Controls.Add(Me.panel10)
        Me.sound_pnl.Location = New System.Drawing.Point(42, 310)
        Me.sound_pnl.Name = "sound_pnl"
        Me.sound_pnl.Size = New System.Drawing.Size(652, 314)
        Me.sound_pnl.TabIndex = 16
        Me.sound_pnl.Visible = False
        '
        'panel15
        '
        Me.panel15.Location = New System.Drawing.Point(159, 406)
        Me.panel15.Name = "panel15"
        Me.panel15.Size = New System.Drawing.Size(141, 61)
        Me.panel15.TabIndex = 17
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(17, 324)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(84, 13)
        Me.label28.TabIndex = 17
        Me.label28.Text = "Surround setting"
        '
        'panel14
        '
        Me.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel14.Controls.Add(Me.surroundOFF_rb)
        Me.panel14.Controls.Add(Me.surroundON_rb)
        Me.panel14.Location = New System.Drawing.Point(11, 330)
        Me.panel14.Name = "panel14"
        Me.panel14.Size = New System.Drawing.Size(141, 73)
        Me.panel14.TabIndex = 16
        '
        'surroundOFF_rb
        '
        Me.surroundOFF_rb.AutoSize = True
        Me.surroundOFF_rb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.surroundOFF_rb.Location = New System.Drawing.Point(19, 43)
        Me.surroundOFF_rb.Name = "surroundOFF_rb"
        Me.surroundOFF_rb.Size = New System.Drawing.Size(45, 17)
        Me.surroundOFF_rb.TabIndex = 1
        Me.surroundOFF_rb.Text = "OFF"
        Me.surroundOFF_rb.UseVisualStyleBackColor = True
        '
        'surroundON_rb
        '
        Me.surroundON_rb.AutoSize = True
        Me.surroundON_rb.Checked = True
        Me.surroundON_rb.Location = New System.Drawing.Point(19, 17)
        Me.surroundON_rb.Name = "surroundON_rb"
        Me.surroundON_rb.Size = New System.Drawing.Size(41, 17)
        Me.surroundON_rb.TabIndex = 0
        Me.surroundON_rb.TabStop = True
        Me.surroundON_rb.Text = "ON"
        Me.surroundON_rb.UseVisualStyleBackColor = True
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(17, 250)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(175, 13)
        Me.label24.TabIndex = 15
        Me.label24.Text = "Video playback volume in the game"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(17, 90)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(58, 13)
        Me.label21.TabIndex = 11
        Me.label21.Text = "SE volume"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(17, 170)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(71, 13)
        Me.label25.TabIndex = 13
        Me.label25.Text = "Voice volume"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(17, 12)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(68, 13)
        Me.label20.TabIndex = 6
        Me.label20.Text = "BGM volume"
        '
        'panel9
        '
        Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel9.Controls.Add(Me.label26)
        Me.panel9.Controls.Add(Me.label27)
        Me.panel9.Controls.Add(Me.vidVol_lbl)
        Me.panel9.Controls.Add(Me.vidVol_tb)
        Me.panel9.Location = New System.Drawing.Point(11, 256)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(450, 61)
        Me.panel9.TabIndex = 14
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(359, 42)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(25, 13)
        Me.label26.TabIndex = 9
        Me.label26.Text = "100"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(20, 42)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(13, 13)
        Me.label27.TabIndex = 8
        Me.label27.Text = "0"
        '
        'vidVol_lbl
        '
        Me.vidVol_lbl.AutoSize = True
        Me.vidVol_lbl.Location = New System.Drawing.Point(390, 16)
        Me.vidVol_lbl.Name = "vidVol_lbl"
        Me.vidVol_lbl.Size = New System.Drawing.Size(59, 13)
        Me.vidVol_lbl.TabIndex = 7
        Me.vidVol_lbl.Text = "Vid volume"
        '
        'vidVol_tb
        '
        Me.vidVol_tb.BackColor = System.Drawing.SystemColors.Control
        Me.vidVol_tb.Location = New System.Drawing.Point(11, 7)
        Me.vidVol_tb.Maximum = 100
        Me.vidVol_tb.Name = "vidVol_tb"
        Me.vidVol_tb.Size = New System.Drawing.Size(369, 45)
        Me.vidVol_tb.TabIndex = 0
        Me.vidVol_tb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.vidVol_tb.Value = 70
        '
        'panel8
        '
        Me.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel8.Controls.Add(Me.label22)
        Me.panel8.Controls.Add(Me.label23)
        Me.panel8.Controls.Add(Me.seVol_lbl)
        Me.panel8.Controls.Add(Me.seVol_tb)
        Me.panel8.Location = New System.Drawing.Point(11, 96)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(450, 61)
        Me.panel8.TabIndex = 10
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(359, 42)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(25, 13)
        Me.label22.TabIndex = 9
        Me.label22.Text = "100"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(20, 42)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(13, 13)
        Me.label23.TabIndex = 8
        Me.label23.Text = "0"
        '
        'seVol_lbl
        '
        Me.seVol_lbl.AutoSize = True
        Me.seVol_lbl.Location = New System.Drawing.Point(390, 16)
        Me.seVol_lbl.Name = "seVol_lbl"
        Me.seVol_lbl.Size = New System.Drawing.Size(58, 13)
        Me.seVol_lbl.TabIndex = 7
        Me.seVol_lbl.Text = "SE volume"
        '
        'seVol_tb
        '
        Me.seVol_tb.BackColor = System.Drawing.SystemColors.Control
        Me.seVol_tb.Location = New System.Drawing.Point(11, 7)
        Me.seVol_tb.Maximum = 100
        Me.seVol_tb.Name = "seVol_tb"
        Me.seVol_tb.Size = New System.Drawing.Size(369, 45)
        Me.seVol_tb.TabIndex = 0
        Me.seVol_tb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.seVol_tb.Value = 80
        '
        'panel13
        '
        Me.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel13.Controls.Add(Me.label29)
        Me.panel13.Controls.Add(Me.label30)
        Me.panel13.Controls.Add(Me.voiceVol_lbl)
        Me.panel13.Controls.Add(Me.voiceVol_tb)
        Me.panel13.Location = New System.Drawing.Point(11, 176)
        Me.panel13.Name = "panel13"
        Me.panel13.Size = New System.Drawing.Size(450, 61)
        Me.panel13.TabIndex = 12
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(359, 42)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(25, 13)
        Me.label29.TabIndex = 9
        Me.label29.Text = "100"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(20, 42)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(13, 13)
        Me.label30.TabIndex = 8
        Me.label30.Text = "0"
        '
        'voiceVol_lbl
        '
        Me.voiceVol_lbl.AutoSize = True
        Me.voiceVol_lbl.Location = New System.Drawing.Point(390, 16)
        Me.voiceVol_lbl.Name = "voiceVol_lbl"
        Me.voiceVol_lbl.Size = New System.Drawing.Size(71, 13)
        Me.voiceVol_lbl.TabIndex = 7
        Me.voiceVol_lbl.Text = "Voice volume"
        '
        'voiceVol_tb
        '
        Me.voiceVol_tb.BackColor = System.Drawing.SystemColors.Control
        Me.voiceVol_tb.Location = New System.Drawing.Point(11, 7)
        Me.voiceVol_tb.Maximum = 100
        Me.voiceVol_tb.Name = "voiceVol_tb"
        Me.voiceVol_tb.Size = New System.Drawing.Size(369, 45)
        Me.voiceVol_tb.TabIndex = 0
        Me.voiceVol_tb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.voiceVol_tb.Value = 80
        '
        'panel10
        '
        Me.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel10.Controls.Add(Me.label16)
        Me.panel10.Controls.Add(Me.label15)
        Me.panel10.Controls.Add(Me.bgmVol_lbl)
        Me.panel10.Controls.Add(Me.bgmVol_trkb)
        Me.panel10.Location = New System.Drawing.Point(11, 18)
        Me.panel10.Name = "panel10"
        Me.panel10.Size = New System.Drawing.Size(450, 61)
        Me.panel10.TabIndex = 5
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(359, 42)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(25, 13)
        Me.label16.TabIndex = 9
        Me.label16.Text = "100"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(20, 42)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(13, 13)
        Me.label15.TabIndex = 8
        Me.label15.Text = "0"
        '
        'bgmVol_lbl
        '
        Me.bgmVol_lbl.AutoSize = True
        Me.bgmVol_lbl.Location = New System.Drawing.Point(390, 16)
        Me.bgmVol_lbl.Name = "bgmVol_lbl"
        Me.bgmVol_lbl.Size = New System.Drawing.Size(68, 13)
        Me.bgmVol_lbl.TabIndex = 7
        Me.bgmVol_lbl.Text = "BGM volume"
        '
        'bgmVol_trkb
        '
        Me.bgmVol_trkb.BackColor = System.Drawing.SystemColors.Control
        Me.bgmVol_trkb.Location = New System.Drawing.Point(11, 7)
        Me.bgmVol_trkb.Maximum = 100
        Me.bgmVol_trkb.Name = "bgmVol_trkb"
        Me.bgmVol_trkb.Size = New System.Drawing.Size(369, 45)
        Me.bgmVol_trkb.TabIndex = 0
        Me.bgmVol_trkb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.bgmVol_trkb.Value = 50
        '
        'network_pnl
        '
        Me.network_pnl.AutoScroll = True
        Me.network_pnl.Controls.Add(Me.Label33)
        Me.network_pnl.Controls.Add(Me.Panel17)
        Me.network_pnl.Controls.Add(Me.rtbDebug)
        Me.network_pnl.Controls.Add(Me.label35)
        Me.network_pnl.Controls.Add(Me.panel22)
        Me.network_pnl.Location = New System.Drawing.Point(42, 310)
        Me.network_pnl.Name = "network_pnl"
        Me.network_pnl.Size = New System.Drawing.Size(652, 314)
        Me.network_pnl.TabIndex = 18
        Me.network_pnl.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 126)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 13)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Tweaker"
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Label41)
        Me.Panel17.Controls.Add(Me.Label40)
        Me.Panel17.Controls.Add(Me.Panel23)
        Me.Panel17.Controls.Add(Me.Panel21)
        Me.Panel17.Controls.Add(Me.Label39)
        Me.Panel17.Controls.Add(Me.Label38)
        Me.Panel17.Controls.Add(Me.Panel20)
        Me.Panel17.Controls.Add(Me.Panel19)
        Me.Panel17.Controls.Add(Me.Label37)
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.btnInstallPSO2)
        Me.Panel17.Controls.Add(Me.btnTerminate)
        Me.Panel17.Controls.Add(Me.CheckBox3)
        Me.Panel17.Controls.Add(Me.enableSteam_cbx)
        Me.Panel17.Controls.Add(Me.btnResetTweaker)
        Me.Panel17.Location = New System.Drawing.Point(11, 139)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(566, 456)
        Me.Panel17.TabIndex = 10
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(382, 107)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(144, 13)
        Me.Label41.TabIndex = 27
        Me.Label41.Text = "Redownload Original JP Files"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label40.Image = CType(resources.GetObject("Label40.Image"), System.Drawing.Image)
        Me.Label40.Location = New System.Drawing.Point(196, 107)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(135, 13)
        Me.Label40.TabIndex = 27
        Me.Label40.Text = "Restore Backup of JP Files"
        '
        'Panel23
        '
        Me.Panel23.BackgroundImage = CType(resources.GetObject("Panel23.BackgroundImage"), System.Drawing.Image)
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.Button15)
        Me.Panel23.Controls.Add(Me.Button16)
        Me.Panel23.Controls.Add(Me.Button17)
        Me.Panel23.Location = New System.Drawing.Point(374, 114)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(175, 103)
        Me.Panel23.TabIndex = 28
        '
        'Button15
        '
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.SystemColors.Control
        Me.Button15.Location = New System.Drawing.Point(3, 13)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(166, 22)
        Me.Button15.TabIndex = 16
        Me.Button15.Text = "DL English Patch"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.SystemColors.Control
        Me.Button16.Location = New System.Drawing.Point(3, 41)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(166, 22)
        Me.Button16.TabIndex = 17
        Me.Button16.Text = "DL English Large Files"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.SystemColors.Control
        Me.Button17.Location = New System.Drawing.Point(3, 69)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(166, 22)
        Me.Button17.TabIndex = 18
        Me.Button17.Text = "DL English Story Patch"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.BackgroundImage = CType(resources.GetObject("Panel21.BackgroundImage"), System.Drawing.Image)
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.Button9)
        Me.Panel21.Controls.Add(Me.Button10)
        Me.Panel21.Controls.Add(Me.Button11)
        Me.Panel21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel21.Location = New System.Drawing.Point(188, 114)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(175, 103)
        Me.Panel21.TabIndex = 28
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.SystemColors.Control
        Me.Button9.Location = New System.Drawing.Point(3, 13)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 22)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "Restore English Patch"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.Control
        Me.Button10.Location = New System.Drawing.Point(3, 41)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(166, 22)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Restore EN Large Files"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.Control
        Me.Button11.Location = New System.Drawing.Point(3, 69)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(166, 22)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "Restore EN Story Patch"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(11, 107)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 13)
        Me.Label39.TabIndex = 25
        Me.Label39.Text = "Install/Update Patches"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label39.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.Location = New System.Drawing.Point(383, 218)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 13)
        Me.Label38.TabIndex = 25
        Me.Label38.Text = "Donation Links"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.SystemColors.Control
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.btnENPatch)
        Me.Panel20.Controls.Add(Me.Button2)
        Me.Panel20.Controls.Add(Me.Button3)
        Me.Panel20.Controls.Add(Me.Button6)
        Me.Panel20.Controls.Add(Me.Button5)
        Me.Panel20.Controls.Add(Me.Button4)
        Me.Panel20.Location = New System.Drawing.Point(3, 114)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(175, 197)
        Me.Panel20.TabIndex = 26
        Me.Panel20.Visible = False
        '
        'btnENPatch
        '
        Me.btnENPatch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnENPatch.BackgroundImage = CType(resources.GetObject("btnENPatch.BackgroundImage"), System.Drawing.Image)
        Me.btnENPatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnENPatch.FlatAppearance.BorderSize = 0
        Me.btnENPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnENPatch.ForeColor = System.Drawing.SystemColors.Control
        Me.btnENPatch.Location = New System.Drawing.Point(3, 13)
        Me.btnENPatch.Name = "btnENPatch"
        Me.btnENPatch.Size = New System.Drawing.Size(166, 22)
        Me.btnENPatch.TabIndex = 16
        Me.btnENPatch.Text = "English Patch"
        Me.btnENPatch.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(3, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 22)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "English Large Files (New Method)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(3, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 22)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "English Story Patch"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(3, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(166, 22)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Revert E-Codes to JP"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(3, 125)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(166, 22)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Revert Enemy Names to JP"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(3, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 22)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Russian Patch"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel19
        '
        Me.Panel19.BackgroundImage = CType(resources.GetObject("Panel19.BackgroundImage"), System.Drawing.Image)
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.LinkLabel13)
        Me.Panel19.Controls.Add(Me.LinkLabel14)
        Me.Panel19.Controls.Add(Me.LinkLabel15)
        Me.Panel19.Controls.Add(Me.LinkLabel16)
        Me.Panel19.Location = New System.Drawing.Point(374, 226)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(187, 121)
        Me.Panel19.TabIndex = 26
        '
        'LinkLabel13
        '
        Me.LinkLabel13.AutoSize = True
        Me.LinkLabel13.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel13.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel13.Location = New System.Drawing.Point(6, 77)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(176, 13)
        Me.LinkLabel13.TabIndex = 3
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "PSO2 Arks Launcher Donation Link"
        '
        'LinkLabel14
        '
        Me.LinkLabel14.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel14.AutoSize = True
        Me.LinkLabel14.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel14.Image = CType(resources.GetObject("LinkLabel14.Image"), System.Drawing.Image)
        Me.LinkLabel14.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel14.Location = New System.Drawing.Point(6, 55)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(149, 13)
        Me.LinkLabel14.TabIndex = 2
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "PSO2 Tweaker Donation Link"
        '
        'LinkLabel15
        '
        Me.LinkLabel15.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel15.AutoSize = True
        Me.LinkLabel15.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel15.Image = CType(resources.GetObject("LinkLabel15.Image"), System.Drawing.Image)
        Me.LinkLabel15.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel15.Location = New System.Drawing.Point(6, 33)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(126, 13)
        Me.LinkLabel15.TabIndex = 1
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "Cirnopedia Donation Link"
        '
        'LinkLabel16
        '
        Me.LinkLabel16.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel16.AutoSize = True
        Me.LinkLabel16.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel16.Image = CType(resources.GetObject("LinkLabel16.Image"), System.Drawing.Image)
        Me.LinkLabel16.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel16.Location = New System.Drawing.Point(6, 10)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(133, 13)
        Me.LinkLabel16.TabIndex = 0
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "Bumped.org Donation Link"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.Location = New System.Drawing.Point(195, 218)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Web Links"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.LightGray
        Me.Panel18.BackgroundImage = CType(resources.GetObject("Panel18.BackgroundImage"), System.Drawing.Image)
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.LinkLabel8)
        Me.Panel18.Controls.Add(Me.LinkLabel7)
        Me.Panel18.Controls.Add(Me.LinkLabel6)
        Me.Panel18.Controls.Add(Me.LinkLabel5)
        Me.Panel18.Controls.Add(Me.LinkLabel4)
        Me.Panel18.Controls.Add(Me.LinkLabel3)
        Me.Panel18.Controls.Add(Me.LinkLabel2)
        Me.Panel18.Controls.Add(Me.LinkLabel1)
        Me.Panel18.Location = New System.Drawing.Point(186, 226)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(179, 218)
        Me.Panel18.TabIndex = 24
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel8.Image = CType(resources.GetObject("LinkLabel8.Image"), System.Drawing.Image)
        Me.LinkLabel8.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel8.Location = New System.Drawing.Point(6, 166)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(168, 13)
        Me.LinkLabel8.TabIndex = 7
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Symbol Art Editor (English Version)"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel7.Image = CType(resources.GetObject("LinkLabel7.Image"), System.Drawing.Image)
        Me.LinkLabel7.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel7.Location = New System.Drawing.Point(6, 145)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(161, 13)
        Me.LinkLabel7.TabIndex = 6
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Running PSO2 in Linux (Tutorial)"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel6.Image = CType(resources.GetObject("LinkLabel6.Image"), System.Drawing.Image)
        Me.LinkLabel6.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel6.Location = New System.Drawing.Point(6, 122)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(117, 13)
        Me.LinkLabel6.TabIndex = 5
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "PSO2 Tweaker Thread"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel5.Image = CType(resources.GetObject("LinkLabel5.Image"), System.Drawing.Image)
        Me.LinkLabel5.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel5.Location = New System.Drawing.Point(6, 99)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel5.TabIndex = 4
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "PSO2 Registration Guide"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel4.Image = CType(resources.GetObject("LinkLabel4.Image"), System.Drawing.Image)
        Me.LinkLabel4.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel4.Location = New System.Drawing.Point(6, 77)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel4.TabIndex = 3
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Official PSO2JP Site"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel3.Image = CType(resources.GetObject("LinkLabel3.Image"), System.Drawing.Image)
        Me.LinkLabel3.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel3.Location = New System.Drawing.Point(6, 55)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(135, 13)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "How to buy AC (Arks Cash)"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel2.Image = CType(resources.GetObject("LinkLabel2.Image"), System.Drawing.Image)
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 33)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(143, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cirnopedia (PSO2 Database)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.LightGray
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), System.Drawing.Image)
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(152, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Bumped.org (PSO2 News Site)"
        '
        'btnInstallPSO2
        '
        Me.btnInstallPSO2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInstallPSO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstallPSO2.FlatAppearance.BorderSize = 0
        Me.btnInstallPSO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstallPSO2.Font = New System.Drawing.Font("Eurostile LT Std", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstallPSO2.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInstallPSO2.Location = New System.Drawing.Point(165, 10)
        Me.btnInstallPSO2.Name = "btnInstallPSO2"
        Me.btnInstallPSO2.Size = New System.Drawing.Size(223, 39)
        Me.btnInstallPSO2.TabIndex = 23
        Me.btnInstallPSO2.Text = "Install Phantasy Star Online 2"
        Me.btnInstallPSO2.UseVisualStyleBackColor = False
        '
        'btnTerminate
        '
        Me.btnTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerminate.FlatAppearance.BorderSize = 0
        Me.btnTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTerminate.Location = New System.Drawing.Point(204, 59)
        Me.btnTerminate.Name = "btnTerminate"
        Me.btnTerminate.Size = New System.Drawing.Size(143, 23)
        Me.btnTerminate.TabIndex = 22
        Me.btnTerminate.Text = "Terminate PSO2 Process"
        Me.btnTerminate.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackgroundImage = CType(resources.GetObject("CheckBox3.BackgroundImage"), System.Drawing.Image)
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.CheckBox3.Location = New System.Drawing.Point(3, 43)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(136, 17)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Enable Debug Window"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'enableSteam_cbx
        '
        Me.enableSteam_cbx.AutoSize = True
        Me.enableSteam_cbx.BackgroundImage = CType(resources.GetObject("enableSteam_cbx.BackgroundImage"), System.Drawing.Image)
        Me.enableSteam_cbx.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.enableSteam_cbx.Location = New System.Drawing.Point(3, 8)
        Me.enableSteam_cbx.Name = "enableSteam_cbx"
        Me.enableSteam_cbx.Size = New System.Drawing.Size(131, 17)
        Me.enableSteam_cbx.TabIndex = 9
        Me.enableSteam_cbx.Text = "Enable Steam Overlay"
        Me.enableSteam_cbx.UseVisualStyleBackColor = True
        '
        'btnResetTweaker
        '
        Me.btnResetTweaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetTweaker.FlatAppearance.BorderSize = 0
        Me.btnResetTweaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetTweaker.ForeColor = System.Drawing.SystemColors.Control
        Me.btnResetTweaker.Location = New System.Drawing.Point(393, 59)
        Me.btnResetTweaker.Name = "btnResetTweaker"
        Me.btnResetTweaker.Size = New System.Drawing.Size(143, 23)
        Me.btnResetTweaker.TabIndex = 8
        Me.btnResetTweaker.Text = "Reset Launcher Settings"
        Me.btnResetTweaker.UseVisualStyleBackColor = True
        '
        'rtbDebug
        '
        Me.rtbDebug.Location = New System.Drawing.Point(223, 18)
        Me.rtbDebug.Multiline = True
        Me.rtbDebug.Name = "rtbDebug"
        Me.rtbDebug.Size = New System.Drawing.Size(354, 103)
        Me.rtbDebug.TabIndex = 7
        Me.rtbDebug.Text = "Debug Log-------------------------"
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Location = New System.Drawing.Point(17, 12)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(90, 13)
        Me.label35.TabIndex = 6
        Me.label35.Text = "Connection setup"
        '
        'panel22
        '
        Me.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel22.Controls.Add(Me.chkConnection_btn)
        Me.panel22.Controls.Add(Me.ieSettings_btn)
        Me.panel22.Location = New System.Drawing.Point(11, 18)
        Me.panel22.Name = "panel22"
        Me.panel22.Size = New System.Drawing.Size(206, 103)
        Me.panel22.TabIndex = 5
        '
        'chkConnection_btn
        '
        Me.chkConnection_btn.Enabled = False
        Me.chkConnection_btn.Location = New System.Drawing.Point(31, 63)
        Me.chkConnection_btn.Name = "chkConnection_btn"
        Me.chkConnection_btn.Size = New System.Drawing.Size(138, 23)
        Me.chkConnection_btn.TabIndex = 1
        Me.chkConnection_btn.Text = "Checking the Connection"
        Me.chkConnection_btn.UseVisualStyleBackColor = True
        '
        'ieSettings_btn
        '
        Me.ieSettings_btn.Enabled = False
        Me.ieSettings_btn.Location = New System.Drawing.Point(16, 18)
        Me.ieSettings_btn.Name = "ieSettings_btn"
        Me.ieSettings_btn.Size = New System.Drawing.Size(169, 23)
        Me.ieSettings_btn.TabIndex = 0
        Me.ieSettings_btn.Text = "Internet Settings property"
        Me.ieSettings_btn.UseVisualStyleBackColor = True
        '
        'language_pnl
        '
        Me.language_pnl.AutoScroll = True
        Me.language_pnl.Controls.Add(Me.WebBrowser2)
        Me.language_pnl.Controls.Add(Me.Label32)
        Me.language_pnl.Controls.Add(Me.savePlugins)
        Me.language_pnl.Controls.Add(Me.btnConfigure)
        Me.language_pnl.Controls.Add(Me.lblPluginInfo)
        Me.language_pnl.Controls.Add(Me.Label31)
        Me.language_pnl.Controls.Add(Me.Panel16)
        Me.language_pnl.Controls.Add(Me.btnLargeFilesTRANSAM)
        Me.language_pnl.Controls.Add(Me.label9)
        Me.language_pnl.Controls.Add(Me.language_cb)
        Me.language_pnl.Controls.Add(Me.label8)
        Me.language_pnl.Controls.Add(Me.panel4)
        Me.language_pnl.Location = New System.Drawing.Point(42, 310)
        Me.language_pnl.Name = "language_pnl"
        Me.language_pnl.Size = New System.Drawing.Size(652, 314)
        Me.language_pnl.TabIndex = 7
        Me.language_pnl.Visible = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.AllowWebBrowserDrop = False
        Me.WebBrowser2.Location = New System.Drawing.Point(223, 27)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(390, 188)
        Me.WebBrowser2.TabIndex = 14
        Me.WebBrowser2.Url = New System.Uri("http://108.61.203.33/freedom/tweaker.html", System.UriKind.Absolute)
        Me.WebBrowser2.WebBrowserShortcutsEnabled = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(225, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(121, 13)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Tweaker Freedom Page"
        '
        'savePlugins
        '
        Me.savePlugins.Location = New System.Drawing.Point(220, 219)
        Me.savePlugins.Name = "savePlugins"
        Me.savePlugins.Size = New System.Drawing.Size(101, 23)
        Me.savePlugins.TabIndex = 13
        Me.savePlugins.Text = "Confirm"
        Me.savePlugins.UseVisualStyleBackColor = True
        Me.savePlugins.Visible = False
        '
        'btnConfigure
        '
        Me.btnConfigure.Location = New System.Drawing.Point(220, 245)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(101, 23)
        Me.btnConfigure.TabIndex = 12
        Me.btnConfigure.Text = "Configure plugin"
        Me.btnConfigure.UseVisualStyleBackColor = True
        Me.btnConfigure.Visible = False
        '
        'lblPluginInfo
        '
        Me.lblPluginInfo.AutoSize = True
        Me.lblPluginInfo.Location = New System.Drawing.Point(14, 265)
        Me.lblPluginInfo.Name = "lblPluginInfo"
        Me.lblPluginInfo.Size = New System.Drawing.Size(94, 13)
        Me.lblPluginInfo.TabIndex = 11
        Me.lblPluginInfo.Text = "Plugin Information."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(17, 157)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Plugins"
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.ListViewEx1)
        Me.Panel16.Location = New System.Drawing.Point(11, 163)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(203, 105)
        Me.Panel16.TabIndex = 7
        '
        'ListViewEx1
        '
        Me.ListViewEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewEx1.CheckBoxes = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        Me.ListViewEx1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListViewEx1.Location = New System.Drawing.Point(8, 12)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(184, 84)
        Me.ListViewEx1.TabIndex = 11
        Me.ListViewEx1.UseCompatibleStateImageBehavior = False
        Me.ListViewEx1.View = System.Windows.Forms.View.List
        '
        'btnLargeFilesTRANSAM
        '
        Me.btnLargeFilesTRANSAM.Location = New System.Drawing.Point(520, 235)
        Me.btnLargeFilesTRANSAM.Name = "btnLargeFilesTRANSAM"
        Me.btnLargeFilesTRANSAM.Size = New System.Drawing.Size(101, 23)
        Me.btnLargeFilesTRANSAM.TabIndex = 9
        Me.btnLargeFilesTRANSAM.Text = "Install Large Files"
        Me.btnLargeFilesTRANSAM.UseVisualStyleBackColor = True
        Me.btnLargeFilesTRANSAM.Visible = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(8, 10)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(55, 13)
        Me.label9.TabIndex = 8
        Me.label9.Text = "Language"
        '
        'language_cb
        '
        Me.language_cb.FormattingEnabled = True
        Me.language_cb.Items.AddRange(New Object() {"NoChange", "English(US Small Files)", "English(US Large Files)"})
        Me.language_cb.Location = New System.Drawing.Point(11, 27)
        Me.language_cb.Name = "language_cb"
        Me.language_cb.Size = New System.Drawing.Size(181, 21)
        Me.language_cb.TabIndex = 7
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(17, 61)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(182, 13)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Video playback settings giant monitor"
        '
        'panel4
        '
        Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel4.Controls.Add(Me.disableVideos_rb)
        Me.panel4.Controls.Add(Me.enableVideos_rb)
        Me.panel4.Location = New System.Drawing.Point(11, 67)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(203, 71)
        Me.panel4.TabIndex = 5
        '
        'disableVideos_rb
        '
        Me.disableVideos_rb.AutoSize = True
        Me.disableVideos_rb.Location = New System.Drawing.Point(12, 40)
        Me.disableVideos_rb.Name = "disableVideos_rb"
        Me.disableVideos_rb.Size = New System.Drawing.Size(202, 17)
        Me.disableVideos_rb.TabIndex = 5
        Me.disableVideos_rb.Text = "Do not display videos on a giant mon " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.disableVideos_rb.UseVisualStyleBackColor = True
        '
        'enableVideos_rb
        '
        Me.enableVideos_rb.AutoSize = True
        Me.enableVideos_rb.Checked = True
        Me.enableVideos_rb.Location = New System.Drawing.Point(19, 14)
        Me.enableVideos_rb.Name = "enableVideos_rb"
        Me.enableVideos_rb.Size = New System.Drawing.Size(176, 17)
        Me.enableVideos_rb.TabIndex = 4
        Me.enableVideos_rb.TabStop = True
        Me.enableVideos_rb.Text = "To play a video on a giant monit"
        Me.enableVideos_rb.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._209
        Me.quit_btn.FlatAppearance.BorderSize = 0
        Me.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quit_btn.Location = New System.Drawing.Point(694, 0)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(51, 19)
        Me.quit_btn.TabIndex = 11
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'FrmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._131__Japanese__Japan__
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(745, 720)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.settingsPanel)
        Me.Controls.Add(Me.Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain2"
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        Me.settingsPanel.ResumeLayout(False)
        Me.settingsPanel.PerformLayout()
        Me.simpleSettings_pnl.ResumeLayout(False)
        Me.simpleSettings_pnl.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.simpleSettigns_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.screen_pnl.ResumeLayout(False)
        Me.screen_pnl.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel6.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.textures_pnl.ResumeLayout(False)
        Me.textures_pnl.PerformLayout()
        Me.panel11.ResumeLayout(False)
        Me.panel11.PerformLayout()
        Me.panel12.ResumeLayout(False)
        Me.panel12.PerformLayout()
        Me.sound_pnl.ResumeLayout(False)
        Me.sound_pnl.PerformLayout()
        Me.panel14.ResumeLayout(False)
        Me.panel14.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        CType(Me.vidVol_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        CType(Me.seVol_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel13.ResumeLayout(False)
        Me.panel13.PerformLayout()
        CType(Me.voiceVol_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel10.ResumeLayout(False)
        Me.panel10.PerformLayout()
        CType(Me.bgmVol_trkb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.network_pnl.ResumeLayout(False)
        Me.network_pnl.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.panel22.ResumeLayout(False)
        Me.language_pnl.ResumeLayout(False)
        Me.language_pnl.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrWaitingforPSO2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LibDirChecker As Timer
    Private WithEvents Main As Panel
    Friend WithEvents versionLBL As Label
    Friend WithEvents lblDirectory As Label
    Public WithEvents webBrowser1 As WebBrowser
    Private WithEvents website_btn As Button
    Private WithEvents Play_btn As Button
    Private WithEvents settings_btn As Button
    Private WithEvents settingsPanel As Panel
    Private WithEvents defaults_btn As Button
    Private WithEvents saveSettings_btn As Button
    Friend WithEvents txtHTML As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents TextBoxX1 As TextBox
    Friend WithEvents txtPSO2DefaultINI As TextBox
    Private WithEvents network_btn As Button
    Private WithEvents sound_btn As Button
    Friend WithEvents CheckBoxX1 As CheckBox
    Private WithEvents textures_btn As Button
    Private WithEvents screenSettings_btn As Button
    Private WithEvents language_btn As Button
    Private WithEvents Simple_btn As Button
    Private WithEvents return_btn As Button
    Private WithEvents screen_pnl As Panel
    Private WithEvents label14 As Label
    Private WithEvents panel7 As Panel
    Private WithEvents fpsRate_cb As ComboBox
    Private WithEvents label13 As Label
    Private WithEvents panel6 As Panel
    Private WithEvents screenResolution_cb As ComboBox
    Private WithEvents label12 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents charSize_cb As ComboBox
    Private WithEvents label10 As Label
    Private WithEvents label11 As Label
    Private WithEvents panel5 As Panel
    Private WithEvents virtualFullscreen_rb As RadioButton
    Private WithEvents fullScreen_rb As RadioButton
    Private WithEvents windowed_rb As RadioButton
    Private WithEvents textures_pnl As Panel
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents panel11 As Panel
    Private WithEvents HighShaders_rdb As RadioButton
    Private WithEvents sharderSimple_rb As RadioButton
    Private WithEvents shaderStandard_rb As RadioButton
    Private WithEvents label19 As Label
    Private WithEvents panel12 As Panel
    Private WithEvents compactRes_rb As RadioButton
    Private WithEvents standardRes_rb As RadioButton
    Private WithEvents highResTextures_rb As RadioButton
    Private WithEvents sound_pnl As Panel
    Private WithEvents panel15 As Panel
    Private WithEvents label28 As Label
    Private WithEvents panel14 As Panel
    Private WithEvents surroundOFF_rb As RadioButton
    Private WithEvents surroundON_rb As RadioButton
    Private WithEvents label24 As Label
    Private WithEvents label21 As Label
    Private WithEvents label25 As Label
    Private WithEvents label20 As Label
    Private WithEvents panel9 As Panel
    Private WithEvents label26 As Label
    Private WithEvents label27 As Label
    Private WithEvents vidVol_lbl As Label
    Private WithEvents vidVol_tb As TrackBar
    Private WithEvents panel8 As Panel
    Private WithEvents label22 As Label
    Private WithEvents label23 As Label
    Private WithEvents seVol_lbl As Label
    Private WithEvents seVol_tb As TrackBar
    Private WithEvents panel13 As Panel
    Private WithEvents label29 As Label
    Private WithEvents label30 As Label
    Private WithEvents voiceVol_lbl As Label
    Private WithEvents voiceVol_tb As TrackBar
    Private WithEvents panel10 As Panel
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Private WithEvents bgmVol_lbl As Label
    Private WithEvents bgmVol_trkb As TrackBar
    Private WithEvents network_pnl As Panel
    Private WithEvents Label33 As Label
    Private WithEvents Panel17 As Panel
    Private WithEvents Label41 As Label
    Private WithEvents Label40 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Private WithEvents Label39 As Label
    Private WithEvents Label38 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents btnENPatch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents LinkLabel14 As LinkLabel
    Friend WithEvents LinkLabel15 As LinkLabel
    Friend WithEvents LinkLabel16 As LinkLabel
    Private WithEvents Label37 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnInstallPSO2 As Button
    Friend WithEvents btnTerminate As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents enableSteam_cbx As CheckBox
    Friend WithEvents btnResetTweaker As Button
    Friend WithEvents rtbDebug As TextBox
    Private WithEvents label35 As Label
    Private WithEvents panel22 As Panel
    Private WithEvents chkConnection_btn As Button
    Private WithEvents ieSettings_btn As Button
    Private WithEvents language_pnl As Panel
    Friend WithEvents WebBrowser2 As WebBrowser
    Private WithEvents Label32 As Label
    Friend WithEvents savePlugins As Button
    Friend WithEvents btnConfigure As Button
    Friend WithEvents lblPluginInfo As Label
    Private WithEvents Label31 As Label
    Private WithEvents Panel16 As Panel
    Friend WithEvents ListViewEx1 As ListView
    Friend WithEvents btnLargeFilesTRANSAM As Button
    Private WithEvents label9 As Label
    Private WithEvents language_cb As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents disableVideos_rb As RadioButton
    Private WithEvents enableVideos_rb As RadioButton
    Private WithEvents simpleSettings_pnl As Panel
    Friend WithEvents donationLiveOriginal As Button
    Friend WithEvents arksDonation As Button
    Friend WithEvents btnNewShit As Button
    Private WithEvents outputEnvironment_btn As Button
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents readSettings_btn As Button
    Private WithEvents exportSettings_btn As Button
    Private WithEvents panel2 As Panel
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents simpleSettigns_tb As TrackBar
    Private WithEvents quit_btn As Button
    Friend WithEvents advanceMode_btn As Button
End Class
