namespace Polytoria.Datamodel;

[Token(Token = "0x200030C")]
public class Backpack : Instance
{

	[Address(RVA = "0x400540", Offset = "0x3FF740", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001C05")]
	public Backpack() { }

	[Address(RVA = "0x400530", Offset = "0x3FF730", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C03")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C04")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C06")]
	public virtual bool Weaved() { }

}

