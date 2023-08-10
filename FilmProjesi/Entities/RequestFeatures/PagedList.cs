using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
    public class PagedList<T>:List<T>
    {
        public MetaData MetaData { get; set; }

        public PagedList(List<T> items,int count,int pageNumber,int pageSize)
        {
            MetaData = new MetaData()
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrrentPage = pageNumber,
                TotalPage = (int)Math.Ceiling(count/(double)pageSize)
            };
            AddRange(items);

        }

        public static PagedList<T> ToPagedList(IEnumerable<T> Source,int pageNumber,int pageSize) 
        {
            var count=Source.Count();
            var items = Source.Skip((pageNumber-1)*pageSize).Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
