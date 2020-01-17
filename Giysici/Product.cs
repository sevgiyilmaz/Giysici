using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giysici
{
    class Product
    {
        public string Beden { get; set; }
        public bool Yazlık { get; set; }
        public string Renkler { get; set; }       

        private string _marka;
        private decimal _markaCarpani = 1;
        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                switch (value)
                {
                    case "LCWaikiki":
                        _markaCarpani = 1;
                        break;
                    case "Lewis":
                        _markaCarpani = 3;
                        break;
                    case "Mavi":
                        _markaCarpani = 2.5m;
                        break;
                    case "Zara":
                        _markaCarpani = 4;
                        break;
                    case "Koton":
                        _markaCarpani = 1.5m;
                        break;
                    case "Decathlon":
                        _markaCarpani = 2;
                        break;
                    case "Oysho":
                        _markaCarpani = 2;
                        break;
                    case "PullandBear":
                        _markaCarpani = 2.5m;
                        break;
                    case "Defacto":
                        _markaCarpani = 1.25m;
                        break;
                    case "Ramsey":
                        _markaCarpani = 8;
                        break;
                    case "HandM":
                        _markaCarpani = 2;
                        break;
                }
                _marka = value;
            }
        }
        private string _tur;
        private decimal _turFiyat = 0;
        public string Tur
        {
            get
            {
                return _tur;
            }
            set
            {
                switch (value)
                {
                    case "Pantolon":
                        _turFiyat = 50;
                        break;
                    case "Elbise":
                        _turFiyat = 110;
                        break;
                    case "Bluz":
                        _turFiyat = 70;
                        break;
                    case "Gömlek":
                        _turFiyat = 30;
                        break;
                    case "Etek":
                        _turFiyat = 40;
                        break;
                    case "Tulum":
                        _turFiyat = 150;
                        break;
                    case "T-Shirt":
                        _turFiyat = 20;
                        break;
                    case "Şort":
                        _turFiyat = 25;
                        break;
                    case "Takım Elbise":
                        _turFiyat = 500;
                        break;
                    case "Şapka":
                        _turFiyat = 15;
                        break;
                    case "Ayakkabı":
                        _turFiyat = 120;
                        break;
                    case "Kemer":
                        _turFiyat = 25;
                        break;
                }
                _tur = value;
            }
        }

        public int Adet { get; set; }
        public decimal Fiyat { get { return _turFiyat * _markaCarpani; } }
        public decimal AraToplam { get { return Adet * (_turFiyat * _markaCarpani); } }
        public override string ToString()
        {
            return $"Marka:{_marka}|Tur:{_tur}|Beden:{Beden}|Renk:{Renkler}|Yazlıkmı:{(Yazlık ? "Yazlık" : "Kışlık")}|Fiyat:{(_turFiyat * _markaCarpani).ToString("C2")}|Adet:{Adet}|Ara Toplam:{AraToplam.ToString("c2")}";
        }
    }
}
