namespace progetto_fineanno_bassi
{
    public partial class Form1 : Form
    {
        MyList stringhe = new MyList();
        BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            
            string nota = textBox1.Text;

                

                DateTime ora = DateTime.Now;
                string messaggio = $"{ora}: {nota}";
                stringhe.AddTail(messaggio);

               label1.Text = stringhe.ToString();
            //MessageBox.Show(stringhe.ToString());
            //Console.WriteLine("Stringhe inserite:");
            //Console.WriteLine(stringhe);
            //label1.Text = stringhe.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nota = textBox2.Text;
            tree.Inserisci(nota);

            label1.Text=tree.ToString();
            //MessageBox.Show(tree.ToString());
        }
    }
}