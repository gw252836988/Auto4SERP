using System;
using System.Collections.Generic;
using System.Text;


namespace Model
{
    public class PageInfo
    {
        private int pageCurrent;

        public int PageCurrent
        {
            get { return pageCurrent; }
            set { pageCurrent = value; }
        }

        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        private int pageSize=10;

        public int PageSize
        {
            get { return pageSize; }
        }

        private int recordCount;

        public int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }

    }
}
