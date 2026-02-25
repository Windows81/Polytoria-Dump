namespace UnityEngine.Rendering;

[Token(Token = "0x20002B4")]
internal static class CameraEventUtils
{

	[Address(RVA = "0x197B8E0", Offset = "0x197AAE0", Length = "0xE")]
	[CalledBy(Type = typeof(Camera), Member = "AddCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "RemoveCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraEvent), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D79")]
	public static bool IsValid(CameraEvent value) { }

}

