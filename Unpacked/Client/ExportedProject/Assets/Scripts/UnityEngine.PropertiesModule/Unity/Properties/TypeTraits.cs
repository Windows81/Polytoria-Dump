namespace Unity.Properties;

[Token(Token = "0x2000060")]
public static class TypeTraits
{

	[Address(RVA = "0x1A146A0", Offset = "0x1A138A0", Length = "0x114")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeTraits`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	public static bool IsContainer(Type type) { }

}

