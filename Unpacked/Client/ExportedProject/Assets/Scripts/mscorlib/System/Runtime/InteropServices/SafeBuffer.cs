namespace System.Runtime.InteropServices;

[Token(Token = "0x2000432")]
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	[Token(Token = "0x4001198")]
	private static readonly UIntPtr Uninitialized; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001199")]
	private UIntPtr _numBytes; //Field offset: 0x20

	[Address(RVA = "0x13C9990", Offset = "0x13C8B90", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001F69")]
	private static SafeBuffer() { }

	[Address(RVA = "0x13C9790", Offset = "0x13C8990", Length = "0xDB")]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(SafeBuffer), Member = "NotInitialized", ReturnType = typeof(InvalidOperationException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	[Token(Token = "0x6001F66")]
	public void AcquirePointer(ref Byte* pointer) { }

	[Address(RVA = "0x13C9870", Offset = "0x13C8A70", Length = "0x58")]
	[CalledBy(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F68")]
	private static InvalidOperationException NotInitialized() { }

	[Address(RVA = "0x13C98D0", Offset = "0x13C8AD0", Length = "0xB1")]
	[CalledBy(Type = "System.Collections.SortedList+ValueList", Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(SafeBuffer), Member = "NotInitialized", ReturnType = typeof(InvalidOperationException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F67")]
	public void ReleasePointer() { }

}

