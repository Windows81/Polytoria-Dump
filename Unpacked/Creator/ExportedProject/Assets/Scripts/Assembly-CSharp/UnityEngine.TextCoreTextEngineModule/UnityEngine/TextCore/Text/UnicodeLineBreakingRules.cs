namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200006A")]
public class UnicodeLineBreakingRules
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400048F")]
	private TextAsset m_UnicodeLineBreakingRules; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000490")]
	private TextAsset m_LeadingCharacters; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000491")]
	private TextAsset m_FollowingCharacters; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000492")]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000493")]
	private HashSet<UInt32> m_LeadingCharactersLookup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000494")]
	private HashSet<UInt32> m_FollowingCharactersLookup; //Field offset: 0x38

	[Token(Token = "0x1700007F")]
	internal HashSet<UInt32> followingCharactersLookup
	{
		[Address(RVA = "0x1A71760", Offset = "0x1A70960", Length = "0x2B")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		[Token(Token = "0x60002FC")]
		internal get { } //Length: 43
	}

	[Token(Token = "0x1700007E")]
	internal HashSet<UInt32> leadingCharactersLookup
	{
		[Address(RVA = "0x1A71790", Offset = "0x1A70990", Length = "0x2B")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		[Token(Token = "0x60002FB")]
		internal get { } //Length: 43
	}

	[Token(Token = "0x17000080")]
	public bool useModernHangulLineBreakingRules
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000300")]
	public UnicodeLineBreakingRules() { }

	[Address(RVA = "0x1A71760", Offset = "0x1A70960", Length = "0x2B")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Token(Token = "0x60002FC")]
	internal HashSet<UInt32> get_followingCharactersLookup() { }

	[Address(RVA = "0x1A71790", Offset = "0x1A70990", Length = "0x2B")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Token(Token = "0x60002FB")]
	internal HashSet<UInt32> get_leadingCharactersLookup() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FD")]
	public bool get_useModernHangulLineBreakingRules() { }

	[Address(RVA = "0x1A714A0", Offset = "0x1A706A0", Length = "0xC7")]
	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002FF")]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[Address(RVA = "0x1A71570", Offset = "0x1A70770", Length = "0x1E6")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[CalledBy(Type = typeof(TextSettings), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "get_leadingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "get_followingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002FE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void LoadLineBreakingRules() { }

}

