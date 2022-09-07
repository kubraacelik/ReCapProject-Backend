using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); //cache'den getirirken hangi tipte istediğimizi, çalıştığımızı, dönüştüreceğimizi söyleyeceğiz
        object Get(string key); //generic olmayan versiyonu
        void Add(string key, object value, int duration); //value:gelecek data bütün veri tiplerini kapsaması için object olacak
                                                          //duration:cache'de ne kadar duracak
        bool IsAdd(string key); //cache'de var mı
        void Remove(string key); //cache'den uçurmak için
        void RemoveByPattern(string pattern); //içinde şu olanları uçur demek
    }
}
