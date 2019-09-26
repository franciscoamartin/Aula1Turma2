using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDados.Model;

namespace LeitorDados.Model
{
    public class RelatorioContext
    {
        public int IdContadorCarros { get; set; } = 1;

        public List<Carros> Carros { get; set; }

        public RelatorioContext()
        {
            Carros = new List<Carros>();

            #region Lista

            Carros.Add(new Carros { Id = 01,  Carro = " Risus Company                      ", Valor = 7.200, Quantidade = 18,   Data = DateTime.Parse(" 29 / 01 / 2019") });
            Carros.Add(new Carros { Id = 02,  Carro = " Risus Associates                   ", Valor = 9.961, Quantidade = 04,   Data = DateTime.Parse(" 10 / 02 / 2019") });
            Carros.Add(new Carros { Id = 03,  Carro = " Et Libero Proin Foundation         ", Valor = 8.710, Quantidade = 17,   Data = DateTime.Parse(" 24 / 01 / 2019") });
            Carros.Add(new Carros { Id = 04,  Carro = " Cursus Et Ltd                      ", Valor = 9.010, Quantidade = 17,   Data = DateTime.Parse(" 26 / 10 / 2019") });
            Carros.Add(new Carros { Id = 05,  Carro = " Odio Etiam Ligula Company          ", Valor = 5.245, Quantidade = 08,   Data = DateTime.Parse(" 16 / 02 / 2019") });
            Carros.Add(new Carros { Id = 06,  Carro = " Eu Nibh Inc.                       ", Valor = 7.922, Quantidade = 09,   Data = DateTime.Parse(" 27 / 06 / 2019") });
            Carros.Add(new Carros { Id = 07,  Carro = " Tellus Limited                     ", Valor = 7.294, Quantidade = 07,   Data = DateTime.Parse(" 26 / 01 / 2019") });
            Carros.Add(new Carros { Id = 08,  Carro = " Imperdiet PC                       ", Valor = 8.305, Quantidade = 05,   Data = DateTime.Parse(" 06 / 09 / 2019") });
            Carros.Add(new Carros { Id = 09,  Carro = " Elit Inc.	                      ", Valor = 5.398, Quantidade = 18,    Data = DateTime.Parse(" 09 / 06 / 2019") });
            Carros.Add(new Carros { Id = 10,  Carro = "Quam A Limited                     ", Valor = 5.398, Quantidade = 14,    Data = DateTime.Parse(" 09 / 09 / 2019") });
            Carros.Add(new Carros { Id = 11,  Carro = "Adipiscing Institute               ", Valor = 8.133, Quantidade = 04,    Data = DateTime.Parse(" 24 / 10 / 2019") });
            Carros.Add(new Carros { Id = 12,  Carro = "Posuere At Velit Ltd               ", Valor = 5.121, Quantidade = 15,    Data = DateTime.Parse(" 19 / 11 / 2019") });
            Carros.Add(new Carros { Id = 13,  Carro = "Nunc In Industries                 ", Valor = 8.902, Quantidade = 02,    Data = DateTime.Parse(" 21 / 07 / 2019") });
            Carros.Add(new Carros { Id = 14,  Carro = "Integer Vitae Nibh Corporation     ", Valor = 6.313, Quantidade = 20,    Data = DateTime.Parse(" 02 / 02 / 2019") });
            Carros.Add(new Carros { Id = 15,  Carro = "Tellus Nunc Lectus Company         ", Valor = 9.650, Quantidade = 02,    Data = DateTime.Parse(" 20 / 07 / 2019") });
            Carros.Add(new Carros { Id = 16,  Carro = "Suspendisse LLC                    ", Valor = 5.319, Quantidade = 12,    Data = DateTime.Parse(" 24 / 12 / 2019") });
            Carros.Add(new Carros { Id = 17,  Carro = "Mauris Vestibulum Corporation      ", Valor = 5.790, Quantidade = 05,    Data = DateTime.Parse(" 14 / 11 / 2019") });
            Carros.Add(new Carros { Id = 18,  Carro = "Sed Nec Corp.                      ", Valor = 8.421, Quantidade = 02,    Data = DateTime.Parse(" 05 / 05 / 2019") });
            Carros.Add(new Carros { Id = 19,  Carro = "Enim Nisl Elementum Inc.	          ", Valor = 5.904, Quantidade = 06,    Data = DateTime.Parse(" 26 / 06 / 2019") });
            Carros.Add(new Carros { Id = 20,  Carro = "Ac Mattis Semper Corporation       ", Valor = 5.110, Quantidade = 04,    Data = DateTime.Parse(" 14 / 01 / 2019") });
            Carros.Add(new Carros { Id = 21,  Carro = "Donec Tempus Lorem LLC             ", Valor = 8.576, Quantidade = 16,    Data = DateTime.Parse(" 29 / 03 / 2019") });
            Carros.Add(new Carros { Id = 22,  Carro = "Tempor Augue Ac Ltd                ", Valor = 9.072, Quantidade = 16,    Data = DateTime.Parse(" 09 / 07 / 2019") });
            Carros.Add(new Carros { Id = 23,  Carro = "Diam Duis Mi LLC                   ", Valor = 8.472, Quantidade = 04,    Data = DateTime.Parse(" 23 / 09 / 2019") });
            Carros.Add(new Carros { Id = 24,  Carro = "Aliquam Corp.	                  ", Valor = 6.607, Quantidade = 04,    Data = DateTime.Parse(" 28 / 09 / 2019") });
            Carros.Add(new Carros { Id = 25,  Carro = "Montes Institute                   ", Valor = 6.176, Quantidade = 08,    Data = DateTime.Parse(" 19 / 06 / 2019") });
            Carros.Add(new Carros { Id = 26,  Carro = "Hendrerit Institute                ", Valor = 8.387, Quantidade = 11,    Data = DateTime.Parse(" 17 / 09 / 2019") });
            Carros.Add(new Carros { Id = 27,  Carro = "Erat Etiam Vestibulum Corporation  ", Valor = 7.584, Quantidade = 09,    Data = DateTime.Parse(" 02 / 06 / 2019") });
            Carros.Add(new Carros { Id = 28,  Carro = "Adipiscing Ltd                     ", Valor = 7.887, Quantidade = 09,    Data = DateTime.Parse(" 19 / 03 / 2019") });
            Carros.Add(new Carros { Id = 29,  Carro = "In Tempus Eu Inc.	              ", Valor = 5.233, Quantidade = 16,    Data = DateTime.Parse(" 20 / 07 / 2019") });
            Carros.Add(new Carros { Id = 30,  Carro = "Elit Institute                     ", Valor = 7.359, Quantidade = 11,    Data = DateTime.Parse(" 12 / 09 / 2019") });
            Carros.Add(new Carros { Id = 31,  Carro = "Aliquam Erat LLC                   ", Valor = 8.842, Quantidade = 04,    Data = DateTime.Parse(" 14 / 03 / 2019") });
            Carros.Add(new Carros { Id = 32,  Carro = "A Feugiat Tellus PC                ", Valor = 9.176, Quantidade = 04,    Data = DateTime.Parse(" 10 / 12 / 2019") });
            Carros.Add(new Carros { Id = 33,  Carro = "Aliquet Incorporated               ", Valor = 9.057, Quantidade = 08,    Data = DateTime.Parse(" 26 / 04 / 2019") });
            Carros.Add(new Carros { Id = 34,  Carro = "Dolor Dolor Tempus Institute       ", Valor = 8.433, Quantidade = 15,    Data = DateTime.Parse(" 31 / 10 / 2019") });
            Carros.Add(new Carros { Id = 35,  Carro = "Risus Odio Auctor PC               ", Valor = 8.286, Quantidade = 11,    Data = DateTime.Parse(" 29 / 03 / 2019") });
            Carros.Add(new Carros { Id = 36,  Carro = "Aliquet Molestie Tellus Corp.	  ", Valor = 8.779, Quantidade = 01,    Data = DateTime.Parse(" 05 / 07 / 2019") });
            Carros.Add(new Carros { Id = 37,  Carro = "Ipsum Corp.	                      ", Valor = 5.568, Quantidade = 15,    Data = DateTime.Parse(" 10 / 03 / 2019") });
            Carros.Add(new Carros { Id = 38,  Carro = "Mi Lacinia Foundation              ", Valor = 7.442, Quantidade = 20,    Data = DateTime.Parse(" 09 / 07 / 2019") });
            Carros.Add(new Carros { Id = 39,  Carro = "Cubilia Curae; Corp.               ", Valor = 8.421, Quantidade = 07,    Data = DateTime.Parse(" 26 / 05 / 2019") });
            Carros.Add(new Carros { Id = 40,  Carro = "Velit Sed Malesuada Associates     ", Valor = 9.841, Quantidade = 06,    Data = DateTime.Parse(" 07 / 11 / 2019") });
            Carros.Add(new Carros { Id = 41,  Carro = "Duis Foundation                    ", Valor = 9.849, Quantidade = 06,    Data = DateTime.Parse(" 08 / 12 / 2019") });
            Carros.Add(new Carros { Id = 42,  Carro = "Erat Semper Consulting             ", Valor = 6.168, Quantidade = 10,    Data = DateTime.Parse(" 10 / 11 / 2019") });
            Carros.Add(new Carros { Id = 43,  Carro = "Turpis Inc.	                      ", Valor = 7.758, Quantidade = 07,    Data = DateTime.Parse(" 12 / 08 / 2019") });
            Carros.Add(new Carros { Id = 44,  Carro = "Aenean Industries                  ", Valor = 8.770, Quantidade = 12,    Data = DateTime.Parse(" 10 / 09 / 2019") });
            Carros.Add(new Carros { Id = 45,  Carro = "Nulla Industries                   ", Valor = 8.884, Quantidade = 08,    Data = DateTime.Parse(" 10 / 11 / 2019") });
            Carros.Add(new Carros { Id = 46,  Carro = "Semper Egestas Urna Inc.	          ", Valor = 9.428, Quantidade = 11,    Data = DateTime.Parse(" 26 / 06 / 2019") });
            Carros.Add(new Carros { Id = 47,  Carro = "Donec Luctus Aliquet Industries    ", Valor = 5.928, Quantidade = 08,    Data = DateTime.Parse(" 11 / 07 / 2019") });
            Carros.Add(new Carros { Id = 48,  Carro = "Cum Sociis Natoque Foundation      ", Valor = 7.506, Quantidade = 02,    Data = DateTime.Parse(" 21 / 07 / 2019") });
            Carros.Add(new Carros { Id = 49,  Carro = "Vitae Sodales Limited              ", Valor = 8.912, Quantidade = 08,    Data = DateTime.Parse(" 22 / 06 / 2019") });
            Carros.Add(new Carros { Id = 50,  Carro = "Tellus Sem Mollis Ltd              ", Valor = 9.615, Quantidade = 20,    Data = DateTime.Parse(" 30 / 10 / 2019") });
            Carros.Add(new Carros { Id = 51,  Carro = "Nulla Tincidunt LLC                ", Valor = 5.562, Quantidade = 19,    Data = DateTime.Parse(" 22 / 09 / 2019") });
            Carros.Add(new Carros { Id = 52,  Carro = "Sed Dictum Institute               ", Valor = 9.243, Quantidade = 14,    Data = DateTime.Parse(" 26 / 06 / 2019") });
            Carros.Add(new Carros { Id = 53,  Carro = "Sed Turpis Company                 ", Valor = 7.243, Quantidade = 14,    Data = DateTime.Parse(" 20 / 08 / 2019") });
            Carros.Add(new Carros { Id = 54,  Carro = "Vitae Diam Proin Associates        ", Valor = 6.631, Quantidade = 02,    Data = DateTime.Parse(" 10 / 06 / 2019") });
            Carros.Add(new Carros { Id = 55,  Carro = "Curabitur Inc.	                  ", Valor = 8.090, Quantidade = 03,    Data = DateTime.Parse(" 09 / 02 / 2019") });
            Carros.Add(new Carros { Id = 56,  Carro = "Suscipit Est Ac LLC                ", Valor = 8.567, Quantidade = 15,    Data = DateTime.Parse(" 08 / 03 / 2019") });
            Carros.Add(new Carros { Id = 57,  Carro = "Neque Morbi Industries             ", Valor = 5.171, Quantidade = 01,    Data = DateTime.Parse(" 03 / 10 / 2019") });
            Carros.Add(new Carros { Id = 58,  Carro = "Non Ltd                            ", Valor = 5.102, Quantidade = 19,    Data = DateTime.Parse(" 14 / 08 / 2019") });
            Carros.Add(new Carros { Id = 59,  Carro = "Arcu Vestibulum Ante Institute     ", Valor = 6.128, Quantidade = 01,    Data = DateTime.Parse(" 08 / 10 / 2019") });
            Carros.Add(new Carros { Id = 60,  Carro = "Nulla Foundation                   ", Valor = 7.636, Quantidade = 06,    Data = DateTime.Parse(" 14 / 04 / 2019") });
            Carros.Add(new Carros { Id = 61,  Carro = "Quis Massa Mauris LLP              ", Valor = 5.053, Quantidade = 03,    Data = DateTime.Parse(" 09 / 10 / 2019") });
            Carros.Add(new Carros { Id = 62,  Carro = "Ut Incorporated                    ", Valor = 6.922, Quantidade = 17,    Data = DateTime.Parse(" 16 / 09 / 2019") });
            Carros.Add(new Carros { Id = 63,  Carro = "Aenean Egestas Corp.               ", Valor = 8.142, Quantidade = 19,    Data = DateTime.Parse(" 17 / 11 / 2019") });
            Carros.Add(new Carros { Id = 64,  Carro = "Fusce Mi Lorem Consulting          ", Valor = 8.312, Quantidade = 20,    Data = DateTime.Parse(" 19 / 11 / 2019") });
            Carros.Add(new Carros { Id = 65,  Carro = "A Sollicitudin Orci PC             ", Valor = 5.864, Quantidade = 01,    Data = DateTime.Parse(" 20 / 03 / 2019") });
            Carros.Add(new Carros { Id = 66,  Carro = "Sociosqu Limited                   ", Valor = 5.985, Quantidade = 12,    Data = DateTime.Parse(" 28 / 11 / 2019") });
            Carros.Add(new Carros { Id = 67,  Carro = "Ullamcorper Duis Cursus LLC        ", Valor = 5.164, Quantidade = 07,    Data = DateTime.Parse(" 22 / 12 / 2019") });
            Carros.Add(new Carros { Id = 68,  Carro = "Nibh Lacinia LLC                   ", Valor = 7.760, Quantidade = 10,    Data = DateTime.Parse(" 13 / 06 / 2019") });
            Carros.Add(new Carros { Id = 69,  Carro = "Eu Dui Institute                   ", Valor = 7.695, Quantidade = 08,    Data = DateTime.Parse(" 12 / 12 / 2019") });
            Carros.Add(new Carros { Id = 70,  Carro = "Fringilla Purus Mauris Consulting  ", Valor = 5.845, Quantidade = 06,    Data = DateTime.Parse(" 01 / 03 / 2019") });
            Carros.Add(new Carros { Id = 71,  Carro = "Donec Tempus Lorem Industries      ", Valor = 8.472, Quantidade = 19,    Data = DateTime.Parse(" 09 / 03 / 2019") });
            Carros.Add(new Carros { Id = 72,  Carro = "Auctor Incorporated                ", Valor = 6.795, Quantidade = 01,    Data = DateTime.Parse(" 04 / 10 / 2019") });
            Carros.Add(new Carros { Id = 73,  Carro = "Enim Etiam Imperdiet Corporation   ", Valor = 6.532, Quantidade = 13,    Data = DateTime.Parse(" 14 / 10 / 2019") });
            Carros.Add(new Carros { Id = 74,  Carro = "Non Cursus Non Industries          ", Valor = 9.569, Quantidade = 16,    Data = DateTime.Parse(" 25 / 10 / 2019") });
            Carros.Add(new Carros { Id = 75,  Carro = "Ut Semper Incorporated             ", Valor = 5.760, Quantidade = 18,    Data = DateTime.Parse(" 14 / 01 / 2019") });
            Carros.Add(new Carros { Id = 76,  Carro = "Sed Malesuada Corporation          ", Valor = 6.561, Quantidade = 04,    Data = DateTime.Parse(" 06 / 03 / 2019") });
            Carros.Add(new Carros { Id = 77,  Carro = "Sed Neque Consulting               ", Valor = 7.308, Quantidade = 02,    Data = DateTime.Parse(" 31 / 08 / 2019") });
            Carros.Add(new Carros { Id = 78,  Carro = "Nisl Arcu PC                       ", Valor = 7.260, Quantidade = 08,    Data = DateTime.Parse(" 19 / 06 / 2019") });
            Carros.Add(new Carros { Id = 79,  Carro = "Euismod Est Consulting             ", Valor = 6.020, Quantidade = 11,    Data = DateTime.Parse(" 27 / 10 / 2019") });
            Carros.Add(new Carros { Id = 80,  Carro = "Leo Vivamus Ltd                    ", Valor = 5.055, Quantidade = 08,    Data = DateTime.Parse(" 22 / 10 / 2019") });
            Carros.Add(new Carros { Id = 81,  Carro = "Tristique Neque Inc.               ", Valor = 9.268, Quantidade = 13,    Data = DateTime.Parse(" 25 / 02 / 2019") });
            Carros.Add(new Carros { Id = 82,  Carro = "In Lobortis PC                     ", Valor = 5.539, Quantidade = 04,    Data = DateTime.Parse(" 18 / 12 / 2019") });
            Carros.Add(new Carros { Id = 83,  Carro = "Nunc Ltd                           ", Valor = 6.846, Quantidade = 02,    Data = DateTime.Parse(" 09 / 10 / 2019") });
            Carros.Add(new Carros { Id = 84,  Carro = "Dictum Proin Limited               ", Valor = 5.543, Quantidade = 12,    Data = DateTime.Parse(" 05 / 10 / 2019") });
            Carros.Add(new Carros { Id = 85,  Carro = "Erat Vitae LLP                     ", Valor = 5.060, Quantidade = 07,    Data = DateTime.Parse(" 12 / 12 / 2019") });
            Carros.Add(new Carros { Id = 86,  Carro = "Pellentesque Ultricies Dignissim PC", Valor = 7.971, Quantidade = 15,    Data = DateTime.Parse(" 25 / 10 / 2019") });
            Carros.Add(new Carros { Id = 87,  Carro = "Phasellus Elit Company             ", Valor = 5.350, Quantidade = 15,    Data = DateTime.Parse(" 31 / 10 / 2019") });
            Carros.Add(new Carros { Id = 88,  Carro = "Luctus Felis Ltd                   ", Valor = 9.872, Quantidade = 13,    Data = DateTime.Parse(" 06 / 01 / 2019") });
            Carros.Add(new Carros { Id = 89,  Carro = "Dui Suspendisse PC                 ", Valor = 6.878, Quantidade = 07,    Data = DateTime.Parse(" 06 / 02 / 2019") });
            Carros.Add(new Carros { Id = 90,  Carro = "Odio Associates                    ", Valor = 7.636, Quantidade = 18,    Data = DateTime.Parse(" 24 / 07 / 2019") });
            Carros.Add(new Carros { Id = 91,  Carro = "Vel Company                        ", Valor = 7.410, Quantidade = 05,    Data = DateTime.Parse(" 16 / 02 / 2019") });
            Carros.Add(new Carros { Id = 92,  Carro = "Lobortis Institute                 ", Valor = 5.110, Quantidade = 08,    Data = DateTime.Parse(" 27 / 05 / 2019") });
            Carros.Add(new Carros { Id = 93,  Carro = "Scelerisque Company                ", Valor = 7.983, Quantidade = 19,    Data = DateTime.Parse(" 03 / 12 / 2019") });
            Carros.Add(new Carros { Id = 94,  Carro = "Posuere Enim Company               ", Valor = 6.968, Quantidade = 19,    Data = DateTime.Parse(" 22 / 04 / 2019") });
            Carros.Add(new Carros { Id = 95,  Carro = "Sem Ut Corp.                       ", Valor = 6.504, Quantidade = 11,    Data = DateTime.Parse(" 02 / 02 / 2019") });
            Carros.Add(new Carros { Id = 96,  Carro = "Dui Fusce Aliquam PC               ", Valor = 7.837, Quantidade = 02,    Data = DateTime.Parse(" 08 / 12 / 2019") });
            Carros.Add(new Carros { Id = 97,  Carro = "Nisl Sem Industries                ", Valor = 6.835, Quantidade = 05,    Data = DateTime.Parse(" 14 / 11 / 2019") });
            Carros.Add(new Carros { Id = 98,  Carro = "Vitae Corp.	                      ", Valor = 7.669, Quantidade = 07,    Data = DateTime.Parse(" 09 / 11 / 2019") });
            Carros.Add(new Carros { Id = 99,  Carro = "Malesuada Incorporated             ", Valor = 5.960, Quantidade = 04,    Data = DateTime.Parse(" 26 / 09 / 2019") });
            Carros.Add(new Carros { Id = 100, Carro = " Mauris Ltd                         ", Valor = 8.974, Quantidade = 18,   Data = DateTime.Parse(" 16 / 05 / 2019") });
            #endregion Lista

            //Carros.Add(new Carros { 1, "Risus Company                      ", 7.200, 18, DateTime.Parse("29/01/2019") });
            //Carros.Add(new Carros { 2, "Risus Associates                   ", 9.961, 4, DateTime.Parse(" 10 / 02 / 2019") });
            //Carros.Add(new Carros {  3,   "Et Libero Proin Foundation         ", 8.710,  17,  DateTime.Parse(" 24 / 01 / 2019") });
            //Carros.Add(new Carros {  4,   "Cursus Et Ltd                      ", 9.010,  17,  DateTime.Parse(" 26 / 10 / 2019") });
            //Carros.Add(new Carros {  5,   "Odio Etiam Ligula Company          ", 5.245,  8,   DateTime.Parse(" 16 / 02 / 2019") });
            //Carros.Add(new Carros {  6,   "Eu Nibh Inc.                       ", 7.922,  9,   DateTime.Parse(" 27 / 06 / 2019") });
            //Carros.Add(new Carros {  7,   "Tellus Limited                     ", 7.294,  7,   DateTime.Parse(" 26 / 01 / 2019") });
            //Carros.Add(new Carros {  8,   "Imperdiet PC                       ", 8.305,  5,   DateTime.Parse(" 06 / 09 / 2019") });
            //Carros.Add(new Carros {  9,   "Elit Inc.	                      ",   5.398,  18,  DateTime.Parse(" 09 / 06 / 2019") });
            //Carros.Add(new Carros {  10,  "Quam A Limited                     ", 5.398,  14,  DateTime.Parse(" 09 / 09 / 2019") });
            //Carros.Add(new Carros {  11,  "Adipiscing Institute               ", 8.133,  4,   DateTime.Parse(" 24 / 10 / 2019") });
            //Carros.Add(new Carros {  12,  "Posuere At Velit Ltd               ", 5.121,  15,  DateTime.Parse(" 19 / 11 / 2019") });
            //Carros.Add(new Carros {  13,  "Nunc In Industries                 ", 8.902,  2,   DateTime.Parse(" 21 / 07 / 2019") });
            //Carros.Add(new Carros {  14,  "Integer Vitae Nibh Corporation     ", 6.313,  20,  DateTime.Parse(" 02 / 02 / 2019") });
            //Carros.Add(new Carros {  15,  "Tellus Nunc Lectus Company         ", 9.650,  2,   DateTime.Parse(" 20 / 07 / 2019") });
            //Carros.Add(new Carros {  16,  "Suspendisse LLC                    ", 5.319,  12,  DateTime.Parse(" 24 / 12 / 2019") });
            //Carros.Add(new Carros {  17,  "Mauris Vestibulum Corporation      ", 5.790,  5,   DateTime.Parse(" 14 / 11 / 2019") });
            //Carros.Add(new Carros {  18,  "Sed Nec Corp.                      ", 8.421,  2,   DateTime.Parse(" 05 / 05 / 2019") });
            //Carros.Add(new Carros {  19,  "Enim Nisl Elementum Inc.	        ", 5.904,  6,   DateTime.Parse(" 26 / 06 / 2019") });
            //Carros.Add(new Carros {  20,  "Ac Mattis Semper Corporation       ", 5.110,  4,   DateTime.Parse(" 14 / 01 / 2019") });
            //Carros.Add(new Carros {  21,  "Donec Tempus Lorem LLC             ", 8.576,  16,  DateTime.Parse(" 29 / 03 / 2019") });
            //Carros.Add(new Carros {  22,  "Tempor Augue Ac Ltd                ", 9.072,  16,  DateTime.Parse(" 09 / 07 / 2019") });
            //Carros.Add(new Carros {  23,  "Diam Duis Mi LLC                   ", 8.472,  4,   DateTime.Parse(" 23 / 09 / 2019") });
            //Carros.Add(new Carros {  24,  "Aliquam Corp.	                    ", 6.607,  4,   DateTime.Parse(" 28 / 09 / 2019") });
            //Carros.Add(new Carros {  25,  "Montes Institute                   ", 6.176,  8,   DateTime.Parse(" 19 / 06 / 2019") });
            //Carros.Add(new Carros {  26,  "Hendrerit Institute                ", 8.387,  11,  DateTime.Parse(" 17 / 09 / 2019") });
            //Carros.Add(new Carros {  27,  "Erat Etiam Vestibulum Corporation  ", 7.584,  9,   DateTime.Parse(" 02 / 06 / 2019") });
            //Carros.Add(new Carros {  28,  "Adipiscing Ltd                     ", 7.887,  9,   DateTime.Parse(" 19 / 03 / 2019") });
            //Carros.Add(new Carros {  29,  "In Tempus Eu Inc.	                ", 5.233,  16,  DateTime.Parse(" 20 / 07 / 2019") });
            //Carros.Add(new Carros {  30,  "Elit Institute                     ", 7.359,  11,  DateTime.Parse(" 12 / 09 / 2019") });
            //Carros.Add(new Carros {  31,  "Aliquam Erat LLC                   ", 8.842,  4,   DateTime.Parse(" 14 / 03 / 2019") });
            //Carros.Add(new Carros {  32,  "A Feugiat Tellus PC                ", 9.176,  4,   DateTime.Parse(" 10 / 12 / 2019") });
            //Carros.Add(new Carros {  33,  "Aliquet Incorporated               ", 9.057,  8,   DateTime.Parse(" 26 / 04 / 2019") });
            //Carros.Add(new Carros {  34,  "Dolor Dolor Tempus Institute       ", 8.433,  15,  DateTime.Parse(" 31 / 10 / 2019") });
            //Carros.Add(new Carros {  35,  "Risus Odio Auctor PC               ", 8.286,  11,  DateTime.Parse(" 29 / 03 / 2019") });
            //Carros.Add(new Carros {  36,  "Aliquet Molestie Tellus Corp.	    ", 8.779,  1,   DateTime.Parse(" 05 / 07 / 2019") });
            //Carros.Add(new Carros {  37,  "Ipsum Corp.	                    ", 5.568,  15,  DateTime.Parse(" 10 / 03 / 2019") });
            //Carros.Add(new Carros {  38,  "Mi Lacinia Foundation              ", 7.442,  20,  DateTime.Parse(" 09 / 07 / 2019") });
            //Carros.Add(new Carros {  39,  "Cubilia Curae; Corp.               ", 8.421,  7,   DateTime.Parse(" 26 / 05 / 2019") });
            //Carros.Add(new Carros {  40,  "Velit Sed Malesuada Associates     ", 9.841,  6,   DateTime.Parse(" 07 / 11 / 2019") });
            //Carros.Add(new Carros {  41,  "Duis Foundation                    ", 9.849,  6,   DateTime.Parse(" 08 / 12 / 2019") });
            //Carros.Add(new Carros {  42,  "Erat Semper Consulting             ", 6.168,  10,  DateTime.Parse(" 10 / 11 / 2019") });
            //Carros.Add(new Carros {  43,  "Turpis Inc.	                    ", 7.758,  7,   DateTime.Parse(" 12 / 08 / 2019") });
            //Carros.Add(new Carros {  44,  "Aenean Industries                  ", 8.770,  12,  DateTime.Parse(" 10 / 09 / 2019") });
            //Carros.Add(new Carros {  45,  "Nulla Industries                   ", 8.884,  8,   DateTime.Parse(" 10 / 11 / 2019") });
            //Carros.Add(new Carros {  46,  "Semper Egestas Urna Inc.	        ", 9.428,  11,  DateTime.Parse(" 26 / 06 / 2019") });
            //Carros.Add(new Carros {  47,  "Donec Luctus Aliquet Industries    ", 5.928,  8,   DateTime.Parse(" 11 / 07 / 2019") });
            //Carros.Add(new Carros {  48,  "Cum Sociis Natoque Foundation      ", 7.506,  2,   DateTime.Parse(" 21 / 07 / 2019") });
            //Carros.Add(new Carros {  49,  "Vitae Sodales Limited              ", 8.912,  8,   DateTime.Parse(" 22 / 06 / 2019") });
            //Carros.Add(new Carros {  50,  "Tellus Sem Mollis Ltd              ", 9.615,  20,  DateTime.Parse(" 30 / 10 / 2019") });
            //Carros.Add(new Carros {  51,  "Nulla Tincidunt LLC                ", 5.562,  19,  DateTime.Parse(" 22 / 09 / 2019") });
            //Carros.Add(new Carros {  52,  "Sed Dictum Institute               ", 9.243,  14,  DateTime.Parse(" 26 / 06 / 2019") });
            //Carros.Add(new Carros {  53,  "Sed Turpis Company                 ", 7.243,  14,  DateTime.Parse(" 20 / 08 / 2019") });
            //Carros.Add(new Carros {  54,  "Vitae Diam Proin Associates        ", 6.631,  2,   DateTime.Parse(" 10 / 06 / 2019") });
            //Carros.Add(new Carros {  55,  "Curabitur Inc.	                    ", 8.090,  3,   DateTime.Parse(" 09 / 02 / 2019") });
            //Carros.Add(new Carros {  56,  "Suscipit Est Ac LLC                ", 8.567,  15,  DateTime.Parse(" 08 / 03 / 2019") });
            //Carros.Add(new Carros {  57,  "Neque Morbi Industries             ", 5.171,  1,   DateTime.Parse(" 03 / 10 / 2019") });
            //Carros.Add(new Carros {  58,  "Non Ltd                            ", 5.102,  19,  DateTime.Parse(" 14 / 08 / 2019") });
            //Carros.Add(new Carros {  59,  "Arcu Vestibulum Ante Institute     ", 6.128,  1,   DateTime.Parse(" 08 / 10 / 2019") });
            //Carros.Add(new Carros {  60,  "Nulla Foundation                   ", 7.636,  6,   DateTime.Parse(" 14 / 04 / 2019") });
            //Carros.Add(new Carros {  61,  "Quis Massa Mauris LLP              ", 5.053,  3,   DateTime.Parse(" 09 / 10 / 2019") });
            //Carros.Add(new Carros {  62,  "Ut Incorporated                    ", 6.922,  17,  DateTime.Parse(" 16 / 09 / 2019") });
            //Carros.Add(new Carros {  63,  "Aenean Egestas Corp.               ", 8.142,  19,  DateTime.Parse(" 17 / 11 / 2019") });
            //Carros.Add(new Carros {  64,  "Fusce Mi Lorem Consulting          ", 8.312,  20,  DateTime.Parse(" 19 / 11 / 2019") });
            //Carros.Add(new Carros {  65,  "A Sollicitudin Orci PC             ", 5.864,  1,   DateTime.Parse(" 20 / 03 / 2019") });
            //Carros.Add(new Carros {  66,  "Sociosqu Limited                   ", 5.985,  12,  DateTime.Parse(" 28 / 11 / 2019") });
            //Carros.Add(new Carros {  67,  "Ullamcorper Duis Cursus LLC        ", 5.164,  7,   DateTime.Parse(" 22 / 12 / 2019") });
            //Carros.Add(new Carros {  68,  "Nibh Lacinia LLC                   ", 7.760,  10,  DateTime.Parse(" 13 / 06 / 2019") });
            //Carros.Add(new Carros {  69,  "Eu Dui Institute                   ", 7.695,  8,   DateTime.Parse(" 12 / 12 / 2019") });
            //Carros.Add(new Carros {  70,  "Fringilla Purus Mauris Consulting  ", 5.845,  6,   DateTime.Parse(" 01 / 03 / 2019") });
            //Carros.Add(new Carros {  71,  "Donec Tempus Lorem Industries      ", 8.472,  19,  DateTime.Parse(" 09 / 03 / 2019") });
            //Carros.Add(new Carros {  72,  "Auctor Incorporated                ", 6.795,  1,   DateTime.Parse(" 04 / 10 / 2019") });
            //Carros.Add(new Carros {  73,  "Enim Etiam Imperdiet Corporation   ", 6.532,  13,  DateTime.Parse(" 14 / 10 / 2019") });
            //Carros.Add(new Carros {  74,  "Non Cursus Non Industries          ", 9.569,  16,  DateTime.Parse(" 25 / 10 / 2019") });
            //Carros.Add(new Carros {  75,  "Ut Semper Incorporated             ", 5.760,  18,  DateTime.Parse(" 14 / 01 / 2019") });
            //Carros.Add(new Carros {  76,  "Sed Malesuada Corporation          ", 6.561,  4,   DateTime.Parse(" 06 / 03 / 2019") });
            //Carros.Add(new Carros {  77,  "Sed Neque Consulting               ", 7.308,  2,   DateTime.Parse(" 31 / 08 / 2019") });
            //Carros.Add(new Carros {  78,  "Nisl Arcu PC                       ", 7.260,  8,   DateTime.Parse(" 19 / 06 / 2019") });
            //Carros.Add(new Carros {  79,  "Euismod Est Consulting             ", 6.020,  11,  DateTime.Parse(" 27 / 10 / 2019") });
            //Carros.Add(new Carros {  80,  "Leo Vivamus Ltd                    ", 5.055,  8,   DateTime.Parse(" 22 / 10 / 2019") });
            //Carros.Add(new Carros {  81,  "Tristique Neque Inc.               ", 9.268,  13,  DateTime.Parse(" 25 / 02 / 2019") });
            //Carros.Add(new Carros {  82,  "In Lobortis PC                     ", 5.539,  4,   DateTime.Parse(" 18 / 12 / 2019") });
            //Carros.Add(new Carros {  83,  "Nunc Ltd                           ", 6.846,  2,   DateTime.Parse(" 09 / 10 / 2019") });
            //Carros.Add(new Carros {  84,  "Dictum Proin Limited               ", 5.543,  12,  DateTime.Parse(" 05 / 10 / 2019") });
            //Carros.Add(new Carros {  85,  "Erat Vitae LLP                     ", 5.060,  7,   DateTime.Parse(" 12 / 12 / 2019") });
            //Carros.Add(new Carros {  86,  "Pellentesque Ultricies Dignissim PC", 7.971,  15,  DateTime.Parse(" 25 / 10 / 2019") });
            //Carros.Add(new Carros {  87,  "Phasellus Elit Company             ", 5.350,  15,  DateTime.Parse(" 31 / 10 / 2019") });
            //Carros.Add(new Carros {  88,  "Luctus Felis Ltd                   ", 9.872,  13,  DateTime.Parse(" 06 / 01 / 2019") });
            //Carros.Add(new Carros {  89,  "Dui Suspendisse PC                 ", 6.878,  7,   DateTime.Parse(" 06 / 02 / 2019") });
            //Carros.Add(new Carros {  90,  "Odio Associates                    ", 7.636,  18,  DateTime.Parse(" 24 / 07 / 2019") });
            //Carros.Add(new Carros {  91,  "Vel Company                        ", 7.410,  5,   DateTime.Parse(" 16 / 02 / 2019") });
            //Carros.Add(new Carros {  92,  "Lobortis Institute                 ", 5.110,  8,   DateTime.Parse(" 27 / 05 / 2019") });
            //Carros.Add(new Carros {  93,  "Scelerisque Company                ", 7.983,  19,  DateTime.Parse(" 03 / 12 / 2019") });
            //Carros.Add(new Carros {  94,  "Posuere Enim Company               ", 6.968,  19,  DateTime.Parse(" 22 / 04 / 2019") });
            //Carros.Add(new Carros {  95,  "Sem Ut Corp.                       ", 6.504,  11,  DateTime.Parse(" 02 / 02 / 2019") });
            //Carros.Add(new Carros {  96,  "Dui Fusce Aliquam PC               ", 7.837,  2,   DateTime.Parse(" 08 / 12 / 2019") });
            //Carros.Add(new Carros {  97,  "Nisl Sem Industries                ", 6.835,  5,   DateTime.Parse(" 14 / 11 / 2019") });
            //Carros.Add(new Carros {  98,  "Vitae Corp.	                    ", 7.669,  7,   DateTime.Parse(" 09 / 11 / 2019") });
            //Carros.Add(new Carros {  99,  "Malesuada Incorporated             ", 5.960,  4,   DateTime.Parse(" 26 / 09 / 2019") });
            //Carros.Add(new Carros {  100, "Mauris Ltd                         ", 8.974,  18,  DateTime.Parse(" 16 / 05 / 2019") });





        }
    }
}