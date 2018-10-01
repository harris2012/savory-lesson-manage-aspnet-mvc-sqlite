using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryLessonManage.Controllers.Request;
using SavoryLessonManage.Repository.Entity;
using SavoryLessonManage.Vo;

namespace SavoryLessonManage.Convertor
{
    public class LessonConvertor : ILessonConvertor
    {

        public LessonEntity toEntity(LessonCreateRequest request)
        {
            LessonEntity entity = new LessonEntity();

            entity.Ename = request.Ename;
            entity.Title = request.Title;

            return entity;
        }

        public LessonEntity toEntity(LessonUpdateRequest request)
        {
            LessonEntity entity = new LessonEntity();

            entity.Id = request.Id;
            entity.Ename = request.Ename;
            entity.Title = request.Title;

            return entity;
        }

        public LessonVo toEmptyVo()
        {
            LessonVo vo = new LessonVo();

            return vo;
        }

        public LessonVo toLessVo(LessonEntity entity)
        {
            LessonVo vo = toVo(entity);

            return vo;
        }

        public LessonVo toMoreVo(LessonEntity entity)
        {
            LessonVo vo = toVo(entity);

            return vo;
        }

        public List<LessonVo> toLessVoList(List<LessonEntity> entityList)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<LessonVo> voList = new List<LessonVo>();
            foreach (LessonEntity entity in entityList) {
                voList.Add(toLessVo(entity));
            }

            return voList;
        }

        /// <summary>
        /// 将entity转换为vo。不包括来自元数据的属性
        /// </summary>
        private LessonVo toVo(LessonEntity entity)
        {
            LessonVo vo = new LessonVo();

            vo.Id = entity.Id;
            vo.Ename = entity.Ename;
            vo.Title = entity.Title;

            return vo;
        }
    }
}
