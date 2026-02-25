namespace UnityEngine;

[Token(Token = "0x2000033")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class TextSelectingUtilities
{
	[Token(Token = "0x2000034")]
	private enum CharacterType
	{
		LetterLike = 0,
		Symbol = 1,
		Symbol2 = 2,
		WhiteSpace = 3,
		NewLine = 4,
	}

	[Token(Token = "0x2000035")]
	private enum Direction
	{
		Forward = 0,
		Backward = 1,
	}

	[Token(Token = "0x4000179")]
	private const int kMoveDownHeight = 5; //Field offset: 0x0
	[Token(Token = "0x400017E")]
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; //Field offset: 0x0
	[Token(Token = "0x400017A")]
	private const char kNewLineChar = '\uA'; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000171")]
	public DblClickSnapping dblClickSnap; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000172")]
	public int iAltCursorPos; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000173")]
	public bool hasHorizontalCursorPos; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000174")]
	private bool m_bJustSelected; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000175")]
	private bool m_MouseDragSelectsWholeWords; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000176")]
	private int m_DblClickInitPosStart; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000177")]
	private int m_DblClickInitPosEnd; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000178")]
	public TextHandle textHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017B")]
	private bool m_RevealCursor; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400017C")]
	private int m_CursorIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017D")]
	internal int m_SelectIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnCursorIndexChange; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000180")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnSelectIndexChange; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000181")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnRevealCursorChange; //Field offset: 0x50

	[Token(Token = "0x1700009B")]
	private int characterCount
	{
		[Address(RVA = "0x19CF400", Offset = "0x19CE600", Length = "0xC9")]
		[CallerCount(Count = 220)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002E1")]
		private get { } //Length: 201
	}

	[Token(Token = "0x1700009D")]
	public int cursorIndex
	{
		[Address(RVA = "0x19CF4E0", Offset = "0x19CE6E0", Length = "0x62")]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_cursorIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 98
		[Address(RVA = "0x19CF8A0", Offset = "0x19CEAA0", Length = "0x28")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E4")]
		 set { } //Length: 40
	}

	[Token(Token = "0x1700009E")]
	internal int cursorIndexNoValidation
	{
		[Address(RVA = "0x19CF4D0", Offset = "0x19CE6D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E5")]
		internal get { } //Length: 6
		[Address(RVA = "0x19CF8A0", Offset = "0x19CEAA0", Length = "0x28")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E6")]
		internal set { } //Length: 40
	}

	[Token(Token = "0x17000098")]
	public bool hasSelection
	{
		[Address(RVA = "0x19CF550", Offset = "0x19CE750", Length = "0xB6")]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnSelectIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnCursorIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HasSelection", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ValidateCommandEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002DD")]
		 get { } //Length: 182
	}

	[Token(Token = "0x1700009A")]
	private int m_CharacterCount
	{
		[Address(RVA = "0x19CF610", Offset = "0x19CE810", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002E0")]
		private get { } //Length: 29
	}

	[Token(Token = "0x1700009C")]
	private TextElementInfo[] m_TextElementInfos
	{
		[Address(RVA = "0x19CF630", Offset = "0x19CE830", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002E2")]
		private get { } //Length: 39
	}

	[Token(Token = "0x17000099")]
	public bool revealCursor
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 5
		[Address(RVA = "0x19CF8D0", Offset = "0x19CEAD0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002DF")]
		 set { } //Length: 40
	}

	[Token(Token = "0x170000A1")]
	public string selectedText
	{
		[Address(RVA = "0x19CF6D0", Offset = "0x19CE8D0", Length = "0x1C1")]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 449
	}

	[Token(Token = "0x1700009F")]
	public int selectIndex
	{
		[Address(RVA = "0x19CF660", Offset = "0x19CE860", Length = "0x62")]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_selectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 98
		[Address(RVA = "0x19CF900", Offset = "0x19CEB00", Length = "0x28")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 40
	}

	[Token(Token = "0x170000A0")]
	internal int selectIndexNoValidation
	{
		[Address(RVA = "0x19CF900", Offset = "0x19CEB00", Length = "0x28")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EA")]
		internal set { } //Length: 40
	}

	[Address(RVA = "0x19CF3B0", Offset = "0x19CE5B0", Length = "0x50")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002ED")]
	public TextSelectingUtilities(TextHandle textHandle) { }

	[Address(RVA = "0x19C92E0", Offset = "0x19C84E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Token(Token = "0x6000321")]
	private int ClampTextIndex(int index) { }

	[Address(RVA = "0x19C9310", Offset = "0x19C8510", Length = "0x131")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindNextSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000328")]
	private CharacterType ClassifyChar(int index) { }

	[Address(RVA = "0x19C9450", Offset = "0x19C8650", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002F2")]
	public void ClearCursorPos() { }

	[Address(RVA = "0x19C9460", Offset = "0x19C8660", Length = "0x102")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Cut", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000327")]
	public void Copy() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000319")]
	public void DblClickSnap(DblClickSnapping snapping) { }

	[Address(RVA = "0x19C9570", Offset = "0x19C8770", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000318")]
	public void ExpandSelectGraphicalLineEnd() { }

	[Address(RVA = "0x19C9770", Offset = "0x19C8970", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000317")]
	public void ExpandSelectGraphicalLineStart() { }

	[Address(RVA = "0x19C9970", Offset = "0x19C8B70", Length = "0x1B1")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000320")]
	private int FindEndOfClassification(int p, Direction dir) { }

	[Address(RVA = "0x19C9B30", Offset = "0x19C8D30", Length = "0x1C2")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToEndOfPreviousWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToEndOfPreviousWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600031F")]
	public int FindEndOfPreviousWord(int p) { }

	[Address(RVA = "0x19C9D00", Offset = "0x19C8F00", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600031C")]
	private int FindNextSeperator(int startPos) { }

	[Address(RVA = "0x19C9DF0", Offset = "0x19C8FF0", Length = "0x17B")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600031D")]
	private int FindPrevSeperator(int startPos) { }

	[Address(RVA = "0x19C9F70", Offset = "0x19C9170", Length = "0x2CF")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToStartOfNextWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToStartOfNextWord", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600031E")]
	public int FindStartOfNextWord(int p) { }

	[Address(RVA = "0x19CF400", Offset = "0x19CE600", Length = "0xC9")]
	[CallerCount(Count = 220)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002E1")]
	private int get_characterCount() { }

	[Address(RVA = "0x19CF4E0", Offset = "0x19CE6E0", Length = "0x62")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_cursorIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E3")]
	public int get_cursorIndex() { }

	[Address(RVA = "0x19CF4D0", Offset = "0x19CE6D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E5")]
	internal int get_cursorIndexNoValidation() { }

	[Address(RVA = "0x19CF550", Offset = "0x19CE750", Length = "0xB6")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnSelectIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnCursorIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HasSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ValidateCommandEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DD")]
	public bool get_hasSelection() { }

	[Address(RVA = "0x19CF610", Offset = "0x19CE810", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002E0")]
	private int get_m_CharacterCount() { }

	[Address(RVA = "0x19CF630", Offset = "0x19CE830", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002E2")]
	private TextElementInfo[] get_m_TextElementInfos() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DE")]
	public bool get_revealCursor() { }

	[Address(RVA = "0x19CF6D0", Offset = "0x19CE8D0", Length = "0x1C1")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60002EC")]
	public string get_selectedText() { }

	[Address(RVA = "0x19CF660", Offset = "0x19CE860", Length = "0x62")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_selectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E8")]
	public int get_selectIndex() { }

	[Address(RVA = "0x19CA240", Offset = "0x19C9440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000326")]
	private int GetGraphicalLineEnd(int p) { }

	[Address(RVA = "0x19CA260", Offset = "0x19C9460", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000325")]
	private int GetGraphicalLineStart(int p) { }

	[Address(RVA = "0x19CA280", Offset = "0x19C9480", Length = "0x10B")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "set_modifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool HandleKeyEvent(Event e) { }

	[Address(RVA = "0x19CA390", Offset = "0x19C9590", Length = "0x3C")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000322")]
	private int IndexOfEndOfLine(int startIndex) { }

	[Address(RVA = "0x19CA3D0", Offset = "0x19C95D0", Length = "0x482")]
	[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextSelectOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002F1")]
	private void InitKeyActions() { }

	[Address(RVA = "0x19CA860", Offset = "0x19C9A60", Length = "0x85")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F0")]
	private static void MapKey(string key, TextSelectOp action) { }

	[Address(RVA = "0x19CA8F0", Offset = "0x19C9AF0", Length = "0x204")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "MouseDragSelectsWholeWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000316")]
	public void MouseDragSelectsWholeWords(bool on) { }

	[Address(RVA = "0x19CAB00", Offset = "0x19C9D00", Length = "0xB6")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600031A")]
	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	[Address(RVA = "0x19CABC0", Offset = "0x19C9DC0", Length = "0x245")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000309")]
	public void MoveDown() { }

	[Address(RVA = "0x19CAE10", Offset = "0x19CA010", Length = "0x171")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600030D")]
	public void MoveGraphicalLineEnd() { }

	[Address(RVA = "0x19CAF90", Offset = "0x19CA190", Length = "0x171")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600030C")]
	public void MoveGraphicalLineStart() { }

	[Address(RVA = "0x19CB110", Offset = "0x19CA310", Length = "0x26E")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToEndOfPreviousWord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000307")]
	public void MoveLeft() { }

	[Address(RVA = "0x19CB380", Offset = "0x19CA580", Length = "0x1FD")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600030B")]
	public void MoveLineEnd() { }

	[Address(RVA = "0x19CB580", Offset = "0x19CA780", Length = "0x1EC")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600030A")]
	public void MoveLineStart() { }

	[Address(RVA = "0x19CB770", Offset = "0x19CA970", Length = "0x261")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToPreviousParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000311")]
	public void MoveParagraphBackward() { }

	[Address(RVA = "0x19CB9E0", Offset = "0x19CABE0", Length = "0x259")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToNextParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000310")]
	public void MoveParagraphForward() { }

	[Address(RVA = "0x19CBC40", Offset = "0x19CAE40", Length = "0x273")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToStartOfNextWord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000306")]
	public void MoveRight() { }

	[Address(RVA = "0x19CBEC0", Offset = "0x19CB0C0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600030F")]
	public void MoveTextEnd() { }

	[Address(RVA = "0x19CBF20", Offset = "0x19CB120", Length = "0x57")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600030E")]
	public void MoveTextStart() { }

	[Address(RVA = "0x19CBF80", Offset = "0x19CB180", Length = "0x161")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000314")]
	public void MoveToEndOfPreviousWord() { }

	[Address(RVA = "0x19CC0F0", Offset = "0x19CB2F0", Length = "0x161")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000313")]
	public void MoveToStartOfNextWord() { }

	[Address(RVA = "0x19CC260", Offset = "0x19CB460", Length = "0x236")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000308")]
	public void MoveUp() { }

	[Address(RVA = "0x19CC4A0", Offset = "0x19CB6A0", Length = "0x270")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000315")]
	public void MoveWordLeft() { }

	[Address(RVA = "0x19CC720", Offset = "0x19CB920", Length = "0x325")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000312")]
	public void MoveWordRight() { }

	[Address(RVA = "0x19CCA50", Offset = "0x19CBC50", Length = "0x65")]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000324")]
	public int NextCodePointIndex(int index) { }

	[Address(RVA = "0x19CCAC0", Offset = "0x19CBCC0", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnFocusEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002F3")]
	public void OnFocus(bool selectAll = true) { }

	[Address(RVA = "0x19CCB50", Offset = "0x19CBD50", Length = "0x5C")]
	[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002EF")]
	private bool PerformOperation(TextSelectOp operation) { }

	[Address(RVA = "0x19CD0B0", Offset = "0x19CC2B0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000323")]
	public int PreviousCodePointIndex(int index) { }

	[Address(RVA = "0x19CD110", Offset = "0x19CC310", Length = "0x65")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F4")]
	public void SelectAll() { }

	[Address(RVA = "0x19CD180", Offset = "0x19CC380", Length = "0x248")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectCurrentParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000305")]
	public void SelectCurrentParagraph() { }

	[Address(RVA = "0x19CD3D0", Offset = "0x19CC5D0", Length = "0x626")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectCurrentWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000304")]
	public void SelectCurrentWord() { }

	[Address(RVA = "0x19CDA00", Offset = "0x19CCC00", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F9")]
	public void SelectDown() { }

	[Address(RVA = "0x19CDAA0", Offset = "0x19CCCA0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000301")]
	public void SelectGraphicalLineEnd() { }

	[Address(RVA = "0x19CDB40", Offset = "0x19CCD40", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000300")]
	public void SelectGraphicalLineStart() { }

	[Address(RVA = "0x19CDBE0", Offset = "0x19CCDE0", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60002F6")]
	public void SelectLeft() { }

	[Address(RVA = "0x19CDD90", Offset = "0x19CCF90", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "OnBlur", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F5")]
	public void SelectNone() { }

	[Address(RVA = "0x19CDE20", Offset = "0x19CD020", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToPreviousParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000303")]
	public void SelectParagraphBackward() { }

	[Address(RVA = "0x19CE0B0", Offset = "0x19CD2B0", Length = "0x228")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToNextParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000302")]
	public void SelectParagraphForward() { }

	[Address(RVA = "0x19CE2E0", Offset = "0x19CD4E0", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60002F7")]
	public void SelectRight() { }

	[Address(RVA = "0x19CE4A0", Offset = "0x19CD6A0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FA")]
	public void SelectTextEnd() { }

	[Address(RVA = "0x19CE4E0", Offset = "0x19CD6E0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FB")]
	public void SelectTextStart() { }

	[Address(RVA = "0x19CE510", Offset = "0x19CD710", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002FD")]
	public void SelectToEndOfPreviousWord() { }

	[Address(RVA = "0x19CE5B0", Offset = "0x19CD7B0", Length = "0x710")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToStartOfParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToEndOfParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "IndexOfEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x600031B")]
	public void SelectToPosition(Vector2 cursorPosition) { }

	[Address(RVA = "0x19CECD0", Offset = "0x19CDED0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002FC")]
	public void SelectToStartOfNextWord() { }

	[Address(RVA = "0x19CED70", Offset = "0x19CDF70", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F8")]
	public void SelectUp() { }

	[Address(RVA = "0x19CEE10", Offset = "0x19CE010", Length = "0x2C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x60002FF")]
	public void SelectWordLeft() { }

	[Address(RVA = "0x19CF0E0", Offset = "0x19CE2E0", Length = "0x2C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x60002FE")]
	public void SelectWordRight() { }

	[Address(RVA = "0x19CF8A0", Offset = "0x19CEAA0", Length = "0x28")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E4")]
	public void set_cursorIndex(int value) { }

	[Address(RVA = "0x19CF8A0", Offset = "0x19CEAA0", Length = "0x28")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E6")]
	internal void set_cursorIndexNoValidation(int value) { }

	[Address(RVA = "0x19CF8D0", Offset = "0x19CEAD0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DF")]
	public void set_revealCursor(bool value) { }

	[Address(RVA = "0x19CF900", Offset = "0x19CEB00", Length = "0x28")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E9")]
	public void set_selectIndex(int value) { }

	[Address(RVA = "0x19CF900", Offset = "0x19CEB00", Length = "0x28")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EA")]
	internal void set_selectIndexNoValidation(int value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E7")]
	internal void SetCursorIndexWithoutNotify(int index) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EB")]
	internal void SetSelectIndexWithoutNotify(int index) { }

}

