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

namespace Steganographi1
{
    public partial class Steganography : Form
    {
        public Steganography()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)  //нажатие на копку "Загрузить изображение"
        {
            openFileDialog();
        }


        private void buttonLoadProcessImage_Click(object sender, EventArgs e)  //нажатие на кнопку "Загрузить обработанное изображение"
        {
            openFileDialog();
        }
        
        
        private void buttonLoadSourceImage_Click(object sender, EventArgs e)  //нажатие на кнопку "Загрузить исходное изображение"
        {
            openFileDialog();
        }

        public void openFileDialog() //открытие диалогового окна
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSourceImage.Image = Image.FromFile(op.FileName);
            }
        }

        private void buttonCode_Click(object sender, EventArgs e) //нажатие на кнопку "Закодировать"
        {
            string binText = "";
            ConvertTextToBinary(ref binText);  //конвертируем текст в двоичную форму
            ToCodeImage(ref binText);  //шифруем двоичный текст в изображении
        }

        public void ConvertTextToBinary(ref string binText)
        {
            for (int i = 0; i < textBoxCode.Text.Length; i++)
            {
                int[] oneSymbol = new int[11];  //массив для одного символа размера 11, тк в кодировке utf16 наибольшийразмер кода символа в двоичной системе 11
                int code = Convert.ToInt32(textBoxCode.Text[i]);  //узнаем код символа
                for (int j = 10; j >= 0; j--)  //переводим код символа в двоичную систему
                {
                    oneSymbol[j] = code % 2;
                    code /= 2;
                }
                for (int j = 0; j <= 10; j++)  //записываем в строку массив
                    binText += Convert.ToString(oneSymbol[j]);
            }
        }

        public void ToCodeImage(ref string binText)
        {
            int count = 0;  //счетчик, что бы не выйти за пределы сообщения
            Bitmap b = new Bitmap(pictureBoxImage.ClientSize.Width, pictureBoxImage.Height); //создаем экземпляр класса bitmap, и загружаем в него избражение
            pictureBoxImage.DrawToBitmap(b, pictureBoxImage.ClientRectangle);
            for (int i = 0; i < pictureBoxImage.ClientSize.Width; i++)  //проходим по пикселям изображения
                for (int j = 0; j < pictureBoxImage.ClientSize.Height; j++)
                {

                    if (count < binText.Length) //проверяем, не  вышли ли мы за пределы строки
                    {
                        if (binText[count] == '0')  //если символ является 0
                        {
                            Color colour = b.GetPixel(i, j); // увеличиваем значение красного компонента на 1
                            b.SetPixel(i, j, Color.FromArgb(colour.A, (colour.R + 1) % 255, colour.G, colour.B));
                            count++;
                        }
                        else
                        {
                            Color colour = b.GetPixel(i, j); //иначе увеличиваем на 2
                            b.SetPixel(i, j, Color.FromArgb(colour.A, (colour.R + 2) % 255, colour.G, colour.B));
                            count++;
                        }
                    }
                    else //если вышли за пределы строки, завершаем цикл
                    {
                        i = pictureBoxImage.Width;
                       break;
                    }
                }
            if (pictureBoxImage.Image != null) pictureBoxImage.Image.Dispose(); //клонируем изображение в соседний picturebox
            pictureBoxImage.Image = b.Clone(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            
            b.Dispose(); //освобождаем экземпляр класса
            pictureBoxImageRixel.Image = (Bitmap)pictureBoxImage.Image.Clone();
            
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)  //нажатие на кнопку "Сохранить изображение"
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

        private void buttonRestart_Click(object sender, EventArgs e) //нажатие на кнопку "Начать сначала"
        {
            Application.Restart();
        }

        private void buttonDecode_Click(object sender, EventArgs e) //нажатие на кнопку "Раскодировать"
        {
            textBoxDecode.Clear();
            string binTextDecode = ""; //строка для записи сообщения в двоичной системе
            ConvertPixelToBinText(ref binTextDecode);
            string text = "";
            ConvertBinTextToStringText(binTextDecode, ref text);

        }


        public void ConvertBinTextToStringText(string binTextDecode, ref string text) //конвертирует двоичный код в текст
        {
            int oneSymbol = 0;
            for (int i = 0; i < binTextDecode.Length; i += 11) //разделяем строку по 11 символов
            {
                for (int j = 0; j < 11; j++)
                {
                    if (binTextDecode[i + j] == '1') //если символ равен 1, прибавляем к oneSymbol 2 в степени соответствующго разряда
                        oneSymbol += Convert.ToInt32(Math.Pow(2, 10 - j));
                }
                char symbol = Convert.ToChar(oneSymbol); //узнаем символ по его коду
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
                Bitmap b1 = new Bitmap(pictureBoxSourceImage.ClientSize.Width, pictureBoxSourceImage.Height); //сщздаем экземпляр класса bitmap и загружаем в него избражение
                pictureBoxSourceImage.DrawToBitmap(b1, pictureBoxSourceImage.ClientRectangle);

                Bitmap b2 = new Bitmap(pictureBoxProcessImage.ClientSize.Width, pictureBoxProcessImage.Height);
                pictureBoxProcessImage.DrawToBitmap(b2, pictureBoxProcessImage.ClientRectangle);

                for (int i = 0; i < pictureBoxSourceImage.ClientSize.Width; i++)
                    for (int j = 0; j < pictureBoxSourceImage.ClientSize.Height; j++)
                    {
                        int R1 = b1.GetPixel(i, j).R; //узнаем зачения красного компонента ij пикселя в исходном изображении
                        int R2 = b2.GetPixel(i, j).R; //узнаем зачения красного компонента ij пикселя в обработанном изображении
                        count = R2 - R1; //разность значений красного компонента

                        if (count == 1) binTextDecode += 0; //если разность равна 1, прибавляем к строке 0
                        if (count == 2) binTextDecode += 1; //иначе прибавляем 1
                        if (count == 0 && i==0 && j==0) //если первые пиксели двух изображений равны выводим сообщение
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

        private void buttonSaveMassage_Click(object sender, EventArgs e) //нажатие на кнопку "Сохранить сообщение"
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Unnamed.txt";
            sfd.Filter = "Text file:|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBoxDecode.Text);

        }
    }
}
