using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Juwerely_store.Res.ChainofStorePage
{
    public partial class Map: Form
    {

        #region Markers
        GMarkerGoogle marker1;
        GMarkerGoogle marker2;
        GMarkerGoogle marker3;
        GMarkerGoogle marker4;
        GMarkerGoogle marker5;
        GMarkerGoogle marker6;
        GMarkerGoogle marker7;
        GMarkerGoogle marker8;
        GMarkerGoogle marker9;
        GMarkerGoogle marker10;
        GMarkerGoogle marker11;
        GMarkerGoogle marker12;
        GMarkerGoogle marker13;
        GMarkerGoogle marker14;
        GMarkerGoogle marker15;
        GMarkerGoogle marker16;
        GMarkerGoogle marker17;
        GMarkerGoogle marker18;
        GMarkerGoogle marker19;


        #endregion
        #region Долготы и Широты соотношение 1 к 1 2 к 2 
        double dolg1 = 55.75469920264955;
        double shir1 = 37.62147903442383;
        double dolg2 = 55.749627360810486;
        double shir2 = 37.59826183319092;
        double dolg3 = 55.75341922858881;
        double shir3 = 37.6122522354126;
        double dolg4 = 55.75049686624562;
        double shir4 = 37.59388446807861;
        double dolg5 = 55.75675190353971;
        double shir5 = 37.59654521942139;
        double dolg6 = 55.75786282836846;
        double shir6 = 37.60180418749735;
        double dolg7 = 55.75887703533419;
        double shir7 = 37.602726867398474;
        double dolg8 = 53.89558919394205;
        double shir8 = 27.54796453060476;
        double dolg9 = 53.90375664463047;
        double shir9 = 27.558603286743164;
        double dolg10 = 53.889646185903146;
        double shir10 = 27.585597038269043;
        double dolg11 = 53.87793115965895;
        double shir11 = 27.533943937409845;
        double dolg12 = 53.876995089193706;
        double shir12 = 27.51611975578885;
        double dolg13 = 53.875299825641555;
        double shir13 = 27.499150639923528;
        double dolg14 = 53.87936658999192;
        double shir14 = 27.48140481668088;
        double dolg15 = 53.89427433456289;
        double shir15 = 27.48277187347412;
        double dolg16 = 53.90617576229811;
        double shir16 = 27.52332339956922;
        double dolg17 = 52.08711453067115;
        double shir17 = 23.699287076467726;
        double dolg18 = 52.09353459128322;
        double shir18 = 23.685969015970272;
        double dolg19 = 52.081409;
        double shir19 = 23.770126;


        #endregion

        GMapOverlay mapOverlay;
        DataTable dt;
        public Map()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            DescTxt.Visible = false;
            ShirTxt.Visible = false;
            DolgTxt.Visible = false;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Описание", typeof(string)));
            dt.Columns.Add(new DataColumn("Долгота", typeof(double)));
            dt.Columns.Add(new DataColumn("Широта", typeof(double)));

            dt.Rows.Add("Магазин Москва ГУМ", 55.75469920264955, 37.62147903442383);
            dt.Rows.Add("Магазин Москва Старый Арбат", 55.749627360810486, 37.59826183319092);
            dt.Rows.Add("Магазин Москва Манеж", 55.75341922858881, 37.6122522354126);
            dt.Rows.Add("Магазин Москва Дом Верх Дном", 55.75049686624562, 37.59388446807861);
            dt.Rows.Add("Магазин Москва Музей Десерта", 55.75675190353971, 37.59654521942139);
            dt.Rows.Add("Магазин Москва Аукцион и Музей", 55.75786282836846, 37.60180418749735);
            dt.Rows.Add("Магазин Москва Дом Станиславского", 55.75887703533419, 37.602726867398474);




            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(dolg1, shir1);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            mapOverlay = new GMapOverlay("Moscow");
            marker1 = new GMarkerGoogle(new PointLatLng(dolg1, shir1), GMarkerGoogleType.red);
            marker2 = new GMarkerGoogle(new PointLatLng(dolg2, shir2), GMarkerGoogleType.red);
            marker3 = new GMarkerGoogle(new PointLatLng(dolg3, shir3), GMarkerGoogleType.red);
            marker4 = new GMarkerGoogle(new PointLatLng(dolg4, shir4), GMarkerGoogleType.red);
            marker5 = new GMarkerGoogle(new PointLatLng(dolg5, shir5), GMarkerGoogleType.red);
            marker6 = new GMarkerGoogle(new PointLatLng(dolg6, shir6), GMarkerGoogleType.red);
            marker7 = new GMarkerGoogle(new PointLatLng(dolg7, shir7), GMarkerGoogleType.red);
            marker8 = new GMarkerGoogle(new PointLatLng(dolg8, shir8), GMarkerGoogleType.red);
            marker9 = new GMarkerGoogle(new PointLatLng(dolg9, shir9), GMarkerGoogleType.red);
            marker10 = new GMarkerGoogle(new PointLatLng(dolg10, shir10), GMarkerGoogleType.red);
            marker11 = new GMarkerGoogle(new PointLatLng(dolg11, shir11), GMarkerGoogleType.red);
            marker12 = new GMarkerGoogle(new PointLatLng(dolg12, shir12), GMarkerGoogleType.red);
            marker13 = new GMarkerGoogle(new PointLatLng(dolg13, shir13), GMarkerGoogleType.red);
            marker14 = new GMarkerGoogle(new PointLatLng(dolg14, shir14), GMarkerGoogleType.red);
            marker15 = new GMarkerGoogle(new PointLatLng(dolg15, shir15), GMarkerGoogleType.red);
            marker16 = new GMarkerGoogle(new PointLatLng(dolg16, shir16), GMarkerGoogleType.red);
            marker17 = new GMarkerGoogle(new PointLatLng(dolg17, shir17), GMarkerGoogleType.red);
            marker18 = new GMarkerGoogle(new PointLatLng(dolg18, shir18), GMarkerGoogleType.red);
            marker19 = new GMarkerGoogle(new PointLatLng(dolg19, shir19), GMarkerGoogleType.red);


            mapOverlay.Markers.Add(marker1);
            mapOverlay.Markers.Add(marker2);
            mapOverlay.Markers.Add(marker3);
            mapOverlay.Markers.Add(marker4);
            mapOverlay.Markers.Add(marker5);
            mapOverlay.Markers.Add(marker6);
            mapOverlay.Markers.Add(marker7);
            mapOverlay.Markers.Add(marker8);
            mapOverlay.Markers.Add(marker9);
            mapOverlay.Markers.Add(marker10);
            mapOverlay.Markers.Add(marker11);
            mapOverlay.Markers.Add(marker12);
            mapOverlay.Markers.Add(marker13);
            mapOverlay.Markers.Add(marker14);
            mapOverlay.Markers.Add(marker15);
            mapOverlay.Markers.Add(marker16);
            mapOverlay.Markers.Add(marker17);
            mapOverlay.Markers.Add(marker18);
            mapOverlay.Markers.Add(marker19);



            marker1.ToolTipMode = MarkerTooltipMode.Always;
            marker1.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Тверской бульвар, 22 (м. Пушкинская)", "8:00 - 18:00"); // тут указываешь что будет в окне над маркером можешь указать типо город улица время работы будет не плохо , в качестве примера сделаю 1

            marker2.ToolTipMode = MarkerTooltipMode.Always;
            marker2.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Шереметьевская, 8 (м. Рижская)", "8:00 - 18:00");

            marker3.ToolTipMode = MarkerTooltipMode.Always;
            marker3.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Земляной вал, 76/21 (м. Таганская)", "8:00 - 18:00");

            marker4.ToolTipMode = MarkerTooltipMode.Always;
            marker4.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", " Б. Никитский, 23/9 (м. Арбатская, Пушкинская)", "8:00 - 18:00");

            marker5.ToolTipMode = MarkerTooltipMode.Always;
            marker5.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Стромынка, 6 (м. Сокольники)", "8:00 - 18:00");

            marker6.ToolTipMode = MarkerTooltipMode.Always;
            marker6.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Фролов пер, 2 (м. Тургеневская, Чистые пруды)", "8:00 - 18:00");

            marker7.ToolTipMode = MarkerTooltipMode.Always;
            marker7.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Москва", "Малая Дмитровка, 6 (м. Тверская, Пушкинская, Чеховская)", "8:00 - 18:00");

            marker8.ToolTipMode = MarkerTooltipMode.Always;
            marker8.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Володарского, 5", "8:00 - 18:00");

            marker9.ToolTipMode = MarkerTooltipMode.Always;
            marker9.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", " ул. Козлова, 17", "8:00 - 18:00");

            marker10.ToolTipMode = MarkerTooltipMode.Always;
            marker10.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Советская, 15", "8:00 - 18:00");

            marker11.ToolTipMode = MarkerTooltipMode.Always;
            marker11.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", " пр-т Независимости, 25", "8:00 - 18:00");

            marker12.ToolTipMode = MarkerTooltipMode.Always;
            marker12.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Красноармейская, 15", "8:00 - 18:00");

            marker13.ToolTipMode = MarkerTooltipMode.Always;
            marker13.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", " ул. Фабрициуса, 26", "8:00 - 18:00");

            marker14.ToolTipMode = MarkerTooltipMode.Always;
            marker14.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Энгельса, 20", "8:00 - 18:00");

            marker15.ToolTipMode = MarkerTooltipMode.Always;
            marker15.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Фрунзе, 55", "8:00 - 18:00");

            marker16.ToolTipMode = MarkerTooltipMode.Always;
            marker16.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Минск", "ул. Гаврирола, 16", "8:00 - 18:00");

            marker17.ToolTipMode = MarkerTooltipMode.Always;
            marker17.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Брест", "ул. Московская, 328", "8:00 - 18:00");

            marker18.ToolTipMode = MarkerTooltipMode.Always;
            marker18.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Брест", "ул. Брестских дивизий, 24", "8:00 - 18:00");

            marker19.ToolTipMode = MarkerTooltipMode.Always;
            marker19.ToolTipText = string.Format("Город:{0} \n Улица:{1} \n Время Работы:{2}", "Брест", "Варшаское шоссе, 24", "8:00 - 18:00");

            gMapControl1.Overlays.Add(mapOverlay);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;

        }
    }
}
