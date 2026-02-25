namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E5")]
public class Regex : ISerializable
{
	[Token(Token = "0x20000E7")]
	public sealed class CachedCodeEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000387")]
		public CachedCodeEntry Next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000388")]
		public CachedCodeEntry Previous; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000389")]
		public readonly CachedCodeEntryKey Key; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400038A")]
		public RegexCode Code; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400038B")]
		public readonly Hashtable Caps; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400038C")]
		public readonly Hashtable Capnames; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400038D")]
		public readonly String[] Capslist; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400038E")]
		public readonly int Capsize; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400038F")]
		public readonly ExclusiveReference Runnerref; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000390")]
		public readonly WeakReference<RegexReplacement> ReplRef; //Field offset: 0x68

		[Address(RVA = "0x174D860", Offset = "0x174CA60", Length = "0xC6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000508")]
		public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, String[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20000E6")]
	public struct CachedCodeEntryKey : IEquatable<CachedCodeEntryKey>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000384")]
		private readonly RegexOptions _options; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000385")]
		private readonly string _cultureKey; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000386")]
		private readonly string _pattern; //Field offset: 0x10

		[Address(RVA = "0x4004F0", Offset = "0x3FF6F0", Length = "0x3C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000503")]
		public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) { }

		[Address(RVA = "0x174D690", Offset = "0x174C890", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000504")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x174D620", Offset = "0x174C820", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000505")]
		public override bool Equals(CachedCodeEntryKey other) { }

		[Address(RVA = "0x174D770", Offset = "0x174C970", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000507")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x174D7E0", Offset = "0x174C9E0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000506")]
		public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	}

	[Token(Token = "0x400036D")]
	private const int CacheDictionarySwitchLimit = 10; //Field offset: 0x0
	[Token(Token = "0x4000374")]
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; //Field offset: 0x0
	[Token(Token = "0x4000378")]
	internal const int MaxOptionShift = 10; //Field offset: 0x0
	[Token(Token = "0x400036E")]
	private static int s_cacheSize; //Field offset: 0x0
	[Token(Token = "0x400036F")]
	private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache; //Field offset: 0x8
	[Token(Token = "0x4000370")]
	private static int s_cacheCount; //Field offset: 0x10
	[Token(Token = "0x4000371")]
	private static CachedCodeEntry s_cacheFirst; //Field offset: 0x18
	[Token(Token = "0x4000372")]
	private static CachedCodeEntry s_cacheLast; //Field offset: 0x20
	[Token(Token = "0x4000373")]
	private static readonly TimeSpan s_maximumMatchTimeout; //Field offset: 0x28
	[Token(Token = "0x4000375")]
	internal static readonly TimeSpan s_defaultMatchTimeout; //Field offset: 0x30
	[Token(Token = "0x4000376")]
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000377")]
	protected private TimeSpan internalMatchTimeout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000379")]
	protected private string pattern; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037A")]
	protected private RegexOptions roptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037B")]
	protected private RegexRunnerFactory factory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400037C")]
	protected private Hashtable caps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400037D")]
	protected private Hashtable capnames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400037E")]
	protected private String[] capslist; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400037F")]
	protected private int capsize; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000380")]
	internal ExclusiveReference _runnerref; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000381")]
	internal WeakReference<RegexReplacement> _replref; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000382")]
	internal RegexCode _code; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000383")]
	internal bool _refsInitialized; //Field offset: 0x68

	[Token(Token = "0x170000DC")]
	public bool RightToLeft
	{
		[Address(RVA = "0x1764310", Offset = "0x1763510", Length = "0x8")]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FC")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1764490", Offset = "0x1763690", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x60004F4")]
	private static Regex() { }

	[Address(RVA = "0x1764B40", Offset = "0x1763D40", Length = "0x8B")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebProxy), Member = "UpdateRegExList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "get_LanguagePattern", ReturnType = typeof(Regex))]
	[CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Unity.Hierarchy.DefaultHierarchySearchQueryParser", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004F9")]
	public Regex(string pattern, RegexOptions options) { }

	[Address(RVA = "0x1764600", Offset = "0x1763800", Length = "0x7E")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004F8")]
	public Regex(string pattern) { }

	[Address(RVA = "0x1764BD0", Offset = "0x1763DD0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F7")]
	protected Regex() { }

	[Address(RVA = "0x1764680", Offset = "0x1763880", Length = "0x4B0")]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(MatchEvaluator), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(MatchEvaluator)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(RegexTree))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18174D420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004FB")]
	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	[Address(RVA = "0x1761450", Offset = "0x1760650", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DE")]
	private void FillCacheDictionary() { }

	[Address(RVA = "0x1764310", Offset = "0x1763510", Length = "0x8")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FC")]
	public bool get_RightToLeft() { }

	[Address(RVA = "0x1761C40", Offset = "0x1760E40", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004DC")]
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	[Address(RVA = "0x1761560", Offset = "0x1760760", Length = "0x6D0")]
	[CalledBy(Type = typeof(X509PalImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Regex), Member = "GetCachedCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "LookupCachedAndPromote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey)}, ReturnType = typeof(CachedCodeEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004DD")]
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	[Address(RVA = "0x1761DB0", Offset = "0x1760FB0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(object), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FE")]
	public string GroupNameFromNumber(int i) { }

	[Address(RVA = "0x1761EC0", Offset = "0x17610C0", Length = "0x211")]
	[CalledBy(Type = typeof(Regex), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(AppDomain), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F6")]
	private static TimeSpan InitDefaultMatchTimeout() { }

	[Address(RVA = "0x17620E0", Offset = "0x17612E0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004FF")]
	protected void InitializeReferences() { }

	[Address(RVA = "0x17621E0", Offset = "0x17613E0", Length = "0x79")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60004E2")]
	public static bool IsMatch(string input, string pattern) { }

	[Address(RVA = "0x17622F0", Offset = "0x17614F0", Length = "0x9C")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "CheckLexicalFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "CheckPatternFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.RestrictionFacets", typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E5")]
	public bool IsMatch(string input) { }

	[Address(RVA = "0x1762390", Offset = "0x1761590", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E6")]
	public bool IsMatch(string input, int startat) { }

	[Address(RVA = "0x1762260", Offset = "0x1761460", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.FilterService", Member = "Filter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60004E3")]
	public static bool IsMatch(string input, string pattern, RegexOptions options) { }

	[Address(RVA = "0x1762420", Offset = "0x1761620", Length = "0x125")]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E4")]
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x1762550", Offset = "0x1761750", Length = "0x4C9")]
	[CalledBy(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E1")]
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	[Address(RVA = "0x1762C70", Offset = "0x1761E70", Length = "0x150")]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "ReParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004E7")]
	public static Match Match(string input, string pattern) { }

	[Address(RVA = "0x1762A20", Offset = "0x1761C20", Length = "0x96")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "MatchCustomIdent", ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004E9")]
	public Match Match(string input) { }

	[Address(RVA = "0x1762AC0", Offset = "0x1761CC0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004E8")]
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x1762BE0", Offset = "0x1761DE0", Length = "0x89")]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004EA")]
	public Match Match(string input, int startat) { }

	[Address(RVA = "0x1763400", Offset = "0x1762600", Length = "0x519")]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(MatchEvaluator)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(MatchEvaluator), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MatchEvaluator)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MatchEvaluator), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004F3")]
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	[Address(RVA = "0x1762F20", Offset = "0x1762120", Length = "0x18A")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "ReplaceMetaChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchEvaluator), typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004EF")]
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	[Address(RVA = "0x17630B0", Offset = "0x17622B0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchEvaluator), typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004F1")]
	public string Replace(string input, MatchEvaluator evaluator) { }

	[Address(RVA = "0x1762DD0", Offset = "0x1761FD0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchEvaluator), typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004F0")]
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x1763C30", Offset = "0x1762E30", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004EE")]
	public string Replace(string input, string replacement, int count, int startat) { }

	[Address(RVA = "0x1763B00", Offset = "0x1762D00", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004ED")]
	public string Replace(string input, string replacement) { }

	[Address(RVA = "0x1763260", Offset = "0x1762460", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004EC")]
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x1763920", Offset = "0x1762B20", Length = "0x1D9")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "GetEnumExportString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "ConvertCamelToDash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.Reflection", Member = "GetAssemblyQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004EB")]
	public static string Replace(string input, string pattern, string replacement) { }

	[Address(RVA = "0x1763190", Offset = "0x1762390", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchEvaluator), typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004F2")]
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	[Address(RVA = "0x1763D50", Offset = "0x1762F50", Length = "0x31E")]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MatchEvaluator), typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18174D330")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCode), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000500")]
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	[Address(RVA = "0x1764070", Offset = "0x1763270", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004FA")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FD")]
	public virtual string ToString() { }

	[Address(RVA = "0x1764200", Offset = "0x1763400", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "TryGetCacheValueSmall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(CachedCodeEntry&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DF")]
	private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[Address(RVA = "0x17640B0", Offset = "0x17632B0", Length = "0x14E")]
	[CalledBy(Type = typeof(Regex), Member = "TryGetCacheValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(CachedCodeEntry&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E0")]
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[Address(RVA = "0x1764300", Offset = "0x1763500", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000502")]
	internal bool UseOptionInvariant() { }

	[Address(RVA = "0x1764310", Offset = "0x1763510", Length = "0x8")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000501")]
	protected private bool UseOptionR() { }

	[Address(RVA = "0x1764320", Offset = "0x1763520", Length = "0x163")]
	[CalledBy(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F5")]
	protected private static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

