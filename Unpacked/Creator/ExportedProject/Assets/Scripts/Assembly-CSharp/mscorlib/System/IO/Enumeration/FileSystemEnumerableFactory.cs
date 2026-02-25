namespace System.IO.Enumeration;

[Token(Token = "0x200066D")]
internal static class FileSystemEnumerableFactory
{
	[CompilerGenerated]
	[Token(Token = "0x200066F")]
	private sealed class <>c
	{
		[Token(Token = "0x4001A30")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001A31")]
		public static FindTransform<String> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4001A32")]
		public static FindTransform<String> <>9__4_0; //Field offset: 0x10
		[Token(Token = "0x4001A33")]
		public static FindTransform<String> <>9__5_0; //Field offset: 0x18
		[Token(Token = "0x4001A34")]
		public static FindTransform<FileInfo> <>9__6_0; //Field offset: 0x20
		[Token(Token = "0x4001A35")]
		public static FindTransform<DirectoryInfo> <>9__7_0; //Field offset: 0x28
		[Token(Token = "0x4001A36")]
		public static FindTransform<FileSystemInfo> <>9__8_0; //Field offset: 0x30

		[Address(RVA = "0x147F370", Offset = "0x147E570", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002FD9")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FDA")]
		public <>c() { }

		[Address(RVA = "0x147E960", Offset = "0x147DB60", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6002FDF")]
		internal DirectoryInfo <DirectoryInfos>b__7_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x147E9C0", Offset = "0x147DBC0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6002FDE")]
		internal FileInfo <FileInfos>b__6_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x147EA20", Offset = "0x147DC20", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		[Token(Token = "0x6002FE0")]
		internal FileSystemInfo <FileSystemInfos>b__8_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x147EEB0", Offset = "0x147E0B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FDC")]
		internal string <UserDirectories>b__4_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x147EEB0", Offset = "0x147E0B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FDD")]
		internal string <UserEntries>b__5_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x147EEB0", Offset = "0x147E0B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FDB")]
		internal string <UserFiles>b__3_0(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200066E")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A2E")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A2F")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FD7")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x147EEC0", Offset = "0x147E0C0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002FD8")]
		internal bool <UserFiles>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000670")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A37")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A38")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FE1")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x147EF80", Offset = "0x147E180", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002FE2")]
		internal bool <UserDirectories>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000671")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A39")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A3A")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FE3")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x147F040", Offset = "0x147E240", Length = "0x94")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002FE4")]
		internal bool <UserEntries>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000672")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A3B")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A3C")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FE5")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x147F0E0", Offset = "0x147E2E0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002FE6")]
		internal bool <FileInfos>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000673")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A3D")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A3E")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FE7")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x147F1A0", Offset = "0x147E3A0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002FE8")]
		internal bool <DirectoryInfos>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000674")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A3F")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A40")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FE9")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x147F260", Offset = "0x147E460", Length = "0x94")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002FEA")]
		internal bool <FileSystemInfos>b__1(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x4001A2D")]
	private static readonly Char[] s_unixEscapeChars; //Field offset: 0x0

	[Address(RVA = "0x14763F0", Offset = "0x14755F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002FD6")]
	private static FileSystemEnumerableFactory() { }

	[Address(RVA = "0x1474EC0", Offset = "0x14740C0", Length = "0x207")]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD4")]
	internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x14750D0", Offset = "0x14742D0", Length = "0x207")]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD3")]
	internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x14752E0", Offset = "0x14744E0", Length = "0x207")]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD5")]
	internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x14754F0", Offset = "0x14746F0", Length = "0x2B8")]
	[CalledBy(Type = typeof(<>c__DisplayClass3_0), Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass4_0), Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass5_0), Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass6_0), Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass8_0), Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FCF")]
	private static bool MatchesPattern(string expression, ReadOnlySpan<Char> name, EnumerationOptions options) { }

	[Address(RVA = "0x14757B0", Offset = "0x14749B0", Length = "0x607")]
	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002FCE")]
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	[Address(RVA = "0x1475DC0", Offset = "0x1474FC0", Length = "0x207")]
	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD1")]
	internal static IEnumerable<String> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x1475FD0", Offset = "0x14751D0", Length = "0x207")]
	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD2")]
	internal static IEnumerable<String> UserEntries(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x14761E0", Offset = "0x14753E0", Length = "0x207")]
	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002FD0")]
	internal static IEnumerable<String> UserFiles(string directory, string expression, EnumerationOptions options) { }

}

