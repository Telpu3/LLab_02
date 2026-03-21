using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2
{
    public partial class Form1 : Form
    {
        private List<int> divisors = new List<int>(); // Список для хранения делителей
        private int currentPerfectNumber; // Текущее совершенное число
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelresult1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxN1.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введено неправильное число");
                return;
            }
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                labelResult1.Text = "Число является совершенным";
            }
            else
            {
                labelResult1.Text = "Число не является совершенным";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Валидация
            if (!int.TryParse(textBoxN2.Text, out int n) || n < 2)
            {
                MessageBox.Show("Введите целое число >= 2.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxPerfect.Items.Clear();

            // Перебор чисел от 2 до N
            for (int num = 2; num <= n; num++)
            {
                // Находим делители и сумму
                List<int> divisors = new List<int>();
                int sum = 0;

                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        divisors.Add(i);
                        sum += i;
                    }
                }

                // Если число совершенное
                if (sum == num)
                {
                    // Формируем строку с числом и его делителями
                    string divisorsText = string.Join(", ", divisors);
                    listBoxPerfect.Items.Add($"{num}: делители: {divisorsText}");
                }
            }

            if (listBoxPerfect.Items.Count == 0)
            {
                MessageBox.Show("Совершенных чисел в заданном диапазоне не найдено.", "Результат");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxPerfect.Text, out currentPerfectNumber) || currentPerfectNumber <= 0)
            {
                MessageBox.Show("Введите положительное целое число!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            divisors.Clear();

            int sum = 0;
            for (int i = 1; i <= currentPerfectNumber / 2; i++)
            {
                if (currentPerfectNumber % i == 0)
                {
                    divisors.Add(i);
                    sum += i;
                }
            }

            if (sum == currentPerfectNumber)
            {
                labelSumCheck.Text = $"Число {currentPerfectNumber} — Совершенное! Сумма делителей = {sum}";
            
            }
            else
            {
                labelSumCheck.Text = $"Число {currentPerfectNumber} — Не совершенное. Сумма делителей = {sum}";
                
            }

            if (divisors.Count == 0)
            {
                MessageBox.Show("У числа нет делителей кроме самого себя.", "Информация");
                pictureBox.Invalidate(); // Очищаем PictureBox
                return;
            }

            // Запускаем перерисовку PictureBox
            pictureBox.Invalidate();
        }
     
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (divisors.Count == 0) return;

            int totalSum = 0;
            foreach (int d in divisors)
            {
                totalSum += d;
            }

            int marginLeft = 20;   // Отступ слева
            int marginRight = 20;  // Отступ справа
            int availableWidth = pictureBox.Width - marginLeft - marginRight;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = marginLeft;    // Начальная позиция с отступом слева
            int y = 50;
            int height = 80;

            for (int i = 0; i < divisors.Count; i++)
            {
                double fraction = (double)divisors[i] / totalSum;
                int width = (int)(fraction * availableWidth);

                g.FillRectangle(Brushes.Gold, x, y, width, height);
                g.DrawRectangle(Pens.Black, x, y, width, height);
                g.DrawString(divisors[i].ToString(), new Font("Arial", 10), Brushes.DarkRed, x + 30, y + 30);

                x += width;  // Сдвигаем на ширину прямоугольника (без дополнительного отступа)
            }
        }
    }
}
         

