﻿using System.Windows;
using System.Windows.Controls;
using System.Data;
using Highway.Models;
using System.Windows.Input;
using System;

namespace Highway
{
    /// <summary>
    /// Interaction logic for HighwayTable.xaml
    /// </summary>
    public partial class HighwayTable : UserControl
    {
        readonly UpdateTable updateTable;
        private const uint countColumns = 7;
        public HighwayTable()
        {
            InitializeComponent();
            updateTable = new UpdateTable();
            UpdateTable.HighWaysFill += onTableUpdate;
        }

        private void onTableUpdate(HighwayList list)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("№", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Type", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Length", typeof(uint)));
            dataTable.Columns.Add(new DataColumn("Lanes", typeof(uint)));
            dataTable.Columns.Add(new DataColumn("Banquette", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Divider", typeof(string)));

            DataRow rows;
            HighWay highway;
            for (int i = 0; i < list.highwaysList.Count; ++i)
            {
                rows = dataTable.NewRow();
                highway = list[i];
                rows[0] = i + 1;
                rows[1] = highway.NameHighway;
                rows[2] = highway.RoadType;
                rows[3] = highway.RoadLength;
                rows[4] = highway.NumberLanes;
                rows[5] = highway.Banquette;
                rows[6] = highway.RoadDivider;
                dataTable.Rows.Add(rows);
            }
            RoadTable.ItemsSource = dataTable.DefaultView;
            foreach (var column in RoadTable.Columns)
            {
                column.IsReadOnly = true;
                column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
            RoadTable.CanUserAddRows = false;
            RoadTable.CanUserDeleteRows = false;    
        }
    }
}