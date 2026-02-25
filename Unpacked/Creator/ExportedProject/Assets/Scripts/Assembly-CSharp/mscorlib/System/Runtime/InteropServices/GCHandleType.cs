namespace System.Runtime.InteropServices;

[Token(Token = "0x2000431")]
public enum GCHandleType
{
	Weak = 0,
	WeakTrackResurrection = 1,
	Normal = 2,
	Pinned = 3,
}

