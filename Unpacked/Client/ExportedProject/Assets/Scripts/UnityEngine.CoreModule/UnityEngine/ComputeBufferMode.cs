namespace UnityEngine;

[NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
[Token(Token = "0x20000A7")]
public enum ComputeBufferMode
{
	Immutable = 0,
	Dynamic = 1,
	Circular = 2,
	StreamOut = 3,
	SubUpdates = 4,
}

