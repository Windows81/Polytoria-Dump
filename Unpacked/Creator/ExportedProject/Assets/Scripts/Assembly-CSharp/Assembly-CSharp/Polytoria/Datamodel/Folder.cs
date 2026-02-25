namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200031D")]
public class Folder : Instance
{

	[Address(RVA = "0x421E20", Offset = "0x421020", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001D80")]
	public Folder() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D81")]
	public virtual bool Weaved() { }

}

