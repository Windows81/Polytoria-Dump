namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
[Token(Token = "0x200000C")]
[UsedByNativeCode]
public class VisualEffectAsset : VisualEffectObject
{
	[Token(Token = "0x4000017")]
	public static readonly int PlayEventID; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	public static readonly int StopEventID; //Field offset: 0x4

	[Address(RVA = "0x1D00840", Offset = "0x1CFFA40", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600001C")]
	private static VisualEffectAsset() { }

}

