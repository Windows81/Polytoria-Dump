namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C7")]
public class UIButtonProxy : UILabelProxy
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001011")]
	private readonly UIButton uiButton; //Field offset: 0x30

	[Token(Token = "0x17000C63")]
	public bool Interactable
	{
		[Address(RVA = "0x4B5570", Offset = "0x4B4770", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600290E")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5590", Offset = "0x4B4790", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIButton), Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600290F")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4AD140", Offset = "0x4AC340", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002910")]
	public UIButtonProxy(UIButton target) { }

	[Address(RVA = "0x4B5570", Offset = "0x4B4770", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600290E")]
	public bool get_Interactable() { }

	[Address(RVA = "0x4B5590", Offset = "0x4B4790", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButton), Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600290F")]
	public void set_Interactable(bool value) { }

}

