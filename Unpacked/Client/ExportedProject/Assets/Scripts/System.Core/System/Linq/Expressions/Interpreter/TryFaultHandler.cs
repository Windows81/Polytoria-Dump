namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200017A")]
internal sealed class TryFaultHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E9")]
	internal readonly int TryStartIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002EA")]
	internal readonly int TryEndIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EB")]
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002EC")]
	internal readonly int FinallyEndIndex; //Field offset: 0x1C

	[Address(RVA = "0x15CD130", Offset = "0x15CC330", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000782")]
	internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }

}

