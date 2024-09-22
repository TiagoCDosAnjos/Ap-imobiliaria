using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Imobiliaria.Dominio.Models.ModuloCliente
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ServiceCliente(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void CriarCliente(Cliente cliente)
        {
            ValidacaoDuplicacao(cliente);
        }

        private void ValidacaoDuplicacao(Cliente cliente)
        {
            var existeClienteCpf = _clienteRepositorio.ClientePorCpf(cliente.Cpf, cliente.ClienteId);
            
            if(existeClienteCpf is true) 
            {
                throw new Exception();
            }

            var existeClienteEmail = _clienteRepositorio.ClientePorEmail(cliente.Email, cliente.ClienteId);

            if (existeClienteEmail is true)
            {
                throw new Exception();
            }
        }

        public void Remover(int id)
        {
            _clienteRepositorio.Remover(id);
        }

        public void SalvarCliente(Cliente cliente)
        {
            ValidacaoDuplicacao(cliente);
            _clienteRepositorio.SalvarCliente(cliente);
        }

        public Cliente TragaClientePorId(int id)
        {
            return _clienteRepositorio.TragaClientePorId(id);
        }

        public List<Cliente> TragaTodosClientes()
        {
            return _clienteRepositorio.TragaTodosClientes();
        }
    }
}
