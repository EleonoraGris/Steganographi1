using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganographi1
{
    public partial class Steganography : Form
    {
        public Steganography()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK) 
            {
                pictureBoxImage.Image = Image.FromFile(op.FileName);
            }
        }


        private void buttonLoadProcessImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProcessImage.Image = Image.FromFile(op.FileName);
            }
        }
        
        
        private void buttonLoadSourceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSourceImage .Image = Image.FromFile(op.FileName);
            }
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            string binText = "";
            ConvertTextToBinary(ref binText);
            ToCodeImage(ref binText);
        }

        public void ConvertTextToBinary(ref string binText)
        {
            for (int i = 0; i < textBoxCode.Text.Length; i++)
            {
                int[] oneSymbol = new int[11];
                int code = Convert.ToInt32(textBoxCode.Text[i]);
                for (int j = 10; j >= 0; j--)
                {
                    oneSymbol[j] = code % 2;
                    code /= 2;
                }
                for (int j = 0; j <= 10; j++)
                    binText += Convert.ToString(oneSymbol[j]);
            }
            textBoxBinCode.Text = binText;
        }

        public void ToCodeImage(ref string binText)
        {
            int count = 0;
            Bitmap b = new Bitmap(pictureBoxImage.ClientSize.Width, pictureBoxImage.Height);
            pictureBoxImage.DrawToBitmap(b, pictureBoxImage.ClientRectangle);
            for (int i = 0; i < pictureBoxImage.ClientSize.Width; i++)
                for (int j = 0; j < pictureBoxImage.ClientSize.Height; j++)
                {

                    if (count < binText.Length)
                    {
                        if (binText[count] == '0')
                        {
                            Color colour = b.GetPixel(i, j);
                            b.SetPixel(i, j, Color.FromArgb(colour.A, (colour.R + 1) % 255, colour.G, colour.B));
                            count++;
                        }
                        else
                        {
                            Color colour = b.GetPixel(i, j);
                            b.SetPixel(i, j, Color.FromArgb(colour.A, (colour.R + 2) % 255, colour.G, colour.B));
                            count++;
                        }
                    }
                    else
                    {
                        i = pictureBoxImage.Width;
                       break;
                    }
                }
            if (pictureBoxImage.Image != null) pictureBoxImage.Image.Dispose();
            pictureBoxImage.Image = b.Clone(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            
            b.Dispose();
            pictureBoxImageRixel.Image = (Bitmap)pictureBoxImage.Image.Clone();
            
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxImageRixel.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxImageRixel.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Нет картинки");
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textBoxDecode.Clear();
            string binTextDecode = "";
            ConvertPixelToBinText(ref binTextDecode);
            string text = "";
            ConvertBinTextToStringText(binTextDecode, ref text);

        }


        public void ConvertBinTextToStringText(string binTextDecode, ref string text)
        {
            int oneSymbol = 0;
            for (int i = 0; i < binTextDecode.Length; i += 11)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (binTextDecode[i + j] == '1')
                        oneSymbol += Convert.ToInt32(Math.Pow(2, 10 - j));
                }
                char symbol = Convert.ToChar(oneSymbol);
                text += Convert.ToString(symbol);
                oneSymbol = 0;
            }
                textBoxDecode.Text = text;
        }


        public void ConvertPixelToBinText(ref string binTextDecode)
        {
            int count = 0;

            do
            {
                Bitmap b1 = new Bitmap(pictureBoxSourceImage.ClientSize.Width, pictureBoxSourceImage.Height);
                pictureBoxSourceImage.DrawToBitmap(b1, pictureBoxSourceImage.ClientRectangle);

                Bitmap b2 = new Bitmap(pictureBoxProcessImage.ClientSize.Width, pictureBoxProcessImage.Height);
                pictureBoxProcessImage.DrawToBitmap(b2, pictureBoxProcessImage.ClientRectangle);

                for (int i = 0; i < pictureBoxSourceImage.ClientSize.Width; i++)
                    for (int j = 0; j < pictureBoxSourceImage.ClientSize.Height; j++)
                    {
                        int R1 = b1.GetPixel(i, j).R;
                        int R2 = b2.GetPixel(i, j).R;
                        count = R2 - R1;

                        if (count == 1) binTextDecode += 0;
                        if (count == 2) binTextDecode += 1;
                        if (count == 0 && i==0 && j==0) 
                        {

                            MessageBox.Show("Вы загузили одинаковые изображения");
                            i = pictureBoxSourceImage.Width;
                            break;
                        }
                        if (count != 0 && count != 1 && count != 2)
                        {
                            MessageBox.Show("изображения не подходят для декодировки");
                            i = pictureBoxSourceImage.Width;
                            break;
                        }

                    }
            }
            while (count == 1 || count == 2);
            textBoxDecode.Text = binTextDecode;
        }

        private void buttonSaveMassage_Click(object sender, EventArgs e)
        {

        }
    }
}
