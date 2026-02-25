namespace UnityEngine.Sprites;

[Token(Token = "0x2000324")]
public sealed class DataUtility
{

	[Address(RVA = "0x1980AE0", Offset = "0x197FCE0", Length = "0x35")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Sprite), Member = "GetInnerUVs", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F04")]
	public static Vector4 GetInnerUV(Sprite sprite) { }

	[Address(RVA = "0x1980B20", Offset = "0x197FD20", Length = "0x88")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F07")]
	public static Vector2 GetMinSize(Sprite sprite) { }

	[Address(RVA = "0x1980BB0", Offset = "0x197FDB0", Length = "0x35")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Sprite), Member = "GetOuterUVs", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F05")]
	public static Vector4 GetOuterUV(Sprite sprite) { }

	[Address(RVA = "0x1980BF0", Offset = "0x197FDF0", Length = "0x35")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Sprite), Member = "GetPadding", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F06")]
	public static Vector4 GetPadding(Sprite sprite) { }

}

