namespace RLD;

[Token(Token = "0x2000130")]
public class CameraPanSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000573")]
	private CameraPanMode _panMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000574")]
	private float _standardPanSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000575")]
	private float _smoothPanSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000576")]
	private float _smoothValue; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	private bool _invertX; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	private bool _invertY; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x4000579")]
	private bool _isPanningEnabled; //Field offset: 0x3A

	[Token(Token = "0x170004DF")]
	public bool InvertX
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4F")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E50")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004E0")]
	public bool InvertY
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E51")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E52")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004E1")]
	public bool IsPanningEnabled
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E53")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E54")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004DA")]
	public CameraPanMode PanMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E46")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E47")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004DD")]
	public float Sensitivity
	{
		[Address(RVA = "0x53B960", Offset = "0x53AB60", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4C")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170004DC")]
	public float SmoothPanSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4A")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004DE")]
	public float SmoothValue
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4D")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004DB")]
	public float StandardPanSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E48")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E49")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53BBF0", Offset = "0x53ADF0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E55")]
	public CameraPanSettings() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4F")]
	public bool get_InvertX() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E51")]
	public bool get_InvertY() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E53")]
	public bool get_IsPanningEnabled() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E46")]
	public CameraPanMode get_PanMode() { }

	[Address(RVA = "0x53B960", Offset = "0x53AB60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4C")]
	public float get_Sensitivity() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4A")]
	public float get_SmoothPanSensitivity() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4D")]
	public float get_SmoothValue() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E48")]
	public float get_StandardPanSensitivity() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E50")]
	public void set_InvertX(bool value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E52")]
	public void set_InvertY(bool value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E54")]
	public void set_IsPanningEnabled(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E47")]
	public void set_PanMode(CameraPanMode value) { }

	[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4B")]
	public void set_SmoothPanSensitivity(float value) { }

	[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4E")]
	public void set_SmoothValue(float value) { }

	[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E49")]
	public void set_StandardPanSensitivity(float value) { }

}

