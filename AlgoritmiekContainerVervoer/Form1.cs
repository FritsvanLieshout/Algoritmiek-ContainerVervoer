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
            TestData();
           // lbContainers.DataSource = Containers;
            cbTypesContainer.SelectedIndex = -1;
            cbTypesContainer.DataSource = Enum.GetValues(typeof(Enums.TypOfContainers.Types));
            InfoShip.Visible = false;
            ConfigShip.Visible = true;
            ShipLogic = new ShipLogic(5, 10);
            lbContainers.DataSource = ShipLogic.UnSortedContainers;
            //totalweight of containers
            if (600000 >= (Ship.Weight / 2))
            {
                btnSort.Enabled = true;
            }

        }

        private void BtnSetShip_Click(object sender, EventArgs e)
        {
            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;

            InfoShip.Visible = true;
            ConfigShip.Visible = false;
            lblLength.Text = length.ToString();
            lblWidth.Text = width.ToString();
            lblCount.Text = lbContainers.Items.Count.ToString();
            btnAddContainer.Enabled = true;
        }

        private void BtnAddContainer_Click(object sender, EventArgs e)
        {
            var weight = (int)nudContainerWeight.Value;
            var type = cbTypesContainer.SelectedValue.ToString();
            var container = new Container(weight, true, false);
            //if (type == "Cooled")
            //{
            //    Container = new Container(weight, true, false);
            //}

            //else if (type == "Valuable")
            //{
            //    Container = new Container(weight, false, true);
            //}

            //else
            //{
            //    Container = new Container(weight, false, false);
            //}

            //Dit nog even fixen

            Containers.Add(container);
            lbContainers.Items.Add(container);
            lblCount.Text = Containers.Count.ToString();
            //enable button if value > 50%?
            var totalWeight = 0;
            totalWeight = container.Weight;

            if (totalWeight >= (Ship.Weight / 2))
            {
                btnSort.Enabled = true;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;

            var logic = new ShipLogic(width, length);
            logic.SortContainers(Containers);

            //var output = Containers;
            //foreach (var container in output)
            //{
            //    lbSortedContainers.Items.Add(container);
            //}

            var shipList = logic.SortContainers(Containers);


            foreach (var ship in shipList)
            {
                lbSortedContainersFront.Items.Add("Length: " + ship.Length + ", Width: " + ship.Width);

                foreach (var stack in ship.Stack)
                {
                    if (stack.FrontRow)
                    {
                        lbSortedContainersFront.Items.Add("Front:");
                    }

                    else if (stack.BackRow)
                    {
                        lbSortedContainersFront.Items.Add("Back:");
                    }

                    //lbSortedContainers.Items.Add("Stack: " + stack.Row1 + " " + stack.Row2);

                    foreach (var container in stack.Containers)
                    {
                        lbSortedContainersFront.Items.Add("Weight: " + container.Weight + ", Cooled: " + container.CooledContainer + ", Valuable: " + container.ValuableContainer);
                    }

                    lbSortedContainersFront.Items.Add("");
                }
            }

            lblCount.Text = lbContainers.Items.Count.ToString();
        }

        public void TestData()
        {
            Containers = new List<Container>
            {
                new Container(4000, false, false),
                new Container(4000, false, false),
                new Container(4500, false, true),
                new Container(4500, false, true),
                new Container(9000, false, false),
                new Container(5500, true, false),
                new Container(6500, false, false),
                new Container(4000, false, true),
                new Container(25000, true, false),
                new Container(4000, false, false),
                new Container(10000, true, false),
                new Container(4000, false, true),
                new Container(6500, true, false),
                new Container(20000, false, true),
                new Container(5000, false, false),
                new Container(9500, false, false),
                new Container(8500, true, false),
                new Container(8500, false, true),
                new Container(4000, false, false),
                new Container(18000, true, false),
                new Container(16000, false, false),
                new Container(4000, false, true),
                new Container(30000, false, true),
                new Container(4500, false, false),
                new Container(12500, false, true),
                new Container(5000, false, true),
                new Container(7500, true, false),
                new Container(28000, false, true),
                new Container(24000, true, false),
                new Container(16000, false, true),
                new Container(13500, true, false),
                new Container(19000, false, true),
                new Container(4000, false, false),
                new Container(5500, true, false),
                new Container(8000, false, false),
                new Container(4000, false, true),
                new Container(21000, false, true),
                new Container(5000, false, false),
                new Container(14500, false, false),
                new Container(4000, false, false),
                new Container(12500, true, false),
                new Container(21000, false, false),
                new Container(14000, false, true),
                new Container(16000, true, false),
                new Container(4000, false, false),
                new Container(8500, false, true),
                new Container(4000, false, false),
                new Container(15500, true, false),
                new Container(20500, false, true),
                new Container(7000, false, true),
                new Container(9000, true, false),
                new Container(4000, false, false),
                new Container(9500, true, false),
                new Container(6000, false, true),
                new Container(23500, false, true),
                new Container(30000, true, false),
                new Container(4000, false, false),
                new Container(5500, false, false),
                new Container(10000, true, false),
                new Container(9500, false, true),
                new Container(11500, false, false),
                new Container(13000, true, false),
                new Container(7000, false, false),
                new Container(9000, false, true),
                new Container(26000, true, false),
                new Container(6000, true, false),
                new Container(12000, false, true),
                new Container(5000, false, true),
                new Container(4500, true, false),
                new Container(21500, false, false)
            };
        }
    }
}
