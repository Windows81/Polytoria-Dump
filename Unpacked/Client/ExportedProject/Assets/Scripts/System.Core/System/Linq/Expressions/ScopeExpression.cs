namespace System.Linq.Expressions;

[Token(Token = "0x200005E")]
internal class ScopeExpression : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A6")]
	private IReadOnlyList<ParameterExpression> _variables; //Field offset: 0x10

	[Token(Token = "0x17000041")]
	protected IReadOnlyList<ParameterExpression> VariablesList
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000228")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1592B40", Offset = "0x1591D40", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000226")]
	internal ScopeExpression(IReadOnlyList<ParameterExpression> variables) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	[Address(RVA = "0x15A8210", Offset = "0x15A7410", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Token(Token = "0x6000227")]
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[Address(RVA = "0x15A8250", Offset = "0x15A7450", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000229")]
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }

}

