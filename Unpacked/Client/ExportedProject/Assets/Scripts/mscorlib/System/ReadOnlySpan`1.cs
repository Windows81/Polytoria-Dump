namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000129")]
public struct ReadOnlySpan
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045C")]
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045D")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x170000A3")]
	public static ReadOnlySpan<T> Empty
	{
		[Address(RVA = "0xF085C0", Offset = "0xF077C0", Length = "0xA")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600096F")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170000A2")]
	public bool IsEmpty
	{
		[Address(RVA = "0xF085D0", Offset = "0xF077D0", Length = "0x8")]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[NonVersionable]
		[Token(Token = "0x600096B")]
		 get { } //Length: 8
	}

	[IsReadOnly]
	[Token(Token = "0x170000A0")]
	public T Item
	{
		[Address(RVA = "0xF08650", Offset = "0xF07850", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Intrinsic]
		[NonVersionable]
		[Token(Token = "0x6000962")]
		 get { } //Length: 46
	}

	[Token(Token = "0x170000A1")]
	public int Length
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[NonVersionable]
		[Token(Token = "0x600096A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xF07F00", Offset = "0xF07100", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095E")]
	public ReadOnlySpan`1(T[] array) { }

	[Address(RVA = "0xF082B0", Offset = "0xF074B0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600095F")]
	public ReadOnlySpan`1(T[] array, int start, int length) { }

	[Address(RVA = "0xF07DB0", Offset = "0xF06FB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000960")]
	public ReadOnlySpan`1(Void* pointer, int length) { }

	[Address(RVA = "0xCE3150", Offset = "0xCE2350", Length = "0x8")]
	[CallerCount(Count = 311)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000961")]
	internal ReadOnlySpan`1(ref T ptr, int length) { }

	[Address(RVA = "0xF02C60", Offset = "0xF01E60", Length = "0x8A")]
	[CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Stream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(Utf8Parser), Member = "TryParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(NumberBuffer&), typeof(Int32&), "System.Buffers.Text.Utf8Parser+ParseNumberOptions", typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "CopyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Guid), Member = "EatAllWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[CalledBy(Type = typeof(__DTString), Member = "RemoveLeadingInQuoteSpaces", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = "RemoveTrailingInQuoteSpaces", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000964")]
	public void CopyTo(Span<T> destination) { }

	[Address(RVA = "0xF033B0", Offset = "0xF025B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	[Token(Token = "0x600096C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF085C0", Offset = "0xF077C0", Length = "0xA")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600096F")]
	public static ReadOnlySpan<T> get_Empty() { }

	[Address(RVA = "0xF085D0", Offset = "0xF077D0", Length = "0x8")]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x600096B")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xF08650", Offset = "0xF07850", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Intrinsic]
	[NonVersionable]
	[Token(Token = "0x6000962")]
	public T get_Item(int index) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x600096A")]
	public int get_Length() { }

	[Address(RVA = "0xF03400", Offset = "0xF02600", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	[Token(Token = "0x600096D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF03450", Offset = "0xF02650", Length = "0xD")]
	[CallerCount(Count = 272)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000963")]
	public T GetPinnableReference() { }

	[Address(RVA = "0xF088F0", Offset = "0xF07AF0", Length = "0xE8")]
	[CallerCount(Count = 105)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[DeduplicatedMethod]
	[Token(Token = "0x600096E")]
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }

	[Address(RVA = "0xF037E0", Offset = "0xF029E0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000967")]
	public ReadOnlySpan<T> Slice(int start) { }

	[Address(RVA = "0xF034E0", Offset = "0xF026E0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000968")]
	public ReadOnlySpan<T> Slice(int start, int length) { }

	[Address(RVA = "0xF04E30", Offset = "0xF04030", Length = "0x147")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexWriter", Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.RegexTree"}, ReturnType = "System.Text.RegularExpressions.RegexCode")]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000969")]
	public T[] ToArray() { }

	[Address(RVA = "0xF05A80", Offset = "0xF04C80", Length = "0x169")]
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
	[Token(Token = "0x6000966")]
	public virtual string ToString() { }

	[Address(RVA = "0xF079C0", Offset = "0xF06BC0", Length = "0x87")]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(string), "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000965")]
	public bool TryCopyTo(Span<T> destination) { }

}

