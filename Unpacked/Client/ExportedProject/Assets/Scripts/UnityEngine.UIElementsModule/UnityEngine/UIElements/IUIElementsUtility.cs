namespace UnityEngine.UIElements;

[Token(Token = "0x200049D")]
internal interface IUIElementsUtility
{

	[Token(Token = "0x6002324")]
	public bool CleanupRoots() { }

	[Token(Token = "0x6002325")]
	public bool EndContainerGUIFromException(Exception exception) { }

	[Token(Token = "0x6002326")]
	public bool MakeCurrentIMGUIContainerDirty() { }

	[Token(Token = "0x6002323")]
	public bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	[Token(Token = "0x6002322")]
	public bool ReleaseCapture() { }

	[Token(Token = "0x6002321")]
	public bool TakeCapture() { }

}

