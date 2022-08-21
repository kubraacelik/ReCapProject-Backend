using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule //tüm projelerimizde kullanabileceğimiz kodları içerecek 
    {
        void Load(IServiceCollection serviceCollection); //servisleri yüklüyor olacak
    }
}
