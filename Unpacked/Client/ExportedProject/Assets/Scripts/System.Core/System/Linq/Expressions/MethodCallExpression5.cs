namespace System.Linq.Expressions;

[Token(Token = "0x200009A")]
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000159")]
	private object _arg0; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015A")]
	private readonly Expression _arg1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015B")]
	private readonly Expression _arg2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015C")]
	private readonly Expression _arg3; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400015D")]
	private readonly Expression _arg4; //Field offset: 0x38

	[Token(Token = "0x170000AC")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A6690", Offset = "0x15A5890", Length = "0xD5")]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003D3")]
	public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D5")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x15A6420", Offset = "0x15A5620", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60003D4")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x15A5B80", Offset = "0x15A4D80", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IArgumentProvider), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D6")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A6510", Offset = "0x15A5710", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Token(Token = "0x60003D7")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

