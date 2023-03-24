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

namespace GlumSak_MetaViewer.UI
{
    public partial class Form1 : Form
    {
        private static List<Image> _gameImgs = new List<Image>();
        private static List<string> _gameNames = new List<string>();
        private static List<string> _gameIds = new List<string>();

        private static string tempPath = Path.GetTempPath();
        private static string _emuConfig;
        private static string metaPath = Path.GetTempPath() + "glumCacheMeta.glumMeta";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCacheContent();

            foreach (Image image in _gameImgs)
            {
                if (image != null)
                {
                    var pb = new PictureBox();
                    pb.Height = 115;
                    pb.Width = 115;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = image;
                    Images_WrapPanel.Controls.Add(pb);
                }
            }

            for (var i = 0; i < _gameNames.Count; i++)
            {
                var item = _gameNames[i] + " | " + _gameIds[i];
                Games_List.Items.Add(item);
            }

            EmuConfig_Label.Text += $" {_emuConfig}";
        }

        public static bool CacheExists()
        {
            return File.Exists(metaPath);
        }

        public static void GetCacheContent()
        {
            string[] content = File.ReadAllLines(metaPath);

            List<string> imgPaths = new List<string>();
            List<string> gameNames = new List<string>();
            List<string> gameIds = new List<string>();

            foreach (string line in content)
            {
                ReadContent(imgPaths, line, content[0]);
                ReadContent(gameIds, line, content[1]);
                ReadContent(gameNames, line, content[2]);

                if (line == content[3])
                {
                    _emuConfig = line.Split('=').Last().Split(',').First();
                }
            }

            foreach (var imgPath in imgPaths) //gets the images from the meta file and converts them to Image
            {
                using (Stream bmpStrm = File.Open(imgPath, FileMode.Open)) //To make sure that the imgs can be deleted
                                                                           //at runtime
                {
                    Image img = Image.FromStream(bmpStrm);
                    var bmp = new Bitmap(img);
                    _gameImgs.Add(bmp);
                }
            }

            _gameNames = gameNames;
            _gameIds = gameIds;
        }

        private static void ReadContent(List<string> target, string line, string fileContent)
        {
            if (line == fileContent)
            {
                string[] tempLines = line.Split(',');
                for (int i = 0; i < tempLines.Length; i++)
                {
                    if (tempLines[i] != string.Empty)
                    {
                        target.Add(tempLines[i]);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _emuConfig = null;
            _gameImgs.Clear();
            _gameNames.Clear();
            _gameIds.Clear();
        }
    }
}