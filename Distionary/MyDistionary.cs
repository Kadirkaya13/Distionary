using System;
using System.Collections.Generic;
using System.Text;

namespace Distionary
{
    class MyDistionary<V,N>
    {
        V[] _arrayValue;
        N[] _arrayNumber;
        public MyDistionary()
        {
            _arrayValue = new V[0];
            _arrayNumber = new N[0]; 

        }
        public void Add(V value ,N number )
        {
            //referansı kaybetmemek için geçiçi bir değişkene atama yapılır
            V[] _tempValue = _arrayValue;
            N[] _tempNumber = _arrayNumber;

            _arrayValue = new V[_arrayValue.Length + 1];
            _arrayNumber = new N[_arrayNumber.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _arrayValue[i] = _tempValue[i];
                _arrayValue[_arrayValue.Length - 1] = value;

            }
            for (int i = 0; i < _tempNumber.Length; i++)
            {
                _arrayNumber[i] = _tempNumber[i];
                _arrayNumber[_arrayNumber.Length - 1] = number;

            }
            Console.WriteLine("Şehir Adı :"+value+" | "+" Plakası :"+number);
        }

    }
}
