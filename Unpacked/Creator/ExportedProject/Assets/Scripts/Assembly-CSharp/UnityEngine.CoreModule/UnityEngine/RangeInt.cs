namespace UnityEngine;

[Token(Token = "0x2000154")]
public struct RangeInt
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000570")]
	public int start; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000571")]
	public int length; //Field offset: 0x4

	[Token(Token = "0x17000199")]
	public int end
	{
		[Address(RVA = "0x196BE10", Offset = "0x196B010", Length = "0x8")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60009E4")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E5")]
	public RangeInt(int start, int length) { }

	[Address(RVA = "0x196BE10", Offset = "0x196B010", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60009E4")]
	public int get_end() { }

}

