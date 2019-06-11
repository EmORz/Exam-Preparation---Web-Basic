namespace Panda.Data_1.Models
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}