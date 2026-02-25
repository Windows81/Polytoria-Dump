namespace System.Linq.Expressions;

[Token(Token = "0x200008D")]
internal sealed class PropertyExpression : MemberExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000146")]
	private readonly PropertyInfo _property; //Field offset: 0x18

	[Token(Token = "0x1700009A")]
	public virtual Type Type
	{
		[Address(RVA = "0x15A7F20", Offset = "0x15A7120", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600039D")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x15A24B0", Offset = "0x15A16B0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600039B")]
	public PropertyExpression(Expression expression, PropertyInfo member) { }

	[Address(RVA = "0x15A7F20", Offset = "0x15A7120", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600039D")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600039C")]
	internal virtual MemberInfo GetMember() { }

}

