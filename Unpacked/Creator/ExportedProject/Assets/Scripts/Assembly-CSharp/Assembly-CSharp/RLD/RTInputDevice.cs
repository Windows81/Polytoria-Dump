namespace RLD;

[Token(Token = "0x200017C")]
public class RTInputDevice : MonoSingleton<RTInputDevice>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000673")]
	private IInputDevice _inputDevice; //Field offset: 0x20

	[Token(Token = "0x1700056F")]
	public IInputDevice Device
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000570")]
	public InputDeviceType DeviceType
	{
		[Address(RVA = "0x56AEE0", Offset = "0x56A0E0", Length = "0xBD")]
		[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTFocusCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60010C9")]
		 get { } //Length: 189
	}

	[Address(RVA = "0x56AE80", Offset = "0x56A080", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010CC")]
	public RTInputDevice() { }

	[Address(RVA = "0x56AD30", Offset = "0x569F30", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010CB")]
	private void Awake() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C8")]
	public IInputDevice get_Device() { }

	[Address(RVA = "0x56AEE0", Offset = "0x56A0E0", Length = "0xBD")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60010C9")]
	public InputDeviceType get_DeviceType() { }

	[Address(RVA = "0x56AE30", Offset = "0x56A030", Length = "0x49")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010CA")]
	public void Update_SystemCall() { }

}

