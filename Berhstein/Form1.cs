using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berhstein {
    public partial class BurseApp : Form {
        public BurseApp() {
            InitializeComponent();
            //получаем ссылку на биржу
            internationalBurse = Burse.BurseInstance;
            //устанавливаем список
            internationalBurse.SetList(listBrokers);
            //инициализация объектов для рисования графиков
            graphUSD = new GraphBuilder(pbGraphic, Color.FromArgb(50, 100, 200));
            graphEuro = new GraphBuilder(pbGraphic, Color.FromArgb(200, 50, 50));
            InitializeTradeTimer();
        }
        //ссылка на объект международной биржи
        Burse internationalBurse;
        //объекты рисования графиков курса доллара и евро
        GraphBuilder graphUSD;
        GraphBuilder graphEuro;

        Timer trade;
        //инициализация таймера торгов
        private void InitializeTradeTimer() {
            trade = new Timer();
            trade.Interval = 500;
            trade.Tick += MarketAction;
        }
        private void MarketAction(object sender, EventArgs e) {
            internationalBurse.Market();
            float differenceUSD = internationalBurse.BurseInfo.USD - 25;
            graphUSD.Step(differenceUSD * 15f);
            float differenceEuro = internationalBurse.BurseInfo.Euro - 25;
            //graphEuro.Step(differenceEuro * 15f);
        }

        //запуск торгов
        private void btnStartTrade_Click(object sender, EventArgs e) {
            trade.Start();
        }
        //остановка торгов
        private void btnStopTrade_Click(object sender, EventArgs e) {
            trade.Stop();
        }
        //регистрация участника
        private void btnRegistrate_Click(object sender, EventArgs e) {
            if (txtParticipant.Text == string.Empty) return;
            Broker b = new Broker(txtParticipant.Text, new Random().Next(22, 28), internationalBurse);
            txtParticipant.Text = string.Empty;
            listBrokers.Items.Add(b.Name);
        }
        //регистрация участника по нажатию Enter
        private void txtParticipant_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnRegistrate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
    //класс для рисования графика
    class GraphBuilder {
        //поле для рисования
        PictureBox canvas; 
        //последняя соединенная точка
        PointF lastPoint;
        //"перо", которой рисуется линия
        Pen pen;
        //шаг графика
        int step = 3;
        //умолчательное значение координаты Y для данного графика
        int defaultY;
        //заливка белым цветом
        void ResetCanvas() {
            using (Graphics g = Graphics.FromImage(canvas.Image)) {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, canvas.Width, canvas.Height);
                g.DrawLine(new Pen(Color.Black), 0, defaultY, canvas.Width, defaultY);
            }
        }
        //конструктор
        public GraphBuilder(PictureBox pb, Color col) {
            canvas = pb;
            //начальным значением будет центр графика
            defaultY = canvas.Height / 2;
            //точка устанавливается в начало
            lastPoint = new Point(0, defaultY);
            //создатеся "перо" заданного цвета
            pen = new Pen(col);
            //если поле для рисования не инициализировано
            if (canvas.Image == null) {
                //инициализируем новое поле
                canvas.Image = new Bitmap(canvas.Width, canvas.Height);
                ResetCanvas();
            }
        }
        //продвижение графика к следующей точке
        public void Step(float value) {
            //получаем графический объект g, с помощью которого осуществляется рисование
            using (Graphics g = Graphics.FromImage(canvas.Image)) {
                //вычисляем координаты новой точки
                PointF pt = new PointF(lastPoint.X + step, defaultY - value);
                //соединяем последнюю точку и новую
                g.DrawLine(pen, lastPoint, pt);
                //новая точка стает последней
                lastPoint = pt;
                //перерисовка поля
                canvas.Refresh(); 
                //если координата Х вышла за границу поля, то обнуляем ее
                //и заново рисуем поле
                if (lastPoint.X > canvas.Width) {
                    lastPoint.X = 0;
                    ResetCanvas();
                }
            }
        }
    }

}
