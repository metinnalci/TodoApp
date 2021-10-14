using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _001_TodoApplicationRestApp.Entities;
using CSD.Util.Data.Repository;

namespace _001_TodoApplicationRestApp.Repositories
{
    public interface ITodoRepository : ICrudRepository<TodoInfo, int>
    {

    }
}
