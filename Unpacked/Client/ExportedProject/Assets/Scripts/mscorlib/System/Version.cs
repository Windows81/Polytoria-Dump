namespace System;

[Token(Token = "0x2000157")]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004BA")]
	private readonly int _Major; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004BB")]
	private readonly int _Minor; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004BC")]
	private readonly int _Build; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004BD")]
	private readonly int _Revision; //Field offset: 0x1C

	[Token(Token = "0x17000101")]
	public int Build
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000103")]
	private int DefaultFormatFieldCount
	{
		[Address(RVA = "0x14CEF10", Offset = "0x14CE110", Length = "0x19")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000BEB")]
		private get { } //Length: 25
	}

	[Token(Token = "0x170000FF")]
	public int Major
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000100")]
	public int Minor
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BDE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000102")]
	public int Revision
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE0")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x14CECB0", Offset = "0x14CDEB0", Length = "0x1D6")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[CalledBy(Type = typeof(Environment), Member = "CreateVersionFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BD8")]
	public Version(int major, int minor, int build, int revision) { }

	[Address(RVA = "0x14CEBB0", Offset = "0x14CDDB0", Length = "0xF9")]
	[CalledBy(Type = "System.Net.HttpVersion", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BD9")]
	public Version(int major, int minor) { }

	[Address(RVA = "0x14CEEE0", Offset = "0x14CE0E0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDA")]
	public Version() { }

	[Address(RVA = "0x14CEE90", Offset = "0x14CE090", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDB")]
	private Version(Version version) { }

	[Address(RVA = "0x14CE310", Offset = "0x14CD510", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDC")]
	public override object Clone() { }

	[Address(RVA = "0x14CE480", Offset = "0x14CD680", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BE2")]
	public override int CompareTo(Version value) { }

	[Address(RVA = "0x14CE390", Offset = "0x14CD590", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000BE1")]
	public override int CompareTo(object version) { }

	[Address(RVA = "0x14CE4E0", Offset = "0x14CD6E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BE4")]
	public override bool Equals(Version obj) { }

	[Address(RVA = "0x14CE520", Offset = "0x14CD720", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BE3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BDF")]
	public int get_Build() { }

	[Address(RVA = "0x14CEF10", Offset = "0x14CE110", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BEB")]
	private int get_DefaultFormatFieldCount() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BDD")]
	public int get_Major() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BDE")]
	public int get_Minor() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BE0")]
	public int get_Revision() { }

	[Address(RVA = "0x14CE5C0", Offset = "0x14CD7C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000BE5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14CEF30", Offset = "0x14CE130", Length = "0x3E")]
	[CalledBy(Type = typeof(AssemblyName), Member = "set_Version", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssemblyName), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_SendContinue", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = "System.Net.HttpWebRequest")]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BED")]
	public static bool op_Equality(Version v1, Version v2) { }

	[Address(RVA = "0x14CEF70", Offset = "0x14CE170", Length = "0x4E")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_ProtocolVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Net.WebConnection+<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection", "System.Net.WebOperation", typeof(Stream), "System.Net.WebConnectionTunnel"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BEE")]
	public static bool op_Inequality(Version v1, Version v2) { }

	[Address(RVA = "0x14CEFC0", Offset = "0x14CE1C0", Length = "0x94")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BEF")]
	public static bool op_LessThan(Version v1, Version v2) { }

	[Address(RVA = "0x14CE5F0", Offset = "0x14CD7F0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BEA")]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x14CE6F0", Offset = "0x14CD8F0", Length = "0x306")]
	[CalledBy(Type = typeof(Version), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Version), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BEC")]
	private StringBuilder ToCachedStringBuilder(int fieldCount) { }

	[Address(RVA = "0x14CEA50", Offset = "0x14CDC50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BE6")]
	public virtual string ToString() { }

	[Address(RVA = "0x14CEA00", Offset = "0x14CDC00", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000BE7")]
	public string ToString(int fieldCount) { }

	[Address(RVA = "0x14CE5F0", Offset = "0x14CD7F0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BE8")]
	public bool TryFormat(Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x14CEA90", Offset = "0x14CDC90", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000BE9")]
	public bool TryFormat(Span<Char> destination, int fieldCount, out int charsWritten) { }

}

