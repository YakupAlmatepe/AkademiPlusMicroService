﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroService.Sharedd.DTOs
{
	public class Response<T>
	{
		public T Data { get; set; }
		public int StatusCode { get; set; }
		public bool IsSuccesful { get; set; }
		public List<string> Errors { get; set; }

		public static Response<T> Success(T data, int statusCode)
		{
			return new Response<T> { Data = data, StatusCode = statusCode, IsSuccesful = true };
		}
		public static Response<T> Success(int statusCode)
		{
			return new Response<T> { Data = default(T), StatusCode = statusCode, IsSuccesful = true };
		}
		public static Response<T> Fail(string error, int statusCode)
		{
			return new Response<T> { Errors = new List<string> { error }, StatusCode = statusCode, IsSuccesful = false };
		}
		public static Response<T> Fail(List<string> errors, int statusCode)
		{
			return new Response<T> { Errors = errors, StatusCode = statusCode, IsSuccesful = false };
		}
	}
}