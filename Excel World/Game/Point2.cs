using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public struct Point2
    {
        public int X { get; set; }
        public int Y { get; set; }

        // 构造函数
        public Point2(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        // 加法运算符重载
        public static Point2 operator +(Point2 p1, Point2 p2)
        {
            return new Point2(p1.X + p2.X, p1.Y + p2.Y);
        }

        // 减法运算符重载
        public static Point2 operator -(Point2 p1, Point2 p2)
        {
            return new Point2(p1.X - p2.X, p1.Y - p2.Y);
        }

        // 乘法运算符重载（标量乘法）
        public static Point2 operator *(Point2 p, int scalar)
        {
            return new Point2(p.X * scalar, p.Y * scalar);
        }

        // 除法运算符重载（标量除法）
        public static Point2 operator /(Point2 p, int scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Scalar cannot be zero.");
            return new Point2(p.X / scalar, p.Y / scalar);
        }

        // 相等运算符重载
        public static bool operator ==(Point2 p1, Point2 p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        // 不等运算符重载
        public static bool operator !=(Point2 p1, Point2 p2)
        {
            return !(p1 == p2);
        }

        // 获取长度（欧几里得距离）
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // 获取平方长度（用于优化计算）
        public int LengthSquared()
        {
            return X * X + Y * Y;
        }

        // 计算点之间的距离
        public static double Distance(Point2 p1, Point2 p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // 计算点之间的平方距离
        public static int DistanceSquared(Point2 p1, Point2 p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            return dx * dx + dy * dy;
        }

        // 点积计算
        public int Dot(Point2 other)
        {
            return X * other.X + Y * other.Y;
        }

        // 转为字符串
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // 覆盖 Equals 方法
        public override bool Equals(object obj)
        {
            if (obj is Point2 p)
            {
                return X == p.X && Y == p.Y;
            }
            return false;
        }

        // 覆盖 GetHashCode 方法
        public override int GetHashCode()
        {
            unchecked // 使用 unchecked 防止溢出异常
            {
                int hash = 17;
                hash = hash * 31 + X;
                hash = hash * 31 + Y;
                return hash;
            }
        }
    }
}
