namespace RLD;

[Token(Token = "0x200020A")]
public class XZGridSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40007E2")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40007E3")]
	private float _cellSizeX; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40007E4")]
	private float _cellSizeZ; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40007E5")]
	private float _yOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40007E6")]
	private Vector3 _rotationAngles; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40007E7")]
	private float _upDownStep; //Field offset: 0x44

	[Token(Token = "0x17000655")]
	public float CellSizeX
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F3")]
		 get { } //Length: 6
		[Address(RVA = "0x53C530", Offset = "0x53B730", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F4")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000656")]
	public float CellSizeZ
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F5")]
		 get { } //Length: 6
		[Address(RVA = "0x5A6730", Offset = "0x5A5930", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60013F6")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000654")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F1")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000657")]
	public Vector3 RotationAngles
	{
		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F7")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F8")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000659")]
	public float UpDownStep
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FB")]
		 get { } //Length: 6
		[Address(RVA = "0x508FD0", Offset = "0x5081D0", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FC")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000658")]
	public float YOffset
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F9")]
		 get { } //Length: 6
		[Address(RVA = "0x5A6740", Offset = "0x5A5940", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FA")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x5A66C0", Offset = "0x5A58C0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60013FD")]
	public XZGridSettings() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F3")]
	public float get_CellSizeX() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F5")]
	public float get_CellSizeZ() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F1")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F7")]
	public Vector3 get_RotationAngles() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FB")]
	public float get_UpDownStep() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F9")]
	public float get_YOffset() { }

	[Address(RVA = "0x53C530", Offset = "0x53B730", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F4")]
	public void set_CellSizeX(float value) { }

	[Address(RVA = "0x5A6730", Offset = "0x5A5930", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013F6")]
	public void set_CellSizeZ(float value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F2")]
	public void set_IsVisible(bool value) { }

	[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F8")]
	public void set_RotationAngles(Vector3 value) { }

	[Address(RVA = "0x508FD0", Offset = "0x5081D0", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FC")]
	public void set_UpDownStep(float value) { }

	[Address(RVA = "0x5A6740", Offset = "0x5A5940", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FA")]
	public void set_YOffset(float value) { }

}

