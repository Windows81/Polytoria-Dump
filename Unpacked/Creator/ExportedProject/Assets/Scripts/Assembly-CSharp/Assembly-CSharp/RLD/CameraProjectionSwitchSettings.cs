namespace RLD;

[Token(Token = "0x2000138")]
public class CameraProjectionSwitchSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000595")]
	private CameraProjectionSwitchMode _switchMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000596")]
	private float _transitionDurationInSeconds; //Field offset: 0x2C

	[Token(Token = "0x170004EC")]
	public CameraProjectionSwitchMode SwitchMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7E")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004ED")]
	public float TransitionDurationInSeconds
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E80")]
		 get { } //Length: 6
		[Address(RVA = "0x53C530", Offset = "0x53B730", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E81")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x53C4D0", Offset = "0x53B6D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E82")]
	public CameraProjectionSwitchSettings() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7E")]
	public CameraProjectionSwitchMode get_SwitchMode() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E80")]
	public float get_TransitionDurationInSeconds() { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7F")]
	public void set_SwitchMode(CameraProjectionSwitchMode value) { }

	[Address(RVA = "0x53C530", Offset = "0x53B730", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E81")]
	public void set_TransitionDurationInSeconds(float value) { }

}

