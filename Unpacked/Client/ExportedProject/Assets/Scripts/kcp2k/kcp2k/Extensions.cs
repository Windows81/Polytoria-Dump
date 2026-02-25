namespace kcp2k;

[Extension]
[Token(Token = "0x2000006")]
public static class Extensions
{

	[Address(RVA = "0x109A780", Offset = "0x1099980", Length = "0x132")]
	[CalledBy(Type = typeof(KcpServer), Member = "RawReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArraySegment`1<Byte>&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600000B")]
	public static bool ReceiveFromNonBlocking(Socket socket, Byte[] recvBuffer, out ArraySegment<Byte>& data, ref EndPoint remoteEP) { }

	[Address(RVA = "0x109A8C0", Offset = "0x1099AC0", Length = "0x11D")]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "RawReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "RawReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>&", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KcpClient), Member = "RawReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600000C")]
	public static bool ReceiveNonBlocking(Socket socket, Byte[] recvBuffer, out ArraySegment<Byte>& data) { }

	[Address(RVA = "0x109A9E0", Offset = "0x1099BE0", Length = "0xFC")]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "SendPing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpClient), Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600000A")]
	public static bool SendNonBlocking(Socket socket, ArraySegment<Byte> data) { }

	[Address(RVA = "0x109AAE0", Offset = "0x1099CE0", Length = "0x111")]
	[CalledBy(Type = typeof(KcpServer), Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Socket), Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000009")]
	public static bool SendToNonBlocking(Socket socket, ArraySegment<Byte> data, EndPoint remoteEP) { }

	[Address(RVA = "0x109AC00", Offset = "0x1099E00", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Extension]
	[Token(Token = "0x6000008")]
	public static string ToHexString(ArraySegment<Byte> segment) { }

}

