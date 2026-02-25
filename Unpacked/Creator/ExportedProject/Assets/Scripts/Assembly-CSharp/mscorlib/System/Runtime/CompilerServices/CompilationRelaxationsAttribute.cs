namespace System.Runtime.CompilerServices;

[AttributeUsage(71)]
[ComVisible(True)]
[Token(Token = "0x200049A")]
public class CompilationRelaxationsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001288")]
	private int m_relaxations; //Field offset: 0x10

	[Token(Token = "0x1700040C")]
	public int CompilationRelaxations
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60020A4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A2")]
	public CompilationRelaxationsAttribute(int relaxations) { }

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A3")]
	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A4")]
	public int get_CompilationRelaxations() { }

}

