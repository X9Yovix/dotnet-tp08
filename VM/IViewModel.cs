using TP08.Models;

namespace TP08.VM
{
    public interface IViewModel
    {
        ViewModel GetViewModel();
        Client GetClientById(int id);
    }
}
