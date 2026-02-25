namespace UnityEngine.UIElements;

[Token(Token = "0x20002AB")]
public interface IDebugPanelChangeReceiver
{

	[Token(Token = "0x600122F")]
	public void OnVisualElementChange(VisualElement element, VersionChangeType changeType) { }

}

