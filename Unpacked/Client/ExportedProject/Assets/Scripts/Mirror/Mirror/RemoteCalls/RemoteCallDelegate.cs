namespace Mirror.RemoteCalls;

[Token(Token = "0x20000A4")]
public sealed class RemoteCallDelegate : MulticastDelegate
{

	[Address(RVA = "0x3354E0", Offset = "0x3346E0", Length = "0x125")]
	[CallerCount(Count = 170)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000519")]
	public RemoteCallDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x335480", Offset = "0x334680", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600051B")]
	public override IAsyncResult BeginInvoke(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x600051C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051A")]
	public override void Invoke(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

}

