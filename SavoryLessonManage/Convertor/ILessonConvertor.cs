using SavoryLessonManage.Controllers.Request;
using SavoryLessonManage.Repository.Entity;
using SavoryLessonManage.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryLessonManage.Convertor
{
    public interface ILessonConvertor
    {

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        LessonEntity toEntity(LessonCreateRequest request);

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        LessonEntity toEntity(LessonUpdateRequest request);

        /// <summary>
        /// 获取空 vo
        /// </summary>
        LessonVo toEmptyVo();

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        LessonVo toLessVo(LessonEntity entity);

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        LessonVo toMoreVo(LessonEntity entity);

        /// <summary>
        /// entityList 转换为 voList
        /// </summary>
        List<LessonVo> toLessVoList(List<LessonEntity> entityList);
    }
}
