namespace System.Xml;

[Token(Token = "0x200003F")]
internal class XmlTextReaderImpl : XmlReader, IXmlNamespaceResolver
{
	[Token(Token = "0x200004C")]
	private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<Object>
	{
		[Token(Token = "0x40001C7")]
		private static IComparer<Object> s_instance; //Field offset: 0x0

		[Token(Token = "0x170000C2")]
		internal static IComparer<Object> Instance
		{
			[Address(RVA = "0x1657480", Offset = "0x1656680", Length = "0x4E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6000386")]
			internal get { } //Length: 78
		}

		[Address(RVA = "0x1657410", Offset = "0x1656610", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000389")]
		private static DtdDefaultAttributeInfoToNodeDataComparer() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000388")]
		public DtdDefaultAttributeInfoToNodeDataComparer() { }

		[Address(RVA = "0x16571A0", Offset = "0x16563A0", Length = "0x26D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000387")]
		public override int Compare(object x, object y) { }

		[Address(RVA = "0x1657480", Offset = "0x1656680", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000386")]
		internal static IComparer<Object> get_Instance() { }

	}

	[Token(Token = "0x200004A")]
	public class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B2")]
		private XmlTextReaderImpl reader; //Field offset: 0x10

		[Token(Token = "0x170000AD")]
		private override Uri System.Xml.IDtdParserAdapter.BaseUri
		{
			[Address(RVA = "0x1657730", Offset = "0x1656930", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_BaseUri", ReturnType = typeof(Uri))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000350")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B1")]
		private override int System.Xml.IDtdParserAdapter.CurrentPosition
		{
			[Address(RVA = "0x1657750", Offset = "0x1656950", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000354")]
			private get { } //Length: 29
			[Address(RVA = "0x1657890", Offset = "0x1656A90", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000355")]
			private set { } //Length: 30
		}

		[Token(Token = "0x170000B2")]
		private override int System.Xml.IDtdParserAdapter.EntityStackLength
		{
			[Address(RVA = "0x1657770", Offset = "0x1656970", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000356")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B3")]
		private override bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
		{
			[Address(RVA = "0x1657790", Offset = "0x1656990", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000357")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000AE")]
		private override bool System.Xml.IDtdParserAdapter.IsEof
		{
			[Address(RVA = "0x16577B0", Offset = "0x16569B0", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000351")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B4")]
		private override int System.Xml.IDtdParserAdapter.LineNo
		{
			[Address(RVA = "0x16577D0", Offset = "0x16569D0", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000359")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B5")]
		private override int System.Xml.IDtdParserAdapter.LineStartPosition
		{
			[Address(RVA = "0x16577F0", Offset = "0x16569F0", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600035A")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000AC")]
		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
		{
			[Address(RVA = "0x1657830", Offset = "0x1656A30", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600034F")]
			private get { } //Length: 30
		}

		[Token(Token = "0x170000AB")]
		private override XmlNameTable System.Xml.IDtdParserAdapter.NameTable
		{
			[Address(RVA = "0x1657810", Offset = "0x1656A10", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600034E")]
			private get { } //Length: 30
		}

		[Token(Token = "0x170000AF")]
		private override Char[] System.Xml.IDtdParserAdapter.ParsingBuffer
		{
			[Address(RVA = "0x1657870", Offset = "0x1656A70", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000352")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B0")]
		private override int System.Xml.IDtdParserAdapter.ParsingBufferLength
		{
			[Address(RVA = "0x1657850", Offset = "0x1656A50", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000353")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B9")]
		private override bool System.Xml.IDtdParserAdapterV1.Namespaces
		{
			[Address(RVA = "0x16574D0", Offset = "0x16566D0", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600036A")]
			private get { } //Length: 30
		}

		[Token(Token = "0x170000B8")]
		private override bool System.Xml.IDtdParserAdapterV1.Normalization
		{
			[Address(RVA = "0x16574F0", Offset = "0x16566F0", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000369")]
			private get { } //Length: 30
		}

		[Token(Token = "0x170000BA")]
		private override bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
		{
			[Address(RVA = "0x1657510", Offset = "0x1656710", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600036B")]
			private get { } //Length: 30
		}

		[Token(Token = "0x170000B6")]
		private override bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
		{
			[Address(RVA = "0x1657530", Offset = "0x1656730", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000367")]
			private get { } //Length: 29
		}

		[Token(Token = "0x170000B7")]
		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
		{
			[Address(RVA = "0x1657550", Offset = "0x1656750", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000368")]
			private get { } //Length: 30
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034D")]
		internal DtdParserProxy(XmlTextReaderImpl reader) { }

		[Address(RVA = "0x1657730", Offset = "0x1656930", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_BaseUri", ReturnType = typeof(Uri))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000350")]
		private override Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

		[Address(RVA = "0x1657750", Offset = "0x1656950", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000354")]
		private override int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

		[Address(RVA = "0x1657770", Offset = "0x1656970", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000356")]
		private override int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

		[Address(RVA = "0x1657790", Offset = "0x1656990", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000357")]
		private override bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

		[Address(RVA = "0x16577B0", Offset = "0x16569B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000351")]
		private override bool System.Xml.IDtdParserAdapter.get_IsEof() { }

		[Address(RVA = "0x16577D0", Offset = "0x16569D0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000359")]
		private override int System.Xml.IDtdParserAdapter.get_LineNo() { }

		[Address(RVA = "0x16577F0", Offset = "0x16569F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600035A")]
		private override int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

		[Address(RVA = "0x1657830", Offset = "0x1656A30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600034F")]
		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

		[Address(RVA = "0x1657810", Offset = "0x1656A10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600034E")]
		private override XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

		[Address(RVA = "0x1657870", Offset = "0x1656A70", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000352")]
		private override Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

		[Address(RVA = "0x1657850", Offset = "0x1656A50", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000353")]
		private override int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

		[Address(RVA = "0x1657570", Offset = "0x1656770", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000358")]
		private override void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

		[Address(RVA = "0x1657590", Offset = "0x1656790", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000366")]
		private override void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

		[Address(RVA = "0x16575C0", Offset = "0x16567C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000365")]
		private override void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

		[Address(RVA = "0x16575F0", Offset = "0x16567F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600035F")]
		private override void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

		[Address(RVA = "0x1657610", Offset = "0x1656810", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600035D")]
		private override int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

		[Address(RVA = "0x1657630", Offset = "0x1656830", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600035C")]
		private override int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

		[Address(RVA = "0x1657650", Offset = "0x1656850", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600035E")]
		private override void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

		[Address(RVA = "0x1657670", Offset = "0x1656870", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000361")]
		private override bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

		[Address(RVA = "0x1657690", Offset = "0x1656890", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000360")]
		private override bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

		[Address(RVA = "0x16576B0", Offset = "0x16568B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000362")]
		private override bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

		[Address(RVA = "0x16576D0", Offset = "0x16568D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000363")]
		private override void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

		[Address(RVA = "0x16576F0", Offset = "0x16568F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ReadData", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600035B")]
		private override int System.Xml.IDtdParserAdapter.ReadData() { }

		[Address(RVA = "0x1657890", Offset = "0x1656A90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000355")]
		private override void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

		[Address(RVA = "0x1657710", Offset = "0x1656910", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000364")]
		private override void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

		[Address(RVA = "0x16574D0", Offset = "0x16566D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600036A")]
		private override bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

		[Address(RVA = "0x16574F0", Offset = "0x16566F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000369")]
		private override bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

		[Address(RVA = "0x1657510", Offset = "0x1656710", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600036B")]
		private override bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

		[Address(RVA = "0x1657530", Offset = "0x1656730", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000367")]
		private override bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

		[Address(RVA = "0x1657550", Offset = "0x1656750", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000368")]
		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	}

	[Token(Token = "0x2000043")]
	private enum EntityExpandType
	{
		All = 0,
		OnlyGeneral = 1,
		OnlyCharacter = 2,
	}

	[Token(Token = "0x2000042")]
	private enum EntityType
	{
		CharacterDec = 0,
		CharacterHex = 1,
		CharacterNamed = 2,
		Expanded = 3,
		Skipped = 4,
		FakeExpanded = 5,
		Unexpanded = 6,
		ExpandedInAttribute = 7,
	}

	[Token(Token = "0x2000044")]
	private enum IncrementalReadState
	{
		Text = 0,
		StartTag = 1,
		PI = 2,
		CDATA = 3,
		Comment = 4,
		Attributes = 5,
		AttributeValue = 6,
		ReadData = 7,
		EndElement = 8,
		End = 9,
		ReadValueChunk_OnCachedValue = 10,
		ReadValueChunk_OnPartialValue = 11,
		ReadContentAsBinary_OnCachedValue = 12,
		ReadContentAsBinary_OnPartialValue = 13,
		ReadContentAsBinary_End = 14,
	}

	[Token(Token = "0x2000046")]
	private enum InitInputType
	{
		UriString = 0,
		Stream = 1,
		TextReader = 2,
		Invalid = 3,
	}

	[Token(Token = "0x2000045")]
	private class LaterInitParam
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400018A")]
		public bool useAsync; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400018B")]
		public Stream inputStream; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400018C")]
		public Byte[] inputBytes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400018D")]
		public int inputByteCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400018E")]
		public Uri inputbaseUri; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400018F")]
		public string inputUriStr; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000190")]
		public XmlResolver inputUriResolver; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000191")]
		public XmlParserContext inputContext; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000192")]
		public TextReader inputTextReader; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000193")]
		public InitInputType initType; //Field offset: 0x58

	}

	[Token(Token = "0x200004B")]
	private class NodeData : IComparable
	{
		[Token(Token = "0x40001B3")]
		private static NodeData s_None; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B4")]
		internal XmlNodeType type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B5")]
		internal string localName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B6")]
		internal string prefix; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B7")]
		internal string ns; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001B8")]
		internal string nameWPrefix; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001B9")]
		private string value; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001BA")]
		private Char[] chars; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001BB")]
		private int valueStartPos; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40001BC")]
		private int valueLength; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001BD")]
		internal LineInfo lineInfo; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001BE")]
		internal LineInfo lineInfo2; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001BF")]
		internal char quoteChar; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40001C0")]
		internal int depth; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001C1")]
		private bool isEmptyOrDefault; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40001C2")]
		internal int entityId; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001C3")]
		internal bool xmlContextPushed; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001C4")]
		internal NodeData nextAttrValueChunk; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40001C5")]
		internal object schemaType; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001C6")]
		internal object typedValue; //Field offset: 0x88

		[Token(Token = "0x170000BF")]
		internal bool IsDefaultAttribute
		{
			[Address(RVA = "0x16580D0", Offset = "0x16572D0", Length = "0xE")]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsDefault", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x6000372")]
			internal get { } //Length: 14
			[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000373")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x170000BE")]
		internal bool IsEmptyElement
		{
			[Address(RVA = "0x16580E0", Offset = "0x16572E0", Length = "0xE")]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x6000370")]
			internal get { } //Length: 14
			[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000371")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x170000BC")]
		internal int LineNo
		{
			[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x600036E")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x170000BD")]
		internal int LinePos
		{
			[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			[Token(Token = "0x600036F")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x170000BB")]
		internal static NodeData None
		{
			[Address(RVA = "0x16580F0", Offset = "0x16572F0", Length = "0x12F")]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600036C")]
			internal get { } //Length: 303
		}

		[Token(Token = "0x170000C1")]
		internal string StringValue
		{
			[Address(RVA = "0x1658220", Offset = "0x1657420", Length = "0x50")]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x6000375")]
			internal get { } //Length: 80
		}

		[Token(Token = "0x170000C0")]
		internal bool ValueBuffered
		{
			[Address(RVA = "0x1658270", Offset = "0x1657470", Length = "0x9")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000374")]
			internal get { } //Length: 9
		}

		[Address(RVA = "0x1658030", Offset = "0x1657230", Length = "0xA0")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600036D")]
		internal NodeData() { }

		[Address(RVA = "0x1657990", Offset = "0x1656B90", Length = "0x8D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000377")]
		internal void Clear(XmlNodeType type) { }

		[Address(RVA = "0x1657900", Offset = "0x1656B00", Length = "0x86")]
		[CalledBy(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000378")]
		internal void ClearName() { }

		[Address(RVA = "0x1657A20", Offset = "0x1656C20", Length = "0x89")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000382")]
		internal void CopyTo(int valueOffset, StringBuilder sb) { }

		[Address(RVA = "0x1657AB0", Offset = "0x1656CB0", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000384")]
		internal string CreateNameWPrefix(XmlNameTable nt) { }

		[Address(RVA = "0x16580D0", Offset = "0x16572D0", Length = "0xE")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsDefault", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000372")]
		internal bool get_IsDefaultAttribute() { }

		[Address(RVA = "0x16580E0", Offset = "0x16572E0", Length = "0xE")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000370")]
		internal bool get_IsEmptyElement() { }

		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036E")]
		internal int get_LineNo() { }

		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036F")]
		internal int get_LinePos() { }

		[Address(RVA = "0x16580F0", Offset = "0x16572F0", Length = "0x12F")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600036C")]
		internal static NodeData get_None() { }

		[Address(RVA = "0x1658220", Offset = "0x1657420", Length = "0x50")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000375")]
		internal string get_StringValue() { }

		[Address(RVA = "0x1658270", Offset = "0x1657470", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000374")]
		internal bool get_ValueBuffered() { }

		[Address(RVA = "0x1657B50", Offset = "0x1656D50", Length = "0xB1")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000383")]
		internal string GetNameWPrefix(XmlNameTable nt) { }

		[Address(RVA = "0x1657C10", Offset = "0x1656E10", Length = "0x56")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000381")]
		internal void OnBufferInvalidated() { }

		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000373")]
		internal void set_IsDefaultAttribute(bool value) { }

		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000371")]
		internal void set_IsEmptyElement(bool value) { }

		[Address(RVA = "0x1657C80", Offset = "0x1656E80", Length = "0xC")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000379")]
		internal void SetLineInfo(int lineNo, int linePos) { }

		[Address(RVA = "0x1657C70", Offset = "0x1656E70", Length = "0xC")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600037A")]
		internal void SetLineInfo2(int lineNo, int linePos) { }

		[Address(RVA = "0x1657C90", Offset = "0x1656E90", Length = "0xAC")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600037D")]
		internal void SetNamedNode(XmlNodeType type, string localName) { }

		[Address(RVA = "0x1657D40", Offset = "0x1656F40", Length = "0x93")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600037E")]
		internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

		[Address(RVA = "0x1657E80", Offset = "0x1657080", Length = "0x14")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600037F")]
		internal void SetValue(string value) { }

		[Address(RVA = "0x1657EA0", Offset = "0x16570A0", Length = "0x5E")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000380")]
		internal void SetValue(Char[] chars, int startPos, int len) { }

		[Address(RVA = "0x1657DE0", Offset = "0x1656FE0", Length = "0x3C")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600037B")]
		internal void SetValueNode(XmlNodeType type, string value) { }

		[Address(RVA = "0x1657E20", Offset = "0x1657020", Length = "0x5F")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600037C")]
		internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

		[Address(RVA = "0x1657F00", Offset = "0x1657100", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000385")]
		private override int System.IComparable.CompareTo(object obj) { }

		[Address(RVA = "0x1657FE0", Offset = "0x16571E0", Length = "0x48")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000376")]
		internal void TrimSpacesInValue() { }

	}

	[Token(Token = "0x2000049")]
	private class NoNamespaceManager : XmlNamespaceManager
	{

		[Token(Token = "0x170000AA")]
		public virtual string DefaultNamespace
		{
			[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000346")]
			 get { } //Length: 18
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000345")]
		public NoNamespaceManager() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000349")]
		public virtual void AddNamespace(string prefix, string uri) { }

		[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000346")]
		public virtual string get_DefaultNamespace() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034A")]
		public virtual IEnumerator GetEnumerator() { }

		[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034B")]
		public virtual string LookupNamespace(string prefix) { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600034C")]
		public virtual string LookupPrefix(string uri) { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000348")]
		public virtual bool PopScope() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000347")]
		public virtual void PushScope() { }

	}

	[Token(Token = "0x200004D")]
	public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
	{

		[Address(RVA = "0x335350", Offset = "0x334550", Length = "0x125")]
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600038A")]
		public OnDefaultAttributeUseDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600038B")]
		public override void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	}

	[Token(Token = "0x2000040")]
	private enum ParsingFunction
	{
		ElementContent = 0,
		NoData = 1,
		OpenUrl = 2,
		SwitchToInteractive = 3,
		SwitchToInteractiveXmlDecl = 4,
		DocumentContent = 5,
		MoveToElementContent = 6,
		PopElementContext = 7,
		PopEmptyElementContext = 8,
		ResetAttributesRootLevel = 9,
		Error = 10,
		Eof = 11,
		ReaderClosed = 12,
		EntityReference = 13,
		InIncrementalRead = 14,
		FragmentAttribute = 15,
		ReportEndEntity = 16,
		AfterResolveEntityInContent = 17,
		AfterResolveEmptyEntityInContent = 18,
		XmlDeclarationFragment = 19,
		GoToEof = 20,
		PartialTextValue = 21,
		InReadAttributeValue = 22,
		InReadValueChunk = 23,
		InReadContentAsBinary = 24,
		InReadElementContentAsBinary = 25,
	}

	[Token(Token = "0x2000041")]
	private enum ParsingMode
	{
		Full = 0,
		SkipNode = 1,
		SkipContent = 2,
	}

	[Token(Token = "0x2000047")]
	private struct ParsingState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000199")]
		internal Char[] chars; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019A")]
		internal int charPos; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400019B")]
		internal int charsUsed; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019C")]
		internal Encoding encoding; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400019D")]
		internal bool appendMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400019E")]
		internal Stream stream; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400019F")]
		internal Decoder decoder; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001A0")]
		internal Byte[] bytes; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001A1")]
		internal int bytePos; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40001A2")]
		internal int bytesUsed; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001A3")]
		internal TextReader textReader; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001A4")]
		internal int lineNo; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40001A5")]
		internal int lineStartPos; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001A6")]
		internal string baseUriStr; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001A7")]
		internal Uri baseUri; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001A8")]
		internal bool isEof; //Field offset: 0x60
		[FieldOffset(Offset = "0x61")]
		[Token(Token = "0x40001A9")]
		internal bool isStreamEof; //Field offset: 0x61
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001AA")]
		internal IDtdEntityInfo entity; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001AB")]
		internal int entityId; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40001AC")]
		internal bool eolNormalized; //Field offset: 0x74
		[FieldOffset(Offset = "0x75")]
		[Token(Token = "0x40001AD")]
		internal bool entityResolvedManually; //Field offset: 0x75

		[Token(Token = "0x170000A8")]
		internal int LineNo
		{
			[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
			[CallerCount(Count = 10)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000341")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x170000A9")]
		internal int LinePos
		{
			[Address(RVA = "0x16583A0", Offset = "0x16575A0", Length = "0x7")]
			[CallerCount(Count = 32)]
			[Token(Token = "0x6000342")]
			internal get { } //Length: 7
		}

		[Address(RVA = "0x1658280", Offset = "0x1657480", Length = "0xBC")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600033F")]
		internal void Clear() { }

		[Address(RVA = "0x1658340", Offset = "0x1657540", Length = "0x5D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000340")]
		internal void Close(bool closeInput) { }

		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000341")]
		internal int get_LineNo() { }

		[Address(RVA = "0x16583A0", Offset = "0x16575A0", Length = "0x7")]
		[CallerCount(Count = 32)]
		[Token(Token = "0x6000342")]
		internal int get_LinePos() { }

	}

	[Token(Token = "0x2000048")]
	private class XmlContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001AE")]
		internal XmlSpace xmlSpace; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001AF")]
		internal string xmlLang; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B0")]
		internal string defaultNamespace; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B1")]
		internal XmlContext previousContext; //Field offset: 0x28

		[Address(RVA = "0x1658420", Offset = "0x1657620", Length = "0x6B")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000343")]
		internal XmlContext() { }

		[Address(RVA = "0x1658490", Offset = "0x1657690", Length = "0x63")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000344")]
		internal XmlContext(XmlContext previousContext) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000102")]
	private LaterInitParam laterInitParam; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000103")]
	private XmlCharType xmlCharType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000104")]
	private ParsingState ps; //Field offset: 0x20
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000105")]
	private ParsingFunction parsingFunction; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000106")]
	private ParsingFunction nextParsingFunction; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000107")]
	private ParsingFunction nextNextParsingFunction; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000108")]
	private NodeData[] nodes; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000109")]
	private NodeData curNode; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400010A")]
	private int index; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400010B")]
	private int curAttrIndex; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400010C")]
	private int attrCount; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400010D")]
	private int attrHashtable; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400010E")]
	private int attrDuplWalkCount; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400010F")]
	private bool attrNeedNamespaceLookup; //Field offset: 0xCC
	[FieldOffset(Offset = "0xCD")]
	[Token(Token = "0x4000110")]
	private bool fullAttrCleanup; //Field offset: 0xCD
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000111")]
	private NodeData[] attrDuplSortingArray; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000112")]
	private XmlNameTable nameTable; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000113")]
	private bool nameTableFromSettings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000114")]
	private XmlResolver xmlResolver; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000115")]
	private string url; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000116")]
	private bool normalize; //Field offset: 0xF8
	[FieldOffset(Offset = "0xF9")]
	[Token(Token = "0x4000117")]
	private bool supportNamespaces; //Field offset: 0xF9
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000118")]
	private WhitespaceHandling whitespaceHandling; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000119")]
	private DtdProcessing dtdProcessing; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400011A")]
	private EntityHandling entityHandling; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400011B")]
	private bool ignorePIs; //Field offset: 0x108
	[FieldOffset(Offset = "0x109")]
	[Token(Token = "0x400011C")]
	private bool ignoreComments; //Field offset: 0x109
	[FieldOffset(Offset = "0x10A")]
	[Token(Token = "0x400011D")]
	private bool checkCharacters; //Field offset: 0x10A
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400011E")]
	private int lineNumberOffset; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400011F")]
	private int linePositionOffset; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000120")]
	private bool closeInput; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000121")]
	private long maxCharactersInDocument; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000122")]
	private long maxCharactersFromEntities; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000123")]
	private bool v1Compat; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000124")]
	private XmlNamespaceManager namespaceManager; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000125")]
	private string lastPrefix; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000126")]
	private XmlContext xmlContext; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000127")]
	private ParsingState[] parsingStatesStack; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000128")]
	private int parsingStatesStackTop; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000129")]
	private string reportedBaseUri; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400012A")]
	private Encoding reportedEncoding; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400012B")]
	private IDtdInfo dtdInfo; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400012C")]
	private XmlNodeType fragmentType; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400012D")]
	private XmlParserContext fragmentParserContext; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400012E")]
	private bool fragment; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400012F")]
	private IncrementalReadDecoder incReadDecoder; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000130")]
	private IncrementalReadState incReadState; //Field offset: 0x190
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000131")]
	private LineInfo incReadLineInfo; //Field offset: 0x194
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000132")]
	private int incReadDepth; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000133")]
	private int incReadLeftStartPos; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000134")]
	private int incReadLeftEndPos; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000135")]
	private int attributeValueBaseEntityId; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000136")]
	private bool emptyEntityInAttributeResolved; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000137")]
	private IValidationEventHandling validationEventHandling; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000138")]
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000139")]
	private bool validatingReaderCompatFlag; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C1")]
	[Token(Token = "0x400013A")]
	private bool addDefaultAttributesAndNormalize; //Field offset: 0x1C1
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400013B")]
	private StringBuilder stringBuilder; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400013C")]
	private bool rootElementParsed; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D1")]
	[Token(Token = "0x400013D")]
	private bool standalone; //Field offset: 0x1D1
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x400013E")]
	private int nextEntityId; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400013F")]
	private ParsingMode parsingMode; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000140")]
	private ReadState readState; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000141")]
	private IDtdEntityInfo lastEntity; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000142")]
	private bool afterResetState; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000143")]
	private int documentStartBytePos; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000144")]
	private int readValueOffset; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000145")]
	private long charactersInDocument; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000146")]
	private long charactersFromEntities; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000147")]
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000148")]
	private bool disableUndeclaredEntityCheck; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000149")]
	private XmlReader outerReader; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400014A")]
	private bool xmlResolverIsSet; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400014B")]
	private string Xml; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x400014C")]
	private string XmlNs; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x400014D")]
	private Task<Tuple`4<Int32, Int32, Int32, Boolean>> parseText_dummyTask; //Field offset: 0x238

	[Token(Token = "0x17000087")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000270")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008C")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000275")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000A7")]
	internal bool DisableUndeclaredEntityCheck
	{
		[Address(RVA = "0x16568F0", Offset = "0x1655AF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000339")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170000A5")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000334")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000097")]
	internal Uri DtdParserProxy_BaseUri
	{
		[Address(RVA = "0x1656380", Offset = "0x1655580", Length = "0xB1")]
		[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_BaseUri", ReturnType = typeof(Uri))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600028D")]
		internal get { } //Length: 177
	}

	[Token(Token = "0x1700009B")]
	internal int DtdParserProxy_CurrentPosition
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000291")]
		internal get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000292")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000093")]
	internal bool DtdParserProxy_DtdValidation
	{
		[Address(RVA = "0x1656440", Offset = "0x1655640", Length = "0xC")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000289")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x1700009C")]
	internal int DtdParserProxy_EntityStackLength
	{
		[Address(RVA = "0x1656450", Offset = "0x1655650", Length = "0x9")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000293")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700009D")]
	internal bool DtdParserProxy_IsEntityEolNormalized
	{
		[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000294")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000098")]
	internal bool DtdParserProxy_IsEof
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028E")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700009F")]
	internal int DtdParserProxy_LineNo
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000297")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000A0")]
	internal int DtdParserProxy_LineStartPosition
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000298")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000092")]
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000288")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000095")]
	internal bool DtdParserProxy_Namespaces
	{
		[Address(RVA = "0x1656460", Offset = "0x1655660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600028B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000091")]
	internal XmlNameTable DtdParserProxy_NameTable
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000287")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000094")]
	internal bool DtdParserProxy_Normalization
	{
		[Address(RVA = "0x1656470", Offset = "0x1655670", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000099")]
	internal Char[] DtdParserProxy_ParsingBuffer
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700009A")]
	internal int DtdParserProxy_ParsingBufferLength
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000290")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000096")]
	internal bool DtdParserProxy_V1CompatibilityMode
	{
		[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028C")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700009E")]
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
	{
		[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000295")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000A3")]
	private bool DtdValidation
	{
		[Address(RVA = "0x1656440", Offset = "0x1655640", Length = "0xC")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BC")]
		private get { } //Length: 12
	}

	[Token(Token = "0x1700008F")]
	internal EntityHandling EntityHandling
	{
		[Address(RVA = "0x1656900", Offset = "0x1655B00", Length = "0x85")]
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000285")]
		internal set { } //Length: 133
	}

	[Token(Token = "0x170000A2")]
	private bool InAttributeValueIterator
	{
		[Address(RVA = "0x1656480", Offset = "0x1655680", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002BA")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170000A4")]
	private bool InEntity
	{
		[Address(RVA = "0x16564A0", Offset = "0x16556A0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002EF")]
		private get { } //Length: 12
	}

	[Token(Token = "0x17000089")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x16564B0", Offset = "0x16556B0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "get_IsDefaultAttribute", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000272")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000088")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x16564E0", Offset = "0x16556E0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000271")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170000A1")]
	private bool IsResolverNull
	{
		[Address(RVA = "0x1656510", Offset = "0x1655710", Length = "0x3C")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600029E")]
		private get { } //Length: 60
	}

	[Token(Token = "0x17000083")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1656550", Offset = "0x1655750", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000082")]
	public virtual string Name
	{
		[Address(RVA = "0x1656570", Offset = "0x1655770", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026B")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700008E")]
	internal bool Namespaces
	{
		[Address(RVA = "0x1656990", Offset = "0x1655B90", Length = "0x248")]
		[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000284")]
		internal set { } //Length: 584
	}

	[Token(Token = "0x17000084")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x16565A0", Offset = "0x16557A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026D")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700008B")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000274")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000081")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x16565C0", Offset = "0x16557C0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026A")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700008D")]
	internal XmlReader OuterReader
	{
		[Address(RVA = "0x404440", Offset = "0x403640", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000280")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000085")]
	public virtual string Prefix
	{
		[Address(RVA = "0x16565E0", Offset = "0x16557E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026E")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700008A")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x1656600", Offset = "0x1655800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000273")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000080")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x1656610", Offset = "0x1655810", Length = "0x183")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000269")]
		 get { } //Length: 387
	}

	[Token(Token = "0x17000086")]
	public virtual string Value
	{
		[Address(RVA = "0x16567A0", Offset = "0x16559A0", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600026F")]
		 get { } //Length: 325
	}

	[Token(Token = "0x17000090")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0x1656BE0", Offset = "0x1655DE0", Length = "0xAD")]
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000286")]
		internal set { } //Length: 173
	}

	[Token(Token = "0x170000A6")]
	internal bool XmlValidatingReaderCompatibilityMode
	{
		[Address(RVA = "0x1656C90", Offset = "0x1655E90", Length = "0x50A")]
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181657100")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 9)]
		[Token(Token = "0x6000336")]
		internal set { } //Length: 1290
	}

	[Address(RVA = "0x1655DA0", Offset = "0x1654FA0", Length = "0x48B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlContext), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000261")]
	internal XmlTextReaderImpl(XmlNameTable nt) { }

	[Address(RVA = "0x1655B90", Offset = "0x1654D90", Length = "0x10C")]
	[CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000262")]
	internal XmlTextReaderImpl(TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x1655CA0", Offset = "0x1654EA0", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000263")]
	internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x1655A60", Offset = "0x1654C60", Length = "0x129")]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000264")]
	internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	[Address(RVA = "0x1656230", Offset = "0x1655430", Length = "0x140")]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000265")]
	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context) { }

	[Address(RVA = "0x1642FA0", Offset = "0x16421A0", Length = "0x20E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600030D")]
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	[Address(RVA = "0x16431B0", Offset = "0x16423B0", Length = "0x16B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600030E")]
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	[Address(RVA = "0x1642E90", Offset = "0x1642090", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002E2")]
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	[Address(RVA = "0x1642F10", Offset = "0x1642110", Length = "0x8C")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030C")]
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	[Address(RVA = "0x1643320", Offset = "0x1642520", Length = "0x595")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000337")]
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	[Address(RVA = "0x16438C0", Offset = "0x1642AC0", Length = "0x2BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000338")]
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	[Address(RVA = "0x1643B80", Offset = "0x1642D80", Length = "0x623")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180739630")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D7")]
	private void AddDefaultAttributesAndNormalize() { }

	[Address(RVA = "0x16441B0", Offset = "0x16433B0", Length = "0x266")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000313")]
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	[Address(RVA = "0x1644420", Offset = "0x1643620", Length = "0x1A4")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600030A")]
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	[Address(RVA = "0x16445D0", Offset = "0x16437D0", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600030B")]
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	[Address(RVA = "0x1644750", Offset = "0x1643950", Length = "0x423")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60002DD")]
	private void AttributeDuplCheck() { }

	[Address(RVA = "0x1644B80", Offset = "0x1643D80", Length = "0xC5")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002DC")]
	private void AttributeNamespaceLookup() { }

	[Address(RVA = "0x1644C70", Offset = "0x1643E70", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033E")]
	internal static void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

	[Address(RVA = "0x1644C50", Offset = "0x1643E50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033D")]
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	[Address(RVA = "0x1644C80", Offset = "0x1643E80", Length = "0x34E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60002CA")]
	private Encoding CheckEncoding(string newEncodingName) { }

	[Address(RVA = "0x1644FD0", Offset = "0x16441D0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60002D0")]
	internal void Close(bool closeInput) { }

	[Address(RVA = "0x16450C0", Offset = "0x16442C0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600027C")]
	public virtual void Close() { }

	[Address(RVA = "0x16451C0", Offset = "0x16443C0", Length = "0x1FB")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_3412", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Littleendian", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Bigendian", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_2143", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C7")]
	private Encoding DetectEncoding() { }

	[Address(RVA = "0x16453C0", Offset = "0x16445C0", Length = "0xA")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000296")]
	internal void DtdParserProxy_OnNewLine(int pos) { }

	[Address(RVA = "0x16453D0", Offset = "0x16445D0", Length = "0xE7")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A6")]
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	[Address(RVA = "0x16454C0", Offset = "0x16446C0", Length = "0xE7")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A5")]
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	[Address(RVA = "0x16455B0", Offset = "0x16447B0", Length = "0x3BF")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NodeData), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029D")]
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	[Address(RVA = "0x1645970", Offset = "0x1644B70", Length = "0x8")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Token(Token = "0x600029B")]
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x1645980", Offset = "0x1644B80", Length = "0xAC")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029A")]
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x1645A30", Offset = "0x1644C30", Length = "0x48")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600029C")]
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	[Address(RVA = "0x1645A80", Offset = "0x1644C80", Length = "0x71")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Token(Token = "0x60002A1")]
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	[Address(RVA = "0x1645B00", Offset = "0x1644D00", Length = "0xC8")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002A0")]
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	[Address(RVA = "0x1645BD0", Offset = "0x1644DD0", Length = "0x165")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A2")]
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	[Address(RVA = "0x1645D40", Offset = "0x1644F40", Length = "0x96")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002A3")]
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	[Address(RVA = "0x1645DE0", Offset = "0x1644FE0", Length = "0x7")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ReadData", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Token(Token = "0x6000299")]
	internal int DtdParserProxy_ReadData() { }

	[Address(RVA = "0x1645DF0", Offset = "0x1644FF0", Length = "0xC")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A4")]
	internal void DtdParserProxy_Throw(Exception e) { }

	[Address(RVA = "0x1645E00", Offset = "0x1645000", Length = "0x235")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Token(Token = "0x60002FF")]
	private int EatWhitespaces(StringBuilder sb) { }

	[Address(RVA = "0x1646040", Offset = "0x1645240", Length = "0x81")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002DB")]
	private void ElementNamespaceLookup() { }

	[Address(RVA = "0x16460D0", Offset = "0x16452D0", Length = "0x178")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToElement", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002BB")]
	private void FinishAttributeValueIterator() { }

	[Address(RVA = "0x1646250", Offset = "0x1645450", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000324")]
	private void FinishIncrementalRead() { }

	[Address(RVA = "0x16467F0", Offset = "0x16459F0", Length = "0x135")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600027A")]
	private void FinishInit() { }

	[Address(RVA = "0x16462E0", Offset = "0x16454E0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000267")]
	private void FinishInitStream() { }

	[Address(RVA = "0x16463C0", Offset = "0x16455C0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000268")]
	private void FinishInitTextReader() { }

	[Address(RVA = "0x1646460", Offset = "0x1645660", Length = "0x38B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000266")]
	private void FinishInitUriString() { }

	[Address(RVA = "0x1646930", Offset = "0x1645B30", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002E6")]
	private void FinishOtherValueIterator() { }

	[Address(RVA = "0x1646A60", Offset = "0x1645C60", Length = "0x130")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NodeData), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E5")]
	private void FinishPartialValue() { }

	[Address(RVA = "0x1646BA0", Offset = "0x1645DA0", Length = "0x118")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002E9")]
	private void FinishReadContentAsBinary() { }

	[Address(RVA = "0x1646D00", Offset = "0x1645F00", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EA")]
	private void FinishReadElementContentAsBinary() { }

	[Address(RVA = "0x1646DD0", Offset = "0x1645FD0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Token(Token = "0x60002E8")]
	private void FinishReadValueChunk() { }

	[Address(RVA = "0x1646E10", Offset = "0x1646010", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000315")]
	private void FullAttributeCleanup() { }

	[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000270")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x1656380", Offset = "0x1655580", Length = "0xB1")]
	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_BaseUri", ReturnType = typeof(Uri))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028D")]
	internal Uri get_DtdParserProxy_BaseUri() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000291")]
	internal int get_DtdParserProxy_CurrentPosition() { }

	[Address(RVA = "0x1656440", Offset = "0x1655640", Length = "0xC")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000289")]
	internal bool get_DtdParserProxy_DtdValidation() { }

	[Address(RVA = "0x1656450", Offset = "0x1655650", Length = "0x9")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000293")]
	internal int get_DtdParserProxy_EntityStackLength() { }

	[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000294")]
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028E")]
	internal bool get_DtdParserProxy_IsEof() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000297")]
	internal int get_DtdParserProxy_LineNo() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000298")]
	internal int get_DtdParserProxy_LineStartPosition() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000288")]
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	[Address(RVA = "0x1656460", Offset = "0x1655660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600028B")]
	internal bool get_DtdParserProxy_Namespaces() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000287")]
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	[Address(RVA = "0x1656470", Offset = "0x1655670", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028A")]
	internal bool get_DtdParserProxy_Normalization() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028F")]
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000290")]
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028C")]
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000295")]
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	[Address(RVA = "0x1656440", Offset = "0x1655640", Length = "0xC")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60002BC")]
	private bool get_DtdValidation() { }

	[Address(RVA = "0x1656480", Offset = "0x1655680", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002BA")]
	private bool get_InAttributeValueIterator() { }

	[Address(RVA = "0x16564A0", Offset = "0x16556A0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002EF")]
	private bool get_InEntity() { }

	[Address(RVA = "0x16564B0", Offset = "0x16556B0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_IsDefaultAttribute", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000272")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x16564E0", Offset = "0x16556E0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000271")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x1656510", Offset = "0x1655710", Length = "0x3C")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600029E")]
	private bool get_IsResolverNull() { }

	[Address(RVA = "0x1656550", Offset = "0x1655750", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026C")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x1656570", Offset = "0x1655770", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026B")]
	public virtual string get_Name() { }

	[Address(RVA = "0x16565A0", Offset = "0x16557A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026D")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000274")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x16565C0", Offset = "0x16557C0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026A")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x16565E0", Offset = "0x16557E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026E")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1656600", Offset = "0x1655800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000273")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x1656610", Offset = "0x1655810", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000269")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x16567A0", Offset = "0x16559A0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026F")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1646ED0", Offset = "0x16460D0", Length = "0xDC")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CE")]
	private int GetChars(int maxCharsCount) { }

	[Address(RVA = "0x16470A0", Offset = "0x16462A0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600032F")]
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	[Address(RVA = "0x1646FB0", Offset = "0x16461B0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000330")]
	private int GetIndexOfAttributeWithPrefix(string name) { }

	[Address(RVA = "0x16471B0", Offset = "0x16463B0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600029F")]
	private XmlResolver GetTempResolver() { }

	[Address(RVA = "0x1647210", Offset = "0x1646410", Length = "0x57")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000319")]
	private XmlNodeType GetTextNodeType(int orChars) { }

	[Address(RVA = "0x1647270", Offset = "0x1646470", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000318")]
	private XmlNodeType GetWhitespaceType() { }

	[Address(RVA = "0x16472C0", Offset = "0x16464C0", Length = "0x191")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F0")]
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	[Address(RVA = "0x1647460", Offset = "0x1646660", Length = "0x28B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002ED")]
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos) { }

	[Address(RVA = "0x16476F0", Offset = "0x16468F0", Length = "0x47D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ResolveEntity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_IsResolverNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EE")]
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	[Address(RVA = "0x1647B70", Offset = "0x1646D70", Length = "0xA40")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000323")]
	private int IncrementalRead() { }

	[Address(RVA = "0x16485E0", Offset = "0x16477E0", Length = "0x2B2")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C3")]
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	[Address(RVA = "0x1648B50", Offset = "0x1647D50", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002BD")]
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	[Address(RVA = "0x1648BD0", Offset = "0x1647DD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002BE")]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	[Address(RVA = "0x16488A0", Offset = "0x1647AA0", Length = "0x2A1")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlReader), Member = "CalcBufferSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002BF")]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	[Address(RVA = "0x1648C00", Offset = "0x1647E00", Length = "0x10D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C2")]
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	[Address(RVA = "0x1648D10", Offset = "0x1647F10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002C0")]
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	[Address(RVA = "0x1648D30", Offset = "0x1647F30", Length = "0xF3")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002C1")]
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	[Address(RVA = "0x1648E30", Offset = "0x1648030", Length = "0x16D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CF")]
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	[Address(RVA = "0x1648FA0", Offset = "0x16481A0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600027D")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x1648FE0", Offset = "0x16481E0", Length = "0xD9")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000312")]
	private string LookupNamespace(NodeData node) { }

	[Address(RVA = "0x16490C0", Offset = "0x16482C0", Length = "0x2D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000283")]
	internal string LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x16490F0", Offset = "0x16482F0", Length = "0x275")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000276")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x1649370", Offset = "0x1648570", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000279")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x1649400", Offset = "0x1648600", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000277")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x1649480", Offset = "0x1648680", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000278")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x1649520", Offset = "0x1648720", Length = "0x40")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000333")]
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	[Address(RVA = "0x1649630", Offset = "0x1648830", Length = "0x12E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002DE")]
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	[Address(RVA = "0x1649760", Offset = "0x1648960", Length = "0xCA")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000311")]
	private void OnEof() { }

	[Address(RVA = "0x1649830", Offset = "0x1648A30", Length = "0xE9")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DF")]
	private void OnNamespaceDecl(NodeData attr) { }

	[Address(RVA = "0x16453C0", Offset = "0x16445C0", Length = "0xA")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000310")]
	private void OnNewLine(int pos) { }

	[Address(RVA = "0x1649920", Offset = "0x1648B20", Length = "0x221")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60002E0")]
	private void OnXmlReservedAttribute(NodeData attr) { }

	[Address(RVA = "0x1649B50", Offset = "0x1648D50", Length = "0x294")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600031B")]
	private bool OpenAndPush(Uri uri) { }

	[Address(RVA = "0x1649F70", Offset = "0x1649170", Length = "0x31D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetErrorState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002C5")]
	private void OpenUrl() { }

	[Address(RVA = "0x1649DF0", Offset = "0x1648FF0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C6")]
	private void OpenUrlDelegate(object xmlResolver) { }

	[Address(RVA = "0x164B350", Offset = "0x164A550", Length = "0x666")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002DA")]
	private void ParseAttributes() { }

	[Address(RVA = "0x164A290", Offset = "0x1649490", Length = "0x5F6")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000326")]
	private bool ParseAttributeValueChunk() { }

	[Address(RVA = "0x164A890", Offset = "0x1649A90", Length = "0xA94")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002E1")]
	private void ParseAttributeValueSlow(int curPos, char quoteChar, NodeData attr) { }

	[Address(RVA = "0x164BFB0", Offset = "0x164B1B0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002F7")]
	private void ParseCData() { }

	[Address(RVA = "0x164B9C0", Offset = "0x164ABC0", Length = "0x421")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002F9")]
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	[Address(RVA = "0x164BDF0", Offset = "0x164AFF0", Length = "0x1BA")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCData", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F8")]
	private void ParseCDataOrComment(XmlNodeType type) { }

	[Address(RVA = "0x164BFC0", Offset = "0x164B1C0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000300")]
	private int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType) { }

	[Address(RVA = "0x164C040", Offset = "0x164B240", Length = "0x225")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F6")]
	private bool ParseComment() { }

	[Address(RVA = "0x164C270", Offset = "0x164B470", Length = "0x2C3")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002FA")]
	private bool ParseDoctypeDecl() { }

	[Address(RVA = "0x164C540", Offset = "0x164B740", Length = "0x58A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D3")]
	private bool ParseDocumentContent() { }

	[Address(RVA = "0x164CCD0", Offset = "0x164BED0", Length = "0x2A1")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002FB")]
	private void ParseDtd() { }

	[Address(RVA = "0x164CAD0", Offset = "0x164BCD0", Length = "0x1F6")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000332")]
	private void ParseDtdFromParserContext() { }

	[Address(RVA = "0x164D300", Offset = "0x164C500", Length = "0x52F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002D6")]
	private void ParseElement() { }

	[Address(RVA = "0x164CF80", Offset = "0x164C180", Length = "0x37F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D4")]
	private bool ParseElementContent() { }

	[Address(RVA = "0x164D830", Offset = "0x164CA30", Length = "0x3F2")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D8")]
	private void ParseEndElement() { }

	[Address(RVA = "0x164DC30", Offset = "0x164CE30", Length = "0xEC")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000309")]
	private string ParseEntityName() { }

	[Address(RVA = "0x164DD20", Offset = "0x164CF20", Length = "0x7C")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002EC")]
	private void ParseEntityReference() { }

	[Address(RVA = "0x164DDA0", Offset = "0x164CFA0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000325")]
	private bool ParseFragmentAttribute() { }

	[Address(RVA = "0x164DE40", Offset = "0x164D040", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000305")]
	private int ParseName() { }

	[Address(RVA = "0x164E180", Offset = "0x164D380", Length = "0x79")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Token(Token = "0x6000303")]
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x164DE70", Offset = "0x164D070", Length = "0x30E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000304")]
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x164E9B0", Offset = "0x164DBB0", Length = "0xC0")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000301")]
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	[Address(RVA = "0x164E200", Offset = "0x164D400", Length = "0x7A4")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "SplitSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char&), typeof(Char&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000302")]
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType) { }

	[Address(RVA = "0x164F200", Offset = "0x164E400", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002F3")]
	private bool ParsePI() { }

	[Address(RVA = "0x164EE00", Offset = "0x164E000", Length = "0x3FB")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F4")]
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	[Address(RVA = "0x164EA80", Offset = "0x164DC80", Length = "0x371")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002F5")]
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	[Address(RVA = "0x164F490", Offset = "0x164E690", Length = "0x1F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000306")]
	private int ParseQName(out int colonPos) { }

	[Address(RVA = "0x164F210", Offset = "0x164E410", Length = "0x27F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseName", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000307")]
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	[Address(RVA = "0x164F4B0", Offset = "0x164E6B0", Length = "0x231")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ZeroEndingStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EB")]
	private bool ParseRootLevelWhitespace() { }

	[Address(RVA = "0x164FB80", Offset = "0x164ED80", Length = "0x6E8")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001CD0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002E4")]
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	[Address(RVA = "0x164F6F0", Offset = "0x164E8F0", Length = "0x487")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetTextNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002E3")]
	private bool ParseText() { }

	[Address(RVA = "0x1650290", Offset = "0x164F490", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Token(Token = "0x600032C")]
	private string ParseUnexpectedToken(int pos) { }

	[Address(RVA = "0x16502A0", Offset = "0x164F4A0", Length = "0xEE")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlCharType), Member = "IsNCNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600032D")]
	private string ParseUnexpectedToken() { }

	[Address(RVA = "0x1650420", Offset = "0x164F620", Length = "0xFA7")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "UnDecodeChars", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002330")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60002D2")]
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	[Address(RVA = "0x1650390", Offset = "0x164F590", Length = "0x88")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000327")]
	private void ParseXmlDeclarationFragment() { }

	[Address(RVA = "0x16513D0", Offset = "0x16505D0", Length = "0x78")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030F")]
	private void PopElementContext() { }

	[Address(RVA = "0x1651450", Offset = "0x1650650", Length = "0x96")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031E")]
	private void PopEntity() { }

	[Address(RVA = "0x16514F0", Offset = "0x16506F0", Length = "0xC9")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000322")]
	private void PopParsingState() { }

	[Address(RVA = "0x16515C0", Offset = "0x16507C0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000317")]
	private void PopXmlContext() { }

	[Address(RVA = "0x1651610", Offset = "0x1650810", Length = "0x60")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002C4")]
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	[Address(RVA = "0x16519C0", Offset = "0x1650BC0", Length = "0x200")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031C")]
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x1651680", Offset = "0x1650880", Length = "0x332")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600031A")]
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	[Address(RVA = "0x1651BD0", Offset = "0x1650DD0", Length = "0x15D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600031D")]
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x1651D30", Offset = "0x1650F30", Length = "0x18E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParsingState), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000321")]
	private void PushParsingState() { }

	[Address(RVA = "0x1651EC0", Offset = "0x16510C0", Length = "0x8D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000316")]
	private void PushXmlContext() { }

	[Address(RVA = "0x1652820", Offset = "0x1651A20", Length = "0x774")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopElementContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ResetAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600027B")]
	public virtual bool Read() { }

	[Address(RVA = "0x1651FF0", Offset = "0x16511F0", Length = "0x35E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600027E")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x1652390", Offset = "0x1651590", Length = "0x48E")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "OnBufferInvalidated", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002CD")]
	private int ReadData() { }

	[Address(RVA = "0x1652350", Offset = "0x1651550", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000308")]
	private bool ReadDataInName(ref int pos) { }

	[Address(RVA = "0x1653000", Offset = "0x1652200", Length = "0x124")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033A")]
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	[Address(RVA = "0x1653130", Offset = "0x1652330", Length = "0x227")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A5650")]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600031F")]
	private void RegisterEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x1653360", Offset = "0x1652560", Length = "0xD9")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000314")]
	private void ResetAttributes() { }

	[Address(RVA = "0x1653440", Offset = "0x1652640", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600027F")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x1651F50", Offset = "0x1651150", Length = "0x9D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B2")]
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	[Address(RVA = "0x16536F0", Offset = "0x16528F0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B9")]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	[Address(RVA = "0x16537C0", Offset = "0x16529C0", Length = "0x13C")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B8")]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x16568F0", Offset = "0x1655AF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000339")]
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000292")]
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	[Address(RVA = "0x1656900", Offset = "0x1655B00", Length = "0x85")]
	[CalledBy(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000285")]
	internal void set_EntityHandling(EntityHandling value) { }

	[Address(RVA = "0x1656990", Offset = "0x1655B90", Length = "0x248")]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000284")]
	internal void set_Namespaces(bool value) { }

	[Address(RVA = "0x404440", Offset = "0x403640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000280")]
	internal void set_OuterReader(XmlReader value) { }

	[Address(RVA = "0x1656BE0", Offset = "0x1655DE0", Length = "0xAD")]
	[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000286")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x1656C90", Offset = "0x1655E90", Length = "0x50A")]
	[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181657100")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6000336")]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[Address(RVA = "0x1653900", Offset = "0x1652B00", Length = "0xB2")]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000335")]
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	[Address(RVA = "0x16539C0", Offset = "0x1652BC0", Length = "0x15")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60002B7")]
	private void SetErrorState() { }

	[Address(RVA = "0x16539E0", Offset = "0x1652BE0", Length = "0x188")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF16Decoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002C8")]
	private void SetupEncoding(Encoding encoding) { }

	[Address(RVA = "0x1653B70", Offset = "0x1652D70", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002F2")]
	private void SetupEndEntityNodeInAttribute() { }

	[Address(RVA = "0x1653C00", Offset = "0x1652E00", Length = "0x131")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F1")]
	private void SetupEndEntityNodeInContent() { }

	[Address(RVA = "0x1653D40", Offset = "0x1652F40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002D1")]
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	[Address(RVA = "0x1653D70", Offset = "0x1652F70", Length = "0x38B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002FC")]
	private void SkipDtd() { }

	[Address(RVA = "0x1654100", Offset = "0x1653300", Length = "0x5B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadValueChunk", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002E7")]
	private void SkipPartialTextValue() { }

	[Address(RVA = "0x1654160", Offset = "0x1653360", Length = "0x8F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002FD")]
	private void SkipPublicOrSystemIdLiteral() { }

	[Address(RVA = "0x16541F0", Offset = "0x16533F0", Length = "0x485")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002FE")]
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	[Address(RVA = "0x1654860", Offset = "0x1653A60", Length = "0x151")]
	[CalledBy(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600033C")]
	internal static void StripSpaces(Char[] value, int index, ref int len) { }

	[Address(RVA = "0x1654680", Offset = "0x1653880", Length = "0x1DA")]
	[CalledBy(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033B")]
	internal static string StripSpaces(string value) { }

	[Address(RVA = "0x1654A30", Offset = "0x1653C30", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002C9")]
	private void SwitchEncoding(Encoding newEncoding) { }

	[Address(RVA = "0x16549C0", Offset = "0x1653BC0", Length = "0x62")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002CC")]
	private void SwitchEncodingToUTF8() { }

	[Address(RVA = "0xC8CF40", Offset = "0xC8C140", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000281")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x16490C0", Offset = "0x16482C0", Length = "0x2D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000282")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x16555D0", Offset = "0x16547D0", Length = "0xA1")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002AC")]
	private void Throw(string res, string arg) { }

	[Address(RVA = "0x1655780", Offset = "0x1654980", Length = "0x8B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AD")]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x16554F0", Offset = "0x16546F0", Length = "0x9A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AB")]
	private void Throw(string res, int lineNo, int linePos) { }

	[Address(RVA = "0x1655750", Offset = "0x1654950", Length = "0x2D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Token(Token = "0x60002AA")]
	private void Throw(string res) { }

	[Address(RVA = "0x1655440", Offset = "0x1654640", Length = "0xA1")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002AE")]
	private void Throw(string res, String[] args) { }

	[Address(RVA = "0x1655590", Offset = "0x1654790", Length = "0x30")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A9")]
	private void Throw(int pos, string res) { }

	[Address(RVA = "0x1655810", Offset = "0x1654A10", Length = "0x1B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A8")]
	private void Throw(int pos, string res, String[] args) { }

	[Address(RVA = "0x1655680", Offset = "0x1654880", Length = "0xA3")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetErrorState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002B1")]
	private void Throw(Exception e) { }

	[Address(RVA = "0x1655730", Offset = "0x1654930", Length = "0x1B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A7")]
	private void Throw(int pos, string res, string arg) { }

	[Address(RVA = "0x1655830", Offset = "0x1654A30", Length = "0xA6")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002B0")]
	private void Throw(string res, String[] args, Exception innerException) { }

	[Address(RVA = "0x16553B0", Offset = "0x16545B0", Length = "0x85")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AF")]
	private void Throw(string res, string arg, Exception innerException) { }

	[Address(RVA = "0x1654BD0", Offset = "0x1653DD0", Length = "0x76")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600032E")]
	private void ThrowExpectingWhitespace(int pos) { }

	[Address(RVA = "0x1654C50", Offset = "0x1653E50", Length = "0x69")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B6")]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[Address(RVA = "0x1654CC0", Offset = "0x1653EC0", Length = "0x1C4")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Token(Token = "0x60002D9")]
	private void ThrowTagMismatch(NodeData startTag) { }

	[Address(RVA = "0x1654E90", Offset = "0x1654090", Length = "0x1DA")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B30")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Token(Token = "0x60002D5")]
	private void ThrowUnclosedElements() { }

	[Address(RVA = "0x1655090", Offset = "0x1654290", Length = "0xF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000329")]
	private void ThrowUnexpectedToken(string expectedToken1) { }

	[Address(RVA = "0x16550A0", Offset = "0x16542A0", Length = "0x15")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000328")]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[Address(RVA = "0x16550C0", Offset = "0x16542C0", Length = "0x14F")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600032B")]
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x1655070", Offset = "0x1654270", Length = "0x1B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600032A")]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x1655210", Offset = "0x1654410", Length = "0x7A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B4")]
	private void ThrowWithoutLineInfo(string res, string arg) { }

	[Address(RVA = "0x1655320", Offset = "0x1654520", Length = "0x86")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B3")]
	private void ThrowWithoutLineInfo(string res) { }

	[Address(RVA = "0x1655290", Offset = "0x1654490", Length = "0x86")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B5")]
	private void ThrowWithoutLineInfo(string res, String[] args, Exception innerException) { }

	[Address(RVA = "0x16558E0", Offset = "0x1654AE0", Length = "0xAB")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CB")]
	private void UnDecodeChars() { }

	[Address(RVA = "0x1655990", Offset = "0x1654B90", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000320")]
	private void UnregisterEntity() { }

	[Address(RVA = "0x16559F0", Offset = "0x1654BF0", Length = "0x68")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000331")]
	private bool ZeroEndingStream(int pos) { }

}

