namespace RLD;

[Token(Token = "0x20001D9")]
public class ObjectKeyRotationSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400074A")]
	private float _xRotationStep; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400074B")]
	private float _yRotationStep; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400074C")]
	private float _zRotationStep; //Field offset: 0x30

	[Token(Token = "0x170005DC")]
	public float XRotationStep
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001282")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001283")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170005DD")]
	public float YRotationStep
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001284")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001285")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170005DE")]
	public float ZRotationStep
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001286")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001287")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x576BF0", Offset = "0x575DF0", Length = "0x1C")]
	[CalledBy(Type = typeof(ObjectSelectionRotationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001288")]
	public ObjectKeyRotationSettings() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001282")]
	public float get_XRotationStep() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001284")]
	public float get_YRotationStep() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001286")]
	public float get_ZRotationStep() { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001283")]
	public void set_XRotationStep(float value) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001285")]
	public void set_YRotationStep(float value) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001287")]
	public void set_ZRotationStep(float value) { }

}

