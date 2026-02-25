namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000336")]
public class ModuleScript : BaseScript
{

	[Address(RVA = "0x432590", Offset = "0x431790", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseScript), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001EE8")]
	public ModuleScript() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE9")]
	public virtual bool Weaved() { }

}

