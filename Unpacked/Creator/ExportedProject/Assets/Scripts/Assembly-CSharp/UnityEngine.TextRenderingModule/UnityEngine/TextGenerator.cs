namespace UnityEngine;

[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[Token(Token = "0x2000005")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	[Token(Token = "0x2000006")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		public static IntPtr ConvertToNative(TextGenerator textGenerator) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001D")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001E")]
	private string m_LastString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001F")]
	private TextGenerationSettings m_LastSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000020")]
	private bool m_HasGenerated; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000021")]
	private TextGenerationError m_LastValid; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000022")]
	private readonly List<UIVertex> m_Verts; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000023")]
	private readonly List<UICharInfo> m_Characters; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000024")]
	private readonly List<UILineInfo> m_Lines; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000025")]
	private bool m_CachedVerts; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000026")]
	private bool m_CachedCharacters; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000027")]
	private bool m_CachedLines; //Field offset: 0xA2

	[Token(Token = "0x17000006")]
	public int characterCount
	{
		[Address(RVA = "0x1A744D0", Offset = "0x1A736D0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000018")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000001")]
	public int characterCountVisible
	{
		[Address(RVA = "0x1A74430", Offset = "0x1A73630", Length = "0x53")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000003")]
	public IList<UICharInfo> characters
	{
		[Address(RVA = "0x1A74530", Offset = "0x1A73730", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000015")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000007")]
	public int lineCount
	{
		[Address(RVA = "0x1A74600", Offset = "0x1A73800", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000004")]
	public IList<UILineInfo> lines
	{
		[Address(RVA = "0x1A74660", Offset = "0x1A73860", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000016")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000005")]
	public Rect rectExtents
	{
		[Address(RVA = "0x1A74740", Offset = "0x1A73940", Length = "0x69")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000017")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000002")]
	public IList<UIVertex> verts
	{
		[Address(RVA = "0x1A747B0", Offset = "0x1A739B0", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000014")]
		 get { } //Length: 133
	}

	[Address(RVA = "0x1A742E0", Offset = "0x1A734E0", Length = "0x149")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public TextGenerator() { }

	[Address(RVA = "0x1A74180", Offset = "0x1A73380", Length = "0x155")]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public TextGenerator(int initialCapacity) { }

	[Address(RVA = "0x1A72900", Offset = "0x1A71B00", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1A744D0", Offset = "0x1A736D0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	public int get_characterCount() { }

	[Address(RVA = "0x1A74490", Offset = "0x1A73690", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A74430", Offset = "0x1A73630", Length = "0x53")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public int get_characterCountVisible() { }

	[Address(RVA = "0x1A74530", Offset = "0x1A73730", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public IList<UICharInfo> get_characters() { }

	[Address(RVA = "0x1A74600", Offset = "0x1A73800", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public int get_lineCount() { }

	[Address(RVA = "0x1A745C0", Offset = "0x1A737C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000023")]
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A74660", Offset = "0x1A73860", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public IList<UILineInfo> get_lines() { }

	[Address(RVA = "0x1A74740", Offset = "0x1A73940", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	public Rect get_rectExtents() { }

	[Address(RVA = "0x1A746F0", Offset = "0x1A738F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x1A747B0", Offset = "0x1A739B0", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	public IList<UIVertex> get_verts() { }

	[Address(RVA = "0x1A72A30", Offset = "0x1A71C30", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public void GetCharacters(List<UICharInfo> characters) { }

	[Address(RVA = "0x1A72A30", Offset = "0x1A71C30", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600001F")]
	private void GetCharactersInternal(object characters) { }

	[Address(RVA = "0x1A729E0", Offset = "0x1A71BE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	[Address(RVA = "0x1A72AE0", Offset = "0x1A71CE0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public void GetLines(List<UILineInfo> lines) { }

	[Address(RVA = "0x1A72AE0", Offset = "0x1A71CE0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x6000020")]
	private void GetLinesInternal(object lines) { }

	[Address(RVA = "0x1A72A90", Offset = "0x1A71C90", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }

	[Address(RVA = "0x1A72B40", Offset = "0x1A71D40", Length = "0xC9")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x1A72C10", Offset = "0x1A71E10", Length = "0xD1")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x1A72D40", Offset = "0x1A71F40", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public void GetVertices(List<UIVertex> vertices) { }

	[Address(RVA = "0x1A72D40", Offset = "0x1A71F40", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600001E")]
	private void GetVerticesInternal(object vertices) { }

	[Address(RVA = "0x1A72CF0", Offset = "0x1A71EF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	[Address(RVA = "0x1A72DA0", Offset = "0x1A71FA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600001A")]
	private static IntPtr Internal_Create() { }

	[Address(RVA = "0x1A72DD0", Offset = "0x1A71FD0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600001B")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x1267AF0", Offset = "0x1266CF0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public void Invalidate() { }

	[Address(RVA = "0x1A73D80", Offset = "0x1A72F80", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000011")]
	public bool Populate(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x1A73A30", Offset = "0x1A72C30", Length = "0x342")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(VerticalWrapMode), typeof(HorizontalWrapMode), typeof(bool), typeof(TextAnchor), typeof(Vector2), typeof(Vector2), typeof(bool), typeof(bool), typeof(TextGenerationError&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[Address(RVA = "0x1A73850", Offset = "0x1A72A50", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600001D")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[Address(RVA = "0x1A73790", Offset = "0x1A72990", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[Address(RVA = "0x1A72E10", Offset = "0x1A72010", Length = "0x357")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextGenerator), Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000013")]
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x1A73170", Offset = "0x1A72370", Length = "0x3FA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextGenerator), Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000012")]
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x1A73570", Offset = "0x1A72770", Length = "0x21E")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000010")]
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	[Address(RVA = "0x1A73DE0", Offset = "0x1A72FE0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x1A73E30", Offset = "0x1A73030", Length = "0x34F")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000009")]
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

}

