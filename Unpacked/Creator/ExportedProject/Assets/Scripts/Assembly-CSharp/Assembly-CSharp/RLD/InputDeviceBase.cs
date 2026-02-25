namespace RLD;

[Token(Token = "0x2000177")]
public abstract class InputDeviceBase : IInputDevice
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065F")]
	private InputDeviceDoubleTapHandler DoubleTap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000660")]
	private float _doubleTapDelay; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000661")]
	private float _lastTapTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000662")]
	private bool _didDoubleTap; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000663")]
	private int _maxNumDeltaCaptures; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000664")]
	private InputDeviceDeltaCapture[] _deltaCaptures; //Field offset: 0x28

	[Token(Token = "0x14000025")]
	public override event InputDeviceDoubleTapHandler DoubleTap
	{
		[Address(RVA = "0x561870", Offset = "0x560A70", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60010A1")]
		 add { } //Length: 158
		[Address(RVA = "0x561910", Offset = "0x560B10", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60010A2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700056A")]
	public abstract InputDeviceType DeviceType
	{
		[Token(Token = "0x60010A6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000568")]
	public override bool DidDoubleTap
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010A3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000569")]
	public override float DoubleTapDelay
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010A4")]
		 get { } //Length: 6
		[Address(RVA = "0x5619B0", Offset = "0x560BB0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010A5")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x561810", Offset = "0x560A10", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010A7")]
	public InputDeviceBase() { }

	[Address(RVA = "0x561870", Offset = "0x560A70", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60010A1")]
	public override void add_DoubleTap(InputDeviceDoubleTapHandler value) { }

	[Address(RVA = "0x561210", Offset = "0x560410", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010A9")]
	public override bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId) { }

	[Address(RVA = "0x561340", Offset = "0x560540", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60010B7")]
	private void DetectAndHandleDoubleTap() { }

	[Token(Token = "0x60010A6")]
	public abstract InputDeviceType get_DeviceType() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010A3")]
	public override bool get_DidDoubleTap() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010A4")]
	public override float get_DoubleTapDelay() { }

	[Address(RVA = "0x561400", Offset = "0x560600", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010AB")]
	public override Vector3 GetCaptureDelta(int deltaCaptureId) { }

	[Token(Token = "0x60010AC")]
	public abstract Vector3 GetFrameDelta() { }

	[Token(Token = "0x60010AE")]
	public abstract Vector3 GetPositionYAxisUp() { }

	[Token(Token = "0x60010AD")]
	public abstract Ray GetRay(Camera camera) { }

	[Token(Token = "0x60010AF")]
	public abstract bool HasPointer() { }

	[Token(Token = "0x60010B0")]
	public abstract bool IsButtonPressed(int buttonIndex) { }

	[Address(RVA = "0x561910", Offset = "0x560B10", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60010A2")]
	public override void remove_DoubleTap(InputDeviceDoubleTapHandler value) { }

	[Address(RVA = "0x5614B0", Offset = "0x5606B0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60010AA")]
	public override void RemoveDeltaCapture(int deltaCaptureId) { }

	[Address(RVA = "0x5619B0", Offset = "0x560BB0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010A5")]
	public override void set_DoubleTapDelay(float value) { }

	[Address(RVA = "0x561500", Offset = "0x560700", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60010A8")]
	public void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures) { }

	[Token(Token = "0x60010B5")]
	protected abstract void UpateFrameDeltas() { }

	[Address(RVA = "0x561660", Offset = "0x560860", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60010B4")]
	public override void Update() { }

	[Address(RVA = "0x561560", Offset = "0x560760", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B6")]
	private void UpdateDeltaCaptures() { }

	[Token(Token = "0x60010B1")]
	public abstract bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	[Token(Token = "0x60010B2")]
	public abstract bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	[Token(Token = "0x60010B3")]
	public abstract bool WasMoved() { }

}

