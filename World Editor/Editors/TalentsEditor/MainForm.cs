using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MDS.cBlp2;
using World_Editor.DBC;

namespace World_Editor.TalentsEditor
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();

        public MainForm()
        {
            InitializeComponent();
            this.g = panelIn.CreateGraphics();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            talentTabScroll.Maximum = panelIn.Height - panelOut.Height;

            listTalentTab.Items.Clear();
            foreach (TalentTabEntry t in DBCStores.TalentTab.Records)
                listTalentTab.Items.Add(t);

            listTalentTab.SelectedIndex = 0;
        }

        private void listTalentTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Blp2 blpFile = new Blp2();
            images.Clear();

            listTalents.Items.Clear();
            TalentTabEntry tab = (TalentTabEntry)listTalentTab.SelectedItem;
            foreach (TalentEntry t in DBCStores.Talent.Records.Where(th => th.TabId == tab.Id))
            {
                listTalents.Items.Add(t);
                if (Stormlib.MPQFile.HasFile(DBCStores.SpellIcon[DBCStores.Spell[t.RankId[0]].SpellIconID].IconPath + ".blp"))
                {
                    blpFile = Blp2.FromStream(new Stormlib.MPQFile(DBCStores.SpellIcon[DBCStores.Spell[t.RankId[0]].SpellIconID].IconPath + ".blp"));
                    images.Add("SpellIcon." + t.Row.ToString() + "." + t.Col.ToString(), ResizeBlp(blpFile, 40, 40));
                }
            }

            blpFile = Blp2.FromFile("Ressources\\DefaultTalent-TopLeft.blp");
            images.Add("BackTopLeft", (Bitmap)blpFile);
            blpFile = Blp2.FromFile("Ressources\\DefaultTalent-TopRight.blp");
            images.Add("BackTopRight", (Bitmap)blpFile);
            blpFile = Blp2.FromFile("Ressources\\DefaultTalent-BottomLeft.blp");
            images.Add("BackBottomLeft", (Bitmap)blpFile);
            blpFile = Blp2.FromFile("Ressources\\DefaultTalent-BottomRight.blp");
            images.Add("BackBottomRight", (Bitmap)blpFile);

            blpFile = Blp2.FromFile("Ressources\\UI-TalentArrows.blp");
            images.Add("TalentArrowsBottom", CropBlp((Bitmap)blpFile, new Rectangle(0, 0, 32, 32)));
            images.Add("TalentArrowsRight", CropBlp((Bitmap)blpFile, new Rectangle(32, 0, 32, 32)));
            images.Add("TalentArrowsLeft", RotateBlp(CropBlp((Bitmap)blpFile, new Rectangle(32, 0, 32, 32)), 180.0f));

            blpFile = Blp2.FromFile("Ressources\\TalentFrame-RankBorder.blp");
            images.Add("TalentRankBorder", (Bitmap)blpFile);

            blpFile = Blp2.FromFile("Ressources\\UI-TalentBranches.blp");
            images.Add("TalentBarH", CropBlp((Bitmap)blpFile, new Rectangle(32, 0, 32, 32)));
            images.Add("TalentBarHLittle", CropBlp((Bitmap)blpFile, new Rectangle(32, 0, 32, 20)));
            images.Add("TalentBarV", CropBlp((Bitmap)blpFile, new Rectangle(64, 0, 32, 32)));
            images.Add("TalentBarVLittle", CropBlp((Bitmap)blpFile, new Rectangle(64, 0, 28, 32)));
            Bitmap bTmp = CropBlp((Bitmap)blpFile, new Rectangle(128, 0, 32, 32));
            bTmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            images.Add("TalentBarCR", bTmp);
            images.Add("TalentBarCL", CropBlp((Bitmap)blpFile, new Rectangle(128, 0, 32, 32)));

            blpFile = Blp2.FromFile("Ressources\\DefaultTalentIcon.blp");
            images.Add("SpellIconDefault", ResizeBlp((Bitmap)blpFile, 45, 45));

            LoadTalentTab();

            listTalents.SelectedIndex = 0;
        }

        private uint TalentRanks(TalentEntry t)
        {
            for (uint i = 0; i < 6; ++i)
                if (t.RankId[i] == 0)
                    return i;

            return 0;
        }

        private Bitmap ResizeBlp(Bitmap bitmap, uint x, uint y)
        {
            Bitmap b = new Bitmap((int)x, (int)y);
            Graphics graphic = Graphics.FromImage((Image)b);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage((Image)bitmap, 0, 0, x, y);
            graphic.Dispose();

            return b;
        }

        private static Bitmap CropBlp(Bitmap bitmap, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(bitmap);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            return bmpCrop;
        }

        private Bitmap RotateBlp(Bitmap bitmap, float angle)
        {
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            g.DrawImage(bitmap, new Point(0, 0));

            return returnBitmap;
        }

        private void LoadTalentTab()
        {
            Bitmap _bitmapTemp = new Bitmap(panelIn.Width, panelIn.Height);

            using (Graphics g = Graphics.FromImage(_bitmapTemp))
            {
                int y = talentTabScroll.Value;
                g.DrawImageUnscaled(images["BackTopLeft"], 0, 0 + y);
                g.DrawImageUnscaled(images["BackTopRight"], 256, 0 + y);
                g.DrawImageUnscaled(images["BackBottomLeft"], 0, 256 + y);
                g.DrawImageUnscaled(images["BackBottomRight"], 256, 256 + y);

                foreach (TalentEntry t in listTalents.Items)
                {
                    if (images.ContainsKey("SpellIcon." + t.Row.ToString() + "." + t.Col.ToString()))
                        g.DrawImageUnscaled(images["SpellIcon." + t.Row.ToString() + "." + t.Col.ToString()], 35 + 64 * (int)t.Col, 20 + 60 * (int)t.Row);
                    else
                        g.DrawImageUnscaled(images["SpellIconDefault"], 35 + 64 * (int)t.Col, 20 + 60 * (int)t.Row);

                    g.DrawImageUnscaled(images["TalentRankBorder"], 24 + 35 + 64 * (int)t.Col, 26 + 20 + 60 * (int)t.Row);
                    g.DrawString(TalentRanks(t).ToString(), new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point), Brushes.White, (float)(35 + 35 + 64 * (int)t.Col), (float)(35 + 20 + 60 * (int)t.Row));
                    g.DrawImageUnscaled(images["TalentRankBorder"], 26 + 35 + 64 * (int)t.Col, 6 + 60 * (int)t.Row);
                    g.DrawString("X", new Font("Arial", 8.0f, FontStyle.Bold, GraphicsUnit.Point), Brushes.White, (float)(36 + 35 + 64 * (int)t.Col), (float)(20 - 5 + 60 * (int)t.Row));

                    if (!DBCStores.Talent.ContainsKey(t.ReqTalent[0]))
                        continue;

                    TalentEntry reqTalent = DBCStores.Talent[t.ReqTalent[0]];

                    // Talent 1 case au dessus
                    if (((int)reqTalent.Row - t.Row == -1) && ((int)reqTalent.Col - t.Col == 0))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsBottom"], 20 - 16 + 35 + 64 * (int)t.Col, 20 - 12 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarHLittle"], 20 - 16 - 1 + 35 + 64 * (int)t.Col, 20 - 12 - 7 + 60 * (int)t.Row);
                    }
                    // Talent 2 cases au dessus
                    else if (((int)reqTalent.Row - t.Row == -2) && ((int)reqTalent.Col - t.Col == 0))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsBottom"], 20 - 16 + 35 + 64 * (int)t.Col, 20 - 12 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 20 - 16 - 1 + 35 + 64 * (int)t.Col, 20 - 12 - 18 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 20 - 16 - 1 + 35 + 64 * (int)t.Col, 20 - 12 - 18 - 32 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarHLittle"], 20 - 16 - 1 + 35 + 64 * (int)t.Col, 20 - 12 - 4 - 64 + 60 * (int)t.Row);
                    }
                    // Talent 3 cases au dessus
                    else if (((int)reqTalent.Row - t.Row == -3) && ((int)reqTalent.Col - t.Col == 0))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsBottom"], 39 + 64 * (int)t.Col, 8 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -10 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -42 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -74 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -106 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarHLittle"], 38 + 64 * (int)t.Col, -120 + 60 * (int)t.Row);
                    }
                    // Talent 1 case à droite
                    else if (((int)reqTalent.Row - t.Row == 0) && ((int)reqTalent.Col - t.Col == 1))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsLeft"], 20 - 16 + 20 + 35 - 4 + 64 * (int)t.Col, 20 - 12 - 4 + 20 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarVLittle"], 20 - 16 + 17 + 21 + 35 - 4 + 64 * (int)t.Col, 20 - 11 - 4 + 20 + 60 * (int)t.Row);
                    }
                    // Talent 1 case à gauche
                    else if (((int)reqTalent.Row - t.Row == 0) && ((int)reqTalent.Col - t.Col == -1))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsRight"], 20 - 16 - 16 + 35 + 64 * (int)t.Col, 20 - 12 + 16 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarVLittle"], 20 - 16 - 16 - 20 + 35 + 5 + 64 * (int)t.Col, 20 - 12 + 16 + 60 * (int)t.Row);
                    }
                    // Talent 1 case en haut à droite
                    else if (((int)reqTalent.Row - t.Row == -1) && ((int)reqTalent.Col - t.Col == 1))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsBottom"], 39 + 64 * (int)t.Col, 8 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -10 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarCR"], 43 + 64 * (int)t.Col, -35 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarV"], 66 + 64 * (int)t.Col, -35 + 60 * (int)t.Row);
                    }
                    // Talent 1 case en haut à gauche
                    else if (((int)reqTalent.Row - t.Row == -1) && ((int)reqTalent.Col - t.Col == -1))
                    {
                        g.DrawImageUnscaled(images["TalentArrowsBottom"], 39 + 64 * (int)t.Col, 8 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarH"], 38 + 64 * (int)t.Col, -10 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarCL"], 35 + 64 * (int)t.Col, -35 + 60 * (int)t.Row);
                        g.DrawImageUnscaled(images["TalentBarV"], 10 + 64 * (int)t.Col, -35 + 60 * (int)t.Row);
                    }
                }
            }

            this.g.DrawImage(_bitmapTemp, 0, 0);
            _bitmapTemp.Dispose();
            _bitmapTemp = null; 
        }

        private void talentTabScroll_Scroll(object sender, ScrollEventArgs e)
        {
            panelIn.Top = -talentTabScroll.Value;
            LoadTalentTab();
        }

        private void panelIn_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (TalentEntry t in listTalents.Items)
            {
                if ((e.X > 37 + 35 + 64 * t.Col) && (e.X < 47 + 35 + 64 * t.Col) &&
                    (e.Y > 16 + 60 * t.Row) && (e.Y < 25 + 60 * t.Row))
                {
                    DBCStores.Talent.RemoveEntry(t.Id);
                    listTalents.Items.Remove(t);
                    listTalents.SelectedIndex = 0;
                    LoadTalentTab();
                    return;
                }
                else if ((e.X > 35 + 64 * t.Col) && (e.X < 35 + 35 + 64 * t.Col) &&
                    (e.Y > 20 + 60 * t.Row) && (e.Y < 35 + 20 + 60 * t.Row))
                {
                    listTalents.SelectedItem = t;
                    return;
                }
            }

            for (uint i = 0; i < 4; ++i)
            {
                for (uint j = 0; j < 11; ++j)
                {
                    if ((e.X > 35 + 64 * i) && (e.X < 35 + 35 + 64 * i) &&
                    (e.Y > 20 + 60 * j) && (e.Y < 35 + 20 + 60 * j))
                    {
                        TalentTabEntry tb = (TalentTabEntry)listTalentTab.SelectedItem;
                        TalentEntry newTalent = new TalentEntry
                        {
                            Id = DBCStores.Talent.MaxKey + 1,
                            TabId = tb.Id,
                            Row = j,
                            Col = i,
                            RankId = new uint[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            ReqTalent = new uint[] { 0, 0, 0 },
                            ReqRank = new uint[] { 0, 0, 0 },
                            AllowForPetFlags = new uint[] { 0, 0 },
                        };
                        DBCStores.Talent.AddEntry(newTalent.Id, newTalent);
                        listTalents.Items.Add(newTalent);

                        listTalents.SelectedItem = newTalent;

                        return;
                    }
                }
            }
        }

        private void listTalents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;

            txtId.Text = t.Id.ToString();
            txtRow.Text = t.Row.ToString();
            txtCol.Text = t.Col.ToString();
            txtSpell0.Text = t.RankId[0].ToString();
            txtSpell1.Text = t.RankId[1].ToString();
            txtSpell2.Text = t.RankId[2].ToString();
            txtSpell3.Text = t.RankId[3].ToString();
            txtSpell4.Text = t.RankId[4].ToString();
            txtReqTalent.Text = t.ReqTalent[0].ToString();
            txtReqRank.Text = t.ReqRank[0].ToString();
            checkFlags.Checked = Convert.ToBoolean(t.Flags);
            txtPetFlags0.Text = t.AllowForPetFlags[0].ToString();
            txtPetFlags1.Text = t.AllowForPetFlags[1].ToString();
        }

        private void btnEditTalentTab_Click(object sender, EventArgs e)
        {
            Dialogs.TalentTabsEditor d = new Dialogs.TalentTabsEditor();
            d.ShowDialog();

            listTalentTab.Items.Clear();
            foreach (TalentTabEntry t in DBCStores.TalentTab.Records)
                listTalentTab.Items.Add(t);

            listTalentTab.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveTalentsEditorFiles();
                MessageBox.Show("Sauvegarde terminée !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        private void btnSpell0_Click(object sender, EventArgs e)
        {

        }

        private void btnSpell1_Click(object sender, EventArgs e)
        {

        }

        private void btnSpell2_Click(object sender, EventArgs e)
        {

        }

        private void btnSpell3_Click(object sender, EventArgs e)
        {

        }

        private void btnSpell4_Click(object sender, EventArgs e)
        {

        }

        private void txtRow_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.Row = ParseToUInt(txtRow.Text);
            listTalents.Items[listTalents.SelectedIndex] = t;

            LoadTalentTab();
        }

        private void txtCol_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.Col = ParseToUInt(txtCol.Text);
            listTalents.Items[listTalents.SelectedIndex] = t;

            LoadTalentTab();
        }

        private void txtSpell0_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.RankId[0] = ParseToUInt(txtSpell0.Text);
        }

        private void txtSpell1_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.RankId[1] = ParseToUInt(txtSpell1.Text);
        }

        private void txtSpell2_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.RankId[2] = ParseToUInt(txtSpell2.Text);
        }

        private void txtSpell3_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.RankId[3] = ParseToUInt(txtSpell3.Text);
        }

        private void txtSpell4_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.RankId[4] = ParseToUInt(txtSpell4.Text);
        }

        private void checkFlags_CheckedChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            if (checkFlags.Checked)
                t.Flags = 1;
            else
                t.Flags = 0;
        }

        private void txtReqTalent_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.ReqTalent[0] = ParseToUInt(txtReqTalent.Text);

            LoadTalentTab();
        }

        private void txtReqRank_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.ReqRank[0] = ParseToUInt(txtReqRank.Text);
        }

        private void txtPetFlags0_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.AllowForPetFlags[0] = ParseToUInt(txtPetFlags0.Text);
        }

        private void txtPetFlags1_TextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry)listTalents.SelectedItem;
            t.AllowForPetFlags[1] = ParseToUInt(txtPetFlags1.Text);
        }

        private uint ParseToUInt(string value)
        {
            uint tmp;
            UInt32.TryParse(value, out tmp);
            return tmp;
        }
    }
}
