namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x2000057")]
public class MenuItemEvent : UnityEvent<String>
{

	[Address(RVA = "0x5E9C90", Offset = "0x5E8E90", Length = "0x39")]
	[CalledBy(Type = typeof(MenuCreator), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B9")]
	public MenuItemEvent() { }

}

