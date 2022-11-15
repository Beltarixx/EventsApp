namespace EventsApp.BusinessLogicLayer
{
    interface IService<T>
    {
        void Create(T entity);
        void RemoveById(string id);
        List<T> GetAll();
        T GetById(string id);
        bool EditById(string id, T editedEntity);
    }
}