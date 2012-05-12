namespace World_Editor.AchievementsEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeAchievements = new System.Windows.Forms.TreeView();
            this.lblTimeRender = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.btnAchAdd = new System.Windows.Forms.Button();
            this.tabAchievement = new System.Windows.Forms.TabControl();
            this.tabPageAchievement = new System.Windows.Forms.TabPage();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.listFaction = new System.Windows.Forms.ComboBox();
            this.listMap = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.txtParentAchievement = new System.Windows.Forms.TextBox();
            this.btnFlags = new System.Windows.Forms.Button();
            this.btnIcon = new System.Windows.Forms.Button();
            this.groupBoxCriterias = new System.Windows.Forms.GroupBox();
            this.listCriterias = new System.Windows.Forms.ListBox();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.btnRmvCriteria = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReqValue0 = new System.Windows.Forms.Label();
            this.lblReqType0 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCriteriaId = new System.Windows.Forms.TextBox();
            this.txtReqType0 = new System.Windows.Forms.TextBox();
            this.txtCriteriaAchievement = new System.Windows.Forms.TextBox();
            this.txtCriteriaName = new System.Windows.Forms.TextBox();
            this.txtCriteriaOrder = new System.Windows.Forms.TextBox();
            this.listCriteriaType = new System.Windows.Forms.ComboBox();
            this.txtReqValue0 = new System.Windows.Forms.TextBox();
            this.txtReqType2 = new System.Windows.Forms.TextBox();
            this.txtReqType1 = new System.Windows.Forms.TextBox();
            this.txtReqValue2 = new System.Windows.Forms.TextBox();
            this.txtReqValue1 = new System.Windows.Forms.TextBox();
            this.lblReqValue1 = new System.Windows.Forms.Label();
            this.lblReqValue2 = new System.Windows.Forms.Label();
            this.lblReqType2 = new System.Windows.Forms.Label();
            this.lblReqType1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimerStartEvent = new System.Windows.Forms.TextBox();
            this.txtTimedType = new System.Windows.Forms.TextBox();
            this.txtTimeLimit = new System.Windows.Forms.TextBox();
            this.txtCriteriaFlags = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panelRenderAchievement = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAchievementRef = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnReconstructTree = new System.Windows.Forms.Button();
            this.tabAchievement.SuspendLayout();
            this.tabPageAchievement.SuspendLayout();
            this.groupBoxCriterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeAchievements
            // 
            this.treeAchievements.Location = new System.Drawing.Point(12, 12);
            this.treeAchievements.Name = "treeAchievements";
            this.treeAchievements.Size = new System.Drawing.Size(222, 454);
            this.treeAchievements.TabIndex = 0;
            this.treeAchievements.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAchievements_AfterSelect);
            // 
            // lblTimeRender
            // 
            this.lblTimeRender.AutoSize = true;
            this.lblTimeRender.Location = new System.Drawing.Point(12, 525);
            this.lblTimeRender.Name = "lblTimeRender";
            this.lblTimeRender.Size = new System.Drawing.Size(75, 13);
            this.lblTimeRender.TabIndex = 1;
            this.lblTimeRender.Text = "lblTimeRender";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(25, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(12, 472);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(108, 22);
            this.btnCatAdd.TabIndex = 3;
            this.btnCatAdd.Text = "Add category";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            // 
            // btnAchAdd
            // 
            this.btnAchAdd.Location = new System.Drawing.Point(126, 472);
            this.btnAchAdd.Name = "btnAchAdd";
            this.btnAchAdd.Size = new System.Drawing.Size(108, 22);
            this.btnAchAdd.TabIndex = 4;
            this.btnAchAdd.Text = "Add achievement";
            this.btnAchAdd.UseVisualStyleBackColor = true;
            // 
            // tabAchievement
            // 
            this.tabAchievement.Controls.Add(this.tabPageAchievement);
            this.tabAchievement.Controls.Add(this.tabPageCategory);
            this.tabAchievement.Location = new System.Drawing.Point(240, 12);
            this.tabAchievement.Name = "tabAchievement";
            this.tabAchievement.SelectedIndex = 0;
            this.tabAchievement.Size = new System.Drawing.Size(488, 519);
            this.tabAchievement.TabIndex = 5;
            // 
            // tabPageAchievement
            // 
            this.tabPageAchievement.Controls.Add(this.btnReconstructTree);
            this.tabPageAchievement.Controls.Add(this.txtCount);
            this.tabPageAchievement.Controls.Add(this.txtAchievementRef);
            this.tabPageAchievement.Controls.Add(this.label23);
            this.tabPageAchievement.Controls.Add(this.label22);
            this.tabPageAchievement.Controls.Add(this.panelRenderAchievement);
            this.tabPageAchievement.Controls.Add(this.groupBoxCriterias);
            this.tabPageAchievement.Controls.Add(this.btnIcon);
            this.tabPageAchievement.Controls.Add(this.btnFlags);
            this.tabPageAchievement.Controls.Add(this.txtParentAchievement);
            this.tabPageAchievement.Controls.Add(this.txtReward);
            this.tabPageAchievement.Controls.Add(this.txtPoints);
            this.tabPageAchievement.Controls.Add(this.txtOrder);
            this.tabPageAchievement.Controls.Add(this.txtFlags);
            this.tabPageAchievement.Controls.Add(this.txtCategory);
            this.tabPageAchievement.Controls.Add(this.txtIcon);
            this.tabPageAchievement.Controls.Add(this.txtDescription);
            this.tabPageAchievement.Controls.Add(this.txtName);
            this.tabPageAchievement.Controls.Add(this.listMap);
            this.tabPageAchievement.Controls.Add(this.listFaction);
            this.tabPageAchievement.Controls.Add(this.txtMap);
            this.tabPageAchievement.Controls.Add(this.label12);
            this.tabPageAchievement.Controls.Add(this.label11);
            this.tabPageAchievement.Controls.Add(this.label10);
            this.tabPageAchievement.Controls.Add(this.label9);
            this.tabPageAchievement.Controls.Add(this.label8);
            this.tabPageAchievement.Controls.Add(this.label7);
            this.tabPageAchievement.Controls.Add(this.label6);
            this.tabPageAchievement.Controls.Add(this.label5);
            this.tabPageAchievement.Controls.Add(this.label4);
            this.tabPageAchievement.Controls.Add(this.label3);
            this.tabPageAchievement.Controls.Add(this.label2);
            this.tabPageAchievement.Controls.Add(this.label1);
            this.tabPageAchievement.Controls.Add(this.txtId);
            this.tabPageAchievement.Location = new System.Drawing.Point(4, 22);
            this.tabPageAchievement.Name = "tabPageAchievement";
            this.tabPageAchievement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAchievement.Size = new System.Drawing.Size(480, 493);
            this.tabPageAchievement.TabIndex = 0;
            this.tabPageAchievement.Text = "Achievement";
            this.tabPageAchievement.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(480, 493);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Map";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reward";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Icon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Flags";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Order in category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Parent achievement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Faction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Points";
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(237, 6);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(41, 20);
            this.txtMap.TabIndex = 15;
            this.txtMap.TextChanged += new System.EventHandler(this.txtMap_TextChanged);
            // 
            // listFaction
            // 
            this.listFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFaction.FormattingEnabled = true;
            this.listFaction.Items.AddRange(new object[] {
            "All",
            "Horde",
            "Alliance"});
            this.listFaction.Location = new System.Drawing.Point(125, 5);
            this.listFaction.Name = "listFaction";
            this.listFaction.Size = new System.Drawing.Size(72, 21);
            this.listFaction.TabIndex = 16;
            // 
            // listMap
            // 
            this.listMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMap.FormattingEnabled = true;
            this.listMap.Location = new System.Drawing.Point(284, 6);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(190, 21);
            this.listMap.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 105);
            this.txtDescription.TabIndex = 19;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(368, 84);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(78, 20);
            this.txtIcon.TabIndex = 20;
            this.txtIcon.TextChanged += new System.EventHandler(this.txtIcon_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(253, 137);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(55, 20);
            this.txtCategory.TabIndex = 21;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(253, 84);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(47, 20);
            this.txtFlags.TabIndex = 22;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(400, 59);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(74, 20);
            this.txtOrder.TabIndex = 23;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(253, 58);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(47, 20);
            this.txtPoints.TabIndex = 24;
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(253, 111);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(221, 20);
            this.txtReward.TabIndex = 25;
            // 
            // txtParentAchievement
            // 
            this.txtParentAchievement.Location = new System.Drawing.Point(311, 33);
            this.txtParentAchievement.Name = "txtParentAchievement";
            this.txtParentAchievement.Size = new System.Drawing.Size(163, 20);
            this.txtParentAchievement.TabIndex = 26;
            // 
            // btnFlags
            // 
            this.btnFlags.Location = new System.Drawing.Point(306, 83);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(22, 22);
            this.btnFlags.TabIndex = 27;
            this.btnFlags.Text = "+";
            this.btnFlags.UseVisualStyleBackColor = true;
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(452, 83);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(22, 22);
            this.btnIcon.TabIndex = 28;
            this.btnIcon.Text = "+";
            this.btnIcon.UseVisualStyleBackColor = true;
            // 
            // groupBoxCriterias
            // 
            this.groupBoxCriterias.Controls.Add(this.label21);
            this.groupBoxCriterias.Controls.Add(this.label20);
            this.groupBoxCriterias.Controls.Add(this.label15);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaFlags);
            this.groupBoxCriterias.Controls.Add(this.txtTimeLimit);
            this.groupBoxCriterias.Controls.Add(this.txtTimedType);
            this.groupBoxCriterias.Controls.Add(this.txtTimerStartEvent);
            this.groupBoxCriterias.Controls.Add(this.label14);
            this.groupBoxCriterias.Controls.Add(this.lblReqType1);
            this.groupBoxCriterias.Controls.Add(this.lblReqType2);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue2);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue1);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue1);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue2);
            this.groupBoxCriterias.Controls.Add(this.txtReqType1);
            this.groupBoxCriterias.Controls.Add(this.txtReqType2);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue0);
            this.groupBoxCriterias.Controls.Add(this.listCriteriaType);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaOrder);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaName);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaAchievement);
            this.groupBoxCriterias.Controls.Add(this.txtReqType0);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaId);
            this.groupBoxCriterias.Controls.Add(this.label19);
            this.groupBoxCriterias.Controls.Add(this.label18);
            this.groupBoxCriterias.Controls.Add(this.label17);
            this.groupBoxCriterias.Controls.Add(this.label16);
            this.groupBoxCriterias.Controls.Add(this.lblReqType0);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue0);
            this.groupBoxCriterias.Controls.Add(this.label13);
            this.groupBoxCriterias.Controls.Add(this.btnRmvCriteria);
            this.groupBoxCriterias.Controls.Add(this.btnAddCriteria);
            this.groupBoxCriterias.Controls.Add(this.listCriterias);
            this.groupBoxCriterias.Location = new System.Drawing.Point(9, 188);
            this.groupBoxCriterias.Name = "groupBoxCriterias";
            this.groupBoxCriterias.Size = new System.Drawing.Size(465, 206);
            this.groupBoxCriterias.TabIndex = 29;
            this.groupBoxCriterias.TabStop = false;
            this.groupBoxCriterias.Text = "Criterias";
            // 
            // listCriterias
            // 
            this.listCriterias.FormattingEnabled = true;
            this.listCriterias.Location = new System.Drawing.Point(6, 19);
            this.listCriterias.Name = "listCriterias";
            this.listCriterias.Size = new System.Drawing.Size(104, 121);
            this.listCriterias.TabIndex = 0;
            this.listCriterias.SelectedIndexChanged += new System.EventHandler(this.listCriterias_SelectedIndexChanged);
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.Location = new System.Drawing.Point(6, 146);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(104, 22);
            this.btnAddCriteria.TabIndex = 1;
            this.btnAddCriteria.Text = "Add criteria";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            // 
            // btnRmvCriteria
            // 
            this.btnRmvCriteria.Location = new System.Drawing.Point(6, 174);
            this.btnRmvCriteria.Name = "btnRmvCriteria";
            this.btnRmvCriteria.Size = new System.Drawing.Size(104, 22);
            this.btnRmvCriteria.TabIndex = 2;
            this.btnRmvCriteria.Text = "Remove criteria";
            this.btnRmvCriteria.UseVisualStyleBackColor = true;
            this.btnRmvCriteria.Click += new System.EventHandler(this.btnRmvCriteria_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Id";
            // 
            // lblReqValue0
            // 
            this.lblReqValue0.Location = new System.Drawing.Point(292, 129);
            this.lblReqValue0.Name = "lblReqValue0";
            this.lblReqValue0.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue0.TabIndex = 4;
            this.lblReqValue0.Text = "lblReqValue0";
            this.lblReqValue0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqType0
            // 
            this.lblReqType0.Location = new System.Drawing.Point(116, 129);
            this.lblReqType0.Name = "lblReqType0";
            this.lblReqType0.Size = new System.Drawing.Size(109, 20);
            this.lblReqType0.TabIndex = 5;
            this.lblReqType0.Text = "lblReqType0";
            this.lblReqType0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(116, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(220, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "CriteriaOrder";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Achievement";
            // 
            // txtCriteriaId
            // 
            this.txtCriteriaId.Enabled = false;
            this.txtCriteriaId.Location = new System.Drawing.Point(138, 19);
            this.txtCriteriaId.Name = "txtCriteriaId";
            this.txtCriteriaId.Size = new System.Drawing.Size(41, 20);
            this.txtCriteriaId.TabIndex = 10;
            // 
            // txtReqType0
            // 
            this.txtReqType0.Location = new System.Drawing.Point(231, 129);
            this.txtReqType0.Name = "txtReqType0";
            this.txtReqType0.Size = new System.Drawing.Size(55, 20);
            this.txtReqType0.TabIndex = 11;
            // 
            // txtCriteriaAchievement
            // 
            this.txtCriteriaAchievement.Enabled = false;
            this.txtCriteriaAchievement.Location = new System.Drawing.Point(260, 19);
            this.txtCriteriaAchievement.Name = "txtCriteriaAchievement";
            this.txtCriteriaAchievement.Size = new System.Drawing.Size(44, 20);
            this.txtCriteriaAchievement.TabIndex = 12;
            // 
            // txtCriteriaName
            // 
            this.txtCriteriaName.Location = new System.Drawing.Point(173, 72);
            this.txtCriteriaName.Name = "txtCriteriaName";
            this.txtCriteriaName.Size = new System.Drawing.Size(131, 20);
            this.txtCriteriaName.TabIndex = 13;
            // 
            // txtCriteriaOrder
            // 
            this.txtCriteriaOrder.Location = new System.Drawing.Point(291, 97);
            this.txtCriteriaOrder.Name = "txtCriteriaOrder";
            this.txtCriteriaOrder.Size = new System.Drawing.Size(39, 20);
            this.txtCriteriaOrder.TabIndex = 14;
            // 
            // listCriteriaType
            // 
            this.listCriteriaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCriteriaType.FormattingEnabled = true;
            this.listCriteriaType.Location = new System.Drawing.Point(173, 45);
            this.listCriteriaType.Name = "listCriteriaType";
            this.listCriteriaType.Size = new System.Drawing.Size(283, 21);
            this.listCriteriaType.TabIndex = 15;
            this.listCriteriaType.SelectedIndexChanged += new System.EventHandler(this.listCriteriaType_SelectedIndexChanged);
            // 
            // txtReqValue0
            // 
            this.txtReqValue0.Location = new System.Drawing.Point(404, 129);
            this.txtReqValue0.Name = "txtReqValue0";
            this.txtReqValue0.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue0.TabIndex = 16;
            // 
            // txtReqType2
            // 
            this.txtReqType2.Location = new System.Drawing.Point(231, 181);
            this.txtReqType2.Name = "txtReqType2";
            this.txtReqType2.Size = new System.Drawing.Size(55, 20);
            this.txtReqType2.TabIndex = 17;
            // 
            // txtReqType1
            // 
            this.txtReqType1.Location = new System.Drawing.Point(230, 155);
            this.txtReqType1.Name = "txtReqType1";
            this.txtReqType1.Size = new System.Drawing.Size(56, 20);
            this.txtReqType1.TabIndex = 18;
            // 
            // txtReqValue2
            // 
            this.txtReqValue2.Location = new System.Drawing.Point(404, 181);
            this.txtReqValue2.Name = "txtReqValue2";
            this.txtReqValue2.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue2.TabIndex = 19;
            // 
            // txtReqValue1
            // 
            this.txtReqValue1.Location = new System.Drawing.Point(404, 155);
            this.txtReqValue1.Name = "txtReqValue1";
            this.txtReqValue1.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue1.TabIndex = 20;
            // 
            // lblReqValue1
            // 
            this.lblReqValue1.Location = new System.Drawing.Point(292, 155);
            this.lblReqValue1.Name = "lblReqValue1";
            this.lblReqValue1.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue1.TabIndex = 21;
            this.lblReqValue1.Text = "lblReqValue1";
            this.lblReqValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqValue2
            // 
            this.lblReqValue2.Location = new System.Drawing.Point(292, 181);
            this.lblReqValue2.Name = "lblReqValue2";
            this.lblReqValue2.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue2.TabIndex = 22;
            this.lblReqValue2.Text = "lblReqValue2";
            this.lblReqValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqType2
            // 
            this.lblReqType2.Location = new System.Drawing.Point(116, 181);
            this.lblReqType2.Name = "lblReqType2";
            this.lblReqType2.Size = new System.Drawing.Size(109, 20);
            this.lblReqType2.TabIndex = 23;
            this.lblReqType2.Text = "lblReqType2";
            this.lblReqType2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqType1
            // 
            this.lblReqType1.Location = new System.Drawing.Point(116, 155);
            this.lblReqType1.Name = "lblReqType1";
            this.lblReqType1.Size = new System.Drawing.Size(108, 20);
            this.lblReqType1.TabIndex = 24;
            this.lblReqType1.Text = "lblReqType1";
            this.lblReqType1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Completion flag";
            // 
            // txtTimerStartEvent
            // 
            this.txtTimerStartEvent.Location = new System.Drawing.Point(396, 71);
            this.txtTimerStartEvent.Name = "txtTimerStartEvent";
            this.txtTimerStartEvent.Size = new System.Drawing.Size(60, 20);
            this.txtTimerStartEvent.TabIndex = 26;
            // 
            // txtTimedType
            // 
            this.txtTimedType.Location = new System.Drawing.Point(396, 97);
            this.txtTimedType.Name = "txtTimedType";
            this.txtTimedType.Size = new System.Drawing.Size(60, 20);
            this.txtTimedType.TabIndex = 27;
            // 
            // txtTimeLimit
            // 
            this.txtTimeLimit.Location = new System.Drawing.Point(173, 97);
            this.txtTimeLimit.Name = "txtTimeLimit";
            this.txtTimeLimit.Size = new System.Drawing.Size(41, 20);
            this.txtTimeLimit.TabIndex = 28;
            // 
            // txtCriteriaFlags
            // 
            this.txtCriteriaFlags.Location = new System.Drawing.Point(396, 19);
            this.txtCriteriaFlags.Name = "txtCriteriaFlags";
            this.txtCriteriaFlags.Size = new System.Drawing.Size(60, 20);
            this.txtCriteriaFlags.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TimeLimit";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(312, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "timerStartEvent";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(336, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "timedType";
            // 
            // panelRenderAchievement
            // 
            this.panelRenderAchievement.Location = new System.Drawing.Point(90, 400);
            this.panelRenderAchievement.Name = "panelRenderAchievement";
            this.panelRenderAchievement.Size = new System.Drawing.Size(310, 87);
            this.panelRenderAchievement.TabIndex = 30;
            this.panelRenderAchievement.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRenderAchievement_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 500);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 22);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 22);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save files";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(351, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Criterias req";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(203, 165);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Achievement reference";
            // 
            // txtAchievementRef
            // 
            this.txtAchievementRef.Location = new System.Drawing.Point(326, 162);
            this.txtAchievementRef.Name = "txtAchievementRef";
            this.txtAchievementRef.Size = new System.Drawing.Size(52, 20);
            this.txtAchievementRef.TabIndex = 33;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(419, 137);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(55, 20);
            this.txtCount.TabIndex = 34;
            // 
            // btnReconstructTree
            // 
            this.btnReconstructTree.Location = new System.Drawing.Point(314, 136);
            this.btnReconstructTree.Name = "btnReconstructTree";
            this.btnReconstructTree.Size = new System.Drawing.Size(22, 22);
            this.btnReconstructTree.TabIndex = 8;
            this.btnReconstructTree.Text = "\t↩";
            this.btnReconstructTree.UseVisualStyleBackColor = true;
            this.btnReconstructTree.Click += new System.EventHandler(this.btnReconstructTree_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 543);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tabAchievement);
            this.Controls.Add(this.btnAchAdd);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.lblTimeRender);
            this.Controls.Add(this.treeAchievements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achievements Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabAchievement.ResumeLayout(false);
            this.tabPageAchievement.ResumeLayout(false);
            this.tabPageAchievement.PerformLayout();
            this.groupBoxCriterias.ResumeLayout(false);
            this.groupBoxCriterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeAchievements;
        private System.Windows.Forms.Label lblTimeRender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Button btnAchAdd;
        private System.Windows.Forms.TabControl tabAchievement;
        private System.Windows.Forms.TabPage tabPageAchievement;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox listMap;
        private System.Windows.Forms.ComboBox listFaction;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.TextBox txtParentAchievement;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.GroupBox groupBoxCriterias;
        private System.Windows.Forms.Button btnRmvCriteria;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.ListBox listCriterias;
        private System.Windows.Forms.TextBox txtCriteriaOrder;
        private System.Windows.Forms.TextBox txtCriteriaName;
        private System.Windows.Forms.TextBox txtCriteriaAchievement;
        private System.Windows.Forms.TextBox txtReqType0;
        private System.Windows.Forms.TextBox txtCriteriaId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblReqType0;
        private System.Windows.Forms.Label lblReqValue0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox listCriteriaType;
        private System.Windows.Forms.TextBox txtReqValue0;
        private System.Windows.Forms.Label lblReqType1;
        private System.Windows.Forms.Label lblReqType2;
        private System.Windows.Forms.Label lblReqValue2;
        private System.Windows.Forms.Label lblReqValue1;
        private System.Windows.Forms.TextBox txtReqValue1;
        private System.Windows.Forms.TextBox txtReqValue2;
        private System.Windows.Forms.TextBox txtReqType1;
        private System.Windows.Forms.TextBox txtReqType2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCriteriaFlags;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.TextBox txtTimedType;
        private System.Windows.Forms.TextBox txtTimerStartEvent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelRenderAchievement;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAchievementRef;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnReconstructTree;
    }
}