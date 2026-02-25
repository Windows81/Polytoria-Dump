namespace UnityEngine.UIElements;

[Token(Token = "0x2000025")]
public class ConverterGroup
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000050")]
	private readonly string <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000051")]
	private readonly string <displayName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000052")]
	private readonly string <description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000053")]
	private readonly TypeConverterRegistry <registry>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700002A")]
	internal TypeConverterRegistry registry
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1A97520", Offset = "0x1A96720", Length = "0x140")]
	[CalledBy(Type = typeof(ConverterGroups), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "get_sourceToUiConverters", ReturnType = typeof(ConverterGroup))]
	[CalledBy(Type = typeof(DataBinding), Member = "get_uiToSourceConverters", ReturnType = typeof(ConverterGroup))]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B9")]
	public ConverterGroup(string id, string displayName = null, string description = null) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	internal TypeConverterRegistry get_registry() { }

	[Address(RVA = "0x68A690", Offset = "0x689890", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TypeConverterRegistry), Member = "TryGetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Delegate&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BA")]
	public bool TryConvert(ref TSource source, out TDestination destination) { }

	[Address(RVA = "0x68AB70", Offset = "0x689D70", Length = "0x27A")]
	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180689050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BB")]
	public bool TrySetValue(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode) { }

}

