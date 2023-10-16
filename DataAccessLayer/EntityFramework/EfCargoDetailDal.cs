using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
	{
		private readonly CargoContext _context;
		public EfCargoDetailDal(CargoContext cargoContext) : base(cargoContext)
		{
			_context = cargoContext;
		}

		public int TotalCargoCount()
		{
			return _context.CargoDetails.Count();
		}
	}
}