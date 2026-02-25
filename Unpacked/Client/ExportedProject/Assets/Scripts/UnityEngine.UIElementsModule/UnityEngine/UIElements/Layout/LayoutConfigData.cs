namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005D0")]
internal struct LayoutConfigData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400150D")]
	public float PointScaleFactor; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400150E")]
	public int ManagedMeasureFunctionIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400150F")]
	public int ManagedBaselineFunctionIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4001510")]
	public bool ShouldLog; //Field offset: 0xC

	[Token(Token = "0x17000A7C")]
	public static LayoutConfigData Default
	{
		[Address(RVA = "0x1BA86E0", Offset = "0x1BA78E0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600295F")]
		 get { } //Length: 16
	}

	[Address(RVA = "0x1BA86E0", Offset = "0x1BA78E0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600295F")]
	public static LayoutConfigData get_Default() { }

}

