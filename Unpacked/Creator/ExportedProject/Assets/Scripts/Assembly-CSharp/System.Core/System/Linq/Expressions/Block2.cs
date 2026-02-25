namespace System.Linq.Expressions;

[Token(Token = "0x2000059")]
internal sealed class Block2 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000097")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000098")]
	private readonly Expression _arg1; //Field offset: 0x18

	[Token(Token = "0x1700003C")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020F")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1591850", Offset = "0x1590A50", Length = "0x82")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020D")]
	internal Block2(Expression arg0, Expression arg1) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020F")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x15916D0", Offset = "0x15908D0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600020E")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x1591760", Offset = "0x1590960", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlockExpression), Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000210")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x1591770", Offset = "0x1590970", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

