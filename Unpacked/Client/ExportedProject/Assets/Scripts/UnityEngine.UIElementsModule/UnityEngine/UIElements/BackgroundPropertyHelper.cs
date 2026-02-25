namespace UnityEngine.UIElements;

[Token(Token = "0x200000E")]
public static class BackgroundPropertyHelper
{

	[Address(RVA = "0x1A92800", Offset = "0x1A91A00", Length = "0x4E")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0xE8CB90", Offset = "0xE8BD90", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0x1A92A10", Offset = "0x1A91C10", Length = "0xB1")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&), typeof(BackgroundRepeat&), typeof(BackgroundSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000041")]
	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0x1A92AD0", Offset = "0x1A91CD0", Length = "0x3B9")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6000042")]
	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid) { }

}

