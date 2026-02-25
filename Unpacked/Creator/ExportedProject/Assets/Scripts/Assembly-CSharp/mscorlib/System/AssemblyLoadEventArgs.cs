namespace System;

[Token(Token = "0x20000BB")]
public class AssemblyLoadEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B0")]
	private readonly Assembly <LoadedAssembly>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x140B0C0", Offset = "0x140A2C0", Length = "0x65")]
	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000437")]
	public AssemblyLoadEventArgs(Assembly loadedAssembly) { }

}

