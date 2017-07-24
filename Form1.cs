using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangulFixer
{
    public partial class Form1 : Form
    {

        private static int[] firstChar = { 0x1100, 0x1112 };
        private static int[] midChar = { 0x1161, 0x1175 };
        private static int[] lastChar = { 0x11a8, 0x11c2 };

        public Form1()
        {
            InitializeComponent();

        }

        private void btFindDir_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            listFile.Items.Clear();
            var result = fbd.ShowDialog();
            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                var files = Directory.GetFiles(fbd.SelectedPath);
                foreach (var file in files)
                {
                    bool incHangul = false;
                    foreach (var c in file)
                    {
                        //자음
                        if ((c >= 0x1100 && c <= 0x1112) || (c >= 0x1161 && c <= 0x1175) || (c >= 0x11a8 && c <= 0x11c2))
                        {
                            incHangul = true;
                        }
                    }
                    if (incHangul)
                    {
                        listFile.Items.Add(new ListViewItem(new[] { file, Convert(file) }));
                    }
                }
            }
        }

        private string Convert(string str)
        {
            StringBuilder sb = new StringBuilder();
            int c = -1;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= firstChar[0] && str[i] <= firstChar[1])
                {
                    if (c != -1)
                        sb.Append((char)(c + 0xAC00));
                    c = (str[i] - firstChar[0]) * 21;
                }
                else if (str[i] >= midChar[0] && str[i] <= midChar[1]) {
                    c += str[i] - midChar[0];
                    c *= 28;
                }
                else if (str[i] >= lastChar[0] && str[i] <= lastChar[1])
                {
                    c += str[i] - lastChar[0] + 1;
                    sb.Append((char)(c + 0xAC00));
                    c = -1;
                }
                else
                {
                    if (c != -1) sb.Append((char)(c + 0xAC00));
                    sb.Append(str[i]);
                    c = -1;
                }
            }
            if (c != -1)
                sb.Append((char)(c + 0xAC00));
            return sb.ToString();
        }

        private void btDo_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (listFile.Items.Count == 0) return;
            foreach (ListViewItem item in listFile.Items)
                count += item.Checked ? 1 : 0;

            if(count == 0)
            {
                var result = MessageBox.Show("아무런 파일도 선택되지 않았습니다. 모든 파일에 대해 교정 작업을 하시겠습니까?", "HangulFixer", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listFile.Items)
                        item.Checked = true;
                }
                else
                    return;
            }
            try
            {
                foreach (ListViewItem item in listFile.Items)
                {
                    if (item.Checked == true)
                    {
                        FileInfo file = new FileInfo(item.Text);
                        file.MoveTo(Convert(item.Text));
                    }
                }
                MessageBox.Show("작업이 완료되었습니다.");
            }catch (Exception ex)
            {
                MessageBox.Show("오류 발생 : " + ex.StackTrace);
            }
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HangulFixer 20170601\nsource code : http://github.com/mystika/HangulFixer", "HangulFixer", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
