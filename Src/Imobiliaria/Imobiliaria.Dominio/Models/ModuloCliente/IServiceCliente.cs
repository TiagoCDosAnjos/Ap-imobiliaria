using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria.Dominio.Models.ModuloCliente
{
    public interface IServiceCliente
    {
        void CriarCliente(Cliente cliente);
        List<Cliente> TragaTodosClientes();
        void SalvarCliente(Cliente cliente);
        Cliente TragaClientePorId(int id);
        void Remover(int id);
    }
}
