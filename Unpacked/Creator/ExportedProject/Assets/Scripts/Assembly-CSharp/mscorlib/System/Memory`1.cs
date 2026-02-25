namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
[Token(Token = "0x200010E")]
public struct Memory : IEquatable<Memory`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000432")]
	private readonly object _object; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000433")]
	private readonly int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000434")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x17000090")]
	public int Length
	{
		[Address(RVA = "0xE0A680", Offset = "0xE09880", Length = "0x8")]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000871")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000091")]
	public Span<T> Span
	{
		[Address(RVA = "0xDFD2D0", Offset = "0xDFC4D0", Length = "0x3C8")]
		[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Memory`1), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
		[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000874")]
		 get { } //Length: 968
	}

	[Address(RVA = "0xE0A5B0", Offset = "0xE097B0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600086C")]
	public Memory`1(T[] array) { }

	[Address(RVA = "0xE0A600", Offset = "0xE09800", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600086D")]
	public Memory`1(T[] array, int start, int length) { }

	[Address(RVA = "0x89CC80", Offset = "0x89BE80", Length = "0x228")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D86A0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086E")]
	internal Memory`1(object obj, int start, int length) { }

	[Address(RVA = "0xE08BA0", Offset = "0xE07DA0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	private static int CombineHashCodes(int left, int right) { }

	[Address(RVA = "0xE08B30", Offset = "0xE07D30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600087B")]
	private static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0xE08F70", Offset = "0xE08170", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000877")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE08F50", Offset = "0xE08150", Length = "0x1D")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000878")]
	public override bool Equals(Memory<T> other) { }

	[Address(RVA = "0xE0A680", Offset = "0xE09880", Length = "0x8")]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000871")]
	public int get_Length() { }

	[Address(RVA = "0xDFD2D0", Offset = "0xDFC4D0", Length = "0x3C8")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Memory`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000874")]
	public Span<T> get_Span() { }

	[Address(RVA = "0xE09190", Offset = "0xE08390", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000879")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE0A690", Offset = "0xE09890", Length = "0x6A")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&", typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint&", typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&", typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint", typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs", typeof(AsyncCallback), typeof(object), "System.Net.Sockets.SocketOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SocketAsyncResult", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.Socket", typeof(AsyncCallback), typeof(object), "System.Net.Sockets.SocketOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600086F")]
	public static Memory<T> op_Implicit(T[] array) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000870")]
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }

	[Address(RVA = "0xE09A20", Offset = "0xE08C20", Length = "0x2D4")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IOAsyncResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint&", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncResult", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(MemoryHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(GCHandle), typeof(IPinnable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000875")]
	public MemoryHandle Pin() { }

	[Address(RVA = "0xE09D00", Offset = "0xE08F00", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000873")]
	public Memory<T> Slice(int start, int length) { }

	[Address(RVA = "0xE09F10", Offset = "0xE09110", Length = "0x80")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.Sockets.Socket")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&), typeof(IAsyncResult)}, ReturnType = "System.Net.Sockets.Socket")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180673960")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000876")]
	public T[] ToArray() { }

	[Address(RVA = "0xE0A3B0", Offset = "0xE095B0", Length = "0x1F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Span`1<System.Byte>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000872")]
	public virtual string ToString() { }

}

