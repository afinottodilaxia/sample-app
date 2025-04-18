

using PagedList;

namespace SampleMVCApp.Models
{
    public class ListaDellaSpesaViewModel
    {
        // Add properties as needed in the future
        public IPagedList<Prodotto> Prodotti { get; set; }
        public Prodotto NuovoProdotto { get; set; }
    }
}
