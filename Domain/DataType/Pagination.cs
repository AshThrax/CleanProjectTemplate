using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataType
{
    public class Pagination<T>
    {
        public Pagination(int pageSize, int pageNumber, List<T> items,int totalCount)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
            TotalCount = totalCount;
            Items = items;
        }

        //page size
        public int PageSize { get; }
        public int PageNumber { get; }
        public int TotalCount { get;}  
        public List<T> Items { get; }
        public bool HasNext => PageNumber < TotalCount;
        public bool HasPrevious => PageNumber>1;

        public static Pagination<T> ToPagedList(List<T> Data,int pageNumber, int pageSize)
        {
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }
            if (pageSize <= 0)
            {
                pageSize = 1;
            }

            var count = Data.Count();
            if (count > 0)
            {
                var pageListed = Data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                var totalPages = (int)Math.Ceiling(count / (double)pageSize);
                return new Pagination<T>(pageNumber, pageSize, pageListed, totalPages);

            }
            else
            {
                return new Pagination<T>(0,0,null,0);
            }

        }

    }

}
