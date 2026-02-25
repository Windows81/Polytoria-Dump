namespace MoonSharp.Interpreter;

[AttributeUsage(12, Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000067")]
public sealed class MoonSharpUserDataAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000225")]
	private InteropAccessMode <AccessMode>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000D1")]
	public InteropAccessMode AccessMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600063F")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000640")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x305ED0", Offset = "0x3050D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000641")]
	public MoonSharpUserDataAttribute() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600063F")]
	public InteropAccessMode get_AccessMode() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000640")]
	public void set_AccessMode(InteropAccessMode value) { }

}

