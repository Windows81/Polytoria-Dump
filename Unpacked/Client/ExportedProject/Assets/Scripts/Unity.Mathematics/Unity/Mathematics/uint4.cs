namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000014")]
public struct uint4 : IEquatable<uint4>, IFormattable
{
	[Token(Token = "0x2000015")]
	public sealed class DebuggerProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001F")]
	public uint x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000020")]
	public uint y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000021")]
	public uint z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000022")]
	public uint w; //Field offset: 0xC

	[Address(RVA = "0x1828760", Offset = "0x1827960", Length = "0x12")]
	[CallerCount(Count = 24)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	public uint4(uint x, uint y, uint z, uint w) { }

	[Address(RVA = "0x1828750", Offset = "0x1827950", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000090")]
	public uint4(int v) { }

	[Address(RVA = "0x149E160", Offset = "0x149D360", Length = "0x23")]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public override bool Equals(uint4 rhs) { }

	[Address(RVA = "0x1828290", Offset = "0x1827490", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000098")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1826EF0", Offset = "0x18260F0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000099")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1828780", Offset = "0x1827980", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000092")]
	public static uint4 op_Addition(uint4 lhs, uint4 rhs) { }

	[Address(RVA = "0x18287B0", Offset = "0x18279B0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000094")]
	public static uint4 op_BitwiseAnd(uint4 lhs, uint4 rhs) { }

	[Address(RVA = "0x18287E0", Offset = "0x18279E0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000095")]
	public static uint4 op_BitwiseOr(uint4 lhs, uint4 rhs) { }

	[Address(RVA = "0x1828810", Offset = "0x1827A10", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000096")]
	public static uint4 op_ExclusiveOr(uint4 lhs, uint4 rhs) { }

	[Address(RVA = "0x1828840", Offset = "0x1827A40", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000091")]
	public static uint4 op_Multiply(uint4 lhs, uint4 rhs) { }

	[Address(RVA = "0x1828870", Offset = "0x1827A70", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000093")]
	public static uint4 op_OnesComplement(uint4 val) { }

	[Address(RVA = "0x1828550", Offset = "0x1827750", Length = "0x1F4")]
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
	[Token(Token = "0x600009A")]
	public virtual string ToString() { }

	[Address(RVA = "0x1828340", Offset = "0x1827540", Length = "0x20A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600009B")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

