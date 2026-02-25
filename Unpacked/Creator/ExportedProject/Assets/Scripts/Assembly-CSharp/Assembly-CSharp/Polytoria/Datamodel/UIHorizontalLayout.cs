namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000368")]
public class UIHorizontalLayout : UIHVLayout
{

	[Address(RVA = "0x496BB0", Offset = "0x495DB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600243B")]
	public UIHorizontalLayout() { }

	[Address(RVA = "0x496A50", Offset = "0x495C50", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002438")]
	protected virtual void Awake() { }

	[Address(RVA = "0x496AB0", Offset = "0x495CB0", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Token(Token = "0x600243A")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x493BF0", Offset = "0x492DF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002439")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600243C")]
	public virtual bool Weaved() { }

}

