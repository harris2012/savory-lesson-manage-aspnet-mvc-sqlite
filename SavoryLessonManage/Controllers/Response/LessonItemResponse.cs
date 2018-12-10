using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryLessonManage.Vo;

namespace SavoryLessonManage.Controllers.Response
{
    public class LessonItemResponse : BaseResponse
    {
        [JsonProperty("item")]
        public LessonVo Item { get; set; }
    }
}
