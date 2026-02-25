namespace System.Linq.Expressions;

[Token(Token = "0x2000069")]
internal class FullConditionalExpression : ConditionalExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BB")]
	private readonly Expression _false; //Field offset: 0x20

	[Address(RVA = "0x15A2660", Offset = "0x15A1860", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000262")]
	internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000263")]
	internal virtual Expression GetFalse() { }

}

