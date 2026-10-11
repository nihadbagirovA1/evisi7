using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evisi7
{
    public partial class Form1 : Form
    {
        private double toplamGelir = 0;
        private readonly CultureInfo ci = CultureInfo.InvariantCulture;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            // 1. Boşluq yoxlaması
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Bütün xanaları doldurun!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Rəqəm olub-olmadığını yoxlamaq
            if (!int.TryParse(textBox2.Text.Trim(), out int count))
            {
                MessageBox.Show("Say tam ədəd olmalıdır!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // Nöqtə və vergül hər ikisi qəbul olunur
            string priceText = textBox3.Text.Trim().Replace(',', '.');
            if (!double.TryParse(priceText, NumberStyles.Float, ci, out double price))
            {
                MessageBox.Show("Qiymət rəqəm olmalıdır!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 3. Mənfi və ya sıfır yoxlaması
            if (count <= 0 || price <= 0)
            {
                MessageBox.Show("Say və qiymət sıfırdan böyük olmalıdır!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Cədvələ əlavə
            double result = count * price;
            dataGridView1.Rows.Add(textBox1.Text.Trim(), count.ToString(),
                price.ToString(ci), result.ToString("F2", ci));

            // 5. Toplam gəlir
            toplamGelir += result;
            lblGelir.Text = toplamGelir.ToString("F2", ci);

            // 6. Xanaları sıfırla
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}