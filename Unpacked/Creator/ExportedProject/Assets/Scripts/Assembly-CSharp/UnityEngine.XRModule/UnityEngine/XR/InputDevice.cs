namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[Token(Token = "0x200000A")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000038")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000039")]
	private bool m_Initialized; //Field offset: 0x8

	[Token(Token = "0x17000006")]
	private ulong deviceId
	{
		[Address(RVA = "0x1D01690", Offset = "0x1D00890", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600000B")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x1D01680", Offset = "0x1D00880", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000A")]
	internal InputDevice(ulong deviceId) { }

	[Address(RVA = "0x1D01570", Offset = "0x1D00770", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1D01620", Offset = "0x1D00820", Length = "0x25")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000D")]
	public override bool Equals(InputDevice other) { }

	[Address(RVA = "0x1D01690", Offset = "0x1D00890", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000B")]
	private ulong get_deviceId() { }

	[Address(RVA = "0x1D01650", Offset = "0x1D00850", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600000E")]
	public virtual int GetHashCode() { }

}

