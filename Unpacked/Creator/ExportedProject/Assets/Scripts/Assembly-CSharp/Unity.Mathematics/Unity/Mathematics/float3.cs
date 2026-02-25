namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000007")]
public struct float3 : IEquatable<float3>, IFormattable
{
	[Token(Token = "0x2000008")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000005")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000006")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000007")]
	public float z; //Field offset: 0x8

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000001")]
	public float3 yzx
	{
		[Address(RVA = "0x18246B0", Offset = "0x18238B0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000045")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x18246A0", Offset = "0x18238A0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public float3(float x, float y, float z) { }

	[Address(RVA = "0x1824690", Offset = "0x1823890", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600003C")]
	public float3(float v) { }

	[Address(RVA = "0x1824660", Offset = "0x1823860", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600003D")]
	public float3(int v) { }

	[Address(RVA = "0x18243F0", Offset = "0x18235F0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000047")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x18243C0", Offset = "0x18235C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public override bool Equals(float3 rhs) { }

	[Address(RVA = "0x18246B0", Offset = "0x18238B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000045")]
	public float3 get_yzx() { }

	[Address(RVA = "0x18244A0", Offset = "0x18236A0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x18246D0", Offset = "0x18238D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000044")]
	public static float3 op_Division(float3 lhs, float rhs) { }

	[Address(RVA = "0x1824730", Offset = "0x1823930", Length = "0x14")]
	[CalledBy(Type = "GLTFast.Schema.AccessorBase", Member = "TryGetBounds", ReturnType = "System.Nullable`1<Bounds>")]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600004B")]
	public static Vector3 op_Implicit(float3 v) { }

	[Address(RVA = "0x1824700", Offset = "0x1823900", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600003F")]
	public static float3 op_Implicit(int v) { }

	[Address(RVA = "0x40F340", Offset = "0x40E540", Length = "0x12")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	public static float3 op_Implicit(float v) { }

	[Address(RVA = "0x1824790", Offset = "0x1823990", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000042")]
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	[Address(RVA = "0x18247C0", Offset = "0x18239C0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000041")]
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	[Address(RVA = "0x1824750", Offset = "0x1823950", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000040")]
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x18247F0", Offset = "0x18239F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000043")]
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x18244F0", Offset = "0x18236F0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000049")]
	public virtual string ToString() { }

	[Address(RVA = "0x18245A0", Offset = "0x18237A0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600004A")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

