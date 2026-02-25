namespace Unity.Properties.Internal;

[Token(Token = "0x200009E")]
internal static class PropertyBagStore
{
	[Token(Token = "0x200009F")]
	public struct TypedStore
	{
		[Token(Token = "0x4000160")]
		public static IPropertyBag<TContainer> PropertyBag; //Field offset: 0x0

	}

	[Token(Token = "0x400015D")]
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; //Field offset: 0x0
	[Token(Token = "0x400015E")]
	private static readonly List<Type> s_RegisteredTypes; //Field offset: 0x8
	[Token(Token = "0x400015F")]
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; //Field offset: 0x10

	[Token(Token = "0x17000095")]
	private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider
	{
		[Address(RVA = "0x1A0EAF0", Offset = "0x1A0DCF0", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000321")]
		private get { } //Length: 199
	}

	[Address(RVA = "0x1A0E9D0", Offset = "0x1A0DBD0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000327")]
	private static PropertyBagStore() { }

	[Address(RVA = "0x72EAB0", Offset = "0x72DCB0", Length = "0x5A2")]
	[CalledBy(Type = typeof(PropertyBag), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.PropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag`1), Member = "Unity.Properties.Internal.IPropertyBagRegister.Register", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000323")]
	internal static void AddPropertyBag(IPropertyBag<TContainer> propertyBag) { }

	[Address(RVA = "0x1A0E470", Offset = "0x1A0D670", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000322")]
	internal static void CreatePropertyBagProvider() { }

	[Address(RVA = "0x1A0EAF0", Offset = "0x1A0DCF0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000321")]
	private static ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider() { }

	[Address(RVA = "0x72FBC0", Offset = "0x72EDC0", Length = "0x147")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000324")]
	internal static IPropertyBag<TContainer> GetPropertyBag() { }

	[Address(RVA = "0x1A0E500", Offset = "0x1A0D700", Length = "0x4C0")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[CalledBy(Type = typeof(TypeUtility), Member = "CreateTypeConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.TypeUtility+ITypeConstructor")]
	[CalledBy(Type = typeof(TypeUtility), Member = "InstantiateArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArray"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = "TArray")]
	[CalledBy(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = "Unity.Properties.IPropertyBag`1<TContainer>")]
	[CalledBy(Type = typeof(PropertyBagStore), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000325")]
	internal static IPropertyBag GetPropertyBag(Type type) { }

	[Address(RVA = "0x735790", Offset = "0x734990", Length = "0x3E1")]
	[CalledBy(Type = typeof(PropertyBag), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.StyleEnum`1<System.Int32Enum>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.StyleEnum`1<System.Int32Enum>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C9F0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000326")]
	internal static bool TryGetPropertyBagForValue(ref TValue value, out IPropertyBag propertyBag) { }

}

