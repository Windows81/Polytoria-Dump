namespace System;

[Extension]
[Token(Token = "0x2000131")]
internal static class SpanHelpers
{

	[Address(RVA = "0x14C08D0", Offset = "0x14BFAD0", Length = "0x1FC")]
	[CalledBy(Type = typeof(Span`1), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(bool)}, ReturnType = "System.Net.IPAddress")]
	[CalledBy(Type = "U8Xml.XmlParser", Member = "ParseDtdInternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.RawString", typeof(Int32&), "U8Xml.Internal.RawStringTable&", "U8Xml.RawString&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.Internal.RawStringTable", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "U8Xml.Internal.RawStringTable")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009DD")]
	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	[Address(RVA = "0x14C07A0", Offset = "0x14BF9A0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x60009DE")]
	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }

	[Address(RVA = "0x14C0B30", Offset = "0x14BFD30", Length = "0x223")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60009DA")]
	public static bool EndsWithCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x14C0D60", Offset = "0x14BFF60", Length = "0x213")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DB")]
	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x14C0F80", Offset = "0x14C0180", Length = "0xFC")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DC")]
	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x75CBD0", Offset = "0x75BDD0", Length = "0x339")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NumberBuffer), Member = "get_NumDigits", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 30)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D7")]
	public static int IndexOf(ref T searchSpace, T value, int length) { }

	[Address(RVA = "0x75D390", Offset = "0x75C590", Length = "0xD9")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D6")]
	public static int IndexOf(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[Address(RVA = "0x14C14E0", Offset = "0x14C06E0", Length = "0xD6")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009CB")]
	public static int IndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[Address(RVA = "0x14C1100", Offset = "0x14C0300", Length = "0x3DC")]
	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroup", Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ToggleButtonGroupState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NumberBuffer), Member = "get_NumDigits", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1814B3E40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030530")]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA510")]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009D0")]
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	[Address(RVA = "0x14C15C0", Offset = "0x14C07C0", Length = "0x291")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NumberBuffer), Member = "get_NumDigits", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroup", Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ToggleButtonGroupState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 23)]
	[Token(Token = "0x60009CD")]
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	[Address(RVA = "0x75C9A0", Offset = "0x75BBA0", Length = "0xA1")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D8")]
	public static int IndexOfAny(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[Address(RVA = "0x14C1080", Offset = "0x14C0280", Length = "0x80")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60009CC")]
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[Address(RVA = "0x14C1860", Offset = "0x14C0A60", Length = "0x3D7")]
	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030530")]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807CA510")]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1814B3F90")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009D1")]
	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	[Address(RVA = "0x14C1C40", Offset = "0x14C0E40", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009D3")]
	private static int LocateFirstFoundChar(ulong match) { }

	[Address(RVA = "0x14C1C60", Offset = "0x14C0E60", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030530")]
	[Calls(Type = typeof(System.Numerics.Vector`1<System.UInt64>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60009D2")]
	private static int LocateFirstFoundChar(Vector<UInt16> match) { }

	[Address(RVA = "0x14C1EF0", Offset = "0x14C10F0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009D5")]
	private static int LocateLastFoundChar(ulong match) { }

	[Address(RVA = "0x14C1DB0", Offset = "0x14C0FB0", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030530")]
	[Calls(Type = typeof(System.Numerics.Vector`1<System.UInt64>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60009D4")]
	private static int LocateLastFoundChar(Vector<UInt16> match) { }

	[Address(RVA = "0x14C1F10", Offset = "0x14C1110", Length = "0x409")]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030530")]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 26)]
	[Token(Token = "0x60009CF")]
	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	[Address(RVA = "0x75E7F0", Offset = "0x75D9F0", Length = "0x3C2")]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "U8Xml.XmlParser", Member = "ParseCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.Internal.UnmanagedBuffer&", typeof(int)}, ReturnType = "U8Xml.Internal.XmlObjectCore")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 37)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D9")]
	public static bool SequenceEqual(ref T first, ref T second, int length) { }

	[Address(RVA = "0x14C2320", Offset = "0x14C1520", Length = "0x15F")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x60009CE")]
	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

}

