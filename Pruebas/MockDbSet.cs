using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class MockDbSet<T> where T : class
    {
        public static Mock<IDbSet<T>> Get(List<T> data)
        {
            var mock = new Mock<IDbSet<T>>();
            mock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.AsQueryable().Provider);
            mock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.AsQueryable().Expression);
            mock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.AsQueryable().ElementType);
            mock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.AsQueryable().GetEnumerator());

            return mock;
        }
    }
}
