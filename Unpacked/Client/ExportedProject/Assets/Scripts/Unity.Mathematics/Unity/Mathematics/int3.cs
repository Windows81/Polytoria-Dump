namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200000D")]
public struct int3 : IEquatable<int3>, IFormattable
{
	[Token(Token = "0x200000E")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000015")]
	public int x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000016")]
	public int y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000017")]
	public int z; //Field offset: 0x8

	[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006F")]
	public int3(int x, int y, int z) { }

	[Address(RVA = "0x107A160", Offset = "0x1079360", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public override bool Equals(int3 rhs) { }

	[Address(RVA = "0x1826A40", Offset = "0x1825C40", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000071")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1826AF0", Offset = "0x1825CF0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1826C00", Offset = "0x1825E00", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000073")]
	public virtual string ToString() { }

	[Address(RVA = "0x1826B40", Offset = "0x1825D40", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000074")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

