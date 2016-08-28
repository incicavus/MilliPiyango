using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliPiyango
{
    class Piyango
    {
        //bilet nesnelerinden bağımsız olarak işlem yapar. 

        //buradaki işlemler için nesle oluşturulmasına gerek yok.
        private Piyango()
        {

        }

        //çekiliş ve listeleme işlemleri burada yapılmalı.

        public static ArrayList Amorti = new ArrayList();
        public static ArrayList Son2 = new ArrayList();
        public static ArrayList Son3 = new ArrayList();

        public static void Cekilis()
        {
            Son2.Clear();
            Son3.Clear();
            Amorti.Clear();

            CekilisYap(Amorti, 2,1);
            CekilisYap(Son2, 15,2);
            CekilisYap(Son3, 30,3);
        }

        private static void CekilisYap(ArrayList liste, int kacSayi, int basamakSayisi)
        {
            Random gen = new Random();
            string sayi = "";

            for (int i = 0; i < kacSayi; i++)
            {
                for (int j = 0; j < basamakSayisi; j++)
                {
                    sayi += gen.Next(10);
                    


                }

                if (!liste.Contains(sayi))
                    liste.Add(sayi);
                else
                    i--;
                //sayı değişkeni oluşturulan sayı istenen listeye ister eklensin ister eklenmesin basamak sayısını aşmamak için en sonda ya da en başta resetlenmeli.
                sayi = "";
            }

            liste.Sort();//artan şekilde sıralasın.
        }


    }
}
