namespace MoonSharp.Interpreter.Interop.UserDataRegistries;

[Token(Token = "0x2000112")]
internal class ExtensionMethodsRegistry
{
	[CompilerGenerated]
	[Token(Token = "0x2000114")]
	private sealed class <>c
	{
		[Token(Token = "0x400045D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400045E")]
		public static Func<MethodInfo, Boolean> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x34E780", Offset = "0x34D980", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A74")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A75")]
		public <>c() { }

		[Address(RVA = "0x313B60", Offset = "0x312D60", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A76")]
		internal bool <RegisterExtensionType>b__5_0(MethodInfo _mi) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000115")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400045F")]
		public Type extendedType; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A77")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x34E4F0", Offset = "0x34D6F0", Length = "0x135")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A78")]
		internal bool <GetExtensionMethodsByNameAndType>b__0(IOverloadableMemberDescriptor d) { }

	}

	[Token(Token = "0x2000113")]
	private class UnresolvedGenericMethod
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400045A")]
		public readonly MethodInfo Method; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400045B")]
		public readonly InteropAccessMode AccessMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400045C")]
		public readonly HashSet<Type> AlreadyAddedTypes; //Field offset: 0x20

		[Address(RVA = "0x34EA20", Offset = "0x34DC20", Length = "0xA4")]
		[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A73")]
		public UnresolvedGenericMethod(MethodInfo mi, InteropAccessMode mode) { }

	}

	[Token(Token = "0x4000456")]
	private static object s_Lock; //Field offset: 0x0
	[Token(Token = "0x4000457")]
	private static MultiDictionary<String, IOverloadableMemberDescriptor> s_Registry; //Field offset: 0x8
	[Token(Token = "0x4000458")]
	private static MultiDictionary<String, UnresolvedGenericMethod> s_UnresolvedGenericsRegistry; //Field offset: 0x10
	[Token(Token = "0x4000459")]
	private static int s_ExtensionMethodChangeVersion; //Field offset: 0x18

	[Address(RVA = "0x338450", Offset = "0x337650", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A72")]
	private static ExtensionMethodsRegistry() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A71")]
	public ExtensionMethodsRegistry() { }

	[Address(RVA = "0x3372C0", Offset = "0x3364C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A6B")]
	private static object FrameworkGetMethods() { }

	[Address(RVA = "0x3378B0", Offset = "0x336AB0", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiDictionary`2), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = "System.Collections.Generic.IEnumerable`1<V>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000A6C")]
	public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name) { }

	[Address(RVA = "0x337300", Offset = "0x336500", Length = "0x5AA")]
	[CalledBy(Type = typeof(UserData), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiDictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExtensionMethodsRegistry), Member = "InstantiateMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExtensionMethodsRegistry), Member = "GetGenericMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(MultiDictionary`2), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = "System.Collections.Generic.IEnumerable`1<V>")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A6E")]
	public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType) { }

	[Address(RVA = "0x337A20", Offset = "0x336C20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A6D")]
	public static int GetExtensionMethodsChangeVersion() { }

	[Address(RVA = "0x337A70", Offset = "0x336C70", Length = "0x292")]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetAllImplementedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000A70")]
	private static Type GetGenericMatch(Type extensionType, Type extendedType) { }

	[Address(RVA = "0x337D10", Offset = "0x336F10", Length = "0x117")]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A6F")]
	private static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType) { }

	[Address(RVA = "0x337E30", Offset = "0x337030", Length = "0x611")]
	[CalledBy(Type = typeof(UserData), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(UnresolvedGenericMethod), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = "CheckMethodIsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(MultiDictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K", "V"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000A6A")]
	public static void RegisterExtensionType(Type type, InteropAccessMode mode = 7) { }

}

