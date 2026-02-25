namespace System.Linq.Expressions;

[Token(Token = "0x200009D")]
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015F")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000160")]
	private readonly Expression _arg1; //Field offset: 0x28

	[Token(Token = "0x170000AF")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E4")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A45C0", Offset = "0x15A37C0", Length = "0x44")]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003E2")]
	public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E4")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x15A4400", Offset = "0x15A3600", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60003E3")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x15A42F0", Offset = "0x15A34F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IArgumentProvider), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E5")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A44B0", Offset = "0x15A36B0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Token(Token = "0x60003E6")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

