namespace DAL;

using System.Collections.Generic;
using BOL;

public class UserDBManager : IUserDBManager
{
    public List<User> GetAll()
    {
        using (var Context = new CollectionContext())
        {
            var u = from users in Context.user select users;
            return u.ToList<User>();
        }
    }

    public User GetByID(int id)
    {
        using (var context = new CollectionContext())
        {
            var user = context.user.Find(id);
            return user;
        }

    }

    public void Insert(User u)
    {
        using (var context = new CollectionContext())
        {
            context.user.Add(u);
            context.SaveChanges();
        }
    }

    public void Delete(int id)
    {
        using (var context = new CollectionContext())
        {
            context.user.Remove(context.user.Find(id));
            context.SaveChanges();
        }

    }

    public void Update(User u)
    {
        using (var context = new CollectionContext())
        {
            var usr = context.user.Find(u.id);
            usr.name = u.name;
            usr.email = u.email;
            usr.country = u.country;
            context.SaveChanges();
        }
    }
}

