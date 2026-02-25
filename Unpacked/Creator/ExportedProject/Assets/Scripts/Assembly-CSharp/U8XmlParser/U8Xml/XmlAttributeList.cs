namespace U8Xml;

[DebuggerDisplay("XmlAttribute[{Count}]")]
[DebuggerTypeProxy(typeof(XmlAttributeListTypeProxy))]
[IsReadOnly]
[Token(Token = "0x200000F")]
public struct XmlAttributeList : IEnumerable<XmlAttribute>, IEnumerable, ICollection<XmlAttribute>
{
	[Token(Token = "0x2000010")]
	private sealed class EnumeratorClass : IEnumerator<XmlAttribute>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000D")]
		private Enumerator<XmlAttribute_> _enumerator; //Field offset: 0x10

		[Token(Token = "0x1700000F")]
		public override XmlAttribute Current
		{
			[Address(RVA = "0x1807690", Offset = "0x1806890", Length = "0x35")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600004C")]
			 get { } //Length: 53
		}

		[Nullable(1)]
		[Token(Token = "0x17000010")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1807580", Offset = "0x1806780", Length = "0x68")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[NullableContext(1)]
			[Token(Token = "0x600004D")]
			private get { } //Length: 104
		}

		[Address(RVA = "0x1807640", Offset = "0x1806840", Length = "0x39")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004E")]
		internal EnumeratorClass(in Enumerator<XmlAttribute_> enumerator) { }

		[Address(RVA = "0x18073F0", Offset = "0x18065F0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004F")]
		public override void Dispose() { }

		[Address(RVA = "0x1807690", Offset = "0x1806890", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004C")]
		public override XmlAttribute get_Current() { }

		[Address(RVA = "0x1807480", Offset = "0x1806680", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Enumerator), Member = "NewLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000050")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1807530", Offset = "0x1806730", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000051")]
		public override void Reset() { }

		[Address(RVA = "0x1807580", Offset = "0x1806780", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[NullableContext(1)]
		[Token(Token = "0x600004D")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x2000011")]
	private class XmlAttributeListTypeProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000C")]
	private readonly IntPtr _node; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	public override int Count
	{
		[Address(RVA = "0x180C000", Offset = "0x180B200", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000042")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700000C")]
	private CustomList<XmlAttribute_> List
	{
		[Address(RVA = "0x180C030", Offset = "0x180B230", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000041")]
		private get { } //Length: 33
	}

	[Token(Token = "0x1700000B")]
	private int StartIndex
	{
		[Address(RVA = "0x180C060", Offset = "0x180B260", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000040")]
		private get { } //Length: 32
	}

	[Token(Token = "0x1700000E")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	internal XmlAttributeList(XmlNode_* node) { }

	[Address(RVA = "0x180C000", Offset = "0x180B200", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	public override int get_Count() { }

	[Address(RVA = "0x180C030", Offset = "0x180B230", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	private CustomList<XmlAttribute_> get_List() { }

	[Address(RVA = "0x180C060", Offset = "0x180B260", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	private int get_StartIndex() { }

	[Address(RVA = "0x180BCA0", Offset = "0x180AEA0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000045")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.Add(XmlAttribute item) { }

	[Address(RVA = "0x180BCE0", Offset = "0x180AEE0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000046")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.Clear() { }

	[Address(RVA = "0x180BD20", Offset = "0x180AF20", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000047")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.Contains(XmlAttribute item) { }

	[Address(RVA = "0x180BD60", Offset = "0x180AF60", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[NullableContext(1)]
	[Token(Token = "0x6000048")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.CopyTo(XmlAttribute[] array, int arrayIndex) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.get_IsReadOnly() { }

	[Address(RVA = "0x180BDA0", Offset = "0x180AFA0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000049")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlAttribute>.Remove(XmlAttribute item) { }

	[Address(RVA = "0x180BDE0", Offset = "0x180AFE0", Length = "0x103")]
	[CalledBy(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomList`1), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "U8Xml.Internal.CustomList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[NullableContext(1)]
	[Token(Token = "0x600004A")]
	private override IEnumerator<XmlAttribute> System.Collections.Generic.IEnumerable<U8Xml.XmlAttribute>.GetEnumerator() { }

	[Address(RVA = "0x180BEF0", Offset = "0x180B0F0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomList`1), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "U8Xml.Internal.CustomList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[NullableContext(1)]
	[Token(Token = "0x600004B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

