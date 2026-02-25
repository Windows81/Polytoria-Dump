namespace UnityEngine.TextCore;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
[Token(Token = "0x2000005")]
[UsedByNativeCode("TextGenerationSettings")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct NativeTextGenerationSettings
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c
	{
		[Token(Token = "0x4000019")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400001A")]
		public static Predicate<TextSpan> <>9__23_0; //Field offset: 0x8

		[Address(RVA = "0x1A3BA00", Offset = "0x1A3AC00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000009")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000A")]
		public <>c() { }

		[Address(RVA = "0x1A3B980", Offset = "0x1A3AB80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000B")]
		internal bool <get_hasLink>b__23_0(TextSpan span) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000003")]
	public IntPtr fontAsset; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000004")]
	public IntPtr textSettings; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	public string text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	public int screenWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000007")]
	public int screenHeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	public WhiteSpace wordWrap; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000009")]
	public TextOverflow overflow; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	public LanguageDirection languageDirection; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400000B")]
	public int vertexPadding; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal HorizontalAlignment horizontalAlignment; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400000D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal VerticalAlignment verticalAlignment; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	public int fontSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000F")]
	public bool bestFit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000010")]
	public int maxFontSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000011")]
	public int minFontSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000012")]
	public FontStyles fontStyle; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000013")]
	public TextFontWeight fontWeight; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000014")]
	public TextSpan[] textSpans; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000015")]
	public Color32 color; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000016")]
	public int characterSpacing; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000017")]
	public int wordSpacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000018")]
	public int paragraphSpacing; //Field offset: 0x64

	[Token(Token = "0x17000002")]
	public static NativeTextGenerationSettings Default
	{
		[Address(RVA = "0x1A36640", Offset = "0x1A35840", Length = "0x55")]
		[CalledBy(Type = typeof(TextHandle), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[Token(Token = "0x6000007")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000001")]
	public bool hasLink
	{
		[Address(RVA = "0x1A366A0", Offset = "0x1A358A0", Length = "0x122")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000005")]
		 get { } //Length: 290
	}

	[Address(RVA = "0x1A35BE0", Offset = "0x1A34DE0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[IsReadOnly]
	[Token(Token = "0x6000006")]
	public TextSpan CreateTextSpan() { }

	[Address(RVA = "0x1A36640", Offset = "0x1A35840", Length = "0x55")]
	[CalledBy(Type = typeof(TextHandle), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Token(Token = "0x6000007")]
	public static NativeTextGenerationSettings get_Default() { }

	[Address(RVA = "0x1A366A0", Offset = "0x1A358A0", Length = "0x122")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000005")]
	public bool get_hasLink() { }

	[Address(RVA = "0x1A35C50", Offset = "0x1A34E50", Length = "0x9E6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TextSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public virtual string ToString() { }

}

