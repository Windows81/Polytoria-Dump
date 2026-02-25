namespace RLD;

[Token(Token = "0x2000224")]
public class Object2ObjectSnapSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000846")]
	private int _snapDestinationLayers; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000847")]
	private bool _canClimbObjects; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000848")]
	private float _snapRadius; //Field offset: 0x30

	[Token(Token = "0x1700068C")]
	public bool CanClimbObjects
	{
		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A4")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700068B")]
	public int SnapDestinationLayers
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A2")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700068D")]
	public float SnapRadius
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A6")]
		 get { } //Length: 6
		[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014A7")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x598A50", Offset = "0x597C50", Length = "0x19")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60014A8")]
	public Object2ObjectSnapSettings() { }

	[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A4")]
	public bool get_CanClimbObjects() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A2")]
	public int get_SnapDestinationLayers() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A6")]
	public float get_SnapRadius() { }

	[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A5")]
	public void set_CanClimbObjects(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A3")]
	public void set_SnapDestinationLayers(int value) { }

	[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014A7")]
	public void set_SnapRadius(float value) { }

}

