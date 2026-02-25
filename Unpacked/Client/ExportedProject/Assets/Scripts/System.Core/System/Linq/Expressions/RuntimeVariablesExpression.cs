namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
[Token(Token = "0x20000A7")]
public sealed class RuntimeVariablesExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016A")]
	private readonly ReadOnlyCollection<ParameterExpression> <Variables>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000BC")]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000406")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000406")]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

}

