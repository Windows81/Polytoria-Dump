namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextSelectionService.h")]
[Token(Token = "0x2000059")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextSelectionService
{

	[Address(RVA = "0x1A6A9A0", Offset = "0x1A69BA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetCharacterHeightFromIndex")]
	[Token(Token = "0x600025D")]
	internal static float GetCharacterHeightFromIndex(IntPtr textGenerationInfo, int index) { }

	[Address(RVA = "0x1A6AA30", Offset = "0x1A69C30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetCursorLogicalIndexFromPosition")]
	[Token(Token = "0x6000258")]
	internal static int GetCursorLogicalIndexFromPosition(IntPtr textGenerationInfo, Vector2 position) { }

	[Address(RVA = "0x1A6A9E0", Offset = "0x1A69BE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026A")]
	private static int GetCursorLogicalIndexFromPosition_Injected(IntPtr textGenerationInfo, in Vector2 position) { }

	[Address(RVA = "0x1A6AAC0", Offset = "0x1A69CC0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetCursorPositionFromLogicalIndex")]
	[Token(Token = "0x6000259")]
	internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex) { }

	[Address(RVA = "0x1A6AA70", Offset = "0x1A69C70", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026B")]
	private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret) { }

	[Address(RVA = "0x1A6AB20", Offset = "0x1A69D20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetEndOfPreviousWord")]
	[Token(Token = "0x600025F")]
	internal static int GetEndOfPreviousWord(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6AB60", Offset = "0x1A69D60", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetFirstCharacterIndexOnLine")]
	[Token(Token = "0x6000260")]
	internal static int GetFirstCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6AC00", Offset = "0x1A69E00", Length = "0xD6")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A584C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetHighlightRectangles")]
	[Token(Token = "0x600025C")]
	internal static Rect[] GetHighlightRectangles(IntPtr textGenerationInfo, int cursorIndex, int selectIndex) { }

	[Address(RVA = "0x1A6ABA0", Offset = "0x1A69DA0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026C")]
	private static void GetHighlightRectangles_Injected(IntPtr textGenerationInfo, int cursorIndex, int selectIndex, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x1A6ACE0", Offset = "0x1A69EE0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetLastCharacterIndexOnLine")]
	[Token(Token = "0x6000261")]
	internal static int GetLastCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6AD20", Offset = "0x1A69F20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetLineHeight")]
	[Token(Token = "0x6000262")]
	internal static float GetLineHeight(IntPtr textGenerationInfo, int lineIndex) { }

	[Address(RVA = "0x1A6AD60", Offset = "0x1A69F60", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetLineNumberFromLogicalIndex")]
	[Token(Token = "0x6000263")]
	internal static int GetLineNumber(IntPtr textGenerationInfo, int logicalIndex) { }

	[Address(RVA = "0x1A6ADA0", Offset = "0x1A69FA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::GetStartOfNextWord")]
	[Token(Token = "0x600025E")]
	internal static int GetStartOfNextWord(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6ADE0", Offset = "0x1A69FE0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::LineDownCharacterPosition")]
	[Token(Token = "0x600025B")]
	internal static int LineDownCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[Address(RVA = "0x1A6AE20", Offset = "0x1A6A020", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::LineUpCharacterPosition")]
	[Token(Token = "0x600025A")]
	internal static int LineUpCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[Address(RVA = "0x1A6AE60", Offset = "0x1A6A060", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::NextCodePointIndex")]
	[Token(Token = "0x6000257")]
	internal static int NextCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6AEA0", Offset = "0x1A6A0A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::PreviousCodePointIndex")]
	[Token(Token = "0x6000256")]
	internal static int PreviousCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x1A6AEE0", Offset = "0x1A6A0E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentParagraph")]
	[Token(Token = "0x6000268")]
	internal static void SelectCurrentParagraph(IntPtr textGenerationInfo, ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x1A6AF40", Offset = "0x1A6A140", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentWord")]
	[Token(Token = "0x6000255")]
	internal static void SelectCurrentWord(IntPtr textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex) { }

	[Address(RVA = "0x1A6AFA0", Offset = "0x1A6A1A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectToEndOfParagraph")]
	[Token(Token = "0x6000266")]
	internal static void SelectToEndOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x1A6AFF0", Offset = "0x1A6A1F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectToNextParagraph")]
	[Token(Token = "0x6000267")]
	internal static void SelectToNextParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x1A6B040", Offset = "0x1A6A240", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectToPreviousParagraph")]
	[Token(Token = "0x6000264")]
	internal static void SelectToPreviousParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x1A6B090", Offset = "0x1A6A290", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::SelectToStartOfParagraph")]
	[Token(Token = "0x6000265")]
	internal static void SelectToStartOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x1A6B140", Offset = "0x1A6A340", Length = "0xCA")]
	[CalledBy(Type = typeof(TextHandle), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSelectionService::Substring")]
	[Token(Token = "0x6000254")]
	internal static string Substring(IntPtr textGenerationInfo, int startIndex, int endIndex) { }

	[Address(RVA = "0x1A6B0E0", Offset = "0x1A6A2E0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000269")]
	private static void Substring_Injected(IntPtr textGenerationInfo, int startIndex, int endIndex, out ManagedSpanWrapper ret) { }

}

