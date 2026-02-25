namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Activator))]
[ComVisible(True)]
[Token(Token = "0x200017A")]
public sealed class Activator
{

	[Address(RVA = "0x14CF210", Offset = "0x14CE410", Length = "0x24")]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.WebRequestPrefixElement", Member = "get_Creator", ReturnType = "System.Net.IWebRequestCreate")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyNodeTypeHandlerBase", Member = "CreateNodeTypeHandlerFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[Token(Token = "0x6000D31")]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture) { }

	[Address(RVA = "0x14CF280", Offset = "0x14CE480", Length = "0x23E")]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D32")]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes) { }

	[Address(RVA = "0x14CF4C0", Offset = "0x14CE6C0", Length = "0x2A")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ChannelServices), Member = "CreateProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.TableConversions", Member = "ConvertTableToArrayOfGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), "MoonSharp.Interpreter.Table"}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[Token(Token = "0x6000D33")]
	public static object CreateInstance(Type type, Object[] args) { }

	[Address(RVA = "0x14CF240", Offset = "0x14CE440", Length = "0x2A")]
	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[Token(Token = "0x6000D34")]
	public static object CreateInstance(Type type, Object[] args, Object[] activationAttributes) { }

	[Address(RVA = "0x14CF4F0", Offset = "0x14CE6F0", Length = "0xD")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000D35")]
	public static object CreateInstance(Type type) { }

	[Address(RVA = "0x14CF270", Offset = "0x14CE470", Length = "0xB")]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "LookupProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000D36")]
	public static object CreateInstance(Type type, bool nonPublic) { }

	[Address(RVA = "0x14CF060", Offset = "0x14CE260", Length = "0x1A1")]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D37")]
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	[Address(RVA = "0x608CF0", Offset = "0x607EF0", Length = "0x17F")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&"}, ReturnType = "TStyleValue")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword&"}, ReturnType = "TStyleValue")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumAttributeDescription`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "CreateClassInstance", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.InputForUI.Event", Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D38")]
	public static T CreateInstance() { }

}

