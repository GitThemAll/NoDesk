﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NoDesk
{
    public partial class Dashboard : Form
    {
		IncidentController incidentController = new IncidentController();
	    private List<Incident> incidents;
	    private List<Incident> solvedIncidents;
	    private List<Incident> notSolvedIncidents;
	    private List<Incident> pastIncidents;

		public Dashboard(User user)
	    {
		    InitializeComponent();
		    this.Text = string.Format("{0} {1} Dashboard", user.firstname, user.lastname);
		    this.incidents = incidentController.getAll();
		    this.pastIncidents = incidentController.getPastIncidents();
		    this.notSolvedIncidents = incidentController.getnotYetSolvedIncidents();
		    this.solvedIncidents = incidentController.getSolvedIncidents();

		    UnResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", notSolvedIncidents.Count, incidents.Count);
		    UnResolvedIncidentsProgressBar.Value = incidentController.notSolvedIncidentsPercentage;

		    PastIncidentsProgressBar.Text = string.Format("{0}/{1}", pastIncidents.Count, incidents.Count);
			PastIncidentsProgressBar.Value = incidentController.pastIncidentsPercentage;

			ResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", solvedIncidents.Count, incidents.Count);
			ResolvedIncidentsProgressBar.Value = incidentController.solvedIncidentsPercentage;

		}

	}
}
