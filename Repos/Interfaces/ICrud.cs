namespace AtcAntarctic.Repos.Interfaces;

public interface ICrud<T>
{
    public IEnumerable<T> GetAll();
    public T? Get(long id);
    // public void Create(T entity);
    // public void Update(T entity);
    public T? Delete(long sid);
}