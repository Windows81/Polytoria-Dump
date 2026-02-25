namespace System.ComponentModel;

[ComVisible(True)]
[Token(Token = "0x200018A")]
public class TypeConverter
{
	[DefaultMember("Item")]
	[Token(Token = "0x200018B")]
	internal class StandardValuesCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000646")]
		private ICollection values; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000647")]
		private Array valueArray; //Field offset: 0x18

		[Token(Token = "0x170001C8")]
		public int Count
		{
			[Address(RVA = "0x17A9630", Offset = "0x17A8830", Length = "0x65")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600098A")]
			 get { } //Length: 101
		}

		[Token(Token = "0x170001C9")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x17A9630", Offset = "0x17A8830", Length = "0x65")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600098D")]
			private get { } //Length: 101
		}

		[Token(Token = "0x170001CA")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x600098E")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x17A96A0", Offset = "0x17A88A0", Length = "0xAB")]
		[CalledBy(Type = typeof(BooleanConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000989")]
		public StandardValuesCollection(ICollection values) { }

		[Address(RVA = "0x17A9570", Offset = "0x17A8770", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098B")]
		public void CopyTo(Array array, int index) { }

		[Address(RVA = "0x17A9630", Offset = "0x17A8830", Length = "0x65")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600098A")]
		public int get_Count() { }

		[Address(RVA = "0x17A95E0", Offset = "0x17A87E0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098C")]
		public IEnumerator GetEnumerator() { }

		[Address(RVA = "0x17A9570", Offset = "0x17A8770", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098F")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x17A9630", Offset = "0x17A8830", Length = "0x65")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600098D")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600098E")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x17A95E0", Offset = "0x17A87E0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000990")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x4000644")]
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior"; //Field offset: 0x0
	[Token(Token = "0x4000645")]
	private static bool useCompatibleTypeConversion; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000988")]
	public TypeConverter() { }

	[Address(RVA = "0x17A9F00", Offset = "0x17A9100", Length = "0x6D")]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BooleanConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NullableConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600097C")]
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x17A9F70", Offset = "0x17A9170", Length = "0x4C")]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600097D")]
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x17A9FC0", Offset = "0x17A91C0", Length = "0x65")]
	[CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BooleanConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CharConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeConverter), Member = "GetConvertFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Token(Token = "0x600097E")]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x174A280", Offset = "0x1749480", Length = "0x19")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600097F")]
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	[Address(RVA = "0x17AA2C0", Offset = "0x17A94C0", Length = "0x20E")]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CharConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NullableConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CollectionConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TypeConverter), Member = "GetConvertToException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000980")]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x17AA030", Offset = "0x17A9230", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000981")]
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0x17AA120", Offset = "0x17A9320", Length = "0xDC")]
	[CalledBy(Type = "System.ComponentModel.ReferenceConverter+ReferenceComparer", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000982")]
	public string ConvertToString(object value) { }

	[Address(RVA = "0x17AA200", Offset = "0x17A9400", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000983")]
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x17AA4D0", Offset = "0x17A96D0", Length = "0x141")]
	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NullableConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(StringConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000984")]
	protected Exception GetConvertFromException(object value) { }

	[Address(RVA = "0x17AA620", Offset = "0x17A9820", Length = "0x185")]
	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000985")]
	protected Exception GetConvertToException(object value, Type destinationType) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000986")]
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000987")]
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

