namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000012")]
public struct uint3 : IEquatable<uint3>, IFormattable
{
	[Token(Token = "0x2000013")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001C")]
	public uint x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001D")]
	public uint y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001E")]
	public uint z; //Field offset: 0x8

	[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	public uint3(uint x, uint y, uint z) { }

	[Address(RVA = "0x107A160", Offset = "0x1079360", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public override bool Equals(uint3 rhs) { }

	[Address(RVA = "0x1828030", Offset = "0x1827230", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008B")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1826F40", Offset = "0x1826140", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1828240", Offset = "0x1827440", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000089")]
	public static uint3 op_Addition(uint3 lhs, uint3 rhs) { }

	[Address(RVA = "0x1828260", Offset = "0x1827460", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000088")]
	public static uint3 op_Multiply(uint3 lhs, uint3 rhs) { }

	[Address(RVA = "0x18281A0", Offset = "0x18273A0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600008D")]
	public virtual string ToString() { }

	[Address(RVA = "0x18280E0", Offset = "0x18272E0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600008E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

