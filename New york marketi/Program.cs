using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace New_york_marketi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //New york markete hoşgeldiniz
            Console.WriteLine("New york markete hoşgeldiniz");
            Console.WriteLine("************");
            string kullancı = Convert.ToString(Console.ReadLine());
            string[] yemekler = new string[3];
            string[] ürünler = { "kola", "Bisküvi", "çikolata","Lanbo","takımelbise" };
            double money = 1000;
            string[] fiyatlar = { "7", "3", "2","700","1000" };
            string fiyatlar1 = Convert.ToString(fiyatlar);
            string Login = Convert.ToString(Console.ReadLine());
            string sifre = "kostantinapolis";
            string sfr = Convert.ToString(Console.ReadLine());
            bool adminlereözel = true;
            bool login1 = true;
            

            int sahtekar_sayısı = 0;

            while (true)
            {
                Console.WriteLine("1 Vip ve ya admin giriş için ");
                Console.WriteLine("0 Çıkış için");
                


                break;
            }
            if (adminlereözel)
            {
                Console.WriteLine("admin kullancı giriniz:");
                string Doğrudan = Convert.ToString(Console.ReadLine());
                

            }
            else if (Login == sifre)
            {
                Console.WriteLine("Şifrenizi giriniz:");
                
            }
            else 
            {
               
                Console.WriteLine("Yanlış şifre girişi yaptınız bb kanka : " + (0 - sahtekar_sayısı));
            }
                        for (int i = 0; i < ürünler.Length; i++)
                        {
                            Console.WriteLine($"Ürün ismi giriniz:{ürünler[i]}");
                            Console.WriteLine("ürün fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            fiyat = +fiyat;
                            Console.WriteLine("Ürünler ve fiyatlar güncellendi.");
                        }
                        Console.WriteLine("Ürünler:");
                        for (int i = 0; i < ürünler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ürünler[i]} - {fiyatlar[i]} TL");
                        }
                       

                        Console.WriteLine("Ürünler:");
                        for (int i = 0; i < ürünler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ürünler[i]} - {fiyatlar[i]} TL");
                        }

                        Console.Write("Ürün seçin (1-5): ");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        int secim2 = Convert.ToInt32(secim);

                        if (secim >= 1 && secim <= ürünler.Length)
                        {
                            string secilenUrun = ürünler[secim - 1];
                            double secilenFiyat = fiyatlar1[secim2 - 1];

                            Console.WriteLine($"Seçilen ürün: {secilenUrun}");
                            Console.WriteLine($"Fiyatı: {secilenFiyat} TL");

                            Console.Write("Ödeme miktarını girin: ");
                            double odeme = Convert.ToDouble(Console.ReadLine());

                            if (odeme >= secilenFiyat)
                            {
                                double paraUstu = odeme - secilenFiyat;
                                Console.WriteLine($"Para üstü: {paraUstu} TL");
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz ödeme miktarı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün seçimi.");
                        }
            



            Console.ReadKey();






















                    }
                }
            }


