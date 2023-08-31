namespace prjTrees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100 };

            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() { Data = 50 ,Parent = tree.Root},
                new TreeNode<int>() {Data =1,Parent = tree.Root},
                new TreeNode<int>() {Data =150 ,Parent = tree.Root}
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>(){ Data=30,Parent = tree.Root.Children[2]}
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>()
                {
                new TreeNode<int>() { Data = 8, Parent = tree.Root.Children[2].Children[0] },
                new TreeNode<int>() { Data = 11, Parent = tree.Root.Children[2].Children[0] },
            };


            tree.Root.Children[0].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>() {Data =12,Parent=tree.Root.Children[0]},
                new TreeNode<int>() {Data =1,Parent=tree.Root.Children[0]}
            };
            tree.Root.Children.Add(new TreeNode<int>() { Data = 70, Parent = tree.Root });

            lblOutput.Text = lblOutput.Text+" "+ tree.Root.Children[3].Data.ToString();

            tree.Root.Children[2].Children.Add(new TreeNode<int>() { Data = 40, Parent = tree.Root.Children[2] });

        }
    }

}