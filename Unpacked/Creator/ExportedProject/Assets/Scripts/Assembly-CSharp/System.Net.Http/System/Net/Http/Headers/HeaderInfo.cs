namespace System.Net.Http.Headers;

[Token(Token = "0x2000024")]
internal abstract class HeaderInfo
{
	[Token(Token = "0x2000026")]
	private class CollectionHeaderTypeInfo : HeaderTypeInfo<T, U>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000091")]
		private readonly int minimalCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000092")]
		private readonly string separator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000093")]
		private readonly TryParseListDelegate<T> parser; //Field offset: 0x0

		[Token(Token = "0x17000034")]
		public virtual string Separator
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000F9")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x96C1A0", Offset = "0x96B3A0", Length = "0x67")]
		[CalledBy(Type = typeof(HeaderInfo), Member = "CreateMulti", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseListDelegate`1<T>", typeof(HttpHeaderKind), typeof(int), typeof(string)}, ReturnType = typeof(HeaderInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Net.Http.Headers.HeaderInfo+HeaderTypeInfo`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseDelegate`1<T>", typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F8")]
		public CollectionHeaderTypeInfo`2(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F9")]
		public virtual string get_Separator() { }

		[Address(RVA = "0x96C120", Offset = "0x96B320", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FA")]
		public virtual bool TryParse(string value, out object result) { }

	}

	[Token(Token = "0x2000025")]
	private class HeaderTypeInfo : HeaderInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000090")]
		private readonly TryParseDelegate<T> parser; //Field offset: 0x0

		[Address(RVA = "0xC85390", Offset = "0xC84590", Length = "0x38")]
		[CalledBy(Type = "System.Net.Http.Headers.HeaderInfo+CollectionHeaderTypeInfo`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseListDelegate`1<T>", typeof(HttpHeaderKind), typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HeaderInfo), Member = "CreateSingle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseDelegate`1<T>", typeof(HttpHeaderKind), typeof(System.Func`2<System.Object, System.String>)}, ReturnType = typeof(HeaderInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HeaderInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F3")]
		public HeaderTypeInfo`2(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }

		[Address(RVA = "0xC83840", Offset = "0xC82A40", Length = "0x170")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6CE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F4")]
		public virtual void AddToCollection(object collection, object value) { }

		[Address(RVA = "0xC839C0", Offset = "0xC82BC0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F5")]
		protected virtual object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }

		[Address(RVA = "0xC83DF0", Offset = "0xC82FF0", Length = "0x3A8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6D60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F6")]
		public virtual List<String> ToStringCollection(object collection) { }

		[Address(RVA = "0xC85060", Offset = "0xC84260", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F7")]
		public virtual bool TryParse(string value, out object result) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008C")]
	public bool AllowsMany; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400008D")]
	public readonly HttpHeaderKind HeaderKind; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008E")]
	public readonly string Name; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008F")]
	private Func<Object, String> <CustomToString>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000032")]
	public private Func<Object, String> CustomToString
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000ED")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000033")]
	public override string Separator
	{
		[Address(RVA = "0x160B250", Offset = "0x160A450", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60000EE")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x160B200", Offset = "0x160A400", Length = "0x42")]
	[CalledBy(Type = typeof(HeaderTypeInfo`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseDelegate`1<T>", typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E8")]
	protected HeaderInfo(string name, HttpHeaderKind headerKind) { }

	[Token(Token = "0x60000EF")]
	public abstract void AddToCollection(object collection, object value) { }

	[Address(RVA = "0x160B1E0", Offset = "0x160A3E0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EB")]
	public object CreateCollection(HttpHeaders headers) { }

	[Token(Token = "0x60000F0")]
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }

	[Address(RVA = "0x6D6230", Offset = "0x6D5430", Length = "0xAA")]
	[CalledBy(Type = typeof(HttpHeaders), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionHeaderTypeInfo`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseListDelegate`1<T>", typeof(HttpHeaderKind), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EA")]
	public static HeaderInfo CreateMulti(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }

	[Address(RVA = "0x6D62E0", Offset = "0x6D54E0", Length = "0xB0")]
	[CalledBy(Type = typeof(HttpHeaders), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HeaderTypeInfo`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.TryParseDelegate`1<T>", typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	public static HeaderInfo CreateSingle(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<Object, String> toString = null) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	public Func<Object, String> get_CustomToString() { }

	[Address(RVA = "0x160B250", Offset = "0x160A450", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000EE")]
	public override string get_Separator() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	private void set_CustomToString(Func<Object, String> value) { }

	[Token(Token = "0x60000F1")]
	public abstract List<String> ToStringCollection(object collection) { }

	[Token(Token = "0x60000F2")]
	public abstract bool TryParse(string value, out object result) { }

}

