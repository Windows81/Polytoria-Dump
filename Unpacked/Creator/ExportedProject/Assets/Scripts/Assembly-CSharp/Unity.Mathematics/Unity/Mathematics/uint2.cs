namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000010")]
public struct uint2 : IEquatable<uint2>, IFormattable
{
	[Token(Token = "0x2000011")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	public uint x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001B")]
	public uint y; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public uint2(uint x, uint y) { }

	[Address(RVA = "0x1806EF0", Offset = "0x18060F0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public override bool Equals(uint2 rhs) { }

	[Address(RVA = "0x1827E20", Offset = "0x1827020", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000083")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1827EB0", Offset = "0x18270B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000084")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1828010", Offset = "0x1827210", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000081")]
	public static uint2 op_Multiply(uint2 lhs, uint2 rhs) { }

	[Address(RVA = "0x1827F90", Offset = "0x1827190", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000085")]
	public virtual string ToString() { }

	[Address(RVA = "0x1827F00", Offset = "0x1827100", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000086")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

