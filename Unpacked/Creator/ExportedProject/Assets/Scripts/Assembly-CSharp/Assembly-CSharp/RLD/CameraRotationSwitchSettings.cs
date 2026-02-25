namespace RLD;

[Token(Token = "0x200013A")]
public class CameraRotationSwitchSettings : Settings
{
	[Token(Token = "0x400059B")]
	private static readonly float _minConstantDuration; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400059C")]
	private CameraRotationSwitchMode _switchMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400059D")]
	private float _constantSwitchDurationInSeconds; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400059E")]
	private float _smoothValue; //Field offset: 0x30

	[Token(Token = "0x170004EF")]
	public float ConstantSwitchDurationInSeconds
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E85")]
		 get { } //Length: 6
		[Address(RVA = "0x53C670", Offset = "0x53B870", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000E86")]
		 set { } //Length: 103
	}

	[Token(Token = "0x170004F0")]
	public float SmoothValue
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E87")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E88")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170004EE")]
	public CameraRotationSwitchMode SwitchMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E83")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E84")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x53C5C0", Offset = "0x53B7C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E8A")]
	private static CameraRotationSwitchSettings() { }

	[Address(RVA = "0x53C600", Offset = "0x53B800", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E89")]
	public CameraRotationSwitchSettings() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E85")]
	public float get_ConstantSwitchDurationInSeconds() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E87")]
	public float get_SmoothValue() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E83")]
	public CameraRotationSwitchMode get_SwitchMode() { }

	[Address(RVA = "0x53C670", Offset = "0x53B870", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000E86")]
	public void set_ConstantSwitchDurationInSeconds(float value) { }

	[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E88")]
	public void set_SmoothValue(float value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E84")]
	public void set_SwitchMode(CameraRotationSwitchMode value) { }

}

