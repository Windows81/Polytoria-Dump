namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x200012F")]
public struct Span
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000462")]
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000463")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x170000A4")]
	public T Item
	{
		[Address(RVA = "0xF08650", Offset = "0xF07850", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Intrinsic]
		[NonVersionable]
		[Token(Token = "0x60009BC")]
		 get { } //Length: 46
	}

	[Token(Token = "0x170000A5")]
	public int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[NonVersionable]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xF33580", Offset = "0xF32780", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B8")]
	public Span`1(T[] array) { }

	[Address(RVA = "0xF33650", Offset = "0xF32850", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B9")]
	public Span`1(T[] array, int start, int length) { }

	[Address(RVA = "0xF07DB0", Offset = "0xF06FB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BA")]
	public Span`1(Void* pointer, int length) { }

	[Address(RVA = "0xCE3150", Offset = "0xCE2350", Length = "0x8")]
	[CallerCount(Count = 311)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BB")]
	internal Span`1(ref T ptr, int length) { }

	[Address(RVA = "0xF31B80", Offset = "0xF30D80", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "ClearWithoutReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BE")]
	public void Clear() { }

	[Address(RVA = "0xF31C40", Offset = "0xF30E40", Length = "0x8A")]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.Internal.StreamExtension", Member = "<ReadAllToUnmanaged>g__ExtendBuffer|0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.Internal.UnmanagedBuffer&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.Internal.StreamExtension", Member = "ReadAllToUnmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = "System.ValueTuple`2<UnmanagedBuffer, Int32>")]
	[CalledBy(Type = "U8Xml.Internal.NodeStack", Member = "GrowUp", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Path+<>c", Member = "<JoinInternal>b__60_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(System.ValueTuple`8<System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.Boolean, System.ValueTuple`1<System.Boolean>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Path+<>c", Member = "<JoinInternal>b__59_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(System.ValueTuple`5<System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "ReadAllBytesUnknownLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileStream)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C0")]
	public void CopyTo(Span<T> destination) { }

	[Address(RVA = "0xF033B0", Offset = "0xF025B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	[Token(Token = "0x60009C8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF32390", Offset = "0xF31590", Length = "0xAA")]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BF")]
	public void Fill(T value) { }

	[Address(RVA = "0xF08650", Offset = "0xF07850", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Intrinsic]
	[NonVersionable]
	[Token(Token = "0x60009BC")]
	public T get_Item(int index) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60009C7")]
	public int get_Length() { }

	[Address(RVA = "0xF03400", Offset = "0xF02600", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	[Token(Token = "0x60009C9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF03450", Offset = "0xF02650", Length = "0xD")]
	[CallerCount(Count = 272)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BD")]
	public T GetPinnableReference() { }

	[Address(RVA = "0xF337A0", Offset = "0xF329A0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CA")]
	public static Span<T> op_Implicit(T[] array) { }

	[Address(RVA = "0xF33750", Offset = "0xF32950", Length = "0x49")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C2")]
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }

	[Address(RVA = "0xF034E0", Offset = "0xF026E0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C5")]
	public Span<T> Slice(int start, int length) { }

	[Address(RVA = "0xF037E0", Offset = "0xF029E0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C4")]
	public Span<T> Slice(int start) { }

	[Address(RVA = "0xDFD6A0", Offset = "0xDFC8A0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C6")]
	public T[] ToArray() { }

	[Address(RVA = "0xF32F40", Offset = "0xF32140", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C3")]
	public virtual string ToString() { }

	[Address(RVA = "0xF33340", Offset = "0xF32540", Length = "0x87")]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueListBuilder`1), Member = "Grow", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.ValueListBuilder`1", Member = "Grow", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(char), typeof(int), typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Char>", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C1")]
	public bool TryCopyTo(Span<T> destination) { }

}

