namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000331")]
public class LocalScript : BaseScript
{

	[Address(RVA = "0x42EEA0", Offset = "0x42E0A0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseScript), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001EAC")]
	public LocalScript() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAD")]
	public virtual bool Weaved() { }

}

