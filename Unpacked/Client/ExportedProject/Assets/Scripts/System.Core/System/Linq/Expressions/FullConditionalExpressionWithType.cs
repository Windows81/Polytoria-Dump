namespace System.Linq.Expressions;

[Token(Token = "0x200006A")]
internal sealed class FullConditionalExpressionWithType : FullConditionalExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000BC")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000054")]
	public virtual Type Type
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000265")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15A2610", Offset = "0x15A1810", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000264")]
	internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000265")]
	public virtual Type get_Type() { }

}

