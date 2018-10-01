using SavoryLessonManage.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryLessonManage.Controllers.Response
{
    public class LessonCountResponse : BaseResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }
}
