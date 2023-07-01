using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
namespace Plato {
public static partial class Intrinsics {
public static float Add(this float a, float b) => a + b;
public static IArray<float> Add(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a + b);
public static float Subtract(this float a, float b) => a - b;
public static IArray<float> Subtract(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a - b);
public static float Sum(this IArray<float> self) => self.Aggregate((a, b) => a + b);
public static float Multiply(this float a, float b) => a * b;
public static IArray<float> Multiply(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a * b);
public static float Divide(this float a, float b) => a / b;
public static IArray<float> Divide(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a / b);
public static float Modulo(this float a, float b) => a % b;
public static IArray<float> Modulo(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a % b);
public static float Product(this IArray<float> self) => self.Aggregate((a, b) => a * b);
public static float Negate(this float a) => - a;
public static IArray<float> Negate(this IArray<float> self) => self.Select(a => - a);
public static bool Equals(this float a, float b) => a == b;
public static bool NotEquals(this float a, float b) => a != b;
public static int CompareTo(this float self, float other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this float a, float b) => a < b;
public static IArray<bool> LessThan(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this float a, float b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this float a, float b) => a > b;
public static IArray<bool> GreaterThan(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this float a, float b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<float> self, IArray<float> other) => self.Zip(other, (a,b) => a >= b);
public static float Default(this float _) => default(float);
public static float Zero(this float _) => (float)0;
public static float One(this float _) => (float)1;
public static float MinValue(this float _) => float.MinValue;
public static float MaxValue(this float _) => float.MaxValue;
}
public static partial class Intrinsics {
public static double Add(this double a, double b) => a + b;
public static IArray<double> Add(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a + b);
public static double Subtract(this double a, double b) => a - b;
public static IArray<double> Subtract(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a - b);
public static double Sum(this IArray<double> self) => self.Aggregate((a, b) => a + b);
public static double Multiply(this double a, double b) => a * b;
public static IArray<double> Multiply(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a * b);
public static double Divide(this double a, double b) => a / b;
public static IArray<double> Divide(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a / b);
public static double Modulo(this double a, double b) => a % b;
public static IArray<double> Modulo(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a % b);
public static double Product(this IArray<double> self) => self.Aggregate((a, b) => a * b);
public static double Negate(this double a) => - a;
public static IArray<double> Negate(this IArray<double> self) => self.Select(a => - a);
public static bool Equals(this double a, double b) => a == b;
public static bool NotEquals(this double a, double b) => a != b;
public static int CompareTo(this double self, double other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this double a, double b) => a < b;
public static IArray<bool> LessThan(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this double a, double b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this double a, double b) => a > b;
public static IArray<bool> GreaterThan(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this double a, double b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<double> self, IArray<double> other) => self.Zip(other, (a,b) => a >= b);
public static double Default(this double _) => default(double);
public static double Zero(this double _) => (double)0;
public static double One(this double _) => (double)1;
public static double MinValue(this double _) => double.MinValue;
public static double MaxValue(this double _) => double.MaxValue;
}
public static partial class Intrinsics {
public static int Add(this int a, int b) => a + b;
public static IArray<int> Add(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a + b);
public static int Subtract(this int a, int b) => a - b;
public static IArray<int> Subtract(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a - b);
public static int Sum(this IArray<int> self) => self.Aggregate((a, b) => a + b);
public static int Multiply(this int a, int b) => a * b;
public static IArray<int> Multiply(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a * b);
public static int Divide(this int a, int b) => a / b;
public static IArray<int> Divide(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a / b);
public static int Modulo(this int a, int b) => a % b;
public static IArray<int> Modulo(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a % b);
public static int Product(this IArray<int> self) => self.Aggregate((a, b) => a * b);
public static int Negate(this int a) => - a;
public static IArray<int> Negate(this IArray<int> self) => self.Select(a => - a);
public static bool Equals(this int a, int b) => a == b;
public static bool NotEquals(this int a, int b) => a != b;
public static int CompareTo(this int self, int other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this int a, int b) => a < b;
public static IArray<bool> LessThan(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this int a, int b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this int a, int b) => a > b;
public static IArray<bool> GreaterThan(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this int a, int b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<int> self, IArray<int> other) => self.Zip(other, (a,b) => a >= b);
public static int Default(this int _) => default(int);
public static int Zero(this int _) => (int)0;
public static int One(this int _) => (int)1;
public static int MinValue(this int _) => int.MinValue;
public static int MaxValue(this int _) => int.MaxValue;
}
public static partial class Intrinsics {
public static long Add(this long a, long b) => a + b;
public static IArray<long> Add(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a + b);
public static long Subtract(this long a, long b) => a - b;
public static IArray<long> Subtract(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a - b);
public static long Sum(this IArray<long> self) => self.Aggregate((a, b) => a + b);
public static long Multiply(this long a, long b) => a * b;
public static IArray<long> Multiply(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a * b);
public static long Divide(this long a, long b) => a / b;
public static IArray<long> Divide(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a / b);
public static long Modulo(this long a, long b) => a % b;
public static IArray<long> Modulo(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a % b);
public static long Product(this IArray<long> self) => self.Aggregate((a, b) => a * b);
public static long Negate(this long a) => - a;
public static IArray<long> Negate(this IArray<long> self) => self.Select(a => - a);
public static bool Equals(this long a, long b) => a == b;
public static bool NotEquals(this long a, long b) => a != b;
public static int CompareTo(this long self, long other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this long a, long b) => a < b;
public static IArray<bool> LessThan(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this long a, long b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this long a, long b) => a > b;
public static IArray<bool> GreaterThan(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this long a, long b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<long> self, IArray<long> other) => self.Zip(other, (a,b) => a >= b);
public static long Default(this long _) => default(long);
public static long Zero(this long _) => (long)0;
public static long One(this long _) => (long)1;
public static long MinValue(this long _) => long.MinValue;
public static long MaxValue(this long _) => long.MaxValue;
}
public static partial class Intrinsics {
public static decimal Add(this decimal a, decimal b) => a + b;
public static IArray<decimal> Add(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a + b);
public static decimal Subtract(this decimal a, decimal b) => a - b;
public static IArray<decimal> Subtract(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a - b);
public static decimal Sum(this IArray<decimal> self) => self.Aggregate((a, b) => a + b);
public static decimal Multiply(this decimal a, decimal b) => a * b;
public static IArray<decimal> Multiply(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a * b);
public static decimal Divide(this decimal a, decimal b) => a / b;
public static IArray<decimal> Divide(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a / b);
public static decimal Modulo(this decimal a, decimal b) => a % b;
public static IArray<decimal> Modulo(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a % b);
public static decimal Product(this IArray<decimal> self) => self.Aggregate((a, b) => a * b);
public static decimal Negate(this decimal a) => - a;
public static IArray<decimal> Negate(this IArray<decimal> self) => self.Select(a => - a);
public static bool Equals(this decimal a, decimal b) => a == b;
public static bool NotEquals(this decimal a, decimal b) => a != b;
public static int CompareTo(this decimal self, decimal other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this decimal a, decimal b) => a < b;
public static IArray<bool> LessThan(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this decimal a, decimal b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this decimal a, decimal b) => a > b;
public static IArray<bool> GreaterThan(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this decimal a, decimal b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<decimal> self, IArray<decimal> other) => self.Zip(other, (a,b) => a >= b);
public static decimal Default(this decimal _) => default(decimal);
public static decimal Zero(this decimal _) => (decimal)0;
public static decimal One(this decimal _) => (decimal)1;
public static decimal MinValue(this decimal _) => decimal.MinValue;
public static decimal MaxValue(this decimal _) => decimal.MaxValue;
}
public static partial class Intrinsics {
public static byte Default(this byte _) => default(byte);
public static byte Zero(this byte _) => (byte)0;
public static byte One(this byte _) => (byte)1;
public static byte MinValue(this byte _) => byte.MinValue;
public static byte MaxValue(this byte _) => byte.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Float2
: IArray<float>
{
public Float2(float x, float y) => (X, Y) = (x, y);
public static Float2 Create(float x, float y) => new Float2(x, y);
public float X { get; }
public float Y { get; }
public static implicit operator Float2((float X, float Y) tuple) => new Float2(tuple.X, tuple.Y);
public static implicit operator (float X, float Y)(Float2 self) => (self.X, self.Y);
public void Deconstruct(out float x, out float y) => (x, y) = (X, Y);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y } }}";
public override bool Equals(object other) => other is Float2 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y).GetHashCode();
public static readonly Float2 Default = default;
public static Float2 Zero = new Float2(Default.X.Zero(),Default.Y.Zero());
public static Float2 One = new Float2(Default.X.One(),Default.Y.One());
public static Float2 MinValue = new Float2(Default.X.MinValue(),Default.Y.MinValue());
public static Float2 MaxValue = new Float2(Default.X.MaxValue(),Default.Y.MaxValue());
public static bool operator ==(Float2 a, Float2 b) => (a.X == b.X) && (a.Y == b.Y);
public static bool operator !=(Float2 a, Float2 b) => (a.X != b.X) || (a.Y != b.Y);
public Float2 WithX(float value) => new Float2(value, Y);
public Float2 WithY(float value) => new Float2(X, value);
public static Float2 operator +(Float2 a, Float2 b) => new Float2(a.X + b.X, a.Y + b.Y);
public static Float2 operator +(float a, Float2 b) => new Float2(a + b.X, a + b.Y);
public static Float2 operator +(Float2 a, float b) => new Float2(a.X + b, a.Y + b);
public static Float2 operator -(Float2 a, Float2 b) => new Float2(a.X - b.X, a.Y - b.Y);
public static Float2 operator -(float a, Float2 b) => new Float2(a - b.X, a - b.Y);
public static Float2 operator -(Float2 a, float b) => new Float2(a.X - b, a.Y - b);
public static Float2 operator *(Float2 a, Float2 b) => new Float2(a.X * b.X, a.Y * b.Y);
public static Float2 operator *(Float2 a, float  b) => new Float2(a.X * b, a.Y * b);
public static Float2 operator *(float  a, Float2 b) => new Float2(a * b.X, a * b.Y);
public static Float2 operator /(Float2 a, Float2 b) => new Float2(a.X / b.X, a.Y / b.Y);
public static Float2 operator /(Float2 a, float  b) => new Float2(a.X / b, a.Y / b);
public static Float2 operator /(float  a, Float2 b) => new Float2(a / b.X, a / b.Y);
public static Float2 operator %(Float2 a, Float2 b) => new Float2(a.X % b.X, a.Y % b.Y);
public static Float2 operator %(Float2 a, float  b) => new Float2(a.X % b, a.Y % b);
public static Float2 operator %(float  a, Float2 b) => new Float2(a % b.X, a % b.Y);
public static Float2 operator -(Float2 a) => new Float2(- a.X, - a.Y);
public static implicit operator float[](Float2 value) => new[] { value.X, value.Y };
public double Dot(Float2 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<float> Iterator => new ArrayIterator<float>(this);
public int Count => 2;
public float this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Float2 Add(this Float2 a, Float2 b) => a + b;
public static IArray<Float2> Add(this IArray<Float2> self, IArray<Float2> other) => self.Zip(other, (a,b) => a + b);
public static Float2 Subtract(this Float2 a, Float2 b) => a - b;
public static IArray<Float2> Subtract(this IArray<Float2> self, IArray<Float2> other) => self.Zip(other, (a,b) => a - b);
public static Float2 Sum(this IArray<Float2> self) => self.Aggregate((a, b) => a + b);
public static Float2 Multiply(this Float2 a, Float2 b) => a * b;
public static IArray<Float2> Multiply(this IArray<Float2> self, IArray<Float2> other) => self.Zip(other, (a,b) => a * b);
public static Float2 Divide(this Float2 a, Float2 b) => a / b;
public static IArray<Float2> Divide(this IArray<Float2> self, IArray<Float2> other) => self.Zip(other, (a,b) => a / b);
public static Float2 Modulo(this Float2 a, Float2 b) => a % b;
public static IArray<Float2> Modulo(this IArray<Float2> self, IArray<Float2> other) => self.Zip(other, (a,b) => a % b);
public static Float2 Product(this IArray<Float2> self) => self.Aggregate((a, b) => a * b);
public static Float2 Negate(this Float2 a) => - a;
public static IArray<Float2> Negate(this IArray<Float2> self) => self.Select(a => - a);
public static bool Equals(this Float2 a, Float2 b) => a == b;
public static bool NotEquals(this Float2 a, Float2 b) => a != b;
public static Float2 Default(this Float2 _) => default(Float2);
public static Float2 Zero(this Float2 _) => Float2.Zero;
public static Float2 One(this Float2 _) => Float2.One;
public static Float2 MinValue(this Float2 _) => Float2.MinValue;
public static Float2 MaxValue(this Float2 _) => Float2.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Float3
: IArray<float>
{
public Float3(float x, float y, float z) => (X, Y, Z) = (x, y, z);
public static Float3 Create(float x, float y, float z) => new Float3(x, y, z);
public float X { get; }
public float Y { get; }
public float Z { get; }
public static implicit operator Float3((float X, float Y, float Z) tuple) => new Float3(tuple.X, tuple.Y, tuple.Z);
public static implicit operator (float X, float Y, float Z)(Float3 self) => (self.X, self.Y, self.Z);
public void Deconstruct(out float x, out float y, out float z) => (x, y, z) = (X, Y, Z);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y }, \"Z\" : { Z } }}";
public override bool Equals(object other) => other is Float3 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y, Z).GetHashCode();
public static readonly Float3 Default = default;
public static Float3 Zero = new Float3(Default.X.Zero(),Default.Y.Zero(),Default.Z.Zero());
public static Float3 One = new Float3(Default.X.One(),Default.Y.One(),Default.Z.One());
public static Float3 MinValue = new Float3(Default.X.MinValue(),Default.Y.MinValue(),Default.Z.MinValue());
public static Float3 MaxValue = new Float3(Default.X.MaxValue(),Default.Y.MaxValue(),Default.Z.MaxValue());
public static bool operator ==(Float3 a, Float3 b) => (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
public static bool operator !=(Float3 a, Float3 b) => (a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z);
public Float3 WithX(float value) => new Float3(value, Y, Z);
public Float3 WithY(float value) => new Float3(X, value, Z);
public Float3 WithZ(float value) => new Float3(X, Y, value);
public static Float3 operator +(Float3 a, Float3 b) => new Float3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
public static Float3 operator +(float a, Float3 b) => new Float3(a + b.X, a + b.Y, a + b.Z);
public static Float3 operator +(Float3 a, float b) => new Float3(a.X + b, a.Y + b, a.Z + b);
public static Float3 operator -(Float3 a, Float3 b) => new Float3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
public static Float3 operator -(float a, Float3 b) => new Float3(a - b.X, a - b.Y, a - b.Z);
public static Float3 operator -(Float3 a, float b) => new Float3(a.X - b, a.Y - b, a.Z - b);
public static Float3 operator *(Float3 a, Float3 b) => new Float3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
public static Float3 operator *(Float3 a, float  b) => new Float3(a.X * b, a.Y * b, a.Z * b);
public static Float3 operator *(float  a, Float3 b) => new Float3(a * b.X, a * b.Y, a * b.Z);
public static Float3 operator /(Float3 a, Float3 b) => new Float3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
public static Float3 operator /(Float3 a, float  b) => new Float3(a.X / b, a.Y / b, a.Z / b);
public static Float3 operator /(float  a, Float3 b) => new Float3(a / b.X, a / b.Y, a / b.Z);
public static Float3 operator %(Float3 a, Float3 b) => new Float3(a.X % b.X, a.Y % b.Y, a.Z % b.Z);
public static Float3 operator %(Float3 a, float  b) => new Float3(a.X % b, a.Y % b, a.Z % b);
public static Float3 operator %(float  a, Float3 b) => new Float3(a % b.X, a % b.Y, a % b.Z);
public static Float3 operator -(Float3 a) => new Float3(- a.X, - a.Y, - a.Z);
public static implicit operator float[](Float3 value) => new[] { value.X, value.Y, value.Z };
public double Dot(Float3 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<float> Iterator => new ArrayIterator<float>(this);
public int Count => 3;
public float this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
case 2: return Z;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Float3 Add(this Float3 a, Float3 b) => a + b;
public static IArray<Float3> Add(this IArray<Float3> self, IArray<Float3> other) => self.Zip(other, (a,b) => a + b);
public static Float3 Subtract(this Float3 a, Float3 b) => a - b;
public static IArray<Float3> Subtract(this IArray<Float3> self, IArray<Float3> other) => self.Zip(other, (a,b) => a - b);
public static Float3 Sum(this IArray<Float3> self) => self.Aggregate((a, b) => a + b);
public static Float3 Multiply(this Float3 a, Float3 b) => a * b;
public static IArray<Float3> Multiply(this IArray<Float3> self, IArray<Float3> other) => self.Zip(other, (a,b) => a * b);
public static Float3 Divide(this Float3 a, Float3 b) => a / b;
public static IArray<Float3> Divide(this IArray<Float3> self, IArray<Float3> other) => self.Zip(other, (a,b) => a / b);
public static Float3 Modulo(this Float3 a, Float3 b) => a % b;
public static IArray<Float3> Modulo(this IArray<Float3> self, IArray<Float3> other) => self.Zip(other, (a,b) => a % b);
public static Float3 Product(this IArray<Float3> self) => self.Aggregate((a, b) => a * b);
public static Float3 Negate(this Float3 a) => - a;
public static IArray<Float3> Negate(this IArray<Float3> self) => self.Select(a => - a);
public static bool Equals(this Float3 a, Float3 b) => a == b;
public static bool NotEquals(this Float3 a, Float3 b) => a != b;
public static Float3 Default(this Float3 _) => default(Float3);
public static Float3 Zero(this Float3 _) => Float3.Zero;
public static Float3 One(this Float3 _) => Float3.One;
public static Float3 MinValue(this Float3 _) => Float3.MinValue;
public static Float3 MaxValue(this Float3 _) => Float3.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Float4
: IArray<float>
{
public Float4(float x, float y, float z, float w) => (X, Y, Z, W) = (x, y, z, w);
public static Float4 Create(float x, float y, float z, float w) => new Float4(x, y, z, w);
public float X { get; }
public float Y { get; }
public float Z { get; }
public float W { get; }
public static implicit operator Float4((float X, float Y, float Z, float W) tuple) => new Float4(tuple.X, tuple.Y, tuple.Z, tuple.W);
public static implicit operator (float X, float Y, float Z, float W)(Float4 self) => (self.X, self.Y, self.Z, self.W);
public void Deconstruct(out float x, out float y, out float z, out float w) => (x, y, z, w) = (X, Y, Z, W);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y }, \"Z\" : { Z }, \"W\" : { W } }}";
public override bool Equals(object other) => other is Float4 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y, Z, W).GetHashCode();
public static readonly Float4 Default = default;
public static Float4 Zero = new Float4(Default.X.Zero(),Default.Y.Zero(),Default.Z.Zero(),Default.W.Zero());
public static Float4 One = new Float4(Default.X.One(),Default.Y.One(),Default.Z.One(),Default.W.One());
public static Float4 MinValue = new Float4(Default.X.MinValue(),Default.Y.MinValue(),Default.Z.MinValue(),Default.W.MinValue());
public static Float4 MaxValue = new Float4(Default.X.MaxValue(),Default.Y.MaxValue(),Default.Z.MaxValue(),Default.W.MaxValue());
public static bool operator ==(Float4 a, Float4 b) => (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z) && (a.W == b.W);
public static bool operator !=(Float4 a, Float4 b) => (a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z) || (a.W != b.W);
public Float4 WithX(float value) => new Float4(value, Y, Z, W);
public Float4 WithY(float value) => new Float4(X, value, Z, W);
public Float4 WithZ(float value) => new Float4(X, Y, value, W);
public Float4 WithW(float value) => new Float4(X, Y, Z, value);
public static Float4 operator +(Float4 a, Float4 b) => new Float4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
public static Float4 operator +(float a, Float4 b) => new Float4(a + b.X, a + b.Y, a + b.Z, a + b.W);
public static Float4 operator +(Float4 a, float b) => new Float4(a.X + b, a.Y + b, a.Z + b, a.W + b);
public static Float4 operator -(Float4 a, Float4 b) => new Float4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
public static Float4 operator -(float a, Float4 b) => new Float4(a - b.X, a - b.Y, a - b.Z, a - b.W);
public static Float4 operator -(Float4 a, float b) => new Float4(a.X - b, a.Y - b, a.Z - b, a.W - b);
public static Float4 operator *(Float4 a, Float4 b) => new Float4(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
public static Float4 operator *(Float4 a, float  b) => new Float4(a.X * b, a.Y * b, a.Z * b, a.W * b);
public static Float4 operator *(float  a, Float4 b) => new Float4(a * b.X, a * b.Y, a * b.Z, a * b.W);
public static Float4 operator /(Float4 a, Float4 b) => new Float4(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
public static Float4 operator /(Float4 a, float  b) => new Float4(a.X / b, a.Y / b, a.Z / b, a.W / b);
public static Float4 operator /(float  a, Float4 b) => new Float4(a / b.X, a / b.Y, a / b.Z, a / b.W);
public static Float4 operator %(Float4 a, Float4 b) => new Float4(a.X % b.X, a.Y % b.Y, a.Z % b.Z, a.W % b.W);
public static Float4 operator %(Float4 a, float  b) => new Float4(a.X % b, a.Y % b, a.Z % b, a.W % b);
public static Float4 operator %(float  a, Float4 b) => new Float4(a % b.X, a % b.Y, a % b.Z, a % b.W);
public static Float4 operator -(Float4 a) => new Float4(- a.X, - a.Y, - a.Z, - a.W);
public static implicit operator float[](Float4 value) => new[] { value.X, value.Y, value.Z, value.W };
public double Dot(Float4 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<float> Iterator => new ArrayIterator<float>(this);
public int Count => 4;
public float this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
case 2: return Z;
case 3: return W;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Float4 Add(this Float4 a, Float4 b) => a + b;
public static IArray<Float4> Add(this IArray<Float4> self, IArray<Float4> other) => self.Zip(other, (a,b) => a + b);
public static Float4 Subtract(this Float4 a, Float4 b) => a - b;
public static IArray<Float4> Subtract(this IArray<Float4> self, IArray<Float4> other) => self.Zip(other, (a,b) => a - b);
public static Float4 Sum(this IArray<Float4> self) => self.Aggregate((a, b) => a + b);
public static Float4 Multiply(this Float4 a, Float4 b) => a * b;
public static IArray<Float4> Multiply(this IArray<Float4> self, IArray<Float4> other) => self.Zip(other, (a,b) => a * b);
public static Float4 Divide(this Float4 a, Float4 b) => a / b;
public static IArray<Float4> Divide(this IArray<Float4> self, IArray<Float4> other) => self.Zip(other, (a,b) => a / b);
public static Float4 Modulo(this Float4 a, Float4 b) => a % b;
public static IArray<Float4> Modulo(this IArray<Float4> self, IArray<Float4> other) => self.Zip(other, (a,b) => a % b);
public static Float4 Product(this IArray<Float4> self) => self.Aggregate((a, b) => a * b);
public static Float4 Negate(this Float4 a) => - a;
public static IArray<Float4> Negate(this IArray<Float4> self) => self.Select(a => - a);
public static bool Equals(this Float4 a, Float4 b) => a == b;
public static bool NotEquals(this Float4 a, Float4 b) => a != b;
public static Float4 Default(this Float4 _) => default(Float4);
public static Float4 Zero(this Float4 _) => Float4.Zero;
public static Float4 One(this Float4 _) => Float4.One;
public static Float4 MinValue(this Float4 _) => Float4.MinValue;
public static Float4 MaxValue(this Float4 _) => Float4.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Double2
: IArray<double>
{
public Double2(double x, double y) => (X, Y) = (x, y);
public static Double2 Create(double x, double y) => new Double2(x, y);
public double X { get; }
public double Y { get; }
public static implicit operator Double2((double X, double Y) tuple) => new Double2(tuple.X, tuple.Y);
public static implicit operator (double X, double Y)(Double2 self) => (self.X, self.Y);
public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y } }}";
public override bool Equals(object other) => other is Double2 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y).GetHashCode();
public static readonly Double2 Default = default;
public static Double2 Zero = new Double2(Default.X.Zero(),Default.Y.Zero());
public static Double2 One = new Double2(Default.X.One(),Default.Y.One());
public static Double2 MinValue = new Double2(Default.X.MinValue(),Default.Y.MinValue());
public static Double2 MaxValue = new Double2(Default.X.MaxValue(),Default.Y.MaxValue());
public static bool operator ==(Double2 a, Double2 b) => (a.X == b.X) && (a.Y == b.Y);
public static bool operator !=(Double2 a, Double2 b) => (a.X != b.X) || (a.Y != b.Y);
public Double2 WithX(double value) => new Double2(value, Y);
public Double2 WithY(double value) => new Double2(X, value);
public static Double2 operator +(Double2 a, Double2 b) => new Double2(a.X + b.X, a.Y + b.Y);
public static Double2 operator +(double a, Double2 b) => new Double2(a + b.X, a + b.Y);
public static Double2 operator +(Double2 a, double b) => new Double2(a.X + b, a.Y + b);
public static Double2 operator -(Double2 a, Double2 b) => new Double2(a.X - b.X, a.Y - b.Y);
public static Double2 operator -(double a, Double2 b) => new Double2(a - b.X, a - b.Y);
public static Double2 operator -(Double2 a, double b) => new Double2(a.X - b, a.Y - b);
public static Double2 operator *(Double2 a, Double2 b) => new Double2(a.X * b.X, a.Y * b.Y);
public static Double2 operator *(Double2 a, double  b) => new Double2(a.X * b, a.Y * b);
public static Double2 operator *(double  a, Double2 b) => new Double2(a * b.X, a * b.Y);
public static Double2 operator /(Double2 a, Double2 b) => new Double2(a.X / b.X, a.Y / b.Y);
public static Double2 operator /(Double2 a, double  b) => new Double2(a.X / b, a.Y / b);
public static Double2 operator /(double  a, Double2 b) => new Double2(a / b.X, a / b.Y);
public static Double2 operator %(Double2 a, Double2 b) => new Double2(a.X % b.X, a.Y % b.Y);
public static Double2 operator %(Double2 a, double  b) => new Double2(a.X % b, a.Y % b);
public static Double2 operator %(double  a, Double2 b) => new Double2(a % b.X, a % b.Y);
public static Double2 operator -(Double2 a) => new Double2(- a.X, - a.Y);
public static implicit operator double[](Double2 value) => new[] { value.X, value.Y };
public double Dot(Double2 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<double> Iterator => new ArrayIterator<double>(this);
public int Count => 2;
public double this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Double2 Add(this Double2 a, Double2 b) => a + b;
public static IArray<Double2> Add(this IArray<Double2> self, IArray<Double2> other) => self.Zip(other, (a,b) => a + b);
public static Double2 Subtract(this Double2 a, Double2 b) => a - b;
public static IArray<Double2> Subtract(this IArray<Double2> self, IArray<Double2> other) => self.Zip(other, (a,b) => a - b);
public static Double2 Sum(this IArray<Double2> self) => self.Aggregate((a, b) => a + b);
public static Double2 Multiply(this Double2 a, Double2 b) => a * b;
public static IArray<Double2> Multiply(this IArray<Double2> self, IArray<Double2> other) => self.Zip(other, (a,b) => a * b);
public static Double2 Divide(this Double2 a, Double2 b) => a / b;
public static IArray<Double2> Divide(this IArray<Double2> self, IArray<Double2> other) => self.Zip(other, (a,b) => a / b);
public static Double2 Modulo(this Double2 a, Double2 b) => a % b;
public static IArray<Double2> Modulo(this IArray<Double2> self, IArray<Double2> other) => self.Zip(other, (a,b) => a % b);
public static Double2 Product(this IArray<Double2> self) => self.Aggregate((a, b) => a * b);
public static Double2 Negate(this Double2 a) => - a;
public static IArray<Double2> Negate(this IArray<Double2> self) => self.Select(a => - a);
public static bool Equals(this Double2 a, Double2 b) => a == b;
public static bool NotEquals(this Double2 a, Double2 b) => a != b;
public static Double2 Default(this Double2 _) => default(Double2);
public static Double2 Zero(this Double2 _) => Double2.Zero;
public static Double2 One(this Double2 _) => Double2.One;
public static Double2 MinValue(this Double2 _) => Double2.MinValue;
public static Double2 MaxValue(this Double2 _) => Double2.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Double3
: IArray<double>
{
public Double3(double x, double y, double z) => (X, Y, Z) = (x, y, z);
public static Double3 Create(double x, double y, double z) => new Double3(x, y, z);
public double X { get; }
public double Y { get; }
public double Z { get; }
public static implicit operator Double3((double X, double Y, double Z) tuple) => new Double3(tuple.X, tuple.Y, tuple.Z);
public static implicit operator (double X, double Y, double Z)(Double3 self) => (self.X, self.Y, self.Z);
public void Deconstruct(out double x, out double y, out double z) => (x, y, z) = (X, Y, Z);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y }, \"Z\" : { Z } }}";
public override bool Equals(object other) => other is Double3 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y, Z).GetHashCode();
public static readonly Double3 Default = default;
public static Double3 Zero = new Double3(Default.X.Zero(),Default.Y.Zero(),Default.Z.Zero());
public static Double3 One = new Double3(Default.X.One(),Default.Y.One(),Default.Z.One());
public static Double3 MinValue = new Double3(Default.X.MinValue(),Default.Y.MinValue(),Default.Z.MinValue());
public static Double3 MaxValue = new Double3(Default.X.MaxValue(),Default.Y.MaxValue(),Default.Z.MaxValue());
public static bool operator ==(Double3 a, Double3 b) => (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
public static bool operator !=(Double3 a, Double3 b) => (a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z);
public Double3 WithX(double value) => new Double3(value, Y, Z);
public Double3 WithY(double value) => new Double3(X, value, Z);
public Double3 WithZ(double value) => new Double3(X, Y, value);
public static Double3 operator +(Double3 a, Double3 b) => new Double3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
public static Double3 operator +(double a, Double3 b) => new Double3(a + b.X, a + b.Y, a + b.Z);
public static Double3 operator +(Double3 a, double b) => new Double3(a.X + b, a.Y + b, a.Z + b);
public static Double3 operator -(Double3 a, Double3 b) => new Double3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
public static Double3 operator -(double a, Double3 b) => new Double3(a - b.X, a - b.Y, a - b.Z);
public static Double3 operator -(Double3 a, double b) => new Double3(a.X - b, a.Y - b, a.Z - b);
public static Double3 operator *(Double3 a, Double3 b) => new Double3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
public static Double3 operator *(Double3 a, double  b) => new Double3(a.X * b, a.Y * b, a.Z * b);
public static Double3 operator *(double  a, Double3 b) => new Double3(a * b.X, a * b.Y, a * b.Z);
public static Double3 operator /(Double3 a, Double3 b) => new Double3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
public static Double3 operator /(Double3 a, double  b) => new Double3(a.X / b, a.Y / b, a.Z / b);
public static Double3 operator /(double  a, Double3 b) => new Double3(a / b.X, a / b.Y, a / b.Z);
public static Double3 operator %(Double3 a, Double3 b) => new Double3(a.X % b.X, a.Y % b.Y, a.Z % b.Z);
public static Double3 operator %(Double3 a, double  b) => new Double3(a.X % b, a.Y % b, a.Z % b);
public static Double3 operator %(double  a, Double3 b) => new Double3(a % b.X, a % b.Y, a % b.Z);
public static Double3 operator -(Double3 a) => new Double3(- a.X, - a.Y, - a.Z);
public static implicit operator double[](Double3 value) => new[] { value.X, value.Y, value.Z };
public double Dot(Double3 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<double> Iterator => new ArrayIterator<double>(this);
public int Count => 3;
public double this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
case 2: return Z;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Double3 Add(this Double3 a, Double3 b) => a + b;
public static IArray<Double3> Add(this IArray<Double3> self, IArray<Double3> other) => self.Zip(other, (a,b) => a + b);
public static Double3 Subtract(this Double3 a, Double3 b) => a - b;
public static IArray<Double3> Subtract(this IArray<Double3> self, IArray<Double3> other) => self.Zip(other, (a,b) => a - b);
public static Double3 Sum(this IArray<Double3> self) => self.Aggregate((a, b) => a + b);
public static Double3 Multiply(this Double3 a, Double3 b) => a * b;
public static IArray<Double3> Multiply(this IArray<Double3> self, IArray<Double3> other) => self.Zip(other, (a,b) => a * b);
public static Double3 Divide(this Double3 a, Double3 b) => a / b;
public static IArray<Double3> Divide(this IArray<Double3> self, IArray<Double3> other) => self.Zip(other, (a,b) => a / b);
public static Double3 Modulo(this Double3 a, Double3 b) => a % b;
public static IArray<Double3> Modulo(this IArray<Double3> self, IArray<Double3> other) => self.Zip(other, (a,b) => a % b);
public static Double3 Product(this IArray<Double3> self) => self.Aggregate((a, b) => a * b);
public static Double3 Negate(this Double3 a) => - a;
public static IArray<Double3> Negate(this IArray<Double3> self) => self.Select(a => - a);
public static bool Equals(this Double3 a, Double3 b) => a == b;
public static bool NotEquals(this Double3 a, Double3 b) => a != b;
public static Double3 Default(this Double3 _) => default(Double3);
public static Double3 Zero(this Double3 _) => Double3.Zero;
public static Double3 One(this Double3 _) => Double3.One;
public static Double3 MinValue(this Double3 _) => Double3.MinValue;
public static Double3 MaxValue(this Double3 _) => Double3.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Double4
: IArray<double>
{
public Double4(double x, double y, double z, double w) => (X, Y, Z, W) = (x, y, z, w);
public static Double4 Create(double x, double y, double z, double w) => new Double4(x, y, z, w);
public double X { get; }
public double Y { get; }
public double Z { get; }
public double W { get; }
public static implicit operator Double4((double X, double Y, double Z, double W) tuple) => new Double4(tuple.X, tuple.Y, tuple.Z, tuple.W);
public static implicit operator (double X, double Y, double Z, double W)(Double4 self) => (self.X, self.Y, self.Z, self.W);
public void Deconstruct(out double x, out double y, out double z, out double w) => (x, y, z, w) = (X, Y, Z, W);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y }, \"Z\" : { Z }, \"W\" : { W } }}";
public override bool Equals(object other) => other is Double4 typedOther && this == typedOther;
public override int GetHashCode() => (X, Y, Z, W).GetHashCode();
public static readonly Double4 Default = default;
public static Double4 Zero = new Double4(Default.X.Zero(),Default.Y.Zero(),Default.Z.Zero(),Default.W.Zero());
public static Double4 One = new Double4(Default.X.One(),Default.Y.One(),Default.Z.One(),Default.W.One());
public static Double4 MinValue = new Double4(Default.X.MinValue(),Default.Y.MinValue(),Default.Z.MinValue(),Default.W.MinValue());
public static Double4 MaxValue = new Double4(Default.X.MaxValue(),Default.Y.MaxValue(),Default.Z.MaxValue(),Default.W.MaxValue());
public static bool operator ==(Double4 a, Double4 b) => (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z) && (a.W == b.W);
public static bool operator !=(Double4 a, Double4 b) => (a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z) || (a.W != b.W);
public Double4 WithX(double value) => new Double4(value, Y, Z, W);
public Double4 WithY(double value) => new Double4(X, value, Z, W);
public Double4 WithZ(double value) => new Double4(X, Y, value, W);
public Double4 WithW(double value) => new Double4(X, Y, Z, value);
public static Double4 operator +(Double4 a, Double4 b) => new Double4(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
public static Double4 operator +(double a, Double4 b) => new Double4(a + b.X, a + b.Y, a + b.Z, a + b.W);
public static Double4 operator +(Double4 a, double b) => new Double4(a.X + b, a.Y + b, a.Z + b, a.W + b);
public static Double4 operator -(Double4 a, Double4 b) => new Double4(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
public static Double4 operator -(double a, Double4 b) => new Double4(a - b.X, a - b.Y, a - b.Z, a - b.W);
public static Double4 operator -(Double4 a, double b) => new Double4(a.X - b, a.Y - b, a.Z - b, a.W - b);
public static Double4 operator *(Double4 a, Double4 b) => new Double4(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
public static Double4 operator *(Double4 a, double  b) => new Double4(a.X * b, a.Y * b, a.Z * b, a.W * b);
public static Double4 operator *(double  a, Double4 b) => new Double4(a * b.X, a * b.Y, a * b.Z, a * b.W);
public static Double4 operator /(Double4 a, Double4 b) => new Double4(a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);
public static Double4 operator /(Double4 a, double  b) => new Double4(a.X / b, a.Y / b, a.Z / b, a.W / b);
public static Double4 operator /(double  a, Double4 b) => new Double4(a / b.X, a / b.Y, a / b.Z, a / b.W);
public static Double4 operator %(Double4 a, Double4 b) => new Double4(a.X % b.X, a.Y % b.Y, a.Z % b.Z, a.W % b.W);
public static Double4 operator %(Double4 a, double  b) => new Double4(a.X % b, a.Y % b, a.Z % b, a.W % b);
public static Double4 operator %(double  a, Double4 b) => new Double4(a % b.X, a % b.Y, a % b.Z, a % b.W);
public static Double4 operator -(Double4 a) => new Double4(- a.X, - a.Y, - a.Z, - a.W);
public static implicit operator double[](Double4 value) => new[] { value.X, value.Y, value.Z, value.W };
public double Dot(Double4 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<double> Iterator => new ArrayIterator<double>(this);
public int Count => 4;
public double this[int index] { get { switch (index) {
case 0: return X;
case 1: return Y;
case 2: return Z;
case 3: return W;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Double4 Add(this Double4 a, Double4 b) => a + b;
public static IArray<Double4> Add(this IArray<Double4> self, IArray<Double4> other) => self.Zip(other, (a,b) => a + b);
public static Double4 Subtract(this Double4 a, Double4 b) => a - b;
public static IArray<Double4> Subtract(this IArray<Double4> self, IArray<Double4> other) => self.Zip(other, (a,b) => a - b);
public static Double4 Sum(this IArray<Double4> self) => self.Aggregate((a, b) => a + b);
public static Double4 Multiply(this Double4 a, Double4 b) => a * b;
public static IArray<Double4> Multiply(this IArray<Double4> self, IArray<Double4> other) => self.Zip(other, (a,b) => a * b);
public static Double4 Divide(this Double4 a, Double4 b) => a / b;
public static IArray<Double4> Divide(this IArray<Double4> self, IArray<Double4> other) => self.Zip(other, (a,b) => a / b);
public static Double4 Modulo(this Double4 a, Double4 b) => a % b;
public static IArray<Double4> Modulo(this IArray<Double4> self, IArray<Double4> other) => self.Zip(other, (a,b) => a % b);
public static Double4 Product(this IArray<Double4> self) => self.Aggregate((a, b) => a * b);
public static Double4 Negate(this Double4 a) => - a;
public static IArray<Double4> Negate(this IArray<Double4> self) => self.Select(a => - a);
public static bool Equals(this Double4 a, Double4 b) => a == b;
public static bool NotEquals(this Double4 a, Double4 b) => a != b;
public static Double4 Default(this Double4 _) => default(Double4);
public static Double4 Zero(this Double4 _) => Double4.Zero;
public static Double4 One(this Double4 _) => Double4.One;
public static Double4 MinValue(this Double4 _) => Double4.MinValue;
public static Double4 MaxValue(this Double4 _) => Double4.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Quaternion
{
public Quaternion(double x, double y, double z, double w) => (X, Y, Z, W) = (x, y, z, w);
public static Quaternion Create(double x, double y, double z, double w) => new Quaternion(x, y, z, w);
public double X { get; }
public double Y { get; }
public double Z { get; }
public double W { get; }
public static implicit operator Quaternion((double X, double Y, double Z, double W) tuple) => new Quaternion(tuple.X, tuple.Y, tuple.Z, tuple.W);
public static implicit operator (double X, double Y, double Z, double W)(Quaternion self) => (self.X, self.Y, self.Z, self.W);
public void Deconstruct(out double x, out double y, out double z, out double w) => (x, y, z, w) = (X, Y, Z, W);
public override string ToString() => $"{{ \"X\" : { X }, \"Y\" : { Y }, \"Z\" : { Z }, \"W\" : { W } }}";
public override bool Equals(object other) => other is Quaternion typedOther && this == typedOther;
public override int GetHashCode() => (X, Y, Z, W).GetHashCode();
public static readonly Quaternion Default = default;
public static Quaternion Zero = new Quaternion(Default.X.Zero(),Default.Y.Zero(),Default.Z.Zero(),Default.W.Zero());
public static Quaternion One = new Quaternion(Default.X.One(),Default.Y.One(),Default.Z.One(),Default.W.One());
public static Quaternion MinValue = new Quaternion(Default.X.MinValue(),Default.Y.MinValue(),Default.Z.MinValue(),Default.W.MinValue());
public static Quaternion MaxValue = new Quaternion(Default.X.MaxValue(),Default.Y.MaxValue(),Default.Z.MaxValue(),Default.W.MaxValue());
public static bool operator ==(Quaternion a, Quaternion b) => (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z) && (a.W == b.W);
public static bool operator !=(Quaternion a, Quaternion b) => (a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z) || (a.W != b.W);
public Quaternion WithX(double value) => new Quaternion(value, Y, Z, W);
public Quaternion WithY(double value) => new Quaternion(X, value, Z, W);
public Quaternion WithZ(double value) => new Quaternion(X, Y, value, W);
public Quaternion WithW(double value) => new Quaternion(X, Y, Z, value);
}
public static partial class Intrinsics {
public static Quaternion Default(this Quaternion _) => default(Quaternion);
public static Quaternion Zero(this Quaternion _) => Quaternion.Zero;
public static Quaternion One(this Quaternion _) => Quaternion.One;
public static Quaternion MinValue(this Quaternion _) => Quaternion.MinValue;
public static Quaternion MaxValue(this Quaternion _) => Quaternion.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AxisAngle
{
public AxisAngle(Double3 axis, Angle angle) => (Axis, Angle) = (axis, angle);
public static AxisAngle Create(Double3 axis, Angle angle) => new AxisAngle(axis, angle);
public Double3 Axis { get; }
public Angle Angle { get; }
public static implicit operator AxisAngle((Double3 Axis, Angle Angle) tuple) => new AxisAngle(tuple.Axis, tuple.Angle);
public static implicit operator (Double3 Axis, Angle Angle)(AxisAngle self) => (self.Axis, self.Angle);
public void Deconstruct(out Double3 axis, out Angle angle) => (axis, angle) = (Axis, Angle);
public override string ToString() => $"{{ \"Axis\" : { Axis }, \"Angle\" : { Angle } }}";
public override bool Equals(object other) => other is AxisAngle typedOther && this == typedOther;
public override int GetHashCode() => (Axis, Angle).GetHashCode();
public static readonly AxisAngle Default = default;
public static AxisAngle Zero = new AxisAngle(Default.Axis.Zero(),Default.Angle.Zero());
public static AxisAngle One = new AxisAngle(Default.Axis.One(),Default.Angle.One());
public static AxisAngle MinValue = new AxisAngle(Default.Axis.MinValue(),Default.Angle.MinValue());
public static AxisAngle MaxValue = new AxisAngle(Default.Axis.MaxValue(),Default.Angle.MaxValue());
public static bool operator ==(AxisAngle a, AxisAngle b) => (a.Axis == b.Axis) && (a.Angle == b.Angle);
public static bool operator !=(AxisAngle a, AxisAngle b) => (a.Axis != b.Axis) || (a.Angle != b.Angle);
public AxisAngle WithAxis(Double3 value) => new AxisAngle(value, Angle);
public AxisAngle WithAngle(Angle value) => new AxisAngle(Axis, value);
}
public static partial class Intrinsics {
public static AxisAngle Default(this AxisAngle _) => default(AxisAngle);
public static AxisAngle Zero(this AxisAngle _) => AxisAngle.Zero;
public static AxisAngle One(this AxisAngle _) => AxisAngle.One;
public static AxisAngle MinValue(this AxisAngle _) => AxisAngle.MinValue;
public static AxisAngle MaxValue(this AxisAngle _) => AxisAngle.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EulerAngles
{
public EulerAngles(Angle yaw, Angle pitch, Angle roll) => (Yaw, Pitch, Roll) = (yaw, pitch, roll);
public static EulerAngles Create(Angle yaw, Angle pitch, Angle roll) => new EulerAngles(yaw, pitch, roll);
public Angle Yaw { get; }
public Angle Pitch { get; }
public Angle Roll { get; }
public static implicit operator EulerAngles((Angle Yaw, Angle Pitch, Angle Roll) tuple) => new EulerAngles(tuple.Yaw, tuple.Pitch, tuple.Roll);
public static implicit operator (Angle Yaw, Angle Pitch, Angle Roll)(EulerAngles self) => (self.Yaw, self.Pitch, self.Roll);
public void Deconstruct(out Angle yaw, out Angle pitch, out Angle roll) => (yaw, pitch, roll) = (Yaw, Pitch, Roll);
public override string ToString() => $"{{ \"Yaw\" : { Yaw }, \"Pitch\" : { Pitch }, \"Roll\" : { Roll } }}";
public override bool Equals(object other) => other is EulerAngles typedOther && this == typedOther;
public override int GetHashCode() => (Yaw, Pitch, Roll).GetHashCode();
public static readonly EulerAngles Default = default;
public static EulerAngles Zero = new EulerAngles(Default.Yaw.Zero(),Default.Pitch.Zero(),Default.Roll.Zero());
public static EulerAngles One = new EulerAngles(Default.Yaw.One(),Default.Pitch.One(),Default.Roll.One());
public static EulerAngles MinValue = new EulerAngles(Default.Yaw.MinValue(),Default.Pitch.MinValue(),Default.Roll.MinValue());
public static EulerAngles MaxValue = new EulerAngles(Default.Yaw.MaxValue(),Default.Pitch.MaxValue(),Default.Roll.MaxValue());
public static bool operator ==(EulerAngles a, EulerAngles b) => (a.Yaw == b.Yaw) && (a.Pitch == b.Pitch) && (a.Roll == b.Roll);
public static bool operator !=(EulerAngles a, EulerAngles b) => (a.Yaw != b.Yaw) || (a.Pitch != b.Pitch) || (a.Roll != b.Roll);
public EulerAngles WithYaw(Angle value) => new EulerAngles(value, Pitch, Roll);
public EulerAngles WithPitch(Angle value) => new EulerAngles(Yaw, value, Roll);
public EulerAngles WithRoll(Angle value) => new EulerAngles(Yaw, Pitch, value);
}
public static partial class Intrinsics {
public static EulerAngles Default(this EulerAngles _) => default(EulerAngles);
public static EulerAngles Zero(this EulerAngles _) => EulerAngles.Zero;
public static EulerAngles One(this EulerAngles _) => EulerAngles.One;
public static EulerAngles MinValue(this EulerAngles _) => EulerAngles.MinValue;
public static EulerAngles MaxValue(this EulerAngles _) => EulerAngles.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Rotation
{
public Rotation(Quaternion quaternion) => (Quaternion) = (quaternion);
public static Rotation Create(Quaternion quaternion) => new Rotation(quaternion);
public Quaternion Quaternion { get; }
public static implicit operator Rotation(Quaternion value) => new Rotation(value);
public static implicit operator Quaternion(Rotation value) => value.Quaternion;
public override string ToString() => $"{{ \"Quaternion\" : { Quaternion } }}";
public override bool Equals(object other) => other is Rotation typedOther && this == typedOther;
public override int GetHashCode() => (Quaternion).GetHashCode();
public static readonly Rotation Default = default;
public static Rotation Zero = new Rotation(Default.Quaternion.Zero());
public static Rotation One = new Rotation(Default.Quaternion.One());
public static Rotation MinValue = new Rotation(Default.Quaternion.MinValue());
public static Rotation MaxValue = new Rotation(Default.Quaternion.MaxValue());
public static bool operator ==(Rotation a, Rotation b) => (a.Quaternion == b.Quaternion);
public static bool operator !=(Rotation a, Rotation b) => (a.Quaternion != b.Quaternion);
public Rotation WithQuaternion(Quaternion value) => new Rotation(value);
}
public static partial class Intrinsics {
public static Rotation Default(this Rotation _) => default(Rotation);
public static Rotation Zero(this Rotation _) => Rotation.Zero;
public static Rotation One(this Rotation _) => Rotation.One;
public static Quaternion ToQuaternion(this Rotation self) => self;
public static Rotation MinValue(this Rotation _) => Rotation.MinValue;
public static Rotation MaxValue(this Rotation _) => Rotation.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Byte2
{
public Byte2(byte a, byte b, byte c, byte d) => (A, B, C, D) = (a, b, c, d);
public static Byte2 Create(byte a, byte b, byte c, byte d) => new Byte2(a, b, c, d);
public byte A { get; }
public byte B { get; }
public byte C { get; }
public byte D { get; }
public static implicit operator Byte2((byte A, byte B, byte C, byte D) tuple) => new Byte2(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (byte A, byte B, byte C, byte D)(Byte2 self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out byte a, out byte b, out byte c, out byte d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Byte2 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Byte2 Default = default;
public static Byte2 Zero = new Byte2(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Byte2 One = new Byte2(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Byte2 MinValue = new Byte2(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Byte2 MaxValue = new Byte2(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Byte2 a, Byte2 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Byte2 a, Byte2 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Byte2 WithA(byte value) => new Byte2(value, B, C, D);
public Byte2 WithB(byte value) => new Byte2(A, value, C, D);
public Byte2 WithC(byte value) => new Byte2(A, B, value, D);
public Byte2 WithD(byte value) => new Byte2(A, B, C, value);
}
public static partial class Intrinsics {
public static Byte2 Default(this Byte2 _) => default(Byte2);
public static Byte2 Zero(this Byte2 _) => Byte2.Zero;
public static Byte2 One(this Byte2 _) => Byte2.One;
public static Byte2 MinValue(this Byte2 _) => Byte2.MinValue;
public static Byte2 MaxValue(this Byte2 _) => Byte2.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Byte3
{
public Byte3(byte a, byte b, byte c, byte d) => (A, B, C, D) = (a, b, c, d);
public static Byte3 Create(byte a, byte b, byte c, byte d) => new Byte3(a, b, c, d);
public byte A { get; }
public byte B { get; }
public byte C { get; }
public byte D { get; }
public static implicit operator Byte3((byte A, byte B, byte C, byte D) tuple) => new Byte3(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (byte A, byte B, byte C, byte D)(Byte3 self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out byte a, out byte b, out byte c, out byte d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Byte3 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Byte3 Default = default;
public static Byte3 Zero = new Byte3(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Byte3 One = new Byte3(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Byte3 MinValue = new Byte3(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Byte3 MaxValue = new Byte3(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Byte3 a, Byte3 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Byte3 a, Byte3 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Byte3 WithA(byte value) => new Byte3(value, B, C, D);
public Byte3 WithB(byte value) => new Byte3(A, value, C, D);
public Byte3 WithC(byte value) => new Byte3(A, B, value, D);
public Byte3 WithD(byte value) => new Byte3(A, B, C, value);
}
public static partial class Intrinsics {
public static Byte3 Default(this Byte3 _) => default(Byte3);
public static Byte3 Zero(this Byte3 _) => Byte3.Zero;
public static Byte3 One(this Byte3 _) => Byte3.One;
public static Byte3 MinValue(this Byte3 _) => Byte3.MinValue;
public static Byte3 MaxValue(this Byte3 _) => Byte3.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Byte4
{
public Byte4(byte a, byte b, byte c, byte d) => (A, B, C, D) = (a, b, c, d);
public static Byte4 Create(byte a, byte b, byte c, byte d) => new Byte4(a, b, c, d);
public byte A { get; }
public byte B { get; }
public byte C { get; }
public byte D { get; }
public static implicit operator Byte4((byte A, byte B, byte C, byte D) tuple) => new Byte4(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (byte A, byte B, byte C, byte D)(Byte4 self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out byte a, out byte b, out byte c, out byte d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Byte4 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Byte4 Default = default;
public static Byte4 Zero = new Byte4(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Byte4 One = new Byte4(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Byte4 MinValue = new Byte4(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Byte4 MaxValue = new Byte4(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Byte4 a, Byte4 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Byte4 a, Byte4 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Byte4 WithA(byte value) => new Byte4(value, B, C, D);
public Byte4 WithB(byte value) => new Byte4(A, value, C, D);
public Byte4 WithC(byte value) => new Byte4(A, B, value, D);
public Byte4 WithD(byte value) => new Byte4(A, B, C, value);
}
public static partial class Intrinsics {
public static Byte4 Default(this Byte4 _) => default(Byte4);
public static Byte4 Zero(this Byte4 _) => Byte4.Zero;
public static Byte4 One(this Byte4 _) => Byte4.One;
public static Byte4 MinValue(this Byte4 _) => Byte4.MinValue;
public static Byte4 MaxValue(this Byte4 _) => Byte4.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Int2
: IArray<int>
{
public Int2(int a, int b) => (A, B) = (a, b);
public static Int2 Create(int a, int b) => new Int2(a, b);
public int A { get; }
public int B { get; }
public static implicit operator Int2((int A, int B) tuple) => new Int2(tuple.A, tuple.B);
public static implicit operator (int A, int B)(Int2 self) => (self.A, self.B);
public void Deconstruct(out int a, out int b) => (a, b) = (A, B);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Int2 typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Int2 Default = default;
public static Int2 Zero = new Int2(Default.A.Zero(),Default.B.Zero());
public static Int2 One = new Int2(Default.A.One(),Default.B.One());
public static Int2 MinValue = new Int2(Default.A.MinValue(),Default.B.MinValue());
public static Int2 MaxValue = new Int2(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Int2 a, Int2 b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Int2 a, Int2 b) => (a.A != b.A) || (a.B != b.B);
public Int2 WithA(int value) => new Int2(value, B);
public Int2 WithB(int value) => new Int2(A, value);
public static Int2 operator +(Int2 a, Int2 b) => new Int2(a.A + b.A, a.B + b.B);
public static Int2 operator +(int a, Int2 b) => new Int2(a + b.A, a + b.B);
public static Int2 operator +(Int2 a, int b) => new Int2(a.A + b, a.B + b);
public static Int2 operator -(Int2 a, Int2 b) => new Int2(a.A - b.A, a.B - b.B);
public static Int2 operator -(int a, Int2 b) => new Int2(a - b.A, a - b.B);
public static Int2 operator -(Int2 a, int b) => new Int2(a.A - b, a.B - b);
public static Int2 operator *(Int2 a, Int2 b) => new Int2(a.A * b.A, a.B * b.B);
public static Int2 operator *(Int2 a, int  b) => new Int2(a.A * b, a.B * b);
public static Int2 operator *(int  a, Int2 b) => new Int2(a * b.A, a * b.B);
public static Int2 operator /(Int2 a, Int2 b) => new Int2(a.A / b.A, a.B / b.B);
public static Int2 operator /(Int2 a, int  b) => new Int2(a.A / b, a.B / b);
public static Int2 operator /(int  a, Int2 b) => new Int2(a / b.A, a / b.B);
public static Int2 operator %(Int2 a, Int2 b) => new Int2(a.A % b.A, a.B % b.B);
public static Int2 operator %(Int2 a, int  b) => new Int2(a.A % b, a.B % b);
public static Int2 operator %(int  a, Int2 b) => new Int2(a % b.A, a % b.B);
public static Int2 operator -(Int2 a) => new Int2(- a.A, - a.B);
public static implicit operator int[](Int2 value) => new[] { value.A, value.B };
public double Dot(Int2 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<int> Iterator => new ArrayIterator<int>(this);
public int Count => 2;
public int this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Int2 Add(this Int2 a, Int2 b) => a + b;
public static IArray<Int2> Add(this IArray<Int2> self, IArray<Int2> other) => self.Zip(other, (a,b) => a + b);
public static Int2 Subtract(this Int2 a, Int2 b) => a - b;
public static IArray<Int2> Subtract(this IArray<Int2> self, IArray<Int2> other) => self.Zip(other, (a,b) => a - b);
public static Int2 Sum(this IArray<Int2> self) => self.Aggregate((a, b) => a + b);
public static Int2 Multiply(this Int2 a, Int2 b) => a * b;
public static IArray<Int2> Multiply(this IArray<Int2> self, IArray<Int2> other) => self.Zip(other, (a,b) => a * b);
public static Int2 Divide(this Int2 a, Int2 b) => a / b;
public static IArray<Int2> Divide(this IArray<Int2> self, IArray<Int2> other) => self.Zip(other, (a,b) => a / b);
public static Int2 Modulo(this Int2 a, Int2 b) => a % b;
public static IArray<Int2> Modulo(this IArray<Int2> self, IArray<Int2> other) => self.Zip(other, (a,b) => a % b);
public static Int2 Product(this IArray<Int2> self) => self.Aggregate((a, b) => a * b);
public static Int2 Negate(this Int2 a) => - a;
public static IArray<Int2> Negate(this IArray<Int2> self) => self.Select(a => - a);
public static bool Equals(this Int2 a, Int2 b) => a == b;
public static bool NotEquals(this Int2 a, Int2 b) => a != b;
public static Int2 Default(this Int2 _) => default(Int2);
public static Int2 Zero(this Int2 _) => Int2.Zero;
public static Int2 One(this Int2 _) => Int2.One;
public static Int2 MinValue(this Int2 _) => Int2.MinValue;
public static Int2 MaxValue(this Int2 _) => Int2.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Int3
: IArray<int>
{
public Int3(int a, int b, int c) => (A, B, C) = (a, b, c);
public static Int3 Create(int a, int b, int c) => new Int3(a, b, c);
public int A { get; }
public int B { get; }
public int C { get; }
public static implicit operator Int3((int A, int B, int C) tuple) => new Int3(tuple.A, tuple.B, tuple.C);
public static implicit operator (int A, int B, int C)(Int3 self) => (self.A, self.B, self.C);
public void Deconstruct(out int a, out int b, out int c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is Int3 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly Int3 Default = default;
public static Int3 Zero = new Int3(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static Int3 One = new Int3(Default.A.One(),Default.B.One(),Default.C.One());
public static Int3 MinValue = new Int3(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static Int3 MaxValue = new Int3(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(Int3 a, Int3 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(Int3 a, Int3 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public Int3 WithA(int value) => new Int3(value, B, C);
public Int3 WithB(int value) => new Int3(A, value, C);
public Int3 WithC(int value) => new Int3(A, B, value);
public static Int3 operator +(Int3 a, Int3 b) => new Int3(a.A + b.A, a.B + b.B, a.C + b.C);
public static Int3 operator +(int a, Int3 b) => new Int3(a + b.A, a + b.B, a + b.C);
public static Int3 operator +(Int3 a, int b) => new Int3(a.A + b, a.B + b, a.C + b);
public static Int3 operator -(Int3 a, Int3 b) => new Int3(a.A - b.A, a.B - b.B, a.C - b.C);
public static Int3 operator -(int a, Int3 b) => new Int3(a - b.A, a - b.B, a - b.C);
public static Int3 operator -(Int3 a, int b) => new Int3(a.A - b, a.B - b, a.C - b);
public static Int3 operator *(Int3 a, Int3 b) => new Int3(a.A * b.A, a.B * b.B, a.C * b.C);
public static Int3 operator *(Int3 a, int  b) => new Int3(a.A * b, a.B * b, a.C * b);
public static Int3 operator *(int  a, Int3 b) => new Int3(a * b.A, a * b.B, a * b.C);
public static Int3 operator /(Int3 a, Int3 b) => new Int3(a.A / b.A, a.B / b.B, a.C / b.C);
public static Int3 operator /(Int3 a, int  b) => new Int3(a.A / b, a.B / b, a.C / b);
public static Int3 operator /(int  a, Int3 b) => new Int3(a / b.A, a / b.B, a / b.C);
public static Int3 operator %(Int3 a, Int3 b) => new Int3(a.A % b.A, a.B % b.B, a.C % b.C);
public static Int3 operator %(Int3 a, int  b) => new Int3(a.A % b, a.B % b, a.C % b);
public static Int3 operator %(int  a, Int3 b) => new Int3(a % b.A, a % b.B, a % b.C);
public static Int3 operator -(Int3 a) => new Int3(- a.A, - a.B, - a.C);
public static implicit operator int[](Int3 value) => new[] { value.A, value.B, value.C };
public double Dot(Int3 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<int> Iterator => new ArrayIterator<int>(this);
public int Count => 3;
public int this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
case 2: return C;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Int3 Add(this Int3 a, Int3 b) => a + b;
public static IArray<Int3> Add(this IArray<Int3> self, IArray<Int3> other) => self.Zip(other, (a,b) => a + b);
public static Int3 Subtract(this Int3 a, Int3 b) => a - b;
public static IArray<Int3> Subtract(this IArray<Int3> self, IArray<Int3> other) => self.Zip(other, (a,b) => a - b);
public static Int3 Sum(this IArray<Int3> self) => self.Aggregate((a, b) => a + b);
public static Int3 Multiply(this Int3 a, Int3 b) => a * b;
public static IArray<Int3> Multiply(this IArray<Int3> self, IArray<Int3> other) => self.Zip(other, (a,b) => a * b);
public static Int3 Divide(this Int3 a, Int3 b) => a / b;
public static IArray<Int3> Divide(this IArray<Int3> self, IArray<Int3> other) => self.Zip(other, (a,b) => a / b);
public static Int3 Modulo(this Int3 a, Int3 b) => a % b;
public static IArray<Int3> Modulo(this IArray<Int3> self, IArray<Int3> other) => self.Zip(other, (a,b) => a % b);
public static Int3 Product(this IArray<Int3> self) => self.Aggregate((a, b) => a * b);
public static Int3 Negate(this Int3 a) => - a;
public static IArray<Int3> Negate(this IArray<Int3> self) => self.Select(a => - a);
public static bool Equals(this Int3 a, Int3 b) => a == b;
public static bool NotEquals(this Int3 a, Int3 b) => a != b;
public static Int3 Default(this Int3 _) => default(Int3);
public static Int3 Zero(this Int3 _) => Int3.Zero;
public static Int3 One(this Int3 _) => Int3.One;
public static Int3 MinValue(this Int3 _) => Int3.MinValue;
public static Int3 MaxValue(this Int3 _) => Int3.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Int4
: IArray<int>
{
public Int4(int a, int b, int c, int d) => (A, B, C, D) = (a, b, c, d);
public static Int4 Create(int a, int b, int c, int d) => new Int4(a, b, c, d);
public int A { get; }
public int B { get; }
public int C { get; }
public int D { get; }
public static implicit operator Int4((int A, int B, int C, int D) tuple) => new Int4(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (int A, int B, int C, int D)(Int4 self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out int a, out int b, out int c, out int d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Int4 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Int4 Default = default;
public static Int4 Zero = new Int4(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Int4 One = new Int4(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Int4 MinValue = new Int4(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Int4 MaxValue = new Int4(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Int4 a, Int4 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Int4 a, Int4 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Int4 WithA(int value) => new Int4(value, B, C, D);
public Int4 WithB(int value) => new Int4(A, value, C, D);
public Int4 WithC(int value) => new Int4(A, B, value, D);
public Int4 WithD(int value) => new Int4(A, B, C, value);
public static Int4 operator +(Int4 a, Int4 b) => new Int4(a.A + b.A, a.B + b.B, a.C + b.C, a.D + b.D);
public static Int4 operator +(int a, Int4 b) => new Int4(a + b.A, a + b.B, a + b.C, a + b.D);
public static Int4 operator +(Int4 a, int b) => new Int4(a.A + b, a.B + b, a.C + b, a.D + b);
public static Int4 operator -(Int4 a, Int4 b) => new Int4(a.A - b.A, a.B - b.B, a.C - b.C, a.D - b.D);
public static Int4 operator -(int a, Int4 b) => new Int4(a - b.A, a - b.B, a - b.C, a - b.D);
public static Int4 operator -(Int4 a, int b) => new Int4(a.A - b, a.B - b, a.C - b, a.D - b);
public static Int4 operator *(Int4 a, Int4 b) => new Int4(a.A * b.A, a.B * b.B, a.C * b.C, a.D * b.D);
public static Int4 operator *(Int4 a, int  b) => new Int4(a.A * b, a.B * b, a.C * b, a.D * b);
public static Int4 operator *(int  a, Int4 b) => new Int4(a * b.A, a * b.B, a * b.C, a * b.D);
public static Int4 operator /(Int4 a, Int4 b) => new Int4(a.A / b.A, a.B / b.B, a.C / b.C, a.D / b.D);
public static Int4 operator /(Int4 a, int  b) => new Int4(a.A / b, a.B / b, a.C / b, a.D / b);
public static Int4 operator /(int  a, Int4 b) => new Int4(a / b.A, a / b.B, a / b.C, a / b.D);
public static Int4 operator %(Int4 a, Int4 b) => new Int4(a.A % b.A, a.B % b.B, a.C % b.C, a.D % b.D);
public static Int4 operator %(Int4 a, int  b) => new Int4(a.A % b, a.B % b, a.C % b, a.D % b);
public static Int4 operator %(int  a, Int4 b) => new Int4(a % b.A, a % b.B, a % b.C, a % b.D);
public static Int4 operator -(Int4 a) => new Int4(- a.A, - a.B, - a.C, - a.D);
public static implicit operator int[](Int4 value) => new[] { value.A, value.B, value.C, value.D };
public double Dot(Int4 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<int> Iterator => new ArrayIterator<int>(this);
public int Count => 4;
public int this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
case 2: return C;
case 3: return D;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Int4 Add(this Int4 a, Int4 b) => a + b;
public static IArray<Int4> Add(this IArray<Int4> self, IArray<Int4> other) => self.Zip(other, (a,b) => a + b);
public static Int4 Subtract(this Int4 a, Int4 b) => a - b;
public static IArray<Int4> Subtract(this IArray<Int4> self, IArray<Int4> other) => self.Zip(other, (a,b) => a - b);
public static Int4 Sum(this IArray<Int4> self) => self.Aggregate((a, b) => a + b);
public static Int4 Multiply(this Int4 a, Int4 b) => a * b;
public static IArray<Int4> Multiply(this IArray<Int4> self, IArray<Int4> other) => self.Zip(other, (a,b) => a * b);
public static Int4 Divide(this Int4 a, Int4 b) => a / b;
public static IArray<Int4> Divide(this IArray<Int4> self, IArray<Int4> other) => self.Zip(other, (a,b) => a / b);
public static Int4 Modulo(this Int4 a, Int4 b) => a % b;
public static IArray<Int4> Modulo(this IArray<Int4> self, IArray<Int4> other) => self.Zip(other, (a,b) => a % b);
public static Int4 Product(this IArray<Int4> self) => self.Aggregate((a, b) => a * b);
public static Int4 Negate(this Int4 a) => - a;
public static IArray<Int4> Negate(this IArray<Int4> self) => self.Select(a => - a);
public static bool Equals(this Int4 a, Int4 b) => a == b;
public static bool NotEquals(this Int4 a, Int4 b) => a != b;
public static Int4 Default(this Int4 _) => default(Int4);
public static Int4 Zero(this Int4 _) => Int4.Zero;
public static Int4 One(this Int4 _) => Int4.One;
public static Int4 MinValue(this Int4 _) => Int4.MinValue;
public static Int4 MaxValue(this Int4 _) => Int4.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Long2
: IArray<long>
{
public Long2(long a, long b) => (A, B) = (a, b);
public static Long2 Create(long a, long b) => new Long2(a, b);
public long A { get; }
public long B { get; }
public static implicit operator Long2((long A, long B) tuple) => new Long2(tuple.A, tuple.B);
public static implicit operator (long A, long B)(Long2 self) => (self.A, self.B);
public void Deconstruct(out long a, out long b) => (a, b) = (A, B);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Long2 typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Long2 Default = default;
public static Long2 Zero = new Long2(Default.A.Zero(),Default.B.Zero());
public static Long2 One = new Long2(Default.A.One(),Default.B.One());
public static Long2 MinValue = new Long2(Default.A.MinValue(),Default.B.MinValue());
public static Long2 MaxValue = new Long2(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Long2 a, Long2 b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Long2 a, Long2 b) => (a.A != b.A) || (a.B != b.B);
public Long2 WithA(long value) => new Long2(value, B);
public Long2 WithB(long value) => new Long2(A, value);
public static Long2 operator +(Long2 a, Long2 b) => new Long2(a.A + b.A, a.B + b.B);
public static Long2 operator +(long a, Long2 b) => new Long2(a + b.A, a + b.B);
public static Long2 operator +(Long2 a, long b) => new Long2(a.A + b, a.B + b);
public static Long2 operator -(Long2 a, Long2 b) => new Long2(a.A - b.A, a.B - b.B);
public static Long2 operator -(long a, Long2 b) => new Long2(a - b.A, a - b.B);
public static Long2 operator -(Long2 a, long b) => new Long2(a.A - b, a.B - b);
public static Long2 operator *(Long2 a, Long2 b) => new Long2(a.A * b.A, a.B * b.B);
public static Long2 operator *(Long2 a, long  b) => new Long2(a.A * b, a.B * b);
public static Long2 operator *(long  a, Long2 b) => new Long2(a * b.A, a * b.B);
public static Long2 operator /(Long2 a, Long2 b) => new Long2(a.A / b.A, a.B / b.B);
public static Long2 operator /(Long2 a, long  b) => new Long2(a.A / b, a.B / b);
public static Long2 operator /(long  a, Long2 b) => new Long2(a / b.A, a / b.B);
public static Long2 operator %(Long2 a, Long2 b) => new Long2(a.A % b.A, a.B % b.B);
public static Long2 operator %(Long2 a, long  b) => new Long2(a.A % b, a.B % b);
public static Long2 operator %(long  a, Long2 b) => new Long2(a % b.A, a % b.B);
public static Long2 operator -(Long2 a) => new Long2(- a.A, - a.B);
public static implicit operator long[](Long2 value) => new[] { value.A, value.B };
public double Dot(Long2 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<long> Iterator => new ArrayIterator<long>(this);
public int Count => 2;
public long this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Long2 Add(this Long2 a, Long2 b) => a + b;
public static IArray<Long2> Add(this IArray<Long2> self, IArray<Long2> other) => self.Zip(other, (a,b) => a + b);
public static Long2 Subtract(this Long2 a, Long2 b) => a - b;
public static IArray<Long2> Subtract(this IArray<Long2> self, IArray<Long2> other) => self.Zip(other, (a,b) => a - b);
public static Long2 Sum(this IArray<Long2> self) => self.Aggregate((a, b) => a + b);
public static Long2 Multiply(this Long2 a, Long2 b) => a * b;
public static IArray<Long2> Multiply(this IArray<Long2> self, IArray<Long2> other) => self.Zip(other, (a,b) => a * b);
public static Long2 Divide(this Long2 a, Long2 b) => a / b;
public static IArray<Long2> Divide(this IArray<Long2> self, IArray<Long2> other) => self.Zip(other, (a,b) => a / b);
public static Long2 Modulo(this Long2 a, Long2 b) => a % b;
public static IArray<Long2> Modulo(this IArray<Long2> self, IArray<Long2> other) => self.Zip(other, (a,b) => a % b);
public static Long2 Product(this IArray<Long2> self) => self.Aggregate((a, b) => a * b);
public static Long2 Negate(this Long2 a) => - a;
public static IArray<Long2> Negate(this IArray<Long2> self) => self.Select(a => - a);
public static bool Equals(this Long2 a, Long2 b) => a == b;
public static bool NotEquals(this Long2 a, Long2 b) => a != b;
public static Long2 Default(this Long2 _) => default(Long2);
public static Long2 Zero(this Long2 _) => Long2.Zero;
public static Long2 One(this Long2 _) => Long2.One;
public static Long2 MinValue(this Long2 _) => Long2.MinValue;
public static Long2 MaxValue(this Long2 _) => Long2.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Long3
: IArray<long>
{
public Long3(long a, long b, long c) => (A, B, C) = (a, b, c);
public static Long3 Create(long a, long b, long c) => new Long3(a, b, c);
public long A { get; }
public long B { get; }
public long C { get; }
public static implicit operator Long3((long A, long B, long C) tuple) => new Long3(tuple.A, tuple.B, tuple.C);
public static implicit operator (long A, long B, long C)(Long3 self) => (self.A, self.B, self.C);
public void Deconstruct(out long a, out long b, out long c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is Long3 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly Long3 Default = default;
public static Long3 Zero = new Long3(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static Long3 One = new Long3(Default.A.One(),Default.B.One(),Default.C.One());
public static Long3 MinValue = new Long3(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static Long3 MaxValue = new Long3(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(Long3 a, Long3 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(Long3 a, Long3 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public Long3 WithA(long value) => new Long3(value, B, C);
public Long3 WithB(long value) => new Long3(A, value, C);
public Long3 WithC(long value) => new Long3(A, B, value);
public static Long3 operator +(Long3 a, Long3 b) => new Long3(a.A + b.A, a.B + b.B, a.C + b.C);
public static Long3 operator +(long a, Long3 b) => new Long3(a + b.A, a + b.B, a + b.C);
public static Long3 operator +(Long3 a, long b) => new Long3(a.A + b, a.B + b, a.C + b);
public static Long3 operator -(Long3 a, Long3 b) => new Long3(a.A - b.A, a.B - b.B, a.C - b.C);
public static Long3 operator -(long a, Long3 b) => new Long3(a - b.A, a - b.B, a - b.C);
public static Long3 operator -(Long3 a, long b) => new Long3(a.A - b, a.B - b, a.C - b);
public static Long3 operator *(Long3 a, Long3 b) => new Long3(a.A * b.A, a.B * b.B, a.C * b.C);
public static Long3 operator *(Long3 a, long  b) => new Long3(a.A * b, a.B * b, a.C * b);
public static Long3 operator *(long  a, Long3 b) => new Long3(a * b.A, a * b.B, a * b.C);
public static Long3 operator /(Long3 a, Long3 b) => new Long3(a.A / b.A, a.B / b.B, a.C / b.C);
public static Long3 operator /(Long3 a, long  b) => new Long3(a.A / b, a.B / b, a.C / b);
public static Long3 operator /(long  a, Long3 b) => new Long3(a / b.A, a / b.B, a / b.C);
public static Long3 operator %(Long3 a, Long3 b) => new Long3(a.A % b.A, a.B % b.B, a.C % b.C);
public static Long3 operator %(Long3 a, long  b) => new Long3(a.A % b, a.B % b, a.C % b);
public static Long3 operator %(long  a, Long3 b) => new Long3(a % b.A, a % b.B, a % b.C);
public static Long3 operator -(Long3 a) => new Long3(- a.A, - a.B, - a.C);
public static implicit operator long[](Long3 value) => new[] { value.A, value.B, value.C };
public double Dot(Long3 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<long> Iterator => new ArrayIterator<long>(this);
public int Count => 3;
public long this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
case 2: return C;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Long3 Add(this Long3 a, Long3 b) => a + b;
public static IArray<Long3> Add(this IArray<Long3> self, IArray<Long3> other) => self.Zip(other, (a,b) => a + b);
public static Long3 Subtract(this Long3 a, Long3 b) => a - b;
public static IArray<Long3> Subtract(this IArray<Long3> self, IArray<Long3> other) => self.Zip(other, (a,b) => a - b);
public static Long3 Sum(this IArray<Long3> self) => self.Aggregate((a, b) => a + b);
public static Long3 Multiply(this Long3 a, Long3 b) => a * b;
public static IArray<Long3> Multiply(this IArray<Long3> self, IArray<Long3> other) => self.Zip(other, (a,b) => a * b);
public static Long3 Divide(this Long3 a, Long3 b) => a / b;
public static IArray<Long3> Divide(this IArray<Long3> self, IArray<Long3> other) => self.Zip(other, (a,b) => a / b);
public static Long3 Modulo(this Long3 a, Long3 b) => a % b;
public static IArray<Long3> Modulo(this IArray<Long3> self, IArray<Long3> other) => self.Zip(other, (a,b) => a % b);
public static Long3 Product(this IArray<Long3> self) => self.Aggregate((a, b) => a * b);
public static Long3 Negate(this Long3 a) => - a;
public static IArray<Long3> Negate(this IArray<Long3> self) => self.Select(a => - a);
public static bool Equals(this Long3 a, Long3 b) => a == b;
public static bool NotEquals(this Long3 a, Long3 b) => a != b;
public static Long3 Default(this Long3 _) => default(Long3);
public static Long3 Zero(this Long3 _) => Long3.Zero;
public static Long3 One(this Long3 _) => Long3.One;
public static Long3 MinValue(this Long3 _) => Long3.MinValue;
public static Long3 MaxValue(this Long3 _) => Long3.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Long4
: IArray<long>
{
public Long4(long a, long b, long c, long d) => (A, B, C, D) = (a, b, c, d);
public static Long4 Create(long a, long b, long c, long d) => new Long4(a, b, c, d);
public long A { get; }
public long B { get; }
public long C { get; }
public long D { get; }
public static implicit operator Long4((long A, long B, long C, long D) tuple) => new Long4(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (long A, long B, long C, long D)(Long4 self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out long a, out long b, out long c, out long d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Long4 typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Long4 Default = default;
public static Long4 Zero = new Long4(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Long4 One = new Long4(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Long4 MinValue = new Long4(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Long4 MaxValue = new Long4(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Long4 a, Long4 b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Long4 a, Long4 b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Long4 WithA(long value) => new Long4(value, B, C, D);
public Long4 WithB(long value) => new Long4(A, value, C, D);
public Long4 WithC(long value) => new Long4(A, B, value, D);
public Long4 WithD(long value) => new Long4(A, B, C, value);
public static Long4 operator +(Long4 a, Long4 b) => new Long4(a.A + b.A, a.B + b.B, a.C + b.C, a.D + b.D);
public static Long4 operator +(long a, Long4 b) => new Long4(a + b.A, a + b.B, a + b.C, a + b.D);
public static Long4 operator +(Long4 a, long b) => new Long4(a.A + b, a.B + b, a.C + b, a.D + b);
public static Long4 operator -(Long4 a, Long4 b) => new Long4(a.A - b.A, a.B - b.B, a.C - b.C, a.D - b.D);
public static Long4 operator -(long a, Long4 b) => new Long4(a - b.A, a - b.B, a - b.C, a - b.D);
public static Long4 operator -(Long4 a, long b) => new Long4(a.A - b, a.B - b, a.C - b, a.D - b);
public static Long4 operator *(Long4 a, Long4 b) => new Long4(a.A * b.A, a.B * b.B, a.C * b.C, a.D * b.D);
public static Long4 operator *(Long4 a, long  b) => new Long4(a.A * b, a.B * b, a.C * b, a.D * b);
public static Long4 operator *(long  a, Long4 b) => new Long4(a * b.A, a * b.B, a * b.C, a * b.D);
public static Long4 operator /(Long4 a, Long4 b) => new Long4(a.A / b.A, a.B / b.B, a.C / b.C, a.D / b.D);
public static Long4 operator /(Long4 a, long  b) => new Long4(a.A / b, a.B / b, a.C / b, a.D / b);
public static Long4 operator /(long  a, Long4 b) => new Long4(a / b.A, a / b.B, a / b.C, a / b.D);
public static Long4 operator %(Long4 a, Long4 b) => new Long4(a.A % b.A, a.B % b.B, a.C % b.C, a.D % b.D);
public static Long4 operator %(Long4 a, long  b) => new Long4(a.A % b, a.B % b, a.C % b, a.D % b);
public static Long4 operator %(long  a, Long4 b) => new Long4(a % b.A, a % b.B, a % b.C, a % b.D);
public static Long4 operator -(Long4 a) => new Long4(- a.A, - a.B, - a.C, - a.D);
public static implicit operator long[](Long4 value) => new[] { value.A, value.B, value.C, value.D };
public double Dot(Long4 other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<long> Iterator => new ArrayIterator<long>(this);
public int Count => 4;
public long this[int index] { get { switch (index) {
case 0: return A;
case 1: return B;
case 2: return C;
case 3: return D;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Long4 Add(this Long4 a, Long4 b) => a + b;
public static IArray<Long4> Add(this IArray<Long4> self, IArray<Long4> other) => self.Zip(other, (a,b) => a + b);
public static Long4 Subtract(this Long4 a, Long4 b) => a - b;
public static IArray<Long4> Subtract(this IArray<Long4> self, IArray<Long4> other) => self.Zip(other, (a,b) => a - b);
public static Long4 Sum(this IArray<Long4> self) => self.Aggregate((a, b) => a + b);
public static Long4 Multiply(this Long4 a, Long4 b) => a * b;
public static IArray<Long4> Multiply(this IArray<Long4> self, IArray<Long4> other) => self.Zip(other, (a,b) => a * b);
public static Long4 Divide(this Long4 a, Long4 b) => a / b;
public static IArray<Long4> Divide(this IArray<Long4> self, IArray<Long4> other) => self.Zip(other, (a,b) => a / b);
public static Long4 Modulo(this Long4 a, Long4 b) => a % b;
public static IArray<Long4> Modulo(this IArray<Long4> self, IArray<Long4> other) => self.Zip(other, (a,b) => a % b);
public static Long4 Product(this IArray<Long4> self) => self.Aggregate((a, b) => a * b);
public static Long4 Negate(this Long4 a) => - a;
public static IArray<Long4> Negate(this IArray<Long4> self) => self.Select(a => - a);
public static bool Equals(this Long4 a, Long4 b) => a == b;
public static bool NotEquals(this Long4 a, Long4 b) => a != b;
public static Long4 Default(this Long4 _) => default(Long4);
public static Long4 Zero(this Long4 _) => Long4.Zero;
public static Long4 One(this Long4 _) => Long4.One;
public static Long4 MinValue(this Long4 _) => Long4.MinValue;
public static Long4 MaxValue(this Long4 _) => Long4.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Pose
{
public Pose(Double3 position, Rotation orientation) => (Position, Orientation) = (position, orientation);
public static Pose Create(Double3 position, Rotation orientation) => new Pose(position, orientation);
public Double3 Position { get; }
public Rotation Orientation { get; }
public static implicit operator Pose((Double3 Position, Rotation Orientation) tuple) => new Pose(tuple.Position, tuple.Orientation);
public static implicit operator (Double3 Position, Rotation Orientation)(Pose self) => (self.Position, self.Orientation);
public void Deconstruct(out Double3 position, out Rotation orientation) => (position, orientation) = (Position, Orientation);
public override string ToString() => $"{{ \"Position\" : { Position }, \"Orientation\" : { Orientation } }}";
public override bool Equals(object other) => other is Pose typedOther && this == typedOther;
public override int GetHashCode() => (Position, Orientation).GetHashCode();
public static readonly Pose Default = default;
public static Pose Zero = new Pose(Default.Position.Zero(),Default.Orientation.Zero());
public static Pose One = new Pose(Default.Position.One(),Default.Orientation.One());
public static Pose MinValue = new Pose(Default.Position.MinValue(),Default.Orientation.MinValue());
public static Pose MaxValue = new Pose(Default.Position.MaxValue(),Default.Orientation.MaxValue());
public static bool operator ==(Pose a, Pose b) => (a.Position == b.Position) && (a.Orientation == b.Orientation);
public static bool operator !=(Pose a, Pose b) => (a.Position != b.Position) || (a.Orientation != b.Orientation);
public Pose WithPosition(Double3 value) => new Pose(value, Orientation);
public Pose WithOrientation(Rotation value) => new Pose(Position, value);
}
public static partial class Intrinsics {
public static Pose Default(this Pose _) => default(Pose);
public static Pose Zero(this Pose _) => Pose.Zero;
public static Pose One(this Pose _) => Pose.One;
public static Pose MinValue(this Pose _) => Pose.MinValue;
public static Pose MaxValue(this Pose _) => Pose.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Transform
{
public Transform(Double3 translation, Rotation rotation, Double3 scale) => (Translation, Rotation, Scale) = (translation, rotation, scale);
public static Transform Create(Double3 translation, Rotation rotation, Double3 scale) => new Transform(translation, rotation, scale);
public Double3 Translation { get; }
public Rotation Rotation { get; }
public Double3 Scale { get; }
public static implicit operator Transform((Double3 Translation, Rotation Rotation, Double3 Scale) tuple) => new Transform(tuple.Translation, tuple.Rotation, tuple.Scale);
public static implicit operator (Double3 Translation, Rotation Rotation, Double3 Scale)(Transform self) => (self.Translation, self.Rotation, self.Scale);
public void Deconstruct(out Double3 translation, out Rotation rotation, out Double3 scale) => (translation, rotation, scale) = (Translation, Rotation, Scale);
public override string ToString() => $"{{ \"Translation\" : { Translation }, \"Rotation3D\" : { Rotation }, \"Scale\" : { Scale } }}";
public override bool Equals(object other) => other is Transform typedOther && this == typedOther;
public override int GetHashCode() => (Translation, Rotation, Scale).GetHashCode();
public static readonly Transform Default = default;
public static Transform Zero = new Transform(Default.Translation.Zero(),Default.Rotation.Zero(),Default.Scale.Zero());
public static Transform One = new Transform(Default.Translation.One(),Default.Rotation.One(),Default.Scale.One());
public static Transform MinValue = new Transform(Default.Translation.MinValue(),Default.Rotation.MinValue(),Default.Scale.MinValue());
public static Transform MaxValue = new Transform(Default.Translation.MaxValue(),Default.Rotation.MaxValue(),Default.Scale.MaxValue());
public static bool operator ==(Transform a, Transform b) => (a.Translation == b.Translation) && (a.Rotation == b.Rotation) && (a.Scale == b.Scale);
public static bool operator !=(Transform a, Transform b) => (a.Translation != b.Translation) || (a.Rotation != b.Rotation) || (a.Scale != b.Scale);
public Transform WithTranslation(Double3 value) => new Transform(value, Rotation, Scale);
public Transform WithRotation(Rotation value) => new Transform(Translation, value, Scale);
public Transform WithScale(Double3 value) => new Transform(Translation, Rotation, value);
}
public static partial class Intrinsics {
public static Transform Default(this Transform _) => default(Transform);
public static Transform Zero(this Transform _) => Transform.Zero;
public static Transform One(this Transform _) => Transform.One;
public static Transform MinValue(this Transform _) => Transform.MinValue;
public static Transform MaxValue(this Transform _) => Transform.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AABBox2D
{
public AABBox2D(Double2 a, Double2 b) => (A, B) = (a, b);
public static AABBox2D Create(Double2 a, Double2 b) => new AABBox2D(a, b);
public Double2 A { get; }
public Double2 B { get; }
public static implicit operator AABBox2D((Double2 A, Double2 B) tuple) => new AABBox2D(tuple.A, tuple.B);
public static implicit operator (Double2 A, Double2 B)(AABBox2D self) => (self.A, self.B);
public void Deconstruct(out Double2 a, out Double2 b) => (a, b) = (A, B);
public static implicit operator AABBox2D(Double2 value) => new AABBox2D(default, value);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is AABBox2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly AABBox2D Default = default;
public static AABBox2D Zero = new AABBox2D(Default.A.Zero(),Default.B.Zero());
public static AABBox2D One = new AABBox2D(Default.A.One(),Default.B.One());
public static AABBox2D MinValue = new AABBox2D(Default.A.MinValue(),Default.B.MinValue());
public static AABBox2D MaxValue = new AABBox2D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(AABBox2D a, AABBox2D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(AABBox2D a, AABBox2D b) => (a.A != b.A) || (a.B != b.B);
public AABBox2D WithA(Double2 value) => new AABBox2D(value, B);
public AABBox2D WithB(Double2 value) => new AABBox2D(A, value);
}
public static partial class Intrinsics {
public static AABBox2D Default(this AABBox2D _) => default(AABBox2D);
public static AABBox2D Zero(this AABBox2D _) => AABBox2D.Zero;
public static AABBox2D One(this AABBox2D _) => AABBox2D.One;
public static AABBox2D MinValue(this AABBox2D _) => AABBox2D.MinValue;
public static AABBox2D MaxValue(this AABBox2D _) => AABBox2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AABBox3D
{
public AABBox3D(Double3 a, Double3 b) => (A, B) = (a, b);
public static AABBox3D Create(Double3 a, Double3 b) => new AABBox3D(a, b);
public Double3 A { get; }
public Double3 B { get; }
public static implicit operator AABBox3D((Double3 A, Double3 B) tuple) => new AABBox3D(tuple.A, tuple.B);
public static implicit operator (Double3 A, Double3 B)(AABBox3D self) => (self.A, self.B);
public void Deconstruct(out Double3 a, out Double3 b) => (a, b) = (A, B);
public static implicit operator AABBox3D(Double3 value) => new AABBox3D(default, value);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is AABBox3D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly AABBox3D Default = default;
public static AABBox3D Zero = new AABBox3D(Default.A.Zero(),Default.B.Zero());
public static AABBox3D One = new AABBox3D(Default.A.One(),Default.B.One());
public static AABBox3D MinValue = new AABBox3D(Default.A.MinValue(),Default.B.MinValue());
public static AABBox3D MaxValue = new AABBox3D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(AABBox3D a, AABBox3D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(AABBox3D a, AABBox3D b) => (a.A != b.A) || (a.B != b.B);
public AABBox3D WithA(Double3 value) => new AABBox3D(value, B);
public AABBox3D WithB(Double3 value) => new AABBox3D(A, value);
}
public static partial class Intrinsics {
public static AABBox3D Default(this AABBox3D _) => default(AABBox3D);
public static AABBox3D Zero(this AABBox3D _) => AABBox3D.Zero;
public static AABBox3D One(this AABBox3D _) => AABBox3D.One;
public static AABBox3D MinValue(this AABBox3D _) => AABBox3D.MinValue;
public static AABBox3D MaxValue(this AABBox3D _) => AABBox3D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Complex
: IArray<double>
{
public Complex(double real, double imaginary) => (Real, Imaginary) = (real, imaginary);
public static Complex Create(double real, double imaginary) => new Complex(real, imaginary);
public double Real { get; }
public double Imaginary { get; }
public static implicit operator Complex((double Real, double Imaginary) tuple) => new Complex(tuple.Real, tuple.Imaginary);
public static implicit operator (double Real, double Imaginary)(Complex self) => (self.Real, self.Imaginary);
public void Deconstruct(out double real, out double imaginary) => (real, imaginary) = (Real, Imaginary);
public override string ToString() => $"{{ \"Real\" : { Real }, \"Imaginary\" : { Imaginary } }}";
public override bool Equals(object other) => other is Complex typedOther && this == typedOther;
public override int GetHashCode() => (Real, Imaginary).GetHashCode();
public static readonly Complex Default = default;
public static Complex Zero = new Complex(Default.Real.Zero(),Default.Imaginary.Zero());
public static Complex One = new Complex(Default.Real.One(),Default.Imaginary.One());
public static Complex MinValue = new Complex(Default.Real.MinValue(),Default.Imaginary.MinValue());
public static Complex MaxValue = new Complex(Default.Real.MaxValue(),Default.Imaginary.MaxValue());
public static bool operator ==(Complex a, Complex b) => (a.Real == b.Real) && (a.Imaginary == b.Imaginary);
public static bool operator !=(Complex a, Complex b) => (a.Real != b.Real) || (a.Imaginary != b.Imaginary);
public Complex WithReal(double value) => new Complex(value, Imaginary);
public Complex WithImaginary(double value) => new Complex(Real, value);
public static Complex operator +(Complex a, Complex b) => new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
public static Complex operator +(double a, Complex b) => new Complex(a + b.Real, a + b.Imaginary);
public static Complex operator +(Complex a, double b) => new Complex(a.Real + b, a.Imaginary + b);
public static Complex operator -(Complex a, Complex b) => new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
public static Complex operator -(double a, Complex b) => new Complex(a - b.Real, a - b.Imaginary);
public static Complex operator -(Complex a, double b) => new Complex(a.Real - b, a.Imaginary - b);
public static Complex operator *(Complex a, Complex b) => new Complex(a.Real * b.Real, a.Imaginary * b.Imaginary);
public static Complex operator *(Complex a, double  b) => new Complex(a.Real * b, a.Imaginary * b);
public static Complex operator *(double  a, Complex b) => new Complex(a * b.Real, a * b.Imaginary);
public static Complex operator /(Complex a, Complex b) => new Complex(a.Real / b.Real, a.Imaginary / b.Imaginary);
public static Complex operator /(Complex a, double  b) => new Complex(a.Real / b, a.Imaginary / b);
public static Complex operator /(double  a, Complex b) => new Complex(a / b.Real, a / b.Imaginary);
public static Complex operator %(Complex a, Complex b) => new Complex(a.Real % b.Real, a.Imaginary % b.Imaginary);
public static Complex operator %(Complex a, double  b) => new Complex(a.Real % b, a.Imaginary % b);
public static Complex operator %(double  a, Complex b) => new Complex(a % b.Real, a % b.Imaginary);
public static Complex operator -(Complex a) => new Complex(- a.Real, - a.Imaginary);
public static implicit operator double[](Complex value) => new[] { value.Real, value.Imaginary };
public double Dot(Complex other) => this.Multiply(other).Sum();
public double LengthSquared() => this.Dot(this);
public double Length() => System.Math.Sqrt(LengthSquared());
public IIterator<double> Iterator => new ArrayIterator<double>(this);
public int Count => 2;
public double this[int index] { get { switch (index) {
case 0: return Real;
case 1: return Imaginary;
default: throw new System.ArgumentOutOfRangeException(nameof(index));
} } }
}
public static partial class Intrinsics {
public static Complex Add(this Complex a, Complex b) => a + b;
public static IArray<Complex> Add(this IArray<Complex> self, IArray<Complex> other) => self.Zip(other, (a,b) => a + b);
public static Complex Subtract(this Complex a, Complex b) => a - b;
public static IArray<Complex> Subtract(this IArray<Complex> self, IArray<Complex> other) => self.Zip(other, (a,b) => a - b);
public static Complex Sum(this IArray<Complex> self) => self.Aggregate((a, b) => a + b);
public static Complex Multiply(this Complex a, Complex b) => a * b;
public static IArray<Complex> Multiply(this IArray<Complex> self, IArray<Complex> other) => self.Zip(other, (a,b) => a * b);
public static Complex Divide(this Complex a, Complex b) => a / b;
public static IArray<Complex> Divide(this IArray<Complex> self, IArray<Complex> other) => self.Zip(other, (a,b) => a / b);
public static Complex Modulo(this Complex a, Complex b) => a % b;
public static IArray<Complex> Modulo(this IArray<Complex> self, IArray<Complex> other) => self.Zip(other, (a,b) => a % b);
public static Complex Product(this IArray<Complex> self) => self.Aggregate((a, b) => a * b);
public static Complex Negate(this Complex a) => - a;
public static IArray<Complex> Negate(this IArray<Complex> self) => self.Select(a => - a);
public static bool Equals(this Complex a, Complex b) => a == b;
public static bool NotEquals(this Complex a, Complex b) => a != b;
public static Complex Default(this Complex _) => default(Complex);
public static Complex Zero(this Complex _) => Complex.Zero;
public static Complex One(this Complex _) => Complex.One;
public static Complex MinValue(this Complex _) => Complex.MinValue;
public static Complex MaxValue(this Complex _) => Complex.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Ray
{
public Ray(Double3 direction, Point3D position) => (Direction, Position) = (direction, position);
public static Ray Create(Double3 direction, Point3D position) => new Ray(direction, position);
public Double3 Direction { get; }
public Point3D Position { get; }
public static implicit operator Ray((Double3 Direction, Point3D Position) tuple) => new Ray(tuple.Direction, tuple.Position);
public static implicit operator (Double3 Direction, Point3D Position)(Ray self) => (self.Direction, self.Position);
public void Deconstruct(out Double3 direction, out Point3D position) => (direction, position) = (Direction, Position);
public override string ToString() => $"{{ \"Direction\" : { Direction }, \"Position\" : { Position } }}";
public override bool Equals(object other) => other is Ray typedOther && this == typedOther;
public override int GetHashCode() => (Direction, Position).GetHashCode();
public static readonly Ray Default = default;
public static Ray Zero = new Ray(Default.Direction.Zero(),Default.Position.Zero());
public static Ray One = new Ray(Default.Direction.One(),Default.Position.One());
public static Ray MinValue = new Ray(Default.Direction.MinValue(),Default.Position.MinValue());
public static Ray MaxValue = new Ray(Default.Direction.MaxValue(),Default.Position.MaxValue());
public static bool operator ==(Ray a, Ray b) => (a.Direction == b.Direction) && (a.Position == b.Position);
public static bool operator !=(Ray a, Ray b) => (a.Direction != b.Direction) || (a.Position != b.Position);
public Ray WithDirection(Double3 value) => new Ray(value, Position);
public Ray WithPosition(Point3D value) => new Ray(Direction, value);
}
public static partial class Intrinsics {
public static Ray Default(this Ray _) => default(Ray);
public static Ray Zero(this Ray _) => Ray.Zero;
public static Ray One(this Ray _) => Ray.One;
public static Ray MinValue(this Ray _) => Ray.MinValue;
public static Ray MaxValue(this Ray _) => Ray.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Ray2D
{
public Ray2D(Double2 direction, Point2D position) => (Direction, Position) = (direction, position);
public static Ray2D Create(Double2 direction, Point2D position) => new Ray2D(direction, position);
public Double2 Direction { get; }
public Point2D Position { get; }
public static implicit operator Ray2D((Double2 Direction, Point2D Position) tuple) => new Ray2D(tuple.Direction, tuple.Position);
public static implicit operator (Double2 Direction, Point2D Position)(Ray2D self) => (self.Direction, self.Position);
public void Deconstruct(out Double2 direction, out Point2D position) => (direction, position) = (Direction, Position);
public override string ToString() => $"{{ \"Direction\" : { Direction }, \"Position\" : { Position } }}";
public override bool Equals(object other) => other is Ray2D typedOther && this == typedOther;
public override int GetHashCode() => (Direction, Position).GetHashCode();
public static readonly Ray2D Default = default;
public static Ray2D Zero = new Ray2D(Default.Direction.Zero(),Default.Position.Zero());
public static Ray2D One = new Ray2D(Default.Direction.One(),Default.Position.One());
public static Ray2D MinValue = new Ray2D(Default.Direction.MinValue(),Default.Position.MinValue());
public static Ray2D MaxValue = new Ray2D(Default.Direction.MaxValue(),Default.Position.MaxValue());
public static bool operator ==(Ray2D a, Ray2D b) => (a.Direction == b.Direction) && (a.Position == b.Position);
public static bool operator !=(Ray2D a, Ray2D b) => (a.Direction != b.Direction) || (a.Position != b.Position);
public Ray2D WithDirection(Double2 value) => new Ray2D(value, Position);
public Ray2D WithPosition(Point2D value) => new Ray2D(Direction, value);
}
public static partial class Intrinsics {
public static Ray2D Default(this Ray2D _) => default(Ray2D);
public static Ray2D Zero(this Ray2D _) => Ray2D.Zero;
public static Ray2D One(this Ray2D _) => Ray2D.One;
public static Ray2D MinValue(this Ray2D _) => Ray2D.MinValue;
public static Ray2D MaxValue(this Ray2D _) => Ray2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Sphere
{
public Sphere(Point3D center, double radius) => (Center, Radius) = (center, radius);
public static Sphere Create(Point3D center, double radius) => new Sphere(center, radius);
public Point3D Center { get; }
public double Radius { get; }
public static implicit operator Sphere((Point3D Center, double Radius) tuple) => new Sphere(tuple.Center, tuple.Radius);
public static implicit operator (Point3D Center, double Radius)(Sphere self) => (self.Center, self.Radius);
public void Deconstruct(out Point3D center, out double radius) => (center, radius) = (Center, Radius);
public override string ToString() => $"{{ \"Center\" : { Center }, \"Radius\" : { Radius } }}";
public override bool Equals(object other) => other is Sphere typedOther && this == typedOther;
public override int GetHashCode() => (Center, Radius).GetHashCode();
public static readonly Sphere Default = default;
public static Sphere Zero = new Sphere(Default.Center.Zero(),Default.Radius.Zero());
public static Sphere One = new Sphere(Default.Center.One(),Default.Radius.One());
public static Sphere MinValue = new Sphere(Default.Center.MinValue(),Default.Radius.MinValue());
public static Sphere MaxValue = new Sphere(Default.Center.MaxValue(),Default.Radius.MaxValue());
public static bool operator ==(Sphere a, Sphere b) => (a.Center == b.Center) && (a.Radius == b.Radius);
public static bool operator !=(Sphere a, Sphere b) => (a.Center != b.Center) || (a.Radius != b.Radius);
public Sphere WithCenter(Point3D value) => new Sphere(value, Radius);
public Sphere WithRadius(double value) => new Sphere(Center, value);
}
public static partial class Intrinsics {
public static Sphere Default(this Sphere _) => default(Sphere);
public static Sphere Zero(this Sphere _) => Sphere.Zero;
public static Sphere One(this Sphere _) => Sphere.One;
public static Sphere MinValue(this Sphere _) => Sphere.MinValue;
public static Sphere MaxValue(this Sphere _) => Sphere.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Plane
{
public Plane(Double3 normal, double d) => (Normal, D) = (normal, d);
public static Plane Create(Double3 normal, double d) => new Plane(normal, d);
public Double3 Normal { get; }
public double D { get; }
public static implicit operator Plane((Double3 Normal, double D) tuple) => new Plane(tuple.Normal, tuple.D);
public static implicit operator (Double3 Normal, double D)(Plane self) => (self.Normal, self.D);
public void Deconstruct(out Double3 normal, out double d) => (normal, d) = (Normal, D);
public override string ToString() => $"{{ \"Normal\" : { Normal }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Plane typedOther && this == typedOther;
public override int GetHashCode() => (Normal, D).GetHashCode();
public static readonly Plane Default = default;
public static Plane Zero = new Plane(Default.Normal.Zero(),Default.D.Zero());
public static Plane One = new Plane(Default.Normal.One(),Default.D.One());
public static Plane MinValue = new Plane(Default.Normal.MinValue(),Default.D.MinValue());
public static Plane MaxValue = new Plane(Default.Normal.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Plane a, Plane b) => (a.Normal == b.Normal) && (a.D == b.D);
public static bool operator !=(Plane a, Plane b) => (a.Normal != b.Normal) || (a.D != b.D);
public Plane WithNormal(Double3 value) => new Plane(value, D);
public Plane WithD(double value) => new Plane(Normal, value);
}
public static partial class Intrinsics {
public static Plane Default(this Plane _) => default(Plane);
public static Plane Zero(this Plane _) => Plane.Zero;
public static Plane One(this Plane _) => Plane.One;
public static Plane MinValue(this Plane _) => Plane.MinValue;
public static Plane MaxValue(this Plane _) => Plane.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Triangle
{
public Triangle(Double3 a, Double3 b, Double3 c) => (A, B, C) = (a, b, c);
public static Triangle Create(Double3 a, Double3 b, Double3 c) => new Triangle(a, b, c);
public Double3 A { get; }
public Double3 B { get; }
public Double3 C { get; }
public static implicit operator Triangle((Double3 A, Double3 B, Double3 C) tuple) => new Triangle(tuple.A, tuple.B, tuple.C);
public static implicit operator (Double3 A, Double3 B, Double3 C)(Triangle self) => (self.A, self.B, self.C);
public void Deconstruct(out Double3 a, out Double3 b, out Double3 c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is Triangle typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly Triangle Default = default;
public static Triangle Zero = new Triangle(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static Triangle One = new Triangle(Default.A.One(),Default.B.One(),Default.C.One());
public static Triangle MinValue = new Triangle(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static Triangle MaxValue = new Triangle(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(Triangle a, Triangle b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(Triangle a, Triangle b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public Triangle WithA(Double3 value) => new Triangle(value, B, C);
public Triangle WithB(Double3 value) => new Triangle(A, value, C);
public Triangle WithC(Double3 value) => new Triangle(A, B, value);
}
public static partial class Intrinsics {
public static Triangle Default(this Triangle _) => default(Triangle);
public static Triangle Zero(this Triangle _) => Triangle.Zero;
public static Triangle One(this Triangle _) => Triangle.One;
public static Triangle MinValue(this Triangle _) => Triangle.MinValue;
public static Triangle MaxValue(this Triangle _) => Triangle.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Triangle2D
{
public Triangle2D(Double2 a, Double2 b, Double2 c) => (A, B, C) = (a, b, c);
public static Triangle2D Create(Double2 a, Double2 b, Double2 c) => new Triangle2D(a, b, c);
public Double2 A { get; }
public Double2 B { get; }
public Double2 C { get; }
public static implicit operator Triangle2D((Double2 A, Double2 B, Double2 C) tuple) => new Triangle2D(tuple.A, tuple.B, tuple.C);
public static implicit operator (Double2 A, Double2 B, Double2 C)(Triangle2D self) => (self.A, self.B, self.C);
public void Deconstruct(out Double2 a, out Double2 b, out Double2 c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is Triangle2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly Triangle2D Default = default;
public static Triangle2D Zero = new Triangle2D(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static Triangle2D One = new Triangle2D(Default.A.One(),Default.B.One(),Default.C.One());
public static Triangle2D MinValue = new Triangle2D(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static Triangle2D MaxValue = new Triangle2D(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(Triangle2D a, Triangle2D b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(Triangle2D a, Triangle2D b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public Triangle2D WithA(Double2 value) => new Triangle2D(value, B, C);
public Triangle2D WithB(Double2 value) => new Triangle2D(A, value, C);
public Triangle2D WithC(Double2 value) => new Triangle2D(A, B, value);
}
public static partial class Intrinsics {
public static Triangle2D Default(this Triangle2D _) => default(Triangle2D);
public static Triangle2D Zero(this Triangle2D _) => Triangle2D.Zero;
public static Triangle2D One(this Triangle2D _) => Triangle2D.One;
public static Triangle2D MinValue(this Triangle2D _) => Triangle2D.MinValue;
public static Triangle2D MaxValue(this Triangle2D _) => Triangle2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Quad
{
public Quad(Double3 a, Double3 b, Double3 c, Double3 d) => (A, B, C, D) = (a, b, c, d);
public static Quad Create(Double3 a, Double3 b, Double3 c, Double3 d) => new Quad(a, b, c, d);
public Double3 A { get; }
public Double3 B { get; }
public Double3 C { get; }
public Double3 D { get; }
public static implicit operator Quad((Double3 A, Double3 B, Double3 C, Double3 D) tuple) => new Quad(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (Double3 A, Double3 B, Double3 C, Double3 D)(Quad self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out Double3 a, out Double3 b, out Double3 c, out Double3 d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is Quad typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly Quad Default = default;
public static Quad Zero = new Quad(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static Quad One = new Quad(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static Quad MinValue = new Quad(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static Quad MaxValue = new Quad(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(Quad a, Quad b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(Quad a, Quad b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public Quad WithA(Double3 value) => new Quad(value, B, C, D);
public Quad WithB(Double3 value) => new Quad(A, value, C, D);
public Quad WithC(Double3 value) => new Quad(A, B, value, D);
public Quad WithD(Double3 value) => new Quad(A, B, C, value);
}
public static partial class Intrinsics {
public static Quad Default(this Quad _) => default(Quad);
public static Quad Zero(this Quad _) => Quad.Zero;
public static Quad One(this Quad _) => Quad.One;
public static Quad MinValue(this Quad _) => Quad.MinValue;
public static Quad MaxValue(this Quad _) => Quad.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Point3D
{
public Point3D(Double3 value) => (Value) = (value);
public static Point3D Create(Double3 value) => new Point3D(value);
public Double3 Value { get; }
public static implicit operator Point3D(Double3 value) => new Point3D(value);
public static implicit operator Double3(Point3D value) => value.Value;
public override string ToString() => $"{{ \"Value\" : { Value } }}";
public override bool Equals(object other) => other is Point3D typedOther && this == typedOther;
public override int GetHashCode() => (Value).GetHashCode();
public static readonly Point3D Default = default;
public static Point3D Zero = new Point3D(Default.Value.Zero());
public static Point3D One = new Point3D(Default.Value.One());
public static Point3D MinValue = new Point3D(Default.Value.MinValue());
public static Point3D MaxValue = new Point3D(Default.Value.MaxValue());
public static bool operator ==(Point3D a, Point3D b) => (a.Value == b.Value);
public static bool operator !=(Point3D a, Point3D b) => (a.Value != b.Value);
public Point3D WithValue(Double3 value) => new Point3D(value);
}
public static partial class Intrinsics {
public static Point3D Default(this Point3D _) => default(Point3D);
public static Point3D Zero(this Point3D _) => Point3D.Zero;
public static Point3D One(this Point3D _) => Point3D.One;
public static Double3 ToDouble3(this Point3D self) => self;
public static Point3D MinValue(this Point3D _) => Point3D.MinValue;
public static Point3D MaxValue(this Point3D _) => Point3D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Point2D
{
public Point2D(Double2 value) => (Value) = (value);
public static Point2D Create(Double2 value) => new Point2D(value);
public Double2 Value { get; }
public static implicit operator Point2D(Double2 value) => new Point2D(value);
public static implicit operator Double2(Point2D value) => value.Value;
public override string ToString() => $"{{ \"Value\" : { Value } }}";
public override bool Equals(object other) => other is Point2D typedOther && this == typedOther;
public override int GetHashCode() => (Value).GetHashCode();
public static readonly Point2D Default = default;
public static Point2D Zero = new Point2D(Default.Value.Zero());
public static Point2D One = new Point2D(Default.Value.One());
public static Point2D MinValue = new Point2D(Default.Value.MinValue());
public static Point2D MaxValue = new Point2D(Default.Value.MaxValue());
public static bool operator ==(Point2D a, Point2D b) => (a.Value == b.Value);
public static bool operator !=(Point2D a, Point2D b) => (a.Value != b.Value);
public Point2D WithValue(Double2 value) => new Point2D(value);
}
public static partial class Intrinsics {
public static Point2D Default(this Point2D _) => default(Point2D);
public static Point2D Zero(this Point2D _) => Point2D.Zero;
public static Point2D One(this Point2D _) => Point2D.One;
public static Double2 ToDouble2(this Point2D self) => self;
public static Point2D MinValue(this Point2D _) => Point2D.MinValue;
public static Point2D MaxValue(this Point2D _) => Point2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Line3D
{
public Line3D(Point3D a, Point3D b) => (A, B) = (a, b);
public static Line3D Create(Point3D a, Point3D b) => new Line3D(a, b);
public Point3D A { get; }
public Point3D B { get; }
public static implicit operator Line3D((Point3D A, Point3D B) tuple) => new Line3D(tuple.A, tuple.B);
public static implicit operator (Point3D A, Point3D B)(Line3D self) => (self.A, self.B);
public void Deconstruct(out Point3D a, out Point3D b) => (a, b) = (A, B);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Line3D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Line3D Default = default;
public static Line3D Zero = new Line3D(Default.A.Zero(),Default.B.Zero());
public static Line3D One = new Line3D(Default.A.One(),Default.B.One());
public static Line3D MinValue = new Line3D(Default.A.MinValue(),Default.B.MinValue());
public static Line3D MaxValue = new Line3D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Line3D a, Line3D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Line3D a, Line3D b) => (a.A != b.A) || (a.B != b.B);
public Line3D WithA(Point3D value) => new Line3D(value, B);
public Line3D WithB(Point3D value) => new Line3D(A, value);
}
public static partial class Intrinsics {
public static Line3D Default(this Line3D _) => default(Line3D);
public static Line3D Zero(this Line3D _) => Line3D.Zero;
public static Line3D One(this Line3D _) => Line3D.One;
public static Line3D MinValue(this Line3D _) => Line3D.MinValue;
public static Line3D MaxValue(this Line3D _) => Line3D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Line2D
{
public Line2D(Point2D a, Point2D b) => (A, B) = (a, b);
public static Line2D Create(Point2D a, Point2D b) => new Line2D(a, b);
public Point2D A { get; }
public Point2D B { get; }
public static implicit operator Line2D((Point2D A, Point2D B) tuple) => new Line2D(tuple.A, tuple.B);
public static implicit operator (Point2D A, Point2D B)(Line2D self) => (self.A, self.B);
public void Deconstruct(out Point2D a, out Point2D b) => (a, b) = (A, B);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Line2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Line2D Default = default;
public static Line2D Zero = new Line2D(Default.A.Zero(),Default.B.Zero());
public static Line2D One = new Line2D(Default.A.One(),Default.B.One());
public static Line2D MinValue = new Line2D(Default.A.MinValue(),Default.B.MinValue());
public static Line2D MaxValue = new Line2D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Line2D a, Line2D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Line2D a, Line2D b) => (a.A != b.A) || (a.B != b.B);
public Line2D WithA(Point2D value) => new Line2D(value, B);
public Line2D WithB(Point2D value) => new Line2D(A, value);
}
public static partial class Intrinsics {
public static Line2D Default(this Line2D _) => default(Line2D);
public static Line2D Zero(this Line2D _) => Line2D.Zero;
public static Line2D One(this Line2D _) => Line2D.One;
public static Line2D MinValue(this Line2D _) => Line2D.MinValue;
public static Line2D MaxValue(this Line2D _) => Line2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Color
{
public Color(double r, double g, double b, double a) => (R, G, B, A) = (r, g, b, a);
public static Color Create(double r, double g, double b, double a) => new Color(r, g, b, a);
public double R { get; }
public double G { get; }
public double B { get; }
public double A { get; }
public static implicit operator Color((double R, double G, double B, double A) tuple) => new Color(tuple.R, tuple.G, tuple.B, tuple.A);
public static implicit operator (double R, double G, double B, double A)(Color self) => (self.R, self.G, self.B, self.A);
public void Deconstruct(out double r, out double g, out double b, out double a) => (r, g, b, a) = (R, G, B, A);
public override string ToString() => $"{{ \"R\" : { R }, \"G\" : { G }, \"B\" : { B }, \"A\" : { A } }}";
public override bool Equals(object other) => other is Color typedOther && this == typedOther;
public override int GetHashCode() => (R, G, B, A).GetHashCode();
public static readonly Color Default = default;
public static Color Zero = new Color(Default.R.Zero(),Default.G.Zero(),Default.B.Zero(),Default.A.Zero());
public static Color One = new Color(Default.R.One(),Default.G.One(),Default.B.One(),Default.A.One());
public static Color MinValue = new Color(Default.R.MinValue(),Default.G.MinValue(),Default.B.MinValue(),Default.A.MinValue());
public static Color MaxValue = new Color(Default.R.MaxValue(),Default.G.MaxValue(),Default.B.MaxValue(),Default.A.MaxValue());
public static bool operator ==(Color a, Color b) => (a.R == b.R) && (a.G == b.G) && (a.B == b.B) && (a.A == b.A);
public static bool operator !=(Color a, Color b) => (a.R != b.R) || (a.G != b.G) || (a.B != b.B) || (a.A != b.A);
public Color WithR(double value) => new Color(value, G, B, A);
public Color WithG(double value) => new Color(R, value, B, A);
public Color WithB(double value) => new Color(R, G, value, A);
public Color WithA(double value) => new Color(R, G, B, value);
}
public static partial class Intrinsics {
public static Color Default(this Color _) => default(Color);
public static Color Zero(this Color _) => Color.Zero;
public static Color One(this Color _) => Color.One;
public static Color MinValue(this Color _) => Color.MinValue;
public static Color MaxValue(this Color _) => Color.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ColorHSV
{
public ColorHSV(double h, double s, double v) => (H, S, V) = (h, s, v);
public static ColorHSV Create(double h, double s, double v) => new ColorHSV(h, s, v);
public double H { get; }
public double S { get; }
public double V { get; }
public static implicit operator ColorHSV((double H, double S, double V) tuple) => new ColorHSV(tuple.H, tuple.S, tuple.V);
public static implicit operator (double H, double S, double V)(ColorHSV self) => (self.H, self.S, self.V);
public void Deconstruct(out double h, out double s, out double v) => (h, s, v) = (H, S, V);
public override string ToString() => $"{{ \"H\" : { H }, \"S\" : { S }, \"V\" : { V } }}";
public override bool Equals(object other) => other is ColorHSV typedOther && this == typedOther;
public override int GetHashCode() => (H, S, V).GetHashCode();
public static readonly ColorHSV Default = default;
public static ColorHSV Zero = new ColorHSV(Default.H.Zero(),Default.S.Zero(),Default.V.Zero());
public static ColorHSV One = new ColorHSV(Default.H.One(),Default.S.One(),Default.V.One());
public static ColorHSV MinValue = new ColorHSV(Default.H.MinValue(),Default.S.MinValue(),Default.V.MinValue());
public static ColorHSV MaxValue = new ColorHSV(Default.H.MaxValue(),Default.S.MaxValue(),Default.V.MaxValue());
public static bool operator ==(ColorHSV a, ColorHSV b) => (a.H == b.H) && (a.S == b.S) && (a.V == b.V);
public static bool operator !=(ColorHSV a, ColorHSV b) => (a.H != b.H) || (a.S != b.S) || (a.V != b.V);
public ColorHSV WithH(double value) => new ColorHSV(value, S, V);
public ColorHSV WithS(double value) => new ColorHSV(H, value, V);
public ColorHSV WithV(double value) => new ColorHSV(H, S, value);
}
public static partial class Intrinsics {
public static ColorHSV Default(this ColorHSV _) => default(ColorHSV);
public static ColorHSV Zero(this ColorHSV _) => ColorHSV.Zero;
public static ColorHSV One(this ColorHSV _) => ColorHSV.One;
public static ColorHSV MinValue(this ColorHSV _) => ColorHSV.MinValue;
public static ColorHSV MaxValue(this ColorHSV _) => ColorHSV.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ColorHSL
{
public ColorHSL(double hue, double saturation, double luminance) => (Hue, Saturation, Luminance) = (hue, saturation, luminance);
public static ColorHSL Create(double hue, double saturation, double luminance) => new ColorHSL(hue, saturation, luminance);
public double Hue { get; }
public double Saturation { get; }
public double Luminance { get; }
public static implicit operator ColorHSL((double Hue, double Saturation, double Luminance) tuple) => new ColorHSL(tuple.Hue, tuple.Saturation, tuple.Luminance);
public static implicit operator (double Hue, double Saturation, double Luminance)(ColorHSL self) => (self.Hue, self.Saturation, self.Luminance);
public void Deconstruct(out double hue, out double saturation, out double luminance) => (hue, saturation, luminance) = (Hue, Saturation, Luminance);
public override string ToString() => $"{{ \"Hue\" : { Hue }, \"Saturation\" : { Saturation }, \"Luminance\" : { Luminance } }}";
public override bool Equals(object other) => other is ColorHSL typedOther && this == typedOther;
public override int GetHashCode() => (Hue, Saturation, Luminance).GetHashCode();
public static readonly ColorHSL Default = default;
public static ColorHSL Zero = new ColorHSL(Default.Hue.Zero(),Default.Saturation.Zero(),Default.Luminance.Zero());
public static ColorHSL One = new ColorHSL(Default.Hue.One(),Default.Saturation.One(),Default.Luminance.One());
public static ColorHSL MinValue = new ColorHSL(Default.Hue.MinValue(),Default.Saturation.MinValue(),Default.Luminance.MinValue());
public static ColorHSL MaxValue = new ColorHSL(Default.Hue.MaxValue(),Default.Saturation.MaxValue(),Default.Luminance.MaxValue());
public static bool operator ==(ColorHSL a, ColorHSL b) => (a.Hue == b.Hue) && (a.Saturation == b.Saturation) && (a.Luminance == b.Luminance);
public static bool operator !=(ColorHSL a, ColorHSL b) => (a.Hue != b.Hue) || (a.Saturation != b.Saturation) || (a.Luminance != b.Luminance);
public ColorHSL WithHue(double value) => new ColorHSL(value, Saturation, Luminance);
public ColorHSL WithSaturation(double value) => new ColorHSL(Hue, value, Luminance);
public ColorHSL WithLuminance(double value) => new ColorHSL(Hue, Saturation, value);
}
public static partial class Intrinsics {
public static ColorHSL Default(this ColorHSL _) => default(ColorHSL);
public static ColorHSL Zero(this ColorHSL _) => ColorHSL.Zero;
public static ColorHSL One(this ColorHSL _) => ColorHSL.One;
public static ColorHSL MinValue(this ColorHSL _) => ColorHSL.MinValue;
public static ColorHSL MaxValue(this ColorHSL _) => ColorHSL.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ColorYCbCr
{
public ColorYCbCr(double y, double cb, double cr) => (Y, Cb, Cr) = (y, cb, cr);
public static ColorYCbCr Create(double y, double cb, double cr) => new ColorYCbCr(y, cb, cr);
public double Y { get; }
public double Cb { get; }
public double Cr { get; }
public static implicit operator ColorYCbCr((double Y, double Cb, double Cr) tuple) => new ColorYCbCr(tuple.Y, tuple.Cb, tuple.Cr);
public static implicit operator (double Y, double Cb, double Cr)(ColorYCbCr self) => (self.Y, self.Cb, self.Cr);
public void Deconstruct(out double y, out double cb, out double cr) => (y, cb, cr) = (Y, Cb, Cr);
public override string ToString() => $"{{ \"Y\" : { Y }, \"Cb\" : { Cb }, \"Cr\" : { Cr } }}";
public override bool Equals(object other) => other is ColorYCbCr typedOther && this == typedOther;
public override int GetHashCode() => (Y, Cb, Cr).GetHashCode();
public static readonly ColorYCbCr Default = default;
public static ColorYCbCr Zero = new ColorYCbCr(Default.Y.Zero(),Default.Cb.Zero(),Default.Cr.Zero());
public static ColorYCbCr One = new ColorYCbCr(Default.Y.One(),Default.Cb.One(),Default.Cr.One());
public static ColorYCbCr MinValue = new ColorYCbCr(Default.Y.MinValue(),Default.Cb.MinValue(),Default.Cr.MinValue());
public static ColorYCbCr MaxValue = new ColorYCbCr(Default.Y.MaxValue(),Default.Cb.MaxValue(),Default.Cr.MaxValue());
public static bool operator ==(ColorYCbCr a, ColorYCbCr b) => (a.Y == b.Y) && (a.Cb == b.Cb) && (a.Cr == b.Cr);
public static bool operator !=(ColorYCbCr a, ColorYCbCr b) => (a.Y != b.Y) || (a.Cb != b.Cb) || (a.Cr != b.Cr);
public ColorYCbCr WithY(double value) => new ColorYCbCr(value, Cb, Cr);
public ColorYCbCr WithCb(double value) => new ColorYCbCr(Y, value, Cr);
public ColorYCbCr WithCr(double value) => new ColorYCbCr(Y, Cb, value);
}
public static partial class Intrinsics {
public static ColorYCbCr Default(this ColorYCbCr _) => default(ColorYCbCr);
public static ColorYCbCr Zero(this ColorYCbCr _) => ColorYCbCr.Zero;
public static ColorYCbCr One(this ColorYCbCr _) => ColorYCbCr.One;
public static ColorYCbCr MinValue(this ColorYCbCr _) => ColorYCbCr.MinValue;
public static ColorYCbCr MaxValue(this ColorYCbCr _) => ColorYCbCr.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SphericalCoordinate
{
public SphericalCoordinate(double radius, Angle azimuth, Angle inclination) => (Radius, Azimuth, Inclination) = (radius, azimuth, inclination);
public static SphericalCoordinate Create(double radius, Angle azimuth, Angle inclination) => new SphericalCoordinate(radius, azimuth, inclination);
public double Radius { get; }
public Angle Azimuth { get; }
public Angle Inclination { get; }
public static implicit operator SphericalCoordinate((double Radius, Angle Azimuth, Angle Inclination) tuple) => new SphericalCoordinate(tuple.Radius, tuple.Azimuth, tuple.Inclination);
public static implicit operator (double Radius, Angle Azimuth, Angle Inclination)(SphericalCoordinate self) => (self.Radius, self.Azimuth, self.Inclination);
public void Deconstruct(out double radius, out Angle azimuth, out Angle inclination) => (radius, azimuth, inclination) = (Radius, Azimuth, Inclination);
public override string ToString() => $"{{ \"Radius\" : { Radius }, \"Azimuth\" : { Azimuth }, \"Inclination\" : { Inclination } }}";
public override bool Equals(object other) => other is SphericalCoordinate typedOther && this == typedOther;
public override int GetHashCode() => (Radius, Azimuth, Inclination).GetHashCode();
public static readonly SphericalCoordinate Default = default;
public static SphericalCoordinate Zero = new SphericalCoordinate(Default.Radius.Zero(),Default.Azimuth.Zero(),Default.Inclination.Zero());
public static SphericalCoordinate One = new SphericalCoordinate(Default.Radius.One(),Default.Azimuth.One(),Default.Inclination.One());
public static SphericalCoordinate MinValue = new SphericalCoordinate(Default.Radius.MinValue(),Default.Azimuth.MinValue(),Default.Inclination.MinValue());
public static SphericalCoordinate MaxValue = new SphericalCoordinate(Default.Radius.MaxValue(),Default.Azimuth.MaxValue(),Default.Inclination.MaxValue());
public static bool operator ==(SphericalCoordinate a, SphericalCoordinate b) => (a.Radius == b.Radius) && (a.Azimuth == b.Azimuth) && (a.Inclination == b.Inclination);
public static bool operator !=(SphericalCoordinate a, SphericalCoordinate b) => (a.Radius != b.Radius) || (a.Azimuth != b.Azimuth) || (a.Inclination != b.Inclination);
public SphericalCoordinate WithRadius(double value) => new SphericalCoordinate(value, Azimuth, Inclination);
public SphericalCoordinate WithAzimuth(Angle value) => new SphericalCoordinate(Radius, value, Inclination);
public SphericalCoordinate WithInclination(Angle value) => new SphericalCoordinate(Radius, Azimuth, value);
}
public static partial class Intrinsics {
public static SphericalCoordinate Default(this SphericalCoordinate _) => default(SphericalCoordinate);
public static SphericalCoordinate Zero(this SphericalCoordinate _) => SphericalCoordinate.Zero;
public static SphericalCoordinate One(this SphericalCoordinate _) => SphericalCoordinate.One;
public static SphericalCoordinate MinValue(this SphericalCoordinate _) => SphericalCoordinate.MinValue;
public static SphericalCoordinate MaxValue(this SphericalCoordinate _) => SphericalCoordinate.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PolarCoordinate
{
public PolarCoordinate(double radius, Angle angle) => (Radius, Angle) = (radius, angle);
public static PolarCoordinate Create(double radius, Angle angle) => new PolarCoordinate(radius, angle);
public double Radius { get; }
public Angle Angle { get; }
public static implicit operator PolarCoordinate((double Radius, Angle Angle) tuple) => new PolarCoordinate(tuple.Radius, tuple.Angle);
public static implicit operator (double Radius, Angle Angle)(PolarCoordinate self) => (self.Radius, self.Angle);
public void Deconstruct(out double radius, out Angle angle) => (radius, angle) = (Radius, Angle);
public override string ToString() => $"{{ \"Radius\" : { Radius }, \"Angle\" : { Angle } }}";
public override bool Equals(object other) => other is PolarCoordinate typedOther && this == typedOther;
public override int GetHashCode() => (Radius, Angle).GetHashCode();
public static readonly PolarCoordinate Default = default;
public static PolarCoordinate Zero = new PolarCoordinate(Default.Radius.Zero(),Default.Angle.Zero());
public static PolarCoordinate One = new PolarCoordinate(Default.Radius.One(),Default.Angle.One());
public static PolarCoordinate MinValue = new PolarCoordinate(Default.Radius.MinValue(),Default.Angle.MinValue());
public static PolarCoordinate MaxValue = new PolarCoordinate(Default.Radius.MaxValue(),Default.Angle.MaxValue());
public static bool operator ==(PolarCoordinate a, PolarCoordinate b) => (a.Radius == b.Radius) && (a.Angle == b.Angle);
public static bool operator !=(PolarCoordinate a, PolarCoordinate b) => (a.Radius != b.Radius) || (a.Angle != b.Angle);
public PolarCoordinate WithRadius(double value) => new PolarCoordinate(value, Angle);
public PolarCoordinate WithAngle(Angle value) => new PolarCoordinate(Radius, value);
}
public static partial class Intrinsics {
public static PolarCoordinate Default(this PolarCoordinate _) => default(PolarCoordinate);
public static PolarCoordinate Zero(this PolarCoordinate _) => PolarCoordinate.Zero;
public static PolarCoordinate One(this PolarCoordinate _) => PolarCoordinate.One;
public static PolarCoordinate MinValue(this PolarCoordinate _) => PolarCoordinate.MinValue;
public static PolarCoordinate MaxValue(this PolarCoordinate _) => PolarCoordinate.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct LogPolarCoordinate
{
public LogPolarCoordinate(double rho, Angle azimuth) => (Rho, Azimuth) = (rho, azimuth);
public static LogPolarCoordinate Create(double rho, Angle azimuth) => new LogPolarCoordinate(rho, azimuth);
public double Rho { get; }
public Angle Azimuth { get; }
public static implicit operator LogPolarCoordinate((double Rho, Angle Azimuth) tuple) => new LogPolarCoordinate(tuple.Rho, tuple.Azimuth);
public static implicit operator (double Rho, Angle Azimuth)(LogPolarCoordinate self) => (self.Rho, self.Azimuth);
public void Deconstruct(out double rho, out Angle azimuth) => (rho, azimuth) = (Rho, Azimuth);
public override string ToString() => $"{{ \"Rho\" : { Rho }, \"Azimuth\" : { Azimuth } }}";
public override bool Equals(object other) => other is LogPolarCoordinate typedOther && this == typedOther;
public override int GetHashCode() => (Rho, Azimuth).GetHashCode();
public static readonly LogPolarCoordinate Default = default;
public static LogPolarCoordinate Zero = new LogPolarCoordinate(Default.Rho.Zero(),Default.Azimuth.Zero());
public static LogPolarCoordinate One = new LogPolarCoordinate(Default.Rho.One(),Default.Azimuth.One());
public static LogPolarCoordinate MinValue = new LogPolarCoordinate(Default.Rho.MinValue(),Default.Azimuth.MinValue());
public static LogPolarCoordinate MaxValue = new LogPolarCoordinate(Default.Rho.MaxValue(),Default.Azimuth.MaxValue());
public static bool operator ==(LogPolarCoordinate a, LogPolarCoordinate b) => (a.Rho == b.Rho) && (a.Azimuth == b.Azimuth);
public static bool operator !=(LogPolarCoordinate a, LogPolarCoordinate b) => (a.Rho != b.Rho) || (a.Azimuth != b.Azimuth);
public LogPolarCoordinate WithRho(double value) => new LogPolarCoordinate(value, Azimuth);
public LogPolarCoordinate WithAzimuth(Angle value) => new LogPolarCoordinate(Rho, value);
}
public static partial class Intrinsics {
public static LogPolarCoordinate Default(this LogPolarCoordinate _) => default(LogPolarCoordinate);
public static LogPolarCoordinate Zero(this LogPolarCoordinate _) => LogPolarCoordinate.Zero;
public static LogPolarCoordinate One(this LogPolarCoordinate _) => LogPolarCoordinate.One;
public static LogPolarCoordinate MinValue(this LogPolarCoordinate _) => LogPolarCoordinate.MinValue;
public static LogPolarCoordinate MaxValue(this LogPolarCoordinate _) => LogPolarCoordinate.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct HorizontalCoordinate
{
public HorizontalCoordinate(double radius, Angle azimuth, double height) => (Radius, Azimuth, Height) = (radius, azimuth, height);
public static HorizontalCoordinate Create(double radius, Angle azimuth, double height) => new HorizontalCoordinate(radius, azimuth, height);
public double Radius { get; }
public Angle Azimuth { get; }
public double Height { get; }
public static implicit operator HorizontalCoordinate((double Radius, Angle Azimuth, double Height) tuple) => new HorizontalCoordinate(tuple.Radius, tuple.Azimuth, tuple.Height);
public static implicit operator (double Radius, Angle Azimuth, double Height)(HorizontalCoordinate self) => (self.Radius, self.Azimuth, self.Height);
public void Deconstruct(out double radius, out Angle azimuth, out double height) => (radius, azimuth, height) = (Radius, Azimuth, Height);
public override string ToString() => $"{{ \"Radius\" : { Radius }, \"Azimuth\" : { Azimuth }, \"Height\" : { Height } }}";
public override bool Equals(object other) => other is HorizontalCoordinate typedOther && this == typedOther;
public override int GetHashCode() => (Radius, Azimuth, Height).GetHashCode();
public static readonly HorizontalCoordinate Default = default;
public static HorizontalCoordinate Zero = new HorizontalCoordinate(Default.Radius.Zero(),Default.Azimuth.Zero(),Default.Height.Zero());
public static HorizontalCoordinate One = new HorizontalCoordinate(Default.Radius.One(),Default.Azimuth.One(),Default.Height.One());
public static HorizontalCoordinate MinValue = new HorizontalCoordinate(Default.Radius.MinValue(),Default.Azimuth.MinValue(),Default.Height.MinValue());
public static HorizontalCoordinate MaxValue = new HorizontalCoordinate(Default.Radius.MaxValue(),Default.Azimuth.MaxValue(),Default.Height.MaxValue());
public static bool operator ==(HorizontalCoordinate a, HorizontalCoordinate b) => (a.Radius == b.Radius) && (a.Azimuth == b.Azimuth) && (a.Height == b.Height);
public static bool operator !=(HorizontalCoordinate a, HorizontalCoordinate b) => (a.Radius != b.Radius) || (a.Azimuth != b.Azimuth) || (a.Height != b.Height);
public HorizontalCoordinate WithRadius(double value) => new HorizontalCoordinate(value, Azimuth, Height);
public HorizontalCoordinate WithAzimuth(Angle value) => new HorizontalCoordinate(Radius, value, Height);
public HorizontalCoordinate WithHeight(double value) => new HorizontalCoordinate(Radius, Azimuth, value);
}
public static partial class Intrinsics {
public static HorizontalCoordinate Default(this HorizontalCoordinate _) => default(HorizontalCoordinate);
public static HorizontalCoordinate Zero(this HorizontalCoordinate _) => HorizontalCoordinate.Zero;
public static HorizontalCoordinate One(this HorizontalCoordinate _) => HorizontalCoordinate.One;
public static HorizontalCoordinate MinValue(this HorizontalCoordinate _) => HorizontalCoordinate.MinValue;
public static HorizontalCoordinate MaxValue(this HorizontalCoordinate _) => HorizontalCoordinate.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct GeoCoordinate
{
public GeoCoordinate(double latitude, double longitude, double altitude) => (Latitude, Longitude, Altitude) = (latitude, longitude, altitude);
public static GeoCoordinate Create(double latitude, double longitude, double altitude) => new GeoCoordinate(latitude, longitude, altitude);
public double Latitude { get; }
public double Longitude { get; }
public double Altitude { get; }
public static implicit operator GeoCoordinate((double Latitude, double Longitude, double Altitude) tuple) => new GeoCoordinate(tuple.Latitude, tuple.Longitude, tuple.Altitude);
public static implicit operator (double Latitude, double Longitude, double Altitude)(GeoCoordinate self) => (self.Latitude, self.Longitude, self.Altitude);
public void Deconstruct(out double latitude, out double longitude, out double altitude) => (latitude, longitude, altitude) = (Latitude, Longitude, Altitude);
public override string ToString() => $"{{ \"Latitude\" : { Latitude }, \"Longitude\" : { Longitude }, \"Altitude\" : { Altitude } }}";
public override bool Equals(object other) => other is GeoCoordinate typedOther && this == typedOther;
public override int GetHashCode() => (Latitude, Longitude, Altitude).GetHashCode();
public static readonly GeoCoordinate Default = default;
public static GeoCoordinate Zero = new GeoCoordinate(Default.Latitude.Zero(),Default.Longitude.Zero(),Default.Altitude.Zero());
public static GeoCoordinate One = new GeoCoordinate(Default.Latitude.One(),Default.Longitude.One(),Default.Altitude.One());
public static GeoCoordinate MinValue = new GeoCoordinate(Default.Latitude.MinValue(),Default.Longitude.MinValue(),Default.Altitude.MinValue());
public static GeoCoordinate MaxValue = new GeoCoordinate(Default.Latitude.MaxValue(),Default.Longitude.MaxValue(),Default.Altitude.MaxValue());
public static bool operator ==(GeoCoordinate a, GeoCoordinate b) => (a.Latitude == b.Latitude) && (a.Longitude == b.Longitude) && (a.Altitude == b.Altitude);
public static bool operator !=(GeoCoordinate a, GeoCoordinate b) => (a.Latitude != b.Latitude) || (a.Longitude != b.Longitude) || (a.Altitude != b.Altitude);
public GeoCoordinate WithLatitude(double value) => new GeoCoordinate(value, Longitude, Altitude);
public GeoCoordinate WithLongitude(double value) => new GeoCoordinate(Latitude, value, Altitude);
public GeoCoordinate WithAltitude(double value) => new GeoCoordinate(Latitude, Longitude, value);
}
public static partial class Intrinsics {
public static GeoCoordinate Default(this GeoCoordinate _) => default(GeoCoordinate);
public static GeoCoordinate Zero(this GeoCoordinate _) => GeoCoordinate.Zero;
public static GeoCoordinate One(this GeoCoordinate _) => GeoCoordinate.One;
public static GeoCoordinate MinValue(this GeoCoordinate _) => GeoCoordinate.MinValue;
public static GeoCoordinate MaxValue(this GeoCoordinate _) => GeoCoordinate.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Circle
{
public Circle(Point2D center, double radius) => (Center, Radius) = (center, radius);
public static Circle Create(Point2D center, double radius) => new Circle(center, radius);
public Point2D Center { get; }
public double Radius { get; }
public static implicit operator Circle((Point2D Center, double Radius) tuple) => new Circle(tuple.Center, tuple.Radius);
public static implicit operator (Point2D Center, double Radius)(Circle self) => (self.Center, self.Radius);
public void Deconstruct(out Point2D center, out double radius) => (center, radius) = (Center, Radius);
public override string ToString() => $"{{ \"Center\" : { Center }, \"Radius\" : { Radius } }}";
public override bool Equals(object other) => other is Circle typedOther && this == typedOther;
public override int GetHashCode() => (Center, Radius).GetHashCode();
public static readonly Circle Default = default;
public static Circle Zero = new Circle(Default.Center.Zero(),Default.Radius.Zero());
public static Circle One = new Circle(Default.Center.One(),Default.Radius.One());
public static Circle MinValue = new Circle(Default.Center.MinValue(),Default.Radius.MinValue());
public static Circle MaxValue = new Circle(Default.Center.MaxValue(),Default.Radius.MaxValue());
public static bool operator ==(Circle a, Circle b) => (a.Center == b.Center) && (a.Radius == b.Radius);
public static bool operator !=(Circle a, Circle b) => (a.Center != b.Center) || (a.Radius != b.Radius);
public Circle WithCenter(Point2D value) => new Circle(value, Radius);
public Circle WithRadius(double value) => new Circle(Center, value);
}
public static partial class Intrinsics {
public static Circle Default(this Circle _) => default(Circle);
public static Circle Zero(this Circle _) => Circle.Zero;
public static Circle One(this Circle _) => Circle.One;
public static Circle MinValue(this Circle _) => Circle.MinValue;
public static Circle MaxValue(this Circle _) => Circle.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Size
{
public Size(double width, double height) => (Width, Height) = (width, height);
public static Size Create(double width, double height) => new Size(width, height);
public double Width { get; }
public double Height { get; }
public static implicit operator Size((double Width, double Height) tuple) => new Size(tuple.Width, tuple.Height);
public static implicit operator (double Width, double Height)(Size self) => (self.Width, self.Height);
public void Deconstruct(out double width, out double height) => (width, height) = (Width, Height);
public override string ToString() => $"{{ \"Width\" : { Width }, \"Height\" : { Height } }}";
public override bool Equals(object other) => other is Size typedOther && this == typedOther;
public override int GetHashCode() => (Width, Height).GetHashCode();
public static readonly Size Default = default;
public static Size Zero = new Size(Default.Width.Zero(),Default.Height.Zero());
public static Size One = new Size(Default.Width.One(),Default.Height.One());
public static Size MinValue = new Size(Default.Width.MinValue(),Default.Height.MinValue());
public static Size MaxValue = new Size(Default.Width.MaxValue(),Default.Height.MaxValue());
public static bool operator ==(Size a, Size b) => (a.Width == b.Width) && (a.Height == b.Height);
public static bool operator !=(Size a, Size b) => (a.Width != b.Width) || (a.Height != b.Height);
public Size WithWidth(double value) => new Size(value, Height);
public Size WithHeight(double value) => new Size(Width, value);
}
public static partial class Intrinsics {
public static Size Default(this Size _) => default(Size);
public static Size Zero(this Size _) => Size.Zero;
public static Size One(this Size _) => Size.One;
public static Size MinValue(this Size _) => Size.MinValue;
public static Size MaxValue(this Size _) => Size.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Rectangle
{
public Rectangle(Double2 topleft, Size size) => (TopLeft, Size) = (topleft, size);
public static Rectangle Create(Double2 topleft, Size size) => new Rectangle(topleft, size);
public Double2 TopLeft { get; }
public Size Size { get; }
public static implicit operator Rectangle((Double2 TopLeft, Size Size) tuple) => new Rectangle(tuple.TopLeft, tuple.Size);
public static implicit operator (Double2 TopLeft, Size Size)(Rectangle self) => (self.TopLeft, self.Size);
public void Deconstruct(out Double2 topleft, out Size size) => (topleft, size) = (TopLeft, Size);
public override string ToString() => $"{{ \"TopLeft\" : { TopLeft }, \"Size\" : { Size } }}";
public override bool Equals(object other) => other is Rectangle typedOther && this == typedOther;
public override int GetHashCode() => (TopLeft, Size).GetHashCode();
public static readonly Rectangle Default = default;
public static Rectangle Zero = new Rectangle(Default.TopLeft.Zero(),Default.Size.Zero());
public static Rectangle One = new Rectangle(Default.TopLeft.One(),Default.Size.One());
public static Rectangle MinValue = new Rectangle(Default.TopLeft.MinValue(),Default.Size.MinValue());
public static Rectangle MaxValue = new Rectangle(Default.TopLeft.MaxValue(),Default.Size.MaxValue());
public static bool operator ==(Rectangle a, Rectangle b) => (a.TopLeft == b.TopLeft) && (a.Size == b.Size);
public static bool operator !=(Rectangle a, Rectangle b) => (a.TopLeft != b.TopLeft) || (a.Size != b.Size);
public Rectangle WithTopLeft(Double2 value) => new Rectangle(value, Size);
public Rectangle WithSize(Size value) => new Rectangle(TopLeft, value);
}
public static partial class Intrinsics {
public static Rectangle Default(this Rectangle _) => default(Rectangle);
public static Rectangle Zero(this Rectangle _) => Rectangle.Zero;
public static Rectangle One(this Rectangle _) => Rectangle.One;
public static Rectangle MinValue(this Rectangle _) => Rectangle.MinValue;
public static Rectangle MaxValue(this Rectangle _) => Rectangle.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Proportion
{
public Proportion(double value) => (Value) = (value);
public static Proportion Create(double value) => new Proportion(value);
public double Value { get; }
public static implicit operator Proportion(double value) => new Proportion(value);
public static implicit operator double(Proportion value) => value.Value;
public override string ToString() => $"{{ \"Value\" : { Value } }}";
public override bool Equals(object other) => other is Proportion typedOther && this == typedOther;
public override int GetHashCode() => (Value).GetHashCode();
public static readonly Proportion Default = default;
public static Proportion Zero = new Proportion(Default.Value.Zero());
public static Proportion One = new Proportion(Default.Value.One());
public static Proportion MinValue = new Proportion(Default.Value.MinValue());
public static Proportion MaxValue = new Proportion(Default.Value.MaxValue());
public static bool operator ==(Proportion a, Proportion b) => (a.Value == b.Value);
public static bool operator !=(Proportion a, Proportion b) => (a.Value != b.Value);
public Proportion WithValue(double value) => new Proportion(value);
public static Proportion operator +(Proportion a, Proportion b) => new Proportion(a.Value + b.Value);
public static Proportion operator +(double a, Proportion b) => new Proportion(a + b.Value);
public static Proportion operator +(Proportion a, double b) => new Proportion(a.Value + b);
public static Proportion operator -(Proportion a, Proportion b) => new Proportion(a.Value - b.Value);
public static Proportion operator -(double a, Proportion b) => new Proportion(a - b.Value);
public static Proportion operator -(Proportion a, double b) => new Proportion(a.Value - b);
public static Proportion operator *(Proportion a, Proportion b) => new Proportion(a.Value * b.Value);
public static Proportion operator *(Proportion a, double  b) => new Proportion(a.Value * b);
public static Proportion operator *(double  a, Proportion b) => new Proportion(a * b.Value);
public static Proportion operator /(Proportion a, Proportion b) => new Proportion(a.Value / b.Value);
public static Proportion operator /(Proportion a, double  b) => new Proportion(a.Value / b);
public static Proportion operator /(double  a, Proportion b) => new Proportion(a / b.Value);
public static Proportion operator %(Proportion a, Proportion b) => new Proportion(a.Value % b.Value);
public static Proportion operator %(Proportion a, double  b) => new Proportion(a.Value % b);
public static Proportion operator %(double  a, Proportion b) => new Proportion(a % b.Value);
public static Proportion operator -(Proportion a) => new Proportion(- a.Value);
public static bool operator <(Proportion a, Proportion b) => a.Value < b.Value;
public static bool operator <=(Proportion a, Proportion b) => a.Value <= b.Value;
public static bool operator >(Proportion a, Proportion b) => a.Value > b.Value;
public static bool operator >=(Proportion a, Proportion b) => a.Value >= b.Value;
public int CompareTo(Proportion other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static Proportion Add(this Proportion a, Proportion b) => a + b;
public static IArray<Proportion> Add(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a + b);
public static Proportion Subtract(this Proportion a, Proportion b) => a - b;
public static IArray<Proportion> Subtract(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a - b);
public static Proportion Sum(this IArray<Proportion> self) => self.Aggregate((a, b) => a + b);
public static Proportion Multiply(this Proportion a, Proportion b) => a * b;
public static IArray<Proportion> Multiply(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a * b);
public static Proportion Divide(this Proportion a, Proportion b) => a / b;
public static IArray<Proportion> Divide(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a / b);
public static Proportion Modulo(this Proportion a, Proportion b) => a % b;
public static IArray<Proportion> Modulo(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a % b);
public static Proportion Product(this IArray<Proportion> self) => self.Aggregate((a, b) => a * b);
public static Proportion Negate(this Proportion a) => - a;
public static IArray<Proportion> Negate(this IArray<Proportion> self) => self.Select(a => - a);
public static bool Equals(this Proportion a, Proportion b) => a == b;
public static bool NotEquals(this Proportion a, Proportion b) => a != b;
public static int CompareTo(this Proportion self, Proportion other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Proportion a, Proportion b) => a < b;
public static IArray<bool> LessThan(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Proportion a, Proportion b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Proportion a, Proportion b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Proportion a, Proportion b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Proportion> self, IArray<Proportion> other) => self.Zip(other, (a,b) => a >= b);
public static Proportion Default(this Proportion _) => default(Proportion);
public static Proportion Zero(this Proportion _) => Proportion.Zero;
public static Proportion One(this Proportion _) => Proportion.One;
public static double ToDouble(this Proportion self) => self;
public static Proportion MinValue(this Proportion _) => Proportion.MinValue;
public static Proportion MaxValue(this Proportion _) => Proportion.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Amount
{
public Amount(double mole) => (Mole) = (mole);
public static Amount Create(double mole) => new Amount(mole);
public double Mole { get; }
public static implicit operator Amount(double value) => new Amount(value);
public static implicit operator double(Amount value) => value.Mole;
public override string ToString() => $"{{ \"Mole\" : { Mole } }}";
public override bool Equals(object other) => other is Amount typedOther && this == typedOther;
public override int GetHashCode() => (Mole).GetHashCode();
public static readonly Amount Default = default;
public static Amount Zero = new Amount(Default.Mole.Zero());
public static Amount One = new Amount(Default.Mole.One());
public static Amount MinValue = new Amount(Default.Mole.MinValue());
public static Amount MaxValue = new Amount(Default.Mole.MaxValue());
public static bool operator ==(Amount a, Amount b) => (a.Mole == b.Mole);
public static bool operator !=(Amount a, Amount b) => (a.Mole != b.Mole);
public Amount WithMole(double value) => new Amount(value);
}
public static partial class Intrinsics {
public static Amount Default(this Amount _) => default(Amount);
public static Amount Zero(this Amount _) => Amount.Zero;
public static Amount One(this Amount _) => Amount.One;
public static double ToDouble(this Amount self) => self;
public static Amount MinValue(this Amount _) => Amount.MinValue;
public static Amount MaxValue(this Amount _) => Amount.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Fraction
{
public Fraction(double numerator, double denominator) => (Numerator, Denominator) = (numerator, denominator);
public static Fraction Create(double numerator, double denominator) => new Fraction(numerator, denominator);
public double Numerator { get; }
public double Denominator { get; }
public static implicit operator Fraction((double Numerator, double Denominator) tuple) => new Fraction(tuple.Numerator, tuple.Denominator);
public static implicit operator (double Numerator, double Denominator)(Fraction self) => (self.Numerator, self.Denominator);
public void Deconstruct(out double numerator, out double denominator) => (numerator, denominator) = (Numerator, Denominator);
public override string ToString() => $"{{ \"Numerator\" : { Numerator }, \"Denominator\" : { Denominator } }}";
public override bool Equals(object other) => other is Fraction typedOther && this == typedOther;
public override int GetHashCode() => (Numerator, Denominator).GetHashCode();
public static readonly Fraction Default = default;
public static Fraction Zero = new Fraction(Default.Numerator.Zero(),Default.Denominator.Zero());
public static Fraction One = new Fraction(Default.Numerator.One(),Default.Denominator.One());
public static Fraction MinValue = new Fraction(Default.Numerator.MinValue(),Default.Denominator.MinValue());
public static Fraction MaxValue = new Fraction(Default.Numerator.MaxValue(),Default.Denominator.MaxValue());
public static bool operator ==(Fraction a, Fraction b) => (a.Numerator == b.Numerator) && (a.Denominator == b.Denominator);
public static bool operator !=(Fraction a, Fraction b) => (a.Numerator != b.Numerator) || (a.Denominator != b.Denominator);
public Fraction WithNumerator(double value) => new Fraction(value, Denominator);
public Fraction WithDenominator(double value) => new Fraction(Numerator, value);
}
public static partial class Intrinsics {
public static Fraction Default(this Fraction _) => default(Fraction);
public static Fraction Zero(this Fraction _) => Fraction.Zero;
public static Fraction One(this Fraction _) => Fraction.One;
public static Fraction MinValue(this Fraction _) => Fraction.MinValue;
public static Fraction MaxValue(this Fraction _) => Fraction.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Angle
{
public Angle(double radians) => (Radians) = (radians);
public static Angle Create(double radians) => new Angle(radians);
public const string Units = nameof(Radians);
public double Radians { get; }
public static implicit operator Angle(double value) => new Angle(value);
public static implicit operator double(Angle value) => value.Radians;
public override string ToString() => $"{{ \"Radians\" : { Radians } }}";
public override bool Equals(object other) => other is Angle typedOther && this == typedOther;
public override int GetHashCode() => (Radians).GetHashCode();
public static readonly Angle Default = default;
public static Angle Zero = new Angle(Default.Radians.Zero());
public static Angle One = new Angle(Default.Radians.One());
public static Angle MinValue = new Angle(Default.Radians.MinValue());
public static Angle MaxValue = new Angle(Default.Radians.MaxValue());
public static bool operator ==(Angle a, Angle b) => (a.Radians == b.Radians);
public static bool operator !=(Angle a, Angle b) => (a.Radians != b.Radians);
public Angle WithRadians(double value) => new Angle(value);
public static Angle operator +(Angle a, Angle b) => new Angle(a.Radians + b.Radians);
public static Angle operator +(double a, Angle b) => new Angle(a + b.Radians);
public static Angle operator +(Angle a, double b) => new Angle(a.Radians + b);
public static Angle operator -(Angle a, Angle b) => new Angle(a.Radians - b.Radians);
public static Angle operator -(double a, Angle b) => new Angle(a - b.Radians);
public static Angle operator -(Angle a, double b) => new Angle(a.Radians - b);
public static Angle operator *(Angle a, double  b) => new Angle(a.Radians * b);
public static Angle operator *(double  a, Angle b) => new Angle(a * b.Radians);
public static Angle operator /(Angle a, double  b) => new Angle(a.Radians / b);
public static Angle operator /(double  a, Angle b) => new Angle(a / b.Radians);
public static Angle operator %(Angle a, double  b) => new Angle(a.Radians % b);
public static Angle operator %(double  a, Angle b) => new Angle(a % b.Radians);
public static Angle operator -(Angle a) => new Angle(- a.Radians);
public static bool operator <(Angle a, Angle b) => a.Radians < b.Radians;
public static bool operator <=(Angle a, Angle b) => a.Radians <= b.Radians;
public static bool operator >(Angle a, Angle b) => a.Radians > b.Radians;
public static bool operator >=(Angle a, Angle b) => a.Radians >= b.Radians;
public int CompareTo(Angle other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Angle self, Angle other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Angle> self, IArray<Angle> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Angle a, Angle b) => a < b;
public static IArray<bool> LessThan(this IArray<Angle> self, IArray<Angle> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Angle a, Angle b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Angle> self, IArray<Angle> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Angle a, Angle b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Angle> self, IArray<Angle> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Angle a, Angle b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Angle> self, IArray<Angle> other) => self.Zip(other, (a,b) => a >= b);
public static Angle Default(this Angle _) => default(Angle);
public static Angle Zero(this Angle _) => Angle.Zero;
public static Angle One(this Angle _) => Angle.One;
public static double ToDouble(this Angle self) => self;
public static Angle MinValue(this Angle _) => Angle.MinValue;
public static Angle MaxValue(this Angle _) => Angle.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Length
{
public Length(double meters) => (Meters) = (meters);
public static Length Create(double meters) => new Length(meters);
public const string Units = nameof(Meters);
public double Meters { get; }
public static implicit operator Length(double value) => new Length(value);
public static implicit operator double(Length value) => value.Meters;
public override string ToString() => $"{{ \"Meters\" : { Meters } }}";
public override bool Equals(object other) => other is Length typedOther && this == typedOther;
public override int GetHashCode() => (Meters).GetHashCode();
public static readonly Length Default = default;
public static Length Zero = new Length(Default.Meters.Zero());
public static Length One = new Length(Default.Meters.One());
public static Length MinValue = new Length(Default.Meters.MinValue());
public static Length MaxValue = new Length(Default.Meters.MaxValue());
public static bool operator ==(Length a, Length b) => (a.Meters == b.Meters);
public static bool operator !=(Length a, Length b) => (a.Meters != b.Meters);
public Length WithMeters(double value) => new Length(value);
public static Length operator +(Length a, Length b) => new Length(a.Meters + b.Meters);
public static Length operator +(double a, Length b) => new Length(a + b.Meters);
public static Length operator +(Length a, double b) => new Length(a.Meters + b);
public static Length operator -(Length a, Length b) => new Length(a.Meters - b.Meters);
public static Length operator -(double a, Length b) => new Length(a - b.Meters);
public static Length operator -(Length a, double b) => new Length(a.Meters - b);
public static Length operator *(Length a, double  b) => new Length(a.Meters * b);
public static Length operator *(double  a, Length b) => new Length(a * b.Meters);
public static Length operator /(Length a, double  b) => new Length(a.Meters / b);
public static Length operator /(double  a, Length b) => new Length(a / b.Meters);
public static Length operator %(Length a, double  b) => new Length(a.Meters % b);
public static Length operator %(double  a, Length b) => new Length(a % b.Meters);
public static Length operator -(Length a) => new Length(- a.Meters);
public static bool operator <(Length a, Length b) => a.Meters < b.Meters;
public static bool operator <=(Length a, Length b) => a.Meters <= b.Meters;
public static bool operator >(Length a, Length b) => a.Meters > b.Meters;
public static bool operator >=(Length a, Length b) => a.Meters >= b.Meters;
public int CompareTo(Length other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Length self, Length other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Length> self, IArray<Length> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Length a, Length b) => a < b;
public static IArray<bool> LessThan(this IArray<Length> self, IArray<Length> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Length a, Length b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Length> self, IArray<Length> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Length a, Length b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Length> self, IArray<Length> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Length a, Length b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Length> self, IArray<Length> other) => self.Zip(other, (a,b) => a >= b);
public static Length Default(this Length _) => default(Length);
public static Length Zero(this Length _) => Length.Zero;
public static Length One(this Length _) => Length.One;
public static double ToDouble(this Length self) => self;
public static Length MinValue(this Length _) => Length.MinValue;
public static Length MaxValue(this Length _) => Length.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Mass
{
public Mass(double kilograms) => (Kilograms) = (kilograms);
public static Mass Create(double kilograms) => new Mass(kilograms);
public const string Units = nameof(Kilograms);
public double Kilograms { get; }
public static implicit operator Mass(double value) => new Mass(value);
public static implicit operator double(Mass value) => value.Kilograms;
public override string ToString() => $"{{ \"Kilograms\" : { Kilograms } }}";
public override bool Equals(object other) => other is Mass typedOther && this == typedOther;
public override int GetHashCode() => (Kilograms).GetHashCode();
public static readonly Mass Default = default;
public static Mass Zero = new Mass(Default.Kilograms.Zero());
public static Mass One = new Mass(Default.Kilograms.One());
public static Mass MinValue = new Mass(Default.Kilograms.MinValue());
public static Mass MaxValue = new Mass(Default.Kilograms.MaxValue());
public static bool operator ==(Mass a, Mass b) => (a.Kilograms == b.Kilograms);
public static bool operator !=(Mass a, Mass b) => (a.Kilograms != b.Kilograms);
public Mass WithKilograms(double value) => new Mass(value);
public static Mass operator +(Mass a, Mass b) => new Mass(a.Kilograms + b.Kilograms);
public static Mass operator +(double a, Mass b) => new Mass(a + b.Kilograms);
public static Mass operator +(Mass a, double b) => new Mass(a.Kilograms + b);
public static Mass operator -(Mass a, Mass b) => new Mass(a.Kilograms - b.Kilograms);
public static Mass operator -(double a, Mass b) => new Mass(a - b.Kilograms);
public static Mass operator -(Mass a, double b) => new Mass(a.Kilograms - b);
public static Mass operator *(Mass a, double  b) => new Mass(a.Kilograms * b);
public static Mass operator *(double  a, Mass b) => new Mass(a * b.Kilograms);
public static Mass operator /(Mass a, double  b) => new Mass(a.Kilograms / b);
public static Mass operator /(double  a, Mass b) => new Mass(a / b.Kilograms);
public static Mass operator %(Mass a, double  b) => new Mass(a.Kilograms % b);
public static Mass operator %(double  a, Mass b) => new Mass(a % b.Kilograms);
public static Mass operator -(Mass a) => new Mass(- a.Kilograms);
public static bool operator <(Mass a, Mass b) => a.Kilograms < b.Kilograms;
public static bool operator <=(Mass a, Mass b) => a.Kilograms <= b.Kilograms;
public static bool operator >(Mass a, Mass b) => a.Kilograms > b.Kilograms;
public static bool operator >=(Mass a, Mass b) => a.Kilograms >= b.Kilograms;
public int CompareTo(Mass other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Mass self, Mass other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Mass> self, IArray<Mass> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Mass a, Mass b) => a < b;
public static IArray<bool> LessThan(this IArray<Mass> self, IArray<Mass> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Mass a, Mass b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Mass> self, IArray<Mass> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Mass a, Mass b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Mass> self, IArray<Mass> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Mass a, Mass b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Mass> self, IArray<Mass> other) => self.Zip(other, (a,b) => a >= b);
public static Mass Default(this Mass _) => default(Mass);
public static Mass Zero(this Mass _) => Mass.Zero;
public static Mass One(this Mass _) => Mass.One;
public static double ToDouble(this Mass self) => self;
public static Mass MinValue(this Mass _) => Mass.MinValue;
public static Mass MaxValue(this Mass _) => Mass.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Temperature
{
public Temperature(double celsius) => (Celsius) = (celsius);
public static Temperature Create(double celsius) => new Temperature(celsius);
public const string Units = nameof(Celsius);
public double Celsius { get; }
public static implicit operator Temperature(double value) => new Temperature(value);
public static implicit operator double(Temperature value) => value.Celsius;
public override string ToString() => $"{{ \"Celsius\" : { Celsius } }}";
public override bool Equals(object other) => other is Temperature typedOther && this == typedOther;
public override int GetHashCode() => (Celsius).GetHashCode();
public static readonly Temperature Default = default;
public static Temperature Zero = new Temperature(Default.Celsius.Zero());
public static Temperature One = new Temperature(Default.Celsius.One());
public static Temperature MinValue = new Temperature(Default.Celsius.MinValue());
public static Temperature MaxValue = new Temperature(Default.Celsius.MaxValue());
public static bool operator ==(Temperature a, Temperature b) => (a.Celsius == b.Celsius);
public static bool operator !=(Temperature a, Temperature b) => (a.Celsius != b.Celsius);
public Temperature WithCelsius(double value) => new Temperature(value);
public static Temperature operator +(Temperature a, Temperature b) => new Temperature(a.Celsius + b.Celsius);
public static Temperature operator +(double a, Temperature b) => new Temperature(a + b.Celsius);
public static Temperature operator +(Temperature a, double b) => new Temperature(a.Celsius + b);
public static Temperature operator -(Temperature a, Temperature b) => new Temperature(a.Celsius - b.Celsius);
public static Temperature operator -(double a, Temperature b) => new Temperature(a - b.Celsius);
public static Temperature operator -(Temperature a, double b) => new Temperature(a.Celsius - b);
public static Temperature operator *(Temperature a, double  b) => new Temperature(a.Celsius * b);
public static Temperature operator *(double  a, Temperature b) => new Temperature(a * b.Celsius);
public static Temperature operator /(Temperature a, double  b) => new Temperature(a.Celsius / b);
public static Temperature operator /(double  a, Temperature b) => new Temperature(a / b.Celsius);
public static Temperature operator %(Temperature a, double  b) => new Temperature(a.Celsius % b);
public static Temperature operator %(double  a, Temperature b) => new Temperature(a % b.Celsius);
public static Temperature operator -(Temperature a) => new Temperature(- a.Celsius);
public static bool operator <(Temperature a, Temperature b) => a.Celsius < b.Celsius;
public static bool operator <=(Temperature a, Temperature b) => a.Celsius <= b.Celsius;
public static bool operator >(Temperature a, Temperature b) => a.Celsius > b.Celsius;
public static bool operator >=(Temperature a, Temperature b) => a.Celsius >= b.Celsius;
public int CompareTo(Temperature other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Temperature self, Temperature other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Temperature> self, IArray<Temperature> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Temperature a, Temperature b) => a < b;
public static IArray<bool> LessThan(this IArray<Temperature> self, IArray<Temperature> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Temperature a, Temperature b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Temperature> self, IArray<Temperature> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Temperature a, Temperature b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Temperature> self, IArray<Temperature> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Temperature a, Temperature b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Temperature> self, IArray<Temperature> other) => self.Zip(other, (a,b) => a >= b);
public static Temperature Default(this Temperature _) => default(Temperature);
public static Temperature Zero(this Temperature _) => Temperature.Zero;
public static Temperature One(this Temperature _) => Temperature.One;
public static double ToDouble(this Temperature self) => self;
public static Temperature MinValue(this Temperature _) => Temperature.MinValue;
public static Temperature MaxValue(this Temperature _) => Temperature.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Time
{
public Time(double seconds) => (Seconds) = (seconds);
public static Time Create(double seconds) => new Time(seconds);
public const string Units = nameof(Seconds);
public double Seconds { get; }
public static implicit operator Time(double value) => new Time(value);
public static implicit operator double(Time value) => value.Seconds;
public override string ToString() => $"{{ \"Seconds\" : { Seconds } }}";
public override bool Equals(object other) => other is Time typedOther && this == typedOther;
public override int GetHashCode() => (Seconds).GetHashCode();
public static readonly Time Default = default;
public static Time Zero = new Time(Default.Seconds.Zero());
public static Time One = new Time(Default.Seconds.One());
public static Time MinValue = new Time(Default.Seconds.MinValue());
public static Time MaxValue = new Time(Default.Seconds.MaxValue());
public static bool operator ==(Time a, Time b) => (a.Seconds == b.Seconds);
public static bool operator !=(Time a, Time b) => (a.Seconds != b.Seconds);
public Time WithSeconds(double value) => new Time(value);
public static Time operator +(Time a, Time b) => new Time(a.Seconds + b.Seconds);
public static Time operator +(double a, Time b) => new Time(a + b.Seconds);
public static Time operator +(Time a, double b) => new Time(a.Seconds + b);
public static Time operator -(Time a, Time b) => new Time(a.Seconds - b.Seconds);
public static Time operator -(double a, Time b) => new Time(a - b.Seconds);
public static Time operator -(Time a, double b) => new Time(a.Seconds - b);
public static Time operator *(Time a, double  b) => new Time(a.Seconds * b);
public static Time operator *(double  a, Time b) => new Time(a * b.Seconds);
public static Time operator /(Time a, double  b) => new Time(a.Seconds / b);
public static Time operator /(double  a, Time b) => new Time(a / b.Seconds);
public static Time operator %(Time a, double  b) => new Time(a.Seconds % b);
public static Time operator %(double  a, Time b) => new Time(a % b.Seconds);
public static Time operator -(Time a) => new Time(- a.Seconds);
public static bool operator <(Time a, Time b) => a.Seconds < b.Seconds;
public static bool operator <=(Time a, Time b) => a.Seconds <= b.Seconds;
public static bool operator >(Time a, Time b) => a.Seconds > b.Seconds;
public static bool operator >=(Time a, Time b) => a.Seconds >= b.Seconds;
public int CompareTo(Time other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Time self, Time other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Time> self, IArray<Time> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Time a, Time b) => a < b;
public static IArray<bool> LessThan(this IArray<Time> self, IArray<Time> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Time a, Time b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Time> self, IArray<Time> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Time a, Time b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Time> self, IArray<Time> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Time a, Time b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Time> self, IArray<Time> other) => self.Zip(other, (a,b) => a >= b);
public static Time Default(this Time _) => default(Time);
public static Time Zero(this Time _) => Time.Zero;
public static Time One(this Time _) => Time.One;
public static double ToDouble(this Time self) => self;
public static Time MinValue(this Time _) => Time.MinValue;
public static Time MaxValue(this Time _) => Time.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TimeInterval
{
public TimeInterval(Time start, Time end) => (Start, End) = (start, end);
public static TimeInterval Create(Time start, Time end) => new TimeInterval(start, end);
public Time Start { get; }
public Time End { get; }
public static implicit operator TimeInterval((Time Start, Time End) tuple) => new TimeInterval(tuple.Start, tuple.End);
public static implicit operator (Time Start, Time End)(TimeInterval self) => (self.Start, self.End);
public void Deconstruct(out Time start, out Time end) => (start, end) = (Start, End);
public static implicit operator TimeInterval(Time value) => new TimeInterval(default, value);
public override string ToString() => $"{{ \"Start\" : { Start }, \"End\" : { End } }}";
public override bool Equals(object other) => other is TimeInterval typedOther && this == typedOther;
public override int GetHashCode() => (Start, End).GetHashCode();
public static readonly TimeInterval Default = default;
public static TimeInterval Zero = new TimeInterval(Default.Start.Zero(),Default.End.Zero());
public static TimeInterval One = new TimeInterval(Default.Start.One(),Default.End.One());
public static TimeInterval MinValue = new TimeInterval(Default.Start.MinValue(),Default.End.MinValue());
public static TimeInterval MaxValue = new TimeInterval(Default.Start.MaxValue(),Default.End.MaxValue());
public static bool operator ==(TimeInterval a, TimeInterval b) => (a.Start == b.Start) && (a.End == b.End);
public static bool operator !=(TimeInterval a, TimeInterval b) => (a.Start != b.Start) || (a.End != b.End);
public TimeInterval WithStart(Time value) => new TimeInterval(value, End);
public TimeInterval WithEnd(Time value) => new TimeInterval(Start, value);
}
public static partial class Intrinsics {
public static TimeInterval Default(this TimeInterval _) => default(TimeInterval);
public static TimeInterval Zero(this TimeInterval _) => TimeInterval.Zero;
public static TimeInterval One(this TimeInterval _) => TimeInterval.One;
public static TimeInterval MinValue(this TimeInterval _) => TimeInterval.MinValue;
public static TimeInterval MaxValue(this TimeInterval _) => TimeInterval.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Interval
{
public Interval(double a, double b) => (A, B) = (a, b);
public static Interval Create(double a, double b) => new Interval(a, b);
public double A { get; }
public double B { get; }
public static implicit operator Interval((double A, double B) tuple) => new Interval(tuple.A, tuple.B);
public static implicit operator (double A, double B)(Interval self) => (self.A, self.B);
public void Deconstruct(out double a, out double b) => (a, b) = (A, B);
public static implicit operator Interval(double value) => new Interval(default, value);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Interval typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Interval Default = default;
public static Interval Zero = new Interval(Default.A.Zero(),Default.B.Zero());
public static Interval One = new Interval(Default.A.One(),Default.B.One());
public static Interval MinValue = new Interval(Default.A.MinValue(),Default.B.MinValue());
public static Interval MaxValue = new Interval(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Interval a, Interval b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Interval a, Interval b) => (a.A != b.A) || (a.B != b.B);
public Interval WithA(double value) => new Interval(value, B);
public Interval WithB(double value) => new Interval(A, value);
}
public static partial class Intrinsics {
public static Interval Default(this Interval _) => default(Interval);
public static Interval Zero(this Interval _) => Interval.Zero;
public static Interval One(this Interval _) => Interval.One;
public static Interval MinValue(this Interval _) => Interval.MinValue;
public static Interval MaxValue(this Interval _) => Interval.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Interval2D
{
public Interval2D(Double2 a, Double2 b) => (A, B) = (a, b);
public static Interval2D Create(Double2 a, Double2 b) => new Interval2D(a, b);
public Double2 A { get; }
public Double2 B { get; }
public static implicit operator Interval2D((Double2 A, Double2 B) tuple) => new Interval2D(tuple.A, tuple.B);
public static implicit operator (Double2 A, Double2 B)(Interval2D self) => (self.A, self.B);
public void Deconstruct(out Double2 a, out Double2 b) => (a, b) = (A, B);
public static implicit operator Interval2D(Double2 value) => new Interval2D(default, value);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Interval2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Interval2D Default = default;
public static Interval2D Zero = new Interval2D(Default.A.Zero(),Default.B.Zero());
public static Interval2D One = new Interval2D(Default.A.One(),Default.B.One());
public static Interval2D MinValue = new Interval2D(Default.A.MinValue(),Default.B.MinValue());
public static Interval2D MaxValue = new Interval2D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Interval2D a, Interval2D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Interval2D a, Interval2D b) => (a.A != b.A) || (a.B != b.B);
public Interval2D WithA(Double2 value) => new Interval2D(value, B);
public Interval2D WithB(Double2 value) => new Interval2D(A, value);
}
public static partial class Intrinsics {
public static Interval2D Default(this Interval2D _) => default(Interval2D);
public static Interval2D Zero(this Interval2D _) => Interval2D.Zero;
public static Interval2D One(this Interval2D _) => Interval2D.One;
public static Interval2D MinValue(this Interval2D _) => Interval2D.MinValue;
public static Interval2D MaxValue(this Interval2D _) => Interval2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Interval3D
{
public Interval3D(Double3 a, Double3 b) => (A, B) = (a, b);
public static Interval3D Create(Double3 a, Double3 b) => new Interval3D(a, b);
public Double3 A { get; }
public Double3 B { get; }
public static implicit operator Interval3D((Double3 A, Double3 B) tuple) => new Interval3D(tuple.A, tuple.B);
public static implicit operator (Double3 A, Double3 B)(Interval3D self) => (self.A, self.B);
public void Deconstruct(out Double3 a, out Double3 b) => (a, b) = (A, B);
public static implicit operator Interval3D(Double3 value) => new Interval3D(default, value);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B } }}";
public override bool Equals(object other) => other is Interval3D typedOther && this == typedOther;
public override int GetHashCode() => (A, B).GetHashCode();
public static readonly Interval3D Default = default;
public static Interval3D Zero = new Interval3D(Default.A.Zero(),Default.B.Zero());
public static Interval3D One = new Interval3D(Default.A.One(),Default.B.One());
public static Interval3D MinValue = new Interval3D(Default.A.MinValue(),Default.B.MinValue());
public static Interval3D MaxValue = new Interval3D(Default.A.MaxValue(),Default.B.MaxValue());
public static bool operator ==(Interval3D a, Interval3D b) => (a.A == b.A) && (a.B == b.B);
public static bool operator !=(Interval3D a, Interval3D b) => (a.A != b.A) || (a.B != b.B);
public Interval3D WithA(Double3 value) => new Interval3D(value, B);
public Interval3D WithB(Double3 value) => new Interval3D(A, value);
}
public static partial class Intrinsics {
public static Interval3D Default(this Interval3D _) => default(Interval3D);
public static Interval3D Zero(this Interval3D _) => Interval3D.Zero;
public static Interval3D One(this Interval3D _) => Interval3D.One;
public static Interval3D MinValue(this Interval3D _) => Interval3D.MinValue;
public static Interval3D MaxValue(this Interval3D _) => Interval3D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Capsule
{
public Capsule(Line3D line3D, double radius) => (Line3D, Radius) = (line3D, radius);
public static Capsule Create(Line3D line3D, double radius) => new Capsule(line3D, radius);
public Line3D Line3D { get; }
public double Radius { get; }
public static implicit operator Capsule((Line3D Line, double Radius) tuple) => new Capsule(tuple.Line, tuple.Radius);
public static implicit operator (Line3D Line, double Radius)(Capsule self) => (self.Line3D, self.Radius);
public void Deconstruct(out Line3D line3D, out double radius) => (line3D, radius) = (Line3D, Radius);
public override string ToString() => $"{{ \"Line3D\" : { Line3D }, \"Radius\" : { Radius } }}";
public override bool Equals(object other) => other is Capsule typedOther && this == typedOther;
public override int GetHashCode() => (Line: Line3D, Radius).GetHashCode();
public static readonly Capsule Default = default;
public static Capsule Zero = new Capsule(Default.Line3D.Zero(),Default.Radius.Zero());
public static Capsule One = new Capsule(Default.Line3D.One(),Default.Radius.One());
public static Capsule MinValue = new Capsule(Default.Line3D.MinValue(),Default.Radius.MinValue());
public static Capsule MaxValue = new Capsule(Default.Line3D.MaxValue(),Default.Radius.MaxValue());
public static bool operator ==(Capsule a, Capsule b) => (a.Line3D == b.Line3D) && (a.Radius == b.Radius);
public static bool operator !=(Capsule a, Capsule b) => (a.Line3D != b.Line3D) || (a.Radius != b.Radius);
public Capsule WithLine(Line3D value) => new Capsule(value, Radius);
public Capsule WithRadius(double value) => new Capsule(Line3D, value);
}
public static partial class Intrinsics {
public static Capsule Default(this Capsule _) => default(Capsule);
public static Capsule Zero(this Capsule _) => Capsule.Zero;
public static Capsule One(this Capsule _) => Capsule.One;
public static Capsule MinValue(this Capsule _) => Capsule.MinValue;
public static Capsule MaxValue(this Capsule _) => Capsule.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Cylinder
{
public Cylinder(Line3D line3D, double radius) => (Line3D, Radius) = (line3D, radius);
public static Cylinder Create(Line3D line3D, double radius) => new Cylinder(line3D, radius);
public Line3D Line3D { get; }
public double Radius { get; }
public static implicit operator Cylinder((Line3D Line, double Radius) tuple) => new Cylinder(tuple.Line, tuple.Radius);
public static implicit operator (Line3D Line, double Radius)(Cylinder self) => (self.Line3D, self.Radius);
public void Deconstruct(out Line3D line3D, out double radius) => (line3D, radius) = (Line3D, Radius);
public override string ToString() => $"{{ \"Line3D\" : { Line3D }, \"Radius\" : { Radius } }}";
public override bool Equals(object other) => other is Cylinder typedOther && this == typedOther;
public override int GetHashCode() => (Line: Line3D, Radius).GetHashCode();
public static readonly Cylinder Default = default;
public static Cylinder Zero = new Cylinder(Default.Line3D.Zero(),Default.Radius.Zero());
public static Cylinder One = new Cylinder(Default.Line3D.One(),Default.Radius.One());
public static Cylinder MinValue = new Cylinder(Default.Line3D.MinValue(),Default.Radius.MinValue());
public static Cylinder MaxValue = new Cylinder(Default.Line3D.MaxValue(),Default.Radius.MaxValue());
public static bool operator ==(Cylinder a, Cylinder b) => (a.Line3D == b.Line3D) && (a.Radius == b.Radius);
public static bool operator !=(Cylinder a, Cylinder b) => (a.Line3D != b.Line3D) || (a.Radius != b.Radius);
public Cylinder WithLine(Line3D value) => new Cylinder(value, Radius);
public Cylinder WithRadius(double value) => new Cylinder(Line3D, value);
}
public static partial class Intrinsics {
public static Cylinder Default(this Cylinder _) => default(Cylinder);
public static Cylinder Zero(this Cylinder _) => Cylinder.Zero;
public static Cylinder One(this Cylinder _) => Cylinder.One;
public static Cylinder MinValue(this Cylinder _) => Cylinder.MinValue;
public static Cylinder MaxValue(this Cylinder _) => Cylinder.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Cone
{
public Cone(Line3D line3D, double radius) => (Line3D, Radius) = (line3D, radius);
public static Cone Create(Line3D line3D, double radius) => new Cone(line3D, radius);
public Line3D Line3D { get; }
public double Radius { get; }
public static implicit operator Cone((Line3D Line, double Radius) tuple) => new Cone(tuple.Line, tuple.Radius);
public static implicit operator (Line3D Line, double Radius)(Cone self) => (self.Line3D, self.Radius);
public void Deconstruct(out Line3D line3D, out double radius) => (line3D, radius) = (Line3D, Radius);
public override string ToString() => $"{{ \"Line3D\" : { Line3D }, \"Radius\" : { Radius } }}";
public override bool Equals(object other) => other is Cone typedOther && this == typedOther;
public override int GetHashCode() => (Line: Line3D, Radius).GetHashCode();
public static readonly Cone Default = default;
public static Cone Zero = new Cone(Default.Line3D.Zero(),Default.Radius.Zero());
public static Cone One = new Cone(Default.Line3D.One(),Default.Radius.One());
public static Cone MinValue = new Cone(Default.Line3D.MinValue(),Default.Radius.MinValue());
public static Cone MaxValue = new Cone(Default.Line3D.MaxValue(),Default.Radius.MaxValue());
public static bool operator ==(Cone a, Cone b) => (a.Line3D == b.Line3D) && (a.Radius == b.Radius);
public static bool operator !=(Cone a, Cone b) => (a.Line3D != b.Line3D) || (a.Radius != b.Radius);
public Cone WithLine(Line3D value) => new Cone(value, Radius);
public Cone WithRadius(double value) => new Cone(Line3D, value);
}
public static partial class Intrinsics {
public static Cone Default(this Cone _) => default(Cone);
public static Cone Zero(this Cone _) => Cone.Zero;
public static Cone One(this Cone _) => Cone.One;
public static Cone MinValue(this Cone _) => Cone.MinValue;
public static Cone MaxValue(this Cone _) => Cone.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Tube
{
public Tube(Line3D line3D, double innerradius, double outerradius) => (Line3D, InnerRadius, OuterRadius) = (line3D, innerradius, outerradius);
public static Tube Create(Line3D line3D, double innerradius, double outerradius) => new Tube(line3D, innerradius, outerradius);
public Line3D Line3D { get; }
public double InnerRadius { get; }
public double OuterRadius { get; }
public static implicit operator Tube((Line3D Line, double InnerRadius, double OuterRadius) tuple) => new Tube(tuple.Line, tuple.InnerRadius, tuple.OuterRadius);
public static implicit operator (Line3D Line, double InnerRadius, double OuterRadius)(Tube self) => (self.Line3D, self.InnerRadius, self.OuterRadius);
public void Deconstruct(out Line3D line3D, out double innerradius, out double outerradius) => (line3D, innerradius, outerradius) = (Line3D, InnerRadius, OuterRadius);
public override string ToString() => $"{{ \"Line3D\" : { Line3D }, \"InnerRadius\" : { InnerRadius }, \"OuterRadius\" : { OuterRadius } }}";
public override bool Equals(object other) => other is Tube typedOther && this == typedOther;
public override int GetHashCode() => (Line: Line3D, InnerRadius, OuterRadius).GetHashCode();
public static readonly Tube Default = default;
public static Tube Zero = new Tube(Default.Line3D.Zero(),Default.InnerRadius.Zero(),Default.OuterRadius.Zero());
public static Tube One = new Tube(Default.Line3D.One(),Default.InnerRadius.One(),Default.OuterRadius.One());
public static Tube MinValue = new Tube(Default.Line3D.MinValue(),Default.InnerRadius.MinValue(),Default.OuterRadius.MinValue());
public static Tube MaxValue = new Tube(Default.Line3D.MaxValue(),Default.InnerRadius.MaxValue(),Default.OuterRadius.MaxValue());
public static bool operator ==(Tube a, Tube b) => (a.Line3D == b.Line3D) && (a.InnerRadius == b.InnerRadius) && (a.OuterRadius == b.OuterRadius);
public static bool operator !=(Tube a, Tube b) => (a.Line3D != b.Line3D) || (a.InnerRadius != b.InnerRadius) || (a.OuterRadius != b.OuterRadius);
public Tube WithLine(Line3D value) => new Tube(value, InnerRadius, OuterRadius);
public Tube WithInnerRadius(double value) => new Tube(Line3D, value, OuterRadius);
public Tube WithOuterRadius(double value) => new Tube(Line3D, InnerRadius, value);
}
public static partial class Intrinsics {
public static Tube Default(this Tube _) => default(Tube);
public static Tube Zero(this Tube _) => Tube.Zero;
public static Tube One(this Tube _) => Tube.One;
public static Tube MinValue(this Tube _) => Tube.MinValue;
public static Tube MaxValue(this Tube _) => Tube.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ConeSegment
{
public ConeSegment(Line3D line3D, double radius1, double radius2) => (Line3D, Radius1, Radius2) = (line3D, radius1, radius2);
public static ConeSegment Create(Line3D line3D, double radius1, double radius2) => new ConeSegment(line3D, radius1, radius2);
public Line3D Line3D { get; }
public double Radius1 { get; }
public double Radius2 { get; }
public static implicit operator ConeSegment((Line3D Line, double Radius1, double Radius2) tuple) => new ConeSegment(tuple.Line, tuple.Radius1, tuple.Radius2);
public static implicit operator (Line3D Line, double Radius1, double Radius2)(ConeSegment self) => (self.Line3D, self.Radius1, self.Radius2);
public void Deconstruct(out Line3D line3D, out double radius1, out double radius2) => (line3D, radius1, radius2) = (Line3D, Radius1, Radius2);
public override string ToString() => $"{{ \"Line3D\" : { Line3D }, \"Radius1\" : { Radius1 }, \"Radius2\" : { Radius2 } }}";
public override bool Equals(object other) => other is ConeSegment typedOther && this == typedOther;
public override int GetHashCode() => (Line: Line3D, Radius1, Radius2).GetHashCode();
public static readonly ConeSegment Default = default;
public static ConeSegment Zero = new ConeSegment(Default.Line3D.Zero(),Default.Radius1.Zero(),Default.Radius2.Zero());
public static ConeSegment One = new ConeSegment(Default.Line3D.One(),Default.Radius1.One(),Default.Radius2.One());
public static ConeSegment MinValue = new ConeSegment(Default.Line3D.MinValue(),Default.Radius1.MinValue(),Default.Radius2.MinValue());
public static ConeSegment MaxValue = new ConeSegment(Default.Line3D.MaxValue(),Default.Radius1.MaxValue(),Default.Radius2.MaxValue());
public static bool operator ==(ConeSegment a, ConeSegment b) => (a.Line3D == b.Line3D) && (a.Radius1 == b.Radius1) && (a.Radius2 == b.Radius2);
public static bool operator !=(ConeSegment a, ConeSegment b) => (a.Line3D != b.Line3D) || (a.Radius1 != b.Radius1) || (a.Radius2 != b.Radius2);
public ConeSegment WithLine(Line3D value) => new ConeSegment(value, Radius1, Radius2);
public ConeSegment WithRadius1(double value) => new ConeSegment(Line3D, value, Radius2);
public ConeSegment WithRadius2(double value) => new ConeSegment(Line3D, Radius1, value);
}
public static partial class Intrinsics {
public static ConeSegment Default(this ConeSegment _) => default(ConeSegment);
public static ConeSegment Zero(this ConeSegment _) => ConeSegment.Zero;
public static ConeSegment One(this ConeSegment _) => ConeSegment.One;
public static ConeSegment MinValue(this ConeSegment _) => ConeSegment.MinValue;
public static ConeSegment MaxValue(this ConeSegment _) => ConeSegment.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Box
{
public Box(Point3D center, Rotation rotation, Double3 extent) => (Center, Rotation, Extent) = (center, rotation, extent);
public static Box Create(Point3D center, Rotation rotation, Double3 extent) => new Box(center, rotation, extent);
public Point3D Center { get; }
public Rotation Rotation { get; }
public Double3 Extent { get; }
public static implicit operator Box((Point3D Center, Rotation Rotation, Double3 Extent) tuple) => new Box(tuple.Center, tuple.Rotation, tuple.Extent);
public static implicit operator (Point3D Center, Rotation Rotation, Double3 Extent)(Box self) => (self.Center, self.Rotation, self.Extent);
public void Deconstruct(out Point3D center, out Rotation rotation, out Double3 extent) => (center, rotation, extent) = (Center, Rotation, Extent);
public override string ToString() => $"{{ \"Center\" : { Center }, \"Rotation3D\" : { Rotation }, \"Extent\" : { Extent } }}";
public override bool Equals(object other) => other is Box typedOther && this == typedOther;
public override int GetHashCode() => (Center, Rotation, Extent).GetHashCode();
public static readonly Box Default = default;
public static Box Zero = new Box(Default.Center.Zero(),Default.Rotation.Zero(),Default.Extent.Zero());
public static Box One = new Box(Default.Center.One(),Default.Rotation.One(),Default.Extent.One());
public static Box MinValue = new Box(Default.Center.MinValue(),Default.Rotation.MinValue(),Default.Extent.MinValue());
public static Box MaxValue = new Box(Default.Center.MaxValue(),Default.Rotation.MaxValue(),Default.Extent.MaxValue());
public static bool operator ==(Box a, Box b) => (a.Center == b.Center) && (a.Rotation == b.Rotation) && (a.Extent == b.Extent);
public static bool operator !=(Box a, Box b) => (a.Center != b.Center) || (a.Rotation != b.Rotation) || (a.Extent != b.Extent);
public Box WithCenter(Point3D value) => new Box(value, Rotation, Extent);
public Box WithRotation(Rotation value) => new Box(Center, value, Extent);
public Box WithExtent(Double3 value) => new Box(Center, Rotation, value);
}
public static partial class Intrinsics {
public static Box Default(this Box _) => default(Box);
public static Box Zero(this Box _) => Box.Zero;
public static Box One(this Box _) => Box.One;
public static Box MinValue(this Box _) => Box.MinValue;
public static Box MaxValue(this Box _) => Box.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CubicBezier2D
{
public CubicBezier2D(Point2D a, Point2D b, Point2D c, Point2D d) => (A, B, C, D) = (a, b, c, d);
public static CubicBezier2D Create(Point2D a, Point2D b, Point2D c, Point2D d) => new CubicBezier2D(a, b, c, d);
public Point2D A { get; }
public Point2D B { get; }
public Point2D C { get; }
public Point2D D { get; }
public static implicit operator CubicBezier2D((Point2D A, Point2D B, Point2D C, Point2D D) tuple) => new CubicBezier2D(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (Point2D A, Point2D B, Point2D C, Point2D D)(CubicBezier2D self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out Point2D a, out Point2D b, out Point2D c, out Point2D d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is CubicBezier2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly CubicBezier2D Default = default;
public static CubicBezier2D Zero = new CubicBezier2D(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static CubicBezier2D One = new CubicBezier2D(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static CubicBezier2D MinValue = new CubicBezier2D(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static CubicBezier2D MaxValue = new CubicBezier2D(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(CubicBezier2D a, CubicBezier2D b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(CubicBezier2D a, CubicBezier2D b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public CubicBezier2D WithA(Point2D value) => new CubicBezier2D(value, B, C, D);
public CubicBezier2D WithB(Point2D value) => new CubicBezier2D(A, value, C, D);
public CubicBezier2D WithC(Point2D value) => new CubicBezier2D(A, B, value, D);
public CubicBezier2D WithD(Point2D value) => new CubicBezier2D(A, B, C, value);
}
public static partial class Intrinsics {
public static CubicBezier2D Default(this CubicBezier2D _) => default(CubicBezier2D);
public static CubicBezier2D Zero(this CubicBezier2D _) => CubicBezier2D.Zero;
public static CubicBezier2D One(this CubicBezier2D _) => CubicBezier2D.One;
public static CubicBezier2D MinValue(this CubicBezier2D _) => CubicBezier2D.MinValue;
public static CubicBezier2D MaxValue(this CubicBezier2D _) => CubicBezier2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CubicBezier
{
public CubicBezier(Point3D a, Point3D b, Point3D c, Point3D d) => (A, B, C, D) = (a, b, c, d);
public static CubicBezier Create(Point3D a, Point3D b, Point3D c, Point3D d) => new CubicBezier(a, b, c, d);
public Point3D A { get; }
public Point3D B { get; }
public Point3D C { get; }
public Point3D D { get; }
public static implicit operator CubicBezier((Point3D A, Point3D B, Point3D C, Point3D D) tuple) => new CubicBezier(tuple.A, tuple.B, tuple.C, tuple.D);
public static implicit operator (Point3D A, Point3D B, Point3D C, Point3D D)(CubicBezier self) => (self.A, self.B, self.C, self.D);
public void Deconstruct(out Point3D a, out Point3D b, out Point3D c, out Point3D d) => (a, b, c, d) = (A, B, C, D);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C }, \"D\" : { D } }}";
public override bool Equals(object other) => other is CubicBezier typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C, D).GetHashCode();
public static readonly CubicBezier Default = default;
public static CubicBezier Zero = new CubicBezier(Default.A.Zero(),Default.B.Zero(),Default.C.Zero(),Default.D.Zero());
public static CubicBezier One = new CubicBezier(Default.A.One(),Default.B.One(),Default.C.One(),Default.D.One());
public static CubicBezier MinValue = new CubicBezier(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue(),Default.D.MinValue());
public static CubicBezier MaxValue = new CubicBezier(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue(),Default.D.MaxValue());
public static bool operator ==(CubicBezier a, CubicBezier b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D);
public static bool operator !=(CubicBezier a, CubicBezier b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C) || (a.D != b.D);
public CubicBezier WithA(Point3D value) => new CubicBezier(value, B, C, D);
public CubicBezier WithB(Point3D value) => new CubicBezier(A, value, C, D);
public CubicBezier WithC(Point3D value) => new CubicBezier(A, B, value, D);
public CubicBezier WithD(Point3D value) => new CubicBezier(A, B, C, value);
}
public static partial class Intrinsics {
public static CubicBezier Default(this CubicBezier _) => default(CubicBezier);
public static CubicBezier Zero(this CubicBezier _) => CubicBezier.Zero;
public static CubicBezier One(this CubicBezier _) => CubicBezier.One;
public static CubicBezier MinValue(this CubicBezier _) => CubicBezier.MinValue;
public static CubicBezier MaxValue(this CubicBezier _) => CubicBezier.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct QuadraticBezier2D
{
public QuadraticBezier2D(Point2D a, Point2D b, Point2D c) => (A, B, C) = (a, b, c);
public static QuadraticBezier2D Create(Point2D a, Point2D b, Point2D c) => new QuadraticBezier2D(a, b, c);
public Point2D A { get; }
public Point2D B { get; }
public Point2D C { get; }
public static implicit operator QuadraticBezier2D((Point2D A, Point2D B, Point2D C) tuple) => new QuadraticBezier2D(tuple.A, tuple.B, tuple.C);
public static implicit operator (Point2D A, Point2D B, Point2D C)(QuadraticBezier2D self) => (self.A, self.B, self.C);
public void Deconstruct(out Point2D a, out Point2D b, out Point2D c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is QuadraticBezier2D typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly QuadraticBezier2D Default = default;
public static QuadraticBezier2D Zero = new QuadraticBezier2D(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static QuadraticBezier2D One = new QuadraticBezier2D(Default.A.One(),Default.B.One(),Default.C.One());
public static QuadraticBezier2D MinValue = new QuadraticBezier2D(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static QuadraticBezier2D MaxValue = new QuadraticBezier2D(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(QuadraticBezier2D a, QuadraticBezier2D b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(QuadraticBezier2D a, QuadraticBezier2D b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public QuadraticBezier2D WithA(Point2D value) => new QuadraticBezier2D(value, B, C);
public QuadraticBezier2D WithB(Point2D value) => new QuadraticBezier2D(A, value, C);
public QuadraticBezier2D WithC(Point2D value) => new QuadraticBezier2D(A, B, value);
}
public static partial class Intrinsics {
public static QuadraticBezier2D Default(this QuadraticBezier2D _) => default(QuadraticBezier2D);
public static QuadraticBezier2D Zero(this QuadraticBezier2D _) => QuadraticBezier2D.Zero;
public static QuadraticBezier2D One(this QuadraticBezier2D _) => QuadraticBezier2D.One;
public static QuadraticBezier2D MinValue(this QuadraticBezier2D _) => QuadraticBezier2D.MinValue;
public static QuadraticBezier2D MaxValue(this QuadraticBezier2D _) => QuadraticBezier2D.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct QuadraticBezier
{
public QuadraticBezier(Point3D a, Point3D b, Point3D c) => (A, B, C) = (a, b, c);
public static QuadraticBezier Create(Point3D a, Point3D b, Point3D c) => new QuadraticBezier(a, b, c);
public Point3D A { get; }
public Point3D B { get; }
public Point3D C { get; }
public static implicit operator QuadraticBezier((Point3D A, Point3D B, Point3D C) tuple) => new QuadraticBezier(tuple.A, tuple.B, tuple.C);
public static implicit operator (Point3D A, Point3D B, Point3D C)(QuadraticBezier self) => (self.A, self.B, self.C);
public void Deconstruct(out Point3D a, out Point3D b, out Point3D c) => (a, b, c) = (A, B, C);
public override string ToString() => $"{{ \"A\" : { A }, \"B\" : { B }, \"C\" : { C } }}";
public override bool Equals(object other) => other is QuadraticBezier typedOther && this == typedOther;
public override int GetHashCode() => (A, B, C).GetHashCode();
public static readonly QuadraticBezier Default = default;
public static QuadraticBezier Zero = new QuadraticBezier(Default.A.Zero(),Default.B.Zero(),Default.C.Zero());
public static QuadraticBezier One = new QuadraticBezier(Default.A.One(),Default.B.One(),Default.C.One());
public static QuadraticBezier MinValue = new QuadraticBezier(Default.A.MinValue(),Default.B.MinValue(),Default.C.MinValue());
public static QuadraticBezier MaxValue = new QuadraticBezier(Default.A.MaxValue(),Default.B.MaxValue(),Default.C.MaxValue());
public static bool operator ==(QuadraticBezier a, QuadraticBezier b) => (a.A == b.A) && (a.B == b.B) && (a.C == b.C);
public static bool operator !=(QuadraticBezier a, QuadraticBezier b) => (a.A != b.A) || (a.B != b.B) || (a.C != b.C);
public QuadraticBezier WithA(Point3D value) => new QuadraticBezier(value, B, C);
public QuadraticBezier WithB(Point3D value) => new QuadraticBezier(A, value, C);
public QuadraticBezier WithC(Point3D value) => new QuadraticBezier(A, B, value);
}
public static partial class Intrinsics {
public static QuadraticBezier Default(this QuadraticBezier _) => default(QuadraticBezier);
public static QuadraticBezier Zero(this QuadraticBezier _) => QuadraticBezier.Zero;
public static QuadraticBezier One(this QuadraticBezier _) => QuadraticBezier.One;
public static QuadraticBezier MinValue(this QuadraticBezier _) => QuadraticBezier.MinValue;
public static QuadraticBezier MaxValue(this QuadraticBezier _) => QuadraticBezier.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Area
{
public Area(double meterssquared) => (MetersSquared) = (meterssquared);
public static Area Create(double meterssquared) => new Area(meterssquared);
public const string Units = nameof(MetersSquared);
public double MetersSquared { get; }
public static implicit operator Area(double value) => new Area(value);
public static implicit operator double(Area value) => value.MetersSquared;
public override string ToString() => $"{{ \"MetersSquared\" : { MetersSquared } }}";
public override bool Equals(object other) => other is Area typedOther && this == typedOther;
public override int GetHashCode() => (MetersSquared).GetHashCode();
public static readonly Area Default = default;
public static Area Zero = new Area(Default.MetersSquared.Zero());
public static Area One = new Area(Default.MetersSquared.One());
public static Area MinValue = new Area(Default.MetersSquared.MinValue());
public static Area MaxValue = new Area(Default.MetersSquared.MaxValue());
public static bool operator ==(Area a, Area b) => (a.MetersSquared == b.MetersSquared);
public static bool operator !=(Area a, Area b) => (a.MetersSquared != b.MetersSquared);
public Area WithMetersSquared(double value) => new Area(value);
public static Area operator +(Area a, Area b) => new Area(a.MetersSquared + b.MetersSquared);
public static Area operator +(double a, Area b) => new Area(a + b.MetersSquared);
public static Area operator +(Area a, double b) => new Area(a.MetersSquared + b);
public static Area operator -(Area a, Area b) => new Area(a.MetersSquared - b.MetersSquared);
public static Area operator -(double a, Area b) => new Area(a - b.MetersSquared);
public static Area operator -(Area a, double b) => new Area(a.MetersSquared - b);
public static Area operator *(Area a, double  b) => new Area(a.MetersSquared * b);
public static Area operator *(double  a, Area b) => new Area(a * b.MetersSquared);
public static Area operator /(Area a, double  b) => new Area(a.MetersSquared / b);
public static Area operator /(double  a, Area b) => new Area(a / b.MetersSquared);
public static Area operator %(Area a, double  b) => new Area(a.MetersSquared % b);
public static Area operator %(double  a, Area b) => new Area(a % b.MetersSquared);
public static Area operator -(Area a) => new Area(- a.MetersSquared);
public static bool operator <(Area a, Area b) => a.MetersSquared < b.MetersSquared;
public static bool operator <=(Area a, Area b) => a.MetersSquared <= b.MetersSquared;
public static bool operator >(Area a, Area b) => a.MetersSquared > b.MetersSquared;
public static bool operator >=(Area a, Area b) => a.MetersSquared >= b.MetersSquared;
public int CompareTo(Area other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Area self, Area other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Area> self, IArray<Area> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Area a, Area b) => a < b;
public static IArray<bool> LessThan(this IArray<Area> self, IArray<Area> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Area a, Area b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Area> self, IArray<Area> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Area a, Area b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Area> self, IArray<Area> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Area a, Area b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Area> self, IArray<Area> other) => self.Zip(other, (a,b) => a >= b);
public static Area Default(this Area _) => default(Area);
public static Area Zero(this Area _) => Area.Zero;
public static Area One(this Area _) => Area.One;
public static double ToDouble(this Area self) => self;
public static Area MinValue(this Area _) => Area.MinValue;
public static Area MaxValue(this Area _) => Area.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Volume
{
public Volume(double meterscubed) => (MetersCubed) = (meterscubed);
public static Volume Create(double meterscubed) => new Volume(meterscubed);
public const string Units = nameof(MetersCubed);
public double MetersCubed { get; }
public static implicit operator Volume(double value) => new Volume(value);
public static implicit operator double(Volume value) => value.MetersCubed;
public override string ToString() => $"{{ \"MetersCubed\" : { MetersCubed } }}";
public override bool Equals(object other) => other is Volume typedOther && this == typedOther;
public override int GetHashCode() => (MetersCubed).GetHashCode();
public static readonly Volume Default = default;
public static Volume Zero = new Volume(Default.MetersCubed.Zero());
public static Volume One = new Volume(Default.MetersCubed.One());
public static Volume MinValue = new Volume(Default.MetersCubed.MinValue());
public static Volume MaxValue = new Volume(Default.MetersCubed.MaxValue());
public static bool operator ==(Volume a, Volume b) => (a.MetersCubed == b.MetersCubed);
public static bool operator !=(Volume a, Volume b) => (a.MetersCubed != b.MetersCubed);
public Volume WithMetersCubed(double value) => new Volume(value);
public static Volume operator +(Volume a, Volume b) => new Volume(a.MetersCubed + b.MetersCubed);
public static Volume operator +(double a, Volume b) => new Volume(a + b.MetersCubed);
public static Volume operator +(Volume a, double b) => new Volume(a.MetersCubed + b);
public static Volume operator -(Volume a, Volume b) => new Volume(a.MetersCubed - b.MetersCubed);
public static Volume operator -(double a, Volume b) => new Volume(a - b.MetersCubed);
public static Volume operator -(Volume a, double b) => new Volume(a.MetersCubed - b);
public static Volume operator *(Volume a, double  b) => new Volume(a.MetersCubed * b);
public static Volume operator *(double  a, Volume b) => new Volume(a * b.MetersCubed);
public static Volume operator /(Volume a, double  b) => new Volume(a.MetersCubed / b);
public static Volume operator /(double  a, Volume b) => new Volume(a / b.MetersCubed);
public static Volume operator %(Volume a, double  b) => new Volume(a.MetersCubed % b);
public static Volume operator %(double  a, Volume b) => new Volume(a % b.MetersCubed);
public static Volume operator -(Volume a) => new Volume(- a.MetersCubed);
public static bool operator <(Volume a, Volume b) => a.MetersCubed < b.MetersCubed;
public static bool operator <=(Volume a, Volume b) => a.MetersCubed <= b.MetersCubed;
public static bool operator >(Volume a, Volume b) => a.MetersCubed > b.MetersCubed;
public static bool operator >=(Volume a, Volume b) => a.MetersCubed >= b.MetersCubed;
public int CompareTo(Volume other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Volume self, Volume other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Volume> self, IArray<Volume> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Volume a, Volume b) => a < b;
public static IArray<bool> LessThan(this IArray<Volume> self, IArray<Volume> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Volume a, Volume b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Volume> self, IArray<Volume> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Volume a, Volume b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Volume> self, IArray<Volume> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Volume a, Volume b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Volume> self, IArray<Volume> other) => self.Zip(other, (a,b) => a >= b);
public static Volume Default(this Volume _) => default(Volume);
public static Volume Zero(this Volume _) => Volume.Zero;
public static Volume One(this Volume _) => Volume.One;
public static double ToDouble(this Volume self) => self;
public static Volume MinValue(this Volume _) => Volume.MinValue;
public static Volume MaxValue(this Volume _) => Volume.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Velocity
{
public Velocity(double meterspersecond) => (MetersPerSecond) = (meterspersecond);
public static Velocity Create(double meterspersecond) => new Velocity(meterspersecond);
public const string Units = nameof(MetersPerSecond);
public double MetersPerSecond { get; }
public static implicit operator Velocity(double value) => new Velocity(value);
public static implicit operator double(Velocity value) => value.MetersPerSecond;
public override string ToString() => $"{{ \"MetersPerSecond\" : { MetersPerSecond } }}";
public override bool Equals(object other) => other is Velocity typedOther && this == typedOther;
public override int GetHashCode() => (MetersPerSecond).GetHashCode();
public static readonly Velocity Default = default;
public static Velocity Zero = new Velocity(Default.MetersPerSecond.Zero());
public static Velocity One = new Velocity(Default.MetersPerSecond.One());
public static Velocity MinValue = new Velocity(Default.MetersPerSecond.MinValue());
public static Velocity MaxValue = new Velocity(Default.MetersPerSecond.MaxValue());
public static bool operator ==(Velocity a, Velocity b) => (a.MetersPerSecond == b.MetersPerSecond);
public static bool operator !=(Velocity a, Velocity b) => (a.MetersPerSecond != b.MetersPerSecond);
public Velocity WithMetersPerSecond(double value) => new Velocity(value);
public static Velocity operator +(Velocity a, Velocity b) => new Velocity(a.MetersPerSecond + b.MetersPerSecond);
public static Velocity operator +(double a, Velocity b) => new Velocity(a + b.MetersPerSecond);
public static Velocity operator +(Velocity a, double b) => new Velocity(a.MetersPerSecond + b);
public static Velocity operator -(Velocity a, Velocity b) => new Velocity(a.MetersPerSecond - b.MetersPerSecond);
public static Velocity operator -(double a, Velocity b) => new Velocity(a - b.MetersPerSecond);
public static Velocity operator -(Velocity a, double b) => new Velocity(a.MetersPerSecond - b);
public static Velocity operator *(Velocity a, double  b) => new Velocity(a.MetersPerSecond * b);
public static Velocity operator *(double  a, Velocity b) => new Velocity(a * b.MetersPerSecond);
public static Velocity operator /(Velocity a, double  b) => new Velocity(a.MetersPerSecond / b);
public static Velocity operator /(double  a, Velocity b) => new Velocity(a / b.MetersPerSecond);
public static Velocity operator %(Velocity a, double  b) => new Velocity(a.MetersPerSecond % b);
public static Velocity operator %(double  a, Velocity b) => new Velocity(a % b.MetersPerSecond);
public static Velocity operator -(Velocity a) => new Velocity(- a.MetersPerSecond);
public static bool operator <(Velocity a, Velocity b) => a.MetersPerSecond < b.MetersPerSecond;
public static bool operator <=(Velocity a, Velocity b) => a.MetersPerSecond <= b.MetersPerSecond;
public static bool operator >(Velocity a, Velocity b) => a.MetersPerSecond > b.MetersPerSecond;
public static bool operator >=(Velocity a, Velocity b) => a.MetersPerSecond >= b.MetersPerSecond;
public int CompareTo(Velocity other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Velocity self, Velocity other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Velocity> self, IArray<Velocity> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Velocity a, Velocity b) => a < b;
public static IArray<bool> LessThan(this IArray<Velocity> self, IArray<Velocity> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Velocity a, Velocity b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Velocity> self, IArray<Velocity> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Velocity a, Velocity b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Velocity> self, IArray<Velocity> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Velocity a, Velocity b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Velocity> self, IArray<Velocity> other) => self.Zip(other, (a,b) => a >= b);
public static Velocity Default(this Velocity _) => default(Velocity);
public static Velocity Zero(this Velocity _) => Velocity.Zero;
public static Velocity One(this Velocity _) => Velocity.One;
public static double ToDouble(this Velocity self) => self;
public static Velocity MinValue(this Velocity _) => Velocity.MinValue;
public static Velocity MaxValue(this Velocity _) => Velocity.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Acceleration
{
public Acceleration(double meterspersecondsquared) => (MetersPerSecondSquared) = (meterspersecondsquared);
public static Acceleration Create(double meterspersecondsquared) => new Acceleration(meterspersecondsquared);
public const string Units = nameof(MetersPerSecondSquared);
public double MetersPerSecondSquared { get; }
public static implicit operator Acceleration(double value) => new Acceleration(value);
public static implicit operator double(Acceleration value) => value.MetersPerSecondSquared;
public override string ToString() => $"{{ \"MetersPerSecondSquared\" : { MetersPerSecondSquared } }}";
public override bool Equals(object other) => other is Acceleration typedOther && this == typedOther;
public override int GetHashCode() => (MetersPerSecondSquared).GetHashCode();
public static readonly Acceleration Default = default;
public static Acceleration Zero = new Acceleration(Default.MetersPerSecondSquared.Zero());
public static Acceleration One = new Acceleration(Default.MetersPerSecondSquared.One());
public static Acceleration MinValue = new Acceleration(Default.MetersPerSecondSquared.MinValue());
public static Acceleration MaxValue = new Acceleration(Default.MetersPerSecondSquared.MaxValue());
public static bool operator ==(Acceleration a, Acceleration b) => (a.MetersPerSecondSquared == b.MetersPerSecondSquared);
public static bool operator !=(Acceleration a, Acceleration b) => (a.MetersPerSecondSquared != b.MetersPerSecondSquared);
public Acceleration WithMetersPerSecondSquared(double value) => new Acceleration(value);
public static Acceleration operator +(Acceleration a, Acceleration b) => new Acceleration(a.MetersPerSecondSquared + b.MetersPerSecondSquared);
public static Acceleration operator +(double a, Acceleration b) => new Acceleration(a + b.MetersPerSecondSquared);
public static Acceleration operator +(Acceleration a, double b) => new Acceleration(a.MetersPerSecondSquared + b);
public static Acceleration operator -(Acceleration a, Acceleration b) => new Acceleration(a.MetersPerSecondSquared - b.MetersPerSecondSquared);
public static Acceleration operator -(double a, Acceleration b) => new Acceleration(a - b.MetersPerSecondSquared);
public static Acceleration operator -(Acceleration a, double b) => new Acceleration(a.MetersPerSecondSquared - b);
public static Acceleration operator *(Acceleration a, double  b) => new Acceleration(a.MetersPerSecondSquared * b);
public static Acceleration operator *(double  a, Acceleration b) => new Acceleration(a * b.MetersPerSecondSquared);
public static Acceleration operator /(Acceleration a, double  b) => new Acceleration(a.MetersPerSecondSquared / b);
public static Acceleration operator /(double  a, Acceleration b) => new Acceleration(a / b.MetersPerSecondSquared);
public static Acceleration operator %(Acceleration a, double  b) => new Acceleration(a.MetersPerSecondSquared % b);
public static Acceleration operator %(double  a, Acceleration b) => new Acceleration(a % b.MetersPerSecondSquared);
public static Acceleration operator -(Acceleration a) => new Acceleration(- a.MetersPerSecondSquared);
public static bool operator <(Acceleration a, Acceleration b) => a.MetersPerSecondSquared < b.MetersPerSecondSquared;
public static bool operator <=(Acceleration a, Acceleration b) => a.MetersPerSecondSquared <= b.MetersPerSecondSquared;
public static bool operator >(Acceleration a, Acceleration b) => a.MetersPerSecondSquared > b.MetersPerSecondSquared;
public static bool operator >=(Acceleration a, Acceleration b) => a.MetersPerSecondSquared >= b.MetersPerSecondSquared;
public int CompareTo(Acceleration other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Acceleration self, Acceleration other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Acceleration> self, IArray<Acceleration> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Acceleration a, Acceleration b) => a < b;
public static IArray<bool> LessThan(this IArray<Acceleration> self, IArray<Acceleration> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Acceleration a, Acceleration b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Acceleration> self, IArray<Acceleration> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Acceleration a, Acceleration b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Acceleration> self, IArray<Acceleration> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Acceleration a, Acceleration b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Acceleration> self, IArray<Acceleration> other) => self.Zip(other, (a,b) => a >= b);
public static Acceleration Default(this Acceleration _) => default(Acceleration);
public static Acceleration Zero(this Acceleration _) => Acceleration.Zero;
public static Acceleration One(this Acceleration _) => Acceleration.One;
public static double ToDouble(this Acceleration self) => self;
public static Acceleration MinValue(this Acceleration _) => Acceleration.MinValue;
public static Acceleration MaxValue(this Acceleration _) => Acceleration.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Force
{
public Force(double newtons) => (Newtons) = (newtons);
public static Force Create(double newtons) => new Force(newtons);
public const string Units = nameof(Newtons);
public double Newtons { get; }
public static implicit operator Force(double value) => new Force(value);
public static implicit operator double(Force value) => value.Newtons;
public override string ToString() => $"{{ \"Newtons\" : { Newtons } }}";
public override bool Equals(object other) => other is Force typedOther && this == typedOther;
public override int GetHashCode() => (Newtons).GetHashCode();
public static readonly Force Default = default;
public static Force Zero = new Force(Default.Newtons.Zero());
public static Force One = new Force(Default.Newtons.One());
public static Force MinValue = new Force(Default.Newtons.MinValue());
public static Force MaxValue = new Force(Default.Newtons.MaxValue());
public static bool operator ==(Force a, Force b) => (a.Newtons == b.Newtons);
public static bool operator !=(Force a, Force b) => (a.Newtons != b.Newtons);
public Force WithNewtons(double value) => new Force(value);
public static Force operator +(Force a, Force b) => new Force(a.Newtons + b.Newtons);
public static Force operator +(double a, Force b) => new Force(a + b.Newtons);
public static Force operator +(Force a, double b) => new Force(a.Newtons + b);
public static Force operator -(Force a, Force b) => new Force(a.Newtons - b.Newtons);
public static Force operator -(double a, Force b) => new Force(a - b.Newtons);
public static Force operator -(Force a, double b) => new Force(a.Newtons - b);
public static Force operator *(Force a, double  b) => new Force(a.Newtons * b);
public static Force operator *(double  a, Force b) => new Force(a * b.Newtons);
public static Force operator /(Force a, double  b) => new Force(a.Newtons / b);
public static Force operator /(double  a, Force b) => new Force(a / b.Newtons);
public static Force operator %(Force a, double  b) => new Force(a.Newtons % b);
public static Force operator %(double  a, Force b) => new Force(a % b.Newtons);
public static Force operator -(Force a) => new Force(- a.Newtons);
public static bool operator <(Force a, Force b) => a.Newtons < b.Newtons;
public static bool operator <=(Force a, Force b) => a.Newtons <= b.Newtons;
public static bool operator >(Force a, Force b) => a.Newtons > b.Newtons;
public static bool operator >=(Force a, Force b) => a.Newtons >= b.Newtons;
public int CompareTo(Force other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Force self, Force other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Force> self, IArray<Force> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Force a, Force b) => a < b;
public static IArray<bool> LessThan(this IArray<Force> self, IArray<Force> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Force a, Force b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Force> self, IArray<Force> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Force a, Force b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Force> self, IArray<Force> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Force a, Force b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Force> self, IArray<Force> other) => self.Zip(other, (a,b) => a >= b);
public static Force Default(this Force _) => default(Force);
public static Force Zero(this Force _) => Force.Zero;
public static Force One(this Force _) => Force.One;
public static double ToDouble(this Force self) => self;
public static Force MinValue(this Force _) => Force.MinValue;
public static Force MaxValue(this Force _) => Force.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Pressure
{
public Pressure(double pascals) => (Pascals) = (pascals);
public static Pressure Create(double pascals) => new Pressure(pascals);
public const string Units = nameof(Pascals);
public double Pascals { get; }
public static implicit operator Pressure(double value) => new Pressure(value);
public static implicit operator double(Pressure value) => value.Pascals;
public override string ToString() => $"{{ \"Pascals\" : { Pascals } }}";
public override bool Equals(object other) => other is Pressure typedOther && this == typedOther;
public override int GetHashCode() => (Pascals).GetHashCode();
public static readonly Pressure Default = default;
public static Pressure Zero = new Pressure(Default.Pascals.Zero());
public static Pressure One = new Pressure(Default.Pascals.One());
public static Pressure MinValue = new Pressure(Default.Pascals.MinValue());
public static Pressure MaxValue = new Pressure(Default.Pascals.MaxValue());
public static bool operator ==(Pressure a, Pressure b) => (a.Pascals == b.Pascals);
public static bool operator !=(Pressure a, Pressure b) => (a.Pascals != b.Pascals);
public Pressure WithPascals(double value) => new Pressure(value);
public static Pressure operator +(Pressure a, Pressure b) => new Pressure(a.Pascals + b.Pascals);
public static Pressure operator +(double a, Pressure b) => new Pressure(a + b.Pascals);
public static Pressure operator +(Pressure a, double b) => new Pressure(a.Pascals + b);
public static Pressure operator -(Pressure a, Pressure b) => new Pressure(a.Pascals - b.Pascals);
public static Pressure operator -(double a, Pressure b) => new Pressure(a - b.Pascals);
public static Pressure operator -(Pressure a, double b) => new Pressure(a.Pascals - b);
public static Pressure operator *(Pressure a, double  b) => new Pressure(a.Pascals * b);
public static Pressure operator *(double  a, Pressure b) => new Pressure(a * b.Pascals);
public static Pressure operator /(Pressure a, double  b) => new Pressure(a.Pascals / b);
public static Pressure operator /(double  a, Pressure b) => new Pressure(a / b.Pascals);
public static Pressure operator %(Pressure a, double  b) => new Pressure(a.Pascals % b);
public static Pressure operator %(double  a, Pressure b) => new Pressure(a % b.Pascals);
public static Pressure operator -(Pressure a) => new Pressure(- a.Pascals);
public static bool operator <(Pressure a, Pressure b) => a.Pascals < b.Pascals;
public static bool operator <=(Pressure a, Pressure b) => a.Pascals <= b.Pascals;
public static bool operator >(Pressure a, Pressure b) => a.Pascals > b.Pascals;
public static bool operator >=(Pressure a, Pressure b) => a.Pascals >= b.Pascals;
public int CompareTo(Pressure other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Pressure self, Pressure other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Pressure> self, IArray<Pressure> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Pressure a, Pressure b) => a < b;
public static IArray<bool> LessThan(this IArray<Pressure> self, IArray<Pressure> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Pressure a, Pressure b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Pressure> self, IArray<Pressure> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Pressure a, Pressure b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Pressure> self, IArray<Pressure> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Pressure a, Pressure b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Pressure> self, IArray<Pressure> other) => self.Zip(other, (a,b) => a >= b);
public static Pressure Default(this Pressure _) => default(Pressure);
public static Pressure Zero(this Pressure _) => Pressure.Zero;
public static Pressure One(this Pressure _) => Pressure.One;
public static double ToDouble(this Pressure self) => self;
public static Pressure MinValue(this Pressure _) => Pressure.MinValue;
public static Pressure MaxValue(this Pressure _) => Pressure.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Energy
{
public Energy(double joules) => (Joules) = (joules);
public static Energy Create(double joules) => new Energy(joules);
public const string Units = nameof(Joules);
public double Joules { get; }
public static implicit operator Energy(double value) => new Energy(value);
public static implicit operator double(Energy value) => value.Joules;
public override string ToString() => $"{{ \"Joules\" : { Joules } }}";
public override bool Equals(object other) => other is Energy typedOther && this == typedOther;
public override int GetHashCode() => (Joules).GetHashCode();
public static readonly Energy Default = default;
public static Energy Zero = new Energy(Default.Joules.Zero());
public static Energy One = new Energy(Default.Joules.One());
public static Energy MinValue = new Energy(Default.Joules.MinValue());
public static Energy MaxValue = new Energy(Default.Joules.MaxValue());
public static bool operator ==(Energy a, Energy b) => (a.Joules == b.Joules);
public static bool operator !=(Energy a, Energy b) => (a.Joules != b.Joules);
public Energy WithJoules(double value) => new Energy(value);
public static Energy operator +(Energy a, Energy b) => new Energy(a.Joules + b.Joules);
public static Energy operator +(double a, Energy b) => new Energy(a + b.Joules);
public static Energy operator +(Energy a, double b) => new Energy(a.Joules + b);
public static Energy operator -(Energy a, Energy b) => new Energy(a.Joules - b.Joules);
public static Energy operator -(double a, Energy b) => new Energy(a - b.Joules);
public static Energy operator -(Energy a, double b) => new Energy(a.Joules - b);
public static Energy operator *(Energy a, double  b) => new Energy(a.Joules * b);
public static Energy operator *(double  a, Energy b) => new Energy(a * b.Joules);
public static Energy operator /(Energy a, double  b) => new Energy(a.Joules / b);
public static Energy operator /(double  a, Energy b) => new Energy(a / b.Joules);
public static Energy operator %(Energy a, double  b) => new Energy(a.Joules % b);
public static Energy operator %(double  a, Energy b) => new Energy(a % b.Joules);
public static Energy operator -(Energy a) => new Energy(- a.Joules);
public static bool operator <(Energy a, Energy b) => a.Joules < b.Joules;
public static bool operator <=(Energy a, Energy b) => a.Joules <= b.Joules;
public static bool operator >(Energy a, Energy b) => a.Joules > b.Joules;
public static bool operator >=(Energy a, Energy b) => a.Joules >= b.Joules;
public int CompareTo(Energy other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Energy self, Energy other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Energy> self, IArray<Energy> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Energy a, Energy b) => a < b;
public static IArray<bool> LessThan(this IArray<Energy> self, IArray<Energy> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Energy a, Energy b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Energy> self, IArray<Energy> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Energy a, Energy b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Energy> self, IArray<Energy> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Energy a, Energy b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Energy> self, IArray<Energy> other) => self.Zip(other, (a,b) => a >= b);
public static Energy Default(this Energy _) => default(Energy);
public static Energy Zero(this Energy _) => Energy.Zero;
public static Energy One(this Energy _) => Energy.One;
public static double ToDouble(this Energy self) => self;
public static Energy MinValue(this Energy _) => Energy.MinValue;
public static Energy MaxValue(this Energy _) => Energy.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Memory
{
public Memory(double bytes) => (Bytes) = (bytes);
public static Memory Create(double bytes) => new Memory(bytes);
public const string Units = nameof(Bytes);
public double Bytes { get; }
public static implicit operator Memory(double value) => new Memory(value);
public static implicit operator double(Memory value) => value.Bytes;
public override string ToString() => $"{{ \"Bytes\" : { Bytes } }}";
public override bool Equals(object other) => other is Memory typedOther && this == typedOther;
public override int GetHashCode() => (Bytes).GetHashCode();
public static readonly Memory Default = default;
public static Memory Zero = new Memory(Default.Bytes.Zero());
public static Memory One = new Memory(Default.Bytes.One());
public static Memory MinValue = new Memory(Default.Bytes.MinValue());
public static Memory MaxValue = new Memory(Default.Bytes.MaxValue());
public static bool operator ==(Memory a, Memory b) => (a.Bytes == b.Bytes);
public static bool operator !=(Memory a, Memory b) => (a.Bytes != b.Bytes);
public Memory WithBytes(double value) => new Memory(value);
public static Memory operator +(Memory a, Memory b) => new Memory(a.Bytes + b.Bytes);
public static Memory operator +(double a, Memory b) => new Memory(a + b.Bytes);
public static Memory operator +(Memory a, double b) => new Memory(a.Bytes + b);
public static Memory operator -(Memory a, Memory b) => new Memory(a.Bytes - b.Bytes);
public static Memory operator -(double a, Memory b) => new Memory(a - b.Bytes);
public static Memory operator -(Memory a, double b) => new Memory(a.Bytes - b);
public static Memory operator *(Memory a, double  b) => new Memory(a.Bytes * b);
public static Memory operator *(double  a, Memory b) => new Memory(a * b.Bytes);
public static Memory operator /(Memory a, double  b) => new Memory(a.Bytes / b);
public static Memory operator /(double  a, Memory b) => new Memory(a / b.Bytes);
public static Memory operator %(Memory a, double  b) => new Memory(a.Bytes % b);
public static Memory operator %(double  a, Memory b) => new Memory(a % b.Bytes);
public static Memory operator -(Memory a) => new Memory(- a.Bytes);
public static bool operator <(Memory a, Memory b) => a.Bytes < b.Bytes;
public static bool operator <=(Memory a, Memory b) => a.Bytes <= b.Bytes;
public static bool operator >(Memory a, Memory b) => a.Bytes > b.Bytes;
public static bool operator >=(Memory a, Memory b) => a.Bytes >= b.Bytes;
public int CompareTo(Memory other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Memory self, Memory other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Memory> self, IArray<Memory> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Memory a, Memory b) => a < b;
public static IArray<bool> LessThan(this IArray<Memory> self, IArray<Memory> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Memory a, Memory b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Memory> self, IArray<Memory> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Memory a, Memory b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Memory> self, IArray<Memory> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Memory a, Memory b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Memory> self, IArray<Memory> other) => self.Zip(other, (a,b) => a >= b);
public static Memory Default(this Memory _) => default(Memory);
public static Memory Zero(this Memory _) => Memory.Zero;
public static Memory One(this Memory _) => Memory.One;
public static double ToDouble(this Memory self) => self;
public static Memory MinValue(this Memory _) => Memory.MinValue;
public static Memory MaxValue(this Memory _) => Memory.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Frequency
{
public Frequency(double hertz) => (Hertz) = (hertz);
public static Frequency Create(double hertz) => new Frequency(hertz);
public const string Units = nameof(Hertz);
public double Hertz { get; }
public static implicit operator Frequency(double value) => new Frequency(value);
public static implicit operator double(Frequency value) => value.Hertz;
public override string ToString() => $"{{ \"Hertz\" : { Hertz } }}";
public override bool Equals(object other) => other is Frequency typedOther && this == typedOther;
public override int GetHashCode() => (Hertz).GetHashCode();
public static readonly Frequency Default = default;
public static Frequency Zero = new Frequency(Default.Hertz.Zero());
public static Frequency One = new Frequency(Default.Hertz.One());
public static Frequency MinValue = new Frequency(Default.Hertz.MinValue());
public static Frequency MaxValue = new Frequency(Default.Hertz.MaxValue());
public static bool operator ==(Frequency a, Frequency b) => (a.Hertz == b.Hertz);
public static bool operator !=(Frequency a, Frequency b) => (a.Hertz != b.Hertz);
public Frequency WithHertz(double value) => new Frequency(value);
public static Frequency operator +(Frequency a, Frequency b) => new Frequency(a.Hertz + b.Hertz);
public static Frequency operator +(double a, Frequency b) => new Frequency(a + b.Hertz);
public static Frequency operator +(Frequency a, double b) => new Frequency(a.Hertz + b);
public static Frequency operator -(Frequency a, Frequency b) => new Frequency(a.Hertz - b.Hertz);
public static Frequency operator -(double a, Frequency b) => new Frequency(a - b.Hertz);
public static Frequency operator -(Frequency a, double b) => new Frequency(a.Hertz - b);
public static Frequency operator *(Frequency a, double  b) => new Frequency(a.Hertz * b);
public static Frequency operator *(double  a, Frequency b) => new Frequency(a * b.Hertz);
public static Frequency operator /(Frequency a, double  b) => new Frequency(a.Hertz / b);
public static Frequency operator /(double  a, Frequency b) => new Frequency(a / b.Hertz);
public static Frequency operator %(Frequency a, double  b) => new Frequency(a.Hertz % b);
public static Frequency operator %(double  a, Frequency b) => new Frequency(a % b.Hertz);
public static Frequency operator -(Frequency a) => new Frequency(- a.Hertz);
public static bool operator <(Frequency a, Frequency b) => a.Hertz < b.Hertz;
public static bool operator <=(Frequency a, Frequency b) => a.Hertz <= b.Hertz;
public static bool operator >(Frequency a, Frequency b) => a.Hertz > b.Hertz;
public static bool operator >=(Frequency a, Frequency b) => a.Hertz >= b.Hertz;
public int CompareTo(Frequency other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Frequency self, Frequency other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Frequency> self, IArray<Frequency> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Frequency a, Frequency b) => a < b;
public static IArray<bool> LessThan(this IArray<Frequency> self, IArray<Frequency> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Frequency a, Frequency b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Frequency> self, IArray<Frequency> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Frequency a, Frequency b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Frequency> self, IArray<Frequency> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Frequency a, Frequency b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Frequency> self, IArray<Frequency> other) => self.Zip(other, (a,b) => a >= b);
public static Frequency Default(this Frequency _) => default(Frequency);
public static Frequency Zero(this Frequency _) => Frequency.Zero;
public static Frequency One(this Frequency _) => Frequency.One;
public static double ToDouble(this Frequency self) => self;
public static Frequency MinValue(this Frequency _) => Frequency.MinValue;
public static Frequency MaxValue(this Frequency _) => Frequency.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Loudness
{
public Loudness(double decibels) => (Decibels) = (decibels);
public static Loudness Create(double decibels) => new Loudness(decibels);
public const string Units = nameof(Decibels);
public double Decibels { get; }
public static implicit operator Loudness(double value) => new Loudness(value);
public static implicit operator double(Loudness value) => value.Decibels;
public override string ToString() => $"{{ \"Decibels\" : { Decibels } }}";
public override bool Equals(object other) => other is Loudness typedOther && this == typedOther;
public override int GetHashCode() => (Decibels).GetHashCode();
public static readonly Loudness Default = default;
public static Loudness Zero = new Loudness(Default.Decibels.Zero());
public static Loudness One = new Loudness(Default.Decibels.One());
public static Loudness MinValue = new Loudness(Default.Decibels.MinValue());
public static Loudness MaxValue = new Loudness(Default.Decibels.MaxValue());
public static bool operator ==(Loudness a, Loudness b) => (a.Decibels == b.Decibels);
public static bool operator !=(Loudness a, Loudness b) => (a.Decibels != b.Decibels);
public Loudness WithDecibels(double value) => new Loudness(value);
public static Loudness operator +(Loudness a, Loudness b) => new Loudness(a.Decibels + b.Decibels);
public static Loudness operator +(double a, Loudness b) => new Loudness(a + b.Decibels);
public static Loudness operator +(Loudness a, double b) => new Loudness(a.Decibels + b);
public static Loudness operator -(Loudness a, Loudness b) => new Loudness(a.Decibels - b.Decibels);
public static Loudness operator -(double a, Loudness b) => new Loudness(a - b.Decibels);
public static Loudness operator -(Loudness a, double b) => new Loudness(a.Decibels - b);
public static Loudness operator *(Loudness a, double  b) => new Loudness(a.Decibels * b);
public static Loudness operator *(double  a, Loudness b) => new Loudness(a * b.Decibels);
public static Loudness operator /(Loudness a, double  b) => new Loudness(a.Decibels / b);
public static Loudness operator /(double  a, Loudness b) => new Loudness(a / b.Decibels);
public static Loudness operator %(Loudness a, double  b) => new Loudness(a.Decibels % b);
public static Loudness operator %(double  a, Loudness b) => new Loudness(a % b.Decibels);
public static Loudness operator -(Loudness a) => new Loudness(- a.Decibels);
public static bool operator <(Loudness a, Loudness b) => a.Decibels < b.Decibels;
public static bool operator <=(Loudness a, Loudness b) => a.Decibels <= b.Decibels;
public static bool operator >(Loudness a, Loudness b) => a.Decibels > b.Decibels;
public static bool operator >=(Loudness a, Loudness b) => a.Decibels >= b.Decibels;
public int CompareTo(Loudness other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Loudness self, Loudness other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Loudness> self, IArray<Loudness> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Loudness a, Loudness b) => a < b;
public static IArray<bool> LessThan(this IArray<Loudness> self, IArray<Loudness> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Loudness a, Loudness b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Loudness> self, IArray<Loudness> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Loudness a, Loudness b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Loudness> self, IArray<Loudness> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Loudness a, Loudness b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Loudness> self, IArray<Loudness> other) => self.Zip(other, (a,b) => a >= b);
public static Loudness Default(this Loudness _) => default(Loudness);
public static Loudness Zero(this Loudness _) => Loudness.Zero;
public static Loudness One(this Loudness _) => Loudness.One;
public static double ToDouble(this Loudness self) => self;
public static Loudness MinValue(this Loudness _) => Loudness.MinValue;
public static Loudness MaxValue(this Loudness _) => Loudness.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct LuminousIntensity
{
public LuminousIntensity(double candelas) => (Candelas) = (candelas);
public static LuminousIntensity Create(double candelas) => new LuminousIntensity(candelas);
public const string Units = nameof(Candelas);
public double Candelas { get; }
public static implicit operator LuminousIntensity(double value) => new LuminousIntensity(value);
public static implicit operator double(LuminousIntensity value) => value.Candelas;
public override string ToString() => $"{{ \"Candelas\" : { Candelas } }}";
public override bool Equals(object other) => other is LuminousIntensity typedOther && this == typedOther;
public override int GetHashCode() => (Candelas).GetHashCode();
public static readonly LuminousIntensity Default = default;
public static LuminousIntensity Zero = new LuminousIntensity(Default.Candelas.Zero());
public static LuminousIntensity One = new LuminousIntensity(Default.Candelas.One());
public static LuminousIntensity MinValue = new LuminousIntensity(Default.Candelas.MinValue());
public static LuminousIntensity MaxValue = new LuminousIntensity(Default.Candelas.MaxValue());
public static bool operator ==(LuminousIntensity a, LuminousIntensity b) => (a.Candelas == b.Candelas);
public static bool operator !=(LuminousIntensity a, LuminousIntensity b) => (a.Candelas != b.Candelas);
public LuminousIntensity WithCandelas(double value) => new LuminousIntensity(value);
public static LuminousIntensity operator +(LuminousIntensity a, LuminousIntensity b) => new LuminousIntensity(a.Candelas + b.Candelas);
public static LuminousIntensity operator +(double a, LuminousIntensity b) => new LuminousIntensity(a + b.Candelas);
public static LuminousIntensity operator +(LuminousIntensity a, double b) => new LuminousIntensity(a.Candelas + b);
public static LuminousIntensity operator -(LuminousIntensity a, LuminousIntensity b) => new LuminousIntensity(a.Candelas - b.Candelas);
public static LuminousIntensity operator -(double a, LuminousIntensity b) => new LuminousIntensity(a - b.Candelas);
public static LuminousIntensity operator -(LuminousIntensity a, double b) => new LuminousIntensity(a.Candelas - b);
public static LuminousIntensity operator *(LuminousIntensity a, double  b) => new LuminousIntensity(a.Candelas * b);
public static LuminousIntensity operator *(double  a, LuminousIntensity b) => new LuminousIntensity(a * b.Candelas);
public static LuminousIntensity operator /(LuminousIntensity a, double  b) => new LuminousIntensity(a.Candelas / b);
public static LuminousIntensity operator /(double  a, LuminousIntensity b) => new LuminousIntensity(a / b.Candelas);
public static LuminousIntensity operator %(LuminousIntensity a, double  b) => new LuminousIntensity(a.Candelas % b);
public static LuminousIntensity operator %(double  a, LuminousIntensity b) => new LuminousIntensity(a % b.Candelas);
public static LuminousIntensity operator -(LuminousIntensity a) => new LuminousIntensity(- a.Candelas);
public static bool operator <(LuminousIntensity a, LuminousIntensity b) => a.Candelas < b.Candelas;
public static bool operator <=(LuminousIntensity a, LuminousIntensity b) => a.Candelas <= b.Candelas;
public static bool operator >(LuminousIntensity a, LuminousIntensity b) => a.Candelas > b.Candelas;
public static bool operator >=(LuminousIntensity a, LuminousIntensity b) => a.Candelas >= b.Candelas;
public int CompareTo(LuminousIntensity other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this LuminousIntensity self, LuminousIntensity other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<LuminousIntensity> self, IArray<LuminousIntensity> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this LuminousIntensity a, LuminousIntensity b) => a < b;
public static IArray<bool> LessThan(this IArray<LuminousIntensity> self, IArray<LuminousIntensity> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this LuminousIntensity a, LuminousIntensity b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<LuminousIntensity> self, IArray<LuminousIntensity> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this LuminousIntensity a, LuminousIntensity b) => a > b;
public static IArray<bool> GreaterThan(this IArray<LuminousIntensity> self, IArray<LuminousIntensity> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this LuminousIntensity a, LuminousIntensity b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<LuminousIntensity> self, IArray<LuminousIntensity> other) => self.Zip(other, (a,b) => a >= b);
public static LuminousIntensity Default(this LuminousIntensity _) => default(LuminousIntensity);
public static LuminousIntensity Zero(this LuminousIntensity _) => LuminousIntensity.Zero;
public static LuminousIntensity One(this LuminousIntensity _) => LuminousIntensity.One;
public static double ToDouble(this LuminousIntensity self) => self;
public static LuminousIntensity MinValue(this LuminousIntensity _) => LuminousIntensity.MinValue;
public static LuminousIntensity MaxValue(this LuminousIntensity _) => LuminousIntensity.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ElectricPotential
{
public ElectricPotential(double volts) => (Volts) = (volts);
public static ElectricPotential Create(double volts) => new ElectricPotential(volts);
public const string Units = nameof(Volts);
public double Volts { get; }
public static implicit operator ElectricPotential(double value) => new ElectricPotential(value);
public static implicit operator double(ElectricPotential value) => value.Volts;
public override string ToString() => $"{{ \"Volts\" : { Volts } }}";
public override bool Equals(object other) => other is ElectricPotential typedOther && this == typedOther;
public override int GetHashCode() => (Volts).GetHashCode();
public static readonly ElectricPotential Default = default;
public static ElectricPotential Zero = new ElectricPotential(Default.Volts.Zero());
public static ElectricPotential One = new ElectricPotential(Default.Volts.One());
public static ElectricPotential MinValue = new ElectricPotential(Default.Volts.MinValue());
public static ElectricPotential MaxValue = new ElectricPotential(Default.Volts.MaxValue());
public static bool operator ==(ElectricPotential a, ElectricPotential b) => (a.Volts == b.Volts);
public static bool operator !=(ElectricPotential a, ElectricPotential b) => (a.Volts != b.Volts);
public ElectricPotential WithVolts(double value) => new ElectricPotential(value);
public static ElectricPotential operator +(ElectricPotential a, ElectricPotential b) => new ElectricPotential(a.Volts + b.Volts);
public static ElectricPotential operator +(double a, ElectricPotential b) => new ElectricPotential(a + b.Volts);
public static ElectricPotential operator +(ElectricPotential a, double b) => new ElectricPotential(a.Volts + b);
public static ElectricPotential operator -(ElectricPotential a, ElectricPotential b) => new ElectricPotential(a.Volts - b.Volts);
public static ElectricPotential operator -(double a, ElectricPotential b) => new ElectricPotential(a - b.Volts);
public static ElectricPotential operator -(ElectricPotential a, double b) => new ElectricPotential(a.Volts - b);
public static ElectricPotential operator *(ElectricPotential a, double  b) => new ElectricPotential(a.Volts * b);
public static ElectricPotential operator *(double  a, ElectricPotential b) => new ElectricPotential(a * b.Volts);
public static ElectricPotential operator /(ElectricPotential a, double  b) => new ElectricPotential(a.Volts / b);
public static ElectricPotential operator /(double  a, ElectricPotential b) => new ElectricPotential(a / b.Volts);
public static ElectricPotential operator %(ElectricPotential a, double  b) => new ElectricPotential(a.Volts % b);
public static ElectricPotential operator %(double  a, ElectricPotential b) => new ElectricPotential(a % b.Volts);
public static ElectricPotential operator -(ElectricPotential a) => new ElectricPotential(- a.Volts);
public static bool operator <(ElectricPotential a, ElectricPotential b) => a.Volts < b.Volts;
public static bool operator <=(ElectricPotential a, ElectricPotential b) => a.Volts <= b.Volts;
public static bool operator >(ElectricPotential a, ElectricPotential b) => a.Volts > b.Volts;
public static bool operator >=(ElectricPotential a, ElectricPotential b) => a.Volts >= b.Volts;
public int CompareTo(ElectricPotential other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this ElectricPotential self, ElectricPotential other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<ElectricPotential> self, IArray<ElectricPotential> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this ElectricPotential a, ElectricPotential b) => a < b;
public static IArray<bool> LessThan(this IArray<ElectricPotential> self, IArray<ElectricPotential> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this ElectricPotential a, ElectricPotential b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<ElectricPotential> self, IArray<ElectricPotential> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this ElectricPotential a, ElectricPotential b) => a > b;
public static IArray<bool> GreaterThan(this IArray<ElectricPotential> self, IArray<ElectricPotential> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this ElectricPotential a, ElectricPotential b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<ElectricPotential> self, IArray<ElectricPotential> other) => self.Zip(other, (a,b) => a >= b);
public static ElectricPotential Default(this ElectricPotential _) => default(ElectricPotential);
public static ElectricPotential Zero(this ElectricPotential _) => ElectricPotential.Zero;
public static ElectricPotential One(this ElectricPotential _) => ElectricPotential.One;
public static double ToDouble(this ElectricPotential self) => self;
public static ElectricPotential MinValue(this ElectricPotential _) => ElectricPotential.MinValue;
public static ElectricPotential MaxValue(this ElectricPotential _) => ElectricPotential.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ElectricCharge
{
public ElectricCharge(double columbs) => (Columbs) = (columbs);
public static ElectricCharge Create(double columbs) => new ElectricCharge(columbs);
public const string Units = nameof(Columbs);
public double Columbs { get; }
public static implicit operator ElectricCharge(double value) => new ElectricCharge(value);
public static implicit operator double(ElectricCharge value) => value.Columbs;
public override string ToString() => $"{{ \"Columbs\" : { Columbs } }}";
public override bool Equals(object other) => other is ElectricCharge typedOther && this == typedOther;
public override int GetHashCode() => (Columbs).GetHashCode();
public static readonly ElectricCharge Default = default;
public static ElectricCharge Zero = new ElectricCharge(Default.Columbs.Zero());
public static ElectricCharge One = new ElectricCharge(Default.Columbs.One());
public static ElectricCharge MinValue = new ElectricCharge(Default.Columbs.MinValue());
public static ElectricCharge MaxValue = new ElectricCharge(Default.Columbs.MaxValue());
public static bool operator ==(ElectricCharge a, ElectricCharge b) => (a.Columbs == b.Columbs);
public static bool operator !=(ElectricCharge a, ElectricCharge b) => (a.Columbs != b.Columbs);
public ElectricCharge WithColumbs(double value) => new ElectricCharge(value);
public static ElectricCharge operator +(ElectricCharge a, ElectricCharge b) => new ElectricCharge(a.Columbs + b.Columbs);
public static ElectricCharge operator +(double a, ElectricCharge b) => new ElectricCharge(a + b.Columbs);
public static ElectricCharge operator +(ElectricCharge a, double b) => new ElectricCharge(a.Columbs + b);
public static ElectricCharge operator -(ElectricCharge a, ElectricCharge b) => new ElectricCharge(a.Columbs - b.Columbs);
public static ElectricCharge operator -(double a, ElectricCharge b) => new ElectricCharge(a - b.Columbs);
public static ElectricCharge operator -(ElectricCharge a, double b) => new ElectricCharge(a.Columbs - b);
public static ElectricCharge operator *(ElectricCharge a, double  b) => new ElectricCharge(a.Columbs * b);
public static ElectricCharge operator *(double  a, ElectricCharge b) => new ElectricCharge(a * b.Columbs);
public static ElectricCharge operator /(ElectricCharge a, double  b) => new ElectricCharge(a.Columbs / b);
public static ElectricCharge operator /(double  a, ElectricCharge b) => new ElectricCharge(a / b.Columbs);
public static ElectricCharge operator %(ElectricCharge a, double  b) => new ElectricCharge(a.Columbs % b);
public static ElectricCharge operator %(double  a, ElectricCharge b) => new ElectricCharge(a % b.Columbs);
public static ElectricCharge operator -(ElectricCharge a) => new ElectricCharge(- a.Columbs);
public static bool operator <(ElectricCharge a, ElectricCharge b) => a.Columbs < b.Columbs;
public static bool operator <=(ElectricCharge a, ElectricCharge b) => a.Columbs <= b.Columbs;
public static bool operator >(ElectricCharge a, ElectricCharge b) => a.Columbs > b.Columbs;
public static bool operator >=(ElectricCharge a, ElectricCharge b) => a.Columbs >= b.Columbs;
public int CompareTo(ElectricCharge other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this ElectricCharge self, ElectricCharge other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<ElectricCharge> self, IArray<ElectricCharge> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this ElectricCharge a, ElectricCharge b) => a < b;
public static IArray<bool> LessThan(this IArray<ElectricCharge> self, IArray<ElectricCharge> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this ElectricCharge a, ElectricCharge b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<ElectricCharge> self, IArray<ElectricCharge> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this ElectricCharge a, ElectricCharge b) => a > b;
public static IArray<bool> GreaterThan(this IArray<ElectricCharge> self, IArray<ElectricCharge> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this ElectricCharge a, ElectricCharge b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<ElectricCharge> self, IArray<ElectricCharge> other) => self.Zip(other, (a,b) => a >= b);
public static ElectricCharge Default(this ElectricCharge _) => default(ElectricCharge);
public static ElectricCharge Zero(this ElectricCharge _) => ElectricCharge.Zero;
public static ElectricCharge One(this ElectricCharge _) => ElectricCharge.One;
public static double ToDouble(this ElectricCharge self) => self;
public static ElectricCharge MinValue(this ElectricCharge _) => ElectricCharge.MinValue;
public static ElectricCharge MaxValue(this ElectricCharge _) => ElectricCharge.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ElectricCurrent
{
public ElectricCurrent(double amperes) => (Amperes) = (amperes);
public static ElectricCurrent Create(double amperes) => new ElectricCurrent(amperes);
public const string Units = nameof(Amperes);
public double Amperes { get; }
public static implicit operator ElectricCurrent(double value) => new ElectricCurrent(value);
public static implicit operator double(ElectricCurrent value) => value.Amperes;
public override string ToString() => $"{{ \"Amperes\" : { Amperes } }}";
public override bool Equals(object other) => other is ElectricCurrent typedOther && this == typedOther;
public override int GetHashCode() => (Amperes).GetHashCode();
public static readonly ElectricCurrent Default = default;
public static ElectricCurrent Zero = new ElectricCurrent(Default.Amperes.Zero());
public static ElectricCurrent One = new ElectricCurrent(Default.Amperes.One());
public static ElectricCurrent MinValue = new ElectricCurrent(Default.Amperes.MinValue());
public static ElectricCurrent MaxValue = new ElectricCurrent(Default.Amperes.MaxValue());
public static bool operator ==(ElectricCurrent a, ElectricCurrent b) => (a.Amperes == b.Amperes);
public static bool operator !=(ElectricCurrent a, ElectricCurrent b) => (a.Amperes != b.Amperes);
public ElectricCurrent WithAmperes(double value) => new ElectricCurrent(value);
public static ElectricCurrent operator +(ElectricCurrent a, ElectricCurrent b) => new ElectricCurrent(a.Amperes + b.Amperes);
public static ElectricCurrent operator +(double a, ElectricCurrent b) => new ElectricCurrent(a + b.Amperes);
public static ElectricCurrent operator +(ElectricCurrent a, double b) => new ElectricCurrent(a.Amperes + b);
public static ElectricCurrent operator -(ElectricCurrent a, ElectricCurrent b) => new ElectricCurrent(a.Amperes - b.Amperes);
public static ElectricCurrent operator -(double a, ElectricCurrent b) => new ElectricCurrent(a - b.Amperes);
public static ElectricCurrent operator -(ElectricCurrent a, double b) => new ElectricCurrent(a.Amperes - b);
public static ElectricCurrent operator *(ElectricCurrent a, double  b) => new ElectricCurrent(a.Amperes * b);
public static ElectricCurrent operator *(double  a, ElectricCurrent b) => new ElectricCurrent(a * b.Amperes);
public static ElectricCurrent operator /(ElectricCurrent a, double  b) => new ElectricCurrent(a.Amperes / b);
public static ElectricCurrent operator /(double  a, ElectricCurrent b) => new ElectricCurrent(a / b.Amperes);
public static ElectricCurrent operator %(ElectricCurrent a, double  b) => new ElectricCurrent(a.Amperes % b);
public static ElectricCurrent operator %(double  a, ElectricCurrent b) => new ElectricCurrent(a % b.Amperes);
public static ElectricCurrent operator -(ElectricCurrent a) => new ElectricCurrent(- a.Amperes);
public static bool operator <(ElectricCurrent a, ElectricCurrent b) => a.Amperes < b.Amperes;
public static bool operator <=(ElectricCurrent a, ElectricCurrent b) => a.Amperes <= b.Amperes;
public static bool operator >(ElectricCurrent a, ElectricCurrent b) => a.Amperes > b.Amperes;
public static bool operator >=(ElectricCurrent a, ElectricCurrent b) => a.Amperes >= b.Amperes;
public int CompareTo(ElectricCurrent other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this ElectricCurrent self, ElectricCurrent other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<ElectricCurrent> self, IArray<ElectricCurrent> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this ElectricCurrent a, ElectricCurrent b) => a < b;
public static IArray<bool> LessThan(this IArray<ElectricCurrent> self, IArray<ElectricCurrent> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this ElectricCurrent a, ElectricCurrent b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<ElectricCurrent> self, IArray<ElectricCurrent> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this ElectricCurrent a, ElectricCurrent b) => a > b;
public static IArray<bool> GreaterThan(this IArray<ElectricCurrent> self, IArray<ElectricCurrent> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this ElectricCurrent a, ElectricCurrent b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<ElectricCurrent> self, IArray<ElectricCurrent> other) => self.Zip(other, (a,b) => a >= b);
public static ElectricCurrent Default(this ElectricCurrent _) => default(ElectricCurrent);
public static ElectricCurrent Zero(this ElectricCurrent _) => ElectricCurrent.Zero;
public static ElectricCurrent One(this ElectricCurrent _) => ElectricCurrent.One;
public static double ToDouble(this ElectricCurrent self) => self;
public static ElectricCurrent MinValue(this ElectricCurrent _) => ElectricCurrent.MinValue;
public static ElectricCurrent MaxValue(this ElectricCurrent _) => ElectricCurrent.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ElectricResistance
{
public ElectricResistance(double ohms) => (Ohms) = (ohms);
public static ElectricResistance Create(double ohms) => new ElectricResistance(ohms);
public const string Units = nameof(Ohms);
public double Ohms { get; }
public static implicit operator ElectricResistance(double value) => new ElectricResistance(value);
public static implicit operator double(ElectricResistance value) => value.Ohms;
public override string ToString() => $"{{ \"Ohms\" : { Ohms } }}";
public override bool Equals(object other) => other is ElectricResistance typedOther && this == typedOther;
public override int GetHashCode() => (Ohms).GetHashCode();
public static readonly ElectricResistance Default = default;
public static ElectricResistance Zero = new ElectricResistance(Default.Ohms.Zero());
public static ElectricResistance One = new ElectricResistance(Default.Ohms.One());
public static ElectricResistance MinValue = new ElectricResistance(Default.Ohms.MinValue());
public static ElectricResistance MaxValue = new ElectricResistance(Default.Ohms.MaxValue());
public static bool operator ==(ElectricResistance a, ElectricResistance b) => (a.Ohms == b.Ohms);
public static bool operator !=(ElectricResistance a, ElectricResistance b) => (a.Ohms != b.Ohms);
public ElectricResistance WithOhms(double value) => new ElectricResistance(value);
public static ElectricResistance operator +(ElectricResistance a, ElectricResistance b) => new ElectricResistance(a.Ohms + b.Ohms);
public static ElectricResistance operator +(double a, ElectricResistance b) => new ElectricResistance(a + b.Ohms);
public static ElectricResistance operator +(ElectricResistance a, double b) => new ElectricResistance(a.Ohms + b);
public static ElectricResistance operator -(ElectricResistance a, ElectricResistance b) => new ElectricResistance(a.Ohms - b.Ohms);
public static ElectricResistance operator -(double a, ElectricResistance b) => new ElectricResistance(a - b.Ohms);
public static ElectricResistance operator -(ElectricResistance a, double b) => new ElectricResistance(a.Ohms - b);
public static ElectricResistance operator *(ElectricResistance a, double  b) => new ElectricResistance(a.Ohms * b);
public static ElectricResistance operator *(double  a, ElectricResistance b) => new ElectricResistance(a * b.Ohms);
public static ElectricResistance operator /(ElectricResistance a, double  b) => new ElectricResistance(a.Ohms / b);
public static ElectricResistance operator /(double  a, ElectricResistance b) => new ElectricResistance(a / b.Ohms);
public static ElectricResistance operator %(ElectricResistance a, double  b) => new ElectricResistance(a.Ohms % b);
public static ElectricResistance operator %(double  a, ElectricResistance b) => new ElectricResistance(a % b.Ohms);
public static ElectricResistance operator -(ElectricResistance a) => new ElectricResistance(- a.Ohms);
public static bool operator <(ElectricResistance a, ElectricResistance b) => a.Ohms < b.Ohms;
public static bool operator <=(ElectricResistance a, ElectricResistance b) => a.Ohms <= b.Ohms;
public static bool operator >(ElectricResistance a, ElectricResistance b) => a.Ohms > b.Ohms;
public static bool operator >=(ElectricResistance a, ElectricResistance b) => a.Ohms >= b.Ohms;
public int CompareTo(ElectricResistance other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this ElectricResistance self, ElectricResistance other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<ElectricResistance> self, IArray<ElectricResistance> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this ElectricResistance a, ElectricResistance b) => a < b;
public static IArray<bool> LessThan(this IArray<ElectricResistance> self, IArray<ElectricResistance> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this ElectricResistance a, ElectricResistance b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<ElectricResistance> self, IArray<ElectricResistance> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this ElectricResistance a, ElectricResistance b) => a > b;
public static IArray<bool> GreaterThan(this IArray<ElectricResistance> self, IArray<ElectricResistance> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this ElectricResistance a, ElectricResistance b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<ElectricResistance> self, IArray<ElectricResistance> other) => self.Zip(other, (a,b) => a >= b);
public static ElectricResistance Default(this ElectricResistance _) => default(ElectricResistance);
public static ElectricResistance Zero(this ElectricResistance _) => ElectricResistance.Zero;
public static ElectricResistance One(this ElectricResistance _) => ElectricResistance.One;
public static double ToDouble(this ElectricResistance self) => self;
public static ElectricResistance MinValue(this ElectricResistance _) => ElectricResistance.MinValue;
public static ElectricResistance MaxValue(this ElectricResistance _) => ElectricResistance.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Power
{
public Power(double watts) => (Watts) = (watts);
public static Power Create(double watts) => new Power(watts);
public const string Units = nameof(Watts);
public double Watts { get; }
public static implicit operator Power(double value) => new Power(value);
public static implicit operator double(Power value) => value.Watts;
public override string ToString() => $"{{ \"Watts\" : { Watts } }}";
public override bool Equals(object other) => other is Power typedOther && this == typedOther;
public override int GetHashCode() => (Watts).GetHashCode();
public static readonly Power Default = default;
public static Power Zero = new Power(Default.Watts.Zero());
public static Power One = new Power(Default.Watts.One());
public static Power MinValue = new Power(Default.Watts.MinValue());
public static Power MaxValue = new Power(Default.Watts.MaxValue());
public static bool operator ==(Power a, Power b) => (a.Watts == b.Watts);
public static bool operator !=(Power a, Power b) => (a.Watts != b.Watts);
public Power WithWatts(double value) => new Power(value);
public static Power operator +(Power a, Power b) => new Power(a.Watts + b.Watts);
public static Power operator +(double a, Power b) => new Power(a + b.Watts);
public static Power operator +(Power a, double b) => new Power(a.Watts + b);
public static Power operator -(Power a, Power b) => new Power(a.Watts - b.Watts);
public static Power operator -(double a, Power b) => new Power(a - b.Watts);
public static Power operator -(Power a, double b) => new Power(a.Watts - b);
public static Power operator *(Power a, double  b) => new Power(a.Watts * b);
public static Power operator *(double  a, Power b) => new Power(a * b.Watts);
public static Power operator /(Power a, double  b) => new Power(a.Watts / b);
public static Power operator /(double  a, Power b) => new Power(a / b.Watts);
public static Power operator %(Power a, double  b) => new Power(a.Watts % b);
public static Power operator %(double  a, Power b) => new Power(a % b.Watts);
public static Power operator -(Power a) => new Power(- a.Watts);
public static bool operator <(Power a, Power b) => a.Watts < b.Watts;
public static bool operator <=(Power a, Power b) => a.Watts <= b.Watts;
public static bool operator >(Power a, Power b) => a.Watts > b.Watts;
public static bool operator >=(Power a, Power b) => a.Watts >= b.Watts;
public int CompareTo(Power other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Power self, Power other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Power> self, IArray<Power> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Power a, Power b) => a < b;
public static IArray<bool> LessThan(this IArray<Power> self, IArray<Power> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Power a, Power b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Power> self, IArray<Power> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Power a, Power b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Power> self, IArray<Power> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Power a, Power b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Power> self, IArray<Power> other) => self.Zip(other, (a,b) => a >= b);
public static Power Default(this Power _) => default(Power);
public static Power Zero(this Power _) => Power.Zero;
public static Power One(this Power _) => Power.One;
public static double ToDouble(this Power self) => self;
public static Power MinValue(this Power _) => Power.MinValue;
public static Power MaxValue(this Power _) => Power.MaxValue;
}
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Density
{
public Density(double kilogramspermetercubed) => (KilogramsPerMeterCubed) = (kilogramspermetercubed);
public static Density Create(double kilogramspermetercubed) => new Density(kilogramspermetercubed);
public const string Units = nameof(KilogramsPerMeterCubed);
public double KilogramsPerMeterCubed { get; }
public static implicit operator Density(double value) => new Density(value);
public static implicit operator double(Density value) => value.KilogramsPerMeterCubed;
public override string ToString() => $"{{ \"KilogramsPerMeterCubed\" : { KilogramsPerMeterCubed } }}";
public override bool Equals(object other) => other is Density typedOther && this == typedOther;
public override int GetHashCode() => (KilogramsPerMeterCubed).GetHashCode();
public static readonly Density Default = default;
public static Density Zero = new Density(Default.KilogramsPerMeterCubed.Zero());
public static Density One = new Density(Default.KilogramsPerMeterCubed.One());
public static Density MinValue = new Density(Default.KilogramsPerMeterCubed.MinValue());
public static Density MaxValue = new Density(Default.KilogramsPerMeterCubed.MaxValue());
public static bool operator ==(Density a, Density b) => (a.KilogramsPerMeterCubed == b.KilogramsPerMeterCubed);
public static bool operator !=(Density a, Density b) => (a.KilogramsPerMeterCubed != b.KilogramsPerMeterCubed);
public Density WithKilogramsPerMeterCubed(double value) => new Density(value);
public static Density operator +(Density a, Density b) => new Density(a.KilogramsPerMeterCubed + b.KilogramsPerMeterCubed);
public static Density operator +(double a, Density b) => new Density(a + b.KilogramsPerMeterCubed);
public static Density operator +(Density a, double b) => new Density(a.KilogramsPerMeterCubed + b);
public static Density operator -(Density a, Density b) => new Density(a.KilogramsPerMeterCubed - b.KilogramsPerMeterCubed);
public static Density operator -(double a, Density b) => new Density(a - b.KilogramsPerMeterCubed);
public static Density operator -(Density a, double b) => new Density(a.KilogramsPerMeterCubed - b);
public static Density operator *(Density a, double  b) => new Density(a.KilogramsPerMeterCubed * b);
public static Density operator *(double  a, Density b) => new Density(a * b.KilogramsPerMeterCubed);
public static Density operator /(Density a, double  b) => new Density(a.KilogramsPerMeterCubed / b);
public static Density operator /(double  a, Density b) => new Density(a / b.KilogramsPerMeterCubed);
public static Density operator %(Density a, double  b) => new Density(a.KilogramsPerMeterCubed % b);
public static Density operator %(double  a, Density b) => new Density(a % b.KilogramsPerMeterCubed);
public static Density operator -(Density a) => new Density(- a.KilogramsPerMeterCubed);
public static bool operator <(Density a, Density b) => a.KilogramsPerMeterCubed < b.KilogramsPerMeterCubed;
public static bool operator <=(Density a, Density b) => a.KilogramsPerMeterCubed <= b.KilogramsPerMeterCubed;
public static bool operator >(Density a, Density b) => a.KilogramsPerMeterCubed > b.KilogramsPerMeterCubed;
public static bool operator >=(Density a, Density b) => a.KilogramsPerMeterCubed >= b.KilogramsPerMeterCubed;
public int CompareTo(Density other) => this < other ? -1 : this > other ? 1 : 0;
}
public static partial class Intrinsics {
public static int CompareTo(this Density self, Density other) => self < other ? -1 : self > other ? 1 : 0;
public static IArray<int> CompareTo(this IArray<Density> self, IArray<Density> other) => self.Zip(other, (a,b) => a.CompareTo(b));
public static bool LessThan(this Density a, Density b) => a < b;
public static IArray<bool> LessThan(this IArray<Density> self, IArray<Density> other) => self.Zip(other, (a,b) => a < b);
public static bool LessThanOrEquals(this Density a, Density b) => a <= b;
public static IArray<bool> LessThanOrEquals(this IArray<Density> self, IArray<Density> other) => self.Zip(other, (a,b) => a <= b);
public static bool GreaterThan(this Density a, Density b) => a > b;
public static IArray<bool> GreaterThan(this IArray<Density> self, IArray<Density> other) => self.Zip(other, (a,b) => a > b);
public static bool GreaterThanOrEquals(this Density a, Density b) => a >= b;
public static IArray<bool> GreaterThanOrEquals(this IArray<Density> self, IArray<Density> other) => self.Zip(other, (a,b) => a >= b);
public static Density Default(this Density _) => default(Density);
public static Density Zero(this Density _) => Density.Zero;
public static Density One(this Density _) => Density.One;
public static double ToDouble(this Density self) => self;
public static Density MinValue(this Density _) => Density.MinValue;
public static Density MaxValue(this Density _) => Density.MaxValue;
}
} // End namespace
