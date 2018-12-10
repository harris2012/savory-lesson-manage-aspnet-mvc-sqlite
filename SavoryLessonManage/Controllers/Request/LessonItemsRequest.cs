using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryLessonManage.Controllers.Request
{
    public class LessonItemsRequest : LessonCountRequest
    {
        public int PageIndex { get; set; }
    }
}
