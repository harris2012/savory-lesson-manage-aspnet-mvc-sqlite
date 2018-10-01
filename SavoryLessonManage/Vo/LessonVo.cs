using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryLessonManage.Vo
{
    public class LessonVo
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ename")]
        public string Ename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
