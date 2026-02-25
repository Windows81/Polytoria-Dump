namespace System.IO.Enumeration;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000668")]
public struct FileSystemEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A22")]
	internal FILE_FULL_DIR_INFORMATION* _info; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001A23")]
	private ReadOnlySpan<Char> <Directory>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A24")]
	private ReadOnlySpan<Char> <RootDirectory>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A25")]
	private ReadOnlySpan<Char> <OriginalRootDirectory>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000757")]
	public FileAttributes Attributes
	{
		[Address(RVA = "0x1474E40", Offset = "0x1474040", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002FBC")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000753")]
	public private ReadOnlySpan<Char> Directory
	{
		[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6002FB5")]
		 get { } //Length: 11
		[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FB6")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000756")]
	public ReadOnlySpan<Char> FileName
	{
		[Address(RVA = "0x1474E60", Offset = "0x1474060", Length = "0x28")]
		[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Token(Token = "0x6002FBB")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000758")]
	public bool IsDirectory
	{
		[Address(RVA = "0x1474E90", Offset = "0x1474090", Length = "0x1D")]
		[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002FBD")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000755")]
	public private ReadOnlySpan<Char> OriginalRootDirectory
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6002FB9")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FBA")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000754")]
	public private ReadOnlySpan<Char> RootDirectory
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6002FB7")]
		 get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FB8")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x1474E40", Offset = "0x1474040", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002FBC")]
	public FileAttributes get_Attributes() { }

	[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6002FB5")]
	public ReadOnlySpan<Char> get_Directory() { }

	[Address(RVA = "0x1474E60", Offset = "0x1474060", Length = "0x28")]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Token(Token = "0x6002FBB")]
	public ReadOnlySpan<Char> get_FileName() { }

	[Address(RVA = "0x1474E90", Offset = "0x1474090", Length = "0x1D")]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FBD")]
	public bool get_IsDirectory() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6002FB9")]
	public ReadOnlySpan<Char> get_OriginalRootDirectory() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6002FB7")]
	public ReadOnlySpan<Char> get_RootDirectory() { }

	[Address(RVA = "0x1474B00", Offset = "0x1473D00", Length = "0x20")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002FB4")]
	internal static void Initialize(ref FileSystemEntry entry, FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<Char> directory, ReadOnlySpan<Char> rootDirectory, ReadOnlySpan<Char> originalRootDirectory) { }

	[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB6")]
	private void set_Directory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FBA")]
	private void set_OriginalRootDirectory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB8")]
	private void set_RootDirectory(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1474B20", Offset = "0x1473D20", Length = "0x114")]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<FileInfos>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<DirectoryInfos>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<FileSystemInfos>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FBE")]
	public FileSystemInfo ToFileSystemInfo() { }

	[Address(RVA = "0x1474C40", Offset = "0x1473E40", Length = "0x1FB")]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserFiles>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserDirectories>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserEntries>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "StartsWithDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FBF")]
	public string ToSpecifiedFullPath() { }

}

