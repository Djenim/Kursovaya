using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berhstein {
    interface IObservable {
        void RegisterObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
        void NotifyObservers();
    }
    interface IObserver {
        void Update(object obj);
    }
    //биржа (паттенр Одиночка и Наблюдатель)
    class Burse : IObservable {
        //данные биржи
        public BurseInfo BurseInfo { get; }
        //список участвующих брокеров
        private List<IObserver> brokers;
        //список брокеров, которые отображается на экране
        private ListBox list;
        private static Burse instance;
        //установка отображаемого списка
        public void SetList(ListBox l) {
            list = l;
        }
        //ссылка на объект-синглтон
        public static Burse BurseInstance {
            get {
                if (instance == null) {
                    instance = new Burse();
                }
                return instance;
            }
        }
        private Burse() {
            //инициализация объектов
            BurseInfo = new BurseInfo();
            brokers = new List<IObserver>();
        }
        //регистрация наблюдателя
        public void RegisterObserver(IObserver obs) {
            brokers.Add(obs);
        }
        //удаление наблюдателя
        public void RemoveObserver(IObserver obs) {
            brokers.Remove(obs);
        }
        //оповещение наблюдателей
        public void NotifyObservers() {
            foreach (IObserver item in brokers) {
                item.Update(BurseInfo);
            }
            //отображение списка брокеров
            if (list != null) {
                list.Items.Clear();
                foreach (Broker item in brokers) {
                    list.Items.Add(string.Format("{0}({1}): {2} ({3}) грн.", item.Name, item.MinSale, item.Active, item.UAH));
                }
            }
        }
        //имитация торгов
        public void Market() {
            Random rand = new Random();
            int maxU = rand.Next(25, 30);
            int minU = rand.Next(20, 25);
            int maxE = rand.Next(27, 33);
            int minE = rand.Next(22, 27);
            //случайным образом задается новый курс доллара и евро
            BurseInfo.USD = rand.Next(minU, maxU);
            BurseInfo.Euro = rand.Next(minE, maxE);
            //оповещение брокеров
            NotifyObservers();
        }
    }
    //данные биржи
    class BurseInfo {
        //курс доллара и евро
        public float USD { get; set; }
        public float Euro { get; set; }
    }
    //брокер на бирже
    class Broker : IObserver {
        private ITrade brokerStrategy { get; set; }
        //имя брокера
        public string Name { get; }
        //гривневые активы
        public float UAH {
            get { return _uah; }
        }
        private float _uah = 1000f;
        //валютные активы
        public float Valute {
            get { return _valute; }
        }
        private float _valute = 0;
        //общие активы
        public float Active { get; private set; }
        public float MinSale { get; }
        IObservable burse;
        //обновляем состояние (стратегию действий) брокера
        public void Update(object obj) {
            BurseInfo info = obj as BurseInfo;
            //покупаем 10 долларов
            if (info.USD <= MinSale) {
                brokerStrategy = new Buy(UAH, Valute, info.USD);
            }
            //продаем 10 долларов
            else {
                brokerStrategy = new Sale(UAH, Valute, info.USD);
            }
            //пересчитываем активы
            brokerStrategy.Trade(out _uah, out _valute);
            Active = UAH + Valute * info.USD;
        }
        //конструктор
        public Broker(string name, float m, IObservable obs) {
            Name = name;
            MinSale = m;
            burse = obs;
            //регистрация данного брокера на бирже
            burse.RegisterObserver(this);
        }
        //отмена торгов
        public void StopTrade() {
            //отписка от биржи
            burse.RemoveObserver(this);
            burse = null;
        }
    }
    //паттерн Стратегия
    interface ITrade {
        void Trade(out float u, out float v);
    }
    //продажа
    public class Sale : ITrade {
        float rate; //курс
        float uah; //гривна
        float valute; //валюта
        //конструктор
        public Sale(float u, float v, float r) {
            rate = r;
            uah = u;
            valute = v;
        }
        //метод, осуществляющий продажу валюты
        public void Trade(out float u, out float v) {
            if (valute - 10 >= 0) {
                uah += 10 * rate;
                valute -= 10;
            }
            u = uah;
            v = valute;
        }
    }
    //покупка
    public class Buy : ITrade {
        float rate; //курс
        float uah; //гривна
        float valute; //валюта
        //конструктор
        public Buy(float u, float v, float r) {
            rate = r;
            uah = u;
            valute = v;
        }
        //метод, осуществляющий покупку валюты
        public void Trade(out float u, out float v) {
            if (uah - 10 * rate >= 0) {
                uah -= 10 * rate;
                valute += 10;
            }
            u = uah;
            v = valute;
        }
    }
}
