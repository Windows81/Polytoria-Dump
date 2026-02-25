namespace U8Xml;

[DebuggerDisplay("{DebugDisplay,nq}")]
[DebuggerTypeProxy(typeof(XmlNodeListTypeProxy))]
[IsReadOnly]
[Token(Token = "0x2000018")]
public struct XmlNodeList : IEnumerable<XmlNode>, IEnumerable, ICollection<XmlNode>, IReference
{
	[Token(Token = "0x2000019")]
	internal struct Enumerator : IEnumerator<XmlNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002B")]
		private XmlNode_* _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002C")]
		private XmlNode_* _next; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002D")]
		private readonly XmlNodeType _targetType; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400002E")]
		private readonly bool _hasTargetType; //Field offset: 0x11

		[Token(Token = "0x1700001C")]
		public override XmlNode Current
		{
			[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
			[CallerCount(Count = 6)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000078")]
			 get { } //Length: 10
		}

		[Nullable(1)]
		[Token(Token = "0x1700001D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1807770", Offset = "0x1806970", Length = "0x4B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[CallsDeduplicatedMethods(Count = 1)]
			[NullableContext(1)]
			[Token(Token = "0x6000079")]
			private get { } //Length: 75
		}

		[Address(RVA = "0x18077C0", Offset = "0x18069C0", Length = "0xBA")]
		[CalledBy(Type = typeof(XmlNodeList), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000077")]
		internal Enumerator(XmlNode_* parent, Nullable<XmlNodeType> targetType) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007A")]
		public override void Dispose() { }

		[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000078")]
		public override XmlNode get_Current() { }

		[Address(RVA = "0x18076D0", Offset = "0x18068D0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600007B")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1807720", Offset = "0x1806920", Length = "0x4E")]
		[CalledBy(Type = "U8Xml.XmlNodeList+EnumeratorClass", Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600007C")]
		public override void Reset() { }

		[Address(RVA = "0x1807770", Offset = "0x1806970", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[NullableContext(1)]
		[Token(Token = "0x6000079")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x200001A")]
	private sealed class EnumeratorClass : IEnumerator<XmlNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002F")]
		private Enumerator _enumerator; //Field offset: 0x10

		[Token(Token = "0x1700001E")]
		public override XmlNode Current
		{
			[Address(RVA = "0x1807680", Offset = "0x1806880", Length = "0xB")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600007D")]
			 get { } //Length: 11
		}

		[Nullable(1)]
		[Token(Token = "0x1700001F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x18075F0", Offset = "0x18067F0", Length = "0x4C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[CallsDeduplicatedMethods(Count = 1)]
			[NullableContext(1)]
			[Token(Token = "0x600007E")]
			private get { } //Length: 76
		}

		[Address(RVA = "0x1806560", Offset = "0x1805760", Length = "0xE8")]
		[CalledBy(Type = typeof(XmlNodeList), Member = "System.Collections.Generic.IEnumerable<U8Xml.XmlNode>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<U8Xml.XmlNode>))]
		[CalledBy(Type = typeof(XmlNodeList), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600007F")]
		internal EnumeratorClass(XmlNode_* parent, Nullable<XmlNodeType> targetType) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		public override void Dispose() { }

		[Address(RVA = "0x1807680", Offset = "0x1806880", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600007D")]
		public override XmlNode get_Current() { }

		[Address(RVA = "0x1807430", Offset = "0x1806630", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000081")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1807570", Offset = "0x1806770", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[Token(Token = "0x6000082")]
		public override void Reset() { }

		[Address(RVA = "0x18075F0", Offset = "0x18067F0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[NullableContext(1)]
		[Token(Token = "0x600007E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x200001B")]
	private sealed class XmlNodeListTypeProxy
	{

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000029")]
	private readonly XmlNode_* _parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002A")]
	private readonly Nullable<XmlNodeType> _targetType; //Field offset: 0x8

	[Token(Token = "0x1700001A")]
	public override int Count
	{
		[Address(RVA = "0x180C530", Offset = "0x180B730", Length = "0x91")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000019")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600006B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001B")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlNode>.IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006D")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x180C520", Offset = "0x180B720", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006E")]
	internal XmlNodeList(XmlNode_* parent, Nullable<XmlNodeType> targetType) { }

	[Address(RVA = "0x180C530", Offset = "0x180B730", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006C")]
	public override int get_Count() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x180C2C0", Offset = "0x180B4C0", Length = "0x34")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode_*), typeof(System.Nullable`1<U8Xml.XmlNodeType>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006F")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x180C300", Offset = "0x180B500", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000072")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlNode>.Add(XmlNode item) { }

	[Address(RVA = "0x180C340", Offset = "0x180B540", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000073")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlNode>.Clear() { }

	[Address(RVA = "0x180C380", Offset = "0x180B580", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000074")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlNode>.Contains(XmlNode item) { }

	[Address(RVA = "0x180C3C0", Offset = "0x180B5C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[NullableContext(1)]
	[Token(Token = "0x6000075")]
	private override void System.Collections.Generic.ICollection<U8Xml.XmlNode>.CopyTo(XmlNode[] array, int arrayIndex) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlNode>.get_IsReadOnly() { }

	[Address(RVA = "0x180C400", Offset = "0x180B600", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000076")]
	private override bool System.Collections.Generic.ICollection<U8Xml.XmlNode>.Remove(XmlNode item) { }

	[Address(RVA = "0x180C440", Offset = "0x180B640", Length = "0x69")]
	[CalledBy(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EnumeratorClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode_*), typeof(System.Nullable`1<U8Xml.XmlNodeType>)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	[Token(Token = "0x6000070")]
	private override IEnumerator<XmlNode> System.Collections.Generic.IEnumerable<U8Xml.XmlNode>.GetEnumerator() { }

	[Address(RVA = "0x180C4B0", Offset = "0x180B6B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EnumeratorClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode_*), typeof(System.Nullable`1<U8Xml.XmlNodeType>)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	[Token(Token = "0x6000071")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

