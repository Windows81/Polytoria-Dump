namespace Mirror.SimpleWeb;

[Token(Token = "0x200000C")]
internal static class SimpleWebJSLib
{

	[Address(RVA = "0x155C5A0", Offset = "0x155B7A0", Length = "0x3E")]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000023")]
	internal static int Connect(string address, Action<Int32> openCallback, Action<Int32> closeCallBack, Action<Int32, IntPtr, Int32> messageCallback, Action<Int32> errorCallback) { }

	[Address(RVA = "0x155C5E0", Offset = "0x155B7E0", Length = "0x3E")]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "Disconnect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000024")]
	internal static void Disconnect(int index) { }

	[Address(RVA = "0x155C620", Offset = "0x155B820", Length = "0x3E")]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "CheckJsConnected", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000022")]
	internal static bool IsConnected(int index) { }

	[Address(RVA = "0x155C660", Offset = "0x155B860", Length = "0x3E")]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "OpenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "onOpen", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000025")]
	internal static bool Send(int index, Byte[] array, int offset, int length) { }

}

