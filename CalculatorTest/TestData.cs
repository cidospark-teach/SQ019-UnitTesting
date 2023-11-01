using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var data = File.ReadAllLines("TestExternalData.csv");
            var objs = new object[data.Length];

            foreach(var line in data)
            {
                var splitted = line.Replace(" ", "").Split(",");
                yield return new object[] { 
                    double.Parse(splitted[0]),
                    double.Parse(splitted[1]),
                    double.Parse(splitted[2])
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
