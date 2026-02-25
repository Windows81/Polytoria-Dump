namespace System.ComponentModel;

[Token(Token = "0x2000173")]
public class RefreshEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061A")]
	private readonly Type <TypeChanged>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x17A8F80", Offset = "0x17A8180", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000907")]
	public RefreshEventArgs(Type typeChanged) { }

}

