using System.IO.Compression;

namespace CBZReader
{
    public partial class Form1 : Form
    {
        private string[]? paths;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        //pick archive from File Dialogue
        private void PickFile_Click(object sender, EventArgs e)
        {
            //get file from dialogue
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select comic book";
            ofd.Filter = "Comic book archives | *.cbz; *.cbr";
            ofd.ShowDialog();

            //check and extract file
            string[] validExtensions = { ".cbz"};
            if (File.Exists(ofd.FileName) && validExtensions.Contains(Path.GetExtension(ofd.FileName)))
            {
                if (unpackArchive(ofd.FileName, Path.GetFileName(ofd.FileName)));
                else MessageBox.Show("No valid archive chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //page backward
        private void bBack_Click(object sender, EventArgs e)
        {
            if(currentIndex > 0)
            {
                currentIndex--;
                updateLabelAndPic();
            }
        }

        //page forward
        private void bForward_Click(object sender, EventArgs e)
        {
            if (currentIndex < paths.Length-1)
            {
                currentIndex++;
                updateLabelAndPic();
            }
        }

        //get input from text field and set page according to it
        private void pageEnter_Click(object sender, EventArgs e)
        {
            int input = (int)pageInput.Value;
            if (input >= 0 && input <= paths.Length - 1)
            {
                currentIndex = input;
                updateLabelAndPic();
            }
            else
            {
                MessageBox.Show("Stay in a range from 0 to " + (paths.Length - 1).ToString(),
                                "Value invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //handle "Enter"-press, when textbox focused
        private void pageInput_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //e.Handled = true;
                e.SuppressKeyPress = true;
                pageEnter_Click(sender, e);
            }

        }
        //handle Arrow-key scrolling, when Buttons focused
        private void ArrowKeyScroll_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (currentIndex > 0) currentIndex--;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (currentIndex < paths.Length - 1) currentIndex++;
            }
            updateLabelAndPic();
        }

        //unpack archive into folder, store file paths of images, enable control buttons
        private bool unpackArchive(string @sourceZip, string ArchiveName)
        {
            ArchiveName = @"\" + ArchiveName;
            try
            {
                //error check, if it is a valid zip archive
                ZipFile.OpenRead(sourceZip);

                //make new folder with extracted contents of archive
                string targetFolder = Directory.GetCurrentDirectory() + ArchiveName;
                if (!Directory.Exists(targetFolder)) ZipFile.ExtractToDirectory(sourceZip, targetFolder);

                //get file paths of images
                paths = Directory.GetFiles(Directory.GetCurrentDirectory() + ArchiveName);
                pictureBox1.ImageLocation = paths[0];
                currentIndex = 0;

                //enable control buttons
                bBack.Enabled = true;
                bForward.Enabled = true;
                pageEnter.Visible = true;
                pageInput.Visible = true;
                label2.Visible = true;
                pageInput.Maximum = paths.Length - 1;

                updateLabelAndPic();
                return true;
            }
            catch (InvalidDataException)
            {
                return false;
            }
        }

        //update page label
        private void updateLabelAndPic()
        {
            pictureBox1.ImageLocation = paths[currentIndex];
            label2.Text = "Page: " + currentIndex.ToString() + "/" + (paths.Length-1).ToString();
        }
    }
}