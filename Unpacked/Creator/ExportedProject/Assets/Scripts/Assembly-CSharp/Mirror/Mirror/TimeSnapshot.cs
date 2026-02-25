namespace Mirror;

[Token(Token = "0x2000078")]
public struct TimeSnapshot : Snapshot
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000195")]
	private double <remoteTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000196")]
	private double <localTime>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700006D")]
	public override double localTime
	{
		[Address(RVA = "0xE304A0", Offset = "0xE2F6A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 6
		[Address(RVA = "0x12466E0", Offset = "0x12458E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FA")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700006C")]
	public override double remoteTime
	{
		[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60003F7")]
		 get { } //Length: 5
		[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F8")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x126F3F0", Offset = "0x126E5F0", Length = "0xA")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FB")]
	public TimeSnapshot(double remoteTime, double localTime) { }

	[Address(RVA = "0xE304A0", Offset = "0xE2F6A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60003F9")]
	public override double get_localTime() { }

	[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60003F7")]
	public override double get_remoteTime() { }

	[Address(RVA = "0x12466E0", Offset = "0x12458E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FA")]
	public override void set_localTime(double value) { }

	[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F8")]
	public override void set_remoteTime(double value) { }

}

