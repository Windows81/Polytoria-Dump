namespace RLD;

[Token(Token = "0x2000128")]
public class CameraFocusSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	private CameraFocusMode _focusMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400054B")]
	private float _constantSpeed; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400054C")]
	private float _smoothTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400054D")]
	private float _focusDistanceAdd; //Field offset: 0x34

	[Token(Token = "0x170004BA")]
	public float ConstantSpeed
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E0C")]
		 get { } //Length: 6
		[Address(RVA = "0x53B2B0", Offset = "0x53A4B0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E0D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004BC")]
	public float FocusDistanceAdd
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E10")]
		 get { } //Length: 6
		[Address(RVA = "0x53B2C0", Offset = "0x53A4C0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E11")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004B9")]
	public CameraFocusMode FocusMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E0A")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E0B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004BB")]
	public float SmoothTime
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E0E")]
		 get { } //Length: 6
		[Address(RVA = "0x53B2D0", Offset = "0x53A4D0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E0F")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53B230", Offset = "0x53A430", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E12")]
	public CameraFocusSettings() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0C")]
	public float get_ConstantSpeed() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E10")]
	public float get_FocusDistanceAdd() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0A")]
	public CameraFocusMode get_FocusMode() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0E")]
	public float get_SmoothTime() { }

	[Address(RVA = "0x53B2B0", Offset = "0x53A4B0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E0D")]
	public void set_ConstantSpeed(float value) { }

	[Address(RVA = "0x53B2C0", Offset = "0x53A4C0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E11")]
	public void set_FocusDistanceAdd(float value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0B")]
	public void set_FocusMode(CameraFocusMode value) { }

	[Address(RVA = "0x53B2D0", Offset = "0x53A4D0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E0F")]
	public void set_SmoothTime(float value) { }

}

