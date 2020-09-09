using Repistory_Patern.DataAccses.Abstract;
using Repistory_Patern.DataAccses.Abstract.Concreate;
using Repistory_Patern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repistory_Patern
{
	class ProductManager : IProductRepository
	{

		IProductRepository _repository;
		public ProductManager(IProductRepository repository)
		{
			_repository = repository;
		}


		public void Create(Product entity)
		{
			_repository.Create(entity);
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


	class Program
	{
		static void Main(string[] args)
		{

			//var productDal = new EfProductDal();
			//var productDal=(new MySQLProductDal());
			//productDal.Create(new Product());

			//var productRepository = new ProductManager(new EfProductDal());
			var productRepository = new ProductManager(new MySQLProductDal());
			productRepository.Create(new Product());
			Console.ReadLine();

		}




	}
}
