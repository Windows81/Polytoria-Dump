namespace System.Linq.Expressions;

[Token(Token = "0x2000036")]
internal sealed class LogicalBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008C")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700002D")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000138")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	public virtual Type Type
	{
		[Address(RVA = "0x158DD00", Offset = "0x158CF00", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000137")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x158DCC0", Offset = "0x158CEC0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000136")]
	internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000138")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x158DD00", Offset = "0x158CF00", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000137")]
	public virtual Type get_Type() { }

}

