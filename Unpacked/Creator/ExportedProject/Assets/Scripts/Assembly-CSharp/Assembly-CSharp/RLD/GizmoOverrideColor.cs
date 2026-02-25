namespace RLD;

[Token(Token = "0x2000033")]
public class GizmoOverrideColor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C7")]
	private bool _isActive; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000C8")]
	private Color _color; //Field offset: 0x14

	[Token(Token = "0x17000062")]
	public Color Color
	{
		[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000181")]
		 get { } //Length: 11
		[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000182")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000061")]
	public bool IsActive
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017F")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000180")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	public GizmoOverrideColor() { }

	[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000181")]
	public Color get_Color() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017F")]
	public bool get_IsActive() { }

	[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	public void set_IsActive(bool value) { }

}

