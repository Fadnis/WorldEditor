using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCLib.Structures335;
using MDS.cBlp2;
using World_Editor.DBC;
using World_Editor.Stormlib;

namespace World_Editor.POIsEditor
{
    public partial class MainForm : Form
    {
        private const int MAX_TEXTURE_SIZE = 256;
        private const int MAX_MAP_WIDTH = 1002;
        private const int MAX_MAP_HEIGHT = 668;

        public MainForm()
        {
            InitializeComponent();
            this.g = panelIn.CreateGraphics();
        }

        public static POIsEditor.MainForm m_poisEditor;
        public static POIsEditor.MainForm GetChildInstance()
        {
            if (m_poisEditor == null)
                m_poisEditor = new MainForm();

            return m_poisEditor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_poisEditor = null;
        }

        private Graphics g;
        private void panelIn_Paint(object sender, PaintEventArgs e)
        {
            int start = System.Environment.TickCount;

            if (listWorldMapAreas.SelectedItem == null)
                return;

            Bitmap _bitmapTemp = new Bitmap(panelIn.Width, panelIn.Height);

            using (Graphics g = Graphics.FromImage(_bitmapTemp))
            {
                WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

                int i = 1;
                for (int y = 0; y < 3; ++y)
                    for (int x = 0; x < 4; ++x, ++i)
                        if (images.ContainsKey(a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp"))
                            g.DrawImageUnscaled(images[a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp"], x * MAX_TEXTURE_SIZE, y * MAX_TEXTURE_SIZE);

                foreach (WorldMapOverlayEntry o in DBCStores.WorldMapOverlay.Records.Where(op => op.WorldMapAreaId == a.Id))
                {
                    int nbX = Convert.ToInt32(Math.Ceiling((decimal)o.TextureWidth / MAX_TEXTURE_SIZE));
                    int nbY = Convert.ToInt32(Math.Ceiling((decimal)o.TextureHeight / MAX_TEXTURE_SIZE));

                    int index = 1;
                    for (int y = 0; y < nbY; ++y)
                        for (int x = 0; x < nbX; ++x, ++index)
                            if (images.ContainsKey(a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"))
                                g.DrawImageUnscaled(images[a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"], (int)o.OffsetX + x * MAX_TEXTURE_SIZE, (int)o.OffsetY + y * MAX_TEXTURE_SIZE);
                }
                /* 
                 * Coordonnées WoW              Coordonnées WinForms
                 *             ^                ------------->
                 *             |                |      x
                 *             | y            y |
                 * <------------                v
                 *       x
                 */
                Rectangle coordsMap = new Rectangle((int)a.locRight, (int)a.locBottom, (int)a.locLeft - (int)a.locRight, (int)a.locTop - (int)a.locBottom);
                foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId))
                    if (iconsPoi.ContainsKey(poi.NormalIcon))
                    {
                        uint iconPoi;
                        if (listFaction.SelectedIndex == 1)
                        {
                            if (barDestruct.Value == 1)
                                iconPoi = poi.HordeIcon50p;
                            else if (barDestruct.Value == 0)
                                iconPoi = poi.HordeIcon0p;
                            else
                                iconPoi = poi.HordeIcon;
                        }
                        else if (listFaction.SelectedIndex == 2)
                        {
                            if (barDestruct.Value == 1)
                                iconPoi = poi.AllianceIcon50p;
                            else if (barDestruct.Value == 0)
                                iconPoi = poi.AllianceIcon0p;
                            else
                                iconPoi = poi.AllianceIcon;
                        }
                        else
                        {
                            if (barDestruct.Value == 1)
                                iconPoi = poi.NormalIcon50p;
                            else if (barDestruct.Value == 0)
                                iconPoi = poi.NormalIcon0p;
                            else
                                iconPoi = poi.NormalIcon;
                        }

                        g.DrawImage(iconsPoi[iconPoi], Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) - 11), Convert.ToInt32((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom) - 15));
                        g.DrawImage(World_Editor.Properties.Resources.icon_delete_little, Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) - 11 + 15), Convert.ToInt32(((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom)) - 15 - 3));
                    }

            }

            this.g.DrawImage(_bitmapTemp, 0, 0);
            _bitmapTemp.Dispose();
            _bitmapTemp = null;

            int end = System.Environment.TickCount;
            lblRenderTime.Text = (end - start).ToString() + " ms";
        }

        private Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        private void listMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWorldMapAreas.SelectedItem == null)
                return;

            images.Clear();

            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

            int i = 1;
            for (int y = 0; y < 3; ++y)
                for (int x = 0; x < 4; ++x, ++i)
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp"))
                        images.Add(a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp")));

            foreach (WorldMapOverlayEntry o in DBCStores.WorldMapOverlay.Records.Where(op => op.WorldMapAreaId == a.Id))
            {
                int nbX = Convert.ToInt32(Math.Ceiling((decimal)o.TextureWidth / MAX_TEXTURE_SIZE));
                int nbY = Convert.ToInt32(Math.Ceiling((decimal)o.TextureHeight / MAX_TEXTURE_SIZE));

                for (int index = 1; index <= nbX * nbY; ++index)
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"))
                            images.Add(a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp")));
            }

            panelIn.Invalidate();
        }

        private Dictionary<uint, Bitmap> iconsPoi = new Dictionary<uint, Bitmap>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadPOIsEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listWorldMapAreas.Items.Clear();
            listWorldMapAreas.Items.AddRange(DBCStores.WorldMapArea.Records.ToArray());
            iconsPoi.Clear();
            // Chargement des icones des POIs
            Bitmap icons = Blp2.FromStream(new MPQFile("Interface\\Minimap\\POIIcons.blp"));
            for (uint y = 0; y <= 12; ++y)
                for (uint x = 0; x <= 13; ++x)
                    iconsPoi.Add(x + 14 * y, cropBitmap(icons, new Rectangle((int)x * 18, (int)y * 18, 18, 18)));

            if (iconsPoi.ContainsKey(0))
                iconsPoi.Remove(0);
            iconsPoi.Add(0, World_Editor.Properties.Resources.no_icon);

            listFaction.SelectedIndex = 0;
            listWorldMapAreas.SelectedIndex = 0;
        }

        private static Bitmap cropBitmap(Bitmap img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return bmpCrop;
        }

        private void panelIn_MouseClick(object sender, MouseEventArgs e)
        {

            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;
            Rectangle coordsMap = new Rectangle((int)a.locRight, (int)a.locBottom, (int)a.locLeft - (int)a.locRight, (int)a.locTop - (int)a.locBottom);
            foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId).Reverse())
            {
                Rectangle rectIconDelete = new Rectangle(
                    Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) + 4), 
                    Convert.ToInt32(((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom)) - 18),
                    7,
                    7);

