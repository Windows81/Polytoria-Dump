namespace Mirror;

[DisallowMultipleComponent]
[Token(Token = "0x2000004")]
public abstract class MiddlewareTransport : Transport
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000006")]
	public Transport inner; //Field offset: 0x88

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	protected MiddlewareTransport() { }

	[Address(RVA = "0x10A3E50", Offset = "0x10A3050", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public virtual bool Available() { }

	[Address(RVA = "0x10A3E80", Offset = "0x10A3080", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x10A3F60", Offset = "0x10A3160", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x10A3F90", Offset = "0x10A3190", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x10A3FC0", Offset = "0x10A31C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x10A3FF0", Offset = "0x10A31F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public virtual void ClientLateUpdate() { }

	[Address(RVA = "0x10A4020", Offset = "0x10A3220", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x10A4060", Offset = "0x10A3260", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public virtual int GetBatchThreshold(int channelId = 0) { }

	[Address(RVA = "0x10A4090", Offset = "0x10A3290", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x10A40C0", Offset = "0x10A32C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x10A40F0", Offset = "0x10A32F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x10A4120", Offset = "0x10A3320", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x10A4150", Offset = "0x10A3350", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x10A4180", Offset = "0x10A3380", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x10A41B0", Offset = "0x10A33B0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x10A4200", Offset = "0x10A3400", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x10A4300", Offset = "0x10A3500", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x10A4330", Offset = "0x10A3530", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public virtual void Shutdown() { }

}

