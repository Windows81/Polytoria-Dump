namespace System.Linq.Expressions;

[Token(Token = "0x2000039")]
internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008E")]
	private readonly LambdaExpression _conversion; //Field offset: 0x38

	[Address(RVA = "0x158DDA0", Offset = "0x158CFA0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000140")]
	internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000141")]
	internal virtual LambdaExpression GetConversion() { }

}

