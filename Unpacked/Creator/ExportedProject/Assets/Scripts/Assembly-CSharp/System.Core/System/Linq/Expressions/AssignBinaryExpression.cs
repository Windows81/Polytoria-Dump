namespace System.Linq.Expressions;

[Token(Token = "0x2000037")]
internal class AssignBinaryExpression : BinaryExpression
{

	[Token(Token = "0x1700002F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE040", Offset = "0x3CD240", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002E")]
	public virtual Type Type
	{
		[Address(RVA = "0x1572050", Offset = "0x1571250", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013A")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1572040", Offset = "0x1571240", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000139")]
	internal AssignBinaryExpression(Expression left, Expression right) { }

	[Address(RVA = "0x3CE040", Offset = "0x3CD240", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x1572050", Offset = "0x1571250", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013A")]
	public virtual Type get_Type() { }

}

