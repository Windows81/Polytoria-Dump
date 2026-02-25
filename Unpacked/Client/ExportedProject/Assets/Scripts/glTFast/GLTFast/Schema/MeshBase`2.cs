namespace GLTFast.Schema;

[Token(Token = "0x20000AD")]
public abstract class MeshBase : MeshBase, ICloneable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400027C")]
	public TExtras extras; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400027D")]
	public TPrimitive[] primitives; //Field offset: 0x0

	[Token(Token = "0x17000059")]
	public virtual MeshExtras Extras
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005A")]
	public virtual IReadOnlyList<MeshPrimitiveBase> Primitives
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000210")]
	protected MeshBase`2() { }

	[Address(RVA = "0xE0A750", Offset = "0xE09950", Length = "0x202")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020F")]
	public override object Clone() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020D")]
	public virtual MeshExtras get_Extras() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020E")]
	public virtual IReadOnlyList<MeshPrimitiveBase> get_Primitives() { }

}

