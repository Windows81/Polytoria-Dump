namespace RLD;

[Token(Token = "0x200012E")]
public class CameraOrbitSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000569")]
	private CameraOrbitMode _orbitMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400056A")]
	private float _standardOrbitSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400056B")]
	private float _smoothOrbitSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400056C")]
	private float _smoothValue; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400056D")]
	private bool _invertX; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x400056E")]
	private bool _invertY; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x400056F")]
	private bool _isOrbitEnabled; //Field offset: 0x3A

	[Token(Token = "0x170004D7")]
	public bool InvertX
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3F")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E40")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004D8")]
	public bool InvertY
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E41")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E42")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004D9")]
	public bool IsOrbitEnabled
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E43")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E44")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004D2")]
	public CameraOrbitMode OrbitMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E36")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E37")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004D5")]
	public float OrbitSensitivity
	{
		[Address(RVA = "0x53BBD0", Offset = "0x53ADD0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E3C")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170004D4")]
	public float SmoothOrbitSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004D6")]
	public float SmoothValue
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3D")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004D3")]
	public float StandardOrbitSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E38")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E39")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53BB60", Offset = "0x53AD60", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E45")]
	public CameraOrbitSettings() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3F")]
	public bool get_InvertX() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E41")]
	public bool get_InvertY() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E43")]
	public bool get_IsOrbitEnabled() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E36")]
	public CameraOrbitMode get_OrbitMode() { }

	[Address(RVA = "0x53BBD0", Offset = "0x53ADD0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E3C")]
	public float get_OrbitSensitivity() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3A")]
	public float get_SmoothOrbitSensitivity() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3D")]
	public float get_SmoothValue() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E38")]
	public float get_StandardOrbitSensitivity() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E40")]
	public void set_InvertX(bool value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E42")]
	public void set_InvertY(bool value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E44")]
	public void set_IsOrbitEnabled(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E37")]
	public void set_OrbitMode(CameraOrbitMode value) { }

	[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3B")]
	public void set_SmoothOrbitSensitivity(float value) { }

	[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3E")]
	public void set_SmoothValue(float value) { }

	[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E39")]
	public void set_StandardOrbitSensitivity(float value) { }

}

