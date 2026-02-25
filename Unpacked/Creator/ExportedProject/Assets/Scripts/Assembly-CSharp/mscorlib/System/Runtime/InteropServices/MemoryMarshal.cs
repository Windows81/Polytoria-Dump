namespace System.Runtime.InteropServices;

[Token(Token = "0x200042E")]
public static class MemoryMarshal
{

	[Address(RVA = "0x701CF0", Offset = "0x700EF0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F51")]
	public static Span<Byte> AsBytes(Span<T> span) { }

	[Address(RVA = "0x701D90", Offset = "0x700F90", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F52")]
	public static ReadOnlySpan<Byte> AsBytes(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F53")]
	public static Memory<T> AsMemory(ReadOnlyMemory<T> memory) { }

	[Address(RVA = "0x702140", Offset = "0x701340", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F58")]
	public static ReadOnlySpan<T> CreateReadOnlySpan(ref T reference, int length) { }

	[Address(RVA = "0x702190", Offset = "0x701390", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F56")]
	internal static T GetNonNullPinnableReference(Span<T> span) { }

	[Address(RVA = "0x702190", Offset = "0x701390", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F57")]
	internal static T GetNonNullPinnableReference(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F54")]
	public static T GetReference(Span<T> span) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F55")]
	public static T GetReference(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x702230", Offset = "0x701430", Length = "0x2B5")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F59")]
	public static bool TryGetArray(ReadOnlyMemory<T> memory, out ArraySegment<T>& segment) { }

}

