namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C9")]
public class UIHorizontalLayoutProxy : UIHVLayoutProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001013")]
	private readonly UIHorizontalLayout uiHorizontalLayout; //Field offset: 0x28

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002924")]
	public UIHorizontalLayoutProxy(UIHorizontalLayout target) { }

}

