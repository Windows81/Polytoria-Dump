namespace System.Linq.Expressions;

[Token(Token = "0x200005F")]
internal sealed class Scope1 : ScopeExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A7")]
	private object _body; //Field offset: 0x18

	[Token(Token = "0x17000042")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022D")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x15A8200", Offset = "0x15A7400", Length = "0x8")]
	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600022A")]
	internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	[Address(RVA = "0x1591850", Offset = "0x1590A50", Length = "0x82")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022B")]
	private Scope1(IReadOnlyList<ParameterExpression> variables, object body) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022D")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x15A8040", Offset = "0x15A7240", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600022C")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x15A80C0", Offset = "0x15A72C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlockExpression), Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[Token(Token = "0x600022E")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x15A80D0", Offset = "0x15A72D0", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600022F")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

