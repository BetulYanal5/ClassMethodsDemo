using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Listele(List<Customer> customers)
        {
            int i = 0;
            foreach (Customer item in customers)//Müşteri özellikleri ekrana yazdırılır
            {
                Console.WriteLine((++i) + ".Müşteri\n" + "Müşteri Id:" + item.Id + "\n" + "Müşteri adı:" + item.Name + "\n" + "Müşteri Soyadı:" + item.Surname + "\n----------");
            }
        }
        public void Ekle(List<Customer> customers)
        {
            Console.WriteLine("Müşteri eklendi");
            Console.WriteLine("-----Güncel Liste-----");
            Listele(customers);//müşteriyi Listele() metoduna gönderdik böylece yeni müşteri listeye eklendi

        }
        public void Delete(int x, List<Customer> customers)
        {
            customers.RemoveAt(x - 1);//Listeleme işlemi 0.indisten başladığı için örneğin biz 2.müşteriyi silmek istersek
                                      //aslında 2.müşteri 1.indiste tutuluyordur bu nedenle bir eksiği alınır.
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine("-----Güncel Liste-----");
            Listele(customers);
        }
    }
}
