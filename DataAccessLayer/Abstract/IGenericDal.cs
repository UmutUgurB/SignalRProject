namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity); 
        void Delete(T entity);  
        void Update(T entity);  
        T TGetByID(int id);  
        List<T> GetAll();       
    }

}
