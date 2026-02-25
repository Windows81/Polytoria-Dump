namespace System.Linq.Expressions;

[Token(Token = "0x2000038")]
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008D")]
	private readonly LambdaExpression _conversion; //Field offset: 0x20

	[Token(Token = "0x17000030")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000031")]
	public virtual Type Type
	{
		[Address(RVA = "0x1574850", Offset = "0x1573A50", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600013F")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1574810", Offset = "0x1573A10", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600013C")]
	internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) { }

	[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013E")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x1574850", Offset = "0x1573A50", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013F")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013D")]
	internal virtual LambdaExpression GetConversion() { }

}

