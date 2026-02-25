namespace System;

[NonVersionable]
[Token(Token = "0x20000ED")]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
{
	[Token(Token = "0x20000EF")]
	private enum GuidParseThrowStyle
	{
		None = 0,
		All = 1,
		AllButOverflow = 2,
	}

	[Token(Token = "0x20000F1")]
	private struct GuidResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000407")]
		internal Guid _parsedGuid; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000408")]
		internal GuidParseThrowStyle _throwStyle; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000409")]
		private ParseFailureKind _failure; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400040A")]
		private string _failureMessageID; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400040B")]
		private object _failureMessageFormatArgument; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400040C")]
		private string _failureArgumentName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400040D")]
		private Exception _innerException; //Field offset: 0x30

		[Address(RVA = "0x149AA60", Offset = "0x1499C60", Length = "0x19B")]
		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string), typeof(object), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Guid))]
		[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(Guid))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000779")]
		internal Exception GetGuidParseException() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000774")]
		internal void Init(GuidParseThrowStyle canThrow) { }

		[Address(RVA = "0x149AD20", Offset = "0x1499F20", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000775")]
		internal void SetFailure(Exception nativeException) { }

		[Address(RVA = "0x149AD40", Offset = "0x1499F40", Length = "0x85")]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Guid+GuidStyles", typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000776")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		[Address(RVA = "0x149AC90", Offset = "0x1499E90", Length = "0x87")]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000777")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		[Address(RVA = "0x149AC00", Offset = "0x1499E00", Length = "0x8C")]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Guid+GuidStyles", typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000778")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	}

	[Flags]
	[Token(Token = "0x20000EE")]
	private enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 16,
		RequireBraces = 32,
		RequireDashes = 64,
		RequireHexPrefix = 128,
		HexFormat = 160,
		NumberFormat = 0,
		DigitFormat = 64,
		BraceFormat = 96,
		ParenthesisFormat = 80,
		Any = 15,
	}

	[Token(Token = "0x20000F0")]
	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5,
	}

	[Token(Token = "0x40003E0")]
	public static readonly Guid Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E1")]
	private int _a; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003E2")]
	private short _b; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x40003E3")]
	private short _c; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003E4")]
	private byte _d; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x40003E5")]
	private byte _e; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40003E6")]
	private byte _f; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x40003E7")]
	private byte _g; //Field offset: 0xB
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003E8")]
	private byte _h; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40003E9")]
	private byte _i; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40003EA")]
	private byte _j; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x40003EB")]
	private byte _k; //Field offset: 0xF

	[Address(RVA = "0x149DF30", Offset = "0x149D130", Length = "0xB7")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeModule), Member = "GetModuleVersionId", ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000751")]
	public Guid(Byte[] b) { }

	[Address(RVA = "0x149DD60", Offset = "0x149CF60", Length = "0x1C3")]
	[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadGuidNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "System.Nullable`1<Guid>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000752")]
	public Guid(ReadOnlySpan<Byte> b) { }

	[Address(RVA = "0x149E110", Offset = "0x149D310", Length = "0x4D")]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.SymbolDocumentInfo", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000753")]
	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	[Address(RVA = "0x149DFF0", Offset = "0x149D1F0", Length = "0x11E")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.GuidConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass12_0", Member = "<Register>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+MessageTypeSubscribers"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass13_0", Member = "<Unregister>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+MessageTypeSubscribers"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "MessageCallbackInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(ulong), typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+MessageTypeSubscribers", Member = "get_MessageTypeId", ReturnType = typeof(Guid))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "BuildLookup", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<Register>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(Guid))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000754")]
	public Guid(string g) { }

	[Address(RVA = "0x149B0A0", Offset = "0x149A2A0", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600076A")]
	public override int CompareTo(Guid value) { }

	[Address(RVA = "0x149ADD0", Offset = "0x1499FD0", Length = "0x2C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000769")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x149B240", Offset = "0x149A440", Length = "0x289")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000760")]
	private static ReadOnlySpan<Char> EatAllWhitespace(ReadOnlySpan<Char> str) { }

	[Address(RVA = "0x149B4D0", Offset = "0x149A6D0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000767")]
	public override bool Equals(Guid g) { }

	[Address(RVA = "0x149B500", Offset = "0x149A700", Length = "0xA6")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_uuid", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000766")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x149B5B0", Offset = "0x149A7B0", Length = "0xC")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "GetNextUxmlAssetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "AssetGuidToUint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000765")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x149B5C0", Offset = "0x149A7C0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000768")]
	private int GetResult(uint me, uint them) { }

	[Address(RVA = "0x149B6A0", Offset = "0x149A8A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600076F")]
	private static int HexsToChars(Char* guidChars, int a, int b) { }

	[Address(RVA = "0x149B600", Offset = "0x149A800", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000770")]
	private static int HexsToCharsHexOutput(Char* guidChars, int a, int b) { }

	[Address(RVA = "0x149B5E0", Offset = "0x149A7E0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600076E")]
	private static char HexToChar(int a) { }

	[Address(RVA = "0x149B720", Offset = "0x149A920", Length = "0xAB")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000761")]
	private static bool IsHexPrefix(ReadOnlySpan<Char> str, int i) { }

	[Address(RVA = "0x149B7D0", Offset = "0x149A9D0", Length = "0x44")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = "Mono.Btls.X509CertificateImplBtls")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "GetNextUxmlAssetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "PurchasesService", Member = "Prompt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(int), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.PathInternal", Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeBlock", Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeFrame", Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "MoonSharp.Interpreter.SymbolRef")]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000750")]
	public static Guid NewGuid() { }

	[Address(RVA = "0x149E160", Offset = "0x149D360", Length = "0x23")]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600076B")]
	public static bool op_Equality(Guid a, Guid b) { }

	[Address(RVA = "0x149E190", Offset = "0x149D390", Length = "0x23")]
	[CalledBy(Type = "Mirror.MatchInterestManagement", Member = "OnMatchChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkMatch", typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MatchInterestManagement", Member = "OnDestroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600076C")]
	public static bool op_Inequality(Guid a, Guid b) { }

	[Address(RVA = "0x149B8B0", Offset = "0x149AAB0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[Token(Token = "0x6000755")]
	public static Guid Parse(string input) { }

	[Address(RVA = "0x149B820", Offset = "0x149AA20", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000756")]
	public static Guid Parse(ReadOnlySpan<Char> input) { }

	[Address(RVA = "0x149BA30", Offset = "0x149AC30", Length = "0x188")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int16&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int16&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600075E")]
	private static bool StringToInt(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[Address(RVA = "0x149B9E0", Offset = "0x149ABE0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600075D")]
	private static bool StringToInt(ReadOnlySpan<Char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[Address(RVA = "0x149BBC0", Offset = "0x149ADC0", Length = "0xFF")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600075F")]
	private static bool StringToLong(ReadOnlySpan<Char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) { }

	[Address(RVA = "0x149BCC0", Offset = "0x149AEC0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600075C")]
	private static bool StringToShort(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[Address(RVA = "0x149BD20", Offset = "0x149AF20", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600075B")]
	private static bool StringToShort(ReadOnlySpan<Char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[Address(RVA = "0x149BD80", Offset = "0x149AF80", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000773")]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x149BDC0", Offset = "0x149AFC0", Length = "0x3F")]
	[CalledBy(Type = "SimpleJSON.JSONObject", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
	[CalledBy(Type = "PurchasesService", Member = "Prompt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(int), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = "Mono.Btls.X509CertificateImplBtls")]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "MessageCallbackInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(ulong), typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+MessageTypeSubscribers", Member = "set_MessageTypeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "InvokeMessageIdSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), "System.Byte[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "AddAndCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = "UnityEngine.Events.UnityEvent`1<MessageEventArgs>")]
	[CalledBy(Type = "Mirror.NetworkMatch", Member = "set_matchId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000764")]
	public virtual string ToString() { }

	[Address(RVA = "0x149C070", Offset = "0x149B270", Length = "0xB")]
	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.PathInternal", Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeBlock", Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeFrame", Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "MoonSharp.Interpreter.SymbolRef")]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), "System.Byte[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), "System.Byte[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x600076D")]
	public string ToString(string format) { }

	[Address(RVA = "0x149BE00", Offset = "0x149B000", Length = "0x260")]
	[CalledBy(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000771")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x149C080", Offset = "0x149B280", Length = "0xA54")]
	[CalledBy(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Guid), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000772")]
	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null) { }

	[Address(RVA = "0x149DB20", Offset = "0x149CD20", Length = "0x1CB")]
	[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(Guid))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801933B0")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000757")]
	private static bool TryParseGuid(ReadOnlySpan<Char> guidString, GuidStyles flags, ref GuidResult result) { }

	[Address(RVA = "0x149CAE0", Offset = "0x149BCE0", Length = "0x344")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600075A")]
	private static bool TryParseGuidWithDashes(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x149CE30", Offset = "0x149C030", Length = "0x8A6")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187B70")]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018B7B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "IsHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "EatAllWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801933B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000758")]
	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x149D6E0", Offset = "0x149C8E0", Length = "0x436")]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000759")]
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x149DCF0", Offset = "0x149CEF0", Length = "0x64")]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteGuidNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", "System.Nullable`1<Guid>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000763")]
	public bool TryWriteBytes(Span<Byte> destination) { }

	[Address(RVA = "0x149A460", Offset = "0x1499660", Length = "0x3D5")]
	[CalledBy(Type = typeof(Guid), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberBuffer), Member = "get_digits", ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000762")]
	private void WriteByteHelper(Span<Byte> destination) { }

}

