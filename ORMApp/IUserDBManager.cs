namespace DAL;
using BOL;

public interface IUserDBManager{
    List<User> GetAll();
    User GetByID(int id);
    void Insert(User user);
    void Delete(int id);
    void Update(User user); 
}