using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp11_g_1
{
    class Triangle
    {
        // закрытые поля
        private int m_a { get; set; }
        private int m_b { get; set; }
        private int m_c { get; set; }

        // публичные свойства
        public int A{ get { return m_a; } set { m_a = value; } }
        public int B{ get { return m_b; } set { m_b = value; } }
        public int C{ get { return m_c; } set { m_c = value; } }

        // свойство для определения существования треуголника
        public bool TriangleIs 
        {
            get
            {
                if (m_c + m_b > m_a && m_a + m_c > m_b && m_a + m_b > m_c)
                {
                    return true;
                }
                return false;
            }
        }

        // конструктор
        public Triangle(int a,int b,int c)
        {
            m_a = a;
            m_b = b;
            m_c = c;
        }
        // перегрузка метода ToString() класса родителя Object для вывода длин сторон треугольника на экран
        public override string ToString()
        {
            return String.Concat("A: ", m_a.ToString(), " B: ", m_b.ToString(), " C: ", m_c.ToString());
        }
        // метод для расчёт периметра треугольника
        public int Perimetr()
        {
            return m_a+ m_b + m_c;    
        }
        // метод для вычисления плозади треугольника
        public float Square()
        {
            float halfPermietr = (float)Perimetr() / 2;
            return MathF.Sqrt(halfPermietr*(halfPermietr-m_a)*(halfPermietr-m_b)*(halfPermietr-m_c));
        }
    }
}
