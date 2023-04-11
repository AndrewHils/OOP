using System;
namespace Lab3_7
{
    public interface IVector
    {
        Vector2D Set_Value(int x, int y);
        Vector2D Set_Value_Arr(int[] x, int[] y);
        int Length(int x, int y);
        Vector2D Sum(Vector2D a, Vector2D b);
        Vector2D Vec_on_Num(Vector2D a, int num);
        int Multi(Vector2D a, Vector2D b);
    }
}
