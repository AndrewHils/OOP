using System;
namespace Lab3_7
{
    public class Vector2D : IVector
    {
        public int length;
        public int x;
        public int y;
        public int[] begin;
        public int[] end;

        public Vector2D()
        {
            x = 0; y = 0;
            length = 0;
            begin = null;
            end = null;
        }
        public Vector2D(int[] first, int[] second)
        {
            Vector2D vector2D = new Vector2D();
            for (int i = 0; i < begin.Length; i++)
            {
                begin[i] = first[i];
                end[i] = second[i];
            }
            x = end[0] - begin[0];
            y = end[1] - begin[1];
            length = vector2D.Length(x, y);
        }
        public Vector2D(int X, int Y)
        {
            Vector2D vector2D = new Vector2D();
            vector2D.x = X;
            vector2D.y = Y;
            length = vector2D.Length(x, y);
        }

        public Vector2D Set_Value(int X, int Y)
        {
            Vector2D vector2D = new Vector2D();
            vector2D.x = X;
            vector2D.y = Y;
            vector2D.length = vector2D.Length(vector2D.x, vector2D.y);

            return vector2D;
        }
        public Vector2D Set_Value_Arr(int[] first, int[] second)
        {
            Vector2D vector2D = new Vector2D();
            begin = new int[2];
            end = new int[2];

            for (int i = 0; i < 2; i++)
            {
                begin[i] = first[i];
                end[i] = second[i];
            }
            vector2D.x = end[0] - begin[0];
            vector2D.y = end[1] - begin[1];
            vector2D.length = vector2D.Length(vector2D.x, vector2D.y);

            return vector2D;
        }

        public int Length(int x, int y)
        {
            return length = (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public Vector2D Sum(Vector2D A, Vector2D B)
        {
            Vector2D C = new Vector2D();
            C.x = A.x + B.x;
            C.y = A.y + B.y;
            C.length = C.Length(C.x, C.y);

            return C;
        }
        public Vector2D Vec_on_Num(Vector2D A, int num)
        {
            Vector2D B = new Vector2D();
            B.x = A.x * num;
            B.y = A.y * num;
            B.length = B.Length(B.x, B.y);
            return B;
        }
        public int Multi(Vector2D A, Vector2D B)
        {
            int resalt;
            resalt = A.x * B.x + A.y * B.y;
            return resalt;
        }
    }
}
