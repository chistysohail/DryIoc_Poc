using DryIoc;
using System;
using System.ComponentModel;

namespace DryIocExample
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var container = new DryIoc.Container();
            container.Register<IService, Service>();

            var service = container.Resolve<IService>();
            service.Serve();
        }
    }
}


//dotnet add package DryIoc.dll
