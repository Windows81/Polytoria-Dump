namespace MoonSharp.Interpreter;

[Token(Token = "0x200005A")]
public class YieldRequest
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000213")]
	public DynValue[] ReturnValues; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000214")]
	private bool <Forced>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000C2")]
	public internal bool Forced
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B2")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B3")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B4")]
	public YieldRequest() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B2")]
	public bool get_Forced() { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B3")]
	internal void set_Forced(bool value) { }

}

