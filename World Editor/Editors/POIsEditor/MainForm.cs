﻿using System;
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
        private uint NbLayerMap { get; set; }
        private Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        private Dictionary<uint, Bitmap> iconsPoi = new Dictionary<uint, Bitmap>();
        public static POIsEditor.MainForm m_poisEditor;
        private Graphics g;
        private bool ClickIsDown = false;
        private AreaPOIEntry PoiSelected;

        public MainForm()
        {
            InitializeComponent();
            this.g = panelIn.CreateGraphics();
        }

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
                Rectangle coordsMap = getBordersCoordinates();

                foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId))
                    if (iconsPoi.ContainsKey(poi.NormalIcon))
                    {
                        Point ptBase = new Point(
                            Convert.ToInt32(((coordsMap.Width + coordsMap.X - poi.Y) * MAX_MAP_WIDTH / coordsMap.Width) - 11),
                            Convert.ToInt32((coordsMap.Height + coordsMap.Y - poi.X) * MAX_MAP_HEIGHT / coordsMap.Height - 15));

                        g.DrawImage(iconsPoi[getIconPoiForDisplayOptions(poi)], new Rectangle(ptBase.X, ptBase.Y, 18, 18), new Rectangle(0, 0, 18, 18), GraphicsUnit.Pixel);
                        if (poi.Id == Misc.ParseToUInt(txtId.Text))
                            g.DrawImage(World_Editor.Properties.Resources.MiniArrow_Right, new Rectangle(ptBase.X - 16, ptBase.Y, 18, 18), new Rectangle(0, 0, 18, 18), GraphicsUnit.Pixel);
                        g.DrawImage(World_Editor.Properties.Resources.icon_delete_little, ptBase.X + 15, ptBase.Y - 3);
                    }
            }

            this.g.DrawImage(_bitmapTemp, 0, 0);
            _bitmapTemp.Dispose();
            _bitmapTemp = null;

            int end = System.Environment.TickCount;
            lblRenderTime.Text = (end - start).ToString() + " ms";
        }

        private void listMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWorldMapAreas.SelectedItem == null)
                return;

            images.Clear();

            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

            int i = 1;
            for (int y = 0; y < 3; ++y)
            {
                for (int x = 0; x < 4; ++x, ++i)
                {
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp"))
                    {
                        images.Add(a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp")));
                        NbLayerMap = 0;
                    }
                    else if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + "1_" + i.ToString() + ".blp"))
                    {
                        images.Add(a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + "1_" + i.ToString() + ".blp")));
                        // Boucle pour détecter le nombre d'étages de la map
                        for (uint index = 1; ; ++index)
                        {
                            if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + index.ToString() + "_" + i.ToString() + ".blp"))
                                NbLayerMap = index;
                            else
                                break;
                        }
                    }
                        
                }
            }

            if (NbLayerMap == 0)
            {
                numLayer.Enabled = false;
                numLayer.Minimum = 0;
                numLayer.Value = 0;
            }
            else if (NbLayerMap == 1)
            {
                numLayer.Enabled = false;
                numLayer.Value = 1;
            }
            else
            {
                numLayer.Enabled = true;
                numLayer.Minimum = 1;
                numLayer.Value = 1;
                numLayer.Maximum = NbLayerMap;
            }

            foreach (WorldMapOverlayEntry o in DBCStores.WorldMapOverlay.Records.Where(op => op.WorldMapAreaId == a.Id))
            {
                int nbX = Convert.ToInt32(Math.Ceiling((decimal)o.TextureWidth / MAX_TEXTURE_SIZE));
                int nbY = Convert.ToInt32(Math.Ceiling((decimal)o.TextureHeight / MAX_TEXTURE_SIZE));

                for (int index = 1; index <= nbX * nbY; ++index)
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"))
                            images.Add(a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp")));
            }

            RePaintMap();
        }

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
            for (uint y = 0; y <= 13; ++y)
                for (uint x = 0; x <= 13; ++x)
                    iconsPoi.Add(x + 14 * y, cropBitmap(icons, new Rectangle((int)x * 18, (int)y * 18, 18, 18)));

            if (iconsPoi.ContainsKey(0))
                iconsPoi.Remove(0);
            iconsPoi.Add(0, World_Editor.Properties.Resources.no_icon);

            listFaction.SelectedIndex = 0;
            listWorldMapAreas.SelectedIndex = 0;
        }

        private void panelIn_MouseClick(object sender, MouseEventArgs e)
        {

            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;
            Rectangle coordsMap = getBordersCoordinates();

            foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId).Reverse())
            {
                Point ptBase = new Point(
                    Convert.ToInt32(((coordsMap.Width + coordsMap.X - poi.Y) * MAX_MAP_WIDTH / coordsMap.Width) - 11),
                    Convert.ToInt32((coordsMap.Height + coordsMap.Y - poi.X) * MAX_MAP_HEIGHT / coordsMap.Height - 15));

                Rectangle rectIconDelete = new Rectangle(ptBase.X + 15, ptBase.Y - 3, 7, 7);

                if (rectIconDelete.Contains(e.Location))
                {
                    DBCStores.AreaPOI.RemoveEntry(poi.Id);

                    RePaintMap();

                    return;
                }

                Rectangle rectIcon = new Rectangle(ptBase.X, ptBase.Y, 20, 20);

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

                    panelIn_Paint(null, null);

                    return;
                }
            }

            // Si on arrive ici c'est que le clic ne correspond à aucun emplacement de poi
            AreaPOIEntry newPoi = new AreaPOIEntry
            {
                Id = DBCStores.AreaPOI.MaxKey + 1,
                NormalIcon = (Editors.POIsEditor.Icons.m_poisIconsEditor == null) ? 45 : (uint)Editors.POIsEditor.Icons.IconIdSelected,
                X = coordsMap.Height + coordsMap.Y - (e.Y + 15) * coordsMap.Height / MAX_MAP_HEIGHT,
                Y = coordsMap.Width + coordsMap.X - (e.X + 11 - 9) * coordsMap.Width / MAX_MAP_WIDTH,
                ContinentId = a.MapId,
                Name = "Nouveau point d'intérêt",
                Description = "",
            };
            DBCStores.AreaPOI.AddEntry(newPoi.Id, newPoi);

            RePaintMap();
        }

        private void panelIn_MouseDown(object sender, MouseEventArgs e)
        {
            
            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;
            Rectangle coordsMap = getBordersCoordinates();

            foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => coordsMap.Contains(new Point((int)poip.Y, (int)poip.X)) && poip.ContinentId == a.MapId).Reverse())
            {
                Point ptBase = new Point(
                    Convert.ToInt32(((coordsMap.Width + coordsMap.X - poi.Y) * MAX_MAP_WIDTH / coordsMap.Width) - 11),
                    Convert.ToInt32((coordsMap.Height + coordsMap.Y - poi.X) * MAX_MAP_HEIGHT / coordsMap.Height - 15));

                Rectangle rectIcon = new Rectangle(ptBase.X, ptBase.Y, 20, 20);

                if (rectIcon.Contains(e.Location))
                {
                    ClickIsDown = true;
                    PoiSelected = poi;
                    return;
                }
            }
        }

        private void numLayer_ValueChanged(object sender, EventArgs e)
        {
            if (listWorldMapAreas.SelectedItem == null || numLayer.Value == 0)
                return;

            images.Clear();

            WorldMapAreaEntry a = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

            int i = 1;
            for (int y = 0; y < 3; ++y)
            {
                for (int x = 0; x < 4; ++x, ++i)
                {
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + numLayer.Value + "_" + i.ToString() + ".blp"))
                    {
                        images.Add(a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + numLayer.Value + "_" + i.ToString() + ".blp")));
                    }

                }
            }

            foreach (WorldMapOverlayEntry o in DBCStores.WorldMapOverlay.Records.Where(op => op.WorldMapAreaId == a.Id))
            {
                int nbX = Convert.ToInt32(Math.Ceiling((decimal)o.TextureWidth / MAX_TEXTURE_SIZE));
                int nbY = Convert.ToInt32(Math.Ceiling((decimal)o.TextureHeight / MAX_TEXTURE_SIZE));

                for (int index = 1; index <= nbX * nbY; ++index)
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"))
                        images.Add(a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp", Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp")));
            }

            RePaintMap();
        }

        /// <summary>
        /// Permet de retourner sous forme de rectangle, les coordonnées de la worldMap par rapport à la map réelle.
        /// Utilisé pour le scaling des coordonnées.
        /// </summary>
        /// <param name="worldMapArea">WorldMapArea à utiliser, si aucune, utilise celle séléctionnée dans la listWorldMapAreas</param>
        /// <returns></returns>
        private Rectangle getBordersCoordinates(WorldMapAreaEntry worldMapArea = null)
        {
            if (worldMapArea == null)
                worldMapArea = (WorldMapAreaEntry)listWorldMapAreas.SelectedItem;

            if (NbLayerMap == 0)
            {
                return new Rectangle((int)worldMapArea.locRight, (int)worldMapArea.locBottom, (int)worldMapArea.locLeft - (int)worldMapArea.locRight, (int)worldMapArea.locTop - (int)worldMapArea.locBottom);
            }
            else
            {
                DungeonMapEntry d = DBCStores.DungeonMap.Records.First(dp => dp.Map == worldMapArea.MapId && dp.Layer == NbLayerMap);
                //                              x1                     y1                             x2 - x1                                        y2 - y1
                return new Rectangle((int)d.Coordonates[0], (int)d.Coordonates[2], (int)d.Coordonates[1] - (int)d.Coordonates[0], (int)d.Coordonates[3] - (int)d.Coordonates[2]);
            }
        }

        /// <summary>
        /// Permet de récupérer l'icône d'un POI à afficher en fonction des paramètres d'affichage (Alliance/Horde/Neutre & 100%/50%/0%)
        /// </summary>
        /// <param name="poi"></param>
        /// <returns></returns>
        private uint getIconPoiForDisplayOptions(AreaPOIEntry poi)
        {
            if (listFaction.SelectedIndex == 1)
                if (barDestruct.Value == 1)
                    return poi.HordeIcon50p;
                else if (barDestruct.Value == 0)
                    return poi.HordeIcon0p;
                else
                    return poi.HordeIcon;
            else if (listFaction.SelectedIndex == 2)
                if (barDestruct.Value == 1)
                    return poi.AllianceIcon50p;
                else if (barDestruct.Value == 0)
                    return poi.AllianceIcon0p;
                else
                    return poi.AllianceIcon;
            else
                if (barDestruct.Value == 1)
                    return poi.NormalIcon50p;
                else if (barDestruct.Value == 0)
                    return poi.NormalIcon0p;
                else
                    return poi.NormalIcon;
        }

        /// <summary>
        /// Permet de repeindre la map par dessus celle existante
        /// </summary>
        private void RePaintMap()
        {
            panelIn_Paint(null, null);
        }

        #region Useless
        private void barDestruct_Scroll(object sender, EventArgs e)
        {
            RePaintMap();
        }

        private void listFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            RePaintMap();
        }

        private void btnIcons_Click(object sender, EventArgs e)
        {
            if (Editors.POIsEditor.Icons.m_poisIconsEditor == null)
            {
                Editors.POIsEditor.Icons d = new Editors.POIsEditor.Icons();
                Editors.POIsEditor.Icons.m_poisIconsEditor = d;
                d.Show(this);
            }
            else
            {
                Editors.POIsEditor.Icons d = Editors.POIsEditor.Icons.m_poisIconsEditor;
                d.BringToFront();
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
                Rectangle coordsMap = getBordersCoordinates();

                PoiSelected.X = coordsMap.Height + coordsMap.Y - (e.Y + 15) * coordsMap.Height / MAX_MAP_HEIGHT;
                PoiSelected.Y = coordsMap.Width + coordsMap.X - (e.X + 11 - 9) * coordsMap.Width / MAX_MAP_WIDTH;

                RePaintMap();
            }
        }

        private static Bitmap cropBitmap(Bitmap img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return bmpCrop;
        }

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
        #endregion

        #region TxtChanged
        private void txtNormalIcon_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.NormalIcon = Misc.ParseToUInt(txtNormalIcon.Text);

            RePaintMap();
        }
        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Description = txtDescription.Text;
        }

        private void txtNormalIcon50_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.NormalIcon50p = Misc.ParseToUInt(txtNormalIcon50.Text);
        }

        private void txtNormalIcon0_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.NormalIcon0p = Misc.ParseToUInt(txtNormalIcon0.Text);
        }

        private void txtHordeIcon_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.HordeIcon = Misc.ParseToUInt(txtHordeIcon.Text);
        }

        private void txtHordeIcon50_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.HordeIcon50p = Misc.ParseToUInt(txtHordeIcon50.Text);
        }

        private void txtHordeIcon0_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.HordeIcon0p = Misc.ParseToUInt(txtHordeIcon0.Text);
        }

        private void txtAllianceIcon_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.AllianceIcon = Misc.ParseToUInt(txtAllianceIcon.Text);
        }

        private void txtAllianceIcon50_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.AllianceIcon50p = Misc.ParseToUInt(txtAllianceIcon50.Text);
        }

        private void txtAllianceIcon0_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.AllianceIcon0p = Misc.ParseToUInt(txtAllianceIcon0.Text);
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.X = Misc.ParseToFloat(txtX.Text);

            RePaintMap();
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Y = Misc.ParseToFloat(txtY.Text);

            RePaintMap();
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Z = Misc.ParseToFloat(txtZ.Text);
        }

        private void txtContinentId_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.ContinentId = Misc.ParseToUInt(txtContinentId.Text);
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Area = Misc.ParseToUInt(txtArea.Text);
        }

        private void txtImportance_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Importance = Misc.ParseToUInt(txtImportance.Text);
        }

        private void txtFactionId_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.FactionId = Misc.ParseToUInt(txtFactionId.Text);
        }

        private void txtWorldState_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.WorldState = Misc.ParseToUInt(txtWorldState.Text);
        }

        private void txtFlags_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.Flags = Misc.ParseToUInt(txtFlags.Text);
        }

        private void txtWorldMapLink_TextChanged(object sender, EventArgs e)
        {
            if (!DBCStores.AreaPOI.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            AreaPOIEntry p = DBCStores.AreaPOI[Misc.ParseToUInt(txtId.Text)];
            p.WorldMapLink = Misc.ParseToUInt(txtWorldMapLink.Text);
        }
    }
}
