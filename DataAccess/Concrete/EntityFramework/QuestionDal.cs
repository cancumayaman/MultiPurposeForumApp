using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataContext.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class QuestionDal:GenericRepository<Question>,IQuestionDal
    {
        public QuestionDal(ApplicationDbContext context):base(context)
        {

        }
    }
}
