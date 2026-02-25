namespace Mirror;

[Token(Token = "0x2000021")]
public class LocalConnectionToServer : NetworkConnectionToServer
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400004F")]
	internal LocalConnectionToClient connectionToClient; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000050")]
	internal readonly Queue<NetworkWriterPooled> queue; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000051")]
	private bool connectedEventPending; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000052")]
	private bool disconnectedEventPending; //Field offset: 0x59

	[Address(RVA = "0x12517E0", Offset = "0x12509E0", Length = "0x77")]
	[CalledBy(Type = typeof(Utils), Member = "CreateLocalConnections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient&), typeof(LocalConnectionToServer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C3")]
	public LocalConnectionToServer() { }

	[Address(RVA = "0x1251040", Offset = "0x1250240", Length = "0x2AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "RemoveFromObservingsObservers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "RemoveLocalConnection", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkClient), Member = "RemoveTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C1")]
	public virtual void Disconnect() { }

	[Address(RVA = "0x1250FE0", Offset = "0x12501E0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000C0")]
	internal void DisconnectInternal() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	internal virtual bool IsAlive(float timeout) { }

	[Address(RVA = "0x12512F0", Offset = "0x12504F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000BC")]
	internal void QueueConnectedEvent() { }

	[Address(RVA = "0x1251300", Offset = "0x1250500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000BD")]
	internal void QueueDisconnectedEvent() { }

	[Address(RVA = "0x1251310", Offset = "0x1250510", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BE")]
	internal virtual void Send(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1251470", Offset = "0x1250670", Length = "0x363")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Batcher), Member = "GetBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Batcher), Member = "AddMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetworkConnection), Member = "GetBatchForChannelId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Batcher))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkConnection), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000BF")]
	internal virtual void Update() { }

}

