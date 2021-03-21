using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trees
{
    public partial class Form1 : Form
    {
        PineTree myPine = new PineTree();
        GumTree myGum = new GumTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrees_Click(object sender, EventArgs e)
        {
            lbTrees.Items.Add(myPine.Height);
            lbTrees.Items.Add(myGum.Height);
            lbTrees.Items.Add(myPine.Name);
            lbTrees.Items.Add(myPine.Origin);
            lbTrees.Items.Add(myPine.Love);
            lbTrees.Items.Add(myGum.Name);
        }
    }
    public abstract class Trees
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Origin { get; set; }
        public string TreeType { get; set; }
        public string Leaves { get; set; }
        public string Love { get; set; }
    }
    class GumTree : Trees
    {
        public GumTree()
        {
            Name = "Gum Tree";
            Leaves = "Gum Leaves";
            Origin = "Australia";
            Height = 33;
           
            // TreeType = "Gum";
        }
    }
    public class PineTree : Trees
    {
        public PineTree()
        {
            Name = "Pine Tree";
            Leaves = "Pine Needles";
            Origin = "USA";
            Height = 33;
            Love = "I love pine Tree";
            // TreeType = "Pine";
        }
    }
}
