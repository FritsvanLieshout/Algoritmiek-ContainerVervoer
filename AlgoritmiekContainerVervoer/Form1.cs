using Logic;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoritmiekContainerVervoer
{
    public partial class Form1 : Form
    {
        ShipLogic SL;
        List<Container> Containers;
        public Form1()
        {
            Containers = new List<Container>
            {
                new Container(4000, false, false),
                new Container(8000, false, false),
                new Container(4000, true, true),
                new Container(6400, false, true),
                new Container(4000, false, false),
                new Container(5600, true, false),
                new Container(6000, false, false),
                new Container(4000, false, true),
                new Container(25000, true, true),
                new Container(4000, false, false),
                new Container(11630, false, false),
                new Container(4000, false, true),
                new Container(3250, true, false),
                new Container(20000, false, false),
                new Container(4000, false, false),
                new Container(8000, false, false),
                new Container(4000, true, true),
                new Container(6400, false, true),
                new Container(4000, false, false),
                new Container(5600, true, false),
                new Container(6000, false, false),
                new Container(4000, false, true),
                new Container(25000, true, true),
                new Container(4000, false, false),
                new Container(11630, false, false),
                new Container(4000, false, true),
                new Container(3250, true, false),
                new Container(20000, false, false),
                new Container(4000, false, false),
                new Container(8000, false, false),
                new Container(4000, true, true),
                new Container(6400, false, true),
                new Container(4000, false, false),
                new Container(5600, true, false),
                new Container(6000, false, false),
                new Container(4000, false, true),
                new Container(25000, true, true),
                new Container(4000, false, false),
                new Container(11630, false, false),
                new Container(4000, false, true),
                new Container(3250, true, false),
                new Container(20000, false, false),
                new Container(4000, false, false),
                new Container(8000, false, false),
                new Container(4000, true, true),
                new Container(6400, false, true),
                new Container(4000, false, false),
                new Container(5600, true, false),
                new Container(6000, false, false),
                new Container(4000, false, true),
                new Container(25000, true, true),
                new Container(4000, false, false),
                new Container(11630, false, false),
                new Container(4000, false, true),
                new Container(3250, true, false),
                new Container(20000, false, false),
                new Container(4000, false, false),
                new Container(8000, false, false),
                new Container(4000, true, true),
                new Container(6400, false, true),
                new Container(4000, false, false),
                new Container(5600, true, false),
                new Container(6000, false, false),
                new Container(4000, false, true),
                new Container(25000, true, true),
                new Container(4000, false, false),
                new Container(11630, false, false),
                new Container(4000, false, true),
                new Container(3250, true, false),
                new Container(20000, false, false)
            };

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTypesContainer.SelectedIndex = -1;
            cbTypesContainer.DataSource = Enum.GetValues(typeof(Enums.TypOfContainers.Types));
            InfoShip.Visible = false;
            ConfigShip.Visible = true;

            btnSort.Enabled = true;

        }

        private void BtnSetShip_Click(object sender, EventArgs e)
        {
            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;

            InfoShip.Visible = true;
            ConfigShip.Visible = false;
            lblLength.Text = length.ToString();
            lblWidth.Text = width.ToString();
            lblCount.Text = "";
            btnAddContainer.Enabled = true;
        }

        private void BtnAddContainer_Click(object sender, EventArgs e)
        {
            //var container = new Container();
            //var weight = (int)nudContainerWeight.Value;
            //var type = cbTypesContainer.SelectedValue.ToString();

            //if (type == "Cooled")
            //{
            //    container = new Container(weight, true, false);
            //}

            //else if (type == "Valuable")
            //{
            //    container = new Container(weight, false, true);
            //}

            //else
            //{
            //    container = new Container(weight, false, false);
            //}

            //Containers.Add(container);
            //lbContainers.Items.Add(container);
            //lblCount.Text = Containers.Count.ToString();
            ////enable button if value > 50%?
            //btnSort.Enabled = true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;

            var logic = new ShipLogic(width, length);
            logic.SortContainers(Containers);

            var output = Containers;
            foreach (var container in output)
            {
                lbSortedContainers.Items.Add(container);
            }
        }
    }
}
