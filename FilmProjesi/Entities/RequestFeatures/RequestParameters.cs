﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
    public abstract class RequestParameters
    {
		const int maxPageSize = 50;

		//Auto-implemented property
        public int PageNumber { get; set; }
		//Full-Property
		private int _pagesize;

		public int PageSize
		{
			get { return _pagesize; }
			set { _pagesize = value>maxPageSize? maxPageSize:value; }
		}

	}
}
