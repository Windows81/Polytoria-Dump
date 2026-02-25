namespace System.Linq.Expressions;

[Token(Token = "0x2000094")]
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014E")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x20

	[Token(Token = "0x170000A6")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x15A4990", Offset = "0x15A3B90", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60003B7")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x15A43C0", Offset = "0x15A35C0", Length = "0x32")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B5")]
	public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	[Address(RVA = "0x15A4990", Offset = "0x15A3B90", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B7")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x15A4870", Offset = "0x15A3A70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003B6")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x15A48D0", Offset = "0x15A3AD0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Token(Token = "0x60003B8")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A4910", Offset = "0x15A3B10", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[Token(Token = "0x60003B9")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

