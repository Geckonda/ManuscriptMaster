﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Model
{
	public class TokenModel
	{
		public string? Token { get; set; }
		public DateTime Expiration { get; set; }
	}
}
