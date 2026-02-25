namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector4f")]
[NativeHeader("Runtime/Math/Vector4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000102")]
public struct Vector4 : IEquatable<Vector4>, IFormattable
{
	[Token(Token = "0x40004DD")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40004E2")]
	private static readonly Vector4 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40004E3")]
	private static readonly Vector4 oneVector; //Field offset: 0x10
	[Token(Token = "0x40004E4")]
	private static readonly Vector4 positiveInfinityVector; //Field offset: 0x20
	[Token(Token = "0x40004E5")]
	private static readonly Vector4 negativeInfinityVector; //Field offset: 0x30
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004DE")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004DF")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004E0")]
	public float z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004E1")]
	public float w; //Field offset: 0xC

	[Token(Token = "0x1700016D")]
	public float Item
	{
		[Address(RVA = "0x1561480", Offset = "0x1560680", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "AdjustBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000835")]
		 get { } //Length: 144
		[Address(RVA = "0x1561510", Offset = "0x1560710", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "AdjustBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000836")]
		 set { } //Length: 144
	}

	[Token(Token = "0x17000170")]
	public static Vector4 one
	{
		[Address(RVA = "0x1979660", Offset = "0x1978860", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600083F")]
		 get { } //Length: 67
	}

	[Token(Token = "0x1700016E")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x19796B0", Offset = "0x19788B0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600083D")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700016F")]
	public static Vector4 zero
	{
		[Address(RVA = "0x1979700", Offset = "0x1978900", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600083E")]
		 get { } //Length: 66
	}

	[Address(RVA = "0x19795C0", Offset = "0x19787C0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600084A")]
	private static Vector4() { }

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000837")]
	public Vector4(float x, float y, float z, float w) { }

	[Address(RVA = "0x1979650", Offset = "0x1978850", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000838")]
	public Vector4(float x, float y) { }

	[Address(RVA = "0x194A1C0", Offset = "0x19493C0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083C")]
	public static float Dot(Vector4 a, Vector4 b) { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600083B")]
	public override bool Equals(Vector4 other) { }

	[Address(RVA = "0x1979270", Offset = "0x1978470", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600083A")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1561480", Offset = "0x1560680", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "AdjustBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000835")]
	public float get_Item(int index) { }

	[Address(RVA = "0x1979660", Offset = "0x1978860", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600083F")]
	public static Vector4 get_one() { }

	[Address(RVA = "0x19796B0", Offset = "0x19788B0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600083D")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x1979700", Offset = "0x1978900", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600083E")]
	public static Vector4 get_zero() { }

	[Address(RVA = "0x698380", Offset = "0x697580", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000839")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1943820", Offset = "0x1942A20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000841")]
	public static Vector4 op_Division(Vector4 a, float d) { }

	[Address(RVA = "0x1979750", Offset = "0x1978950", Length = "0x51")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000842")]
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	[Address(RVA = "0x19797D0", Offset = "0x19789D0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000844")]
	public static Vector4 op_Implicit(Vector3 v) { }

	[Address(RVA = "0x19797B0", Offset = "0x19789B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000845")]
	public static Vector3 op_Implicit(Vector4 v) { }

	[Address(RVA = "0x1979820", Offset = "0x1978A20", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000846")]
	public static Vector4 op_Implicit(Vector2 v) { }

	[Address(RVA = "0x193C320", Offset = "0x193B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000847")]
	public static Vector2 op_Implicit(Vector4 v) { }

	[Address(RVA = "0x1979860", Offset = "0x1978A60", Length = "0x68")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000843")]
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	[Address(RVA = "0x1943940", Offset = "0x1942B40", Length = "0x47")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000840")]
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	[Address(RVA = "0x1561510", Offset = "0x1560710", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "AdjustBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000836")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x1979330", Offset = "0x1978530", Length = "0x279")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000849")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x19795B0", Offset = "0x19787B0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2AE00")]
	[Token(Token = "0x6000848")]
	public virtual string ToString() { }

}

