﻿using Repistory_Patern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repistory_Patern.DataAccses.Abstract
{
	interface ICategoryRepository:IRepository<Category>
	{

		Category[] GetCategories();

	}
}
