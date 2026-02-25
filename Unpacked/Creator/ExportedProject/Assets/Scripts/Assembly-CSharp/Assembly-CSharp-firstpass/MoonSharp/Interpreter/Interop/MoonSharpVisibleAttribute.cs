namespace MoonSharp.Interpreter.Interop;

[AttributeUsage(992, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x20000C8")]
public sealed class MoonSharpVisibleAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000387")]
	private bool <Visible>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000117")]
	public private bool Visible
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000874")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000875")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000876")]
	public MoonSharpVisibleAttribute(bool visible) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000874")]
	public bool get_Visible() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000875")]
	private void set_Visible(bool value) { }

}

