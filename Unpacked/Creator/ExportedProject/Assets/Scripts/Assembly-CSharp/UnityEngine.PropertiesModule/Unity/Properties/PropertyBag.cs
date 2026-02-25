namespace Unity.Properties;

[Token(Token = "0x2000040")]
public static class PropertyBag
{

	[Address(RVA = "0x72E860", Offset = "0x72DA60", Length = "0x24E")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyBag`1), Member = "Unity.Properties.IPropertyBag.Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	public static void AcceptWithSpecializedVisitor(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container) { }

	[Address(RVA = "0x1A0EBC0", Offset = "0x1A0DDC0", Length = "0x49")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Token(Token = "0x60000F3")]
	public static IPropertyBag GetPropertyBag(Type type) { }

	[Address(RVA = "0x7377A0", Offset = "0x7369A0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F4")]
	public static IPropertyBag<TContainer> GetPropertyBag() { }

	[Address(RVA = "0x737C70", Offset = "0x736E70", Length = "0x61")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsInitialization", Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertiesInitialization), Member = "InitializeProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 49)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F0")]
	public static void Register(PropertyBag<TContainer> propertyBag) { }

	[Address(RVA = "0x7379F0", Offset = "0x736BF0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F1")]
	public static void RegisterList() { }

	[Address(RVA = "0x737BA0", Offset = "0x736DA0", Length = "0xCD")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsInitialization", Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public static void RegisterList() { }

	[Address(RVA = "0x738940", Offset = "0x737B40", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F5")]
	public static bool TryGetPropertyBagForValue(ref TValue value, out IPropertyBag propertyBag) { }

}

