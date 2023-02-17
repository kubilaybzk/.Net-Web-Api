using System;
using Microsoft.EntityFrameworkCore;

namespace _15_EntityFramework
{
	public class ETradeContext:DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}

