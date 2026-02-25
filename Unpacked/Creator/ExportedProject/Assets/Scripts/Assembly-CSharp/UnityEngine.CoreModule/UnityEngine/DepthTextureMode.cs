namespace UnityEngine;

[Flags]
[Token(Token = "0x20000C9")]
public enum DepthTextureMode
{
	None = 0,
	Depth = 1,
	DepthNormals = 2,
	MotionVectors = 4,
}

