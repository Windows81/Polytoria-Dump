namespace System.IO;

[Token(Token = "0x200063D")]
internal static class Win32Marshal
{

	[Address(RVA = "0x146DAF0", Offset = "0x146CCF0", Length = "0x53")]
	[CalledBy(Type = typeof(DriveInfoInternal), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(FileSystem), Member = "MoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002DD0")]
	internal static Exception GetExceptionForLastWin32Error(string path = "") { }

	[Address(RVA = "0x146DB50", Offset = "0x146CD50", Length = "0x4EE")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002DD1")]
	internal static Exception GetExceptionForWin32Error(int errorCode, string path = "") { }

	[Address(RVA = "0x146E040", Offset = "0x146D240", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002DD4")]
	internal static string GetMessage(int errorCode) { }

	[Address(RVA = "0x146E050", Offset = "0x146D250", Length = "0x13")]
	[CalledBy(Type = typeof(FileSystem), Member = "MoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6002DD2")]
	internal static int MakeHRFromErrorCode(int errorCode) { }

	[Address(RVA = "0x146E070", Offset = "0x146D270", Length = "0x1C")]
	[CalledBy(Type = typeof(Kernel32), Member = "CopyFileUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002DD3")]
	internal static int TryMakeWin32ErrorCodeFromHR(int hr) { }

}

