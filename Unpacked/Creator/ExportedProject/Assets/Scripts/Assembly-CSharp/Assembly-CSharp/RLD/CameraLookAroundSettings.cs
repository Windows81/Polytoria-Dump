namespace RLD;

[Token(Token = "0x200012B")]
public class CameraLookAroundSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400055B")]
	private CameraLookAroundMode _lookAroundMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400055C")]
	private float _standardLookAroundSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400055D")]
	private float _smoothLookAroundSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400055E")]
	private float smoothValue; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400055F")]
	private bool _invertX; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000560")]
	private bool _invertY; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x4000561")]
	private bool _isLookAroundEnabled; //Field offset: 0x3A

	[Token(Token = "0x170004CC")]
	public bool InvertX
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E27")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E28")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004CD")]
	public bool InvertY
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E29")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004CE")]
	public bool IsLookAroundEnabled
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2B")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004C7")]
	public CameraLookAroundMode LookAroundMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1E")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004CA")]
	public float Sensitivity
	{
		[Address(RVA = "0x53B960", Offset = "0x53AB60", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E24")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170004C9")]
	public float SmoothLookAroundSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E22")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E23")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004CB")]
	public float SmoothValue
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E25")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E26")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004C8")]
	public float StandardLookAroundSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E20")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E21")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53B8D0", Offset = "0x53AAD0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E2D")]
	public CameraLookAroundSettings() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E27")]
	public bool get_InvertX() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E29")]
	public bool get_InvertY() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2B")]
	public bool get_IsLookAroundEnabled() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1E")]
	public CameraLookAroundMode get_LookAroundMode() { }

	[Address(RVA = "0x53B960", Offset = "0x53AB60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E24")]
	public float get_Sensitivity() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E22")]
	public float get_SmoothLookAroundSensitivity() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E25")]
	public float get_SmoothValue() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E20")]
	public float get_StandardLookAroundSensitivity() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E28")]
	public void set_InvertX(bool value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2A")]
	public void set_InvertY(bool value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2C")]
	public void set_IsLookAroundEnabled(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1F")]
	public void set_LookAroundMode(CameraLookAroundMode value) { }

	[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E23")]
	public void set_SmoothLookAroundSensitivity(float value) { }

	[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E26")]
	public void set_SmoothValue(float value) { }

	[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E21")]
	public void set_StandardLookAroundSensitivity(float value) { }

}

