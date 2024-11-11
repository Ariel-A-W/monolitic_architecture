using ShoppingOnline.Domain;

namespace ShoppingOnline.Application;

public class UseCaseApplication
{
    private readonly IShopping _shop;

    public UseCaseApplication(IShopping shop)
    {
        _shop = shop;
    }

    public Task<IEnumerable<Shopping>> GetAllAsync()
    { 
        return Task.FromResult(_shop.GetAll());
    }

    public Task<Shopping> GetById(int id)
    { 
        return Task.FromResult(_shop.GetById(id));
    }
}
