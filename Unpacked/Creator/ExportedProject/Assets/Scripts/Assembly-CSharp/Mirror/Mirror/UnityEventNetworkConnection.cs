namespace Mirror;

[Token(Token = "0x2000034")]
public class UnityEventNetworkConnection : UnityEvent<NetworkConnectionToClient>
{

	[Address(RVA = "0x126FCF0", Offset = "0x126EEF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000CE")]
	public UnityEventNetworkConnection() { }

}

