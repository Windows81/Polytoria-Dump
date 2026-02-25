namespace RLD;

[Token(Token = "0x200017B")]
public class MouseInputDevice : InputDeviceBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000671")]
	private Vector3 _frameDelta; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000672")]
	private Vector3 _mousePosInLastFrame; //Field offset: 0x3C

	[Token(Token = "0x1700056E")]
	public virtual InputDeviceType DeviceType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BD")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x561DF0", Offset = "0x560FF0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010BE")]
	public MouseInputDevice() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BD")]
	public virtual InputDeviceType get_DeviceType() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BF")]
	public virtual Vector3 GetFrameDelta() { }

	[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C1")]
	public virtual Vector3 GetPositionYAxisUp() { }

	[Address(RVA = "0x561C40", Offset = "0x560E40", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010C0")]
	public virtual Ray GetRay(Camera camera) { }

	[Address(RVA = "0x561CB0", Offset = "0x560EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C2")]
	public virtual bool HasPointer() { }

	[Address(RVA = "0x561CC0", Offset = "0x560EC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C3")]
	public virtual bool IsButtonPressed(int buttonIndex) { }

	[Address(RVA = "0x561CD0", Offset = "0x560ED0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Token(Token = "0x60010C7")]
	protected virtual void UpateFrameDeltas() { }

	[Address(RVA = "0x561D50", Offset = "0x560F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C4")]
	public virtual bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	[Address(RVA = "0x561D60", Offset = "0x560F60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C5")]
	public virtual bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	[Address(RVA = "0x561D70", Offset = "0x560F70", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C6")]
	public virtual bool WasMoved() { }

}

