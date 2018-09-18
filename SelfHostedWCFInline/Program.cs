using SelfHostedWCFInline.Contratos;
using SelfHostedWCFInline.Servicos;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHostedWCFInline
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ProdutoService), new Uri[] { new Uri("http://localhost:7171") }))
            {
                host.Description.Behaviors.Add(new ServiceMetadataBehavior());

                host.AddServiceEndpoint(typeof(IProdutoService), new BasicHttpBinding(), "srv");
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

                host.Open();

                Console.WriteLine("Serviço rodando...");
                Console.WriteLine("Tecle para finalizar.");
                Console.ReadLine();
            }
        }
    }
}
