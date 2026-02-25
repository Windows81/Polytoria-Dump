namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000335")]
public class Model : DynamicInstance
{

	[Address(RVA = "0x432540", Offset = "0x431740", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001EE6")]
	public Model() { }

	[Address(RVA = "0x400CA0", Offset = "0x3FFEA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE4")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x421FB0", Offset = "0x4211B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE5")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE7")]
	public virtual bool Weaved() { }

}

