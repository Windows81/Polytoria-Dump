namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[RequiredByNativeCode]
[StaticAccessor("GetVFXManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000008")]
public static class VFXManager
{
	[Token(Token = "0x4000013")]
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; //Field offset: 0x0

	[Address(RVA = "0x1D00290", Offset = "0x1CFF490", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600000F")]
	private static VFXManager() { }

}

