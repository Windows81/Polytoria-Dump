namespace RLD;

[Token(Token = "0x200017D")]
public class TouchInputDevice : InputDeviceBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000674")]
	private int _maxNumberOfTouches; //Field offset: 0x30

	[Token(Token = "0x17000573")]
	public virtual InputDeviceType DeviceType
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000571")]
	public int MaxNumberOfTouches
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CD")]
		 get { } //Length: 174
	}

	[Token(Token = "0x17000572")]
	public int TouchCount
	{
		[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CE")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x56CD80", Offset = "0x56BF80", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010D0")]
	public TouchInputDevice(int maxNumberOfTouches) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010CF")]
	public virtual InputDeviceType get_DeviceType() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60010CD")]
	public int get_MaxNumberOfTouches() { }

	[Address(RVA = "0x56CE00", Offset = "0x56C000", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010CE")]
	public int get_TouchCount() { }

	[Address(RVA = "0x56C720", Offset = "0x56B920", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010D1")]
	public virtual Vector3 GetFrameDelta() { }

	[Address(RVA = "0x56C820", Offset = "0x56BA20", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010D3")]
	public virtual Vector3 GetPositionYAxisUp() { }

	[Address(RVA = "0x56C920", Offset = "0x56BB20", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010D2")]
	public virtual Ray GetRay(Camera camera) { }

	[Address(RVA = "0x56CAD0", Offset = "0x56BCD0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010D4")]
	public virtual bool HasPointer() { }

	[Address(RVA = "0x56CAF0", Offset = "0x56BCF0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010D5")]
	public virtual bool IsButtonPressed(int buttonIndex) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D9")]
	protected virtual void UpateFrameDeltas() { }

	[Address(RVA = "0x56CB30", Offset = "0x56BD30", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010D6")]
	public virtual bool WasButtonPressedInCurrentFrame(int buttonIndex) { }

	[Address(RVA = "0x56CBE0", Offset = "0x56BDE0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010D7")]
	public virtual bool WasButtonReleasedInCurrentFrame(int buttonIndex) { }

	[Address(RVA = "0x56CCC0", Offset = "0x56BEC0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Token(Token = "0x60010D8")]
	public virtual bool WasMoved() { }

}

