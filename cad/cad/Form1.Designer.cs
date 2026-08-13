namespace cad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("노드1");
            TreeNode treeNode2 = new TreeNode("자료", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("노드2");
            TreeNode treeNode4 = new TreeNode("분석결과", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("노드3");
            TreeNode treeNode6 = new TreeNode("제약조건", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Cad 프로젝트", new TreeNode[] { treeNode2, treeNode4, treeNode6 });
            panel_tab = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel_menu = new Panel();
            projectToolStrip = new ToolStrip();
            panel_left = new Panel();
            treeView1 = new TreeView();
            panel_bottom = new Panel();
            panel3 = new Panel();
            toolStrip1 = new ToolStrip();
            panel_tab.SuspendLayout();
            tabControl1.SuspendLayout();
            panel_menu.SuspendLayout();
            panel_left.SuspendLayout();
            SuspendLayout();
            // 
            // panel_tab
            // 
            panel_tab.BackColor = SystemColors.Control;
            panel_tab.Controls.Add(tabControl1);
            panel_tab.Dock = DockStyle.Top;
            panel_tab.Location = new Point(0, 0);
            panel_tab.Name = "panel_tab";
            panel_tab.Size = new Size(1784, 44);
            panel_tab.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(110, 30);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1784, 44);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1776, 6);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "프로젝트";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1776, 6);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "전처리/노선";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1776, 6);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "설계";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_menu
            // 
            panel_menu.BorderStyle = BorderStyle.FixedSingle;
            panel_menu.Controls.Add(projectToolStrip);
            panel_menu.Dock = DockStyle.Top;
            panel_menu.Location = new Point(0, 44);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(1784, 77);
            panel_menu.TabIndex = 1;
            // 
            // projectToolStrip
            // 
            projectToolStrip.AutoSize = false;
            projectToolStrip.BackColor = Color.FromArgb(248, 250, 253);
            projectToolStrip.Dock = DockStyle.Fill;
            projectToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            projectToolStrip.ImageScalingSize = new Size(28, 28);
            projectToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            projectToolStrip.Location = new Point(0, 0);
            projectToolStrip.Name = "projectToolStrip";
            projectToolStrip.Padding = new Padding(8, 0, 0, 0);
            projectToolStrip.RenderMode = ToolStripRenderMode.System;
            projectToolStrip.Size = new Size(1782, 75);
            projectToolStrip.TabIndex = 0;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(247, 249, 253);
            panel_left.BorderStyle = BorderStyle.FixedSingle;
            panel_left.Controls.Add(treeView1);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 121);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(256, 813);
            panel_left.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            treeView1.FullRowSelect = true;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "노드1";
            treeNode1.Text = "노드1";
            treeNode2.Name = "tree_source";
            treeNode2.Text = "자료";
            treeNode3.Name = "노드2";
            treeNode3.Text = "노드2";
            treeNode4.Name = "tree_ana";
            treeNode4.Text = "분석결과";
            treeNode5.Name = "노드3";
            treeNode5.Text = "노드3";
            treeNode6.Name = "tree_const";
            treeNode6.Text = "제약조건";
            treeNode7.Name = "노드0";
            treeNode7.Text = "Cad 프로젝트";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode7 });
            treeView1.ShowLines = false;
            treeView1.Size = new Size(254, 811);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // panel_bottom
            // 
            panel_bottom.BackColor = Color.FromArgb(247, 249, 253);
            panel_bottom.BorderStyle = BorderStyle.FixedSingle;
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 934);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(1784, 52);
            panel_bottom.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 249, 253);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1523, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 813);
            panel3.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(256, 121);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1267, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1784, 986);
            Controls.Add(toolStrip1);
            Controls.Add(panel3);
            Controls.Add(panel_left);
            Controls.Add(panel_bottom);
            Controls.Add(panel_menu);
            Controls.Add(panel_tab);
            Name = "Form1";
            Text = "Cad_Proj";
            panel_tab.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel_menu.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_tab;
        private Panel panel_menu;
        private Panel panel_left;
        private Panel panel_bottom;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        
        private Panel panel3;
        private TreeView treeView1;
        private ToolStrip projectToolStrip;
        private ToolStrip toolStrip1;
    }
}
