namespace System.Linq.Expressions;

[Token(Token = "0x200005B")]
internal sealed class Block4 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009C")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009D")]
	private readonly Expression _arg1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009E")]
	private readonly Expression _arg2; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009F")]
	private readonly Expression _arg3; //Field offset: 0x28

	[Token(Token = "0x1700003E")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000219")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1591D30", Offset = "0x1590F30", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000217")]
	internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000219")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x1591B40", Offset = "0x1590D40", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000218")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x1591760", Offset = "0x1590960", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlockExpression), Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600021A")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x1591C00", Offset = "0x1590E00", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021B")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

