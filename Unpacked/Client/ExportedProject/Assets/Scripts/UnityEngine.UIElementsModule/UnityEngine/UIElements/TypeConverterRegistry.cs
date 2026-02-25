namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000026")]
internal struct TypeConverterRegistry : IEqualityComparer<TypeConverterRegistry>
{
	[IsReadOnly]
	[Token(Token = "0x2000028")]
	private struct ConverterKey
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000056")]
		public readonly Type SourceType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000057")]
		public readonly Type DestinationType; //Field offset: 0x8

		[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
		[CallerCount(Count = 48)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		public ConverterKey(Type source, Type destination) { }

	}

	[Token(Token = "0x2000027")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		public ConverterKeyComparer() { }

		[Address(RVA = "0x19F5830", Offset = "0x19F4A30", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C5")]
		public override bool Equals(ConverterKey x, ConverterKey y) { }

		[Address(RVA = "0x19F58B0", Offset = "0x19F4AB0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C6")]
		public override int GetHashCode(ConverterKey obj) { }

	}

	[Token(Token = "0x4000054")]
	private static readonly ConverterKeyComparer k_Comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000055")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters; //Field offset: 0x0

	[Address(RVA = "0x1AB6660", Offset = "0x1AB5860", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	private static TypeConverterRegistry() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BC")]
	private TypeConverterRegistry(Dictionary<ConverterKey, Delegate> storage) { }

	[Address(RVA = "0x1AB6110", Offset = "0x1AB5310", Length = "0x24D")]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000BF")]
	internal void Apply(TypeConverterRegistry registry) { }

	[Address(RVA = "0x1AB6360", Offset = "0x1AB5560", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000BD")]
	public static TypeConverterRegistry Create() { }

	[Address(RVA = "0x19F5520", Offset = "0x19F4720", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public override bool Equals(TypeConverterRegistry x, TypeConverterRegistry y) { }

	[Address(RVA = "0x1AB6410", Offset = "0x1AB5610", Length = "0xB9")]
	[CalledBy(Type = typeof(TypeConverterRegistry), Member = "TryGetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Delegate&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C0")]
	public Delegate GetConverter(Type source, Type destination) { }

	[Address(RVA = "0x19F55F0", Offset = "0x19F47F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	public override int GetHashCode(TypeConverterRegistry obj) { }

	[Address(RVA = "0x1AB64D0", Offset = "0x1AB56D0", Length = "0xFF")]
	[CalledBy(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BE")]
	public void Register(Type source, Type destination, Delegate converter) { }

	[Address(RVA = "0x1AB65D0", Offset = "0x1AB57D0", Length = "0x8C")]
	[CalledBy(Type = typeof(ConverterGroup), Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConverterGroups), Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeConverterRegistry), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C1")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

}

