using TP08.Models;

namespace TP08.VM
{
    public class ViewModelService : IViewModel
    {
        public ViewModel GetViewModel()
        {
            Product produit = new Product { Id = 1, Name = "Produit 1" };
            List<Client> clients = new List<Client>
            {
                new Client { Id = 1, Name = "Client 1" },
                new Client { Id = 2, Name = "Client 2" },
                new Client { Id = 3, Name = "Client 3" }
            };

            return new ViewModel { Product = produit, Clients = clients };
        }

        public Client GetClientById(int id)
        {
            List<Client> clients = new List<Client>
            {
                new Client { Id = 1, Name = "Client 1" },
                new Client { Id = 2, Name = "Client 2" },
                new Client { Id = 3, Name = "Client 3" }
            };

            return clients.FirstOrDefault(c => c.Id == id);
        }
    }
}
