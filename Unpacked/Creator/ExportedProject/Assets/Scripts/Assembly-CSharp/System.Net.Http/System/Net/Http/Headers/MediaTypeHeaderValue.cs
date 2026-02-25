namespace System.Net.Http.Headers;

[Token(Token = "0x2000033")]
public class MediaTypeHeaderValue : ICloneable
{
	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000C6")]
		public static Predicate<NameValueHeaderValue> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x1620AF0", Offset = "0x161FCF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000161")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000162")]
		public <>c() { }

		[Address(RVA = "0x1620850", Offset = "0x161FA50", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000163")]
		internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C3")]
	internal List<NameValueHeaderValue> parameters; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C4")]
	internal string media_type; //Field offset: 0x18

	[Token(Token = "0x17000048")]
	public string CharSet
	{
		[Address(RVA = "0x1615030", Offset = "0x1614230", Length = "0x12F")]
		[CalledBy(Type = "System.Net.Http.HttpContent+<ReadAsStringAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000159")]
		 get { } //Length: 303
	}

	[Token(Token = "0x17000049")]
	public ICollection<NameValueHeaderValue> Parameters
	{
		[Address(RVA = "0x1615160", Offset = "0x1614360", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600015A")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x1614D60", Offset = "0x1613F60", Length = "0x2CE")]
	[CalledBy(Type = typeof(MediaTypeHeaderValue), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000157")]
	protected MediaTypeHeaderValue(MediaTypeHeaderValue source) { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000158")]
	internal MediaTypeHeaderValue() { }

	[Address(RVA = "0x16146D0", Offset = "0x16138D0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Collections.Generic.List`1<TSource>"}, ReturnType = typeof(bool))]
	[Token(Token = "0x600015C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1615030", Offset = "0x1614230", Length = "0x12F")]
	[CalledBy(Type = "System.Net.Http.HttpContent+<ReadAsStringAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000159")]
	public string get_CharSet() { }

	[Address(RVA = "0x1615160", Offset = "0x1614360", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600015A")]
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	[Address(RVA = "0x1614780", Offset = "0x1613980", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(HashCodeCalculator), Member = "Calculate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ICollection`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1614800", Offset = "0x1613A00", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MediaTypeHeaderValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MediaTypeHeaderValue)}, ReturnType = typeof(void))]
	[Token(Token = "0x600015B")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x1614860", Offset = "0x1613A60", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600015E")]
	public virtual string ToString() { }

	[Address(RVA = "0x1614B80", Offset = "0x1613D80", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MediaTypeHeaderValue), Member = "TryParseMediaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(String&)}, ReturnType = typeof(System.Nullable`1<System.Net.Http.Headers.Token>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NameValueHeaderValue), Member = "TryParseParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(List`1<NameValueHeaderValue>&), typeof(Token&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600015F")]
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	[Address(RVA = "0x16148D0", Offset = "0x1613AD0", Length = "0x2A3")]
	[CalledBy(Type = typeof(MediaTypeHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MediaTypeHeaderValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MediaTypeWithQualityHeaderValue), Member = "TryParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(MediaTypeWithQualityHeaderValue&), typeof(Token&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000160")]
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

