namespace UnityEngine;

[Token(Token = "0x20000E9")]
public struct MipmapLimitDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400031F")]
	private readonly bool <useMipmapLimit>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000320")]
	private readonly string <groupName>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000125")]
	public string groupName
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60006A4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000124")]
	public bool useMipmapLimit
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60006A3")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60006A4")]
	public string get_groupName() { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60006A3")]
	public bool get_useMipmapLimit() { }

}

