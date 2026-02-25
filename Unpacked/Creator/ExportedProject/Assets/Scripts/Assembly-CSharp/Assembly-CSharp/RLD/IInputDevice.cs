namespace RLD;

[Token(Token = "0x2000176")]
public interface IInputDevice
{

	[Token(Token = "0x14000024")]
	public event InputDeviceDoubleTapHandler DoubleTap
	{
		[CompilerGenerated]
		[Token(Token = "0x600108F")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x6001090")]
		 remove { } //Length: 0
	}

	[Token(Token = "0x17000567")]
	public InputDeviceType DeviceType
	{
		[Token(Token = "0x6001094")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000565")]
	public bool DidDoubleTap
	{
		[Token(Token = "0x6001091")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000566")]
	public float DoubleTapDelay
	{
		[Token(Token = "0x6001092")]
		 get { } //Length: 0
		[Token(Token = "0x6001093")]
		 set { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x600108F")]
	public void add_DoubleTap(InputDeviceDoubleTapHandler value) { }

	[Token(Token = "0x600109C")]
	public bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId) { }

	[Token(Token = "0x6001094")]
	public InputDeviceType get_DeviceType() { }

	[Token(Token = "0x6001091")]
	public bool get_DidDoubleTap() { }

	[Token(Token = "0x6001092")]
	public float get_DoubleTapDelay() { }

	[Token(Token = "0x600109E")]
	public Vector3 GetCaptureDelta(int deltaCaptureId) { }

	[Token(Token = "0x600109F")]
	public Vector3 GetFrameDelta() { }

	[Token(Token = "0x6001096")]
	public Vector3 GetPositionYAxisUp() { }

	[Token(Token = "0x6001095")]
	public Ray GetRay(Camera camera) { }

	[Token(Token = "0x6001097")]
	public bool HasPointer() { }

	[Token(Token = "0x6001098")]
	public bool IsButtonPressed(int buttonIndex) { }

	[CompilerGenerated]
	[Token(Token = "0x6001090")]
	public void remove_DoubleTap(InputDeviceDoubleTapHandler value) { }

	[Token(Token = "0x600109D")]
	public void RemoveDeltaCapture(int deltaCaptureId) { }

	[Token(Token = "0x6001093")]
	public void set_DoubleTapDelay(float value) { }

	[Token(Token = "0x60010A0")]
	public void Update() { }

	[Token(Token = "0x6001099")]
	public bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	[Token(Token = "0x600109A")]
	public bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	[Token(Token = "0x600109B")]
	public bool WasMoved() { }

}

