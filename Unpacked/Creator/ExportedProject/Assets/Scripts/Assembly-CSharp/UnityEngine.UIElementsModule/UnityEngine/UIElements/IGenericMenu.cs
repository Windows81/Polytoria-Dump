namespace UnityEngine.UIElements;

[Token(Token = "0x20000CE")]
internal interface IGenericMenu
{

	[Token(Token = "0x600066C")]
	public void AddItem(string itemName, bool isChecked, Action action) { }

	[Token(Token = "0x600066D")]
	public void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	[Token(Token = "0x600066E")]
	public void DropDown(Rect position, VisualElement targetElement, bool anchored = false) { }

}

