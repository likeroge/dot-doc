namespace AtcAntarctic.Repos.Interfaces;

public interface ICrud<T>
{
    public IEnumerable<T> GetAll();
    public T? Get(int id);
    // public void Create(T entity);
    // public void Update(T entity);
    public T? Delete(int sid);
}