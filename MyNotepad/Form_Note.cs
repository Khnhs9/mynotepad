namespace MyNotepad
{
    public partial class Form_Note : Form
    {
        private object txtEditorx;

        public Form_Note()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBox.Text = "";
        }

        private void abourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MyNotepad V1.0", "About");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text|*.txt";
            openFileDialog1.Title = "Open a Text File";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                //File.WriteAllText(saveFileDialog1.FileName, tBox.Text);
                tBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, tBox.Text); 
            }
        }

        private void 폐이지설정UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 연쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void bing으로검색SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 바꾸기RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 이동GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tBox.WordWrap == true)
            {
                tBox.WordWrap = false;
                자동줄바꿈WToolStripMenuItem.Checked = false;
            }
            else
            {
                tBox.WordWrap = true;
                자동줄바꿈WToolStripMenuItem.Checked = true;
            }
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 확대하기축소하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 상태표시줄SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 도움말보기HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code Here");
        }

        private void 메모장정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_info win = new Form_info();
            win.Location = new Point(this.Location.X, this.Location.Y);
            win.ShowDialog();
        }
    }
}
