using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repistory_Patern.DataAccses.Abstract
{
	interface IRepository<TEntity>
	{
		TEntity GetById(int id);
		void Update(TEntity entity);
		void Create(TEntity entity);
		void Delete(int id);
	}
}
