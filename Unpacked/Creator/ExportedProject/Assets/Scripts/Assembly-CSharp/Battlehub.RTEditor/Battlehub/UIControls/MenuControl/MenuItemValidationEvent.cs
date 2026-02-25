namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x2000056")]
public class MenuItemValidationEvent : UnityEvent<MenuItemValidationArgs>
{

	[Address(RVA = "0x5E9D50", Offset = "0x5E8F50", Length = "0x39")]
	[CalledBy(Type = typeof(MenuCreator), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B8")]
	public MenuItemValidationEvent() { }

}

