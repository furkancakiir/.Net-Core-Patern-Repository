using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repistory_Patern.Entity;

namespace Repistory_Patern.DataAccses.Abstract.Concreate
{
	class MySQLProductDal : IProductRepository
	{
		public void Create(Product entity)
		{
			Console.WriteLine("MYSQL Create");
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Product GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Product[] GetPopularProducts()
		{
			throw new NotImplementedException();
		}

		public Product[] GetProductsByCategoryId(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
