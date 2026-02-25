namespace System.Resources;

[ComVisible(True)]
[Token(Token = "0x20004B0")]
public class ResourceManager
{
	[Token(Token = "0x20004B1")]
	public class CultureNameResourceSetPair
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002106")]
		public CultureNameResourceSetPair() { }

	}

	[Token(Token = "0x20004B2")]
	public class ResourceManagerMediator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012CA")]
		private ResourceManager _rm; //Field offset: 0x10

		[Address(RVA = "0x13C2000", Offset = "0x13C1200", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002107")]
		internal ResourceManagerMediator(ResourceManager rm) { }

	}

	[Token(Token = "0x40012C3")]
	public static readonly int MagicNumber; //Field offset: 0x0
	[Token(Token = "0x40012C4")]
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	[Token(Token = "0x40012C5")]
	private static readonly Type _minResourceSet; //Field offset: 0x8
	[Token(Token = "0x40012C6")]
	internal static readonly string ResReaderTypeName; //Field offset: 0x10
	[Token(Token = "0x40012C7")]
	internal static readonly string ResSetTypeName; //Field offset: 0x18
	[Token(Token = "0x40012C8")]
	internal static readonly string MscorlibName; //Field offset: 0x20
	[Token(Token = "0x40012C9")]
	internal static readonly int DEBUG; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Obsolete("call InternalGetResourceSet instead")]
	[Token(Token = "0x40012B8")]
	protected Hashtable ResourceSets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012B9")]
	private Dictionary<String, ResourceSet> _resourceSets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012BA")]
	protected Assembly MainAssembly; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012BB")]
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012BC")]
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012BD")]
	private bool UseManifest; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40012BE")]
	private bool UseSatelliteAssem; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[OptionalField]
	[Token(Token = "0x40012BF")]
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40012C0")]
	private Assembly _callingAssembly; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x40012C1")]
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012C2")]
	private IResourceGroveler resourceGroveler; //Field offset: 0x50

	[Address(RVA = "0x13C2680", Offset = "0x13C1880", Length = "0x207")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002105")]
	private static ResourceManager() { }

	[Address(RVA = "0x13C2890", Offset = "0x13C1A90", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ResourceManager), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002100")]
	protected ResourceManager() { }

	[Address(RVA = "0x13C2080", Offset = "0x13C1280", Length = "0x23F")]
	[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002104")]
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	[Address(RVA = "0x13C22C0", Offset = "0x13C14C0", Length = "0xB9")]
	[CalledBy(Type = typeof(ResourceManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Assembly), Member = "GetCallingAssembly", ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60020FF")]
	private void Init() { }

	[Address(RVA = "0x13C2380", Offset = "0x13C1580", Length = "0x225")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[OnDeserialized]
	[Token(Token = "0x6002102")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x13C25B0", Offset = "0x13C17B0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[OnDeserializing]
	[Token(Token = "0x6002101")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x13C2600", Offset = "0x13C1800", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[OnSerializing]
	[Token(Token = "0x6002103")]
	private void OnSerializing(StreamingContext ctx) { }

}

