namespace UnityEngine.UIElements;

[Token(Token = "0x20002BA")]
internal static class ProjectionUtils
{

	[Address(RVA = "0x1C8DB50", Offset = "0x1C8CD50", Length = "0x15B")]
	[CalledBy(Type = typeof(RenderTreeCompositor), Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001305")]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) { }

}

