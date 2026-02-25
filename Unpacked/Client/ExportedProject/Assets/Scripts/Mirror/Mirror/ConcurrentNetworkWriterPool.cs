namespace Mirror;

[Token(Token = "0x2000088")]
public static class ConcurrentNetworkWriterPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000089")]
	private sealed class <>c
	{
		[Token(Token = "0x40001D3")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x12A44D0", Offset = "0x12A36D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000476")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000477")]
		public <>c() { }

		[Address(RVA = "0x12A41E0", Offset = "0x12A33E0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NetworkWriter), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000478")]
		internal ConcurrentNetworkWriterPooled <.cctor>b__6_0() { }

	}

	[Token(Token = "0x40001D1")]
	public const int InitialCapacity = 1000; //Field offset: 0x0
	[Token(Token = "0x40001D2")]
	private static readonly ConcurrentPool<ConcurrentNetworkWriterPooled> pool; //Field offset: 0x0

	[Token(Token = "0x1700007E")]
	public static int Count
	{
		[Address(RVA = "0x1288C10", Offset = "0x1287E10", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ConcurrentPool`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000472")]
		 get { } //Length: 111
	}

	[Address(RVA = "0x1288B00", Offset = "0x1287D00", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConcurrentPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000475")]
	private static ConcurrentNetworkWriterPool() { }

	[Address(RVA = "0x1288990", Offset = "0x1287B90", Length = "0xCD")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedClientReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedServerReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "SendHandshakeAndPubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Transports.Encryption.EncryptedConnection+OpCodes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "SendHandshakeFin", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000473")]
	public static ConcurrentNetworkWriterPooled Get() { }

	[Address(RVA = "0x1288C10", Offset = "0x1287E10", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentPool`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000472")]
	public static int get_Count() { }

	[Address(RVA = "0x1288A60", Offset = "0x1287C60", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000474")]
	public static void Return(ConcurrentNetworkWriterPooled writer) { }

}

