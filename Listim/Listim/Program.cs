using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Listim
{
    class Program
    {
        static void Main(string[] args)
        {
            Dizi<string> a = new Dizi<string>();          
            a.Add("alperen");
            a.Add("bursa");
            a.Add("bursa");
            a.Add("ceyda");
            a.Remove("mahmut");
            a.Remove("bursa");

            Console.WriteLine(a.Count + "    Eleman sayısı ");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            } 
        }
 
        class Dizi<T>
        {
            private T[] _dizi;
            private T[] _tempS;

            public int Count
            {
                get { return _dizi.Length; }
            }

            public Dizi()
            {
                _dizi = new T[0];
            }
            public void Add(T s)
            {
                _tempS = _dizi;
                _dizi = new T[_dizi.Length + 1];
                for (int i = 0; i < _tempS.Length; i++)
                {
                    _dizi[i] = _tempS[i];
                }
                _dizi[_dizi.Length - 1] = s;
            }

            public bool Remove(T t)
            {
                int silincekelamanınindexi = -1;
                for (int i = 0; i < _dizi.Length; i++)
                {

                    if (_dizi[i].Equals(t))
                    {
                        silincekelamanınindexi = i;
                        break;
                    }
                }
                if (silincekelamanınindexi == -1)
                {
                    return false;
                }

                _tempS = _dizi;
                _dizi = new T[_tempS.Length - 1];
                int newIndex = 0;

                for (int i = 0; i < _tempS.Length; i++)
                {
                    if (i == silincekelamanınindexi)
                    {
                        continue;
                    }
                    _dizi[newIndex] = _tempS[i];
                    newIndex++;
                }
                return true;
            }

            public T this[int index]
            {
                get { return _dizi[index]; }
            }
        }

    }
}