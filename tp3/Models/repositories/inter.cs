namespace tp3.Models.repositories
{
    public interface repository<T>{
    
        List<T> GetAll();
    T FindById(int id);
    void Add(T entity);
    void Update(int id, T entity);
    void Delete(int id);
        List<T> Search(string term);

    }
}

