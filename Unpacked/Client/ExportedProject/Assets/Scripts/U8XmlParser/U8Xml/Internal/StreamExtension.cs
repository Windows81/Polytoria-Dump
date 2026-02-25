namespace U8Xml.Internal;

[Extension]
[Token(Token = "0x200002F")]
internal static class StreamExtension
{

	[Address(RVA = "0x180ACB0", Offset = "0x1809EB0", Length = "0x1AB")]
	[CalledBy(Type = typeof(StreamExtension), Member = "ReadAllToUnmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<U8Xml.Internal.UnmanagedBuffer, System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181806A20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181806B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E6")]
	internal static void <ReadAllToUnmanaged>g__ExtendBuffer|0_0(ref UnmanagedBuffer buf, int currentUsedLen) { }

	[Address(RVA = "0x180A840", Offset = "0x1809A40", Length = "0x46F")]
	[CalledBy(Type = typeof(FileHelper), Member = "ReadFileToUnmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.ValueTuple`2<U8Xml.Internal.UnmanagedBuffer, System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA4B0")]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(StreamExtension), Member = "<ReadAllToUnmanaged>g__ExtendBuffer|0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedBuffer&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181806B10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60000E5")]
	public static ValueTuple<UnmanagedBuffer, Int32> ReadAllToUnmanaged(Stream stream, int fileSizeHint) { }

}

