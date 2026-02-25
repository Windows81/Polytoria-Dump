namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000370")]
public class UIVerticalLayout : UIHVLayout
{

	[Address(RVA = "0x496BB0", Offset = "0x495DB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600252E")]
	public UIVerticalLayout() { }

	[Address(RVA = "0x49CB70", Offset = "0x49BD70", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600252C")]
	protected virtual void Awake() { }

	[Address(RVA = "0x49CBD0", Offset = "0x49BDD0", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Token(Token = "0x600252D")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600252F")]
	public virtual bool Weaved() { }

}

