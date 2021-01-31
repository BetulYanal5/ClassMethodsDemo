using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();//Customer sınıfımızın nesnesini oluşturduk ve bu nesne aracılığıyla değişkenleri atadık
            customer1.Id = 1;
            customer1.Name = "Aslı";
            customer1.Surname = "Kaya";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Selim";
            customer2.Surname = "Işık";

            List<Customer> customers = new List<Customer> { customer1, customer2 };//Liste oluşturuldu
            CustomerManager customerManager = new CustomerManager();//metotlara erişmek için customerMenager nesnesi oluşturuldu

            customerManager.Listele(customers);//CustomerManager sınıfındaki Listele() metodu çağrıldı ve içerisine listemiz eklendi
            Console.WriteLine("1-Müşteri Ekle");
            Console.WriteLine("2-Müşteri Sil");
            Console.WriteLine("3-Çıkış Yap");
            Console.WriteLine("Yapmak istediğiniz işlemin numarasını girin");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3)
            {
                if (choice == 1)
                {
                    Customer customer3 = new Customer();
                    Console.Write("Müşteri Id:");
                    customer3.Id = Convert.ToInt32(Console.ReadLine());//Klavyeden veri girişi yapılır
                    Console.Write("Müşteri Adı:");
                    customer3.Name = Convert.ToString(Console.ReadLine());
                    Console.Write("Müşteri Soyadı:");
                    customer3.Surname = Convert.ToString(Console.ReadLine());
                    customers.Add(customer3);//Klavyeden veri girişi bittikte sonra yeni müşteriyi listeye ekledik
                    customerManager.Ekle(customers);//Sonrasında işlemin gerçekleştirilmesi için Ekle() metodunu çağırdık
                }
                else
                {
                    Console.WriteLine("Kaçıncı Müşteri Silinsin?");
                    int id = Convert.ToInt32(Console.ReadLine());
                    customerManager.Delete(id, customers);//Silmek istediğimiz müşterinin numarasını Delete() metoduna gönderdik
                }
                Console.WriteLine("Yapmak istediğiniz işlemin numarasını girin");
                choice = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadKey();
        }
    }
    
}
