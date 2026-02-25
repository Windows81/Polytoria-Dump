namespace System.Linq.Expressions;

[Token(Token = "0x2000060")]
internal class ScopeN : ScopeExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A8")]
	private IReadOnlyList<Expression> _body; //Field offset: 0x18

	[Token(Token = "0x17000043")]
	protected IReadOnlyList<Expression> Body
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000231")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000044")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x15A84D0", Offset = "0x15A76D0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000233")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0x1591850", Offset = "0x1590A50", Length = "0x82")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000230")]
	internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000231")]
	protected IReadOnlyList<Expression> get_Body() { }

	[Address(RVA = "0x15A84D0", Offset = "0x15A76D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000233")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x15A82E0", Offset = "0x15A74E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000232")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x15A8340", Offset = "0x15A7540", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Token(Token = "0x6000234")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x15A8380", Offset = "0x15A7580", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000235")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

