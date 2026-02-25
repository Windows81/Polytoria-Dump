namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000A")]
public struct float4 : IEquatable<float4>, IFormattable
{
	[Token(Token = "0x200000B")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000C")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400000D")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000E")]
	public float z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400000F")]
	public float w; //Field offset: 0xC

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000003")]
	public float4 wzyx
	{
		[Address(RVA = "0x1825920", Offset = "0x1824B20", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600005F")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000004")]
	public float2 xy
	{
		[Address(RVA = "0x56A3D0", Offset = "0x5695D0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000005")]
	public float2 zw
	{
		[Address(RVA = "0xCE3950", Offset = "0xCE2B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000002")]
	public float4 zwxy
	{
		[Address(RVA = "0x1825940", Offset = "0x1824B40", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600005E")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public float4(float x, float y, float z, float w) { }

	[Address(RVA = "0x18258E0", Offset = "0x1824AE0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000056")]
	public float4(float3 xyz, float w) { }

	[Address(RVA = "0x18258D0", Offset = "0x1824AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000057")]
	public float4(float v) { }

	[Address(RVA = "0x1825360", Offset = "0x1824560", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public override bool Equals(float4 rhs) { }

	[Address(RVA = "0x1825920", Offset = "0x1824B20", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600005F")]
	public float4 get_wzyx() { }

	[Address(RVA = "0x56A3D0", Offset = "0x5695D0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public float2 get_xy() { }

	[Address(RVA = "0xCE3950", Offset = "0xCE2B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public float2 get_zw() { }

	[Address(RVA = "0x1825940", Offset = "0x1824B40", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600005E")]
	public float4 get_zwxy() { }

	[Address(RVA = "0x1825460", Offset = "0x1824660", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000064")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1825960", Offset = "0x1824B60", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	[Address(RVA = "0x18259B0", Offset = "0x1824BB0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005C")]
	public static float4 op_Division(float4 lhs, float rhs) { }

	[Address(RVA = "0x40E940", Offset = "0x40DB40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public static float4 op_Implicit(float v) { }

	[Address(RVA = "0x18259D0", Offset = "0x1824BD0", Length = "0x1A")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000067")]
	public static Vector4 op_Implicit(float4 v) { }

	[Address(RVA = "0x18259F0", Offset = "0x1824BF0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000059")]
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	[Address(RVA = "0x1825A10", Offset = "0x1824C10", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600005B")]
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	[Address(RVA = "0x1825A60", Offset = "0x1824C60", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600005D")]
	public static float4 op_UnaryNegation(float4 val) { }

	[Address(RVA = "0x18256C0", Offset = "0x18248C0", Length = "0x20A")]
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
	[Token(Token = "0x6000066")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x18254B0", Offset = "0x18246B0", Length = "0x204")]
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
	[Token(Token = "0x6000065")]
	public virtual string ToString() { }

}

