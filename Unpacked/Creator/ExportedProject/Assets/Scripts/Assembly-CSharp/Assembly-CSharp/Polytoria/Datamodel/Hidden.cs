namespace Polytoria.Datamodel;

[Token(Token = "0x2000322")]
public class Hidden : Instance
{

	[Address(RVA = "0x425A20", Offset = "0x424C20", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001DF9")]
	public Hidden() { }

	[Address(RVA = "0x400530", Offset = "0x3FF730", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF7")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF8")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFA")]
	public virtual bool Weaved() { }

}

