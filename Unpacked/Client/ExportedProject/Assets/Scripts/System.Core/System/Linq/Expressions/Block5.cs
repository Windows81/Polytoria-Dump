namespace System.Linq.Expressions;

[Token(Token = "0x200005C")]
internal sealed class Block5 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A0")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A1")]
	private readonly Expression _arg1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A2")]
	private readonly Expression _arg2; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A3")]
	private readonly Expression _arg3; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A4")]
	private readonly Expression _arg4; //Field offset: 0x30

	[Token(Token = "0x1700003F")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600021E")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1592020", Offset = "0x1591220", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021E")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x1591DF0", Offset = "0x1590FF0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600021D")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x1591760", Offset = "0x1590960", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlockExpression), Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600021F")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x1591EC0", Offset = "0x15910C0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000220")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

