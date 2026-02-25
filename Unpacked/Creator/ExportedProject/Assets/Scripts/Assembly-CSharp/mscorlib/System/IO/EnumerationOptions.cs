namespace System.IO;

[Token(Token = "0x2000641")]
public class EnumerationOptions
{
	[CompilerGenerated]
	[Token(Token = "0x400194A")]
	private static readonly EnumerationOptions <Compatible>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400194B")]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x400194C")]
	private static readonly EnumerationOptions <Default>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400194D")]
	private bool <RecurseSubdirectories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400194E")]
	private bool <IgnoreInaccessible>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400194F")]
	private int <BufferSize>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001950")]
	private FileAttributes <AttributesToSkip>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001951")]
	private MatchType <MatchType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001952")]
	private MatchCasing <MatchCasing>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001953")]
	private bool <ReturnSpecialDirectories>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x1700071C")]
	public FileAttributes AttributesToSkip
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFC")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700071B")]
	public int BufferSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000717")]
	internal static EnumerationOptions Compatible
	{
		[Address(RVA = "0x1454A50", Offset = "0x1453C50", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF4")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000718")]
	internal static EnumerationOptions Default
	{
		[Address(RVA = "0x1454AA0", Offset = "0x1453CA0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF5")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700071A")]
	public bool IgnoreInaccessible
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DF9")]
		 get { } //Length: 5
		[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700071E")]
	public MatchCasing MatchCasing
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E00")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700071D")]
	public MatchType MatchType
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFE")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DFF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000719")]
	public bool RecurseSubdirectories
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DF7")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DF8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700071F")]
	public bool ReturnSpecialDirectories
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002E01")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x14548F0", Offset = "0x1453AF0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002E02")]
	private static EnumerationOptions() { }

	[Address(RVA = "0x1454A20", Offset = "0x1453C20", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002DF6")]
	public EnumerationOptions() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFC")]
	public FileAttributes get_AttributesToSkip() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFB")]
	public int get_BufferSize() { }

	[Address(RVA = "0x1454A50", Offset = "0x1453C50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002DF4")]
	internal static EnumerationOptions get_Compatible() { }

	[Address(RVA = "0x1454AA0", Offset = "0x1453CA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002DF5")]
	internal static EnumerationOptions get_Default() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DF9")]
	public bool get_IgnoreInaccessible() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E00")]
	public MatchCasing get_MatchCasing() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFE")]
	public MatchType get_MatchType() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DF7")]
	public bool get_RecurseSubdirectories() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002E01")]
	public bool get_ReturnSpecialDirectories() { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFD")]
	public void set_AttributesToSkip(FileAttributes value) { }

	[Address(RVA = "0x3CE380", Offset = "0x3CD580", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFA")]
	public void set_IgnoreInaccessible(bool value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DFF")]
	public void set_MatchType(MatchType value) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DF8")]
	public void set_RecurseSubdirectories(bool value) { }

}

