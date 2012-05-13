﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using DBCLib.Structures335;
using System.Text.RegularExpressions;
using World_Editor.Editors.AchievementsEditor;
using MDS.cBlp2;

namespace World_Editor.AchievementsEditor
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();

        public MainForm()
        {
            InitializeComponent();
            this.g = panelRenderAchievement.CreateGraphics();
        }

        public static AchievementsEditor.MainForm m_achievementsEditor;
        public static AchievementsEditor.MainForm GetChildInstance()
        {
            if (m_achievementsEditor == null)
                m_achievementsEditor = new MainForm();

            return m_achievementsEditor;
        }

        public void LoadSubCat(int id = -1)
        {
            foreach (AchievementCategoryEntry c in DBCStores.AchievementCategory.Records.Where(c => c.ParentCategory == id))
            {
                if (id == -1)
                {
                    treeAchievements.Nodes.Add("c" + c.Id.ToString(), c.Name);
                    LoadSubCat((int)c.Id);
                    foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ta => ta.CategoryId == c.Id).OrderBy(ta => ta.OrderInCategory))
                        treeAchievements.Nodes["c" + c.Id.ToString()].Nodes.Add("a" + a.Id.ToString(), a.Name);
                }
                else
                {
                    TreeNode parent = treeAchievements.Nodes.Find("c" + c.ParentCategory.ToString(), true).First();
                    parent.Nodes.Add("c" + c.Id.ToString(), c.Name);
                    LoadSubCat((int)c.Id);
                    foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ta => ta.CategoryId == c.Id).OrderBy(ta => ta.OrderInCategory))
                        parent.Nodes["c" + c.Id.ToString()].Nodes.Add("a" + a.Id.ToString(), a.Name);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBCStores.LoadAchievementsEditor();

            int start = System.Environment.TickCount;

            LoadSubCat();

            int end = System.Environment.TickCount;
            lblTimeRender.Text = (end - start).ToString() + " ms";

            Criterias.Init();
            listCriteriaType.Items.Clear();
            listCriteriaType.Items.AddRange(Criterias.criterias.Values.ToArray());

            images.Clear();
            images.Add("Back", Blp2.FromFile("Ressources\\UI-Achievement-Alert-Background.blp"));
            images.Add("IconFrame", Blp2.FromFile("Ressources\\UI-Achievement-IconFrame.blp"));
            images.Add("Shield", CropBitmap(Blp2.FromFile("Ressources\\UI-Achievement-Shields.blp"), new Rectangle(0, 0, 64, 64)));
            images.Add("ShieldNoPoints", CropBitmap(Blp2.FromFile("Ressources\\UI-Achievement-Shields-NoPoints.blp"), new Rectangle(0, 0, 64, 64)));
            images.Add("SpellIconDefault", Blp2.FromFile("Ressources\\DefaultTalentIcon.blp"));

            listMap.Items.Clear();
            listMap.Items.Add("None");
            listMap.Items.AddRange(DBCStores.Map.Records.ToArray());
        }

        private static Bitmap CropBitmap(Bitmap bitmap, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(bitmap);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            return bmpCrop;
        }

        private void treeAchievements_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            Regex myRegex = new Regex(@"^([ac])([\d]+)$");
            Match m = myRegex.Match(treeAchievements.SelectedNode.Name);
            if (m.Groups[1].Value == "a")
            {
                tabAchievement.SelectedIndex = 0;
                AchievementEntry a = DBCStores.Achievement[UInt32.Parse(m.Groups[2].Value)];

                txtId.Text = a.Id.ToString();
                listFaction.SelectedIndex = (int)(a.FactionFlag + 1);
                txtMap.Text = a.MapId.ToString();
                txtName.Text = a.Name;
                txtDescription.Text = a.Description;
                txtParentAchievement.Text = a.ParentAchievement.ToString();
                txtPoints.Text = a.Points.ToString();
                txtOrder.Text = a.OrderInCategory.ToString();
                txtFlags.Text = a.Flags.ToString();
                txtIcon.Text = a.Icon.ToString();
                txtReward.Text = a.TitleReward;
                txtCategory.Text = a.CategoryId.ToString();
                txtCount.Text = a.Count.ToString();
                txtAchievementRef.Text = a.RefAchievement.ToString();

                listCriterias.Items.Clear();
                listCriterias.Items.AddRange(DBCStores.AchievementCriteria.Records.Where(c => c.ReferredAchievement == a.Id).ToArray());
                if (listCriterias.Items.Count > 0)
                    listCriterias.SelectedIndex = 0;
            }
            else
            {
                tabAchievement.SelectedIndex = 1;
                AchievementCategoryEntry c = DBCStores.AchievementCategory[UInt32.Parse(m.Groups[2].Value)];

                txtCatId.Text = c.Id.ToString();
                txtCatParentId.Text = c.ParentCategory.ToString();
                txtCatName.Text = c.Name;
                txtCatOrder.Text = c.SortOrder.ToString();
            }
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, uint x, uint y)
        {
            Bitmap b = new Bitmap((int)x, (int)y);
            Graphics graphic = Graphics.FromImage((Image)b);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage((Image)bitmap, 0, 0, x, y);
            graphic.Dispose();

            return b;
        }

        private void listCriterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            AchievementCriteriaEntry c = (AchievementCriteriaEntry) listCriterias.SelectedItem;
            txtCriteriaId.Text = c.Id.ToString();
            txtCriteriaAchievement.Text = c.ReferredAchievement.ToString();
            listCriteriaType.SelectedItem = Criterias.criterias[c.RequiredType];

            txtReqType0.Text = c.ReqType0.ToString();
            txtReqValue0.Text = c.ReqValue0.ToString();
            txtReqType1.Text = c.ReqType1.ToString();
            txtReqValue1.Text = c.ReqValue1.ToString();
            txtReqType2.Text = c.ReqType2.ToString();
            txtReqValue2.Text = c.ReqValue2.ToString();

            txtCriteriaFlags.Text = c.Flags.ToString();
            txtCriteriaName.Text = c.Name;
            txtTimerStartEvent.Text = c.TimerStartEvent.ToString();
            txtTimeLimit.Text = c.TimeLimit.ToString();
            txtCriteriaOrder.Text = c.ShowOrder.ToString();
            txtTimedType.Text = c.TimedType.ToString();
        }

        

        private void panelRenderAchievement_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImageUnscaled(images["Back"], 0, -1);

            if (images.ContainsKey("SpellIcon"))
                g.DrawImageUnscaled(images["SpellIcon"], 10, 20);
            else
                g.DrawImageUnscaled(images["SpellIconDefault"], 5, 15);

            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.NoWrap;
            sf.Trimming = StringTrimming.EllipsisWord;
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(txtName.Text, new Font("Arial", 8.5f, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, new Rectangle(86, 35, 155, 18), sf);
            g.DrawString(txtName.Text, new Font("Arial", 8.5f, FontStyle.Bold, GraphicsUnit.Point), Brushes.White, new Rectangle(85, 34, 155, 18), sf);

            
            g.DrawImageUnscaled(images["IconFrame"], 0, 8);

            if (Misc.ParseToUInt(txtPoints.Text) == 0)
            {
                g.DrawImageUnscaled(images["ShieldNoPoints"], 241, 17);
            }
            else
            {
                g.DrawImageUnscaled(images["Shield"], 241, 17);
                g.DrawString(txtPoints.Text, new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, new Rectangle(259, 38, 29, 17), sf);
                g.DrawString(txtPoints.Text, new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point), Brushes.White, new Rectangle(258, 37, 29, 17), sf);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_achievementsEditor = null;
        }

        private void btnReconstructTree_Click(object sender, EventArgs e)
        {
            string nodeName = null;
            if (treeAchievements.SelectedNode != null)
                nodeName = treeAchievements.SelectedNode.Name;

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            if (nodeName != null)
                treeAchievements.SelectedNode = treeAchievements.Nodes.Find(nodeName, true).First();
        }

        private void tabAchievement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            if (treeAchievements.SelectedNode.Name.Contains("a"))
            {
                if (tabAchievement.SelectedIndex == 1)
                {
                    tabAchievement.SelectedIndex = 0;
                    return;
                }
            }
            else
            {
                if (tabAchievement.SelectedIndex == 0)
                {
                    tabAchievement.SelectedIndex = 1;
                    return;
                }
            }
        }

        #region TextChanged Category
        private void txtCatParentId_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCatParentId.Text)))
                lblCatParentId.Text = DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatParentId.Text)].Name;
            else
                lblCatParentId.Text = "None";

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].ParentCategory = Misc.ParseToInt(txtCatParentId.Text);
        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].Name = txtCatName.Text;

            //treeAchievements.Nodes.Find("c" + txtCatId.Text, true).First().Text = txtCatName.Text;
        }

        private void txtCatOrder_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].SortOrder = Misc.ParseToUInt(txtCatOrder.Text);
        }
        #endregion

        #region TextChanged Achievement
        private void listFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a")) &&
                !DBCStores.Achievement.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].FactionFlag = listFaction.SelectedIndex - 1;
        }

        private void txtMap_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            if (Misc.ParseToInt(txtMap.Text) == -1 || !DBCStores.Map.ContainsKey(Misc.ParseToUInt(txtMap.Text)))
                listMap.SelectedIndex = 0;
            else
                listMap.SelectedItem = DBCStores.Map[Misc.ParseToUInt(txtMap.Text)];

            AchievementEntry a = DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)];
            a.MapId = Misc.ParseToInt(txtMap.Text);
        }

        private void listMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            if (listMap.SelectedItem == null)
                return;

            if (listMap.SelectedIndex == 0)
            {
                txtMap.Text = "-1";
                return;
            }

            MapEntry m = (MapEntry)listMap.SelectedItem;
            txtMap.Text = m.ID.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            treeAchievements.Nodes.Find("a" + txtId.Text, true).First().Text = txtName.Text;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Name = txtName.Text;

            panelRenderAchievement.Invalidate();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Description = txtDescription.Text;
        }

        private void txtParentAchievement_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].ParentAchievement = Misc.ParseToUInt(txtParentAchievement.Text);
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Points = Misc.ParseToUInt(txtPoints.Text);

            panelRenderAchievement.Invalidate();
        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].OrderInCategory = Misc.ParseToUInt(txtOrder.Text);
        }

        private void txtFlags_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Flags = Misc.ParseToUInt(txtFlags.Text);
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            if (images.ContainsKey("SpellIcon"))
                images.Remove("SpellIcon");

            if (DBCStores.SpellIcon.ContainsKey(Misc.ParseToUInt(txtIcon.Text)) &&
                Stormlib.MPQFile.Exists(DBCStores.SpellIcon[Misc.ParseToUInt(txtIcon.Text)].IconPath + ".blp"))
                images.Add("SpellIcon", ResizeBitmap(Blp2.FromStream(new Stormlib.MPQFile(DBCStores.SpellIcon[Misc.ParseToUInt(txtIcon.Text)].IconPath + ".blp")), 50, 50));

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Icon = Misc.ParseToUInt(txtIcon.Text);

            panelRenderAchievement.Invalidate();
        }

        private void txtReward_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Icon = Misc.ParseToUInt(txtIcon.Text);
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null || 
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;
            if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCategory.Text)))
                DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].CategoryId = Misc.ParseToUInt(txtCategory.Text);
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Count = Misc.ParseToUInt(txtCount.Text);
        }

        private void txtAchievementRef_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].RefAchievement = Misc.ParseToUInt(txtAchievementRef.Text);
        }
        #endregion

        #region TextChanged Criteria
        private void txtCriteriaFlags_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].Flags = Misc.ParseToUInt(txtCriteriaFlags.Text);
        }

        private void listCriteriaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCriteriaType.SelectedItem == null || listCriterias.SelectedItem == null)
                return;

            Criteria c = (Criteria)listCriteriaType.SelectedItem;
            lblReqType0.Text = "Unused";
            lblReqType1.Text = "Unused";
            lblReqType2.Text = "Unused";
            lblReqValue0.Text = "Unused";
            lblReqValue1.Text = "Unused";
            lblReqValue2.Text = "Unused";
            txtReqType0.Enabled = false;
            txtReqValue0.Enabled = false;
            txtReqType1.Enabled = false;
            txtReqValue1.Enabled = false;
            txtReqType2.Enabled = false;
            txtReqValue2.Enabled = false;

            if (c.ReqType0 != null)
            {
                lblReqType0.Text = c.ReqType0;
                txtReqType0.Enabled = true;
            }

            if (c.ReqValue0 != null)
            {
                lblReqValue0.Text = c.ReqValue0;
                txtReqValue0.Enabled = true;
            }

            if (c.ReqType1 != null)
            {
                lblReqType1.Text = c.ReqType1;
                txtReqType1.Enabled = true;
            }

            if (c.ReqValue1 != null)
            {
                lblReqValue1.Text = c.ReqValue1;
                txtReqValue1.Enabled = true;
            }

            if (c.ReqType2 != null)
            {
                lblReqType2.Text = c.ReqType2;
                txtReqType2.Enabled = true;
            }

            if (c.ReqValue2 != null)
            {
                lblReqValue2.Text = c.ReqValue2;
                txtReqValue2.Enabled = true;
            }

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].RequiredType = c.TypeId;
        }

        private void txtCriteriaName_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].Name = txtCriteriaName.Text;

            listCriterias.Items[listCriterias.SelectedIndex] = DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)];
        }

        private void txtTimerStartEvent_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimerStartEvent = Misc.ParseToUInt(txtTimerStartEvent.Text);
        }

        private void txtTimeLimit_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimeLimit = Misc.ParseToUInt(txtTimeLimit.Text);
        }

        private void txtCriteriaOrder_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ShowOrder = Misc.ParseToUInt(txtCriteriaOrder.Text);
        }

        private void txtTimedType_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimedType = Misc.ParseToUInt(txtTimedType.Text);
        }

        private void txtReqType0_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType0 = Misc.ParseToUInt(txtReqType0.Text);
        }

        private void txtReqType1_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType1 = Misc.ParseToUInt(txtReqType1.Text);
        }

        private void txtReqType2_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType2 = Misc.ParseToUInt(txtReqType2.Text);
        }

        private void txtReqValue0_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue0 = Misc.ParseToUInt(txtReqValue0.Text);
        }

        private void txtReqValue1_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue1 = Misc.ParseToUInt(txtReqValue1.Text);
        }

        private void txtReqValue2_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue2 = Misc.ParseToUInt(txtReqValue2.Text);
        }
        #endregion

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveAchievementsEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            if (treeAchievements.SelectedNode.Name == "c92")
            {
                MessageBox.Show("Vous ne pouvez supprimer cette catégorie !");
                return;
            }

            if (treeAchievements.SelectedNode.Name.Contains("a"))
            {
                if (DBCStores.Achievement.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                    DBCStores.Achievement.RemoveEntry(Misc.ParseToUInt(txtId.Text));
            }
            else
            {
                if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCatId.Text)))
                {
                    if (MessageBox.Show("Toutes les sous-catégories et haut-faits seront déplacés dans la catégorie Général", "Confirmer la suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        foreach (AchievementCategoryEntry c in DBCStores.AchievementCategory.Records.Where(cp => cp.ParentCategory == Misc.ParseToUInt(txtCatId.Text)))
                            c.ParentCategory = 92;
                        foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ap => ap.CategoryId == Misc.ParseToUInt(txtCatId.Text)))
                            a.CategoryId = 92;
                        DBCStores.AchievementCategory.RemoveEntry(Misc.ParseToUInt(txtCatId.Text));
                    }
                }
            }

            treeAchievements.Nodes.Clear();
            LoadSubCat();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            AchievementCategoryEntry c = new AchievementCategoryEntry
            {
                Id = DBCStores.AchievementCategory.MaxKey + 1,
                ParentCategory = -1,
                Name = "Nouvelle catégorie",
                SortOrder = (uint)DBCStores.AchievementCategory.Records.Where(cp => cp.ParentCategory == -1).Max(cp => cp.SortOrder) + 1,
            };

            DBCStores.AchievementCategory.AddEntry(c.Id, c);

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            treeAchievements.SelectedNode = treeAchievements.Nodes.Find("c" + c.Id.ToString(), true).First();
        }

        private void btnAchAdd_Click(object sender, EventArgs e)
        {
            AchievementEntry a = new AchievementEntry
            {
                Id = DBCStores.Achievement.MaxKey + 1,
                FactionFlag = -1,
                MapId = -1,
                Name = "Nouveau haut-fait",
                Description = "",
                CategoryId = 92,
                TitleReward = "",
            };

            DBCStores.Achievement.AddEntry(a.Id, a);

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            treeAchievements.SelectedNode = treeAchievements.Nodes.Find("a" + a.Id.ToString(), true).First();
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            uint refAchiev = Misc.ParseToUInt(txtId.Text);

            AchievementCriteriaEntry c = new AchievementCriteriaEntry
            {
                Id = DBCStores.AchievementCriteria.MaxKey + 1,
                ReferredAchievement = refAchiev,
                Name = "Nouveau critère",
            };

            DBCStores.AchievementCriteria.AddEntry(c.Id, c);

            listCriterias.Items.Clear();
            listCriterias.Items.AddRange(DBCStores.AchievementCriteria.Records.Where(cp => cp.ReferredAchievement == refAchiev).ToArray());
            if (listCriterias.Items.Count > 0)
                listCriterias.SelectedIndex = listCriterias.Items.Count - 1;
        }

        private void btnRmvCriteria_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a") ||
                listCriterias.SelectedItem == null)
                return;

            AchievementCriteriaEntry c = (AchievementCriteriaEntry)listCriterias.SelectedItem;

            DBCStores.AchievementCriteria.RemoveEntry(c.Id);
            listCriterias.Items.Remove(c);
            if (listCriterias.Items.Count > 0)
                listCriterias.SelectedIndex = 0;
        }
        #endregion
    }
}
