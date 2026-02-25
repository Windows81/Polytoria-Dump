namespace System.Linq.Expressions;

[Token(Token = "0x200008C")]
internal sealed class FieldExpression : MemberExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000145")]
	private readonly FieldInfo _field; //Field offset: 0x18

	[Token(Token = "0x17000099")]
	public virtual Type Type
	{
		[Address(RVA = "0x15A2540", Offset = "0x15A1740", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600039A")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x15A24B0", Offset = "0x15A16B0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000398")]
	public FieldExpression(Expression expression, FieldInfo member) { }

	[Address(RVA = "0x15A2540", Offset = "0x15A1740", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600039A")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000399")]
	internal virtual MemberInfo GetMember() { }

}

