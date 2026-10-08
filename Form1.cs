namespace Laba15_V4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void btnChooseColor_Click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = panelChooseColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK) {
                panelChooseColor.BackColor = dlg.Color;
            }
        }

        private void btnChooseFonts_Click(object sender, EventArgs e) {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowHelp = true;
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                txtChooseFont.Font = fontDialog.Font;
                txtChooseFont.ForeColor = fontDialog.Color;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите папку для демонстрации работы диалога.";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;

            if (dlg.ShowDialog() == DialogResult.OK) {
                txtChooseFolder.Text = dlg.SelectedPath;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt file  (*.txt)|*.txt|" +
                "Мои файлы (расширение не придумал)|*.xxx" +
                "Сборки (*.exe)|*.exe|";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";

            if (dlg.ShowDialog() == DialogResult.OK) {
                txtChoseFile.Text = dlg.FileName;
            }
        }
    }
}
