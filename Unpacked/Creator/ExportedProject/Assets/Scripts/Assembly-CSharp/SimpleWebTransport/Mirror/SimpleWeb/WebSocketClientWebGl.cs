namespace Mirror.SimpleWeb;

[Token(Token = "0x200000D")]
public class WebSocketClientWebGl : SimpleWebClient
{
	[Token(Token = "0x4000020")]
	private static readonly Dictionary<Int32, WebSocketClientWebGl> instances; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000021")]
	private int index; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000022")]
	private Queue<Byte[]> ConnectingSendQueue; //Field offset: 0x58

	[Address(RVA = "0x155F6C0", Offset = "0x155E8C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000033")]
	private static WebSocketClientWebGl() { }

	[Address(RVA = "0x155F750", Offset = "0x155E950", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600002B")]
	internal WebSocketClientWebGl(int maxMessageSize, int maxMessagesPerTick) { }

	[Address(RVA = "0x155EE30", Offset = "0x155E030", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "IsConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600002A")]
	public bool CheckJsConnected() { }

	[Address(RVA = "0x155EE40", Offset = "0x155E040", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(System.Action`1<System.Int32>))]
	[Token(Token = "0x6000027")]
	private static void CloseCallBack(int index) { }

	[Address(RVA = "0x155EF90", Offset = "0x155E190", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180184BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019FCF0")]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<System.Int32>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, System.IntPtr, System.Int32>), typeof(System.Action`1<System.Int32>)}, ReturnType = typeof(int))]
	[Token(Token = "0x600002C")]
	public virtual void Connect(Uri serverAddress) { }

	[Address(RVA = "0x155F0F0", Offset = "0x155E2F0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002D")]
	public virtual void Disconnect() { }

	[Address(RVA = "0x155F110", Offset = "0x155E310", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(System.Action`1<System.Int32>))]
	[Token(Token = "0x6000029")]
	private static void ErrorCallback(int index) { }

	[Address(RVA = "0x155F280", Offset = "0x155E480", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(WebSocketClientWebGl), Member = "onMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MonoPInvokeCallback(typeof(System.Action`3<System.Int32, System.IntPtr, System.Int32>))]
	[Token(Token = "0x6000028")]
	private static void MessageCallback(int index, IntPtr bufferPtr, int count) { }

	[Address(RVA = "0x155F7A0", Offset = "0x155E9A0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000030")]
	private void onClose() { }

	[Address(RVA = "0x155F880", Offset = "0x155EA80", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	private void onErr() { }

	[Address(RVA = "0x155F970", Offset = "0x155EB70", Length = "0x2C6")]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "MessageCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BufferPool), Member = "Take", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Log), Member = "Error", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000031")]
	private void onMessage(IntPtr bufferPtr, int count) { }

	[Address(RVA = "0x155FC40", Offset = "0x155EE40", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019FD00")]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600002F")]
	private void onOpen() { }

	[Address(RVA = "0x155F330", Offset = "0x155E530", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019FD00")]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[MonoPInvokeCallback(typeof(System.Action`1<System.Int32>))]
	[Token(Token = "0x6000026")]
	private static void OpenCallback(int index) { }

	[Address(RVA = "0x155F4A0", Offset = "0x155E6A0", Length = "0x21A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArraySegment`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(SimpleWebJSLib), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Log), Member = "Error", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C320")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800233A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "jinfo_get_method")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public virtual void Send(ArraySegment<Byte> segment) { }

}

