using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba15_V4 {
    public partial class Zadanie : Form {
        public Zadanie() {
            InitializeComponent();
        }
        int good;
        int x;
        int c;
        private int CalcAnswer(int x, int c) {
            if (c == 0 || x == 0) return 0;
            double p = 0;
            int v1 = -1;
            int v2 = 0;
            int v3 = 1;
            int s = -1;
            for (int i = 1; i < c * 2; i += 2) {
                v1 += 2;
                v2 += 2;
                v3 += 2;
                double r = (Math.Pow(Convert.ToDouble(x), Convert.ToDouble(i)) / v1 * v2 * v3);
                p += r * s;
                s = -s;
            }
            return (int)p;
        }
        private void btnSetX_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt file  (*.txt)|*.txt|" +
                "Мои файлы (расширение не придумал)|*.xxx" +
                "Сборки (*.exe)|*.exe|";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";

            if (dlg.ShowDialog() == DialogResult.OK) {
                txtSetX.Text = dlg.FileName;
                string[] xt = File.ReadAllLines(dlg.Title);
                this.x = Int16.Parse(xt[0]);
            }
        }

        private void btnCountElements_Click(object sender, EventArgs e) {

        }

        private void btnGetAnswer_Click(object sender, EventArgs e) {
            good = CalcAnswer(this.x, this.c);
            if (good == 0) {
                return;
            }
            MessageBox.Show($"{good}");
        }
    }
}
