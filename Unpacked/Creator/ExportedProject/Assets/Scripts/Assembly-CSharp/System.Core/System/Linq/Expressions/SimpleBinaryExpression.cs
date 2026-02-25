namespace System.Linq.Expressions;

[Token(Token = "0x200003A")]
internal class SimpleBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008F")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000090")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000032")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000143")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000033")]
	public virtual Type Type
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000144")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x158E080", Offset = "0x158D280", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000142")]
	internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000144")]
	public virtual Type get_Type() { }

}

