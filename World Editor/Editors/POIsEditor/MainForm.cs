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

            if (listMaps.SelectedItem == null)
                return;

            const int MAX_TEXTURE_SIZE = 256;
            const int MAX_MAP_WIDTH = 1002;
            const int MAX_MAP_HEIGHT = 668;

            WorldMapAreaEntry a = (WorldMapAreaEntry) listMaps.SelectedItem;

            int i = 1;
            for (int y = 0; y < 3; ++y)
                for (int x = 0; x < 4; ++x, ++i)
                    if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp"))
                        g.DrawImageUnscaled(Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + a.InternalName + i.ToString() + ".blp")), x * MAX_TEXTURE_SIZE, y * MAX_TEXTURE_SIZE);

            foreach (WorldMapOverlayEntry o in DBCStores.WorldMapOverlay.Records.Where(op => op.WorldMapAreaId == a.Id))
            {
                int nbX = Convert.ToInt32(Math.Ceiling((decimal)o.TextureWidth / MAX_TEXTURE_SIZE));
                int nbY = Convert.ToInt32(Math.Ceiling((decimal)o.TextureHeight / MAX_TEXTURE_SIZE));

                int index = 1;
                for (int y = 0; y < nbY; ++y)
                    for (int x = 0; x < nbX; ++x, ++index)
                        if (MPQFile.Exists("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp"))
                            g.DrawImageUnscaled(Blp2.FromStream(new MPQFile("Interface\\WorldMap\\" + a.InternalName + "\\" + o.TextureName + index.ToString() + ".blp")), (int)o.OffsetX + x * MAX_TEXTURE_SIZE, (int)o.OffsetY + y * MAX_TEXTURE_SIZE);
            }

            Bitmap icons = Blp2.FromStream(new MPQFile("Interface\\Minimap\\POIIcons.blp"));
            foreach (AreaPOIEntry poi in DBCStores.AreaPOI.Records.Where(poip => poip.ContinentId == a.MapId))
            {

                int iconY = (int)poi.NormalIcon / 16;
                int iconX = (int)poi.NormalIcon - iconY;
                g.DrawImage(icons, new Rectangle(Convert.ToInt32(((a.locLeft - poi.Y) * MAX_MAP_WIDTH / (a.locLeft - a.locRight)) - 11), Convert.ToInt32(((a.locTop - poi.X) * MAX_MAP_HEIGHT / (a.locTop - a.locBottom)) - 15), 18, 18), new Rectangle(iconX * 18, iconY * 18, 18, 18), GraphicsUnit.Pixel);
            }

            int end = System.Environment.TickCount;
            lblRenderTime.Text = (end - start).ToString() + " ms";
        }

        private void listMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelIn.Invalidate();
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

            listMaps.Items.Clear();
            listMaps.Items.AddRange(DBCStores.WorldMapArea.Records.ToArray());

            listMaps.SelectedIndex = 0;
        }
    }
}
