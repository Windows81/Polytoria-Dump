namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000009")]
public struct float3x3 : IEquatable<float3x3>, IFormattable
{
	[Token(Token = "0x400000B")]
	public static readonly float3x3 identity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000008")]
	public float3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000009")]
	public float3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000A")]
	public float3 c2; //Field offset: 0x18

	[Address(RVA = "0x1825190", Offset = "0x1824390", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000054")]
	private static float3x3() { }

	[Address(RVA = "0x1825240", Offset = "0x1824440", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004C")]
	public float3x3(float3 c0, float3 c1, float3 c2) { }

	[Address(RVA = "0x18251E0", Offset = "0x18243E0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004D")]
	public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	[Address(RVA = "0x1821B80", Offset = "0x1820D80", Length = "0xCBA")]
	[CalledBy(Type = typeof(float3x3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004F")]
	public override bool Equals(float3x3 rhs) { }

	[Address(RVA = "0x1824830", Offset = "0x1823A30", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float3x3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000050")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x18248E0", Offset = "0x1823AE0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000051")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1825280", Offset = "0x1824480", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004E")]
	public static float3x3 op_Multiply(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x18249A0", Offset = "0x1823BA0", Length = "0x40A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000052")]
	public virtual string ToString() { }

	[Address(RVA = "0x1824DB0", Offset = "0x1823FB0", Length = "0x3DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000053")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

