namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000004")]
public static class AlignmentUtils
{

	[Address(RVA = "0x1A92400", Offset = "0x1A91600", Length = "0x27")]
	[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Token(Token = "0x6000004")]
	internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02) { }

	[Address(RVA = "0x1A92430", Offset = "0x1A91630", Length = "0x51")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000005")]
	public static float RoundToPanelPixelSize(VisualElement ve, float v) { }

	[Address(RVA = "0x1A92490", Offset = "0x1A91690", Length = "0x2F")]
	[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x6000003")]
	internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02) { }

}

