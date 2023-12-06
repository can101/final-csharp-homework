using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public interface IUserDal
    {
        List<User> GetAll();
        bool Create(User user);
        bool Update(User user);
        bool Delete(User user);
    }
}
