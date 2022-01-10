using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;

namespace SuperheroesMVVM
{
    class Superheroe : ObservableObject
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    SetProperty(ref _nombre, value);
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                if (_imagen != value)
                {
                    SetProperty(ref _imagen, value);
                }
            }
        }

        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set
            {
                if (_vengador != value)
                {
                    SetProperty(ref _vengador, value);
                }
            }
        }

        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set
            {
                if (_xmen != value)
                {
                    SetProperty(ref _xmen, value);
                }
            }
        }

        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set
            {
                if (_heroe != value)
                {
                    SetProperty(ref _heroe, value);
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        //public static List<Superheroe> GetSamples()
        //{
        //    List<Superheroe> ejemplos = new List<Superheroe>();

        //    Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
        //    Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
        //    Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

        //    ejemplos.Add(ironman);
        //    ejemplos.Add(kingpin);
        //    ejemplos.Add(spiderman);

        //    return ejemplos;
        //}
    }
}
