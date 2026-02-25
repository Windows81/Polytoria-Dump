namespace Microsoft.Win32;

[Token(Token = "0x200007F")]
internal static class ThrowHelper
{

	[Address(RVA = "0x130ACC0", Offset = "0x1309EC0", Length = "0x54")]
	[CalledBy(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000236")]
	internal static void ThrowArgumentException(string msg, string argument) { }

	[Address(RVA = "0x130AD20", Offset = "0x1309F20", Length = "0x49")]
	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000237")]
	internal static void ThrowArgumentNullException(string argument) { }

	[Address(RVA = "0x130AD70", Offset = "0x1309F70", Length = "0x54")]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegistryKey), Member = "EnsureNotDisposed", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000239")]
	internal static void ThrowObjectDisposedException(string objectName, string msg) { }

	[Address(RVA = "0x130ADD0", Offset = "0x1309FD0", Length = "0x49")]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000238")]
	internal static void ThrowSecurityException(string msg) { }

}

