namespace System.Xml.Schema;

[Token(Token = "0x20000E8")]
internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	[Token(Token = "0x20000E9")]
	private class SchemaDatatypeMap : IComparable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400051E")]
		private string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400051F")]
		private DatatypeImplementation type; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000520")]
		private int parentIndex; //Field offset: 0x20

		[Token(Token = "0x17000219")]
		public string Name
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000901")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700021A")]
		public int ParentIndex
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000902")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FE")]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type) { }

		[Address(RVA = "0x1139D30", Offset = "0x1138F30", Length = "0x5F")]
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FF")]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex) { }

		[Address(RVA = "0x16B1120", Offset = "0x16B0320", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000903")]
		public override int CompareTo(object obj) { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000901")]
		public string get_Name() { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000902")]
		public int get_ParentIndex() { }

		[Address(RVA = "0xE66C30", Offset = "0xE65E30", Length = "0x17")]
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000900")]
		public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	}

	[Token(Token = "0x40004CA")]
	private static Hashtable builtinTypes; //Field offset: 0x0
	[Token(Token = "0x40004CB")]
	private static XmlSchemaSimpleType[] enumToTypeCode; //Field offset: 0x8
	[Token(Token = "0x40004CC")]
	private static XmlSchemaSimpleType anySimpleType; //Field offset: 0x10
	[Token(Token = "0x40004CD")]
	private static XmlSchemaSimpleType anyAtomicType; //Field offset: 0x18
	[Token(Token = "0x40004CE")]
	private static XmlSchemaSimpleType untypedAtomicType; //Field offset: 0x20
	[Token(Token = "0x40004CF")]
	private static XmlSchemaSimpleType yearMonthDurationType; //Field offset: 0x28
	[Token(Token = "0x40004D0")]
	private static XmlSchemaSimpleType dayTimeDurationType; //Field offset: 0x30
	[Token(Token = "0x40004D1")]
	internal static XmlQualifiedName QnAnySimpleType; //Field offset: 0x38
	[Token(Token = "0x40004D2")]
	internal static XmlQualifiedName QnAnyType; //Field offset: 0x40
	[Token(Token = "0x40004D3")]
	internal static FacetsChecker stringFacetsChecker; //Field offset: 0x48
	[Token(Token = "0x40004D4")]
	internal static FacetsChecker miscFacetsChecker; //Field offset: 0x50
	[Token(Token = "0x40004D5")]
	internal static FacetsChecker numeric2FacetsChecker; //Field offset: 0x58
	[Token(Token = "0x40004D6")]
	internal static FacetsChecker binaryFacetsChecker; //Field offset: 0x60
	[Token(Token = "0x40004D7")]
	internal static FacetsChecker dateTimeFacetsChecker; //Field offset: 0x68
	[Token(Token = "0x40004D8")]
	internal static FacetsChecker durationFacetsChecker; //Field offset: 0x70
	[Token(Token = "0x40004D9")]
	internal static FacetsChecker listFacetsChecker; //Field offset: 0x78
	[Token(Token = "0x40004DA")]
	internal static FacetsChecker qnameFacetsChecker; //Field offset: 0x80
	[Token(Token = "0x40004DB")]
	internal static FacetsChecker unionFacetsChecker; //Field offset: 0x88
	[Token(Token = "0x40004DC")]
	private static readonly DatatypeImplementation c_anySimpleType; //Field offset: 0x90
	[Token(Token = "0x40004DD")]
	private static readonly DatatypeImplementation c_anyURI; //Field offset: 0x98
	[Token(Token = "0x40004DE")]
	private static readonly DatatypeImplementation c_base64Binary; //Field offset: 0xA0
	[Token(Token = "0x40004DF")]
	private static readonly DatatypeImplementation c_boolean; //Field offset: 0xA8
	[Token(Token = "0x40004E0")]
	private static readonly DatatypeImplementation c_byte; //Field offset: 0xB0
	[Token(Token = "0x40004E1")]
	private static readonly DatatypeImplementation c_char; //Field offset: 0xB8
	[Token(Token = "0x40004E2")]
	private static readonly DatatypeImplementation c_date; //Field offset: 0xC0
	[Token(Token = "0x40004E3")]
	private static readonly DatatypeImplementation c_dateTime; //Field offset: 0xC8
	[Token(Token = "0x40004E4")]
	private static readonly DatatypeImplementation c_dateTimeNoTz; //Field offset: 0xD0
	[Token(Token = "0x40004E5")]
	private static readonly DatatypeImplementation c_dateTimeTz; //Field offset: 0xD8
	[Token(Token = "0x40004E6")]
	private static readonly DatatypeImplementation c_day; //Field offset: 0xE0
	[Token(Token = "0x40004E7")]
	private static readonly DatatypeImplementation c_decimal; //Field offset: 0xE8
	[Token(Token = "0x40004E8")]
	private static readonly DatatypeImplementation c_double; //Field offset: 0xF0
	[Token(Token = "0x40004E9")]
	private static readonly DatatypeImplementation c_doubleXdr; //Field offset: 0xF8
	[Token(Token = "0x40004EA")]
	private static readonly DatatypeImplementation c_duration; //Field offset: 0x100
	[Token(Token = "0x40004EB")]
	private static readonly DatatypeImplementation c_ENTITY; //Field offset: 0x108
	[Token(Token = "0x40004EC")]
	private static readonly DatatypeImplementation c_ENTITIES; //Field offset: 0x110
	[Token(Token = "0x40004ED")]
	private static readonly DatatypeImplementation c_ENUMERATION; //Field offset: 0x118
	[Token(Token = "0x40004EE")]
	private static readonly DatatypeImplementation c_fixed; //Field offset: 0x120
	[Token(Token = "0x40004EF")]
	private static readonly DatatypeImplementation c_float; //Field offset: 0x128
	[Token(Token = "0x40004F0")]
	private static readonly DatatypeImplementation c_floatXdr; //Field offset: 0x130
	[Token(Token = "0x40004F1")]
	private static readonly DatatypeImplementation c_hexBinary; //Field offset: 0x138
	[Token(Token = "0x40004F2")]
	private static readonly DatatypeImplementation c_ID; //Field offset: 0x140
	[Token(Token = "0x40004F3")]
	private static readonly DatatypeImplementation c_IDREF; //Field offset: 0x148
	[Token(Token = "0x40004F4")]
	private static readonly DatatypeImplementation c_IDREFS; //Field offset: 0x150
	[Token(Token = "0x40004F5")]
	private static readonly DatatypeImplementation c_int; //Field offset: 0x158
	[Token(Token = "0x40004F6")]
	private static readonly DatatypeImplementation c_integer; //Field offset: 0x160
	[Token(Token = "0x40004F7")]
	private static readonly DatatypeImplementation c_language; //Field offset: 0x168
	[Token(Token = "0x40004F8")]
	private static readonly DatatypeImplementation c_long; //Field offset: 0x170
	[Token(Token = "0x40004F9")]
	private static readonly DatatypeImplementation c_month; //Field offset: 0x178
	[Token(Token = "0x40004FA")]
	private static readonly DatatypeImplementation c_monthDay; //Field offset: 0x180
	[Token(Token = "0x40004FB")]
	private static readonly DatatypeImplementation c_Name; //Field offset: 0x188
	[Token(Token = "0x40004FC")]
	private static readonly DatatypeImplementation c_NCName; //Field offset: 0x190
	[Token(Token = "0x40004FD")]
	private static readonly DatatypeImplementation c_negativeInteger; //Field offset: 0x198
	[Token(Token = "0x40004FE")]
	private static readonly DatatypeImplementation c_NMTOKEN; //Field offset: 0x1A0
	[Token(Token = "0x40004FF")]
	private static readonly DatatypeImplementation c_NMTOKENS; //Field offset: 0x1A8
	[Token(Token = "0x4000500")]
	private static readonly DatatypeImplementation c_nonNegativeInteger; //Field offset: 0x1B0
	[Token(Token = "0x4000501")]
	private static readonly DatatypeImplementation c_nonPositiveInteger; //Field offset: 0x1B8
	[Token(Token = "0x4000502")]
	private static readonly DatatypeImplementation c_normalizedString; //Field offset: 0x1C0
	[Token(Token = "0x4000503")]
	private static readonly DatatypeImplementation c_NOTATION; //Field offset: 0x1C8
	[Token(Token = "0x4000504")]
	private static readonly DatatypeImplementation c_positiveInteger; //Field offset: 0x1D0
	[Token(Token = "0x4000505")]
	private static readonly DatatypeImplementation c_QName; //Field offset: 0x1D8
	[Token(Token = "0x4000506")]
	private static readonly DatatypeImplementation c_QNameXdr; //Field offset: 0x1E0
	[Token(Token = "0x4000507")]
	private static readonly DatatypeImplementation c_short; //Field offset: 0x1E8
	[Token(Token = "0x4000508")]
	private static readonly DatatypeImplementation c_string; //Field offset: 0x1F0
	[Token(Token = "0x4000509")]
	private static readonly DatatypeImplementation c_time; //Field offset: 0x1F8
	[Token(Token = "0x400050A")]
	private static readonly DatatypeImplementation c_timeNoTz; //Field offset: 0x200
	[Token(Token = "0x400050B")]
	private static readonly DatatypeImplementation c_timeTz; //Field offset: 0x208
	[Token(Token = "0x400050C")]
	private static readonly DatatypeImplementation c_token; //Field offset: 0x210
	[Token(Token = "0x400050D")]
	private static readonly DatatypeImplementation c_unsignedByte; //Field offset: 0x218
	[Token(Token = "0x400050E")]
	private static readonly DatatypeImplementation c_unsignedInt; //Field offset: 0x220
	[Token(Token = "0x400050F")]
	private static readonly DatatypeImplementation c_unsignedLong; //Field offset: 0x228
	[Token(Token = "0x4000510")]
	private static readonly DatatypeImplementation c_unsignedShort; //Field offset: 0x230
	[Token(Token = "0x4000511")]
	private static readonly DatatypeImplementation c_uuid; //Field offset: 0x238
	[Token(Token = "0x4000512")]
	private static readonly DatatypeImplementation c_year; //Field offset: 0x240
	[Token(Token = "0x4000513")]
	private static readonly DatatypeImplementation c_yearMonth; //Field offset: 0x248
	[Token(Token = "0x4000514")]
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; //Field offset: 0x250
	[Token(Token = "0x4000515")]
	internal static readonly DatatypeImplementation c_tokenV1Compat; //Field offset: 0x258
	[Token(Token = "0x4000516")]
	private static readonly DatatypeImplementation c_anyAtomicType; //Field offset: 0x260
	[Token(Token = "0x4000517")]
	private static readonly DatatypeImplementation c_dayTimeDuration; //Field offset: 0x268
	[Token(Token = "0x4000518")]
	private static readonly DatatypeImplementation c_untypedAtomicType; //Field offset: 0x270
	[Token(Token = "0x4000519")]
	private static readonly DatatypeImplementation c_yearMonthDuration; //Field offset: 0x278
	[Token(Token = "0x400051A")]
	private static readonly DatatypeImplementation[] c_tokenizedTypes; //Field offset: 0x280
	[Token(Token = "0x400051B")]
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; //Field offset: 0x288
	[Token(Token = "0x400051C")]
	private static readonly SchemaDatatypeMap[] c_XdrTypes; //Field offset: 0x290
	[Token(Token = "0x400051D")]
	private static readonly SchemaDatatypeMap[] c_XsdTypes; //Field offset: 0x298
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C5")]
	private XmlSchemaDatatypeVariety variety; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004C6")]
	private RestrictionFacets restriction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C7")]
	private DatatypeImplementation baseType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C8")]
	private XmlValueConverter valueConverter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C9")]
	private XmlSchemaType parentSchemaType; //Field offset: 0x30

	[Token(Token = "0x1700020E")]
	internal static XmlSchemaSimpleType AnySimpleType
	{
		[Address(RVA = "0x16A0C60", Offset = "0x169FE60", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60008E6")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000218")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F9")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000210")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A0CB0", Offset = "0x169FEB0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60008F1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000217")]
	internal abstract Type ListValueType
	{
		[Token(Token = "0x60008F8")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000216")]
	internal virtual RestrictionFacets Restriction
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F7")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000212")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000215")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700020F")]
	internal static XmlSchemaSimpleType UntypedAtomicType
	{
		[Address(RVA = "0x16A0D00", Offset = "0x169FF00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60008E7")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000211")]
	internal virtual XmlValueConverter ValueConverter
	{
		[Address(RVA = "0x16A0D50", Offset = "0x169FF50", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008F2")]
		internal get { } //Length: 75
	}

	[Token(Token = "0x17000213")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A0DA0", Offset = "0x169FFA0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60008F4")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000214")]
	public virtual XmlSchemaDatatypeVariety Variety
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F5")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x169A950", Offset = "0x1699B50", Length = "0x630A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Datatype_anyAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_float), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "DeriveByList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSchemaType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_double), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 104)]
	[Token(Token = "0x60008E5")]
	private static DatatypeImplementation() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FD")]
	protected DatatypeImplementation() { }

	[Address(RVA = "0x1698F30", Offset = "0x1698130", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008FC")]
	protected int Compare(Byte[] value1, Byte[] value2) { }

	[Address(RVA = "0x1698FC0", Offset = "0x16981C0", Length = "0xE99")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60008EC")]
	internal static void CreateBuiltinTypes() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F0")]
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x1699E60", Offset = "0x1699060", Length = "0x2F7")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008EE")]
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	[Address(RVA = "0x169A160", Offset = "0x1699360", Length = "0x274")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60008EB")]
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	[Address(RVA = "0x169A3E0", Offset = "0x16995E0", Length = "0xC2")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object), typeof(IComparer)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E9")]
	private static DatatypeImplementation FromTypeName(string name) { }

	[Address(RVA = "0x169A4B0", Offset = "0x16996B0", Length = "0x72")]
	[CalledBy(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E8")]
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	[Address(RVA = "0x16A0C60", Offset = "0x169FE60", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60008E6")]
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F9")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A0CB0", Offset = "0x169FEB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60008F1")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Token(Token = "0x60008F8")]
	internal abstract Type get_ListValueType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F7")]
	internal virtual RestrictionFacets get_Restriction() { }

	[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F3")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F6")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A0D00", Offset = "0x169FF00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60008E7")]
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	[Address(RVA = "0x16A0D50", Offset = "0x169FF50", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008F2")]
	internal virtual XmlValueConverter get_ValueConverter() { }

	[Address(RVA = "0x16A0DA0", Offset = "0x169FFA0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x60008F4")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F5")]
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	[Address(RVA = "0x169A530", Offset = "0x1699730", Length = "0x6F")]
	[CalledBy(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008ED")]
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	[Address(RVA = "0x169A5A0", Offset = "0x16997A0", Length = "0x8D")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008FB")]
	internal string GetTypeName() { }

	[Address(RVA = "0x169A630", Offset = "0x1699830", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008EF")]
	internal virtual bool IsEqual(object o1, object o2) { }

	[Address(RVA = "0x169A660", Offset = "0x1699860", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008FA")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x169A870", Offset = "0x1699A70", Length = "0xDB")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaSimpleType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008EA")]
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

}

