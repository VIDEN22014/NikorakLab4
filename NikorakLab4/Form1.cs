using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikorakLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddToTree("solitare", mainNode);
            AddToTree("passport", mainNode);
            AddToTree("shelf", mainNode);
            AddToTree("info", mainNode);
            AddToTree("ballet", mainNode);
            AddToTree("base", mainNode);
            AddToTree("white", mainNode);
            AddToTree("exposition", mainNode);
            AddToTree("plenty", mainNode);
            AddToTree("nation", mainNode);
            AddToTree("legacy", mainNode);
            AddToTree("mute", mainNode);
            AddToTree("unusual", mainNode);
            AddToTree("late", mainNode);
        }
        CNode mainNode = new CNode();
        class CNode
        {
            public CNode[] mass = new CNode[27];
            public void Add(int index)
            {
                if (mass[index] == null)
                {
                    mass[index] = new CNode();
                }
            }
        }
        void AddToTree(string str, CNode node)
        {
            CNode tempNode = node;
            str = str.ToLower();
            foreach (char item in str)
            {
                if (item >= 97 && item <= 123)
                {
                    tempNode.Add(item - 97);
                    tempNode = tempNode.mass[item - 97];
                }
            }
            tempNode.Add(26);
            isFindIN.Items.Add(str);
        }
        bool isFindWord(string str, CNode node)
        {
            CNode tempNode = node;
            foreach (char item in str)
            {
                if (item >= 97 && item <= 122)
                {
                    if (tempNode.mass[item - 97] == null)
                    {
                        return false;
                    }
                    tempNode = tempNode.mass[item - 97];
                }
            }
            if (tempNode.mass[26] == null)
            {
                return false;
            }
            return true;
        }
        void BuidTree(CNode node, TreeNode treeNode)
        {
            for (int i = 0; i < 27; i++)
            {
                if (node.mass[i] != null)
                {
                    if (i == 26)
                    {
                        treeNode.Nodes.Add(Convert.ToString(Convert.ToChar(95)));
                    }
                    else
                    {
                        treeNode.Nodes.Add(Convert.ToString(Convert.ToChar(i + 97)));
                    }
                    BuidTree(node.mass[i], TreeNodeCollectionToTreeNode(treeNode.Nodes, Convert.ToChar(i + 97)));
                }
            }
        }
        TreeNode TreeNodeCollectionToTreeNode(TreeNodeCollection nodes, char str)
        {
            foreach (TreeNode item in nodes)
            {
                if (item.Text == Convert.ToString(str))
                {
                    return item;
                }
            }
            return null;
        }
        void ExpandTree(string str)
        {
            TreeNode collection = treeView1.Nodes[0];
            foreach (char item in str)
            {
                TreeNodeCollectionToTreeNode(collection.Nodes, item).Expand();
                collection = TreeNodeCollectionToTreeNode(collection.Nodes, item);
            }
        }
        string ComboBoxToString(ComboBox comboBox)
        {
            if (comboBox.Text == "") { return ""; }
            else return comboBox.Text;
        }
        string TextBoxToString(TextBox textBox)
        {
            if (textBox.Text == "") { return ""; }
            else return textBox.Text;
        }
        private void addToTreeButton_Click(object sender, EventArgs e)
        {
            string str = TextBoxToString(addToTreeIN);
            if (str != "") {
                AddToTree(str, mainNode);
            }
            treeView1.Nodes[0].Nodes.Clear();
            BuidTree(mainNode, treeView1.Nodes[0]);
            treeView1.Nodes[0].ExpandAll();
        }

        private void isFindButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Collapse();
            string str = ComboBoxToString(isFindIN);
            if (isFindWord(str, mainNode))
            {
                treeView1.Nodes[0].Expand();
                ExpandTree(str);
                isFindStatus.Text = "Слово Знайдено";
            }
            else
            {
                isFindStatus.Text = "Слово Не Знайдено";
            }
        }

        private void buildTreeButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Clear();
            BuidTree(mainNode, treeView1.Nodes[0]);
            treeView1.Nodes[0].ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Clear();
            BuidTree(mainNode, treeView1.Nodes[0]);
            treeView1.Nodes[0].ExpandAll();
        }
    }
}
