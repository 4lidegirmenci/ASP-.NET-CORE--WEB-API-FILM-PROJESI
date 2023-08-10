﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
    public class MetaData
    {
        public int CurrrentPage { get; set; }

        public int TotalPage { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public bool HasPrevius => CurrrentPage > 1;
        public bool HasPage=> CurrrentPage < TotalPage;
    }
}
