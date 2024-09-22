using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria.Dominio.Models.ModuloCliente
{
    public interface IClienteRepositorio
    {
        void CriarCliente(Cliente cliente);
        List<Cliente> TragaTodosClientes();
        void SalvarCliente(Cliente cliente);
        Cliente TragaClientePorId(int? id);
        void Remover(int id);
        bool ClientePorCpf(string clienteCpf, int clienteClienteId);
        bool ClientePorEmail(string? clienteEmail, int clienteClienteId);


    }
}
