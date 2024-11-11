namespace Domain;

public interface IShopping
{
    public IEnumerable<Shopping> GetAll();
    public Shopping GetById(int id);
}