                if (rectIconDelete.Contains(e.Location))
                {
                    DBCStores.AreaPOI.RemoveEntry(poi.Id);

                    panelIn_Paint(null, null);

                    return;
                }

                Rectangle rectIcon = new Rectangle(
                    Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) - 11),
                    Convert.ToInt32(((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom)) - 15),
                    20,
                    20);

                if (rectIcon.Contains(e.Location))
                {
                    txtId.Text = poi.Id.ToString();
                    txtName.Text = poi.Name;
                    txtDescription.Text = poi.Description;

                    txtNormalIcon.Text = poi.NormalIcon.ToString();
                    txtNormalIcon50.Text = poi.NormalIcon50p.ToString();
                    txtNormalIcon0.Text = poi.NormalIcon0p.ToString();
                    txtHordeIcon.Text = poi.HordeIcon.ToString();
                    txtHordeIcon50.Text = poi.HordeIcon50p.ToString();
                    txtHordeIcon0.Text = poi.HordeIcon0p.ToString();
                    txtAllianceIcon.Text = poi.AllianceIcon.ToString();
                    txtAllianceIcon50.Text = poi.AllianceIcon50p.ToString();
                    txtAllianceIcon0.Text = poi.AllianceIcon0p.ToString();

                    txtX.Text = poi.X.ToString();
                    txtY.Text = poi.Y.ToString();
                    txtZ.Text = poi.Z.ToString();

                    txtContinentId.Text = poi.ContinentId.ToString();
                    txtArea.Text = poi.Area.ToString();
                    txtImportance.Text = poi.Importance.ToString();
                    txtFactionId.Text = poi.FactionId.ToString();
                    txtWorldState.Text = poi.WorldState.ToString();
                    txtFlags.Text = poi.Flags.ToString();
                    txtWorldMapLink.Text = poi.WorldMapLink.ToString();

                    return;
                }
            }

            // Si on arrive ici c'est que le clic ne correspond à aucun emplacement de poi
            AreaPOIEntry newPoi = new AreaPOIEntry
            {
                Id = DBCStores.AreaPOI.MaxKey + 1,
                NormalIcon = 45,
                X = a.locTop - ((e.Y - 9 + 15) * (a.locTop - a.locBottom) / MAX_MAP_HEIGHT),
                Y = a.locLeft - ((e.X - 9 + 11) * (a.locLeft - a.locRight) / MAX_MAP_WIDTH),
                ContinentId = a.MapId,
                Name = "Nouveau point d'intérêt",
                Description = "",
            };
            DBCStores.AreaPOI.AddEntry(newPoi.Id, newPoi);

            panelIn_Paint(null, null);
        }

        private bool ClickIsDown = false;
        private AreaPOIEntry PoiSelected;
        private void panelIn_MouseDown(object sender, MouseEventArgs e)
        {
            
            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;
            Rectangle coordsMap = new Rectangle((int)a.locRight, (int)a.locBottom, (int)a.locLeft - (int)a.locRight, (int)a.locTop - (int)a.locBottom);
            foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId).Reverse())
            {
                Rectangle rectIcon = new Rectangle(
                    Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) - 11),
                    Convert.ToInt32(((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom)) - 15),
                    20,
                    20);

                if (rectIcon.Contains(e.Location))
                {
                    ClickIsDown = true;
                    PoiSelected = poi;
                    return;
                }
            }
        }

        private void panelIn_MouseUp(object sender, MouseEventArgs e)
        {
            ClickIsDown = false;
        }

        private void panelIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (ClickIsDown)
            {
                WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

                PoiSelected.X = a.locTop - ((e.Y - 9 + 15) * (a.locTop - a.locBottom) / MAX_MAP_HEIGHT);
                PoiSelected.Y = a.locLeft - ((e.X - 9 + 11) * (a.locLeft - a.locRight) / MAX_MAP_WIDTH);

                panelIn_Paint(null, null);
            }
        }

        private void txtNormalIcon_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.NormalIcon = Misc.ParseToUInt(txtNormalIcon.Text);

            panelIn_Paint(null, null);
        }

        private void barDestruct_Scroll(object sender, EventArgs e)
        {
            panelIn_Paint(null, null);
        }

        private void listFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelIn_Paint(null, null);
        }

        private void btnIcons_Click(object sender, EventArgs e)
        {
            Editors.POIsEditor.Icons d = new Editors.POIsEditor.Icons();
            d.Show();
        }
    }
}
