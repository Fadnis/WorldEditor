using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.FactionsEditor
{
    public partial class MainForm : Form
    {
        #region Enums
        enum FlagFactionTemplateEnums
        {
            FLAG_UNK1               = 1,
            FLAG_UNK2               = 2,
            FLAG_UNK3               = 4,
            FLAG_UNK4               = 8,
            FLAG_UNK5               = 16,
            FLAG_UNK6               = 32,
            FLAG_UNK7               = 64,
            FLAG_UNK8               = 128,
            FLAG_UNK9               = 256,
            FLAG_UNK10              = 512,
            FLAG_UNK11              = 1024,
            FLAG_PVP                = 2048,     // flagged for PvP
            FLAG_CONTESTED_GUARD    = 4096,     // faction will attack players that were involved in PvP combats
            FLAG_HOSTILE_BY_DEFAULT = 8192,
        }

        enum FactionFlagsEnums
        {
            FLAG_VISIBLE            = 1,        // makes visible in client (set or can be set at interaction with target of this faction)
            FLAG_AT_WAR             = 2,        // enable AtWar-button in client. player controlled (except opposition team always war state), Flag only set on initial creation
            FLAG_HIDDEN             = 4,        // hidden faction from reputation pane in client (player can gain reputation, but this update not sent to client)
            FLAG_INVISIBLE_FORCED   = 8,        // always overwrite FACTION_FLAG_VISIBLE and hide faction in rep.list, used for hide opposite team factions
            FLAG_PEACE_FORCED       = 16,       // always overwrite FACTION_FLAG_AT_WAR, used for prevent war with own team factions
            FLAG_INACTIVE           = 32,       // player controlled, state stored in characters.data ( CMSG_SET_FACTION_INACTIVE )
            FLAG_RIVAL              = 64,       // flag for the two competing outland factions
            FLAG_TEAM_REPUTATION    = 128,      // faction has own reputation standing despite teaming up sub-factions; spillover from subfactions will go this instead of other subfactions
            FLAG_UNK1               = 256,
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadFactionsEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du chargement des DBCs");
                this.Close();
            }

            listFactions.Items.Clear();
            foreach (FactionEntry f in DBCStores.Faction.Records)
                listFactions.Items.Add(f);

            listFactions.SelectedIndex = 0;
        }

        private void listFactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            txtFactionId.Text = f.Id.ToString();
            txtFactionName.Text = f.Name;
            txtFactionDescription.Text = f.Description;
            txtFactionParentId.Text = f.ParentFactionId.ToString();
            txtSpilloverRateOut.Text = f.SpilloverRateOut.ToString();
            txtSpilloverRateIn.Text = f.SpilloverRateIn.ToString();
            txtSpilloverMaxRkIn.Text = f.SpilloverMaxRankIn.ToString();
            txtSpilloverUnk.Text = f.SpilloverRankUnk.ToString();

            txtRace0.Text = f.BaseRepRaceMask[0].ToString();
            txtClass0.Text = f.BaseRepClassMask[0].ToString();
            txtBaseRep0.Text = f.BaseRepValue[0].ToString();
            txtOptions0.Text = f.ReputationFlags[0].ToString();

            txtRace1.Text = f.BaseRepRaceMask[1].ToString();
            txtClass1.Text = f.BaseRepClassMask[1].ToString();
            txtBaseRep1.Text = f.BaseRepValue[1].ToString();
            txtOptions1.Text = f.ReputationFlags[1].ToString();

            txtRace2.Text = f.BaseRepRaceMask[2].ToString();
            txtClass2.Text = f.BaseRepClassMask[2].ToString();
            txtBaseRep2.Text = f.BaseRepValue[2].ToString();
            txtOptions2.Text = f.ReputationFlags[2].ToString();

            txtRace3.Text = f.BaseRepRaceMask[3].ToString();
            txtClass3.Text = f.BaseRepClassMask[3].ToString();
            txtBaseRep3.Text = f.BaseRepValue[3].ToString();
            txtOptions3.Text = f.ReputationFlags[3].ToString();

            var factionTemplateList = DBCStores.FactionTemplate.Records.Where(ft => ft.Faction == f.Id);
            listFactionTemplate.Items.Clear();
            foreach (FactionTemplateEntry ft in factionTemplateList)
                listFactionTemplate.Items.Add(ft);

            if (listFactionTemplate.Items.Count > 0)
                listFactionTemplate.SelectedIndex = 0;
        }

        private void listFactionTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            txtFactionTemplateId.Text = f.Id.ToString();
            txtFactionTemplateFaction.Text = f.Faction.ToString();
            txtFactionTemplateFlags.Text = f.FactionFlags.ToString();
            txtFactGrp.Text = f.OurMask.ToString();
            txtEnyGrp.Text = f.HostileMask.ToString();
            txtFriendGrp.Text = f.FriendlyMask.ToString();

            txtEnemy0.Text = f.EnemyFaction[0].ToString();
            txtEnemy1.Text = f.EnemyFaction[1].ToString();
            txtEnemy2.Text = f.EnemyFaction[2].ToString();
            txtEnemy3.Text = f.EnemyFaction[3].ToString();

            txtFriend0.Text = f.FriendFaction[0].ToString();
            txtFriend1.Text = f.FriendFaction[1].ToString();
            txtFriend2.Text = f.FriendFaction[2].ToString();
            txtFriend3.Text = f.FriendFaction[3].ToString();
        }        

        #region Ajout/Suppression FactionTemplate
        private void btnFctTplAdd_Click(object sender, EventArgs e)
        {
            FactionTemplateEntry f = new FactionTemplateEntry
            {
                Id = DBCStores.FactionTemplate.MaxKey + 1,
                Faction = UInt32.Parse(txtFactionId.Text),
                FriendFaction = new uint[4] { 0, 0, 0, 0 },
                EnemyFaction = new uint[4] { 0, 0, 0, 0 },
            };

            listFactionTemplate.Items.Add(f);
            DBCStores.FactionTemplate.AddEntry(f.Id, f);

            listFactionTemplate.SelectedIndex = listFactionTemplate.Items.Count - 1;
        }

        private void btnFactTplRemove_Click(object sender, EventArgs e)
        {
            try
            {
                FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

                --listFactionTemplate.SelectedIndex;

                listFactionTemplate.Items.Remove(f);
                DBCStores.FactionTemplate.RemoveEntry(f.Id);
            }
            catch (Exception) { }
        }
        #endregion

        #region Ajout/Suppression Faction
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FactionTemplateEntry ft = new FactionTemplateEntry
            {
                Id = DBCStores.FactionTemplate.MaxKey + 1,
                Faction = DBCStores.Faction.MaxKey + 1,
                FriendFaction = new uint[4] { 0, 0, 0, 0 },
                EnemyFaction = new uint[4] { 0, 0, 0, 0 },
            };
            DBCStores.FactionTemplate.AddEntry(ft.Id, ft);

            FactionEntry f = new FactionEntry
            {
                Id = DBCStores.Faction.MaxKey + 1,
                ReputationListId = DBCStores.Faction.Records.Max(p => p.ReputationListId),
                BaseRepRaceMask = new uint[] { 0, 0, 0, 0 },
                BaseRepClassMask = new uint[] { 0, 0, 0, 0 },
                BaseRepValue = new int[] { 0, 0, 0, 0 },
                ReputationFlags = new uint[] { 0, 0, 0, 0 },
                Name = "Nouvelle faction",
                Description = "",
            };

            listFactions.Items.Add(f);
            DBCStores.Faction.AddEntry(f.Id, f);

            listFactions.SelectedIndex = listFactions.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];
                FactionTemplateEntry[] fts = DBCStores.FactionTemplate.Records.Where(ft => ft.Faction == f.Id).ToArray();

                foreach (FactionTemplateEntry ft in fts)
                    DBCStores.FactionTemplate.RemoveEntry(ft.Id);

                --listFactions.SelectedIndex;

                listFactions.Items.Remove(f);
                DBCStores.Faction.RemoveEntry(f.Id);
            }
            catch (Exception) { }
        }
        #endregion

        #region TextChanged FactionTemplate
        private void txtEnemy0_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.EnemyFaction[0] = ParseToUInt(txtEnemy0.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtEnemy0.Text)))
                lblEnemy0.Text = DBCStores.Faction[ParseToUInt(txtEnemy0.Text)].Name;
            else
                lblEnemy0.Text = "";
        }

        private void txtEnemy1_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.EnemyFaction[1] = ParseToUInt(txtEnemy1.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtEnemy1.Text)))
                lblEnemy1.Text = DBCStores.Faction[ParseToUInt(txtEnemy1.Text)].Name;
            else
                lblEnemy1.Text = "";
        }

        private void txtEnemy2_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.EnemyFaction[2] = ParseToUInt(txtEnemy2.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtEnemy2.Text)))
                lblEnemy2.Text = DBCStores.Faction[ParseToUInt(txtEnemy2.Text)].Name;
            else
                lblEnemy2.Text = "";
        }

        private void txtEnemy3_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.EnemyFaction[3] = ParseToUInt(txtEnemy3.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtEnemy3.Text)))
                lblEnemy3.Text = DBCStores.Faction[ParseToUInt(txtEnemy3.Text)].Name;
            else
                lblEnemy3.Text = "";
        }

        private void txtFriend0_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FriendFaction[0] = ParseToUInt(txtFriend0.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtFriend0.Text)))
                lblFriend0.Text = DBCStores.Faction[ParseToUInt(txtFriend0.Text)].Name;
            else
                lblFriend0.Text = "";
        }

        private void txtFriend1_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FriendFaction[1] = ParseToUInt(txtFriend1.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtFriend1.Text)))
                lblFriend1.Text = DBCStores.Faction[ParseToUInt(txtFriend1.Text)].Name;
            else
                lblFriend1.Text = "";
        }

        private void txtFriend2_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FriendFaction[2] = ParseToUInt(txtFriend2.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtFriend2.Text)))
                lblFriend2.Text = DBCStores.Faction[ParseToUInt(txtFriend2.Text)].Name;
            else
                lblFriend2.Text = "";
        }

        private void txtFriend3_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FriendFaction[3] = ParseToUInt(txtFriend3.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);

            if (DBCStores.Faction.ContainsKey(ParseToUInt(txtFriend3.Text)))
                lblFriend3.Text = DBCStores.Faction[ParseToUInt(txtFriend3.Text)].Name;
            else
                lblFriend3.Text = "";
        }

        private void txtFactionTemplateFlags_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FactionFlags = ParseToUInt(txtFactionTemplateFlags.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);
        }

        private void txtFactGrp_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.OurMask = ParseToUInt(txtFactGrp.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);
        }

        private void txtFriendGrp_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.FriendlyMask = ParseToUInt(txtFriendGrp.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);
        }

        private void txtEnyGrp_TextChanged(object sender, EventArgs e)
        {
            if (listFactionTemplate.SelectedIndex == -1)
                return;

            FactionTemplateEntry f = (FactionTemplateEntry)listFactionTemplate.Items[listFactionTemplate.SelectedIndex];

            f.HostileMask = ParseToUInt(txtEnyGrp.Text);

            listFactionTemplate.Items[listFactionTemplate.SelectedIndex] = f;
            DBCStores.FactionTemplate.ReplaceEntry(f.Id, f);
        }
        #endregion

        #region TextChanged Faction
        private void txtFactionName_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.Name = txtFactionName.Text;

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtFactionDescription_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.Description = txtFactionDescription.Text;

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtFactionParentId_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.ParentFactionId = ParseToUInt(txtFactionParentId.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtSpilloverRateOut_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.SpilloverRateOut = ParseToFloat(txtSpilloverRateOut.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtSpilloverRateIn_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.SpilloverRateIn = ParseToFloat(txtSpilloverRateIn.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtSpilloverMaxRkIn_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.SpilloverMaxRankIn = ParseToUInt(txtSpilloverMaxRkIn.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtSpilloverUnk_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.SpilloverRankUnk = ParseToUInt(txtSpilloverUnk.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtRace0_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepRaceMask[0] = ParseToUInt(txtRace0.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtRace1_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepRaceMask[1] = ParseToUInt(txtRace1.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtRace2_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepRaceMask[2] = ParseToUInt(txtRace2.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtRace3_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepRaceMask[3] = ParseToUInt(txtRace3.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtClass0_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepClassMask[0] = ParseToUInt(txtClass0.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtClass1_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepClassMask[1] = ParseToUInt(txtClass1.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtClass2_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepClassMask[2] = ParseToUInt(txtClass2.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtClass3_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepClassMask[3] = ParseToUInt(txtClass3.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtBaseRep0_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepValue[0] = ParseToInt(txtBaseRep0.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtBaseRep1_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepValue[1] = ParseToInt(txtBaseRep1.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtBaseRep2_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepValue[2] = ParseToInt(txtBaseRep2.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtBaseRep3_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.BaseRepValue[3] = ParseToInt(txtBaseRep3.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtOptions0_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.ReputationFlags[0] = ParseToUInt(txtOptions0.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtOptions1_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.ReputationFlags[1] = ParseToUInt(txtOptions1.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtOptions2_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.ReputationFlags[2] = ParseToUInt(txtOptions2.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }

        private void txtOptions3_TextChanged(object sender, EventArgs e)
        {
            if (listFactions.SelectedIndex == -1)
                return;

            FactionEntry f = (FactionEntry)listFactions.Items[listFactions.SelectedIndex];

            f.ReputationFlags[3] = ParseToUInt(txtOptions3.Text);

            listFactions.Items[listFactions.SelectedIndex] = f;
            DBCStores.Faction.ReplaceEntry(f.Id, f);
        }
        #endregion

        #region Tab Opérations sur factions
        private void btnRaceMaskOld_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRaceMaskOld.Text);
            d.ShowDialog();
            txtRaceMaskOld.Text = d.MaskRacesValue.ToString();
        }

        private void btnRaceMaskNew_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRaceMaskNew.Text);
            d.ShowDialog();
            txtRaceMaskNew.Text = d.MaskRacesValue.ToString();
        }

        private void btnReplaceRaceMask_Click(object sender, EventArgs e)
        {
            uint oldMaskRace;
            uint newMaskRace;
            if (UInt32.TryParse(txtRaceMaskOld.Text, out oldMaskRace) && UInt32.TryParse(txtRaceMaskNew.Text, out newMaskRace))
                foreach (FactionEntry f in DBCStores.Faction.Records)
                    for (uint i = 0; i < 4; ++i)
                        if (f.BaseRepRaceMask[i] == oldMaskRace)
                            f.BaseRepRaceMask[i] = newMaskRace;

            listFactions.Items.Clear();

            foreach (FactionEntry f in DBCStores.Faction.Records)
                listFactions.Items.Add(f);

            listFactions.SelectedIndex = 0;
        }

        private void btnClassMaskOld_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClassMaskOld.Text);
            d.ShowDialog();
            txtClassMaskOld.Text = d.MaskClassesValue.ToString();
        }

        private void btnClassMaskNew_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClassMaskNew.Text);
            d.ShowDialog();
            txtClassMaskNew.Text = d.MaskClassesValue.ToString();
        }

        private void btnReplaceClassMask_Click(object sender, EventArgs e)
        {
            uint oldMaskClass;
            uint newMaskClass;
            if (UInt32.TryParse(txtClassMaskOld.Text, out oldMaskClass) && UInt32.TryParse(txtClassMaskNew.Text, out newMaskClass))
                foreach (FactionEntry f in DBCStores.Faction.Records)
                    for (uint i = 0; i < 4; ++i)
                        if (f.BaseRepClassMask[i] == oldMaskClass)
                            f.BaseRepClassMask[i] = newMaskClass;

            listFactions.Items.Clear();

            foreach (FactionEntry f in DBCStores.Faction.Records)
                listFactions.Items.Add(f);

            listFactions.SelectedIndex = 0;
        }

        private void btnGroupMaskOld_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(ParseToUInt(txtGroupMaskOld.Text));
            d.ShowDialog();
            txtGroupMaskOld.Text = d.BitMask.ToString();
        }

        private void btnGroupMaskNew_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(ParseToUInt(txtGroupMaskNew.Text));
            d.ShowDialog();
            txtGroupMaskNew.Text = d.BitMask.ToString();
        }

        private void btnReplaceGroupMask_Click(object sender, EventArgs e)
        {
            uint oldGroupMask;
            uint newGroupMask;
            if (UInt32.TryParse(txtGroupMaskOld.Text, out oldGroupMask) && UInt32.TryParse(txtGroupMaskNew.Text, out newGroupMask))
                foreach (FactionTemplateEntry f in DBCStores.FactionTemplate.Records)
                    if (rbFaction.Checked)
                        if (f.OurMask == oldGroupMask)
                            f.OurMask = newGroupMask;
                        else if (rbFriend.Checked)
                            if (f.FriendlyMask == oldGroupMask)
                                f.FriendlyMask = newGroupMask;
                            else if (rbEnemy.Checked)
                                if (f.HostileMask == oldGroupMask)
                                    f.HostileMask = newGroupMask;
        }
        #endregion


        #region Ouvertures Dialogs
        // FactionGroup
        private void btnGroupsEditor_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsEditor d = new Dialogs.FactionGroupsEditor();
            d.ShowDialog();
        }

        // FactionTemplate
        private void btnFctTplFacMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(ParseToUInt(txtFactGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFactGrp.Text = d.BitMask.ToString();
        }

        private void btnFctTplFrMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(ParseToUInt(txtFriendGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFriendGrp.Text = d.BitMask.ToString();
        }

        private void btnFctTplEnyMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(ParseToUInt(txtEnyGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtEnyGrp.Text = d.BitMask.ToString();
        }

        private void btnFctTplFlags_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.FlagDialog d = new World_Editor.Dialogs.FlagDialog(typeof(FlagFactionTemplateEnums), ParseToUInt(txtFactionTemplateFlags.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFactionTemplateFlags.Text = d.bitmask.ToString();
        }

        // Faction
        private void btnHelpRace0_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRace0.Text);
            d.ShowDialog();
            txtRace0.Text = d.MaskRacesValue.ToString();
        }

        private void btnHelpRace1_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRace1.Text);
            d.ShowDialog();
            txtRace1.Text = d.MaskRacesValue.ToString();
        }

        private void btnHelpRace2_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRace2.Text);
            d.ShowDialog();
            txtRace2.Text = d.MaskRacesValue.ToString();
        }

        private void btnHelpRace3_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRace3.Text);
            d.ShowDialog();
            txtRace3.Text = d.MaskRacesValue.ToString();
        }

        private void btnHelpClass0_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClass0.Text);
            d.ShowDialog();
            txtClass0.Text = d.MaskClassesValue.ToString();
        }

        private void btnHelpClass1_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClass1.Text);
            d.ShowDialog();
            txtClass1.Text = d.MaskClassesValue.ToString();
        }

        private void btnHelpClass2_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClass2.Text);
            d.ShowDialog();
            txtClass2.Text = d.MaskClassesValue.ToString();
        }

        private void btnHelpClass3_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClass3.Text);
            d.ShowDialog();
            txtClass3.Text = d.MaskClassesValue.ToString();
        }

        private void btnHelpFactionFlags0_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.FlagDialog d = new World_Editor.Dialogs.FlagDialog(typeof(FactionFlagsEnums), ParseToUInt(txtOptions0.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtOptions0.Text = d.bitmask.ToString();
        }

        private void btnHelpFactionFlags1_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.FlagDialog d = new World_Editor.Dialogs.FlagDialog(typeof(FactionFlagsEnums), ParseToUInt(txtOptions1.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtOptions1.Text = d.bitmask.ToString();
        }

        private void btnHelpFactionFlags2_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.FlagDialog d = new World_Editor.Dialogs.FlagDialog(typeof(FactionFlagsEnums), ParseToUInt(txtOptions2.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtOptions2.Text = d.bitmask.ToString();
        }

        private void btnHelpFactionFlags3_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.FlagDialog d = new World_Editor.Dialogs.FlagDialog(typeof(FactionFlagsEnums), ParseToUInt(txtOptions3.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtOptions3.Text = d.bitmask.ToString();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveFactionsEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde des fichiers DBCs : " + ex.Message);
            }
        }

        private uint ParseToUInt(string value)
        {
            uint tmp;
            UInt32.TryParse(value, out tmp);
            return tmp;
        }

        private int ParseToInt(string value)
        {
            int tmp;
            Int32.TryParse(value, out tmp);
            return tmp;
        }

        private float ParseToFloat(string value)
        {
            float tmp;
            float.TryParse(value, out tmp);
            return tmp;
        }
    }
}
