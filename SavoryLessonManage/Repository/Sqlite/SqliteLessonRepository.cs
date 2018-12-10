using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

using SavoryLessonManage.Repository.Entity;

namespace SavoryLessonManage.Repository.Sqlite
{
    public class SqliteLessonRepository : ILessonRepository
    {

        private SqliteConnectionProvider connectionProvider;

        public SqliteLessonRepository(SqliteConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public void Create(LessonEntity entity)
        {
            string sql = "insert into lesson(ename, title) values (@Ename, @Title);";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { Ename = entity.Ename, Title = entity.Title });
            }
        }

        public LessonEntity GetById(long id)
        {
            string sql = "select id, ename as Ename, title as Title from lesson where Id = ?";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QueryFirstOrDefault<LessonEntity>(sql, new { Id = id });
            }
        }

        public int GetCount()
        {
            string sql = "select count(1) from lesson";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QuerySingle<int>(sql);
            }
        }

        public List<LessonEntity> GetEntityList()
        {
            string sql = "select id, ename as Ename, title as Title from lesson";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<LessonEntity>(sql).ToList();
            }
        }

        public List<LessonEntity> GetEntityList(int pageIndex, int pageSize)
        {
            string sql = "select id, ename as Ename, title as Title from lesson limit @Start, @Count";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<LessonEntity>(sql, new { Start = (pageIndex - 1) * pageSize, Count = pageSize }).ToList();
            }
        }

        public void Update(LessonEntity entity)
        {
            string sql = "update lesson set ename = @Ename, title = @Title where id = @Id;";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { id = entity.Id, Ename = entity.Ename, Title = entity.Title });
            }
        }
    }
}
