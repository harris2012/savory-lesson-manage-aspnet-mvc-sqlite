using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryLessonManage.Vo;

namespace SavoryLessonManage.Controllers.Request
{
    public class LessonUpdateRequest
    {

        public int Id { get; set; }

        public string Ename { get; set; }

        public string Title { get; set; }
    }
}
