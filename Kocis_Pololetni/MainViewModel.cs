using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Collection
{
    public class MainViewModel
    {
        private Figurka _figurka;

        ObservableCollection<Figurka> Figurky { get; set; }

        //Vytažení jednotlivých proměnných z Modelu
        public string Nazev
        {
            get { return _figurka.Nazev; }
            set { _figurka.Nazev = value; }
        }

        public string Druh
        {
            get { return _figurka.Druh; }
            set { _figurka.Druh = value; }
        }

        public string Cislo
        {
            get { return _figurka.Cislo; }
            set { _figurka.Cislo = value; }
        }

        public MainViewModel()
        {

            Figurky = new ObservableCollection<Figurka>
            {
                new Figurka
                {
                    //Jen příklad na zkoušku
                    Nazev = "Yondu",
                    Druh = "MARVEL",
                    Cislo = "310",
                    Viditelnost = false

                },
            };

        }

        //Metoda pro přidání do kolekce
        public void PridatDoKolekce()
        {
            Figurky.Add(_figurka);
        }

        //Metoda pro skrytí či zobrazení "bloku" s figurkou
        public void SkrytNeboZobrazitFigurku(Figurka figurka)
        {
            if(_figurka == figurka)
            {
                //DoubleClick schová figurku
                _figurka.Viditelnost = !figurka.Viditelnost;
                UpdateKolekce(figurka);
            }

            else
            {
                if(_figurka != null)
                {
                    //skryje předešlou figurku
                    _figurka.Viditelnost = false;
                    UpdateKolekce(_figurka);
                }
                //zobrazí selektnutou figurku
                figurka.Viditelnost = true;
                UpdateKolekce(figurka);
            }

            _figurka = figurka;
        }

        //Metoda pro aktualizování stavu celé kolekce
        private void UpdateKolekce(Figurka figurka)
        {
            var index = Figurky.IndexOf(figurka);
            Figurky.Remove(figurka);
            Figurky.Insert(index, figurka);
        }
    }
}
