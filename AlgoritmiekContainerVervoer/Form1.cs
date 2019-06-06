using Logic;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoritmiekContainerVervoer
{
    public partial class Form1 : Form
    {
        public Ship Ship;
        public ShipLogic ShipLogic;
        public List<Container> Containers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Containers = new List<Container>();
            cbTypesContainer.SelectedIndex = -1;
            cbTypesContainer.DataSource = Enum.GetValues(typeof(Enums.TypOfContainers.Types));
            InfoShip.Visible = false;
            ConfigShip.Visible = true;
        }

        private void BtnSetShip_Click(object sender, EventArgs e)
        {
            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;

            InfoShip.Visible = true;
            ConfigShip.Visible = false;
            lblContainersWeight.Text = "0";
            btnAddContainer.Enabled = true;

            ShipLogic = new ShipLogic(width, length);
            lblLength.Text = length.ToString();
            lblWidth.Text = width.ToString();
            lblShipWeight.Text = ShipLogic.Ship.MaxWeight.ToString();
            //FillTestData();
            //lblCountUnsorted.Text = lbUnsortedContainers.Items.Count.ToString();
        }

        private void BtnAddContainer_Click(object sender, EventArgs e)
        {
            var weight = (int)nudContainerWeight.Value;
            var type = cbTypesContainer.SelectedValue.ToString();
            var container = new Container();
            if (type == "Cooled")
            {
                container = new Container(weight, false, true);
            }
            else if (type == "Valuable")
            {
                container = new Container(weight, true, false);
            }
            else
            {
                container = new Container(weight, false, false);
            }

            Containers.Add(container);
            lbUnsortedContainers.Items.Add(container);

            ShipLogic.Ship.Weight += container.Weight;
            lblContainersWeight.Text = ShipLogic.Ship.Weight.ToString();
            lblCountUnsorted.Text = lbUnsortedContainers.Items.Count.ToString();
            //TODO Check if containers weight > 50 % of ship weight
            if (ShipLogic.Ship.Weight / 2 <= ShipLogic.Ship.MaxWeight)
            {
                btnSort.Enabled = true;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            lbSortedContainers.Items.Clear();
            var ship = ShipLogic.SortContainers(Containers);

            for (int l = 0; l < ShipLogic.Ship.Length; l++)
            {
                for (int w = 0; w < ShipLogic.Ship.Width; w++)
                {
                    lbSortedContainers.Items.Add(l.ToString() + "." + w.ToString());
                    foreach (var container in ship.Stack[w, l].Containers)
                    {
                        lbSortedContainers.Items.Add(container);
                    }
                }
            }

            lbUnsortedContainers.Items.Clear();
            foreach (Container container in ShipLogic.UnSortedContainers)
            {
                lbUnsortedContainers.Items.Add(container);
            }

            lblCountUnsorted.Text = lbUnsortedContainers.Items.Count.ToString();
        }
    }
}