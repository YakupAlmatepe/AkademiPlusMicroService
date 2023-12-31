﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Sharedd;

namespace AkademiPlusMicroService.Sharedd.Service
{
	public class SharedIdentityService : ISharedIdentityService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public SharedIdentityService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
	}
}