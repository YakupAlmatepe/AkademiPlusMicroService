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
	public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
	{
		private readonly CargoContext _context;
		public EfCargoStateDal(CargoContext cargoContext) : base(cargoContext)
		{
			_context = cargoContext;
		}


	}
}