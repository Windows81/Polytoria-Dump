namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Token(Token = "0x2000015")]
public sealed class GUISettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400007E")]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[SerializeField]
	[Token(Token = "0x400007F")]
	private bool m_TripleClickSelectsLine; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000080")]
	private Color m_CursorColor; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000081")]
	private float m_CursorFlashSpeed; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000082")]
	private Color m_SelectionColor; //Field offset: 0x28

	[Token(Token = "0x1700003A")]
	public Color cursorColor
	{
		[Address(RVA = "0xB085C0", Offset = "0xB077C0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700003B")]
	public float cursorFlashSpeed
	{
		[Address(RVA = "0x19A8C30", Offset = "0x19A7E30", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000129")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000038")]
	public bool doubleClickSelectsWord
	{
		[Address(RVA = "0x19A8C80", Offset = "0x19A7E80", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700003C")]
	public Color selectionColor
	{
		[Address(RVA = "0x19A8C90", Offset = "0x19A7E90", Length = "0xB")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000039")]
	public bool tripleClickSelectsLine
	{
		[Address(RVA = "0x19A8CA0", Offset = "0x19A7EA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000127")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x19A8C00", Offset = "0x19A7E00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012B")]
	public GUISettings() { }

	[Address(RVA = "0xB085C0", Offset = "0xB077C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	public Color get_cursorColor() { }

	[Address(RVA = "0x19A8C30", Offset = "0x19A7E30", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000129")]
	public float get_cursorFlashSpeed() { }

	[Address(RVA = "0x19A8C80", Offset = "0x19A7E80", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	public bool get_doubleClickSelectsWord() { }

	[Address(RVA = "0x19A8C90", Offset = "0x19A7E90", Length = "0xB")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012A")]
	public Color get_selectionColor() { }

	[Address(RVA = "0x19A8CA0", Offset = "0x19A7EA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000127")]
	public bool get_tripleClickSelectsLine() { }

	[Address(RVA = "0x19A8BD0", Offset = "0x19A7DD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000125")]
	private static float Internal_GetCursorFlashSpeed() { }

}

