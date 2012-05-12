using System;
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
                //txtId.Text = "-" + m.Groups[2].Value;
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

        private void listCriteriaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCriteriaType.SelectedItem == null)
                return;

            Criteria c = (Criteria) listCriteriaType.SelectedItem;
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
        }

        private void btnRmvCriteria_Click(object sender, EventArgs e)
        {

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

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (images.ContainsKey("SpellIcon"))
                images.Remove("SpellIcon");

            if (DBCStores.SpellIcon.ContainsKey(Misc.ParseToUInt(txtIcon.Text)) &&
                Stormlib.MPQFile.Exists(DBCStores.SpellIcon[Misc.ParseToUInt(txtIcon.Text)].IconPath + ".blp"))
            {
                images.Add("SpellIcon", ResizeBitmap(Blp2.FromStream(new Stormlib.MPQFile(DBCStores.SpellIcon[Misc.ParseToUInt(txtIcon.Text)].IconPath + ".blp")), 50, 50));
            }

            panelRenderAchievement.Invalidate();
        }

        private void txtMap_TextChanged(object sender, EventArgs e)
        {
            if (Misc.ParseToInt(txtMap.Text) == -1 || !DBCStores.Map.ContainsKey(Misc.ParseToUInt(txtMap.Text)))
                listMap.SelectedIndex = 0;
            else
                listMap.SelectedItem = DBCStores.Map[Misc.ParseToUInt(txtMap.Text)];
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeAchievements.SelectedNode.ToString());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_achievementsEditor = null;
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null || treeAchievements.SelectedNode.Name.Contains("c"))
                return;

            if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCategory.Text)) && DBCStores.Achievement.ContainsKey(Misc.ParseToUInt(txtId.Text)))
            {
                AchievementEntry a = DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)];
                a.CategoryId = Misc.ParseToUInt(txtCategory.Text);
            }
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
    }
}
