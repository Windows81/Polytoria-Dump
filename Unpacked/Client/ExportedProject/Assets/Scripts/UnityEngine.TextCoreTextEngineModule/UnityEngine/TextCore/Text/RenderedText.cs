namespace UnityEngine.TextCore.Text;

[IsReadOnly]
[Token(Token = "0x200004C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule", "UnityEditor.GraphToolsFoundationModule"})]
internal struct RenderedText : IEquatable<RenderedText>, IEquatable<String>
{
	[Token(Token = "0x200004D")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E8")]
		private readonly RenderedText m_Source; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002E9")]
		private int m_Stage; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40002EA")]
		private int m_StageIndex; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002EB")]
		private char m_Current; //Field offset: 0x28

		[Token(Token = "0x17000062")]
		public char Current
		{
			[Address(RVA = "0x1A58740", Offset = "0x1A57940", Length = "0x5")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60001FA")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1A58710", Offset = "0x1A57910", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001FB")]
		public Enumerator(in RenderedText source) { }

		[Address(RVA = "0x1A58740", Offset = "0x1A57940", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001FA")]
		public char get_Current() { }

		[Address(RVA = "0x1A58630", Offset = "0x1A57830", Length = "0xD7")]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderedText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderedText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001FC")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E2")]
	public readonly string value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002E3")]
	public readonly int valueStart; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002E4")]
	public readonly int valueLength; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E5")]
	public readonly string suffix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E6")]
	public readonly char repeat; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E7")]
	public readonly int repeatCount; //Field offset: 0x1C

	[Token(Token = "0x17000061")]
	public int CharacterCount
	{
		[Address(RVA = "0x1A5A990", Offset = "0x1A59B90", Length = "0x15")]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60001F3")]
		 get { } //Length: 21
	}

	[Address(RVA = "0x1A5A6D0", Offset = "0x1A598D0", Length = "0xBF")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), "UnityEngine.UIElements.TextOverflowPosition"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "MeasureTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "get_renderedText", ReturnType = typeof(RenderedText))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001EF")]
	public RenderedText(string value) { }

	[Address(RVA = "0x1A5A850", Offset = "0x1A59A50", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "get_renderedText", ReturnType = typeof(RenderedText))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F0")]
	public RenderedText(string value, string suffix) { }

	[Address(RVA = "0x1A5A790", Offset = "0x1A59990", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F1")]
	public RenderedText(string value, int start, int length, string suffix = null) { }

	[Address(RVA = "0x1A5A920", Offset = "0x1A59B20", Length = "0x6F")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "get_renderedText", ReturnType = typeof(RenderedText))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001F2")]
	public RenderedText(char repeat, int repeatCount, string suffix = null) { }

	[Address(RVA = "0x1A5A0E0", Offset = "0x1A592E0", Length = "0x18A")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerationSettings), Member = "get_text", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextGenerationSettings), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F5")]
	public string CreateString() { }

	[Address(RVA = "0x1A5A270", Offset = "0x1A59470", Length = "0x80")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001F6")]
	public override bool Equals(RenderedText other) { }

	[Address(RVA = "0x1A5A4E0", Offset = "0x1A596E0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F7")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x1A5A2F0", Offset = "0x1A594F0", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001F8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A5A990", Offset = "0x1A59B90", Length = "0x15")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60001F3")]
	public int get_CharacterCount() { }

	[Address(RVA = "0x1A5A5E0", Offset = "0x1A597E0", Length = "0x3F")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001F4")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x1A5A620", Offset = "0x1A59820", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6"}, ReturnType = typeof(int))]
	[Token(Token = "0x60001F9")]
	public virtual int GetHashCode() { }

}

