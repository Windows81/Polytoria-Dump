namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000F")]
public struct quaternion : IEquatable<quaternion>, IFormattable
{
	[Token(Token = "0x4000019")]
	public static readonly quaternion identity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000018")]
	public float4 value; //Field offset: 0x0

	[Address(RVA = "0x1827A80", Offset = "0x1826C80", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600007F")]
	private static quaternion() { }

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public quaternion(float x, float y, float z, float w) { }

	[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public quaternion(float4 value) { }

	[Address(RVA = "0x1827AC0", Offset = "0x1826CC0", Length = "0x356")]
	[CalledBy(Type = "GLTFast.Mathematics", Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(float3&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000079")]
	public quaternion(float3x3 m) { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	public override bool Equals(quaternion x) { }

	[Address(RVA = "0x18275A0", Offset = "0x18267A0", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007B")]
	public virtual bool Equals(object x) { }

	[Address(RVA = "0x1825460", Offset = "0x1824660", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x18259D0", Offset = "0x1824BD0", Length = "0x1A")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	public static Quaternion op_Implicit(quaternion q) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	public static quaternion op_Implicit(float4 v) { }

	[Address(RVA = "0x1827660", Offset = "0x1826860", Length = "0x204")]
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
	[Token(Token = "0x600007D")]
	public virtual string ToString() { }

	[Address(RVA = "0x1827870", Offset = "0x1826A70", Length = "0x20A")]
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
	[Token(Token = "0x600007E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

