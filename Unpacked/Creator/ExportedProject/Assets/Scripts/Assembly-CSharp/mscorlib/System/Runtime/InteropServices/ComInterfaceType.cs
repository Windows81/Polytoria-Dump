namespace System.Runtime.InteropServices;

[ComVisible(True)]
[Token(Token = "0x2000437")]
public enum ComInterfaceType
{
	InterfaceIsDual = 0,
	InterfaceIsIUnknown = 1,
	InterfaceIsIDispatch = 2,
	InterfaceIsIInspectable = 3,
}

