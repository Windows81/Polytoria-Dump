namespace UnityEngine.UI;

[Token(Token = "0x200000D")]
public static class Clipping
{

	[Address(RVA = "0x1A78800", Offset = "0x1A77A00", Length = "0x2B0")]
	[CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000051")]
	public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) { }

}

