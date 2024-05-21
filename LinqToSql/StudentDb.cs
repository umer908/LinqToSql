using LinqToSql.Linq;

namespace LinqToSql
{
    public class StudentDb
    {
        private readonly LinqSql _linqSqlDb;

        public StudentDb(LinqSql linqSqlDb)
        {
            _linqSqlDb = linqSqlDb;
        }

        public void Add(tbl_student student)
        {
            _linqSqlDb.Student.Add(student);
            _linqSqlDb.SaveChanges();
        }

        public IEnumerable<tbl_student> GetAll()
        {
            return _linqSqlDb.Student;
                  
        }

        public void Delete(int id) 
        {
            // Delete
            var studentToDelete = _linqSqlDb.Student.Find(id);
            _linqSqlDb.Student.Remove(studentToDelete);
            _linqSqlDb.SaveChanges();
        }

        public void Update(int id) 
        {
            // Update
            var lamdaquery = _linqSqlDb.Student.Find(id);


            //var stdlinqquery = from std in _linqSqlDb.tbl_student
            //                      where std.id == student.id
            //                      select std;


            lamdaquery.LastName = "UpdatedLastName";
            _linqSqlDb.SaveChanges();
        }
    }
}
