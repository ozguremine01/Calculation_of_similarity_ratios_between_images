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

namespace Benzerlik_Oran
{
    public partial class Form1 : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
        OpenFileDialog openfile1 = new OpenFileDialog();
        public Form1()
        {
            
            InitializeComponent();
        }
        public float Difference(Bitmap resim1, Bitmap resim2)
        {
            float diff = 0;

            //Birinci görüntünün yüksekliği * genişliği kadar, yani tüm pikseller
            for (int y = 0; y < resim1.Height; y++)
            {
                for (int x = 0; x < resim2.Width; x++)
                {
                    //Bitmap sınıfı içerisideki GetPixel metodu piksel değerini okur
                    //RGB formatı referans alınmıştır, iki görüntü için aynı piksellerin mutlak farkı hesaplanır ve maksimum değeri olan 255 ile oranlanır
                    diff += (float)Math.Abs(resim1.GetPixel(x, y).R - resim2.GetPixel(x, y).R) / 255;
                    diff += (float)Math.Abs(resim1.GetPixel(x, y).G - resim2.GetPixel(x, y).G) / 255;
                    diff += (float)Math.Abs(resim1.GetPixel(x, y).B - resim2.GetPixel(x, y).B) / 255;
                }
            }
            //Farkı ve toplam piksel sayısını kullanarak sonucu hesaplar
            return 100-(100 * diff / (resim1.Width * resim1.Height * 3));

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image==null || pictureBox2.Image==null || (pictureBox1.Image==null && pictureBox2.Image==null))
            {
                MessageBox.Show("Hesaplanmasını istediğiniz veri alanları boş...");
            }
            else
            {

            }
            return;
        }
        FolderBrowserDialog folder1 = new FolderBrowserDialog();
        private void btnyükle2_Click(object sender, EventArgs e)
        {
            string[] klasör;
            int y = 0;
            string yol;
            
            if (folder1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folder1.SelectedPath);
                klasör = Directory.GetDirectories(folder1.SelectedPath);
               
                foreach (string dosya in Directory.GetFiles(folder1.SelectedPath))
                {
                    FileInfo fileInfo = new FileInfo(dosya);
                    
                    string url = fileInfo.Name;
                    // comboBox1.Items.Add(url);
                    string yolu = Path.GetFullPath(url);
                    dataGridView1.Rows.Add(url);
                    y++;

                }

                
                    for (int b = 0; b <= Directory.GetFiles(folder1.SelectedPath).Length-1; b++)
                    {
                    dataGridView1.Rows[b].Cells[2].Value = folder1.SelectedPath;
                    //private Bitmap bitmap;
                    //pictureBox2.Image = (Image);
                    if (pictureBox1.Image != null)
                    {
                       
                            pictureBox2.Image = Image.FromFile(folder1.SelectedPath + "\\" + dataGridView1.Rows[b].Cells[0].Value.ToString());
                            Bitmap bmp = new Bitmap(pictureBox1.Image, 100, 200);
                            pictureBox1.Image = bmp;
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                            Bitmap bmp2 = new Bitmap(pictureBox2.Image, 100, 200);
                            pictureBox2.Image = bmp2;
                            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                            float a = Difference(new Bitmap(bmp), new Bitmap(bmp2));
                            //MessageBox.Show(Difference(new Bitmap(bmp), new Bitmap(bmp2)).ToString());
                            //MessageBox.Show(a.ToString());
                            //dataGridView1.Rows[b].Cells[1].Value = a;
                            dataGridView1.Rows[b].Cells[1].Value = a.ToString();
                        float b1;
                        b1 =float.Parse(dataGridView1.Rows[b].Cells[1].Value.ToString());
                        int x1;
                        x1 = dataGridView1.Rows.Count;
                    }
                    else
                    {
                        string message = "Lütfen seçim yapınız/.jpeg yada .jpg uzantılı dosya yükleyiniz/Boş alan bırakmayınız... ";
                        string title = "Uyarı";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {
                            
                        }
                    }
                    }
                
               
            }
           else
            {
                MessageBox.Show("");
                MessageBox.Show("Lütfen hesaplanacak alanları eksiksiz doldurunuz...");
            }
           
        }
       
        private void btnyükle1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                
                    pictureBox1.Image = Image.FromFile(openfile.FileName);
                

            }
            else
            {

                string message = "Lütfen seçim yapınız/.jpeg yada .jpg uzantılı dosya yükleyiniz... ";
                string title = "Uyarı";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }
        private void btnencokbenzeyen_Click(object sender, EventArgs e)
        {
            btnencokbenzeyen.Visible = false;
           float enbüyük=0 ;
           float sayi;
            for (int i = 0; i <dataGridView1.Rows.Count-1; i++)
            {
                //sayi =(float)(dataGridView1.Rows[i].Cells[1].Value);
               sayi =float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (sayi > enbüyük)
                {
                    enbüyük = sayi;
                   pictureBox3.Image = Image.FromFile(""+dataGridView1.Rows[i].Cells[2].Value.ToString()+"\\"+""+ dataGridView1.Rows[i].Cells[0].Value.ToString());
                    textBox1.Text = "Benzerlik Oranı:" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "Adı:" + dataGridView1.Rows[i].Cells[0].Value.ToString();

                }
                else
                {
                    continue;
                }
            }

        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files(*.txt)|*.txt";
            fd.FilterIndex = 2;

            //string adi = fd.FileName;
            //fd.Multiselect = true;
            //FolderBrowserDialog ff = new FolderBrowserDialog();
           // fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //TextWriter textWriter = new StreamWriter(@"{}" + adi);
                TextWriter textWriter = new StreamWriter(@"" + fd.FileName);
                 for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                 {
                     for (int j = 0; j < dataGridView1.Columns.Count; j++)
                     {
                         textWriter.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                     }
                     textWriter.WriteLine("");
                     textWriter.WriteLine("-------------------------------------------------------");
                 }
                 textWriter.Close();
                 MessageBox.Show("Lütfen verilerinizi kaydetttiğiniz dosyaya giriniz ve verilerinizi inceleyiniz...");
                textBox1.Text = fd.FileName;
            }

        }
            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                pictureBox3.Width = 100;
                pictureBox3.Height = 200;
                
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.Image = Image.FromFile(""+dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value+"\\"+ dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            }
            catch
            {

            }
        }
        List<double> veri=new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            double enbuyuk = Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);
            for (int ix = 0; ix < dataGridView1.Rows.Count; ix++)
            {
                veri.Add(Convert.ToDouble(dataGridView1.Rows[ix].Cells[1].Value));
                Console.WriteLine(dataGridView1.Rows[ix].Cells[1].Value);
            }
            veri.Remove(veri.Max());
            Console.WriteLine(veri.Max());
            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                if(Convert.ToDouble(dataGridView1.Rows[x].Cells[1].Value)==veri.Max())
                {
                    Console.WriteLine(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    pictureBox2.Image = Image.FromFile("" + dataGridView1.Rows[x].Cells[2].Value + "\\" + dataGridView1.Rows[2].Cells[0].Value);
                    textBox1.Text = "en çok benzeyen:" + dataGridView1.Rows[x].Cells[0].Value.ToString();
                    textBox2.Text = "oranı:" + Convert.ToDouble(dataGridView1.Rows[x].Cells[1].Value);
                }
            }

        }
               
            }
        }
    

