namespace Microsoft.Win32;

[Token(Token = "0x2000078")]
public static class Registry
{
	[Token(Token = "0x4000232")]
	public static readonly RegistryKey CurrentUser; //Field offset: 0x0
	[Token(Token = "0x4000233")]
	public static readonly RegistryKey LocalMachine; //Field offset: 0x8
	[Token(Token = "0x4000234")]
	public static readonly RegistryKey ClassesRoot; //Field offset: 0x10
	[Token(Token = "0x4000235")]
	public static readonly RegistryKey Users; //Field offset: 0x18
	[Token(Token = "0x4000236")]
	public static readonly RegistryKey PerformanceData; //Field offset: 0x20
	[Token(Token = "0x4000237")]
	public static readonly RegistryKey CurrentConfig; //Field offset: 0x28
	[Obsolete("Use PerformanceData instead")]
	[Token(Token = "0x4000238")]
	public static readonly RegistryKey DynData; //Field offset: 0x30

	[Address(RVA = "0x12FC8E0", Offset = "0x12FBAE0", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegistryKey), Member = "OpenBaseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600021A")]
	private static Registry() { }

}

