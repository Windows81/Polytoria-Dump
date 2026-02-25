namespace System.IO;

[Token(Token = "0x2000630")]
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001917")]
	private Byte[] _array; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001918")]
	private GCHandle _pinningHandle; //Field offset: 0x70

	[Address(RVA = "0x1460F00", Offset = "0x1460100", Length = "0x118")]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(long), typeof(FileAccess)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002D26")]
	internal PinnedBufferMemoryStream(Byte[] array) { }

	[Address(RVA = "0x1460E80", Offset = "0x1460080", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Token(Token = "0x6002D2A")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1354BF0", Offset = "0x1353DF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D29")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1460EC0", Offset = "0x14600C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[Token(Token = "0x6002D27")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x1460EE0", Offset = "0x14600E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D28")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

}

