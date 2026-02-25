namespace Mirror;

[Token(Token = "0x2000048")]
public class NetworkConnectionToServer : NetworkConnection
{

	[Address(RVA = "0x12653A0", Offset = "0x12645A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001DC")]
	public NetworkConnectionToServer() { }

	[Address(RVA = "0x1265280", Offset = "0x1264480", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DB")]
	public virtual void Disconnect() { }

	[Address(RVA = "0x1265320", Offset = "0x1264520", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DA")]
	protected virtual void SendToTransport(ArraySegment<Byte> segment, int channelId = 0) { }

}

