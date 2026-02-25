namespace System;

[Token(Token = "0x200012A")]
public class ResolveEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045E")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045F")]
	private readonly Assembly <RequestingAssembly>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x14BE6C0", Offset = "0x14BD8C0", Length = "0x65")]
	[CalledBy(Type = typeof(AppDomain), Member = "DoTypeResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000970")]
	public ResolveEventArgs(string name) { }

	[Address(RVA = "0x14BE630", Offset = "0x14BD830", Length = "0x82")]
	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "DoResourceResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000971")]
	public ResolveEventArgs(string name, Assembly requestingAssembly) { }

}

