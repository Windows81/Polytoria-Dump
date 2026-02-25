namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000005")]
public struct float2 : IEquatable<float2>, IFormattable
{
	[Token(Token = "0x2000006")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000003")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000004")]
	public float y; //Field offset: 0x4

	[Address(RVA = "0x40FBC0", Offset = "0x40EDC0", Length = "0xA")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public float2(float x, float y) { }

	[Address(RVA = "0x1824360", Offset = "0x1823560", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public float2(float v) { }

	[Address(RVA = "0x1824110", Offset = "0x1823310", Length = "0x26")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public override bool Equals(float2 rhs) { }

	[Address(RVA = "0x1824140", Offset = "0x1823340", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000036")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x18241E0", Offset = "0x18233E0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000037")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1824370", Offset = "0x1823570", Length = "0x22")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public static float2 op_Division(float2 lhs, float rhs) { }

	[Address(RVA = "0x40ED20", Offset = "0x40DF20", Length = "0xC")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public static float2 op_Implicit(float v) { }

	[Address(RVA = "0x18243A0", Offset = "0x18235A0", Length = "0x1A")]
	[CalledBy(Type = "GLTFast.Materials.MaterialGenerator", Member = "TrySetTextureTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.TextureInfoBase", typeof(Material), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600003A")]
	public static Vector2 op_Implicit(float2 v) { }

	[Address(RVA = "0x18242D0", Offset = "0x18234D0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000038")]
	public virtual string ToString() { }

	[Address(RVA = "0x1824240", Offset = "0x1823440", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000039")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

