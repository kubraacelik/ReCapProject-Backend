using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, ICoreModule[] modules) //IServiceCollection = APİ'mizin servis bağımlılıklarını eklediğimiz
                                                                               //veya araya girmesini istediğimiz servisleri eklediğimiz koleksiyon
                                                                               //genişletmek istediklerini this ile ver
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);

        }
    }
}
