namespace cad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddSaveButton();
            treeView1.ExpandAll();
        }

        // 저장 PNG 아이콘만 표시하는 UI 버튼입니다. 클릭 기능은 없습니다.
        private void AddSaveButton()
        {
            using Stream? stream = GetType().Assembly.GetManifestResourceStream("cad.Resources.Icons.save.png");
            if (stream is null) return;

            using var source = Image.FromStream(stream);
            var icon = new Bitmap(source);

            var saveButton = new ToolStripButton
            {
                AutoSize = false,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                Image = icon,
                ImageScaling = ToolStripItemImageScaling.SizeToFit,
                Margin = new Padding(4, 3, 4, 3),
                Size = new Size(86, 66),
                Text = "저장",
                TextImageRelation = TextImageRelation.ImageAboveText,
                ToolTipText = "저장"
            };

            projectToolStrip.Items.Clear();
            projectToolStrip.Items.Add(saveButton);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
    }
}
