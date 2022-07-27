﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            loadExistingTorunamentDropDown.DataSource = tournaments;
            loadExistingTorunamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            if (loadExistingTorunamentDropDown.SelectedItem != null)
            {
                TournamentModel tm = (TournamentModel)loadExistingTorunamentDropDown.SelectedItem;
                TournamentViewerForm frm = new TournamentViewerForm(tm);
                frm.Show();
            }
            else
            {
                return;
            }
        }

        private void loadExistingTorunamentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
