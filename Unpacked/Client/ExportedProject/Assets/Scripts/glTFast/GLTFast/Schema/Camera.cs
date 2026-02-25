namespace GLTFast.Schema;

[Token(Token = "0x2000091")]
public class Camera : CameraBase<CameraOrthographic, CameraPerspective>
{

	[Address(RVA = "0x1075910", Offset = "0x1074B10", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D5")]
	public Camera() { }

}

