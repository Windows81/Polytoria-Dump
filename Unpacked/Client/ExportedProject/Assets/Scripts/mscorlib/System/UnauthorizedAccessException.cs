namespace System;

[Token(Token = "0x200014C")]
public class UnauthorizedAccessException : SystemException
{

	[Address(RVA = "0x14CD550", Offset = "0x14CC750", Length = "0x81")]
	[CalledBy(Type = typeof(Kernel32), Member = "DeleteVolumeMountPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B68")]
	public UnauthorizedAccessException() { }

	[Address(RVA = "0x14CD5E0", Offset = "0x14CC7E0", Length = "0x61")]
	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryStream), Member = "GetBuffer", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B69")]
	public UnauthorizedAccessException(string message) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6A")]
	protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) { }

}

