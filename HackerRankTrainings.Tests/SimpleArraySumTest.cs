using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTrainings.Tests
{
    public class SimpleArraySumTest
    {
        //[Theory (Skip = "Test no es necesario.")] //Codigo para omitir una prueba
        [Theory]
        [ClassData(typeof(SimpleArraySumClassData))]
        public void Operacion(int expected, List<int> ar)
        {
            // arrange
            SimpleArraySum simpleArraySum = new SimpleArraySum();

            //act
            int result = simpleArraySum.Operacion(ar);

            //asserts
            Assert.Equal(expected, result);
        }

        [Fact]
        //[Fact(Skip = "No es necesario el test.")] //Codigo para omitir una prueba
        public void Operacion_Exception()
        {
            //arrange
            SimpleArraySum simpleArraySum = new SimpleArraySum();

            //act
            Action act = () => simpleArraySum.Operacion(new List<int>() { });
            Exception exception = Assert.Throws<Exception>(act);

            //assert
            Assert.Equal("Restriccion violada", exception.Message);
            Assert.IsType<Exception>(exception);
        }

    }

    public class SimpleArraySumClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 31, new List<int>() { 1, 2, 3, 4, 10, 11 } };
            yield return new object[] { 1, new List<int>() { 1 } };
            yield return new object[] { 60, new List<int>() { 10, 20, 30 } };
            yield return new object[] { 100, new List<int>() { 50, 50 } };
            yield return new object[] { 62, new List<int>() { 1, 2, 3, 4, 10, 11, 1, 2, 3, 4, 10, 11 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
