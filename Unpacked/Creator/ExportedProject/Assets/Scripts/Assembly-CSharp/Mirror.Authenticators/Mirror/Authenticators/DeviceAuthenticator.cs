namespace Mirror.Authenticators;

[AddComponentMenu("Network/ Authenticators/Device Authenticator")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-authenticators/device-authenticator")]
[Token(Token = "0x2000008")]
public class DeviceAuthenticator : NetworkAuthenticator
{
	[Token(Token = "0x2000009")]
	internal struct AuthRequestMessage : NetworkMessage
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		public string clientDeviceID; //Field offset: 0x0

	}

	[Token(Token = "0x200000A")]
	internal struct AuthResponseMessage : NetworkMessage
	{

	}


	[Address(RVA = "0x410170", Offset = "0x40F370", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkAuthenticator), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	public DeviceAuthenticator() { }

	[Address(RVA = "0x10A4AF0", Offset = "0x10A3CF0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkAuthenticator), Member = "ServerAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000016")]
	private void OnAuthRequestMessage(NetworkConnectionToClient conn, AuthRequestMessage msg) { }

	[Address(RVA = "0x10A4BF0", Offset = "0x10A3DF0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkAuthenticator), Member = "ClientAccept", ReturnType = typeof(void))]
	[Token(Token = "0x600001A")]
	public void OnAuthResponseMessage(AuthResponseMessage msg) { }

	[Address(RVA = "0x10A4C60", Offset = "0x10A3E60", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemInfo), Member = "get_deviceUniqueIdentifier", ReturnType = typeof(string))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthRequestMessage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthRequestMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public virtual void OnClientAuthenticate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public virtual void OnServerAuthenticate(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x10A4D60", Offset = "0x10A3F60", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000017")]
	public virtual void OnStartClient() { }

	[Address(RVA = "0x10A4E10", Offset = "0x10A4010", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthRequestMessage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<Mirror.NetworkConnectionToClient, Mirror.Authenticators.DeviceAuthenticator+AuthRequestMessage>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public virtual void OnStartServer() { }

	[Address(RVA = "0x10A4EC0", Offset = "0x10A40C0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "UnregisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000018")]
	public virtual void OnStopClient() { }

	[Address(RVA = "0x10A4F20", Offset = "0x10A4120", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "UnregisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000014")]
	public virtual void OnStopServer() { }

}

