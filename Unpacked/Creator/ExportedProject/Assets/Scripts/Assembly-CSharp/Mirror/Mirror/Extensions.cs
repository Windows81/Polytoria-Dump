namespace Mirror;

[Extension]
[Token(Token = "0x2000094")]
public static class Extensions
{

	[Address(RVA = "0x6B31A0", Offset = "0x6B23A0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60004B7")]
	public static void Clear(ConcurrentQueue<T> source) { }

	[Address(RVA = "0x6B32D0", Offset = "0x6B24D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60004B5")]
	public static void CopyTo(IEnumerable<T> source, List<T> destination) { }

	[Address(RVA = "0x12891A0", Offset = "0x12883A0", Length = "0x35")]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler+MessageStats", Member = "RecordRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(MessageInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60004B4")]
	public static string GetMethodName(Delegate func) { }

	[Address(RVA = "0x1289250", Offset = "0x1288450", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60004B2")]
	public static int GetStableHashCode(string text) { }

	[Address(RVA = "0x12891E0", Offset = "0x12883E0", Length = "0x60")]
	[CalledBy(Type = typeof(NetworkMessageId`1), Member = "CalculateId", ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(NetworkMessageId`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60004B3")]
	public static ushort GetStableHashCode16(string text) { }

	[Address(RVA = "0x12892B0", Offset = "0x12884B0", Length = "0x9F")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ServerGetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "<Awake>b__29_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedServerConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport+<>c__DisplayClass23_0", Member = "<HandleInnerServerConnected>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "<Awake>b__8_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPAddress), Member = "get_IsIPv4MappedToIPv6", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPAddress), Member = "MapToIPv4", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x60004B8")]
	public static string PrettyAddress(IPEndPoint endPoint) { }

	[Address(RVA = "0x1289350", Offset = "0x1288550", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Extension]
	[Token(Token = "0x60004B1")]
	public static string ToHexString(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x6B3330", Offset = "0x6B2530", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60004B6")]
	public static bool TryDequeue(Queue<T> source, out T element) { }

}

