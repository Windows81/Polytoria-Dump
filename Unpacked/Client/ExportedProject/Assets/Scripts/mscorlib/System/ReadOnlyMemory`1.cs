namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
[Token(Token = "0x2000128")]
public struct ReadOnlyMemory : IEquatable<ReadOnlyMemory`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000459")]
	private readonly object _object; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045A")]
	private readonly int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045B")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x1700009E")]
	public int Length
	{
		[Address(RVA = "0xE0A680", Offset = "0xE09880", Length = "0x8")]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000955")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009F")]
	public ReadOnlySpan<T> Span
	{
		[Address(RVA = "0xEFC490", Offset = "0xEFB690", Length = "0x401")]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(ReadOnlyMemory`1), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000957")]
		 get { } //Length: 1025
	}

	[Address(RVA = "0xE0A600", Offset = "0xE09800", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000954")]
	public ReadOnlyMemory`1(T[] array, int start, int length) { }

	[Address(RVA = "0xE08BA0", Offset = "0xE07DA0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095B")]
	private static int CombineHashCodes(int left, int right) { }

	[Address(RVA = "0xE08B30", Offset = "0xE07D30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600095C")]
	private static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0xF01F60", Offset = "0xF01160", Length = "0x21E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000958")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE08F50", Offset = "0xE08150", Length = "0x1D")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000959")]
	public override bool Equals(ReadOnlyMemory<T> other) { }

	[Address(RVA = "0xE0A680", Offset = "0xE09880", Length = "0x8")]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000955")]
	public int get_Length() { }

	[Address(RVA = "0xEFC490", Offset = "0xEFB690", Length = "0x401")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(ReadOnlyMemory`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000957")]
	public ReadOnlySpan<T> get_Span() { }

	[Address(RVA = "0xF02180", Offset = "0xF01380", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF02340", Offset = "0xF01540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095D")]
	internal object GetObjectStartLength(out int start, out int length) { }

	[Address(RVA = "0xF02350", Offset = "0xF01550", Length = "0x329")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000956")]
	public virtual string ToString() { }

}

