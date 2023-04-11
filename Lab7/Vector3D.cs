using System;
namespace Lab3_7
{
    public class Vector3D : Vector2D, IVector
    {
        public int z;
        public new int[] begin;
        public new int[] end;

        public Vector3D()
        {
            x = 0; y = 0; z = 0;
            length = 0;
            begin = null;
            end = null;
        }
        public Vector3D(int[] first, int[] second)
        {
            Vector3D vector3D = new Vector3D();
            for (int i = 0; i < begin.Length; i++)
            {
                begin[i] = first[i];
                end[i] = second[i];
            }
            x = end[0] - begin[0];
            y = end[1] - begin[1];
            z = end[2] - begin[2];
            length = vector3D.Length(x, y, z);
        }
        public Vector3D(int x, int y, int z)
        {
            Vector3D vector3D = new Vector3D();
            this.x = x;
            this.y = y;
            this.z = z;
            length = vector3D.Length(x, y, z);
        }

        public Vector3D Set_Value(int X, int Y, int Z)
        {
            Vector3D vec = new Vector3D();
            vec.x = X;
            vec.y = Y;
            vec.z = Z;
            vec.length = vec.Length(vec.x, vec.y, vec.z);

            return vec;
        }
        public new Vector3D Set_Value_Arr(int[] first, int[] second)
        {
            Vector3D vec = new Vector3D();
            begin = new int[3];
            end = new int[3];
            for (int i = 0; i < begin.Length; i++)
            {
                begin[i] = first[i];
                end[i] = second[i];
            }
            vec.x = end[0] - begin[0];
            vec.y = end[1] - begin[1];
            vec.z = end[2] - begin[2];
            vec.length = vec.Length(vec.x, vec.y, vec.z);

            return vec;
        }

        public int Length(int x, int y, int z)
        {
            return length = (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public Vector3D Sum(Vector3D A, Vector3D B)
        {
            Vector3D C = new Vector3D();
            C.x = A.x + B.x;
            C.y = A.y + B.y;
            C.z = A.z + B.z;
            C.length = C.Length(C.x, C.y, C.z);

            return C;
        }
        public Vector3D Vec_on_Num(Vector3D A, int num)
        {
            Vector3D B = new Vector3D();
            B.x = A.x * num;
            B.y = A.y * num;
            B.z = A.z * num;
            B.length = B.Length(B.x, B.y, B.z);
            return B;
        }
        public int Multi(Vector3D A, Vector3D B)
        {
            int resalt;
            resalt = A.x * B.x + A.y * B.y + A.z * B.z;
            return resalt;
        }
    }
}
