namespace System.ComponentModel;

[Token(Token = "0x2000183")]
public class ComponentConverter : ReferenceConverter
{

	[Address(RVA = "0x17943E0", Offset = "0x17935E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600094F")]
	public ComponentConverter(Type type) { }

}

