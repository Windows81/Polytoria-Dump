namespace UnityEngine.Accessibility;

[Token(Token = "0x2000012")]
public interface IAccessibilityNotificationDispatcher
{

	[Token(Token = "0x6000082")]
	public void SendScreenChanged(AccessibilityNode nodeToFocus = null) { }

}

