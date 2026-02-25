namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000059")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct ConversionRegistry : IEqualityComparer<ConversionRegistry>
{
	[IsReadOnly]
	[Token(Token = "0x200005B")]
	private struct ConverterKey
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000082")]
		public readonly Type SourceType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000083")]
		public readonly Type DestinationType; //Field offset: 0x8

		[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
		[CallerCount(Count = 48)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000156")]
		public ConverterKey(Type source, Type destination) { }

	}

	[Token(Token = "0x200005A")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000155")]
		public ConverterKeyComparer() { }

		[Address(RVA = "0x19F5830", Offset = "0x19F4A30", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000153")]
		public override bool Equals(ConverterKey x, ConverterKey y) { }

		[Address(RVA = "0x19F58B0", Offset = "0x19F4AB0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000154")]
		public override int GetHashCode(ConverterKey obj) { }

	}

	[Token(Token = "0x4000080")]
	private static readonly ConverterKeyComparer Comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000081")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters; //Field offset: 0x0

	[Address(RVA = "0x19F57B0", Offset = "0x19F49B0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000152")]
	private static ConversionRegistry() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600014B")]
	private ConversionRegistry(Dictionary<ConverterKey, Delegate> storage) { }

	[Address(RVA = "0x19F5470", Offset = "0x19F4670", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<Unity.Properties.ConversionRegistry+ConverterKey>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600014C")]
	public static ConversionRegistry Create() { }

	[Address(RVA = "0x19F5520", Offset = "0x19F4720", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	public override bool Equals(ConversionRegistry x, ConversionRegistry y) { }

	[Address(RVA = "0x19F5530", Offset = "0x19F4730", Length = "0xB9")]
	[CalledBy(Type = typeof(ConversionRegistry), Member = "TryGetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Delegate&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600014E")]
	public Delegate GetConverter(Type source, Type destination) { }

	[Address(RVA = "0x19F55F0", Offset = "0x19F47F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000151")]
	public override int GetHashCode(ConversionRegistry obj) { }

	[Address(RVA = "0x19F5620", Offset = "0x19F4820", Length = "0xFF")]
	[CalledBy(Type = typeof(TypeConversion), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600014D")]
	public void Register(Type source, Type destination, Delegate converter) { }

	[Address(RVA = "0x19F5720", Offset = "0x19F4920", Length = "0x8C")]
	[CalledBy(Type = typeof(TypeConversion), Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeConversion), Member = "TryConvertToUnityEngineObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConversionRegistry), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014F")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

}

