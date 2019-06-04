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
            var weight = (int)nudShipWeight.Value;

            InfoShip.Visible = true;
            ConfigShip.Visible = false;
            lblLength.Text = length.ToString();
            lblWidth.Text = width.ToString();
            lblShipWeight.Text = weight.ToString();
            lblContainersWeight.Text = "0";
            btnAddContainer.Enabled = true;

            ShipLogic = new ShipLogic(width, length, weight);
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
            if (ShipLogic.Ship.Weight / 2 <= ShipLogic.Ship.MaxWeight)
            {
                btnSort.Enabled = true;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            //ShipLogic logic = new ShipLogic(width, length, weight);
            var ship = ShipLogic.SortContainers(Containers);

            for (var i = 0; i < ShipLogic.Ship.Width; i++)
            {
                for (var j = 0; j < ShipLogic.Ship.Length; j++)
                {
                    //for (var c = 0; c < ship.Stack[i, j].Containers.Count; c++)
                    //{
                        lbSortedContainers.Items.Add(j.ToString() + "." + i.ToString());
                        // foreach (Stack stack in ship.Stack)
                        foreach (var container in ship.Stack[i, j].Containers)
                        {
                            //lbRows.Items.Add(c + ":");
                            lbSortedContainers.Items.Add(container);
                        }
                    //}
                }
            }


            foreach (Container container in ShipLogic.UnSortedContainers)
            {
                lbUnsortedContainers.Items.Add(container);
            }

            lblCountUnsorted.Text = lbUnsortedContainers.Items.Count.ToString();
        }

        public void FillTestData()
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

            var length = (int)nudLength.Value;
            var width = (int)nudWidth.Value;
            var weight = (int)nudShipWeight.Value;

            ShipLogic logic = new ShipLogic(width, length, weight);
            var ship = logic.SortContainers(Containers);

            foreach (Stack stack in ship.Stack)
            {
                //for (var i = 0; i < logic.Ship.Width; i++)
                //{
                //    for (var j = 0; j < logic.Ship.Length; j++)
                //    {
                //        lbRows.Items.Add(i + ", " + j);
                lbSortedContainers.Items.Add(stack);
                //    }
                //}
            }

            foreach (Container container in logic.UnSortedContainers)
            {
                lbUnsortedContainers.Items.Add(container);
            }
        }

        private void LbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbSortedContainers.Items.Clear();

            //var stack = lbSortedContainers.SelectedItem as Stack;
            //var containerList = stack.Containers;

            //foreach (var container in containerList)
            //{
            //    lbSortedContainers.Items.Add(container);
            //}
        }
    }
}