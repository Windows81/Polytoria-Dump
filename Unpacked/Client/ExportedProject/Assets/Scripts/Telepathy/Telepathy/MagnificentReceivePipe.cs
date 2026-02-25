namespace Telepathy;

[Token(Token = "0x200000C")]
public class MagnificentReceivePipe
{
	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000027")]
		public int MaxMessageSize; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x18062F0", Offset = "0x18054F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6000020")]
		internal Byte[] <.ctor>b__0() { }

	}

	[Token(Token = "0x200000D")]
	private struct Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		public int connectionId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000025")]
		public EventType eventType; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000026")]
		public ArraySegment<Byte> data; //Field offset: 0x8

		[Address(RVA = "0x1802800", Offset = "0x1801A00", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600001E")]
		public Entry(int connectionId, EventType eventType, ArraySegment<Byte> data) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000021")]
	private readonly Queue<Entry> queue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000022")]
	private Pool<Byte[]> pool; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000023")]
	private Dictionary<Int32, Int32> queueCounter; //Field offset: 0x20

	[Token(Token = "0x17000006")]
	public int PoolCount
	{
		[Address(RVA = "0x1803570", Offset = "0x1802770", Length = "0xC3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 195
	}

	[Token(Token = "0x17000005")]
	public int TotalCount
	{
		[Address(RVA = "0x1803640", Offset = "0x1802840", Length = "0xB8")]
		[CalledBy(Type = typeof(Client), Member = "get_ReceivePipeCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Client), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Server), Member = "get_ReceivePipeTotalCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 184
	}

	[Address(RVA = "0x18033E0", Offset = "0x18025E0", Length = "0x180")]
	[CalledBy(Type = typeof(ClientConnectionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Client), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Server), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000016")]
	public MagnificentReceivePipe(int MaxMessageSize) { }

	[Address(RVA = "0x18029D0", Offset = "0x1801BD0", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<T>", "System.ArraySegment`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600001D")]
	public void Clear() { }

	[Address(RVA = "0x1802BD0", Offset = "0x1801DD0", Length = "0xE8")]
	[CalledBy(Type = typeof(MagnificentReceivePipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventType), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadFunctions), Member = "ReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(int), typeof(MagnificentReceivePipe), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000017")]
	public int Count(int connectionId) { }

	[Address(RVA = "0x1802CC0", Offset = "0x1801EC0", Length = "0x2D4")]
	[CalledBy(Type = typeof(WebProxy), Member = "set_UseDefaultCredentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Client), Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientConnectionState), typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadFunctions), Member = "ReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(int), typeof(MagnificentReceivePipe), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArraySegment`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<T>", "System.ArraySegment`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "Count", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Pool`1), Member = "Take", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001A")]
	public void Enqueue(int connectionId, EventType eventType, ArraySegment<Byte> message) { }

	[Address(RVA = "0x1803570", Offset = "0x1802770", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public int get_PoolCount() { }

	[Address(RVA = "0x1803640", Offset = "0x1802840", Length = "0xB8")]
	[CalledBy(Type = typeof(Client), Member = "get_ReceivePipeCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Client), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Server), Member = "get_ReceivePipeTotalCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000018")]
	public int get_TotalCount() { }

	[Address(RVA = "0x1802FA0", Offset = "0x18021A0", Length = "0x2AB")]
	[CalledBy(Type = typeof(Client), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<T>", "System.ArraySegment`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600001C")]
	public bool TryDequeue() { }

	[Address(RVA = "0x1803250", Offset = "0x1802450", Length = "0x18B")]
	[CalledBy(Type = typeof(Client), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600001B")]
	public bool TryPeek(out int connectionId, out EventType eventType, out ArraySegment<Byte>& data) { }

}

