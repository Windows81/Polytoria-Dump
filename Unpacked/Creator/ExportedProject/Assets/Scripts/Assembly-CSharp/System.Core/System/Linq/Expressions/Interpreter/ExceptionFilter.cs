namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000177")]
internal sealed class ExceptionFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DB")]
	public readonly int LabelIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002DC")]
	public readonly int StartIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DD")]
	public readonly int EndIndex; //Field offset: 0x18

	[Address(RVA = "0x132BFA0", Offset = "0x132B1A0", Length = "0x44")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000777")]
	internal ExceptionFilter(int labelIndex, int start, int end) { }

}

