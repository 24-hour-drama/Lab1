using System.Drawing.Imaging;
using System.Reflection;
using System.IO;              
using System.Drawing;         
using System.Windows.Forms;   

namespace Forms
{
    public partial class MainForm : Form
    {
        private Image overlayImage;      // лампочка (PNG с прозрачностью)
        private int overlayAlpha = 0;    // 0 — невидима, 255 — непрозрачна

        public MainForm()
        {
            InitializeComponent();

            LoadImages();

            // Плавная перерисовка PictureBox через рефлексию
            // (ResizeRedraw и DoubleBuffered — защищённые свойства Control)
            var flags = BindingFlags.Instance | BindingFlags.NonPublic;

            typeof(Control).GetProperty("ResizeRedraw", flags)
                ?.SetValue(panel1, true, null);

            typeof(Control).GetProperty("DoubleBuffered", flags)
                ?.SetValue(panel1, true, null);

            // Подписываемся на Paint именно PictureBox
            panel1.Paint += panel1_Paint;

            // Первичная отрисовка
            panel1.Invalidate();
        }

        private void LoadImages()
        {
            string basePath = Application.StartupPath; // папка рядом с .exe

            // Лампочка — загружаем в поле, рисуется в Paint
            string lampPath = Path.Combine(basePath, "Resources", "изображение.png");
            if (File.Exists(lampPath))
            {
                overlayImage = Image.FromFile(lampPath);
            }
            else
            {
                MessageBox.Show("Изображение лампочки не найдено: " + lampPath);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (overlayImage == null || overlayAlpha <= 0)
                return;

            var size = panel1.ClientSize;

            using (var ia = new ImageAttributes())
            {
                var cm = new ColorMatrix();
                cm.Matrix33 = overlayAlpha / 255.0f; // общая прозрачность 0..1

                ia.SetColorMatrix(cm,
                    ColorMatrixFlag.Default,
                    ColorAdjustType.Bitmap);

                e.Graphics.DrawImage(
                    overlayImage,
                    new Rectangle(0, 0, size.Width, size.Height),
                    0, 0, overlayImage.Width, overlayImage.Height,
                    GraphicsUnit.Pixel,
                    ia);
            }
        }
        /*
        /// <summary>
        /// Прозрачность лампочки: 0 — невидима, 255 — полностью видна.
        /// Перерисовывает только PictureBox.
        /// </summary>
        public void SetLampAlpha(int alpha)
        {
            overlayAlpha = Math.Clamp(alpha, 0, 255);

            // Перерисовка только pictureLamp — не всей формы
            panel1.Invalidate();
        }

        // Примеры обработчиков
        private void btnOn_Click(object sender, EventArgs e)
        {
            SetLampAlpha(255);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            SetLampAlpha(0);
        }

        private void trackBrightness_Scroll(object sender, EventArgs e)
        {
            // 0..100 → 0..255
            SetLampAlpha(trackBrightness.Value * 255 / 100);
        }*/
    }
}
