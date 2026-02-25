namespace Mirror;

[Token(Token = "0x20000A0")]
public abstract class Transport : MonoBehaviour
{
	[Token(Token = "0x4000207")]
	public static Transport active; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000208")]
	public Action OnClientConnected; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000209")]
	public Action<ArraySegment`1<Byte>, Int32> OnClientDataReceived; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400020A")]
	public Action<ArraySegment`1<Byte>, Int32> OnClientDataSent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400020B")]
	public Action<TransportError, String> OnClientError; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400020C")]
	public Action<Exception> OnClientTransportException; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400020D")]
	public Action OnClientDisconnected; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Obsolete("Use OnServerConnectedWithAddress and pass the remote client address instead")]
	[Token(Token = "0x400020E")]
	public Action<Int32> OnServerConnected; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400020F")]
	public Action<Int32, String> OnServerConnectedWithAddress; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000210")]
	public Action<Int32, ArraySegment`1<Byte>, Int32> OnServerDataReceived; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000211")]
	public Action<Int32, ArraySegment`1<Byte>, Int32> OnServerDataSent; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000212")]
	public Action<Int32, TransportError, String> OnServerError; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000213")]
	public Action<Int32, Exception> OnServerTransportException; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000214")]
	public Action<Int32> OnServerDisconnected; //Field offset: 0x80

	[Token(Token = "0x17000085")]
	public override string EncryptionCipher
	{
		[Address(RVA = "0x12A4050", Offset = "0x12A3250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000500")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000084")]
	public override bool IsEncrypted
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FF")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000517")]
	protected Transport() { }

	[Token(Token = "0x60004FE")]
	public abstract bool Available() { }

	[Token(Token = "0x6000502")]
	public abstract void ClientConnect(string address) { }

	[Address(RVA = "0x12A3FF0", Offset = "0x12A31F0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000503")]
	public override void ClientConnect(Uri uri) { }

	[Token(Token = "0x6000501")]
	public abstract bool ClientConnected() { }

	[Token(Token = "0x6000505")]
	public abstract void ClientDisconnect() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000511")]
	public override void ClientEarlyUpdate() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000513")]
	public override void ClientLateUpdate() { }

	[Token(Token = "0x6000504")]
	public abstract void ClientSend(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x12A4050", Offset = "0x12A3250", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000500")]
	public override string get_EncryptionCipher() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FF")]
	public override bool get_IsEncrypted() { }

	[Address(RVA = "0x12A4030", Offset = "0x12A3230", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050E")]
	public override int GetBatchThreshold(int channelId = 0) { }

	[Token(Token = "0x600050D")]
	public abstract int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000510")]
	public void LateUpdate() { }

	[Address(RVA = "0x1283170", Offset = "0x1282370", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000516")]
	public override void OnApplicationQuit() { }

	[Token(Token = "0x6000507")]
	public abstract bool ServerActive() { }

	[Token(Token = "0x600050A")]
	public abstract void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000512")]
	public override void ServerEarlyUpdate() { }

	[Token(Token = "0x600050B")]
	public abstract string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000514")]
	public override void ServerLateUpdate() { }

	[Token(Token = "0x6000509")]
	public abstract void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId = 0) { }

	[Token(Token = "0x6000508")]
	public abstract void ServerStart() { }

	[Token(Token = "0x600050C")]
	public abstract void ServerStop() { }

	[Token(Token = "0x6000506")]
	public abstract Uri ServerUri() { }

	[Token(Token = "0x6000515")]
	public abstract void Shutdown() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050F")]
	public void Update() { }

}

