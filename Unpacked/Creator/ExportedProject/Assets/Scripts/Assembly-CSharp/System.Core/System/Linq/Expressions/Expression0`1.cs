namespace System.Linq.Expressions;

[Token(Token = "0x2000080")]
internal sealed class Expression0 : Expression<TDelegate>
{

	[Token(Token = "0x17000087")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000371")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0xC2FBC0", Offset = "0xC2EDC0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public Expression0`1(Expression body) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0xC2FB10", Offset = "0xC2ED10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000372")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0xC2FB40", Offset = "0xC2ED40", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000373")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

