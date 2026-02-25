namespace Mirror;

[Token(Token = "0x2000020")]
public class LocalConnectionToClient : NetworkConnectionToClient
{
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400004D")]
	internal LocalConnectionToServer connectionToServer; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400004E")]
	internal readonly Queue<NetworkWriterPooled> queue; //Field offset: 0x128

	[Address(RVA = "0x1250F40", Offset = "0x1250140", Length = "0x93")]
	[CalledBy(Type = typeof(Utils), Member = "CreateLocalConnections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient&), typeof(LocalConnectionToServer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B5")]
	public LocalConnectionToClient() { }

	[Address(RVA = "0x1250AD0", Offset = "0x124FCD0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "RemoveFromObservingsObservers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BB")]
	public virtual void Disconnect() { }

	[Address(RVA = "0x1250AC0", Offset = "0x124FCC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "RemoveFromObservingsObservers", ReturnType = typeof(void))]
	[Token(Token = "0x60000BA")]
	internal void DisconnectInternal() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B7")]
	internal virtual bool IsAlive(float timeout) { }

	[Address(RVA = "0x1250B50", Offset = "0x124FD50", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B6")]
	internal virtual void Send(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1250C50", Offset = "0x124FE50", Length = "0x2ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Batcher), Member = "GetBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Batcher), Member = "AddMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkConnection), Member = "GetBatchForChannelId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Batcher))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(NetworkConnection), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B9")]
	internal virtual void Update() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	protected virtual void UpdatePing() { }

}

