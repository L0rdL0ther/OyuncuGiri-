using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuGiriş
{
    public class AnaBabaAyarlar : IRocketPluginConfiguration
    {
        public string OyuncuGirişMesaj { get; set; }
        public string ServerİnfoHelpKomudu { get; set; }
        public string İnfoPerm { get; set; }
        public string Serverİnfo { get; set; }
        public string OyuncuÇıkışMesaj { get; set; }
        public string ServerGirişMesaj { get; set; }
        public string ServerÇıkışMesaj { get; set; }
        public string Sunucuİsmi { get; set; }
        public string HatalıKod { get; set; }
        public void LoadDefaults()
        {
            HatalıKod = "Lütfen Komut Giriniz";
            İnfoPerm = "İnfo.Perm.Giriş";
            Serverİnfo = "Serverimiz 1 slot , 1 cpu dur";
            ServerİnfoHelpKomudu = " /İnfo Yazarak Server İnfo Alabilirsiniz";
            ServerGirişMesaj = "Server Hoş Geldin Leş";
            ServerÇıkışMesaj = "Bir Leş Daha Temizlendi";
            OyuncuÇıkışMesaj = ($"{Sunucuİsmi}| Güle Güle Yine Bekleriz ");
            OyuncuGirişMesaj = ($" {Sunucuİsmi}| Hoşgeldiniz | Anancılık Plugin");
            Sunucuİsmi = "BrotherHood";
        }
        internal class ınsetence
        {
        }
    }
}
