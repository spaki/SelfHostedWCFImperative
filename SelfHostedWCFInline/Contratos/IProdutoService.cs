using SelfHostedWCFInline.Modelos;
using System.Collections.Generic;
using System.ServiceModel;

namespace SelfHostedWCFInline.Contratos
{
    [ServiceContract]
    public interface IProdutoService
    {
        [OperationContract]
        List<Produto> Listar();
    }
}
