using ShoppingOnline.Domain;

namespace ShoppingOnline.Infrastructure;

public class ShoppingRepository : IShopping
{
    private readonly List<Shopping> _shop = new List<Shopping>()
    { 
        new Shopping() 
        { 
            Id = 1,
            Articulo = "Banqueta Bar", 
            Marca = "Streiss", 
            Precio = 1230.12F
        },
        new Shopping()
        {
            Id = 2,
            Articulo = "Mesa Ratonera",
            Marca = "Saltman SA",
            Precio = 467.56F
        },
        new Shopping()
        {
            Id = 3,
            Articulo = "Bargueño Estilo Brasileño",
            Marca = "Do Santos",
            Precio = 6723.45F
        },
        new Shopping()
        {
            Id = 4,
            Articulo = "Grill Americano",
            Marca = "Costco",
            Precio = 5680.23F
        },
    };

    public IEnumerable<Shopping> GetAll()
    {
        return _shop.ToList();
    }

    public Shopping GetById(int id)
    {
        return _shop.FirstOrDefault(f => f.Id == id)!;
    }
}
