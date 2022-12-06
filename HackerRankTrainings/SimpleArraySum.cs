using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTrainings
{
    #region AlgorithmDescription
    /* Dado un arreglo ar[n], retornar la suma de sus miembros.
     *
     * Restriccion:
     * 0 < n, ar[] <= 1000
     */
    #endregion

    public class SimpleArraySum
    {
        public int Operacion(List<int> ar)
        {
            int sum = 0;

            if ((ar.Count > 0 && ar.Count <= 1000))
            {
                ar.ForEach(x => {
                    if (x <= 0 && x > 1000)
                    {
                        throw new Exception("Restriccion violada");
                    }
                    sum += x;
                });
            }
            else
            {
                throw new Exception("Restriccion violada");
            }

            return sum;
        }
    }
}
