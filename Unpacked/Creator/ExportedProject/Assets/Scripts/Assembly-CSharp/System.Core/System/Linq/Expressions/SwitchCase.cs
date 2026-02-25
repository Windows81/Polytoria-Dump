namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchCaseProxy))]
[Token(Token = "0x20000AB")]
public sealed class SwitchCase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016E")]
	private readonly ReadOnlyCollection<Expression> <TestValues>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016F")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000F2")]
	public Expression Body
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000477")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F1")]
	public ReadOnlyCollection<Expression> TestValues
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000476")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000477")]
	public Expression get_Body() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000476")]
	public ReadOnlyCollection<Expression> get_TestValues() { }

}

