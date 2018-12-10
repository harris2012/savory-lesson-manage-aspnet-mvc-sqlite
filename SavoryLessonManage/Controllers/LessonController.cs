using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Web.Http;

using SavoryLessonManage.Controllers.Request;
using SavoryLessonManage.Controllers.Response;
using SavoryLessonManage.Convertor;
using SavoryLessonManage.Repository;
using SavoryLessonManage.Repository.Entity;

namespace SavoryLessonManage.Controllers
{
    [RoutePrefix("api/lesson")]
    public class LessonController : BaseController
    {
        /// <summary>
        /// 分页，每页个数
        /// </summary>
        private static readonly int PAGE_SIZE = 15;

        private ILessonRepository lessonRepository;

        private ILessonConvertor lessonConvertor;

        public LessonController(
            ILessonRepository lessonRepository,
            ILessonConvertor lessonConvertor)
        {
            this.lessonRepository = lessonRepository;
            this.lessonConvertor = lessonConvertor;
        }

        [HttpPost]
        [Route("items")]
        public LessonItemsResponse Items([FromBody]LessonItemsRequest request)
        {
            LessonItemsResponse response = new LessonItemsResponse();

            List<LessonEntity> entityList = lessonRepository.GetEntityList(request.PageIndex, PAGE_SIZE);

            response.Items = lessonConvertor.toLessVoList(entityList);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("count")]
        public LessonCountResponse Count([FromBody]LessonCountRequest request)
        {
            LessonCountResponse response = new LessonCountResponse();

            int count = lessonRepository.GetCount();

            response.TotalCount = count;

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("item")]
        public LessonItemResponse Item([FromBody]LessonItemRequest request)
        {
            LessonItemResponse response = new LessonItemResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            LessonEntity entity = lessonRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = lessonConvertor.toLessVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("create")]
        public LessonCreateResponse Create([FromBody]LessonCreateRequest request)
        {
            LessonCreateResponse response = new LessonCreateResponse();

            lessonRepository.Create(lessonConvertor.toEntity(request));

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("empty")]
        public LessonEmptyResponse Empty([FromBody]LessonEditableRequest request)
        {
            LessonEmptyResponse response = new LessonEmptyResponse();

            response.Item = lessonConvertor.toEmptyVo();

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("editable")]
        public LessonEditableResponse Editable([FromBody]LessonEditableRequest request)
        {

            LessonEditableResponse response = new LessonEditableResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            LessonEntity entity = lessonRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = lessonConvertor.toMoreVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("update")]
        public LessonUpdateResponse Update([FromBody]LessonUpdateRequest request)
        {

            LessonUpdateResponse response = new LessonUpdateResponse();

            if (request.Id == 0 || request.Id < 0)
            {
                response.Status = -1;
                return response;
            }

            LessonEntity entity = lessonRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            lessonRepository.Update(lessonConvertor.toEntity(request, entity));

            response.Status = 1;
            return response;
        }
    }
}
